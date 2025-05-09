namespace DoAnThuQuan.QuanLyThuQuan.DTO
{
    public class PhieuPhatHuDo
    {
        public int idPhieuPhatHuDo { get; set; }
        public int idPhieuTra { get; set; }
        public int solg { get; set; }
        public int tongTien { get; set; }

        public PhieuPhatHuDo() { }

        public PhieuPhatHuDo(int idPhieuPhatHuDo, int idPhieuTra, int solg, int tongTien)
        {
            this.idPhieuPhatHuDo = idPhieuPhatHuDo;
            this.idPhieuTra = idPhieuTra;
            this.solg = solg;
            this.tongTien = tongTien;
        }
    }
}
