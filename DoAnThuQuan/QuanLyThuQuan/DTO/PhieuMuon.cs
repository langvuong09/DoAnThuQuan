namespace DoAnThuQuan.QuanLyThuQuan.DTO
{
    public class PhieuMuon
    {
        public int idPhieuMuon { get; set; }
        public DateTime tgianMuon { get; set; }
        public int solg { get; set; }
        public int ngMuon { get; set; }
        public int idNhanVien { get; set; }

        public PhieuMuon() { }

        public PhieuMuon(int idPhieuMuon, DateTime tgianMuon, int solg, int ngMuon, int idNhanVien)
        {
            this.idPhieuMuon = idPhieuMuon;
            this.tgianMuon = tgianMuon;
            this.solg = solg;
            this.ngMuon = ngMuon;
            this.idNhanVien = idNhanVien;
        }
    }
}
