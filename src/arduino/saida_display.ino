void saida_display()
{
  lcd.begin();

  lcd.backlight();
  lcd.setCursor(0, 0);
  lcd.print("RFID:");
  lcd.setCursor(12, 0);
  lcd.print(cliente);
  lcd.setCursor(0, 1);
  lcd.print("Nome: ");
  lcd.print(nome_do_cliente);
  delay(2000);
  lcd.clear();
  lcd.setCursor(3, 0);

  lcd.print("29");
  lcd.print(" de ");
  lcd.print("Junho");
  lcd.setCursor(5, 1);
  lcd.print(Clock.getHour(h12, PM), DEC);
  lcd.print(":");
  lcd.print(Clock.getMinute(), DEC);
  delay(1500);
  lcd.clear();
  lcd.setCursor(0, 0);
  lcd.print("cartao lido");
  lcd.setCursor(1, 1);
  lcd.print("Obrigado");
  delay(1500);
}
