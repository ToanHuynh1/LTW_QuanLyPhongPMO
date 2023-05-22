using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using PMO.Models;

namespace PMO
{
    public class Initializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {

            //NhiemVu
            /*var nv1 = context.nhiemVus.Add(new NhiemVu
            {
                TenNV = "Producer"

            });
            var nv2 = context.nhiemVus.Add(new NhiemVu
            {

                TenNV = "Editor"

            });
            var nv3 = context.nhiemVus.Add(new NhiemVu
            {

                TenNV = "CamOp"

            });
            var nv4 = context.nhiemVus.Add(new NhiemVu
            {

                TenNV = "Director"

            });
            var nv5 = context.nhiemVus.Add(new NhiemVu
            {

                TenNV = "Scriptwrite"

            });
            var nv6 = context.nhiemVus.Add(new NhiemVu
            {

                TenNV = "Assistant Director"

            });

            //ChucVu
            var cv1 = context.chucVus.Add(new ChucVu
            {
                TenChucVu = "Trưởng Phòng"

            });
            var cv2 = context.chucVus.Add(new ChucVu
            {
                TenChucVu = "Nhân Viên"

            });
            var cv3 = context.chucVus.Add(new ChucVu
            {
                TenChucVu = "Newbie"

            });
            var cv4 = context.chucVus.Add(new ChucVu
            {
                TenChucVu = "Zombie"

            });
            //TrangThai
            var tt1 = context.trangThais.Add(new TrangThai
            {
                TrangThaiTB = "Đã trả"
            });
            var tt2 = context.trangThais.Add(new TrangThai
            {
                TrangThaiTB = "Chưa trả"
            });
            //DiaDiem
            var dd1 = context.DiaDiems.Add(new DiaDiem
            {
                TenDiaDiem = "Hội trường"
            });
            var dd2 = context.DiaDiems.Add(new DiaDiem
            {
                TenDiaDiem = "Phòng Họp 1"
            });
            //LoaiHoatDong
            var lhd1 = context.loaiHoatDongs.Add(new LoaiHoatDong
            {
                LoaiHD = "Livestream"
            });
            var lhd2 = context.loaiHoatDongs.Add(new LoaiHoatDong
            {
                LoaiHD = "Tư Liệu"
            });
            var lhd3 = context.loaiHoatDongs.Add(new LoaiHoatDong
            {
                LoaiHD = "Project"
            });
            //LoaiThietBi
            var ltb1 = context.loaiThietBis.Add(new LoaiThietBi
            {
                TenLoai = "Mic"
            });
            var ltb2 = context.loaiThietBis.Add(new LoaiThietBi
            {
                TenLoai = "Cam"
            });
            var ltb3 = context.loaiThietBis.Add(new LoaiThietBi
            {
                TenLoai = "Lightning"
            });
            var ltb4 = context.loaiThietBis.Add(new LoaiThietBi
            {
                TenLoai = "Chân đỡ"
            });
            var ns1 = context.nhanSus.Add(new NhanSu
            {
                HoTen = "C",
                CMND = "225666",
                SDT = "6666",
                NgaySinh = new DateTime(2000, 6, 6),
                MSSV = "25566",
                LinkFB = "dddd",
                ChucVu = cv1

            });
            var ns2 = context.nhanSus.Add(new NhanSu
            {
                HoTen = "B",
                CMND = "225666",
                SDT = "6666",
                NgaySinh = new DateTime(2000, 6, 6),
                MSSV = "25566",
                LinkFB = "dddd",
                ChucVu = cv2

            });


            //var ltb1 = context.loaiThietBis.Add(new LoaiThietBi
            //{
            //    TenLoai = "mic"
            //});

            var hd1 = context.LichHoatDongs.Add(
                new LichHoatDong
                {
                    NgayTra = new DateTime(2000, 6, 6),
                    NgayMuon = new DateTime(2022, 7, 7),
                    diaDiem = dd1,
                    LoaiHoatDong = lhd1,
                    TrangThai = tt1,
                    TenHD = "khoa hoc cntt"
                    
                });
            var hdns1 = context.hoatDongNhanSus.Add(new HoatDongNhanSu
            {
                LichHoatDong = hd1 ,
                NhanSu = ns1,
                NhiemVu = nv1
            });
            var hdns2 = context.hoatDongNhanSus.Add(new HoatDongNhanSu
            {
                LichHoatDong = hd1,
                NhanSu = ns2,
                NhiemVu = nv2
            });*/
            var ltb1 = context.LoaiThietBis.Add(new LoaiThietBi
            {
                
                TenLoai = "Mic",
            });

            var ltb2 = context.LoaiThietBis.Add(new LoaiThietBi
            {
                TenLoai = "Cam",
            }) ;
            var ltb3 = context.LoaiThietBis.Add(new LoaiThietBi
            {
                TenLoai = "Đèn"
            }); var ltb4 = context.LoaiThietBis.Add(new LoaiThietBi
            {
                TenLoai = "Dù"
            }); var ltb5 = context.LoaiThietBis.Add(new LoaiThietBi
            {
                TenLoai = "Softbox"
            }); var ltb6 = context.LoaiThietBis.Add(new LoaiThietBi
            {
                TenLoai = "Strip box"
            }); var ltb7 = context.LoaiThietBis.Add(new LoaiThietBi
            {
                TenLoai = "Octabox"
            }); var ltb8 = context.LoaiThietBis.Add(new LoaiThietBi
            {
                TenLoai = "Ball Softbox"
            }); var ltb9 = context.LoaiThietBis.Add(new LoaiThietBi
            {
                TenLoai = "Reflector"
            }); var ltb10 = context.LoaiThietBis.Add(new LoaiThietBi
            {
                TenLoai = "Snoot"
            }); var ltb11 = context.LoaiThietBis.Add(new LoaiThietBi
            {
                TenLoai = "Chân đèn"
            });
            var ltb12 = context.LoaiThietBis.Add(new LoaiThietBi
            {
                TenLoai = "Beauty dish"
            });
            var tb1 = context.ThietBis.Add(new ThietBi
            {
                TenTB= "Micro shotgun",
                SoLuong=15,
                LoaiThietBi=ltb1
                
            } );
            //context.ThietBis.Add(tb1);
            ltb1.ThietBis.Add(tb1);
            var tb2 = context.ThietBis.Add(new ThietBi
            {
                TenTB = "Panasonic AGUX90EN",
                SoLuong = 5,
                LoaiThietBi = ltb2

            });
            ltb2.ThietBis.Add(tb2);
            var tb3 = context.ThietBis.Add(new ThietBi
            {
                TenTB = "Spotlight 650w",
                SoLuong = 15,
                LoaiThietBi = ltb3

            });
            ltb3.ThietBis.Add(tb3);
            var tb4 = context.ThietBis.Add(new ThietBi
            {
                TenTB = "Dù phản sáng",
                SoLuong = 15,
                LoaiThietBi = ltb4

            });
            ltb4.ThietBis.Add(tb4);
            var tb5 = context.ThietBis.Add(new ThietBi
            {
                TenTB = "Dù xuyên sáng",
                SoLuong = 15,
                LoaiThietBi = ltb4

            });
            ltb4.ThietBis.Add(tb5);
            var tb6 = context.ThietBis.Add(new ThietBi
            {
                TenTB = "Softbox 50x70",
                SoLuong = 4,
                LoaiThietBi = ltb5

            });
            ltb5.ThietBis.Add(tb6); 
            var tb7 = context.ThietBis.Add(new ThietBi
            {
                TenTB = "Rotalux Strip box",
                SoLuong = 25,
                LoaiThietBi = ltb6

            });
            ltb6.ThietBis.Add(tb7);
            var tb8 = context.ThietBis.Add(new ThietBi
            {
                TenTB = "Octabox 95",
                SoLuong = 15,
                LoaiThietBi = ltb7

            });
            ltb7.ThietBis.Add(tb8);
            var tb9 = context.ThietBis.Add(new ThietBi
            {
                TenTB = "RTriopo KQ65",
                SoLuong = 25,
                LoaiThietBi = ltb8

            });
            ltb8.ThietBis.Add(tb9);
            var tb10 = context.ThietBis.Add(new ThietBi
            {
                TenTB = "Reflector 120x140",
                SoLuong = 25,
                LoaiThietBi = ltb9

            });
            ltb9.ThietBis.Add(tb10);
            var tb11 = context.ThietBis.Add(new ThietBi
            {
                TenTB = "Optical Snoot",
                SoLuong = 15,
                LoaiThietBi = ltb10

            });
            ltb10.ThietBis.Add(tb11);
            var tb12 = context.ThietBis.Add(new ThietBi
            {
                TenTB = "Chân linex",
                SoLuong = 5,
                LoaiThietBi = ltb11

            });
            ltb11.ThietBis.Add(tb12);
            var tb13 = context.ThietBis.Add(new ThietBi
            {
                TenTB = "Beatiful dish 70",
                SoLuong = 15,
                LoaiThietBi = ltb12

            });
            ltb12.ThietBis.Add(tb13);
            var tb14 = context.ThietBis.Add(new ThietBi
            {
                TenTB = "Chân máy benro",
                SoLuong = 15,
                LoaiThietBi = ltb11

            });
            ltb11.ThietBis.Add(tb14);
            var dd1 = context.DiaDiems.Add(new DiaDiem
            {
                TenDD = "Hội trường"
            }
            );
            var dd2= context.DiaDiems.Add(new DiaDiem
            {
                TenDD = "Sân thể chất"
            }
            );
            var dd3 = context.DiaDiems.Add(new DiaDiem
            {
                TenDD = "Phòng A5-302"
            }
            );
            var dd4 = context.DiaDiems.Add(new DiaDiem
            {
                TenDD = "Phòng A5-301"
            }
            );
            var dd5 = context.DiaDiems.Add(new DiaDiem
            {
                TenDD = "Thư viện"
            }
            );
            var dd6 = context.DiaDiems.Add(new DiaDiem
            {
                TenDD = "Phòng thực hành"
            }
            );
            var tt1 = context.TrangThais.Add(new TrangThai { TenTT = "Đang tiến hành" });
            var tt2 = context.TrangThais.Add(new TrangThai { TenTT = "Chưa tiến hành" });
            var tt3 = context.TrangThais.Add(new TrangThai { TenTT = "Đã hoàn thành" });
            var lhd1 = context.LoaiHoatDongs.Add(new LoaiHoatDong { LoaiHD = "Livestream" });
            var lhd2 = context.LoaiHoatDongs.Add(new LoaiHoatDong { LoaiHD = "Project" });
            var lhd3 = context.LoaiHoatDongs.Add(new LoaiHoatDong { LoaiHD = "Tư liệu" });
            var lhd4 = context.LoaiHoatDongs.Add(new LoaiHoatDong { LoaiHD = "Music Video" });
            var lichhd1 = context.LichHoatDongs.Add(new LichHoatDong
            {
                NgayMuon = new DateTime(2022, 05, 29),
                NgayTra= new DateTime(2022, 05, 29),
                TenHD= "Livestream hội chợ 34",
                DiaDiem1=dd2,
                LoaiHoatDong=lhd1,
                TrangThai1=tt1,
            });
            dd2.LichHoatDongs.Add(lichhd1);
            lhd1.LichHoatDongs.Add(lichhd1);
            tt1.LichHoatDongs.Add(lichhd1);
            var lichhd2 = context.LichHoatDongs.Add(new LichHoatDong
            {
                NgayMuon = new DateTime(2020, 04, 24),
                NgayTra = new DateTime(2022, 04, 25),
                TenHD = "Phát triển truyền thống trường",
                DiaDiem1 = dd1,
                LoaiHoatDong = lhd2,
                TrangThai1 = tt3,
            });
            dd1.LichHoatDongs.Add(lichhd2);
            lhd2.LichHoatDongs.Add(lichhd2);
            tt3.LichHoatDongs.Add(lichhd2);
            var lichhd3 = context.LichHoatDongs.Add(new LichHoatDong
            {
                NgayMuon = new DateTime(2022, 03, 13),
                NgayTra = new DateTime(2022, 05, 25),
                TenHD = "Quảng bá cơ sở vật chất trường",
                DiaDiem1 = dd2,
                LoaiHoatDong = lhd1,
                TrangThai1 = tt1,
            });
            dd2.LichHoatDongs.Add(lichhd3);
            lhd1.LichHoatDongs.Add(lichhd3);
            tt1.LichHoatDongs.Add(lichhd3);
            var lichhd4 = context.LichHoatDongs.Add(new LichHoatDong
            {
                NgayMuon = new DateTime(2022, 05, 25),
                NgayTra = new DateTime(2022, 05, 25),
                TenHD = "Livestream RFSPEED RACING",     
                DiaDiem1 = dd3,
                LoaiHoatDong = lhd1,
                TrangThai1 = tt3,
            });
            dd3.LichHoatDongs.Add(lichhd4);
            lhd1.LichHoatDongs.Add(lichhd4);
            tt3.LichHoatDongs.Add(lichhd4);
            var lichhd5 = context.LichHoatDongs.Add(new LichHoatDong
            {
                NgayMuon = new DateTime(2022, 05, 22),
                NgayTra = new DateTime(2022, 05, 22),
                TenHD = "Lễ ra mắt Hội đồng Tư vấn Nhóm ngành Công nghệ Hóa học và Thực phẩm – ra mắt Ban Liên lạc Cựu sinh viên Khoa Công nghệ Hóa học và Thực phẩm",
                DiaDiem1 = dd4,
                LoaiHoatDong = lhd1,
                TrangThai1 = tt3,
            });
            dd4.LichHoatDongs.Add(lichhd5);
            lhd1.LichHoatDongs.Add(lichhd5);
            tt3.LichHoatDongs.Add(lichhd5);
            var lichhd6 = context.LichHoatDongs.Add(new LichHoatDong
            {
                NgayMuon = new DateTime(2022, 05, 25),
                NgayTra = new DateTime(2022, 05, 25),
                TenHD = "Cổ vũ tinh thần",
                DiaDiem1 = dd1,
                LoaiHoatDong = lhd4,
                TrangThai1 = tt3,
            });
            dd1.LichHoatDongs.Add(lichhd6);
            lhd4.LichHoatDongs.Add(lichhd6);
            tt3.LichHoatDongs.Add(lichhd6);
            var lichhd7 = context.LichHoatDongs.Add(new LichHoatDong
            {
                NgayMuon = new DateTime(2022, 05, 20),
                NgayTra = new DateTime(2022, 05, 21),
                TenHD = "Cuộc thi tôi là kế toán giỏi",
                DiaDiem1 = dd1,
                LoaiHoatDong = lhd1,
                TrangThai1 = tt3,
            });
            dd1.LichHoatDongs.Add(lichhd7);
            lhd1.LichHoatDongs.Add(lichhd7);
            tt3.LichHoatDongs.Add(lichhd7);
            var lichhd8 = context.LichHoatDongs.Add(new LichHoatDong
            {
                NgayMuon = new DateTime(2022, 05, 19),
                NgayTra = new DateTime(2022, 05, 20),
                TenHD = "Hành trình sáng tạo",
                DiaDiem1 = dd4,
                LoaiHoatDong = lhd1,
                TrangThai1 = tt3,
            });
            dd4.LichHoatDongs.Add(lichhd8);
            lhd1.LichHoatDongs.Add(lichhd8);
            tt3.LichHoatDongs.Add(lichhd8);
            var lichhd9 = context.LichHoatDongs.Add(new LichHoatDong
            {
                NgayMuon = new DateTime(2022, 03, 04),
                NgayTra = new DateTime(2022, 05, 20),
                TenHD = "Lễ Tốt nghiệp Đại học Sunderland",
                DiaDiem1 = dd1,
                LoaiHoatDong = lhd1,
                TrangThai1 = tt3,
            });
            dd1.LichHoatDongs.Add(lichhd9);
            lhd1.LichHoatDongs.Add(lichhd9);
            tt3.LichHoatDongs.Add(lichhd9);
            var cv1 = context.ChucVus.Add(new ChucVu { TenCV = "Quản lý" });
            var cv2 = context.ChucVus.Add(new ChucVu { TenCV = "Newbie" });
            var cv3 = context.ChucVus.Add(new ChucVu { TenCV = "Trưởng phòng" });
            var ns1 = context.NhanSus.Add(new NhanSu
            {
                HoTen = "Khổng Lam Hà",
                CMND = "300000",
                NgaySinh = new DateTime(2001, 11, 04),
                SDT = "0207385461",
                MSSV = "1703232",
                Phai = "Nữ",
                LinkFB = "https://www.facebook.com/khonglamha",
                ChucVu = cv1

            }) ;
            cv1.NhanSus.Add(ns1);
            var ns2 = context.NhanSus.Add(new NhanSu
            {
                HoTen = "Tào Minh An",
                CMND = "220000",
                NgaySinh = new DateTime(2000, 06, 07),
                SDT = "0489237061",
                MSSV = "2398128",
                Phai = "Nữ",
                LinkFB = "https://www.facebook.com/taoan",
                ChucVu = cv2
            }) ;
            cv2.NhanSus.Add(ns2);
            var ns3 = context.NhanSus.Add(new NhanSu
            {
                HoTen = "Ưng Gia Phước",
                CMND = "510000",
                NgaySinh = new DateTime(2001, 04, 09),
                SDT = "0265329876",
                MSSV = "3123534",
                Phai = "Nam",
                LinkFB = "https://www.facebook.com/khuonghuy",
                ChucVu=cv2
            });
            cv2.NhanSus.Add(ns3);
            var ns4 = context.NhanSus.Add(new NhanSu
            {
                HoTen = "Khổng Tuấn Chương",
                CMND = "360000",
                NgaySinh = new DateTime(2003, 04, 17),
                SDT = "0212080947",
                MSSV = "321434",
                Phai = "Nam",
                LinkFB = "https://www.facebook.com/ueywq",
                ChucVu = cv2
            });
            cv2.NhanSus.Add(ns4);
            var ns5 = context.NhanSus.Add(new NhanSu
            {
                HoTen = "Hình Uyên Vi",
                CMND = "280000",
                NgaySinh = new DateTime(2001, 10, 04),
                SDT = "0211685374",
                MSSV = "3124315",
                Phai = "Nữ",
                LinkFB = "https://www.facebook.com/ueywq32",
                ChucVu = cv3
            });
            cv3.NhanSus.Add(ns5);
            var ns6 = context.NhanSus.Add(new NhanSu
            {
                HoTen = "Lâm Thiên Phú",
                CMND = "100000",
                NgaySinh = new DateTime(1999, 10, 25),
                SDT = "0247352801",
                MSSV = "3312413",
                Phai = "Nam",
                LinkFB = "https://www.facebook.com/lamthuen",
                ChucVu = cv2
            });
            cv2.NhanSus.Add(ns6);
            var ns7 = context.NhanSus.Add(new NhanSu
            {
                HoTen = "Cống Minh Tân",
                CMND = "870000",
                NgaySinh = new DateTime(2002, 09, 23),
                SDT = "0278910465",
                MSSV = "3362413",
                Phai = "Nam",
                LinkFB = "https://www.facebook.com/lamuendsa",
                ChucVu = cv3
            });
            cv3.NhanSus.Add(ns7);
            var dn1 = context.DangNhaps.Add(new DangNhap
            {
                MaNS = 1,
                UserLogin = "NV_0001",
                PassLogin = "1",
                NhanSu = ns1
            });
            ns1.DangNhap = dn1;
            var dn2 = context.DangNhaps.Add(new DangNhap
            {
                MaNS = 2,
                UserLogin = "NV_0002",
                PassLogin = "1",
                NhanSu = ns2
            });
            ns2.DangNhap = dn2;
            var dn3 = context.DangNhaps.Add(new DangNhap
            {
                MaNS = 3,
                UserLogin = "NV_0003",
                PassLogin = "1",
                NhanSu = ns3
            });
            ns3.DangNhap = dn3;
            var dn4 = context.DangNhaps.Add(new DangNhap
            {
                MaNS = 4,
                UserLogin = "NV_0004",
                PassLogin = "1",
                NhanSu = ns4
            });
            ns4.DangNhap = dn4;
            var dn5 = context.DangNhaps.Add(new DangNhap
            {
                MaNS = 5,
                UserLogin = "NV_0005",
                PassLogin = "1",
                NhanSu = ns5
            });
            ns5.DangNhap = dn5;
            var dn6 = context.DangNhaps.Add(new DangNhap
            {
                MaNS = 6,
                UserLogin = "NV_0006",
                PassLogin = "1",
                NhanSu = ns6
            });
            ns6.DangNhap = dn6;
            var dn7 = context.DangNhaps.Add(new DangNhap
            {
                MaNS = 7,
                UserLogin = "NV_0007",
                PassLogin = "7",
                NhanSu = ns7
            });
            ns7.DangNhap = dn7;
            var sp1 = context.SanPhams.Add(new SanPham
            {
                TenSP = "Livestream RFSPEED RACING",
                LinkSP = "https://www.facebook.com/page/612693435568316/search/?q=RFSPEED%20RACING",
                LinkFB = "https://www.facebook.com/page/612693435568316/search/?q=RFSPEED%20RACING",
                ThoiLuong = "2 tiếng",
               
                NhanSu=ns1
                
            });
            ns1.SanPhams.Add(sp1);
            var sp2 = context.SanPhams.Add(new SanPham
            {
                TenSP = "Cuộc thi tôi là kế toán giỏi",
                LinkSP = "https://www.facebook.com/hashtag/toilaketoangioilaniv",
                LinkFB = "https://www.facebook.com/hashtag/toilaketoangioilaniv",
                ThoiLuong = "2 tiếng",
      
                NhanSu = ns2

            });
            ns2.SanPhams.Add(sp2);
            var sp3 = context.SanPhams.Add(new SanPham
            {
                TenSP = "Lễ Tốt nghiệp Đại học Sunderland",
                LinkSP = "https://www.facebook.com/page/612693435568316/search/?q=L%E1%BB%85%20T%E1%BB%91t%20nghi%E1%BB%87p%20%C4%90%E1%BA%A1i%20h%E1%BB%8Dc%20Sunderland",
                LinkFB = "https://www.facebook.com/page/612693435568316/search/?q=L%E1%BB%85%20T%E1%BB%91t%20nghi%E1%BB%87p%20%C4%90%E1%BA%A1i%20h%E1%BB%8Dc%20Sunderland",
                ThoiLuong = "1 tiếng",
         
                NhanSu = ns3

            });
            ns3.SanPhams.Add(sp3);

            var sp4 = context.SanPhams.Add(new SanPham
            {
                TenSP = "Hành trình sáng tạo",
                LinkSP = "https://www.facebook.com/page/612693435568316/search/?q=H%C3%A0nh%20tr%C3%ACnh%20s%C3%A1ng%20t%E1%BA%A1o",
                LinkFB = "https://www.facebook.com/page/612693435568316/search/?q=H%C3%A0nh%20tr%C3%ACnh%20s%C3%A1ng%20t%E1%BA%A1o",
                ThoiLuong = "22 phút",
       
                NhanSu = ns4

            });
            ns4.SanPhams.Add(sp4);
            var nv1 = context.NhiemVus.Add(new NhiemVu
            {
                TenNV = "camop"
                
            });
            var nv2 = context.NhiemVus.Add(new NhiemVu
            {
                TenNV = "producer"

            });
            var nv3 = context.NhiemVus.Add(new NhiemVu
            {
                TenNV = "gaffer"

            });
            var nv4 = context.NhiemVus.Add(new NhiemVu
            {
                TenNV = "mixer"

            });
            var hdns1 = context.HoatDongNhanSus.Add(new HoatDongNhanSu
            {
                LichHoatDong = lichhd1,
                NhanSu = ns1,
                NhiemVu = nv1

            });
            lichhd1.HoatDongNhanSus.Add(hdns1);
            ns1.HoatDongNhanSus.Add(hdns1);
            nv1.HoatDongNhanSus.Add(hdns1);
            var hdns2 = context.HoatDongNhanSus.Add(new HoatDongNhanSu
            {
                LichHoatDong = lichhd1,
                NhanSu = ns2,
                NhiemVu = nv2

            });
            lichhd1.HoatDongNhanSus.Add(hdns2);
            ns2.HoatDongNhanSus.Add(hdns2);
            nv2.HoatDongNhanSus.Add(hdns2);
            var hdns3 = context.HoatDongNhanSus.Add(new HoatDongNhanSu
            {
                LichHoatDong = lichhd1,
                NhanSu = ns3,
                NhiemVu = nv3

            });
            lichhd1.HoatDongNhanSus.Add(hdns3);
            ns3.HoatDongNhanSus.Add(hdns3);
            nv3.HoatDongNhanSus.Add(hdns3);
            var hdns4 = context.HoatDongNhanSus.Add(new HoatDongNhanSu
            {
                LichHoatDong = lichhd1,
                NhanSu = ns4,
                NhiemVu = nv1

            });
            lichhd1.HoatDongNhanSus.Add(hdns4);
            ns4.HoatDongNhanSus.Add(hdns4);
            nv4.HoatDongNhanSus.Add(hdns4);
            var hdns5 = context.HoatDongNhanSus.Add(new HoatDongNhanSu
            {
                LichHoatDong = lichhd2,
                NhanSu = ns5,
                NhiemVu = nv1

            });
            lichhd2.HoatDongNhanSus.Add(hdns5);
            ns5.HoatDongNhanSus.Add(hdns5);
            nv1.HoatDongNhanSus.Add(hdns5);
            var hdns6 = context.HoatDongNhanSus.Add(new HoatDongNhanSu
            {
                LichHoatDong = lichhd2,
                NhanSu = ns6,
                NhiemVu = nv2

            });
            lichhd2.HoatDongNhanSus.Add(hdns6);
            ns6.HoatDongNhanSus.Add(hdns6);
            nv2.HoatDongNhanSus.Add(hdns6);
            var hdns7 = context.HoatDongNhanSus.Add(new HoatDongNhanSu
            {
                LichHoatDong = lichhd2,
                NhanSu = ns7,
                NhiemVu = nv3

            });
            lichhd2.HoatDongNhanSus.Add(hdns7);
            ns7.HoatDongNhanSus.Add(hdns7);
            nv3.HoatDongNhanSus.Add(hdns7);
            var hdns8 = context.HoatDongNhanSus.Add(new HoatDongNhanSu
            {
                LichHoatDong = lichhd2,
                NhanSu = ns1,
                NhiemVu = nv4

            });
            lichhd2.HoatDongNhanSus.Add(hdns8);
            ns1.HoatDongNhanSus.Add(hdns8);
            nv4.HoatDongNhanSus.Add(hdns8);
            var hdns9 = context.HoatDongNhanSus.Add(new HoatDongNhanSu
            {
                LichHoatDong = lichhd3,
                NhanSu = ns2,
                NhiemVu = nv1

            });
            lichhd3.HoatDongNhanSus.Add(hdns9);
            ns2.HoatDongNhanSus.Add(hdns9);
            nv1.HoatDongNhanSus.Add(hdns9);
            var hdns10 = context.HoatDongNhanSus.Add(new HoatDongNhanSu
            {
                LichHoatDong = lichhd3,
                NhanSu = ns3,
                NhiemVu = nv2

            });
            lichhd3.HoatDongNhanSus.Add(hdns10);
            ns3.HoatDongNhanSus.Add(hdns10);
            nv2.HoatDongNhanSus.Add(hdns10);
            var hdns11 = context.HoatDongNhanSus.Add(new HoatDongNhanSu
            {
                LichHoatDong = lichhd4,
                NhanSu = ns4,
                NhiemVu = nv1

            });
            lichhd4.HoatDongNhanSus.Add(hdns11);
            ns4.HoatDongNhanSus.Add(hdns11);
            nv1.HoatDongNhanSus.Add(hdns11);
            var hdns12 = context.HoatDongNhanSus.Add(new HoatDongNhanSu
            {
                LichHoatDong = lichhd4,
                NhanSu = ns5,
                NhiemVu = nv3

            });
            lichhd4.HoatDongNhanSus.Add(hdns12);
            ns5.HoatDongNhanSus.Add(hdns12);
            nv3.HoatDongNhanSus.Add(hdns12);
            var hdns13= context.HoatDongNhanSus.Add(new HoatDongNhanSu
            {
                LichHoatDong = lichhd5,
                NhanSu = ns6,
                NhiemVu = nv4

            });
            lichhd5.HoatDongNhanSus.Add(hdns13);
            ns6.HoatDongNhanSus.Add(hdns13);
            nv4.HoatDongNhanSus.Add(hdns13);
            var hdns14 = context.HoatDongNhanSus.Add(new HoatDongNhanSu
            {
                LichHoatDong = lichhd5,
                NhanSu = ns7,
                NhiemVu = nv3

            });
            lichhd5.HoatDongNhanSus.Add(hdns14);
            ns7.HoatDongNhanSus.Add(hdns14);
            nv3.HoatDongNhanSus.Add(hdns14);
            var hdns15 = context.HoatDongNhanSus.Add(new HoatDongNhanSu
            {
                LichHoatDong = lichhd6,
                NhanSu = ns2,
                NhiemVu = nv4

            });
            lichhd6.HoatDongNhanSus.Add(hdns15);
            ns2.HoatDongNhanSus.Add(hdns15);
            nv4.HoatDongNhanSus.Add(hdns15);
            var hdtb1 = context.HoatDongThietBis.Add(new HoatDongThietBi
            {
                SoLuong = 2,
                LichHoatDong = lichhd1,
                ThietBi = tb1,
            });
            lichhd1.HoatDongThietBis.Add(hdtb1);
            tb1.HoatDongThietBis.Add(hdtb1);
            var hdtb2 = context.HoatDongThietBis.Add(new HoatDongThietBi
            {
                SoLuong = 2,
                LichHoatDong = lichhd2,
                ThietBi = tb2,
            });
            lichhd2.HoatDongThietBis.Add(hdtb2);
            tb2.HoatDongThietBis.Add(hdtb2);
            var hdtb3 = context.HoatDongThietBis.Add(new HoatDongThietBi
            {
                SoLuong = 2,
                LichHoatDong = lichhd3,
                ThietBi = tb3,
            });
            lichhd3.HoatDongThietBis.Add(hdtb3);
            tb3.HoatDongThietBis.Add(hdtb3);
            var hdtb4 = context.HoatDongThietBis.Add(new HoatDongThietBi
            {
                SoLuong = 2,
                LichHoatDong = lichhd4,
                ThietBi = tb4,
            });
            lichhd4.HoatDongThietBis.Add(hdtb4);
            tb4.HoatDongThietBis.Add(hdtb4);
            var hdtb5 = context.HoatDongThietBis.Add(new HoatDongThietBi
            {
                SoLuong = 5,
                LichHoatDong = lichhd5,
                ThietBi = tb5,
            });
            lichhd5.HoatDongThietBis.Add(hdtb5);
            tb5.HoatDongThietBis.Add(hdtb5);
            var hdtb6 = context.HoatDongThietBis.Add(new HoatDongThietBi
            {
                SoLuong = 6,
                LichHoatDong = lichhd6,
                ThietBi = tb6,
            });
            lichhd6.HoatDongThietBis.Add(hdtb6);
            tb6.HoatDongThietBis.Add(hdtb6);
            var hdtb7 = context.HoatDongThietBis.Add(new HoatDongThietBi
            {
                SoLuong = 7,
                LichHoatDong = lichhd7,
                ThietBi = tb7,
            });
            lichhd7.HoatDongThietBis.Add(hdtb7);
            tb7.HoatDongThietBis.Add(hdtb7);
            var cd1 = context.CapDoTLs.Add(new CapDoTL
            {
                TenCapDo = "A"
            });
            var cd2 = context.CapDoTLs.Add(new CapDoTL
            {
                TenCapDo = "B"
            });
            var cd3 = context.CapDoTLs.Add(new CapDoTL
            {
                TenCapDo = "C"
            });
            var cd4 = context.CapDoTLs.Add(new CapDoTL
            {
                TenCapDo = "D"
            });
            var tl1 = context.TuLieus.Add(new TuLieu
            {
                LichHoatDong = lichhd1,
                TenTL = lichhd1.TenHD,
                CapDoTL = cd1,
                NgayQuayTL = lichhd1.NgayMuon,
                LinkTL = "https://drive.google.com/drive/folders/",
                

            }) ;
            var tl2 = context.TuLieus.Add(new TuLieu
            {
                LichHoatDong = lichhd2,
                TenTL = lichhd2.TenHD,
                CapDoTL = cd1,
                NgayQuayTL = lichhd1.NgayMuon,
                LinkTL = "https://drive.google.com/drive/folders/",


            });
            var tl3 = context.TuLieus.Add(new TuLieu
            {
                LichHoatDong = lichhd3,
                TenTL = lichhd3.TenHD,
                CapDoTL = cd3,
                NgayQuayTL = lichhd3.NgayMuon,
                LinkTL = "https://drive.google.com/drive/folders/",


            });
            tl1.SanPhams.Add(sp1);
            tl1.SanPhams.Add(sp3);
            tl2.SanPhams.Add(sp1);
            context.SaveChanges();
        }
    }

}
