-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: localhost
-- Üretim Zamanı: 17 Eyl 2021, 13:15:57
-- Sunucu sürümü: 8.0.23
-- PHP Sürümü: 7.3.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `bayipanel`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `evrak`
--

CREATE TABLE `evrak` (
  `evrakId` int NOT NULL,
  `evrakDurum` varchar(45) NOT NULL,
  `evrakYol` varchar(100) NOT NULL,
  `evrakAd` varchar(45) NOT NULL,
  `evrakAciklama` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `firma`
--

CREATE TABLE `firma` (
  `firmaId` int NOT NULL,
  `firmaAd` varchar(100) NOT NULL,
  `faaliyet` varchar(40) NOT NULL,
  `adres` varchar(100) NOT NULL,
  `mail` varchar(200) NOT NULL,
  `tel` varchar(20) NOT NULL,
  `vergiDairesi` varchar(45) NOT NULL,
  `vergiNo` longtext NOT NULL,
  `firmaYetkiliAd` varchar(45) NOT NULL,
  `firmaYetkiliSoyad` varchar(45) NOT NULL,
  `yetkiliUnvan` varchar(45) NOT NULL,
  `yetkiliTel` varchar(20) NOT NULL,
  `durum` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Tablo döküm verisi `firma`
--

INSERT INTO `firma` (`firmaId`, `firmaAd`, `faaliyet`, `adres`, `mail`, `tel`, `vergiDairesi`, `vergiNo`, `firmaYetkiliAd`, `firmaYetkiliSoyad`, `yetkiliUnvan`, `yetkiliTel`, `durum`) VALUES
(37, 'bir', 'r', 'gghgh', 'r', '(444) 444-4444', 'r', '4', 'f', 'f', 'f', '(555) 555-5555', 'ONAYLANMADI'),
(38, 'iki', 'faaliyet', 'v', 'v', '(444) 444-4444', 'v', '7', 'g', 'g', 'g', '(555) 555-5555', 'ONAYLANDI'),
(39, 'üç', 'c', 'adres', 'c', '(777) 777-7777', 'c', '3', 'g', 'g', 'g', '(555) 555-5555', 'ONAYLANMADI'),
(40, 'firma ad', 'b', 'ggggg', 'mail', '(444) 444-4444', 'v', '4', 'v', 'v', 'v', '(555) 555-5555', 'ONAYLANDI'),
(42, 'b', 'b', 'b', 'b', '(444) 444-4444', 'vergiDairesi', '5', 'b', 'b', 'b', '(555) 555-5555', 'ONAYLANDI'),
(51, 'aa', 'a', 'a', 'a@a.com', '(333) 333-3333', 'a', '7', 'aa', 'ss', 'uu', '(444) 444-4444', 'ONAYLANDI'),
(53, 'ad', 'faaliyet', 'adresjuj', 'a@a.com', '(543) 545-4545', 'aa', '4444', 'a', 's', 'u', '(543) 897-6767', 'ONAYLANDI'),
(54, 'a', 'a', 'a', 'a@a.com', '(111) 111-1111', 's', '11111100', 'a', 'a', 'a', '(222) 222-2222', 'ONAYLANDI'),
(55, 'a', 'a', 'a', 'a@a.com', '(444) 444-4444', 'd', '4.55256e17', 'a', 'a', 'a', '(666) 666-6666', 'ONAYLANDI'),
(56, 'a', 's', 'gff', 'a@a.com', '(676) 767-8676', 'fd', '645645456456', 'g', 's', 'g', '(878) 787-8779', 'ONAYLANDI'),
(57, 'son', 's', 's', 's@s.com', '(444) 444-4444', 'd', '98742754873', 'a', 's', 'u', '(786) 743-6573', 'ONAYLANDI');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kullanici`
--

CREATE TABLE `kullanici` (
  `kullaniciId` int NOT NULL,
  `kullaniciAd` varchar(45) NOT NULL,
  `sifre` int NOT NULL,
  `ad` varchar(45) NOT NULL,
  `soyad` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Tablo döküm verisi `kullanici`
--

INSERT INTO `kullanici` (`kullaniciId`, `kullaniciAd`, `sifre`, `ad`, `soyad`) VALUES
(1, 'e', 1, 'e', 'y');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `programtipi`
--

CREATE TABLE `programtipi` (
  `programTipId` int NOT NULL,
  `programAd` varchar(45) NOT NULL,
  `programTutar` double NOT NULL,
  `platform` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='			';

--
-- Tablo döküm verisi `programtipi`
--

INSERT INTO `programtipi` (`programTipId`, `programAd`, `programTutar`, `platform`) VALUES
(1, 'Online Muhsebe', 2500, 'Online'),
(2, 'Online Muhsebe2', 2500, 'Online'),
(3, 'Online Muhsebe3', 2500, 'Online'),
(4, 'Online Muhsebe4', 2500, 'Online'),
(5, 'Online Muhsebe5', 2500, 'Online');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `urun`
--

CREATE TABLE `urun` (
  `urunId` int NOT NULL,
  `firmaId` int NOT NULL,
  `satisTarih` varchar(40) DEFAULT NULL,
  `kayitTarih` datetime NOT NULL,
  `tutar` double NOT NULL,
  `komisyonTutar` double NOT NULL,
  `programTip` varchar(45) NOT NULL,
  `tarih` datetime NOT NULL,
  `aciklama` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Tablo döküm verisi `urun`
--

INSERT INTO `urun` (`urunId`, `firmaId`, `satisTarih`, `kayitTarih`, `tutar`, `komisyonTutar`, `programTip`, `tarih`, `aciklama`) VALUES
(1, 40, '7.09.2021 13:18:13', '2021-09-14 13:18:13', 3, 3, 'Online Muhsebe', '2021-09-16 11:35:19', 'fd'),
(5, 40, NULL, '2021-09-09 16:31:39', 4, 4, 'Online Muhsebe2', '2021-09-16 16:14:41', 'a'),
(6, 40, '6.09.2021 09:26:12', '2021-09-01 09:26:12', 23, 24, 'Online Muhsebe5', '2021-09-16 11:35:01', 'e'),
(10, 40, NULL, '2021-09-02 09:26:12', 30, 12, 'Online Muhsebe3', '2021-09-16 16:14:37', 'a'),
(11, 40, NULL, '2021-09-01 09:26:12', 10, 10, 'Online Muhsebe2', '2021-09-16 16:14:49', 'd'),
(19, 37, NULL, '2021-09-22 01:53:09', 50, 55, 'Online Muhsebe3', '2021-09-16 14:31:39', 'xxx'),
(21, 38, NULL, '2021-09-16 02:00:52', 30, 30, 'Online Muhsebe5', '2021-09-16 02:01:13', 'tttt'),
(22, 38, '16.09.2021 02:01:20', '2021-09-16 02:01:21', 30, 20, 'Online Muhsebe4', '2021-09-16 02:01:35', 'ff'),
(23, 37, '16.09.2021 02:05:15', '2021-09-16 02:05:16', 20, 20, 'Online Muhsebe5', '2021-09-16 02:21:33', 'rr'),
(25, 38, NULL, '2021-09-17 02:11:38', 40, 50, 'Online Muhsebe2', '2021-09-16 02:11:52', 'ac'),
(26, 40, NULL, '2021-09-16 02:12:53', 20, 31, 'Online Muhsebe2', '2021-09-16 16:14:45', 's'),
(27, 40, '16.09.2021 02:13:12', '2021-09-16 02:13:12', 13, 13, 'Online Muhsebe4', '2021-09-16 02:13:22', 'aaa'),
(28, 42, '17.09.2021 02:23:06', '2021-09-16 02:22:29', 12, 16, 'Online Muhsebe2', '2021-09-16 02:23:19', 'a'),
(29, 42, '16.09.2021 02:22:37', '2021-09-16 02:22:37', 20, 30, 'Online Muhsebe5', '2021-09-16 02:23:30', 'a'),
(30, 53, '17.09.2021 11:24:54', '2021-09-16 11:21:37', 1200, 1500, 'Online Muhsebe4', '2021-09-16 11:31:15', 'nmnnmnmnm'),
(31, 39, NULL, '2021-09-16 11:32:36', 500, 550, 'Online Muhsebe5', '2021-09-16 11:34:27', 'a'),
(32, 39, '17.09.2021 11:32:50', '2021-09-17 11:32:50', 450, 550, 'Online Muhsebe', '2021-09-16 11:33:24', 'b'),
(33, 39, NULL, '2021-09-17 11:33:40', 300, 330, 'Online Muhsebe4', '2021-09-16 11:34:14', 'n'),
(34, 51, NULL, '2021-09-16 11:35:53', 100, 120, 'Online Muhsebe4', '2021-09-16 11:36:02', 'a'),
(36, 56, '24.09.2021 12:37:18', '2021-09-16 12:36:54', 500, 560, 'Online Muhsebe4', '2021-09-16 12:37:36', 'acıklama'),
(37, 56, '16.09.2021 12:37:06', '2021-09-16 12:37:07', 400, 450, 'Online Muhsebe4', '2021-09-16 12:37:42', 'fdf'),
(38, 37, '17.09.2021 14:31:41', '2021-09-16 14:31:41', 300, 350, 'Online Muhsebe5', '2021-09-16 14:31:55', 'ac'),
(40, 39, '17.09.2021 17:34:51', '2021-09-01 17:33:11', 234, 234, 'Online Muhsebe5', '2021-09-16 17:34:57', 'acık'),
(41, 39, '16.09.2021 17:33:32', '2021-09-07 17:33:32', 500, 500, 'Online Muhsebe3', '2021-09-16 17:33:52', 'kıkıkı');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `evrak`
--
ALTER TABLE `evrak`
  ADD PRIMARY KEY (`evrakId`);

--
-- Tablo için indeksler `firma`
--
ALTER TABLE `firma`
  ADD PRIMARY KEY (`firmaId`);

--
-- Tablo için indeksler `kullanici`
--
ALTER TABLE `kullanici`
  ADD PRIMARY KEY (`kullaniciId`);

--
-- Tablo için indeksler `programtipi`
--
ALTER TABLE `programtipi`
  ADD PRIMARY KEY (`programTipId`);

--
-- Tablo için indeksler `urun`
--
ALTER TABLE `urun`
  ADD PRIMARY KEY (`urunId`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `evrak`
--
ALTER TABLE `evrak`
  MODIFY `evrakId` int NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `firma`
--
ALTER TABLE `firma`
  MODIFY `firmaId` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=58;

--
-- Tablo için AUTO_INCREMENT değeri `kullanici`
--
ALTER TABLE `kullanici`
  MODIFY `kullaniciId` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Tablo için AUTO_INCREMENT değeri `programtipi`
--
ALTER TABLE `programtipi`
  MODIFY `programTipId` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Tablo için AUTO_INCREMENT değeri `urun`
--
ALTER TABLE `urun`
  MODIFY `urunId` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=42;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
