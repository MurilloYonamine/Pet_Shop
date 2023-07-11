-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 11/07/2023 às 16:55
-- Versão do servidor: 10.4.28-MariaDB
-- Versão do PHP: 8.2.4

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

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_InserirSubtrair` (IN `pEsCodigo` INT(11), IN `pFnCodigo` INT(11), IN `pDrQuantidade` INT(11), IN `pDrEntrada` DATE, IN `pDrSaida` DATE, IN `pCodigoRacao` INT(11))   BEGIN
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

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_PmInserirSomar` (IN `pFoCodigo` INT(11), IN `pFoValidade` INT(11), IN `pFoQuantidade ` INT(11), IN `pFoPreco` DATE, IN `pFoProCodigo` DATE, IN `pFoRegistro` INT(11), IN `pFoNome` INT, IN `pFoTotal` INT)   BEGIN
-- =============================================
-- Autor: Murillo Gomes Yonamine
-- Data: 30/06
-- Descrição: Atualizar o Estoque e insere os dados novos no disk racao
-- =============================================

-- Comandos do CRUD
	INSERT INTO tb_fornecedor
        (FoNome, FoValidade, FoQuantidade, FoPreco, FoProCodigo, FoRegistro, FoTotal)
        VALUE(pFoNome,pFoValidade,pFoQuantidade , pFoPreco, pFoProCodigo, pFoRegistro, pFoTotal);

	UPDATE tb_estoque SET EsQuantidade = EsQuantidade + pDrQuantidade
        WHERE EsProCodigo = pFoProCodigo;

-- Fim da execução do comando
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_Venda` (IN `pVenProCodigo` INT(11), IN `pVenPreco` VARCHAR(20) CHARSET utf8mb4, IN `pVenValidade` DATE, IN `pVenQuantidade` INT, IN `pVenTotal` DECIMAL(10,0))   BEGIN
-- =============================================
-- Autor: Murillo Gomes Yonamine
-- Data: 10/07
-- Descrição: Atualizar o Estoque e insere os dados novos no Venda
-- =============================================

-- Comandos do CRUD
	INSERT INTO tb_venda
        (VenProCodigo, VenPreco, VenValidade, VenQuantidade, VenTotal) 
        VALUES(pVenProCodigo, pVenPreco, pVenValidade, pVenQuantidade, pVenTotal);

	UPDATE tb_estoque 
    	SET EsQuantidade = EsQuantidade - pVenQuantidade
        WHERE EsProCodigo = pVenProCodigo;

-- Fim da execução do comando
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_adocao`
--

CREATE TABLE `tb_adocao` (
  `AdoCodigo` int(11) NOT NULL,
  `AdoAnCodigo` int(11) NOT NULL,
  `AdoFnCodigo` int(11) NOT NULL,
  `AdoClCodigo` int(11) NOT NULL,
  `AdoData` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `tb_adocao`
--

INSERT INTO `tb_adocao` (`AdoCodigo`, `AdoAnCodigo`, `AdoFnCodigo`, `AdoClCodigo`, `AdoData`) VALUES
(1, 18, 1, 4, '2023-06-30'),
(2, 17, 5, 8, '2023-06-30'),
(3, 24, 5, 15, '2023-07-01');

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_agendamento`
--

CREATE TABLE `tb_agendamento` (
  `AgCodigo` int(11) NOT NULL,
  `AgResponsavel` varchar(50) NOT NULL,
  `AgTelefone` varchar(15) NOT NULL,
  `AgNomeAnimal` varchar(50) NOT NULL,
  `AgRaca` varchar(50) NOT NULL,
  `AgAgendamento` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `tb_agendamento`
--

INSERT INTO `tb_agendamento` (`AgCodigo`, `AgResponsavel`, `AgTelefone`, `AgNomeAnimal`, `AgRaca`, `AgAgendamento`) VALUES
(2, 'Andressa', '993827662', 'Ivy', 'Felina(SRD)', '2023-07-20 16:06:31'),
(3, 'Victoria', '993652424', 'Clarinha', 'Canina(SRD)', '2023-07-14 16:10:57'),
(4, 'Lucas', '965548716', 'Xuxuu', 'Pitbull', '2023-07-21 16:39:30'),
(5, 'André', '93827665', 'Santiago', 'Huskie', '2023-07-27 16:45:00'),
(6, 'Murillo', '11943753228', 'Toby', 'Shih Tzu', '2023-07-16 11:00:02');

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_analise`
--

CREATE TABLE `tb_analise` (
  `AnaPulgas` varchar(11) NOT NULL,
  `AnaLesoes` varchar(11) NOT NULL,
  `AnaObservacoes` varchar(300) DEFAULT NULL,
  `AnaCodigo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `tb_analise`
--

INSERT INTO `tb_analise` (`AnaPulgas`, `AnaLesoes`, `AnaObservacoes`, `AnaCodigo`) VALUES
('Não', 'Não', 'Ela é Brava!', 2),
('Não', 'Não', '', 3),
('Não', 'Não', 'é docil, menos com o dono', 4),
('Não', 'Sim', '', 5),
('Sim', 'Não', 'Ele é muito brincalhão.', 6);

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_animal`
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
-- Despejando dados para a tabela `tb_animal`
--

INSERT INTO `tb_animal` (`AnCodigoPet`, `AnNomePet`, `AnClCodigo`, `AnFnNome`, `AnRaca`, `AnCor`, `AnTipo`, `AnPeso`, `AnNascimento`, `AnPedigree`, `AnRga`, `AnSexo`, `AnObservacao`) VALUES
(1, 'Bolinha', 1, 1, 'SRD', 'Marrom', 'Cachorro', 10.50, '2018-05-15', 'Não', '1234567', 'Macho', 'Animal bravo'),
(2, 'Mia', 2, 2, 'Persa', 'Cinza', 'Gato', 4.20, '2019-09-20', 'Sim', '9876543', 'Fêmea', 'Precisa de cuidados especiais'),
(4, 'Mel', 4, 3, 'Poodle', 'Branco', 'Cachorro', 7.80, '2020-02-05', 'Não', '7894561', 'Fêmea', 'Excelente companheira'),
(5, 'Nina', 1, 1, 'Siamese', 'Marrom e Branco', 'Gato', 3.50, '2021-01-12', 'Sim', '2587413', 'Fêmea', 'Muito brincalhona'),
(6, 'Simba', 6, 4, 'Maine Coon', 'Laranja', 'Gato', 8.90, '2017-11-30', 'Não', '9638527', 'Macho', 'Grande e tranquilo'),
(7, 'Branquinho', 7, 5, 'SRD', 'Branco', 'Coelho', 1.20, '2022-03-26', 'Não', '1478523', 'Macho', 'Adora cenoura e beterraba'),
(8, 'Luna', 2, 3, 'Golden Retriever', 'Dourado', 'Cachorro', 25.30, '2016-09-03', 'Sim', '3698521', 'Fêmea', 'Ótima para crianças'),
(9, 'Max', 1, 1, 'Labrador', 'Preto', 'Cachorro', 15.20, '2019-05-10', 'Sim', '1234567', 'Macho', 'Adora brincar no parque'),
(10, 'Molly', 1, 2, 'Golden Retriever', 'Dourado', 'Cachorro', 12.80, '2018-12-02', 'Sim', '2345678', 'Fêmea', 'Gosta de nadar'),
(11, 'Bella', 1, 3, 'Persa', 'Branco', 'Gato', 4.50, '2020-02-15', 'Não', '3456789', 'Fêmea', 'Dorme bastante'),
(12, 'Charlie', 1, 4, 'Siamese', 'Marrom', 'Gato', 5.20, '2019-08-20', 'Não', '4567890', 'Macho', 'Gosta de caçar brinquedos'),
(13, 'Luna', 1, 5, 'Vira-lata', 'Caramelo', 'Cachorro', 8.70, '2017-06-11', 'Não', '5678901', 'Fêmea', 'Sempre abana o rabo'),
(14, 'Maximus', 1, 1, 'Bulldog Inglês', 'Marrom e Branco', 'Cachorro', 18.90, '2016-03-25', 'Sim', '6789012', 'Macho', 'Adora correr no parque'),
(15, 'Nina', 1, 2, 'Persa', 'Cinza', 'Gato', 4.10, '2021-01-07', 'Não', '7890123', 'Fêmea', 'Gosta de brincar com bolinhas'),
(16, 'Simba', 1, 1, 'Maine Coon', 'Marrom Escuro', 'Gato', 6.60, '2020-09-14', 'Não', '8901234', 'Macho', 'Gosta de se exibir'),
(17, 'Lola', 8, 4, 'Poodle', 'Branco', 'Cachorro', 7.30, '2019-11-30', 'Sim', '9012345', 'Fêmea', 'Adora passear de carro'),
(18, 'Toby', 4, 5, 'Shih Tzu', 'Marrom e Branco', 'Cachorro', 6.20, '2020-07-22', 'Sim', '1234567', 'Macho', 'Gosta de brincar com bolinhas de tênis'),
(24, 'Csharp', 15, 3, 'Pug', 'Cinza', 'Cachorro', 10.00, '2020-01-28', 'Não', '9.999.9', 'Macho', 'Alergia a ração Pedigree'),
(25, 'Reginaldo', 11, 5, 'Shih Tzu', 'Marrom', 'Cachorro', 5.00, '2014-07-17', 'Sim', '8.469.8', 'Macho', 'Problema nas vistas.');

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_cliente`
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
-- Despejando dados para a tabela `tb_cliente`
--

INSERT INTO `tb_cliente` (`ClCodigo`, `ClNome`, `ClCpf`, `ClCep`, `ClEmail`, `ClEndereco`, `ClNumero`, `ClBairro`, `ClCidade`, `ClUf`, `ClTelefone`, `ClComplemento`, `ClGenero`, `ClDataRegistro`) VALUES
(1, 'Pet Shop', '12345678901', '12345-678', 'pet.shop@email.com', 'Rua das Flores', 123, 'Centro', 'São Paulo', 'SP', '(11) 98765-4321', 'Rua 1A', 'Neutro', NULL),
(2, 'João Santos', '98765432109', '98765-432', 'joao.santos@email.com', 'Avenida dos Sonhos', 456, 'Vila Nova', 'Rio de Janeiro', 'RJ', '(21) 12345-6789', 'Casa 2B', 'Masculino', NULL),
(3, 'Maria Oliveira', '45678912305', '54321-876', 'maria.oliveira@email.com', 'Rua das Palmeiras', 789, 'Jardim Primavera', 'Belo Horizonte', 'MG', '(31) 55555-5555', 'Sala 3C', 'Feminino', NULL),
(4, 'Pedro Almeida', '78945612308', '87654-321', 'pedro.almeida@email.com', 'Avenida das Acácias', 147, 'Jardim Botânico', 'Curitiba', 'PR', '(41) 33333-2222', 'Casa 4D', 'Masculino', NULL),
(6, 'Carlos Costa', '74185296304', '98765-432', 'carlos.costa@email.com', 'Rua dos Girassóis', 258, 'Jardim das Rosas', 'Porto Alegre', 'RS', '(51) 66666-6666', 'Sala 6F', 'Masculino', NULL),
(7, 'Lúcia Fernandes', '96385274103', '54321-876', 'lucia.fernandes@email.com', 'Avenida das Margaridas', 753, 'Jardim Florido', 'Salvador', 'BA', '(71) 77777-7777', 'Casa 7G', 'Feminino', NULL),
(8, 'André Castro', '85296374106', '12345-678', 'andre.castro@email.com', 'Rua das Violetas', 369, 'Vila das Flores', 'Manaus', 'AM', '(92) 88888-8888', 'Apartamento 8H', 'Gênero Neutro', NULL),
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
-- Estrutura para tabela `tb_diskracao`
--

CREATE TABLE `tb_diskracao` (
  `DrCodigo` int(11) NOT NULL,
  `DrEsCodigo` int(11) NOT NULL,
  `DrFnCodigo` int(11) NOT NULL,
  `DrQuantidade` int(11) NOT NULL,
  `DrEntrada` date NOT NULL,
  `DrSaida` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_estoque`
--

CREATE TABLE `tb_estoque` (
  `EsCodigo` int(11) NOT NULL,
  `EsProCodigo` int(11) NOT NULL,
  `EsQuantidade` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `tb_estoque`
--

INSERT INTO `tb_estoque` (`EsCodigo`, `EsProCodigo`, `EsQuantidade`) VALUES
(4, 1, 2);

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_fornecedor`
--

CREATE TABLE `tb_fornecedor` (
  `FoCodigo` smallint(6) NOT NULL,
  `FoNome` varchar(60) DEFAULT NULL,
  `FoValidade` date DEFAULT NULL,
  `FoQuantidade` int(11) DEFAULT NULL,
  `FoPreco` decimal(10,0) DEFAULT NULL,
  `FoProCodigo` int(11) DEFAULT NULL,
  `FoRegistro` date DEFAULT NULL,
  `FoTotal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Despejando dados para a tabela `tb_fornecedor`
--

INSERT INTO `tb_fornecedor` (`FoCodigo`, `FoNome`, `FoValidade`, `FoQuantidade`, `FoPreco`, `FoProCodigo`, `FoRegistro`, `FoTotal`) VALUES
(2, 'PetFeed', '2023-07-05', 6, 19, 1, '2023-07-05', 114),
(3, 'PetHigh', '2033-05-02', 18, 11, 1, '2023-07-05', 198),
(4, 'PetFamily', '2099-11-25', 30, 32, 1, '2023-07-05', 960),
(5, 'PetFeed', '2099-11-25', 50, 20, 1, '2023-07-05', 1000),
(6, 'PetFeed', '2023-07-05', 30, 32, 1, '2023-07-05', 960),
(7, 'Pedigre', '2023-08-05', 5, 110, 1, '2023-07-05', 550),
(8, 'Pedigree', '2023-07-26', 5, 100, 1, '2023-07-05', 500),
(9, 'Pedigree', '2023-07-27', 30, 110, 1, '2023-07-05', 3300),
(10, 'Pedigree', '2023-07-28', 10, 100, 1, '2023-07-05', 1000),
(11, 'Sadia', '2023-08-05', 5, 40, 1, '2023-07-05', 200),
(15, 'peddigree', '2023-07-10', 10, 25, 1, '2023-07-10', 250),
(16, 'Alabama', '2023-07-21', 10, 10, 1, '2023-07-10', 100),
(17, 'mhjvgnvcgb', '2023-07-10', 10, 10, 1, '2023-07-10', 100);

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_funcionario`
--

CREATE TABLE `tb_funcionario` (
  `FnCodigo` int(11) NOT NULL,
  `FnNome` varchar(40) NOT NULL,
  `FnSetor` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `tb_funcionario`
--

INSERT INTO `tb_funcionario` (`FnCodigo`, `FnNome`, `FnSetor`) VALUES
(1, 'Pedro', 'Atendimento'),
(2, 'Maria', 'Atendimento'),
(3, 'Juliana', 'Atendimento'),
(4, 'Lucas', 'Atendimento'),
(5, 'Fernanda', 'Atendimento');

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_hotel`
--

CREATE TABLE `tb_hotel` (
  `HoCodigo` int(11) NOT NULL,
  `HoClCodigo` int(11) NOT NULL,
  `HoAnCodigo` int(11) NOT NULL,
  `HoEntrada` date NOT NULL,
  `HoRetorno` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `tb_hotel`
--

INSERT INTO `tb_hotel` (`HoCodigo`, `HoClCodigo`, `HoAnCodigo`, `HoEntrada`, `HoRetorno`) VALUES
(20, 2, 13, '2023-07-05', '2023-07-18'),
(22, 2, 13, '2023-07-05', '2023-07-21'),
(23, 2, 2, '2023-07-05', '2023-07-10');

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_produto`
--

CREATE TABLE `tb_produto` (
  `ProCodigo` int(11) NOT NULL,
  `ProNome` varchar(30) NOT NULL,
  `ProTipo` varchar(10) NOT NULL,
  `ProMarca` varchar(15) NOT NULL,
  `ProRegistro` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Despejando dados para a tabela `tb_produto`
--

INSERT INTO `tb_produto` (`ProCodigo`, `ProNome`, `ProTipo`, `ProMarca`, `ProRegistro`) VALUES
(1, 'Ração para cãess', 'Alimento', 'PetFit', '2023-07-05'),
(2, 'Shampoo para gatos', 'Higiene', 'Purrfect', '2023-07-05'),
(3, 'Coleira ajustável', 'Acessório', 'PawPrint', '2023-07-05'),
(4, 'Brinquedo de corda', 'Brinquedo', 'HappyPaws', '2023-07-05'),
(5, 'Cama para cães', 'Acessório', 'CozySleep', '2023-07-05'),
(6, 'Arranhador para gatos', 'Acessório', 'ScratchMe', '2023-07-05'),
(7, 'Petisco dental', 'Alimento', 'DentaBite', '2023-07-05'),
(8, 'Shampoo seco para cães', 'Higiene', 'FreshPaws', '2023-07-05'),
(9, 'Coleira anti-latido', 'Acessório', 'QuietCollar', '2023-07-05'),
(10, 'Bolinhas de tênis para cães', 'Brinquedo', 'PlayFetch', '2023-07-05'),
(11, 'Ração Porte Grande', 'Alimento', 'Pedigree', '2023-07-05'),
(13, 'Osso', 'Alimento', 'Ossado', '2023-07-05');

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_servico`
--

CREATE TABLE `tb_servico` (
  `SeBanho` varchar(11) NOT NULL,
  `SeHidratacao` varchar(11) NOT NULL,
  `SeTosa` varchar(11) NOT NULL,
  `SeDesembolo` varchar(11) NOT NULL,
  `SeAlergia` varchar(50) DEFAULT NULL,
  `SeCodigo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `tb_servico`
--

INSERT INTO `tb_servico` (`SeBanho`, `SeHidratacao`, `SeTosa`, `SeDesembolo`, `SeAlergia`, `SeCodigo`) VALUES
('Sim', 'Não', 'Não', 'Não', '', 2),
('Sim', 'Não', 'Não', 'Não', '', 3),
('Sim', 'Sim', 'Não', 'Não', 'Ao Dono', 4),
('Sim', 'Sim', 'Sim', 'Sim', 'Sim', 5),
('Sim', 'Sim', 'Sim', 'Não', 'Não', 6);

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_taxidog`
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
-- Despejando dados para a tabela `tb_taxidog`
--

INSERT INTO `tb_taxidog` (`TaCodigo`, `TaClCodigo`, `TaAnCodigo`, `TaData`, `TaPetCare`, `TaPetVet`, `TaHorario`) VALUES
(2, 2, 2, '2023-10-16', 'Sim', 'Sim', '16:00'),
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
(20, 2, 9, '2023-06-30', 'Sim', 'Sim', '16:30'),
(21, 2, 2, '2023-07-10', 'Sim', 'Sim', '13:30'),
(22, 2, 2, '2023-07-10', 'Sim', 'Sim', '15:00'),
(23, 2, 2, '2023-07-10', 'Sim', 'Sim', '14:00'),
(25, 2, 2, '2023-10-16', 'Sim', 'Sim', '16:00'),
(26, 2, 13, '2023-07-11', 'Sim', 'Não', '14:00'),
(27, 2, 2, '2023-07-11', 'Sim', 'Não', '14:00'),
(28, 11, 25, '2023-07-14', 'Não', 'Sim', '16:00'),
(29, 11, 25, '2023-07-14', 'Não', 'Sim', '16:30'),
(30, 11, 25, '2023-07-14', 'Não', 'Sim', '14:00'),
(31, 11, 25, '2023-07-14', 'Não', 'Sim', '15:30'),
(32, 11, 25, '2023-07-14', 'Sim', 'Sim', '13:00');

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_usuario`
--

CREATE TABLE `tb_usuario` (
  `UserCodigo` int(11) NOT NULL,
  `UserLogin` varchar(30) NOT NULL,
  `UserSenha` varchar(15) NOT NULL,
  `UserLogado` int(11) NOT NULL,
  `UserDataAcesso` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `tb_usuario`
--

INSERT INTO `tb_usuario` (`UserCodigo`, `UserLogin`, `UserSenha`, `UserLogado`, `UserDataAcesso`) VALUES
(1, 'SENAC', 'Sistemas2023', 0, '2023-07-10 16:26:10');

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_venda`
--

CREATE TABLE `tb_venda` (
  `VenCodigo` smallint(6) NOT NULL,
  `VenProCodigo` int(11) NOT NULL,
  `VenPreco` varchar(20) NOT NULL,
  `VenValidade` date NOT NULL,
  `VenQuantidade` int(11) NOT NULL,
  `VenTotal` decimal(10,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Despejando dados para a tabela `tb_venda`
--

INSERT INTO `tb_venda` (`VenCodigo`, `VenProCodigo`, `VenPreco`, `VenValidade`, `VenQuantidade`, `VenTotal`) VALUES
(2, 10, '59', '2023-07-05', 1, 59),
(3, 11, '150', '2023-08-05', 3, 450),
(4, 11, '150', '2023-07-28', 2, 300),
(5, 11, '150', '2023-07-28', 1, 150),
(6, 11, '150', '2023-07-28', 1, 150),
(7, 11, '150', '2023-07-28', 1, 150),
(8, 11, '150', '2023-07-27', 1, 150),
(11, 1, '40', '2023-07-14', 5, 200),
(12, 13, '20', '2023-07-14', 5, 100),
(13, 13, '20', '2023-07-15', 5, 100),
(14, 13, '20', '2023-07-14', 2, 40),
(15, 1, '40', '2023-07-14', 3, 120),
(16, 1, '20', '2023-07-06', 13, 260),
(17, 1, '150', '2023-07-10', 2, 300);

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `tb_adocao`
--
ALTER TABLE `tb_adocao`
  ADD PRIMARY KEY (`AdoCodigo`),
  ADD KEY `FK_AdoAnCodigo` (`AdoAnCodigo`),
  ADD KEY `FK_AdoFnCodigo` (`AdoFnCodigo`),
  ADD KEY `FK_AdoClCodigo` (`AdoClCodigo`);

--
-- Índices de tabela `tb_agendamento`
--
ALTER TABLE `tb_agendamento`
  ADD PRIMARY KEY (`AgCodigo`);

--
-- Índices de tabela `tb_analise`
--
ALTER TABLE `tb_analise`
  ADD PRIMARY KEY (`AnaCodigo`);

--
-- Índices de tabela `tb_animal`
--
ALTER TABLE `tb_animal`
  ADD PRIMARY KEY (`AnCodigoPet`),
  ADD KEY `FK_DonoPet` (`AnClCodigo`),
  ADD KEY `FK_Funcionario` (`AnFnNome`);

--
-- Índices de tabela `tb_cliente`
--
ALTER TABLE `tb_cliente`
  ADD PRIMARY KEY (`ClCodigo`);

--
-- Índices de tabela `tb_diskracao`
--
ALTER TABLE `tb_diskracao`
  ADD PRIMARY KEY (`DrCodigo`),
  ADD KEY `FK_DrFnCodigo` (`DrFnCodigo`);

--
-- Índices de tabela `tb_estoque`
--
ALTER TABLE `tb_estoque`
  ADD PRIMARY KEY (`EsCodigo`),
  ADD KEY `FK_EsProduto` (`EsProCodigo`);

--
-- Índices de tabela `tb_fornecedor`
--
ALTER TABLE `tb_fornecedor`
  ADD PRIMARY KEY (`FoCodigo`),
  ADD KEY `FK_FoProduto` (`FoProCodigo`);

--
-- Índices de tabela `tb_funcionario`
--
ALTER TABLE `tb_funcionario`
  ADD PRIMARY KEY (`FnCodigo`);

--
-- Índices de tabela `tb_hotel`
--
ALTER TABLE `tb_hotel`
  ADD PRIMARY KEY (`HoCodigo`);

--
-- Índices de tabela `tb_produto`
--
ALTER TABLE `tb_produto`
  ADD PRIMARY KEY (`ProCodigo`);

--
-- Índices de tabela `tb_servico`
--
ALTER TABLE `tb_servico`
  ADD PRIMARY KEY (`SeCodigo`);

--
-- Índices de tabela `tb_taxidog`
--
ALTER TABLE `tb_taxidog`
  ADD PRIMARY KEY (`TaCodigo`),
  ADD KEY `FK_ClTaxiDog` (`TaClCodigo`),
  ADD KEY `FK_AnTaxiDog` (`TaAnCodigo`);

--
-- Índices de tabela `tb_usuario`
--
ALTER TABLE `tb_usuario`
  ADD PRIMARY KEY (`UserCodigo`);

--
-- Índices de tabela `tb_venda`
--
ALTER TABLE `tb_venda`
  ADD PRIMARY KEY (`VenCodigo`),
  ADD KEY `FK_VenProduto` (`VenProCodigo`) USING BTREE;

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `tb_adocao`
--
ALTER TABLE `tb_adocao`
  MODIFY `AdoCodigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `tb_agendamento`
--
ALTER TABLE `tb_agendamento`
  MODIFY `AgCodigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de tabela `tb_analise`
--
ALTER TABLE `tb_analise`
  MODIFY `AnaCodigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de tabela `tb_animal`
--
ALTER TABLE `tb_animal`
  MODIFY `AnCodigoPet` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT de tabela `tb_cliente`
--
ALTER TABLE `tb_cliente`
  MODIFY `ClCodigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT de tabela `tb_diskracao`
--
ALTER TABLE `tb_diskracao`
  MODIFY `DrCodigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=50;

--
-- AUTO_INCREMENT de tabela `tb_estoque`
--
ALTER TABLE `tb_estoque`
  MODIFY `EsCodigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `tb_fornecedor`
--
ALTER TABLE `tb_fornecedor`
  MODIFY `FoCodigo` smallint(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

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
-- AUTO_INCREMENT de tabela `tb_produto`
--
ALTER TABLE `tb_produto`
  MODIFY `ProCodigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT de tabela `tb_servico`
--
ALTER TABLE `tb_servico`
  MODIFY `SeCodigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de tabela `tb_taxidog`
--
ALTER TABLE `tb_taxidog`
  MODIFY `TaCodigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT de tabela `tb_usuario`
--
ALTER TABLE `tb_usuario`
  MODIFY `UserCodigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `tb_venda`
--
ALTER TABLE `tb_venda`
  MODIFY `VenCodigo` smallint(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- Restrições para tabelas despejadas
--

--
-- Restrições para tabelas `tb_adocao`
--
ALTER TABLE `tb_adocao`
  ADD CONSTRAINT `FK_AdoAnCodigo` FOREIGN KEY (`AdoAnCodigo`) REFERENCES `tb_animal` (`AnCodigoPet`),
  ADD CONSTRAINT `FK_AdoClCodigo` FOREIGN KEY (`AdoClCodigo`) REFERENCES `tb_cliente` (`ClCodigo`),
  ADD CONSTRAINT `FK_AdoFnCodigo` FOREIGN KEY (`AdoFnCodigo`) REFERENCES `tb_funcionario` (`FnCodigo`);

--
-- Restrições para tabelas `tb_animal`
--
ALTER TABLE `tb_animal`
  ADD CONSTRAINT `FK_DonoPet` FOREIGN KEY (`AnClCodigo`) REFERENCES `tb_cliente` (`ClCodigo`),
  ADD CONSTRAINT `FK_Funcionario` FOREIGN KEY (`AnFnNome`) REFERENCES `tb_funcionario` (`FnCodigo`);

--
-- Restrições para tabelas `tb_diskracao`
--
ALTER TABLE `tb_diskracao`
  ADD CONSTRAINT `FK_DrFnCodigo` FOREIGN KEY (`DrFnCodigo`) REFERENCES `tb_funcionario` (`FnCodigo`);

--
-- Restrições para tabelas `tb_estoque`
--
ALTER TABLE `tb_estoque`
  ADD CONSTRAINT `FK_EsProduto` FOREIGN KEY (`EsProCodigo`) REFERENCES `tb_produto` (`ProCodigo`);

--
-- Restrições para tabelas `tb_fornecedor`
--
ALTER TABLE `tb_fornecedor`
  ADD CONSTRAINT `FK_FoProduto` FOREIGN KEY (`FoProCodigo`) REFERENCES `tb_produto` (`ProCodigo`);

--
-- Restrições para tabelas `tb_taxidog`
--
ALTER TABLE `tb_taxidog`
  ADD CONSTRAINT `FK_AnTaxiDog` FOREIGN KEY (`TaAnCodigo`) REFERENCES `tb_animal` (`AnCodigoPet`),
  ADD CONSTRAINT `FK_ClTaxiDog` FOREIGN KEY (`TaClCodigo`) REFERENCES `tb_cliente` (`ClCodigo`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
