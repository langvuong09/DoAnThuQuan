namespace DoAnThuQuan.QuanLyThuQuan.DTO
{
    public class PhieuDatCho
    {
        public int idPhieudatcho { get; set; }
        public int ngdatcho { get; set; }
        public int idChongoi { get; set; }
        public DateTime createAt { get; set; }
        public DateTime tgian { get; set; }
        public int trangThai { get; set; }
        public int? soTien { get; set; }

        public PhieuDatCho() { }

        public PhieuDatCho(int idPhieudatcho, int ngdatcho, int idChongoi, DateTime createAt, DateTime tgian, int trangThai, int? soTien)
        {
            this.idPhieudatcho = idPhieudatcho;
            this.ngdatcho = ngdatcho;
            this.idChongoi = idChongoi;
            this.createAt = createAt;
            this.tgian = tgian;
            this.trangThai = trangThai;
            this.soTien = soTien;
        }
    }
}
