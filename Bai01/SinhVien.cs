using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class SinhVien
    {
        private string Hoten, Khoi;
        private double Diemtoan, Diemvan, DiemNgoaiNgu,DiemTB;

        public SinhVien()
        {

        }
        public SinhVien(string hoTen, string khoiHoc, float diemToan, float diemVan, float diemNN)
        {
            Hoten = hoTen;
            Khoi = khoiHoc;
            Diemtoan = diemToan;
            Diemvan = diemVan;
            DiemNgoaiNgu = diemNN;
        }
        public string HoTen
        {
            get { return Hoten; }
            set { Hoten = value; }
        }
        public string KH
        {
            get { return Khoi; }
            set { Khoi = value;}
        }
        public double DiemToan
        {
            get { return Diemtoan; }
            set { Diemtoan = value; }
        }
        public double DiemVan
        {
            get { return Diemvan; }
            set { Diemvan = value; }
        }
        public double DiemNgoaiNg
        {
            get { return DiemNgoaiNgu; }
            set { DiemNgoaiNgu = value; }
        }
        public double TinhTrungBinh()
        {
            if(Khoi == "A" || Khoi == "a")
               return  DiemTB = (DiemToan*2 + DiemVan + DiemNgoaiNg) / 4;
            else if (Khoi == "D")
               return DiemTB = (DiemToan + DiemVan + DiemNgoaiNg * 2) / 4;
            else
               return DiemTB = (DiemToan + DiemVan * 2 + DiemNgoaiNg) / 4;
        }
        public string TinhXepLoai()
        {
            if (TinhTrungBinh() >= 5)
               return "DuocLenLop";
            else
              return "LuuBan";
        }
        public void InThongTin()
        {
            Console.WriteLine("Ho va ten sinh vien: {0}", HoTen);
            Console.WriteLine("Diem trung binh cua sinh vien: {0:0.0}", TinhTrungBinh());
            Console.WriteLine("Xep loai: {0}", TinhXepLoai());
        }
       
    }
}
