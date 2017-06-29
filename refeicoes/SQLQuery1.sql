
alter table reservas drop column  dataregisto
alter table reservas add dataregisto date default(getdate());



create table reservas2 (
 idref int identity primary key,
 rfid int constraint fkutentesreservas references utentes(rfid),
 tipo varchar(50),
 dataregisto date default(getdate()),
 datarefeicao date default(dateadd(day,1,getdate()))

)

sp_rename reservas2 ,reservas