using System.ComponentModel.DataAnnotations;
namespace PDFprint.Models
{
    public class CONGNOTHEOTHANG
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string ChiNhanh { get; set; }
        [Required]

        public string Thang { get; set; }
        [Required]
        public string Nam { get; set; }
        [Required]

        public string MaKhachHang { get; set; }
        [Required]

        public string TenKhachHang { get; set; }
        [Required]

        public string DiaChi { get; set; }
        [Required]

        public string TaiKhoan { get; set; }
        [Required]

        public string NgayKhaiTruong { get; set; }
        [Required]

        public string CongNoConLai { get; set; }
        [Required]
        public string CongNoConLaiTheoChu { get; set; }
        [Required]

        public string CongNoThangTruoc { get; set; }
        [Required]

        public string TongPhatSinhTang { get; set; }
        [Required]

        public string TongPhatSinhGiam { get; set; }

    }
}
