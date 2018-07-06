using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter2.Controllers;
using WordCounter.Models;

namespace WordCounter2.Tests
{
    [TestClass]
    public class ResultsControllerTest
    {
        [TestMethod]
        public void Result_ReturnsCorrectView_True()
        {
            RepeatCounter test = new RepeatCounter("hello", "hello hello");
            ResultsController controller = new ResultsController();
            ActionResult indexView = controller.Results(test);
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }

        [TestMethod]
        public void Result_HasCorrectModelType_Results()
        {
            //Arrange
            ResultsController controller = new ResultsController();
            ViewResult costDataType = controller.FilloutForm("hello", "hello and hello") as ViewResult;

            //Act
            var result = costDataType.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(RepeatCounter));
        }
    }
}
