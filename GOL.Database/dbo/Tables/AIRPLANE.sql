create table AIRPLANE(
id int IDENTITY(1,1) NOT NULL,
codigo_do_aviao bigint not null,
modelo nvarchar(50),
qtd_passageiros int,
dt_criacao_registro smalldatetime
PRIMARY KEY(id)
);

