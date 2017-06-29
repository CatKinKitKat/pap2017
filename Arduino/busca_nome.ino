// este int abc é so para a função saber o que vai alterar. pode ser qlq nome. porque no void já se disse que vai ler
// a variável in cliente. é uma função do tipo String porque é o tipo de variável que retorna. se fosse void () nao retornava nada

String busca_nome (int abc)
{
  switch (abc)
  {
    case 372:
      return "A.P.Oliveira";
      break; // utiliza-se o break para evitar perda de tempo no programa a ler os outros "case"

   case 580:
      return "E.Ferreira";
      break;
      
    case 606:
      return "A.Oliveira";
      break;

    case 722:
      return "H.Almeida";
      break;

    case 724:
      return "José Neves";
      break;

    case 786:
      return "Carlos C.";
      break;

    case 678:
      return "Francisco S.";
      break;

    default:
      { for (int a = 0; a < 4; a++)
        {
          tone(8, 1000, 500);
          delay (500);
          digitalWrite( redledpin, HIGH);
        delay(50);
        digitalWrite(redledpin, LOW);
        }
        lcd.backlight();                     // liga o display
        lcd.clear();                         // Limpa o display
        lcd.setCursor(0, 0);                 // Estabelece onde começa a frase
        lcd.print("!!DESCONHECIDO!! ");
        digitalWrite( redledpin, HIGH);
        delay(3000);
        digitalWrite(redledpin, LOW);
        return "Desconhecido";
       // pinMode (7, OUTPUT);
       // digitalWrite(7, LOW);    // os pins por norma estão a HIGH
      }
  }
}
