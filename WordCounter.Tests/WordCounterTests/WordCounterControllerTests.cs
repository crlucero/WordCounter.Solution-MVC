using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordControllerTest
    {
        [TestMethod]
        public void Game_ReturnsCorrectView_True()
        {
            // Arrange
            RepeatCounterController controller = new RepeatCounterController();

            // Act
            ActionResult formView = controller.CreateForm();

            //Assert
            Assert.IsInstanceOfType(formView, typeof(ViewResult));
        }
    }
}

