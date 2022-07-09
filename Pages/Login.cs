using FaceBookLoginTesting.DataReader;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FaceBookLoginTesting.Pages
{
    public class Login
    {
        IWebDriver driver;

        [FindsBy(How = How.Id, Using = "email")]
        IWebElement UserName; 
        [FindsBy(How =  How.Id, Using = "pass")]
        IWebElement Password;
        [FindsBy(How = How.Id, Using = "loginbutton")]
        IWebElement LoginBtn;




        public Login(IWebDriver _driver)
        {
            driver = _driver;
            PageFactory.InitElements(driver,this);
        }

        public void facebookLogin()
        {

            /*UserName.SendKeys("");
            Password.SendKeys("");
            LoginBtn.Click();*/

           readDataFromExcel();

        }


        public void readDataFromExcel()
        {
            DataReaderExcel reader = new DataReaderExcel();
            DataTable dt = reader.readData();

           UserName.SendKeys(dt.Rows[0][0].ToString());
           Password.SendKeys(dt.Rows[0][1].ToString());
            LoginBtn.Click();
        }
        
    }
}
