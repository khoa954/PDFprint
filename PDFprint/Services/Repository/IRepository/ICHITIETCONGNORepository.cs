using PDFprint.Models;

namespace PDFprint.Services.Repository.IRepository
{
    public interface ICHITIETCONGNORepository:IRepository<CHITIETCONGNO>
    {
        List<CHITIETCONGNO> GetByCONGNOTHEOTHANGId(int id);
        void Save();
    }
}
