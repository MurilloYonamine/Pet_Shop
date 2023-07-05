-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 05-Jul-2023 às 22:11
-- Versão do servidor: 10.4.27-MariaDB
-- versão do PHP: 8.1.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `bdpetshop_ti93`
--

DELIMITER $$
--
-- Procedimentos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_AtualizarInserirAdocao` (`pCodigoFuncionario` INT(11), `pCodigoCliente` INT(11), `pCodigoPet` INT(11), `pData` DATE)   BEGIN
-- =============================================
-- Autor: Murillo Gomes Yonamine
-- Data: 30/06
-- Descrição: Inserir dados na tb_adocao e depois atualizar a tb_animal.
-- =============================================

-- Comandos do CRUD
	INSERT INTO tb_adocao
    (AdoAnCodigo, AdoFnCodigo, AdoClCodigo, AdoData)
    VALUE(pCodigoPet, pCodigoFuncionario, pCodigoCliente, pData);

	UPDATE tb_animal
    SET AnClCodigo = pCodigoCliente
    WHERE AnCodigoPet = pCodigoPet;

-- Fim da execução do comando
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_AtualizarLogon` (IN `pUsuario` VARCHAR(30), IN `pStatus` INT(11))   BEGIN
-- =============================================
-- Autor: Murillo
-- Data: 29/06
-- Descrição: Atualizar o status de logon e data.
-- =============================================

 

    -- Comandos do CRUD
    UPDATE tb_usuario SET UserLogado = pStatus, UserDataAcesso = CURRENT_TIMESTAMP()
    WHERE UserLogin = pUsuario; 
    
    SELECT * FROM tb_usuario;

 

-- Fim da execução do comando
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_InserirSubtrair` (IN `pEsCodigo` INT(11), IN `pFnCodigo` INT(11), IN `pDrQuantidade` INT(11), IN `pDrEntrada` INT(11), IN `pDrSaida` INT(11), IN `pCodigoRacao` INT(11))   BEGIN
-- =============================================
-- Autor: Murillo Gomes Yonamine
-- Data: 30/06
-- Descrição: Atualizar o Estoque e insere os dados novos no disk racao
-- =============================================

-- Comandos do CRUD
	INSERT INTO tb_diskracao
        (DrEsCodigo, DrFnCodigo, DrQuantidade, DrEntrada, DrSaida)
        VALUE(pEsCodigo, pFnCodigo, pDrQuantidade, pDrEntrada, pDrSaida);

	UPDATE tb_estoque SET EsQuantidade = EsQuantidade - pDrQuantidade
        WHERE EsCodigoRacao = pCodigoRacao;

-- Fim da execução do comando
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_adocao`
--

CREATE TABLE `tb_adocao` (
  `AdoCodigo` int(11) NOT NULL,
  `AdoAnCodigo` int(11) NOT NULL,
  `AdoFnCodigo` int(11) NOT NULL,
  `AdoClCodigo` int(11) NOT NULL,
  `AdoData` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `tb_adocao`
--

INSERT INTO `tb_adocao` (`AdoCodigo`, `AdoAnCodigo`, `AdoFnCodigo`, `AdoClCodigo`, `AdoData`) VALUES
(1, 18, 1, 4, '2023-06-30'),
(2, 17, 5, 8, '2023-06-30');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_animal`
--

CREATE TABLE `tb_animal` (
  `AnCodigoPet` int(11) NOT NULL,
  `AnNomePet` varchar(50) NOT NULL,
  `AnClCodigo` int(11) NOT NULL,
  `AnFnNome` int(11) NOT NULL,
  `AnRaca` varchar(50) NOT NULL,
  `AnCor` varchar(30) NOT NULL,
  `AnTipo` varchar(50) NOT NULL,
  `AnPeso` decimal(10,2) NOT NULL,
  `AnNascimento` date NOT NULL,
  `AnPedigree` varchar(5) NOT NULL,
  `AnRga` varchar(7) DEFAULT NULL,
  `AnSexo` varchar(10) NOT NULL,
  `AnObservacao` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `tb_animal`
--

INSERT INTO `tb_animal` (`AnCodigoPet`, `AnNomePet`, `AnClCodigo`, `AnFnNome`, `AnRaca`, `AnCor`, `AnTipo`, `AnPeso`, `AnNascimento`, `AnPedigree`, `AnRga`, `AnSexo`, `AnObservacao`) VALUES
(1, 'Bolinha', 1, 1, 'SRD', 'Marrom', 'Cachorro', '10.50', '2018-05-15', 'Não', '1234567', 'Macho', 'Animal dócil'),
(2, 'Mia', 2, 2, 'Persa', 'Cinza', 'Gato', '4.20', '2019-09-20', 'Sim', '9876543', 'Fêmea', 'Precisa de cuidados especiais'),
(4, 'Mel', 4, 3, 'Poodle', 'Branco', 'Cachorro', '7.80', '2020-02-05', 'Não', '7894561', 'Fêmea', 'Excelente companheira'),
(5, 'Nina', 1, 1, 'Siamese', 'Marrom e Branco', 'Gato', '3.50', '2021-01-12', 'Sim', '2587413', 'Fêmea', 'Muito brincalhona'),
(6, 'Simba', 6, 4, 'Maine Coon', 'Laranja', 'Gato', '8.90', '2017-11-30', 'Não', '9638527', 'Macho', 'Grande e tranquilo'),
(7, 'Branquinho', 7, 5, 'SRD', 'Branco', 'Coelho', '1.20', '2022-03-26', 'Não', '1478523', 'Macho', 'Adora cenoura e beterraba'),
(8, 'Luna', 2, 3, 'Golden Retriever', 'Dourado', 'Cachorro', '25.30', '2016-09-03', 'Sim', '3698521', 'Fêmea', 'Ótima para crianças'),
(9, 'Max', 1, 1, 'Labrador', 'Preto', 'Cachorro', '15.20', '2019-05-10', 'Sim', '1234567', 'Macho', 'Adora brincar no parque'),
(10, 'Molly', 1, 2, 'Golden Retriever', 'Dourado', 'Cachorro', '12.80', '2018-12-02', 'Sim', '2345678', 'Fêmea', 'Gosta de nadar'),
(11, 'Bella', 1, 3, 'Persa', 'Branco', 'Gato', '4.50', '2020-02-15', 'Não', '3456789', 'Fêmea', 'Dorme bastante'),
(12, 'Charlie', 1, 4, 'Siamese', 'Marrom', 'Gato', '5.20', '2019-08-20', 'Não', '4567890', 'Macho', 'Gosta de caçar brinquedos'),
(13, 'Luna', 1, 5, 'Vira-lata', 'Caramelo', 'Cachorro', '8.70', '2017-06-11', 'Não', '5678901', 'Fêmea', 'Sempre abana o rabo'),
(14, 'Maximus', 1, 1, 'Bulldog Inglês', 'Marrom e Branco', 'Cachorro', '18.90', '2016-03-25', 'Sim', '6789012', 'Macho', 'Adora correr no parque'),
(15, 'Nina', 1, 2, 'Persa', 'Cinza', 'Gato', '4.10', '2021-01-07', 'Não', '7890123', 'Fêmea', 'Gosta de brincar com bolinhas'),
(16, 'Simba', 1, 3, 'Maine Coon', 'Marrom Escuro', 'Gato', '6.60', '2020-09-14', 'Não', '8901234', 'Macho', 'Gosta de se exibir'),
(17, 'Lola', 8, 4, 'Poodle', 'Branco', 'Cachorro', '7.30', '2019-11-30', 'Sim', '9012345', 'Fêmea', 'Adora passear de carro'),
(18, 'Toby', 4, 5, 'Shih Tzu', 'Marrom e Branco', 'Cachorro', '6.20', '2020-07-22', 'Sim', '1234567', 'Macho', 'Gosta de brincar com bolinhas de tênis'),
(24, 'Csharp', 1, 3, 'Pug', 'Cinza', 'Cachorro', '10.00', '2020-01-28', 'Não', '9.999.9', 'Macho', 'Alergia a ração Pedigree');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_cliente`
--

CREATE TABLE `tb_cliente` (
  `ClCodigo` int(11) NOT NULL,
  `ClNome` varchar(50) NOT NULL,
  `ClCpf` varchar(11) NOT NULL,
  `ClCep` varchar(9) NOT NULL,
  `ClEmail` varchar(50) NOT NULL,
  `ClEndereco` varchar(100) NOT NULL,
  `ClNumero` int(11) NOT NULL,
  `ClBairro` varchar(50) NOT NULL,
  `ClCidade` varchar(50) NOT NULL,
  `ClUf` varchar(2) NOT NULL,
  `ClTelefone` varchar(15) NOT NULL,
  `ClComplemento` varchar(50) DEFAULT NULL,
  `ClGenero` varchar(30) NOT NULL,
  `ClDataRegistro` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `tb_cliente`
--

INSERT INTO `tb_cliente` (`ClCodigo`, `ClNome`, `ClCpf`, `ClCep`, `ClEmail`, `ClEndereco`, `ClNumero`, `ClBairro`, `ClCidade`, `ClUf`, `ClTelefone`, `ClComplemento`, `ClGenero`, `ClDataRegistro`) VALUES
(1, 'Pet Shop', '12345678901', '12345-678', 'pet.shop@email.com', 'Rua das Flores', 123, 'Centro', 'São Paulo', 'SP', '(11) 98765-4321', 'Rua 1A', 'Neutro', NULL),
(2, 'João Santos', '98765432109', '98765-432', 'joao.santos@email.com', 'Avenida dos Sonhos', 456, 'Vila Nova', 'Rio de Janeiro', 'RJ', '(21) 12345-6789', 'Casa 2B', 'Masculino', NULL),
(3, 'Maria Oliveira', '45678912305', '54321-876', 'maria.oliveira@email.com', 'Rua das Palmeiras', 789, 'Jardim Primavera', 'Belo Horizonte', 'MG', '(31) 55555-5555', 'Sala 3C', 'Feminino', NULL),
(4, 'Pedro Almeida', '78945612308', '87654-321', 'pedro.almeida@email.com', 'Avenida das Acácias', 147, 'Jardim Botânico', 'Curitiba', 'PR', '(41) 33333-2222', 'Casa 4D', 'Masculino', NULL),
(6, 'Carlos Costa', '74185296304', '98765-432', 'carlos.costa@email.com', 'Rua dos Girassóis', 258, 'Jardim das Rosas', 'Porto Alegre', 'RS', '(51) 66666-6666', 'Sala 6F', 'Masculino', NULL),
(7, 'Lúcia Fernandes', '96385274103', '54321-876', 'lucia.fernandes@email.com', 'Avenida das Margaridas', 753, 'Jardim Florido', 'Salvador', 'BA', '(71) 77777-7777', 'Casa 7G', 'Feminino', NULL),
(8, 'André Castro', '85296374106', '12345-678', 'andre.castro@email.com', 'Rua das Violetas', 369, 'Vila das Flores', 'Manaus', 'AM', '(92) 88888-8888', 'Apartamento 8H', 'Gênero Neutro', NULL),
(9, 'Júlia Santos', '36985274100', '87654-321', 'julia.santos@email.com', 'Avenida Brasil', 456, 'Centro', 'Goiânia', 'GO', '(62) 99999-9999', 'Casa 9I', 'Trangênero', NULL),
(11, 'Cléberson Ramos', '12345678912', '02358110', 'Cleberson@gmail.com', 'Rua Pedro Vaz Rego', 176, 'Jardim Daysy', 'São Paulo', 'SP', '11943753228', 'Viela 1', 'Masculino', '2023-06-30 14:26:27'),
(12, 'André Michael', '12345678901', '02319180', 'andremichael@gmail.com', 'Rua João Alves Dias', 760, 'Parque Casa de Pedra', 'São Paulo', 'SP', '11484654354', 'Parque', 'Masculino', '2023-07-05 14:24:04'),
(15, 'Dennys', '34662097819', '02401200', 'dennys@senac.br', 'Rua Voluntários da Pátria', 3167, 'Santana', 'São Paulo', 'SP', '11999999999', 'Sala 21', 'Masculino', '2023-07-05 16:52:25');

--
-- Acionadores `tb_cliente`
--
DELIMITER $$
CREATE TRIGGER `TGR_DataCompraUpdate` BEFORE INSERT ON `tb_cliente` FOR EACH ROW SET NEW.ClDataRegistro = NOW()
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_diskracao`
--

CREATE TABLE `tb_diskracao` (
  `DrCodigo` int(11) NOT NULL,
  `DrEsCodigo` int(11) NOT NULL,
  `DrFnCodigo` int(11) NOT NULL,
  `DrQuantidade` int(11) NOT NULL,
  `DrEntrada` date NOT NULL,
  `DrSaida` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `tb_diskracao`
--

INSERT INTO `tb_diskracao` (`DrCodigo`, `DrEsCodigo`, `DrFnCodigo`, `DrQuantidade`, `DrEntrada`, `DrSaida`) VALUES
(1, 1, 1, 10, '2023-06-30', '2023-07-01'),
(2, 2, 2, 5, '2023-06-29', '2023-07-02'),
(3, 3, 3, 8, '2023-06-28', '2023-07-03'),
(4, 4, 4, 3, '2023-06-27', '2023-07-04'),
(5, 5, 5, 15, '2023-06-26', '2023-07-05'),
(6, 6, 1, 12, '2023-06-25', '2023-07-06'),
(7, 7, 2, 7, '2023-06-24', '2023-07-07'),
(8, 8, 3, 9, '2023-06-23', '2023-07-08'),
(9, 9, 4, 4, '2023-06-22', '2023-07-09'),
(10, 10, 5, 20, '2023-06-21', '2023-07-10'),
(20, 7, 4, 2, '0000-00-00', '0000-00-00'),
(21, 7, 4, 2, '0000-00-00', '0000-00-00'),
(22, 7, 4, 2, '0000-00-00', '0000-00-00'),
(23, 10, 5, 10, '0000-00-00', '0000-00-00'),
(24, 9, 5, 10, '0000-00-00', '0000-00-00'),
(25, 7, 5, 5, '0000-00-00', '0000-00-00'),
(26, 7, 5, 5, '0000-00-00', '0000-00-00'),
(27, 8, 5, 13, '0000-00-00', '0000-00-00'),
(28, 8, 5, 13, '0000-00-00', '0000-00-00');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_estoque`
--

CREATE TABLE `tb_estoque` (
  `EsCodigo` int(11) NOT NULL,
  `EsCodigoRacao` int(11) NOT NULL,
  `EsQuantidade` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `tb_estoque`
--

INSERT INTO `tb_estoque` (`EsCodigo`, `EsCodigoRacao`, `EsQuantidade`) VALUES
(1, 1, 30),
(2, 2, 15),
(3, 3, 23),
(4, 4, 55),
(5, 5, 61),
(6, 6, 18),
(7, 7, -5),
(8, 8, -13),
(9, 9, 12),
(10, 10, 28);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_funcionario`
--

CREATE TABLE `tb_funcionario` (
  `FnCodigo` int(11) NOT NULL,
  `FnNome` varchar(40) NOT NULL,
  `FnSetor` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `tb_funcionario`
--

INSERT INTO `tb_funcionario` (`FnCodigo`, `FnNome`, `FnSetor`) VALUES
(1, 'Pedro', 'Atendimento'),
(2, 'Maria', 'Atendimento'),
(3, 'Juliana', 'Atendimento'),
(4, 'Lucas', 'Atendimento'),
(5, 'Fernanda', 'Atendimento');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_hotel`
--

CREATE TABLE `tb_hotel` (
  `HoCodigo` int(11) NOT NULL,
  `HoClCodigo` int(11) NOT NULL,
  `HoAnCodigo` int(11) NOT NULL,
  `HoEntrada` date NOT NULL,
  `HoRetorno` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `tb_hotel`
--

INSERT INTO `tb_hotel` (`HoCodigo`, `HoClCodigo`, `HoAnCodigo`, `HoEntrada`, `HoRetorno`) VALUES
(20, 2, 13, '2023-07-05', '2023-07-18'),
(22, 2, 13, '2023-07-05', '2023-07-21'),
(23, 2, 2, '2023-07-05', '2023-07-10');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_racao`
--

CREATE TABLE `tb_racao` (
  `RaCodigo` int(11) NOT NULL,
  `RaNome` varchar(30) NOT NULL,
  `RaMarca` varchar(30) NOT NULL,
  `RaPeso` decimal(10,3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `tb_racao`
--

INSERT INTO `tb_racao` (`RaCodigo`, `RaNome`, `RaMarca`, `RaPeso`) VALUES
(1, 'Ração Premium', 'Marpet', '1.000'),
(2, 'Ração Natural', 'PetNature', '2.000'),
(3, 'Ração Orgânica', 'BioPets', '1.000'),
(4, 'Ração Light', 'SlimPet', '3.000'),
(5, 'Ração Sensitive', 'GentlePaws', '1.000'),
(6, 'Ração Balanceada', 'FitFur', '2.000'),
(7, 'Ração Premium', 'DeluxeFeed', '1.000'),
(8, 'Ração Natural', 'Organipets', '5.000'),
(9, 'Ração Light', 'SlimTail', '20.000'),
(10, 'Ração Balanceada', 'NutriVet', '15.000');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_taxidog`
--

CREATE TABLE `tb_taxidog` (
  `TaCodigo` int(11) NOT NULL,
  `TaClCodigo` int(11) NOT NULL,
  `TaAnCodigo` int(11) NOT NULL,
  `TaData` date NOT NULL,
  `TaPetCare` varchar(50) NOT NULL,
  `TaPetVet` varchar(50) NOT NULL,
  `TaHorario` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `tb_taxidog`
--

INSERT INTO `tb_taxidog` (`TaCodigo`, `TaClCodigo`, `TaAnCodigo`, `TaData`, `TaPetCare`, `TaPetVet`, `TaHorario`) VALUES
(1, 15, 0, '2023-07-10', 'Sim', 'Sim', '14:00'),
(2, 2, 0, '2023-07-05', 'Não', 'Sim', '15:30'),
(8, 17, 0, '2023-07-10', 'Sim', 'Sim', '14:00'),
(9, 4, 6, '2023-07-13', 'Não', 'Sim', '14:00'),
(10, 2, 9, '2024-07-27', 'Não', 'Sim', '14:00'),
(11, 2, 9, '2023-06-27', 'Sim', 'Não', '15:30'),
(12, 2, 9, '2023-06-27', 'Sim', 'Sim', '15:30'),
(13, 3, 10, '2023-06-28', 'Sim', 'Sim', '16:00'),
(14, 4, 6, '2023-07-13', 'Sim', 'Sim', '15:00'),
(15, 4, 6, '2023-07-13', 'Não', 'Sim', '15:00'),
(16, 4, 6, '2023-07-13', 'Não', 'Sim', '14:00'),
(17, 2, 9, '2024-07-27', 'Não', 'Sim', '14:00'),
(18, 6, 8, '2023-06-27', 'Não', 'Sim', '13:00'),
(19, 4, 6, '2023-04-15', 'Não', 'Sim', '16:30'),
(20, 2, 9, '2023-06-30', 'Sim', 'Sim', '16:30');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_usuario`
--

CREATE TABLE `tb_usuario` (
  `UserCodigo` int(11) NOT NULL,
  `UserLogin` varchar(30) NOT NULL,
  `UserSenha` varchar(15) NOT NULL,
  `UserLogado` int(11) NOT NULL,
  `UserDataAcesso` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `tb_usuario`
--

INSERT INTO `tb_usuario` (`UserCodigo`, `UserLogin`, `UserSenha`, `UserLogado`, `UserDataAcesso`) VALUES
(1, 'SENAC', 'Sistemas2023', 0, '2023-07-05 17:10:45');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `tb_adocao`
--
ALTER TABLE `tb_adocao`
  ADD PRIMARY KEY (`AdoCodigo`),
  ADD KEY `FK_AdoAnCodigo` (`AdoAnCodigo`),
  ADD KEY `FK_AdoFnCodigo` (`AdoFnCodigo`),
  ADD KEY `FK_AdoClCodigo` (`AdoClCodigo`);

--
-- Índices para tabela `tb_animal`
--
ALTER TABLE `tb_animal`
  ADD PRIMARY KEY (`AnCodigoPet`),
  ADD KEY `FK_DonoPet` (`AnClCodigo`),
  ADD KEY `FK_Funcionario` (`AnFnNome`);

--
-- Índices para tabela `tb_cliente`
--
ALTER TABLE `tb_cliente`
  ADD PRIMARY KEY (`ClCodigo`);

--
-- Índices para tabela `tb_diskracao`
--
ALTER TABLE `tb_diskracao`
  ADD PRIMARY KEY (`DrCodigo`),
  ADD KEY `FK_DrFnCodigo` (`DrFnCodigo`),
  ADD KEY `FK_DrEsCodigo` (`DrEsCodigo`);

--
-- Índices para tabela `tb_estoque`
--
ALTER TABLE `tb_estoque`
  ADD PRIMARY KEY (`EsCodigo`),
  ADD KEY `FK_EsCodigoRacao` (`EsCodigoRacao`);

--
-- Índices para tabela `tb_funcionario`
--
ALTER TABLE `tb_funcionario`
  ADD PRIMARY KEY (`FnCodigo`);

--
-- Índices para tabela `tb_hotel`
--
ALTER TABLE `tb_hotel`
  ADD PRIMARY KEY (`HoCodigo`);

--
-- Índices para tabela `tb_racao`
--
ALTER TABLE `tb_racao`
  ADD PRIMARY KEY (`RaCodigo`);

--
-- Índices para tabela `tb_taxidog`
--
ALTER TABLE `tb_taxidog`
  ADD PRIMARY KEY (`TaCodigo`);

--
-- Índices para tabela `tb_usuario`
--
ALTER TABLE `tb_usuario`
  ADD PRIMARY KEY (`UserCodigo`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `tb_adocao`
--
ALTER TABLE `tb_adocao`
  MODIFY `AdoCodigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `tb_animal`
--
ALTER TABLE `tb_animal`
  MODIFY `AnCodigoPet` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT de tabela `tb_cliente`
--
ALTER TABLE `tb_cliente`
  MODIFY `ClCodigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT de tabela `tb_diskracao`
--
ALTER TABLE `tb_diskracao`
  MODIFY `DrCodigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT de tabela `tb_estoque`
--
ALTER TABLE `tb_estoque`
  MODIFY `EsCodigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de tabela `tb_funcionario`
--
ALTER TABLE `tb_funcionario`
  MODIFY `FnCodigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de tabela `tb_hotel`
--
ALTER TABLE `tb_hotel`
  MODIFY `HoCodigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT de tabela `tb_racao`
--
ALTER TABLE `tb_racao`
  MODIFY `RaCodigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de tabela `tb_taxidog`
--
ALTER TABLE `tb_taxidog`
  MODIFY `TaCodigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT de tabela `tb_usuario`
--
ALTER TABLE `tb_usuario`
  MODIFY `UserCodigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `tb_adocao`
--
ALTER TABLE `tb_adocao`
  ADD CONSTRAINT `FK_AdoAnCodigo` FOREIGN KEY (`AdoAnCodigo`) REFERENCES `tb_animal` (`AnCodigoPet`),
  ADD CONSTRAINT `FK_AdoClCodigo` FOREIGN KEY (`AdoClCodigo`) REFERENCES `tb_cliente` (`ClCodigo`),
  ADD CONSTRAINT `FK_AdoFnCodigo` FOREIGN KEY (`AdoFnCodigo`) REFERENCES `tb_funcionario` (`FnCodigo`);

--
-- Limitadores para a tabela `tb_animal`
--
ALTER TABLE `tb_animal`
  ADD CONSTRAINT `FK_DonoPet` FOREIGN KEY (`AnClCodigo`) REFERENCES `tb_cliente` (`ClCodigo`),
  ADD CONSTRAINT `FK_Funcionario` FOREIGN KEY (`AnFnNome`) REFERENCES `tb_funcionario` (`FnCodigo`);

--
-- Limitadores para a tabela `tb_diskracao`
--
ALTER TABLE `tb_diskracao`
  ADD CONSTRAINT `FK_DrEsCodigo` FOREIGN KEY (`DrEsCodigo`) REFERENCES `tb_estoque` (`EsCodigo`),
  ADD CONSTRAINT `FK_DrFnCodigo` FOREIGN KEY (`DrFnCodigo`) REFERENCES `tb_funcionario` (`FnCodigo`),
  ADD CONSTRAINT `FK_DrRaCodigo` FOREIGN KEY (`DrEsCodigo`) REFERENCES `tb_racao` (`RaCodigo`);

--
-- Limitadores para a tabela `tb_estoque`
--
ALTER TABLE `tb_estoque`
  ADD CONSTRAINT `FK_EsCodigoRacao` FOREIGN KEY (`EsCodigoRacao`) REFERENCES `tb_racao` (`RaCodigo`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
