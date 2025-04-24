USE [TEST1]

CREATE TABLE Wydawnictwo(
ID_wydawnictwo INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
Nazwa VARCHAR(255) NOT NULL,
Data_zalozenia DATE NOT NULL);

INSERT INTO Wydawnictwo(Nazwa, Data_zalozenia) VALUES
('Wydawnictwo1', '01-01-2020');

CREATE TABLE Gatunek(
ID_gatunek INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
Nazwa VARCHAR(255) NOT NULL);

INSERT INTO Gatunek(Nazwa) VALUES
('Science fiction');

CREATE TABLE Status_ksiazki(
ID_status INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
Info_status VARCHAR(20) NOT NULL);

INSERT INTO Status_ksiazki(Info_status) VALUES
('Dostępna'),
('Niedostępna');

CREATE TABLE Autor(
ID_autor INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
Imie_autor VARCHAR(50) NOT NULL,
Nazwisko_autor VARCHAR(100) NOT NULL,
Kraj_pochodzenia VARCHAR(200));

INSERT INTO Autor(Imie_autor, Nazwisko_autor, Kraj_pochodzenia) VALUES
('Jan', 'Brzechwa', 'Polska');


CREATE TABLE Rola(
ID_rola INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
Nazwa_roli VARCHAR(100) NOT NULL);

INSERT INTO Rola (Nazwa_roli) VALUES
('Admin'),
('Użytkownik'),
('Gość'),
('Bibliotekarz'),
('Menager Biblioteki');


CREATE TABLE Adres(
ID_adres INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
Kraj VARCHAR(255) NOT NULL,
Miejscowosc VARCHAR(255) NOT NULL,
Kod_pocztowy VARCHAR(6) NOT NULL,
Ulica VARCHAR(255) NOT NULL,
Numer_ulicy Varchar(10) NOT NULL,
Numer_lokalu VARCHAR(10));

INSERT INTO Adres(Kraj,Miejscowosc,Kod_pocztowy,Ulica,Numer_ulicy,Numer_lokalu) VALUES
('Polska', 'Łódź', '91-344','Mackiewicza', '44', null);




CREATE TABLE Ksiazka(
ID_ksiazka INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
Tytul VARCHAR(255) NOT NULL,
Rok_wydania DATE NOT NULL,
FK_ID_wydawnictwo INT NOT NULL FOREIGN KEY REFERENCES Wydawnictwo(ID_wydawnictwo),
Data_zakupu DATE NOT NULL,
Gatunek INT NOT NULL FOREIGN KEY REFERENCES Gatunek(ID_gatunek),
Liczba_stron INT NOT NULL,
Liczba_sztuk INT NOT NULL,
Cena MONEY NOT NULL,
Opis TEXT NOT NULL,
FK_ID_status INT NOT NULL FOREIGN KEY REFERENCES Status_ksiazki(ID_status));

INSERT INTO Ksiazka(Tytul,Rok_wydania,FK_ID_wydawnictwo,Data_zakupu,Gatunek, Liczba_stron, Liczba_sztuk,Cena, Opis, FK_ID_status) values
('Tytul123', '1908', '1', '01-01-2020', '1','100','5','50','fajna','1');

CREATE TABLE Ksiazka_autor(
ID_ksiazka_autor INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
FK_ID_autor INT NOT NULL FOREIGN KEY REFERENCES Autor(ID_autor),
FK_ID_ksiazka INT NOT NULL FOREIGN KEY REFERENCES Ksiazka(ID_ksiazka));

insert into Ksiazka_autor(FK_ID_ksiazka,FK_ID_autor) values
('1','1');




CREATE TABLE Uzytkownik(
ID_uzytkownik INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
Imie VARCHAR(100) NOT NULL,
Nazwisko VARCHAR(200) NOT NULL,
Plec INT Not NULL,
Data_urodzenia DATE NOT NULL,
PESEL VARCHAR(11) UNIQUE NOT NULL,
Numer_telefonu VARCHAR(9) NOT NULL,
Login_uzytkownika VARCHAR(100) UNIQUE NOT NULL,
Haslo VARCHAR(100) NOT NULL,
Email VARCHAR(255) NOT NULL UNIQUE CHECK (email LIKE '%_@_%._%'),
FK_ID_rola INT NOT NULL FOREIGN KEY REFERENCES Rola(ID_Rola),
FK_ID_adres INT NOT NULL FOREIGN KEY REFERENCES Adres(ID_Adres),
Czy_zapomniany BIT NOT NULL DEFAULT 0 -- Domyœlnie uzytkownik jest nieaktywny (0).
);

insert into Uzytkownik (Imie,Nazwisko,Plec, Data_urodzenia,PESEL,Numer_telefonu, Login_uzytkownika,Haslo, Email, FK_ID_rola,FK_ID_adres,Czy_zapomniany) Values
('Admin','Admin','2', '01-01-2000', '00210127618', '234567890','Admin1','Admin!23','admin@gmail.com', '1', '1','1');

CREATE TABLE Rejestracja(
ID_Rejestr INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
FK_ID_ksiazka INT NOT NULL FOREIGN KEY REFERENCES Ksiazka(ID_ksiazka),
FK_ID_uzytkownik INT NOT NULL FOREIGN KEY REFERENCES Uzytkownik(ID_Uzytkownik),
Data_Rejestracji DATETIME NOT NULL DEFAULT GETDATE());
insert into Rejestracja(FK_ID_ksiazka,FK_ID_uzytkownik) values
('1','1');


CREATE TABLE Zapominany(
ID_zapominany INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
FK_ID_uzytkownik INT NOT NULL FOREIGN KEY REFERENCES Uzytkownik(ID_Uzytkownik),
Data_zapomnienia DATETIME NOT NULL DEFAULT GETDATE(),
Zglaszacz INT NOT NULL FOREIGN KEY REFERENCES Uzytkownik(ID_Uzytkownik));
