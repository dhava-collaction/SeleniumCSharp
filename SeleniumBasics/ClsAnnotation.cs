using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSHARPproject
{
    class ClsAnnotation
    {
        IWebDriver driver;

        [SetUp]
        public void browserInit()
        { driver = new ChromeDriver(); }

        [Test]
        public void openTest()
        { driver.Url=("https://www.amazon.in/"); }

        [TearDown]
        public void endTest()
        { driver.Close(); }



    }
}
