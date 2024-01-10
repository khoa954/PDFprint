using Microsoft.EntityFrameworkCore;
using PDFprint.Models;

namespace PDFprint.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }
        public DbSet<CONGNOTHEOTHANG> CONGNOTHEOTHANG { get; set; }
        public DbSet<CHITIETCONGNO> CHITIETCONGNO { get; set; }
        public DbSet<MAKH> MAKH { get; set; }
    }
}
