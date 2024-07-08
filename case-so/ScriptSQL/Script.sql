-- Script de criação da tabela -> Clientes
CREATE TABLE Clientes (
	ClienteId INT PRIMARY KEY IDENTITY(1,1),
	Nome VARCHAR(100) NOT NULL,
	Email VARCHAR(100) NOT NULL,
);

-- Script de criação da tabela -> Pedidos
CREATE TABLE Pedidos (
	PedidoId INT PRIMARY KEY IDENTITY (1,1),
	ClienteId INT NOT NULL,
	DataPedido DATETIME NOT NULL,
	ValorTotal DECIMAL(18,4) NOT NULL,
	FOREIGN KEY (ClienteId) REFERENCES Clientes(ClienteId)
);