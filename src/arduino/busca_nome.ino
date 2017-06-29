String busca_nome(int abc)
{
  switch (abc)
  {
  case 372:
    return "A.P.Oliveira";
    break;

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
  {
    for (int a = 0; a < 4; a++)
    {
      tone(8, 1000, 500);
      delay(500);
      digitalWrite(redledpin, HIGH);
      delay(50);
      digitalWrite(redledpin, LOW);
    }
    lcd.backlight();
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("!!DESCONHECIDO!! ");
    digitalWrite(redledpin, HIGH);
    delay(3000);
    digitalWrite(redledpin, LOW);
    return "Desconhecido";
  }
  }
}
