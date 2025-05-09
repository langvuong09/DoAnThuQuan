namespace DoAnThuQuan.QuanLyThuQuan.DTO
{
    public class MayTinh
    {
        public string idSeriMaytinh { get; set; }
        public int trangThai { get; set; }
        public int? soLuong { get; set; }
        public string link { get; set; }
        public int? giaTien { get; set; }

        public MayTinh() { }

        public MayTinh(string idSeriMaytinh, int trangThai, int? soLuong, string link, int? giaTien)
        {
            this.idSeriMaytinh = idSeriMaytinh;
            this.trangThai = trangThai;
            this.soLuong = soLuong;
            this.link = link;
            this.giaTien = giaTien;
        }
    }
}
