create database db_gem;
use db_gem;

CREATE TABLE Instrumentos (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome_instrumento VARCHAR(100) NOT NULL UNIQUE,
    quantidade_maxima INT NOT NULL
);

-- Tabela de Alunos
CREATE TABLE Alunos (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    cpf VARCHAR(14) UNIQUE NOT NULL,
    dt_cadastro DATE NOT NULL,
    dt_nascimento DATE NOT NULL,
    telefone VARCHAR(20),
    email VARCHAR(100),
    cep VARCHAR(10),
    endereco VARCHAR(255),
    numero VARCHAR(10),
    bairro VARCHAR(100),
    cidade VARCHAR(100),
    estado VARCHAR(2),
    estado_civil VARCHAR(20),
    foto_perfil LONGBLOB,
    id_instrumento INT, 
    FOREIGN KEY (id_instrumento) REFERENCES Instrumentos(id)
);

-- Tabela de Professores (Sem relação com Alunos)
CREATE TABLE Professores (
    id_professor INT PRIMARY KEY AUTO_INCREMENT,
    nome_professor VARCHAR(255) NOT NULL,
    senha_professor VARCHAR(255) NOT NULL,
    perfil_professor varchar(15)
);

-- Tabela de Hinos
CREATE TABLE Hinos (
    id INT PRIMARY KEY AUTO_INCREMENT,
    numero_hino INT NOT NULL UNIQUE CHECK (numero_hino BETWEEN 1 AND 480),
    nome_hino VARCHAR(255) NOT NULL
);

-- Tabela Relacional para Hinos Passados pelos Alunos
CREATE TABLE Aluno_Hino (
    id_aluno INT,
    id_hino INT,
    data_passagem DATE NOT NULL,
    PRIMARY KEY (id_aluno, id_hino),
    FOREIGN KEY (id_aluno) REFERENCES Alunos(id),
    FOREIGN KEY (id_hino) REFERENCES Hinos(id)
);

-- Insert de Hinos --
INSERT INTO hinos (numero_hino, nome_hino) VALUES
(1, 'Cristo Meu Mestre'),
(2, 'De Deus tu és Eleita'),
(3, 'Faz-nos ouvir'),
(4, 'Ouve a nossa Oração'),
(5, 'A Rocha Relestial'),
(6, 'Glória ao Justo'),
(7, 'Quão Grande És Tu'),
(8, 'Oh! Vem Senhor'),
(9, 'Luminosa é a Senda'),
(10, 'Cristo o verbo'),
(11, 'Fala, Senhor'),
(12, 'Ao Único'),
(13, 'Vem Jesus'),
(14, 'Sou Feliz com Jesus'),
(15, 'Sublime Amor'),
(16, 'Promessa Excelente'),
(17, 'Em Jesus Tenho Alegria'),
(18, 'O Bom Consolador'),
(19, 'Descansa no Senhor'),
(20, 'Guia-me, ó Senhor'),
(21, 'Mais de Cristo'),
(22, 'Com Tua Mão'),
(23, 'Céu e Terra Louvem a Deus'),
(24, 'Efatá'),
(25, 'Em Espírito e em Verdade'),
(26, 'A Jesus Dai Louvor'),
(27, 'Nascer de Novo'),
(28, 'O Senhor É Meu Pastor'),
(29, 'O Senhor é Minha Luz'),
(30, 'Te Exaltamos'),
(31, 'Graça Maravilhosa'),
(32, 'Teu Sangue Me Lava'),
(33, 'Pelas Mãos de Jesus'),
(34, 'Aos Pés da Cruz'),
(35, 'Confia no Senhor'),
(36, 'Hosana nas Alturas'),
(37, 'Cristo, Nome Doce'),
(38, 'Ao Deus Eterno'),
(39, 'A Rocha Eterna'),
(40, 'O Cordeiro Triunfante'),
(41, 'Digno é o Cordeiro'),
(42, 'Luz do Mundo'),
(43, 'Desperta, Igreja'),
(44, 'A Última Trombeta'),
(45, 'Fé Inabalável'),
(46, 'Vivifica-me, Senhor'),
(47, 'Alvo Mais Que a Neve'),
(48, 'Glória a Ti, Jesus'),
(49, 'Eu Sei que Meu Redentor Vive'),
(50, 'Jesus Está Chamando'),
(51, 'O Nome de Jesus'),
(52, 'A Fonte Transbordante'),
(53, 'Santo Espírito'),
(54, 'Glorioso És Tu'),
(55, 'Cristo é o Rei'),
(56, 'Jesus é Meu Guia'),
(57, 'Amor Tão Grande'),
(58, 'Chamado por Deus'),
(59, 'Tocou-me'),
(60, 'Redenção em Cristo'),
(61, 'Tu És Santo'),
(62, 'Alegria Sem Fim'),
(63, 'Senhor, Eu Te Amo'),
(64, 'Majestade'),
(65, 'Em Teus Braços'),
(66, 'És Fiel, Senhor'),
(67, 'Caminho da Cruz'),
(68, 'Quero Ser um Vaso Novo'),
(69, 'O Grande Eu Sou'),
(70, 'Adorarei ao Cordeiro'),
(71, 'Cristo Reina'),
(72, 'Amigo Verdadeiro'),
(73, 'És o Meu Refúgio'),
(74, 'Rei dos Reis'),
(75, 'Senhor da Glória'),
(76, 'Eu Navegarei'),
(77, 'A Ele a Glória'),
(78, 'Grandioso és Tu'),
(79, 'Somente Crê'),
(80, 'Jesus, Minha Esperança'),
(81, 'Emanuel'),
(82, 'Deus de Aliança'),
(83, 'O Leão de Judá'),
(84, 'A Cruz Me Salvou'),
(85, 'Te Louvarei, Senhor'),
(86, 'Espírito de Vida'),
(87, 'És Minha Luz'),
(88, 'Sou Teu'),
(89, 'Reina em Mim'),
(90, 'Maravilhosa Graça'),
(91, 'Em Tua Presença'),
(92, 'Canta Minh’Alma'),
(93, 'Minha Fé Está em Ti'),
(94, 'Tudo Entregarei'),
(95, 'Ao Teu Nome'),
(96, 'Salvo por Jesus'),
(97, 'Glória ao Salvador'),
(98, 'Liberdade em Cristo'),
(99, 'Senhor do Meu Coração'),
(100, 'Sempre Fiel é o Senhor');

-- Insert Intrumentos --
INSERT INTO Instrumentos (nome_instrumento, quantidade_maxima) VALUES
('Violino', 10),
('Violoncelo', 5),
('Flauta', 4),
('Clarinete', 3),
('Trompete', 2),
('Saxofone', 1);

-- HINO PARA ALUNO DE ID 1--
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (1, 1, '2025-01-01');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (1, 2, '2025-01-02');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (1, 3, '2025-01-03');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (1, 4, '2025-01-04');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (1, 5, '2025-01-05');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (1, 6, '2025-01-06');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (1, 7, '2025-01-07');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (1, 8, '2025-01-08');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (1, 9, '2025-01-09');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (1, 10, '2025-01-10');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (1, 11, '2025-01-11');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (1, 12, '2025-01-12');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (1, 13, '2025-01-13');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (1, 14, '2025-01-14');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (1, 15, '2025-01-15');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (1, 16, '2025-01-16');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (1, 17, '2025-01-17');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (1, 18, '2025-01-18');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (1, 19, '2025-01-19');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (1, 20, '2025-01-20');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (1, 21, '2025-01-21');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (1, 22, '2025-01-22');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (1, 23, '2025-01-23');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (1, 24, '2025-01-24');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (1, 25, '2025-01-25');

-- HINO PARA ALUNO DE ID 2--
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 1, '2025-01-01');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 2, '2025-01-02');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 3, '2025-01-03');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 4, '2025-01-04');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 5, '2025-01-05');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 6, '2025-01-06');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 7, '2025-01-07');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 8, '2025-01-08');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 9, '2025-01-09');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 10, '2025-01-10');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 11, '2025-01-11');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 12, '2025-01-12');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 13, '2025-01-13');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 14, '2025-01-14');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 15, '2025-01-15');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 16, '2025-01-16');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 17, '2025-01-17');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 18, '2025-01-18');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 19, '2025-01-19');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 20, '2025-01-20');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 21, '2025-01-21');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 22, '2025-01-22');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 23, '2025-01-23');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 24, '2025-01-24');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 25, '2025-01-25');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 26, '2025-01-26');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 27, '2025-01-27');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 28, '2025-01-28');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 29, '2025-01-29');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 30, '2025-01-30');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 31, '2025-01-31');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 32, '2025-02-01');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 33, '2025-02-02');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 34, '2025-02-03');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 35, '2025-02-04');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 36, '2025-02-05');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 37, '2025-02-06');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 38, '2025-02-07');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 39, '2025-02-08');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 40, '2025-02-09');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 41, '2025-02-10');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 42, '2025-02-11');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 43, '2025-02-12');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 44, '2025-02-13');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 45, '2025-02-14');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 46, '2025-02-15');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 47, '2025-02-16');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 48, '2025-02-17');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 49, '2025-02-18');
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (2, 50, '2025-02-19');

-- HINOS PARA ALUNO DE ID 3 --
INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES
(3, 1, '2025-01-01'),
(3, 2, '2025-01-02'),
(3, 3, '2025-01-03'),
(3, 4, '2025-01-04'),
(3, 5, '2025-01-05'),
(3, 6, '2025-01-06'),
(3, 7, '2025-01-07'),
(3, 8, '2025-01-08'),
(3, 9, '2025-01-09'),
(3, 10, '2025-01-10'),
(3, 11, '2025-01-11'),
(3, 12, '2025-01-12'),
(3, 13, '2025-01-13'),
(3, 14, '2025-01-14'),
(3, 15, '2025-01-15'),
(3, 16, '2025-01-16'),
(3, 17, '2025-01-17'),
(3, 18, '2025-01-18'),
(3, 19, '2025-01-19'),
(3, 20, '2025-01-20'),
(3, 21, '2025-01-21'),
(3, 22, '2025-01-22'),
(3, 23, '2025-01-23'),
(3, 24, '2025-01-24'),
(3, 25, '2025-01-25'),
(3, 26, '2025-01-26'),
(3, 27, '2025-01-27'),
(3, 28, '2025-01-28'),
(3, 29, '2025-01-29'),
(3, 30, '2025-01-30'),
(3, 31, '2025-01-31'),
(3, 32, '2025-02-01'),
(3, 33, '2025-02-02'),
(3, 34, '2025-02-03'),
(3, 35, '2025-02-04'),
(3, 36, '2025-02-05'),
(3, 37, '2025-02-06'),
(3, 38, '2025-02-07'),
(3, 39, '2025-02-08'),
(3, 40, '2025-02-09'),
(3, 41, '2025-02-10'),
(3, 42, '2025-02-11'),
(3, 43, '2025-02-12'),
(3, 44, '2025-02-13'),
(3, 45, '2025-02-14'),
(3, 46, '2025-02-15'),
(3, 47, '2025-02-16'),
(3, 48, '2025-02-17'),
(3, 49, '2025-02-18'),
(3, 50, '2025-02-19'),
(3, 51, '2025-02-20'),
(3, 52, '2025-02-21'),
(3, 53, '2025-02-22'),
(3, 54, '2025-02-23'),
(3, 55, '2025-02-24'),
(3, 56, '2025-02-25'),
(3, 57, '2025-02-26'),
(3, 58, '2025-02-27'),
(3, 59, '2025-02-28'),
(3, 60, '2025-03-01'),
(3, 61, '2025-03-02'),
(3, 62, '2025-03-03'),
(3, 63, '2025-03-04'),
(3, 64, '2025-03-05'),
(3, 65, '2025-03-06'),
(3, 66, '2025-03-07'),
(3, 67, '2025-03-08'),
(3, 68, '2025-03-09'),
(3, 69, '2025-03-10'),
(3, 70, '2025-03-11'),
(3, 71, '2025-03-12'),
(3, 72, '2025-03-13'),
(3, 73, '2025-03-14'),
(3, 74, '2025-03-15'),
(3, 75, '2025-03-16'),
(3, 76, '2025-03-17'),
(3, 77, '2025-03-18'),
(3, 78, '2025-03-19'),
(3, 79, '2025-03-20'),
(3, 80, '2025-03-21'),
(3, 81, '2025-03-22'),
(3, 82, '2025-03-23'),
(3, 83, '2025-03-24'),
(3, 84, '2025-03-25'),
(3, 85, '2025-03-26'),
(3, 86, '2025-03-27'),
(3, 87, '2025-03-28'),
(3, 88, '2025-03-29'),
(3, 89, '2025-03-30'),
(3, 90, '2025-03-31'),
(3, 91, '2025-04-01'),
(3, 92, '2025-04-02'),
(3, 93, '2025-04-03'),
(3, 94, '2025-04-04'),
(3, 95, '2025-04-05'),
(3, 96, '2025-04-06'),
(3, 97, '2025-04-07'),
(3, 98, '2025-04-08'),
(3, 99, '2025-04-09'),
(3, 100, '2025-04-10');
