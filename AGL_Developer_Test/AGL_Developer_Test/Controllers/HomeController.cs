using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AGL_Developer_Test.Models;

namespace AGL_Developer_Test.Controllers
{
    public class HomeController : Controller
    {
        #region Private Properties
        private readonly IPetRepository _petRepository;
        #endregion

        #region Constructor
        public HomeController(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }
        #endregion

        #region Action Methods
        public IActionResult Index()
        {
            return View(_petRepository.GetPets());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        #endregion
    }
}
