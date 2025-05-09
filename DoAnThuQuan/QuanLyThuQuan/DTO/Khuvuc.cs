namespace DoAnThuQuan.QuanLyThuQuan.DTO
{
    internal class KhuVuc
    {
        public int idKhuVuc { get; set; }
        public string tenKhuVuc { get; set; }

        public KhuVuc() { }

        public KhuVuc(int idKhuVuc, string tenKhuVuc)
        {
            this.idKhuVuc = idKhuVuc;
            this.tenKhuVuc= tenKhuVuc;
        }
    }
}
