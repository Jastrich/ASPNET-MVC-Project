using SampleApplication.Models;
using Microsoft.AspNetCore.Mvc;
using SampleApplication.ViewModels;

namespace SampleApplication.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController
            (IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public ActionResult List()
        {
            //ViewBag.CurrentCategory = "Cheese Cakes";
            //return View(_pieRepository.AllPies);
            PieListViewModel pieListViewModel = new PieListViewModel
                (_pieRepository.AllPies, "Cheese Cakes");
            return View(pieListViewModel);
        }
    }
}
