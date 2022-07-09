using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceBookLoginTesting.Pages
{
    public class HomePage
    {
        IWebDriver driver;

        public IWebDriver NavigateHomePage()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com/login/");
            driver.Manage().Window.Maximize();
            return driver;
        }



    }
}
