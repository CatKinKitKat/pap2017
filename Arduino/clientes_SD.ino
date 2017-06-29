void clientes_SD()
{
  File dataFile = SD.open("LOG.txt", FILE_WRITE); // a variavel dataFile vai adquirir o valor de LOG.txt na função de escrita

  dataFile.print(cliente);
  dataFile.print("       ");
  dataFile.print(nome_do_cliente);
  for (int i = 0; i < (30 - nome_do_cliente.length()); i++) // para acertar o nr de espaços em branco no ficheiro LOG
  {
    dataFile.print(" ");
  }
  //dataFile.print(Clock.getDate(), DEC);
  dataFile.print("29");
  dataFile.print(" de ");
  dataFile.print("Junho");
  dataFile.print(" ");
  dataFile.print(Clock.getHour(h12, PM), DEC);
  dataFile.print(":");
  dataFile.print(Clock.getMinute(), DEC);
  dataFile.close();

  // guarda no cartao SD os registos para o excel
  File registoFile = SD.open("REGISTO.txt", FILE_WRITE); 
  registoFile.println();
  registoFile.print(cliente);
  registoFile.print(";");
  registoFile.print(nome_do_cliente);
  registoFile.print(";");
  //registoFile.print(Clock.getDate(), DEC);
  registoFile.print("29");
  registoFile.print(" de ");
  registoFile.print("Junho");
  registoFile.print(";");
  registoFile.print(Clock.getHour(h12, PM), DEC);
  registoFile.print(":");
  registoFile.print(Clock.getMinute(), DEC);;
  registoFile.close();

}// fim do void



