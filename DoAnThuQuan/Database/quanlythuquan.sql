-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th5 13, 2025 lúc 08:35 AM
-- Phiên bản máy phục vụ: 10.4.32-MariaDB
-- Phiên bản PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `quanlythuquan`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `check_in_out`
--

CREATE TABLE `check_in_out` (
  `user_id` int(11) NOT NULL,
  `time_in` datetime NOT NULL,
  `time_out` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `check_in_out`
--

INSERT INTO `check_in_out` (`user_id`, `time_in`, `time_out`) VALUES
(1, '2025-03-11 08:00:00', '2025-03-11 12:00:00'),
(2, '2025-03-11 09:00:00', '2025-03-11 15:00:00'),
(3, '2025-03-11 10:00:00', '2025-03-11 14:00:00'),
(4, '2025-03-11 13:00:00', '2025-03-11 17:00:00'),
(5, '2025-03-11 14:00:00', '2025-03-11 18:00:00');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `chitiet_phathudo`
--

CREATE TABLE `chitiet_phathudo` (
  `id_phieuphatHuDo` int(11) NOT NULL,
  `id_mondo` varchar(10) NOT NULL,
  `mota` text NOT NULL,
  `tien` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `chitiet_phathudo`
--

INSERT INTO `chitiet_phathudo` (`id_phieuphatHuDo`, `id_mondo`, `mota`, `tien`) VALUES
(1, 'MD001', 'Sách bị rách trang 10', 50000),
(1, 'MD002', 'Sách bị mất bìa', 100000),
(2, 'MD003', 'Sách bị ghi chú', 30000),
(3, 'MD004', 'Sách bị ướt', 40000),
(4, 'MD005', 'Sách bị mất', 150000);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `chitiet_phieudatcho`
--

CREATE TABLE `chitiet_phieudatcho` (
  `id_chitiet_phieudatcho` int(11) NOT NULL,
  `id_thietbi` varchar(255) DEFAULT NULL,
  `gia_tien` int(11) DEFAULT NULL,
  `id_phieudatcho` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_vietnamese_ci;

--
-- Đang đổ dữ liệu cho bảng `chitiet_phieudatcho`
--

INSERT INTO `chitiet_phieudatcho` (`id_chitiet_phieudatcho`, `id_thietbi`, `gia_tien`, `id_phieudatcho`) VALUES
(1, 'MC001', 12000, 1),
(2, 'MC003', 15000, 1),
(3, 'MT001', 15000, 1),
(4, 'MT003', 50000, 1),
(5, 'MT004', 5000, 1),
(6, 'MT005', 8000, 1),
(7, 'MC003', 15000, 2),
(8, 'MT004', 5000, 2),
(9, 'MC001', 12000, 3),
(10, 'MT004', 5000, 3),
(11, 'MC001', 12000, 4),
(12, 'MT001', 15000, 4),
(13, 'MC001', 12000, 5),
(14, 'MT003', 50000, 5),
(15, 'MC001', 12000, 6),
(16, 'MT003', 50000, 6);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `chitiet_phieumuon`
--

CREATE TABLE `chitiet_phieumuon` (
  `id_phieumuon` int(11) NOT NULL,
  `id_mondo` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `chitiet_phieumuon`
--

INSERT INTO `chitiet_phieumuon` (`id_phieumuon`, `id_mondo`) VALUES
(1, 'MD001'),
(1, 'MD002'),
(2, 'MD003'),
(3, 'MD004'),
(4, 'MD005');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `chitiet_phieunhap`
--

CREATE TABLE `chitiet_phieunhap` (
  `id_phieunhap` int(11) NOT NULL,
  `id_sanpham` int(11) NOT NULL,
  `loai_sanpham` varchar(50) NOT NULL,
  `thanh_tien` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `chitiet_phieunhap`
--

INSERT INTO `chitiet_phieunhap` (`id_phieunhap`, `id_sanpham`, `loai_sanpham`, `thanh_tien`) VALUES
(1, 1, 'sách', 20000),
(1, 1, 'sách', 20000),
(1, 1, 'sách', 20000);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `chitiet_phieutra`
--

CREATE TABLE `chitiet_phieutra` (
  `id_phieutra` int(11) NOT NULL,
  `id_mondo` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `chitiet_phieutra`
--

INSERT INTO `chitiet_phieutra` (`id_phieutra`, `id_mondo`) VALUES
(1, 'MD001'),
(1, 'MD002'),
(2, 'MD003'),
(3, 'MD004'),
(4, 'MD005'),
(1, 'MD001'),
(1, 'MD002'),
(2, 'MD003'),
(3, 'MD004'),
(4, 'MD005');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `cho_ngoi`
--

CREATE TABLE `cho_ngoi` (
  `id_chongoi` int(11) NOT NULL,
  `id_phong` int(11) NOT NULL,
  `status` int(11) NOT NULL,
  `vi_tri` int(11) DEFAULT NULL,
  `so_luong` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `cho_ngoi`
--

INSERT INTO `cho_ngoi` (`id_chongoi`, `id_phong`, `status`, `vi_tri`, `so_luong`) VALUES
(1, 1, 1, 1, 3),
(2, 1, 0, 2, 4),
(3, 2, 1, 3, 2),
(4, 2, 0, 1, 2),
(5, 3, 1, 5, 5);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `ke`
--

CREATE TABLE `ke` (
  `id_ke` int(11) NOT NULL,
  `id_khuvuc` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `ke`
--

INSERT INTO `ke` (`id_ke`, `id_khuvuc`) VALUES
(1, 1),
(2, 1),
(3, 2),
(4, 2),
(5, 3);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `khu_vuc`
--

CREATE TABLE `khu_vuc` (
  `id_khuvuc` int(11) NOT NULL,
  `ten_khuvuc` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `khu_vuc`
--

INSERT INTO `khu_vuc` (`id_khuvuc`, `ten_khuvuc`) VALUES
(1, 'Khu A'),
(2, 'Khu B'),
(3, 'Khu C'),
(4, 'Khu D'),
(5, 'Khu E');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `maychieu`
--

CREATE TABLE `maychieu` (
  `id_seri_maychieu` varchar(10) NOT NULL,
  `status` int(11) NOT NULL,
  `so_luong` int(11) DEFAULT NULL,
  `link` varchar(255) DEFAULT NULL,
  `gia_tien` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `maychieu`
--

INSERT INTO `maychieu` (`id_seri_maychieu`, `status`, `so_luong`, `link`, `gia_tien`) VALUES
('MC001', 1, 10, '\\img\\may-chieu-epson-ebe10-3600-ansilumen-i9j4QY.png', 12000),
('MC002', 1, 1, '\\img\\may-chieu-epson-ebe10-3600-ansilumen-i9j4QY.png', 10000),
('MC003', 1, 0, '\\img\\may-chieu-epson-ebe10-3600-ansilumen-i9j4QY.png', 15000),
('MC004', 0, 12, '\\img\\may-chieu-epson-ebe10-3600-ansilumen-i9j4QY.png', 20000),
('MC005', 1, 2, '\\img\\may-chieu-epson-ebe10-3600-ansilumen-i9j4QY.png', 20000);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `maytinh`
--

CREATE TABLE `maytinh` (
  `id_seri_maytinh` varchar(10) NOT NULL,
  `status` int(11) NOT NULL,
  `so_luong` int(11) DEFAULT NULL,
  `link` varchar(255) DEFAULT NULL,
  `gia_tien` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `maytinh`
--

INSERT INTO `maytinh` (`id_seri_maytinh`, `status`, `so_luong`, `link`, `gia_tien`) VALUES
('MT001', 1, 15, '\\img\\May-Bo-Dell-OptiPlex-7010SFF-Ke-Toan-i7-3770.jpg', 15000),
('MT002', 0, 2, '\\img\\May-Bo-Dell-OptiPlex-7010SFF-Ke-Toan-i7-3770.jpg\\img\\May-Bo-Dell-OptiPlex-7010SFF-Ke-Toan-i7-3770.jpg', 20000),
('MT003', 1, 1, '\\img\\May-Bo-Dell-OptiPlex-7010SFF-Ke-Toan-i7-3770.jpg', 50000),
('MT004', 1, 1, '\\img\\May-Bo-Dell-OptiPlex-7010SFF-Ke-Toan-i7-3770.jpg', 5000),
('MT005', 1, 3, '\\img\\May-Bo-Dell-OptiPlex-7010SFF-Ke-Toan-i7-3770.jpg', 8000);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `phieuphat_hudo`
--

CREATE TABLE `phieuphat_hudo` (
  `id_phieuphatHuDo` int(11) NOT NULL,
  `id_phieutra` int(11) NOT NULL,
  `solg` int(11) NOT NULL,
  `tongtien` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `phieuphat_hudo`
--

INSERT INTO `phieuphat_hudo` (`id_phieuphatHuDo`, `id_phieutra`, `solg`, `tongtien`) VALUES
(1, 1, 2, 150000),
(2, 2, 1, 30000),
(3, 3, 1, 40000),
(4, 4, 1, 150000),
(5, 5, 0, 0);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `phieu_datcho`
--

CREATE TABLE `phieu_datcho` (
  `id_phieudatcho` int(11) NOT NULL,
  `ngdatcho` int(11) NOT NULL,
  `id_chongoi` int(11) NOT NULL,
  `create_at` datetime NOT NULL,
  `tgian` datetime NOT NULL,
  `status` int(11) NOT NULL,
  `so_tien` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `phieu_datcho`
--

INSERT INTO `phieu_datcho` (`id_phieudatcho`, `ngdatcho`, `id_chongoi`, `create_at`, `tgian`, `status`, `so_tien`) VALUES
(1, 2, 1, '2025-04-17 16:52:56', '2025-04-24 16:52:00', 1, 0),
(3, 2, 3, '2025-04-17 16:57:51', '2025-04-24 16:59:00', 1, 13000);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `phieu_muon`
--

CREATE TABLE `phieu_muon` (
  `id_phieumuon` int(11) NOT NULL,
  `tgian_muon` datetime NOT NULL,
  `solg` int(11) NOT NULL,
  `ngmuon` int(11) NOT NULL,
  `nvien` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `phieu_muon`
--

INSERT INTO `phieu_muon` (`id_phieumuon`, `tgian_muon`, `solg`, `ngmuon`, `nvien`) VALUES
(1, '2025-03-01 09:00:00', 2, 1, 2),
(2, '2025-03-02 10:00:00', 1, 2, 3),
(3, '2025-03-03 11:00:00', 1, 3, 4),
(5, '2025-03-05 13:00:00', 0, 5, 1);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `phieu_nhaphang`
--

CREATE TABLE `phieu_nhaphang` (
  `id_phieunhap` int(11) NOT NULL,
  `ngay_nhap` date NOT NULL,
  `id_nhanvien` int(11) NOT NULL,
  `solg_sach` int(50) NOT NULL,
  `solg_maytinh` int(11) NOT NULL,
  `solg_maychieu` int(11) NOT NULL,
  `tong_tien` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `phieu_nhaphang`
--

INSERT INTO `phieu_nhaphang` (`id_phieunhap`, `ngay_nhap`, `id_nhanvien`, `solg_sach`, `solg_maytinh`, `solg_maychieu`, `tong_tien`) VALUES
(1, '2025-04-20', 1, 3, 0, 0, 60000);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `phieu_tra`
--

CREATE TABLE `phieu_tra` (
  `id_phieutra` int(11) NOT NULL,
  `tgian_tra` datetime NOT NULL,
  `id_phieumuon` int(11) NOT NULL,
  `mota` text NOT NULL,
  `nvien` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `phieu_tra`
--

INSERT INTO `phieu_tra` (`id_phieutra`, `tgian_tra`, `id_phieumuon`, `mota`, `nvien`) VALUES
(2, '2025-03-11 10:00:00', 2, 'Trả trễ 1 ngày', 3),
(4, '2025-03-11 12:00:00', 4, 'Trả đúng hạn', 5),
(5, '2025-03-11 13:00:00', 5, 'Không có sách', 1);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `phong`
--

CREATE TABLE `phong` (
  `id_phong` int(11) NOT NULL,
  `solgchongoi` int(11) NOT NULL,
  `status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `phong`
--

INSERT INTO `phong` (`id_phong`, `solgchongoi`, `status`) VALUES
(1, 10, 1),
(2, 15, 0),
(3, 20, 1),
(4, 25, 0),
(5, 30, 1);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `sach`
--

CREATE TABLE `sach` (
  `id_sach` int(11) NOT NULL,
  `ten_sach` varchar(50) NOT NULL,
  `id_theloaisach` int(11) NOT NULL,
  `tacgia` text NOT NULL,
  `id_ke` int(11) NOT NULL,
  `mota` text NOT NULL,
  `thanh_tien` int(11) NOT NULL,
  `status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `sach`
--

INSERT INTO `sach` (`id_sach`, `ten_sach`, `id_theloaisach`, `tacgia`, `id_ke`, `mota`, `thanh_tien`, `status`) VALUES
(1, 'Lập trình C', 1, 'Nguyễn Văn A', 1, 'Sách lập trình cơ bản', 20000, 1),
(2, 'Giấc mwo của tôi là em', 3, 'Cao Tiến Cường', 1, 'Chỉ dành cho 1 người', 100000, 1),
(3, 'Người con gái duy nhất chấm nhận tính cách tôi', 3, 'Cao Tiến Cường', 1, 'Tôi rất quý cô ấy', 100000, 1),
(4, 'Hóa học 12', 4, 'Lê Văn D', 4, 'Sách học sinh lớp 12', 28000, 0),
(5, 'Lịch sử thế giới', 5, 'Hoàng Văn E', 5, 'Lịch sử thế kỷ 20', 27000, 1),
(6, 'ưadfb', 3, 'cuong', 4, 'hello', 10000, 1),
(7, 'wdscxv ', 6, 'phuong', 3, 'love', 100000, 1),
(8, 'Làm Đĩ', 3, 'Vũ Trọng Phụng', 2, 'Phê phán thời xưa', 80000, 1),
(9, 'Trạng Quỳnh tập 1', 7, 'quên rồi', 5, 'hay', 15000, 1);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `sach_detail`
--

CREATE TABLE `sach_detail` (
  `id_serisach` varchar(10) NOT NULL,
  `id_sach` int(11) NOT NULL,
  `status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `sach_detail`
--

INSERT INTO `sach_detail` (`id_serisach`, `id_sach`, `status`) VALUES
('MD001', 1, 1),
('MD002', 2, 1),
('MD003', 3, 1),
('MD004', 4, 0),
('MD005', 5, 1),
('MD006', 6, 0),
('MD007', 7, 0),
('MD008', 8, 1),
('MD009', 8, 1),
('MD010', 9, 1),
('MD011', 1, 1);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `theloai_sach`
--

CREATE TABLE `theloai_sach` (
  `id_theloaisach` int(11) NOT NULL,
  `ten_theloai` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `theloai_sach`
--

INSERT INTO `theloai_sach` (`id_theloaisach`, `ten_theloai`) VALUES
(1, 'Công nghệ'),
(2, 'Toán học'),
(3, 'Văn học'),
(4, 'Hóa học'),
(5, 'Lịch sử'),
(6, 'Vật lý'),
(7, 'Truyện tranh');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `thietbi`
--

CREATE TABLE `thietbi` (
  `id_thietbi` int(11) NOT NULL,
  `ten_thietbi` varchar(50) NOT NULL,
  `so_lg` int(11) NOT NULL,
  `status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `thietbi`
--

INSERT INTO `thietbi` (`id_thietbi`, `ten_thietbi`, `so_lg`, `status`) VALUES
(1, 'Máy chiếu', 5, 1),
(2, 'Máy tính', 10, 0),
(3, 'Loa', 3, 1),
(4, 'Bàn học', 20, 0),
(5, 'Ghế', 50, 1);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `user`
--

CREATE TABLE `user` (
  `user_id` int(11) NOT NULL,
  `user_name` varchar(50) NOT NULL,
  `password` text NOT NULL,
  `full_name` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `sodienthoai` varchar(10) NOT NULL,
  `diachi` text NOT NULL,
  `quyen` int(11) NOT NULL,
  `status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `user`
--

INSERT INTO `user` (`user_id`, `user_name`, `password`, `full_name`, `email`, `sodienthoai`, `diachi`, `quyen`, `status`) VALUES
(1, 'cuonghero9a', 'cuong10a07', 'Cao Tiến Cường', 'cuong@gmail.com', '0962385165', 'abc tp HCM', 0, 1),
(2, 'cuongtester01', 'cuong11a07', 'abcdef', 'cuongcao@gmail.com', '0818707056', 'abc tp HCM', 1, 1),
(3, 'admin1', 'admin1', 'admin', 'admin@gmail.com', '0912345678', 'admin admin', 0, 1),
(4, 'staff123', 'staff123', 'staff', 'staff2025@gmail.com', '0987654321', 'abc def', 0, 1),
(5, 'thanhphuong35', 'thanhphuong2004', 'Nguyễn Hoàng Thanh Phương', 'thanhphuong123@gmail.com', '0312482378', 'tp HCM', 1, 1);

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `check_in_out`
--
ALTER TABLE `check_in_out`
  ADD KEY `user_id` (`user_id`);

--
-- Chỉ mục cho bảng `chitiet_phathudo`
--
ALTER TABLE `chitiet_phathudo`
  ADD KEY `id_phieuphatHuDo` (`id_phieuphatHuDo`);

--
-- Chỉ mục cho bảng `chitiet_phieumuon`
--
ALTER TABLE `chitiet_phieumuon`
  ADD KEY `id_phieumuon` (`id_phieumuon`);

--
-- Chỉ mục cho bảng `chitiet_phieutra`
--
ALTER TABLE `chitiet_phieutra`
  ADD KEY `id_phieutra` (`id_phieutra`);

--
-- Chỉ mục cho bảng `cho_ngoi`
--
ALTER TABLE `cho_ngoi`
  ADD PRIMARY KEY (`id_chongoi`),
  ADD KEY `id_phong` (`id_phong`);

--
-- Chỉ mục cho bảng `ke`
--
ALTER TABLE `ke`
  ADD PRIMARY KEY (`id_ke`),
  ADD KEY `id_khuvuc` (`id_khuvuc`);

--
-- Chỉ mục cho bảng `khu_vuc`
--
ALTER TABLE `khu_vuc`
  ADD PRIMARY KEY (`id_khuvuc`);

--
-- Chỉ mục cho bảng `maychieu`
--
ALTER TABLE `maychieu`
  ADD PRIMARY KEY (`id_seri_maychieu`);

--
-- Chỉ mục cho bảng `maytinh`
--
ALTER TABLE `maytinh`
  ADD PRIMARY KEY (`id_seri_maytinh`);

--
-- Chỉ mục cho bảng `phieuphat_hudo`
--
ALTER TABLE `phieuphat_hudo`
  ADD PRIMARY KEY (`id_phieuphatHuDo`),
  ADD KEY `id_phieutra` (`id_phieutra`);

--
-- Chỉ mục cho bảng `phieu_datcho`
--
ALTER TABLE `phieu_datcho`
  ADD PRIMARY KEY (`id_phieudatcho`),
  ADD KEY `ngdatcho` (`ngdatcho`),
  ADD KEY `id_chongoi` (`id_chongoi`);

--
-- Chỉ mục cho bảng `phieu_muon`
--
ALTER TABLE `phieu_muon`
  ADD PRIMARY KEY (`id_phieumuon`),
  ADD KEY `ngmuon` (`ngmuon`),
  ADD KEY `nvien` (`nvien`);

--
-- Chỉ mục cho bảng `phieu_nhaphang`
--
ALTER TABLE `phieu_nhaphang`
  ADD PRIMARY KEY (`id_phieunhap`);

--
-- Chỉ mục cho bảng `phieu_tra`
--
ALTER TABLE `phieu_tra`
  ADD PRIMARY KEY (`id_phieutra`),
  ADD KEY `nvien` (`nvien`),
  ADD KEY `id_phieumuon` (`id_phieumuon`);

--
-- Chỉ mục cho bảng `phong`
--
ALTER TABLE `phong`
  ADD PRIMARY KEY (`id_phong`);

--
-- Chỉ mục cho bảng `sach`
--
ALTER TABLE `sach`
  ADD PRIMARY KEY (`id_sach`),
  ADD KEY `id_theloaisach` (`id_theloaisach`),
  ADD KEY `id_ke` (`id_ke`);

--
-- Chỉ mục cho bảng `sach_detail`
--
ALTER TABLE `sach_detail`
  ADD PRIMARY KEY (`id_serisach`),
  ADD KEY `id_sach` (`id_sach`);

--
-- Chỉ mục cho bảng `theloai_sach`
--
ALTER TABLE `theloai_sach`
  ADD PRIMARY KEY (`id_theloaisach`);

--
-- Chỉ mục cho bảng `thietbi`
--
ALTER TABLE `thietbi`
  ADD PRIMARY KEY (`id_thietbi`);

--
-- Chỉ mục cho bảng `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT cho các bảng đã đổ
--

--
-- AUTO_INCREMENT cho bảng `phieu_datcho`
--
ALTER TABLE `phieu_datcho`
  MODIFY `id_phieudatcho` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT cho bảng `phieu_muon`
--
ALTER TABLE `phieu_muon`
  MODIFY `id_phieumuon` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT cho bảng `user`
--
ALTER TABLE `user`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Các ràng buộc cho các bảng đã đổ
--

--
-- Các ràng buộc cho bảng `chitiet_phathudo`
--
ALTER TABLE `chitiet_phathudo`
  ADD CONSTRAINT `chitiet_phathudo_ibfk_1` FOREIGN KEY (`id_phieuphatHuDo`) REFERENCES `phieuphat_hudo` (`id_phieuphatHuDo`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
