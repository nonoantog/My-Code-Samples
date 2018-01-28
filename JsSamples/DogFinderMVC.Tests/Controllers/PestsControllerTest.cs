using DogFinderMVC.Controllers;
using DogFinderMVC.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DogFinderMVC.Test
{
    [TestClass]
    public class PestsControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            PetsController controller = new PetsController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);

            var model = result.Model as List<Pet>;

            Assert.IsNotNull(model);

        }
    }
}