namespace DoAnThuQuan.QuanLyThuQuan.DTO
{
    public class MayChieu
    {
        public string idSeriMaychieu { get; set; }
        public int trangThai { get; set; }
        public int? soLuong { get; set; }
        public string link { get; set; }
        public int? giaTien { get; set; }

        public MayChieu() { }

        public MayChieu(string idSeriMaychieu, int trangThai, int? soLuong, string link, int? giaTien)
        {
            this.idSeriMaychieu = idSeriMaychieu;
            this.trangThai = trangThai;
            this.soLuong = soLuong;
            this.link = link;
            this.giaTien = giaTien;
        }
    }
}
