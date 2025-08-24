using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSHARPproject.SeleniumBasics
{
    class ClsWebdriverCommand
    {

        /*
         * Exercise
Launch a new Chrome browser.
Open amazon.in
Get Page Title name and Title length
Print Page Title and Title length on the Console.
Get Page URL and Page Url Length
Print Page URL and Page Url Length on the Console.
Get Page Source (HTML Source code) and Page Source length
Print Page Length on Console.
Close the Browser.
         * 
        */

        IWebDriver driver;
        
        [SetUp]
        public void browserInit()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void opentest()
        {
            driver.Url = "https://www.amazon.in/";
            String strTitle = driver.Title;
            Console.WriteLine("Browser Tile : "+strTitle);

            int Titlelength = strTitle.Length;
            Console.WriteLine("Browser Title Length : "+Titlelength);

            String strUrl = driver.Url;
            Console.WriteLine("Page URL : " + strUrl);

            int urlLength = strUrl.Length;
            Console.WriteLine("URL Length : "+urlLength);

            String strPagesource=driver.PageSource;
            Console.WriteLine("Browser PageSource : " +strPagesource);

            int pagesourcelength = strPagesource.Length;
            Console.WriteLine("Page Source Length : "+pagesourcelength);
        }


        [TearDown]
        public void browserQuit()
        {
            driver.Close();
        }

    }
}
