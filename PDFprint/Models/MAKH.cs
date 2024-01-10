using System.ComponentModel.DataAnnotations;

namespace PDFprint.Models
{
    public class MAKH
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string MaKH { get; set; }
    }
}
