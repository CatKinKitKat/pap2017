/*
 * Gestão de Refeições do IPE
 */
// 
//

#include <SPI.h>                 // biblioteca do I2C
#include <MFRC522.h>             // biblioteca do sensor RFID
#include <Wire.h>                // biblioteca do wire (por causa do display-to-i2c
#include <LiquidCrystal_I2C.h>   // biblioteca do display
#include <DS3231.h>              // biblioteca do RTC
#include <SD.h>                  // biblioteca do cartao de memoria

#define SS_PIN 53
#define RST_PIN 5


MFRC522 rfid(SS_PIN, RST_PIN);        // Instance of the class
MFRC522::MIFARE_Key key;
LiquidCrystal_I2C lcd(0x27, 16, 2);   // set the LCD address to 0x27 for a 16 chars and 2 line display
//DS3231  rtc(SDA, SCL);                // Init the DS3231 using the hardware interface
DS3231 Clock;
//Time t;

////////////////////////////////////SERVIDOR/////////////////////////////////////
#define REQ_BUF_SZ   20
byte mac[] = { 0x90, 0xA2, 0xDA, 0x0D, 0x96, 0xDE };
File webFile;
char HTTP_req[REQ_BUF_SZ] = {0}; // buffered HTTP request stored as null terminated string
char req_index = 0;              // index into HTTP_req buffer

bool h12;
bool PM;
bool Century=false;

//int mt = Clock.getMonth(Century);


/////////////////////////////////////////////////////////////////////////////////

byte nuidPICC[3];        // Array inicial que vai guardar um novo NUID
int cliente = 0;
const int pinSD = 4;
String nome_do_cliente;
const int redledpin = 2;
const int greenledpin = 3;


void setup()
{
  Serial.begin(9600);   // Inicializa a comunicação serial
  SPI.begin();          // Inicializa o SPI bus
  rfid.PCD_Init();      // Inicializa o sensor MFRC522
  Wire.begin();          // Initialize the rtc object
  
  pinMode (2, OUTPUT);
  pinMode (3, OUTPUT);



  for (byte i = 0; i < 6; i++)
  { 
    key.keyByte[i] = 0xFF;
  }

  lcd.begin();                      // initialize the lcd
  // Print a message to the LCD.
  lcd.backlight();
  lcd.setCursor(4, 0); //(coluna, linha)
  lcd.print("MAQUINA");
  lcd.setCursor(3, 1);
  lcd.print("ACTIVADA");
  delay(3000);
  //see if the card is present and can be initialized:
  while (!SD.begin(pinSD))
  {
    lcd.clear();
    lcd.setCursor(0, 0); //(coluna, linha)
    lcd.print("SD --> Falhou");
    delay(500);

  }

  lcd.clear();
  lcd.setCursor(0, 0); //(coluna, linha)
  lcd.print("SD --> OK");
  delay(1500);


  if (SD.exists("REGISTO.txt"))
  {
    lcd.clear();
    lcd.setCursor(0, 0); //(coluna, linha)
    lcd.print("REGISTO --> OK");
    delay(1500);
  }
  else
  {
    lcd.clear();
    lcd.setCursor(0, 0); //(coluna, linha)
    lcd.print("REGISTO -> FALHOU");
    delay(1500);
  }

  if (SD.exists("index.htm"))
  {
    lcd.clear();
    lcd.setCursor(0, 0); //(coluna, linha)
    lcd.print("INDEX --> OK");
    delay(1500);
  }
  else
  {
    lcd.clear();
    lcd.setCursor(0, 0); //(coluna, linha)
    lcd.print("INDEX --> FALHOU");
    delay(1500);
  }
  
} // fim do setup

/////////////////////////////////////////////LOOOOOOOOOOOOOOOOOOOOOOP///////////////////////////////////////////////////////

void loop() 
{

  if (!SD.exists("REGISTO.txt"))
  {
      Serial.println("Cartao de memoria --> Falhou");
    lcd.clear();
    lcd.setCursor(0, 0); //(coluna, linha)
    lcd.print("SD --> Falhou");
    pinMode (7, OUTPUT);
    digitalWrite(7, LOW);    // os pins por norma estão a HIGH
    delay(500);

  }
 
    
    // mantem a hora no display enquanto nao for nenhum cartao lido
    lcd.clear();
    lcd.setCursor(3, 0);
    //lcd.print(Clock.getDate(), DEC);
    lcd.print("29");
    lcd.print(" de ");
    lcd.print("Junho");
    lcd.setCursor(5, 1);
    lcd.print(Clock.getHour(h12, PM), DEC);
    lcd.print(":");
    lcd.print(Clock.getMinute(), DEC);
    delay (1000);

    // Em modo de leitura
    if ( ! rfid.PICC_IsNewCardPresent())  // estas funções vêm da biblioteca MFRC522.h
      return;

    // verifica se um cartão (NUID) foi lido
    if ( ! rfid.PICC_ReadCardSerial())    // estas funções vêm da biblioteca MFRC522.h
      return;


    if (rfid.uid.uidByte[0] != nuidPICC[0] || // Faz com que seja impossivel ler o mesmo o
        rfid.uid.uidByte[1] != nuidPICC[1] || // cartão 2x seguidas ao procurar um cartao novo
        rfid.uid.uidByte[2] != nuidPICC[2] ||
        rfid.uid.uidByte[3] != nuidPICC[3] )
    {


      digitalWrite(greenledpin, HIGH);            // liga o led verde
      delay(300);                                 // espera 300 milisegundos
      digitalWrite(greenledpin, LOW);             // apaga o led verde
      tone(6, 262, 300);                          // sinal sonoro de OK
      delay (300);

      // Guarda o NUID dentro do nuidPICC array
      for (byte i = 0; i < 4; i++)
      {
        nuidPICC[i] = rfid.uid.uidByte[i];    // Guarda o numero NUID em parcelas FF FF FF FF em numero hexadecima
      }                                       //fim do for

      /*for(int i=0;i<3;i++){
      Serial.print(nuidPICC[1]);
      }*/
      printHex(rfid.uid.uidByte, rfid.uid.size); // escreve o numero NUID em hexadecimal no monitor serial da função printHex
      
      Serial.println(); //baixa de linha entre NUID e cliente


      nome_do_cliente = busca_nome(cliente); // a String nome do cliente vai ser igual ao resultado da função
      // busca_nome que tem o "cliente" como objeto

      saida_monitor();     // mostra no monitor as informações

      saida_display();      // mostra no display as informações

      clientes_SD();        // guarda no cartao SD os registos


      //if (cliente == 666);

      cliente = 0; // volta a colocar cliente=0 para ser lido outro cartão. Tem q ser sempre a ultima coisa no no final do if

    } // fim do if

    else
    {
      digitalWrite( redledpin, HIGH);
      delay(300);                                 // espera 300 milisegundos
      digitalWrite(redledpin, LOW);               // apaga o led vermelho
      tone(6, 262, 300);                      // com a avisar que o cartao foi lido 2x seguidas
      delay (300);
      tone(6, 196, 400);
      delay (400);
      delay(2000);

      lcd.backlight();                     // liga o display
      lcd.clear();                         // Limpa o display
      lcd.setCursor(0, 0);                 // Estabelece onde começa a frase
      lcd.print("cartao lido ");
      delay(1000);

    }


    rfid.PICC_HaltA();                // Halt PICC
    rfid.PCD_StopCrypto1();           // Stop encryption on PCD
 



}



