using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSHARPproject
{
    class seleniumTest
    {

        public static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.amazon.in/";
            driver.Quit();

           
        }

    }
}
