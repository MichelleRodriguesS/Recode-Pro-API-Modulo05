CREATE DATABASE imperiohotel;
USE imperiohotel;

CREATE TABLE Cliente (
    idCliente INTEGER PRIMARY KEY auto_increment,
    nome VARCHAR(30),
    cpf VARCHAR(15),
    nascimento VARCHAR(30),
    telefone VARCHAR(30),

);


CREATE TABLE Compra (
    id_compra INTEGER PRIMARY KEY auto_increment,
     VARCHAR(30),
    data DATE,
    idCliente INTEGER,
    formadepagamento varchar (30)
    FOREIGN KEY (idCliente) references Cliente (idCliente),
    id_destino INTEGER,
    FOREIGN KEY (id_destino) references Destinos (id_destino)
);

Create Table Destino (
    id_destino INTEGER PRIMARY KEY auto_increment varchar(30),
    cidade varchar (30),
    estado varchar (4),
    aeroporto varchar(6),


);






