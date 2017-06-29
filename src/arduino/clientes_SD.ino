void clientes_SD()
{
  File dataFile = SD.open("LOG.txt", FILE_WRITE);

  dataFile.print(cliente);
  dataFile.print("       ");
  dataFile.print(nome_do_cliente);
  for (int i = 0; i < (30 - nome_do_cliente.length()); i++)
  {
    dataFile.print(" ");
  }

  dataFile.print("29");
  dataFile.print(" de ");
  dataFile.print("Junho");
  dataFile.print(" ");
  dataFile.print(Clock.getHour(h12, PM), DEC);
  dataFile.print(":");
  dataFile.print(Clock.getMinute(), DEC);
  dataFile.close();

  File registoFile = SD.open("REGISTO.txt", FILE_WRITE);
  registoFile.println();
  registoFile.print(cliente);
  registoFile.print(";");
  registoFile.print(nome_do_cliente);
  registoFile.print(";");

  registoFile.print("29");
  registoFile.print(" de ");
  registoFile.print("Junho");
  registoFile.print(";");
  registoFile.print(Clock.getHour(h12, PM), DEC);
  registoFile.print(":");
  registoFile.print(Clock.getMinute(), DEC);

  registoFile.close();
}
