

create trigger reserva
on reservas 
for  insert
as
begin
  
   declare @idref float, @pu float, @saldo float, @rfid int ,@tipo varchar(50),  @dataregisto date, @datarefeicao date;
   select @rfid=rfid, @tipo=tipo ,@dataregisto =dataregisto, @datarefeicao=datarefeicao from inserted;
   select top 1 @pu=precoRefeicao from variaveis;
   update utentes set saldo = (saldo -  @pu ) where rfid = @rfid ;
end


