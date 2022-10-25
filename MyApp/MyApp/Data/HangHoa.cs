using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyApp.Data
{
    [Table("HangHoa")]
    public class HangHoa
    {
        [Key]
        public int MaHh { get; set; }
        [MaxLength(150)]
        public string TenHh { get; set; }
        public string? Hinh { get; set; }
        public double DonGia { get; set; } = 0;
        public int SoLuong { get; set; } = 0;
        public int? MaLoai { get; set; }
        [ForeignKey("MaLoai")]
        public Loai? Loai { get; set; }

    }
}
