using PDFprint.Data;
using PDFprint.Models;
using PDFprint.Services.Repository.IRepository;

namespace PDFprint.Services.Repository
{
    public class CHITIETCONGNORepository : Repository<CHITIETCONGNO>, ICHITIETCONGNORepository
    {
        private ApplicationDbContext _db;
        public CHITIETCONGNORepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }

        public List<CHITIETCONGNO> GetByCONGNOTHEOTHANGId(int id)
        {
            List<CHITIETCONGNO> items=_db.CHITIETCONGNO.Where(r=>r.CONGNOTHEOTHANGId==id).ToList();
            if(items != null)
            {
                return items;
            }
            return null;
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
