CREATE TRIGGER reserva
ON reservas
FOR INSERT
AS
  BEGIN
      DECLARE @idref        FLOAT,
              @pu           FLOAT,
              @saldo        FLOAT,
              @rfid         INT,
              @tipo         VARCHAR(50),
              @dataregisto  DATE,
              @datarefeicao DATE;

      SELECT @rfid = rfid,
             @tipo = tipo,
             @dataregisto = dataregisto,
             @datarefeicao = datarefeicao
      FROM   inserted;

      SELECT TOP 1 @pu = precorefeicao
      FROM   variaveis;

      UPDATE utentes
      SET    saldo = ( saldo - @pu )
      WHERE  rfid = @rfid;
  END
