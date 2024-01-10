using System.ComponentModel.DataAnnotations.Schema;

namespace PDFprint.Models
{
    public class CHITIETCONGNO
    {
        public int id { get; set; }
        public string SOCHUNGTU { get; set; }
        public string NGAYCHUNGTU { get; set; }
        public string KENHPHANPHOI { get; set; }
        public string DIENGIAI { get; set; }
        public string PHATSINHTANG { get; set; }
        public string PHATSINHGIAM { get; set; }
        public int CONGNOTHEOTHANGId { get; set; }
        [ForeignKey("CONGNOTHEOTHANGId")]
        public CONGNOTHEOTHANG CONGNOTHEOTHANG { get; set; }
    }
}
