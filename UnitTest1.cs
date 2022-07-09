using FaceBookLoginTesting.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace FaceBookLoginTesting
{
    public class Tests
    {
        IWebDriver driver;
        Login obj;

        [OneTimeSetUp]
        public void Setup()
        {
            HomePage homeobj = new HomePage();
            driver = homeobj.NavigateHomePage();
            
        }

        [Test]
        public void Test1()
        {
            obj = new Login(driver);
            obj.facebookLogin();
            Assert.Pass();
        }

        [OneTimeTearDown]
        public void CloseBrowser()
        {
            driver.Close(); 
            driver.Quit();
        }
    }
}