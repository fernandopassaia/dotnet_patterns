CREATE DATABASE Studentsdb;

USE Studentsdb;

DROP TABLE IF EXISTS `Students`;

Create Table `Students` (
    `StudentId` INT AUTO_INCREMENT,
    `Name` varchar(80) NOT NULL,
    `Email` varchar(100) NOT NULL,
    PRIMARY KEY (`StudentId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
    
LOCK TABLES `Students` WRITE;
    insert into `Students` Values (1,'Fernando Passaia', 'fernandopassaia@futuradata.com.br');
    insert into `Students` Values (2,'Jaqueline Guimaraes', 'jaque@futuradata.com.br');
    insert into `Students` Values (3,'Hubinha Guimaraes Passaia', 'hubinha@ossinho.com');
UNLOCK TABLES;