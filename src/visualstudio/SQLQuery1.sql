ALTER TABLE reservas
  DROP COLUMN dataregisto

ALTER TABLE reservas
  ADD dataregisto DATE DEFAULT(Getdate());

CREATE TABLE reservas2
  (
     idref        INT IDENTITY PRIMARY KEY,
     rfid         INT CONSTRAINT fkutentesreservas REFERENCES utentes(rfid),
     tipo         VARCHAR(50),
     dataregisto  DATE DEFAULT(Getdate(
