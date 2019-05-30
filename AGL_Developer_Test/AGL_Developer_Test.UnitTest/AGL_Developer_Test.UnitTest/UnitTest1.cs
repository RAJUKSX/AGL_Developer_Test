using AGL_Developer_Test.Controllers;
using AGL_Developer_Test.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AGL_Developer_Test.UnitTest
{
    [TestClass]
    public class UnitTest1
    {       
      
        [TestMethod]
        public void TestMethod1()
        {
            List<Pet> pets = new List<Pet>();    
            
            //Arrange
            IPetRepository repo = new PetRepository();
            //ACT
            pets = repo.GetPets();

            //Assert
            Assert.IsNotNull(pets);
        }

        


    }
}
