-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 06-Maio-2022 às 01:07
-- Versão do servidor: 10.4.24-MariaDB
-- versão do PHP: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `dps`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `produtos`
--

CREATE TABLE `produtos` (
  `id` int(11) UNSIGNED NOT NULL,
  `codigo` varchar(30) NOT NULL,
  `nome` varchar(255) NOT NULL,
  `quantia` int(11) NOT NULL,
  `foto` varchar(255) NOT NULL,
  `prateleira` int(11) NOT NULL,
  `numero` int(11) NOT NULL,
  `letra` varchar(30) NOT NULL,
  `link` varchar(255) NOT NULL,
  `reg_date` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `produtos`
--

INSERT INTO `produtos` (`id`, `codigo`, `nome`, `quantia`, `foto`, `prateleira`, `numero`, `letra`, `link`, `reg_date`) VALUES
(1, '11100', 'Nautik', 10, 'http://127.0.0.1/Fotos/305070-1.jpg', 2, 3, 'A', 'https://dispropil.com.br', '2022-05-01 03:57:22'),
(2, '129525', 'Chumbinho Grizzluy 9.0', 10, 'http://127.0.0.1/Fotos/317520-1.jpeg', 19, 4, 'A', 'https://www.dispropil.com.br/chumbinho-grizzly-9-0mm-82-grains-85un-hen-sport-129525', '2022-05-01 04:18:40'),
(4, '129356', 'Rifle Airsoft 416 Neptune Black 6mm', 3, 'http://127.0.0.1/Fotos/317313-1.jpg', 0, 0, 'NAN', 'https://www.dispropil.com.br/rifle-airsoft-eletrico-416-neptune-black-6mm-rossi-129356', '2022-05-01 20:16:09'),
(5, '127709', 'Carabina de P. Sport UP 5.5mm Rossi', 8, 'http://127.0.0.1/Fotos/315040-7.jpg', 12, 2, 'B', 'https://www.dispropil.com.br/carabina-de-pressao-sport-up-5-5mm-%e2%80%93-rossi-127709', '2022-05-01 20:46:02'),
(6, '113688', 'Chumbinho D. JSB Exact 4.5mm 500un', 22, 'http://127.0.0.1/Fotos/300511.jpg', 1, 1, 'C', 'https://www.dispropil.com.br/chumbinho-diabolo-jsb-exact-4-5mm-500un-113688', '2022-05-01 20:51:42'),
(7, '115222', 'Chumbinho R.F Energy 5.5mm 100un Gamo', 20, 'http://127.0.0.1/Fotos/302045.jpeg', 1, 4, 'C', 'https://www.dispropil.com.br/chumbinho-red-fire-energy-5-5mm-100un-gamo-115222', '2022-05-01 21:16:28');

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuarios`
--

CREATE TABLE `usuarios` (
  `id` int(6) UNSIGNED NOT NULL,
  `usuario` varchar(30) NOT NULL,
  `senha` varchar(30) NOT NULL,
  `foto` varchar(50) DEFAULT NULL,
  `acesslevel` int(6) DEFAULT NULL,
  `reg_date` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `setor` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `usuarios`
--

INSERT INTO `usuarios` (`id`, `usuario`, `senha`, `foto`, `acesslevel`, `reg_date`, `setor`) VALUES
(1, 'Alisson', '91082439', 'https://i.imgur.com/UUaOEvy.jpg', 2, '2022-04-29 23:07:29', NULL),
(2, 'Naor', '91082439', 'https://recursos.dispropil.com.br/i/SVG-diversos/l', 1, '2022-05-04 23:27:28', 'Administração'),
(3, 'Lucas', '123456', 'https://recursos.dispropil.com.br/i/SVG-diversos/l', 1, '2022-05-04 23:41:02', 'Administração'),
(4, 'Tiao', '123456', 'https://recursos.dispropil.com.br/i/SVG-diversos/l', 1, '2022-05-04 23:41:13', 'Expedição');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `produtos`
--
ALTER TABLE `produtos`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `produtos`
--
ALTER TABLE `produtos`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de tabela `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(6) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
