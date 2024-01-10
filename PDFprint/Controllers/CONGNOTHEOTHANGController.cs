using Microsoft.AspNetCore.Mvc;
using PDFprint.Data;
using PDFprint.Models;
using PDFprint.Services.Repository.IRepository;

namespace PDFprint.Controllers
{
    public class CONGNOTHEOTHANGController : Controller
    {
        private readonly ICONGNOTHEOTHANGRepository _CONGNOTHEOTHANGRepo;
        public CONGNOTHEOTHANGController(ICONGNOTHEOTHANGRepository db)
        {
            _CONGNOTHEOTHANGRepo = db;
        }

        public IActionResult CONGNOTHEOTHANG()
        {
            List<CONGNOTHEOTHANG> obj = _CONGNOTHEOTHANGRepo.GetAll().ToList();
            return View(obj);
        }
    }
}
