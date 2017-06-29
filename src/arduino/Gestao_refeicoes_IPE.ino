#include <SPI.h>
#include <MFRC522.h>
#include <Wire.h>
#include <LiquidCrystal_I2C.h>
#include <DS3231.h>
#include <SD.h>

#define SS_PIN 53
#define RST_PIN 5
#define REQ_BUF_SZ 20

MFRC522 rfid(SS_PIN, RST_PIN);
MFRC522::MIFARE_Key key;

LiquidCrystal_I2C lcd(0x27, 16, 2);

DS3231 Clock;

byte mac[] = {0x90, 0xA2, 0xDA, 0x0D, 0x96, 0xDE};
File webFile;
char HTTP_req[REQ_BUF_SZ] = {0};
char req_index = 0;

bool h12;
bool PM;
bool Century = false;

byte nuidPICC[3];
int cliente = 0;
const int pinSD = 4;
String nome_do_cliente;
const int redledpin = 2;
const int greenledpin = 3;

void setup()
{
  Serial.begin(9600);
  SPI.begin();
  rfid.PCD_Init();
  Wire.begin();

  pinMode(2, OUTPUT);
  pinMode(3, OUTPUT);

  for (byte i = 0; i < 6; i++)
  {
    key.keyByte[i] = 0xFF;
  }

  lcd.begin();

  lcd.backlight();
  lcd.setCursor(4, 0);
  lcd.print("MAQUINA");
  lcd.setCursor(3, 1);
  lcd.print("ACTIVADA");
  delay(3000);

  while (!SD.begin(pinSD))
  {
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("SD --> Falhou");
    delay(500);
  }

  lcd.clear();
  lcd.setCursor(0, 0);
  lcd.print("SD --> OK");
  delay(1500);

  if (SD.exists("REGISTO.txt"))
  {
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("REGISTO --> OK");
    delay(1500);
  }
  else
  {
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("REGISTO -> FALHOU");
    delay(1500);
  }

  if (SD.exists("index.htm"))
  {
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("INDEX --> OK");
    delay(1500);
  }
  else
  {
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("INDEX --> FALHOU");
    delay(1500);
  }
}

void loop()
{

  if (!SD.exists("REGISTO.txt"))
  {
    Serial.println("Cartao de memoria --> Falhou");
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("SD --> Falhou");
    pinMode(7, OUTPUT);
    digitalWrite(7, LOW);
    delay(500);
  }

  lcd.clear();
  lcd.setCursor(3, 0);

  lcd.print("29");
  lcd.print(" de ");
  lcd.print("Junho");
  lcd.setCursor(5, 1);
  lcd.print(Clock.getHour(h12, PM), DEC);
  lcd.print(":");
  lcd.print(Clock.getMinute(), DEC);
  delay(1000);

  if (!rfid.PICC_IsNewCardPresent())
    return;

  if (!rfid.PICC_ReadCardSerial())
    return;

  if (rfid.uid.uidByte[0] != nuidPICC[0] ||
      rfid.uid.uidByte[1] != nuidPICC[1] ||
      rfid.uid.uidByte[2] != nuidPICC[2] ||
      rfid.uid.uidByte[3] != nuidPICC[3])
  {

    digitalWrite(greenledpin, HIGH);
    delay(300);
    digitalWrite(greenledpin, LOW);
    tone(6, 262, 300);
    delay(300);

    for (byte i = 0; i < 4; i++)
    {
      nuidPICC[i] = rfid.uid.uidByte[i];
    }

    /*for(int i=0;i<3;i++){
    Serial.print(nuidPICC[1]);
    }*/
    printHex(rfid.uid.uidByte, rfid.uid.size);

    Serial.println();

    nome_do_cliente = busca_nome(cliente);
    saida_monitor();
    saida_display();
    clientes_SD();

    cliente = 0;
  }

  else
  {
    digitalWrite(redledpin, HIGH);
    delay(300);
    digitalWrite(redledpin, LOW);
    tone(6, 262, 300);
    delay(300);
    tone(6, 196, 400);
    delay(400);
    delay(2000);

    lcd.backlight();
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("cartao lido ");
    delay(1000);
  }

  rfid.PICC_HaltA();
  rfid.PCD_StopCrypto1();
}
