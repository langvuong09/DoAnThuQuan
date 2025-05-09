namespace DoAnThuQuan.QuanLyThuQuan.DTO
{
    public class ChiTietPhieuDatCho
    {
        public int idChiTietPhieuDatCho { get; set; }
        public string idThietBi { get; set; }
        public int giaTien { get; set; }
        public int idPhieuDatCho { get; set; }

        public ChiTietPhieuDatCho() { }

        public ChiTietPhieuDatCho(int idChiTiet, string idThietBi, int giaTien, int idPhieuDatCho)
        {
            this.idChiTietPhieuDatCho = idChiTiet;
            this.idThietBi = idThietBi;
            this.giaTien = giaTien;
            this.idPhieuDatCho = idPhieuDatCho;
        }
    }
}