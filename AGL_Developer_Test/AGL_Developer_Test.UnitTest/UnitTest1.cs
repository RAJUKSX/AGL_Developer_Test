using AGL_Developer_Test.Controllers;
using AGL_Developer_Test.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AGL_Developer_Test.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private readonly IPetRepository _petRepository;
        [TestMethod]
        public void Index()
        {
            HomeController homeController = new HomeController(_petRepository);

            ViewResult
        }
    }
}
