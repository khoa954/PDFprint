using PDFprint.Data;
using PDFprint.Models;
using PDFprint.Services.Repository.IRepository;

namespace PDFprint.Services.Repository
{
    public class CONGNOTHEOTHANGRepository : Repository<CONGNOTHEOTHANG>, ICONGNOTHEOTHANGRepository
    {
        private ApplicationDbContext _db;
        public CONGNOTHEOTHANGRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }

        public List<CONGNOTHEOTHANG> getAllWithMaKH(string maKH)
        {
            if(maKH != null)
            {
                List<CONGNOTHEOTHANG> items=_db.CONGNOTHEOTHANG.Where(r=>r.MaKhachHang==maKH).ToList();
                if (items.Count > 0)
                {
                    return items;
                }
                else
                {
                    return null;
                }
                
            }
            return null;
        }

        public CONGNOTHEOTHANG getOneWithMaKHAndMonth(string maKH, string month)
        {
            CONGNOTHEOTHANG item=_db.CONGNOTHEOTHANG.FirstOrDefault(r => r.MaKhachHang == maKH && r.Thang == month);
            if (item != null)
            {
                return item;
            }
            return null;
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
