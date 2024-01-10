using PDFprint.Models;

namespace PDFprint.Services.Repository.IRepository
{
    public interface ICONGNOTHEOTHANGRepository:IRepository<CONGNOTHEOTHANG>
    {
        CONGNOTHEOTHANG getOneWithMaKHAndMonth(string maKH,string month);
        List<CONGNOTHEOTHANG> getAllWithMaKH(string maKH);
        void Save();
    }
}
