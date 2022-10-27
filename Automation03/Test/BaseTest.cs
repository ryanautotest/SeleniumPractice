using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumPractice.Automation03.Pages;
using static SeleniumPractice.Automation03.Constants.AppConstant;


namespace SeleniumPractice.Automation03.Test
{
    public class BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            WEB_DRIVER = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
            WEB_DRIVER.Manage().Window.Maximize();
            WEB_DRIVER.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            WEB_DRIVER.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TearDown]
        public void Close()
        {
            WEB_DRIVER.Close();
        }
    }
}
