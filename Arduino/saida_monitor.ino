void saida_monitor(){
  Serial.println(cliente);
  Serial.println(nome_do_cliente);
  //Serial.print(Clock.getDate(), DEC);
  Serial.print("29");
  Serial.print(" de ");
  Serial.print("Junho");
  Serial.print(" - ");
  Serial.print(Clock.getHour(h12, PM), DEC);
  Serial.print(":");
  Serial.print(Clock.getMinute(), DEC);
}

