-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 09, 2021 at 08:19 PM
-- Server version: 10.4.18-MariaDB
-- PHP Version: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `aplicatie_librarie`
--

-- --------------------------------------------------------

--
-- Table structure for table `achizitie`
--

CREATE TABLE `achizitie` (
  `IdAchizitie` int(11) NOT NULL,
  `IdFurnizor` int(11) NOT NULL,
  `NrDocument` int(11) NOT NULL,
  `SerieDocument` varchar(10) COLLATE utf8_romanian_ci NOT NULL,
  `Data` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_romanian_ci;

--
-- Dumping data for table `achizitie`
--

INSERT INTO `achizitie` (`IdAchizitie`, `IdFurnizor`, `NrDocument`, `SerieDocument`, `Data`) VALUES
(1, 1, 1001, 'XJ', '2019-05-06'),
(2, 2, 1002, 'XJ', '2019-05-07');

-- --------------------------------------------------------

--
-- Table structure for table `autor`
--

CREATE TABLE `autor` (
  `IdAutor` int(11) NOT NULL,
  `Nume` varchar(50) COLLATE utf8_romanian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_romanian_ci;

--
-- Dumping data for table `autor`
--

INSERT INTO `autor` (`IdAutor`, `Nume`) VALUES
(2, 'Mihai Eminescu'),
(3, 'Mihail Sadoveanu'),
(4, 'Octavian Dospinescu'),
(5, 'Ion Creangă');

-- --------------------------------------------------------

--
-- Table structure for table `birotica`
--

CREATE TABLE `birotica` (
  `IdBirotica` int(11) NOT NULL,
  `Denumire` varchar(50) COLLATE utf8_romanian_ci NOT NULL,
  `Descriere` varchar(100) COLLATE utf8_romanian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_romanian_ci;

--
-- Dumping data for table `birotica`
--

INSERT INTO `birotica` (`IdBirotica`, `Denumire`, `Descriere`) VALUES
(1, 'Pix Pelican', 'Pix cu gel albastru, cu uscare rapidă, ce nu lasă urme.'),
(2, 'Caiet de matematică', 'Caiet de matematică cu 100 de file A4');

-- --------------------------------------------------------

--
-- Table structure for table `carte`
--

CREATE TABLE `carte` (
  `IdCarte` int(11) NOT NULL,
  `ISBN` varchar(11) COLLATE utf8_romanian_ci NOT NULL,
  `Titlu` varchar(100) COLLATE utf8_romanian_ci NOT NULL,
  `Descriere` varchar(100) COLLATE utf8_romanian_ci NOT NULL,
  `IdEditura` int(11) NOT NULL,
  `An` int(11) NOT NULL,
  `NrPagini` int(11) NOT NULL,
  `Locatie` varchar(11) COLLATE utf8_romanian_ci NOT NULL,
  `IdAutor` int(11) NOT NULL,
  `IdDomeniu` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_romanian_ci;

--
-- Dumping data for table `carte`
--

INSERT INTO `carte` (`IdCarte`, `ISBN`, `Titlu`, `Descriere`, `IdEditura`, `An`, `NrPagini`, `Locatie`, `IdAutor`, `IdDomeniu`) VALUES
(1, '15479389789', 'Poezii de Dor', 'Carte de literatură cu poeziile cele mai cunoscute ale lui Mihai Eminescu.', 1, 2003, 87, 'C0508', 2, 1),
(2, '19546896522', 'Programare in C#', 'Invată programarea in C# de la 0.\r\nCartea contine pe langa teorie, probleme si exemple.', 2, 2010, 150, 'F0410', 4, 2);

-- --------------------------------------------------------

--
-- Stand-in structure for view `cartedetaliu`
-- (See below for the actual view)
--
CREATE TABLE `cartedetaliu` (
`Id` int(11)
,`Produs` varchar(25)
,`Titlu` varchar(100)
,`Descriere` varchar(100)
,`Pret` double
,`Cantitate` int(11)
,`ISBN` varchar(11)
,`An` varchar(11)
,`NrPagini` varchar(11)
,`Locatie` varchar(11)
,`Autor` varchar(50)
,`Domeniu` varchar(50)
,`Editura` varchar(50)
);

-- --------------------------------------------------------

--
-- Table structure for table `client`
--

CREATE TABLE `client` (
  `IdClient` int(11) NOT NULL,
  `Nume` varchar(50) COLLATE utf8_romanian_ci NOT NULL,
  `Varsta` int(11) NOT NULL,
  `Sex` varchar(10) COLLATE utf8_romanian_ci NOT NULL,
  `Email` varchar(50) COLLATE utf8_romanian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_romanian_ci;

--
-- Dumping data for table `client`
--

INSERT INTO `client` (`IdClient`, `Nume`, `Varsta`, `Sex`, `Email`) VALUES
(1, 'Popescu Ion', 17, 'masculin', 'Popescu.ion@gmail.com'),
(2, 'Ciobanu Ana', 34, 'feminin', 'CiobanuAna@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `domeniu`
--

CREATE TABLE `domeniu` (
  `IdDomeniu` int(11) NOT NULL,
  `Domeniu` varchar(50) COLLATE utf8_romanian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_romanian_ci;

--
-- Dumping data for table `domeniu`
--

INSERT INTO `domeniu` (`IdDomeniu`, `Domeniu`) VALUES
(1, 'Literatura'),
(2, 'Informatica');

-- --------------------------------------------------------

--
-- Table structure for table `editura`
--

CREATE TABLE `editura` (
  `IdEditura` int(11) NOT NULL,
  `Nume` varchar(50) COLLATE utf8_romanian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_romanian_ci;

--
-- Dumping data for table `editura`
--

INSERT INTO `editura` (`IdEditura`, `Nume`) VALUES
(1, 'Humanitas'),
(2, 'Economica'),
(3, 'Art'),
(4, 'Junimea');

-- --------------------------------------------------------

--
-- Table structure for table `furnizor`
--

CREATE TABLE `furnizor` (
  `IdFurnizor` int(11) NOT NULL,
  `Nume` varchar(50) COLLATE utf8_romanian_ci NOT NULL,
  `CUI` varchar(20) COLLATE utf8_romanian_ci NOT NULL,
  `Sold` double NOT NULL,
  `Email` varchar(50) COLLATE utf8_romanian_ci NOT NULL,
  `Telefon` varchar(12) COLLATE utf8_romanian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_romanian_ci;

--
-- Dumping data for table `furnizor`
--

INSERT INTO `furnizor` (`IdFurnizor`, `Nume`, `CUI`, `Sold`, `Email`, `Telefon`) VALUES
(0, 'Test', 'RO somethingsome', 2, 'test@gmail.com', '1234'),
(1, 'Cartea S.R.L.', 'RO146326xt', 0, 'Cartea@gmail.com', '123'),
(2, 'Pixar S.A.', 'RO1421486rt', 0, 'Pixar@gmail.com', '');

-- --------------------------------------------------------

--
-- Table structure for table `linieachizitie`
--

CREATE TABLE `linieachizitie` (
  `IdAchizitie` int(11) NOT NULL,
  `IdProdus` int(11) NOT NULL,
  `Cantitate` int(11) NOT NULL,
  `Pret` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_romanian_ci;

--
-- Dumping data for table `linieachizitie`
--

INSERT INTO `linieachizitie` (`IdAchizitie`, `IdProdus`, `Cantitate`, `Pret`) VALUES
(1, 1, 100, 1),
(1, 2, 50, 2),
(2, 3, 11, 15),
(2, 4, 14, 25);

-- --------------------------------------------------------

--
-- Table structure for table `linieoferta`
--

CREATE TABLE `linieoferta` (
  `IdOferta` int(11) NOT NULL,
  `IdProdus` int(11) NOT NULL,
  `PretFurnizor` double NOT NULL,
  `Cantitate` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_romanian_ci;

--
-- Dumping data for table `linieoferta`
--

INSERT INTO `linieoferta` (`IdOferta`, `IdProdus`, `PretFurnizor`, `Cantitate`) VALUES
(1, 3, 15, 100),
(2, 1, 1, 200),
(2, 2, 1, 150);

-- --------------------------------------------------------

--
-- Table structure for table `linievanzare`
--

CREATE TABLE `linievanzare` (
  `IdVanzare` int(11) NOT NULL,
  `IdProdus` int(11) NOT NULL,
  `Cantitate` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_romanian_ci;

--
-- Dumping data for table `linievanzare`
--

INSERT INTO `linievanzare` (`IdVanzare`, `IdProdus`, `Cantitate`) VALUES
(1, 1, 2),
(1, 2, 1),
(2, 1, 1),
(2, 3, 1);

-- --------------------------------------------------------

--
-- Table structure for table `oferta`
--

CREATE TABLE `oferta` (
  `IdOferta` int(11) NOT NULL,
  `DataExpirare` date NOT NULL,
  `IdFurnizor` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_romanian_ci;

--
-- Dumping data for table `oferta`
--

INSERT INTO `oferta` (`IdOferta`, `DataExpirare`, `IdFurnizor`) VALUES
(1, '2019-09-18', 1),
(2, '2021-10-31', 2);

-- --------------------------------------------------------

--
-- Table structure for table `plata`
--

CREATE TABLE `plata` (
  `IdPlata` int(11) NOT NULL,
  `SerieDocument` varchar(10) COLLATE utf8_romanian_ci NOT NULL,
  `NrDocument` int(11) NOT NULL,
  `Suma` double NOT NULL,
  `IdFurnizor` int(11) NOT NULL,
  `IdAchizitie` int(11) NOT NULL,
  `Data` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_romanian_ci;

--
-- Dumping data for table `plata`
--

INSERT INTO `plata` (`IdPlata`, `SerieDocument`, `NrDocument`, `Suma`, `IdFurnizor`, `IdAchizitie`, `Data`) VALUES
(1, '0123456', 1, 200, 1, 1, '2021-05-05');

-- --------------------------------------------------------

--
-- Stand-in structure for view `platadetaliu`
-- (See below for the actual view)
--
CREATE TABLE `platadetaliu` (
`IdPlata` int(11)
,`SerieDocument` varchar(10)
,`NrDocument` int(11)
,`Suma` double
,`IdFurnizor` int(11)
,`Furnizor` varchar(50)
,`IdAchizitie` int(11)
,`Data` date
);

-- --------------------------------------------------------

--
-- Table structure for table `produs`
--

CREATE TABLE `produs` (
  `IdProdus` int(11) NOT NULL,
  `IdTipProdus` int(11) NOT NULL,
  `Produs` int(11) NOT NULL,
  `Pret` double NOT NULL,
  `Cantitate` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_romanian_ci;

--
-- Dumping data for table `produs`
--

INSERT INTO `produs` (`IdProdus`, `IdTipProdus`, `Produs`, `Pret`, `Cantitate`) VALUES
(1, 2, 1, 2, 100),
(2, 2, 2, 5, 50),
(3, 1, 1, 30, 15),
(4, 1, 2, 40, 14);

-- --------------------------------------------------------

--
-- Table structure for table `tipprodus`
--

CREATE TABLE `tipprodus` (
  `IdTipProdus` int(11) NOT NULL,
  `TipProdus` varchar(25) COLLATE utf8_romanian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_romanian_ci;

--
-- Dumping data for table `tipprodus`
--

INSERT INTO `tipprodus` (`IdTipProdus`, `TipProdus`) VALUES
(1, 'Carte'),
(2, 'Birotica');

-- --------------------------------------------------------

--
-- Table structure for table `utilizator`
--

CREATE TABLE `utilizator` (
  `IdUtilizator` varchar(50) COLLATE utf8_romanian_ci NOT NULL,
  `Parola` varchar(50) COLLATE utf8_romanian_ci NOT NULL,
  `GradSecuritate` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_romanian_ci;

--
-- Dumping data for table `utilizator`
--

INSERT INTO `utilizator` (`IdUtilizator`, `Parola`, `GradSecuritate`) VALUES
('test', 'test', 1);

-- --------------------------------------------------------

--
-- Table structure for table `vanzari`
--

CREATE TABLE `vanzari` (
  `IdVanzare` int(11) NOT NULL,
  `IdClient` int(11) NOT NULL,
  `Data` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_romanian_ci ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `vanzari`
--

INSERT INTO `vanzari` (`IdVanzare`, `IdClient`, `Data`) VALUES
(1, 1, '2019-05-01'),
(2, 2, '2019-05-02');

-- --------------------------------------------------------

--
-- Structure for view `cartedetaliu`
--
DROP TABLE IF EXISTS `cartedetaliu`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `cartedetaliu`  AS SELECT `c`.`IdCarte` AS `Id`, `t`.`TipProdus` AS `Produs`, `c`.`Titlu` AS `Titlu`, `c`.`Descriere` AS `Descriere`, `p`.`Pret` AS `Pret`, `p`.`Cantitate` AS `Cantitate`, `c`.`ISBN` AS `ISBN`, `c`.`An` AS `An`, `c`.`NrPagini` AS `NrPagini`, `c`.`Locatie` AS `Locatie`, `a`.`Nume` AS `Autor`, `d`.`Domeniu` AS `Domeniu`, `e`.`Nume` AS `Editura` FROM (((((`carte` `c` join `autor` `a` on(`c`.`IdAutor` = `a`.`IdAutor`)) join `domeniu` `d` on(`c`.`IdDomeniu` = `d`.`IdDomeniu`)) join `editura` `e` on(`c`.`IdEditura` = `e`.`IdEditura`)) join `produs` `p` on(`c`.`IdCarte` = `p`.`Produs` and `p`.`IdTipProdus` = 1)) join `tipprodus` `t` on(`p`.`IdTipProdus` = `t`.`IdTipProdus`)) ;

-- --------------------------------------------------------

--
-- Structure for view `platadetaliu`
--
DROP TABLE IF EXISTS `platadetaliu`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `platadetaliu`  AS SELECT `p`.`IdPlata` AS `IdPlata`, `p`.`SerieDocument` AS `SerieDocument`, `p`.`NrDocument` AS `NrDocument`, `p`.`Suma` AS `Suma`, `p`.`IdFurnizor` AS `IdFurnizor`, `f`.`Nume` AS `Furnizor`, `p`.`IdAchizitie` AS `IdAchizitie`, `p`.`Data` AS `Data` FROM (`plata` `p` join `furnizor` `f` on(`p`.`IdFurnizor` = `f`.`IdFurnizor`)) ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `achizitie`
--
ALTER TABLE `achizitie`
  ADD PRIMARY KEY (`IdAchizitie`),
  ADD KEY `AchizitieFurnizor` (`IdFurnizor`);

--
-- Indexes for table `autor`
--
ALTER TABLE `autor`
  ADD PRIMARY KEY (`IdAutor`);

--
-- Indexes for table `birotica`
--
ALTER TABLE `birotica`
  ADD PRIMARY KEY (`IdBirotica`);

--
-- Indexes for table `carte`
--
ALTER TABLE `carte`
  ADD PRIMARY KEY (`IdCarte`),
  ADD UNIQUE KEY `ISBN` (`ISBN`),
  ADD KEY `CarteAutor` (`IdAutor`),
  ADD KEY `CarteEditura` (`IdEditura`),
  ADD KEY `CarteDomeniu` (`IdDomeniu`);

--
-- Indexes for table `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`IdClient`);

--
-- Indexes for table `domeniu`
--
ALTER TABLE `domeniu`
  ADD PRIMARY KEY (`IdDomeniu`);

--
-- Indexes for table `editura`
--
ALTER TABLE `editura`
  ADD PRIMARY KEY (`IdEditura`);

--
-- Indexes for table `furnizor`
--
ALTER TABLE `furnizor`
  ADD PRIMARY KEY (`IdFurnizor`);

--
-- Indexes for table `linieachizitie`
--
ALTER TABLE `linieachizitie`
  ADD PRIMARY KEY (`IdAchizitie`,`IdProdus`),
  ADD KEY `LinieA-Produs` (`IdProdus`);

--
-- Indexes for table `linieoferta`
--
ALTER TABLE `linieoferta`
  ADD PRIMARY KEY (`IdOferta`,`IdProdus`),
  ADD KEY `LinieO-Produs` (`IdProdus`);

--
-- Indexes for table `linievanzare`
--
ALTER TABLE `linievanzare`
  ADD PRIMARY KEY (`IdVanzare`,`IdProdus`),
  ADD KEY `LinieV-Produs` (`IdProdus`);

--
-- Indexes for table `oferta`
--
ALTER TABLE `oferta`
  ADD PRIMARY KEY (`IdOferta`),
  ADD KEY `OfertaFurnizor` (`IdFurnizor`);

--
-- Indexes for table `plata`
--
ALTER TABLE `plata`
  ADD PRIMARY KEY (`IdPlata`),
  ADD KEY `PlataFurnizor` (`IdFurnizor`),
  ADD KEY `PlataAchizitie` (`IdAchizitie`);

--
-- Indexes for table `produs`
--
ALTER TABLE `produs`
  ADD PRIMARY KEY (`IdProdus`),
  ADD KEY `IdTipProdus` (`IdTipProdus`);

--
-- Indexes for table `tipprodus`
--
ALTER TABLE `tipprodus`
  ADD PRIMARY KEY (`IdTipProdus`);

--
-- Indexes for table `utilizator`
--
ALTER TABLE `utilizator`
  ADD PRIMARY KEY (`IdUtilizator`);

--
-- Indexes for table `vanzari`
--
ALTER TABLE `vanzari`
  ADD PRIMARY KEY (`IdVanzare`),
  ADD KEY `VanzariClient` (`IdClient`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `autor`
--
ALTER TABLE `autor`
  MODIFY `IdAutor` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `domeniu`
--
ALTER TABLE `domeniu`
  MODIFY `IdDomeniu` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `editura`
--
ALTER TABLE `editura`
  MODIFY `IdEditura` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `oferta`
--
ALTER TABLE `oferta`
  MODIFY `IdOferta` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `plata`
--
ALTER TABLE `plata`
  MODIFY `IdPlata` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `produs`
--
ALTER TABLE `produs`
  MODIFY `IdProdus` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tipprodus`
--
ALTER TABLE `tipprodus`
  MODIFY `IdTipProdus` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `vanzari`
--
ALTER TABLE `vanzari`
  MODIFY `IdVanzare` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `achizitie`
--
ALTER TABLE `achizitie`
  ADD CONSTRAINT `AchizitieFurnizor` FOREIGN KEY (`IdFurnizor`) REFERENCES `furnizor` (`IdFurnizor`);

--
-- Constraints for table `carte`
--
ALTER TABLE `carte`
  ADD CONSTRAINT `CarteAutor` FOREIGN KEY (`IdAutor`) REFERENCES `autor` (`IdAutor`),
  ADD CONSTRAINT `CarteDomeniu` FOREIGN KEY (`IdDomeniu`) REFERENCES `domeniu` (`IdDomeniu`),
  ADD CONSTRAINT `CarteEditura` FOREIGN KEY (`IdEditura`) REFERENCES `editura` (`IdEditura`);

--
-- Constraints for table `linieachizitie`
--
ALTER TABLE `linieachizitie`
  ADD CONSTRAINT `LinieA-Achizitie` FOREIGN KEY (`IdAchizitie`) REFERENCES `achizitie` (`IdAchizitie`),
  ADD CONSTRAINT `LinieA-Produs` FOREIGN KEY (`IdProdus`) REFERENCES `produs` (`IdProdus`);

--
-- Constraints for table `linieoferta`
--
ALTER TABLE `linieoferta`
  ADD CONSTRAINT `LinieO-Oferta` FOREIGN KEY (`IdOferta`) REFERENCES `oferta` (`IdOferta`),
  ADD CONSTRAINT `LinieO-Produs` FOREIGN KEY (`IdProdus`) REFERENCES `produs` (`IdProdus`);

--
-- Constraints for table `linievanzare`
--
ALTER TABLE `linievanzare`
  ADD CONSTRAINT `LinieV-Produs` FOREIGN KEY (`IdProdus`) REFERENCES `produs` (`IdProdus`),
  ADD CONSTRAINT `LinieV-Vanzare` FOREIGN KEY (`IdVanzare`) REFERENCES `vanzari` (`IdVanzare`);

--
-- Constraints for table `oferta`
--
ALTER TABLE `oferta`
  ADD CONSTRAINT `OfertaFurnizor` FOREIGN KEY (`IdFurnizor`) REFERENCES `furnizor` (`IdFurnizor`);

--
-- Constraints for table `plata`
--
ALTER TABLE `plata`
  ADD CONSTRAINT `PlataAchizitie` FOREIGN KEY (`IdAchizitie`) REFERENCES `achizitie` (`IdAchizitie`),
  ADD CONSTRAINT `PlataFurnizor` FOREIGN KEY (`IdFurnizor`) REFERENCES `furnizor` (`IdFurnizor`);

--
-- Constraints for table `produs`
--
ALTER TABLE `produs`
  ADD CONSTRAINT `produs_ibfk_1` FOREIGN KEY (`IdTipProdus`) REFERENCES `tipprodus` (`IdTipProdus`);

--
-- Constraints for table `vanzari`
--
ALTER TABLE `vanzari`
  ADD CONSTRAINT `VanzariClient` FOREIGN KEY (`IdClient`) REFERENCES `client` (`IdClient`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
