void printHex(byte *buffer, byte bufferSize) 
{
    for (byte i = 0; i < bufferSize; i++) 
    {
      //Serial.print(buffer[i]);
        //Serial.print(buffer[i] < 0x10 ? " 0" : " ");  //se buffer[i]<16 " 0" se >16 entao " "
        //Serial.print(buffer[i], HEX); // buffer[i] é decimal e Hex passa-o a hexadecimal
        //Serial.print("  ");
        
        cliente = cliente + buffer[i]; // soma de todos os arrays buffer
 
    }
}
