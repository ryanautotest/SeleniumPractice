using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SeleniumPractice.Automation03.Constants.AppConstant;

namespace SeleniumPractice.Automation03.Pages
{
    public class BasePage
    {

        private readonly By TxtSearch = By.XPath("//input[@title]");
        private readonly By FirstResult = By.XPath("(//div[@id='search']//a)[1]");

        //Find Search Textbox
        protected IWebElement GetSearchTextBox()
        {
            return WEB_DRIVER.FindElement(TxtSearch);
        }
        //Get First Result
        protected IWebElement GetFirstResult()
        {
            return WEB_DRIVER.FindElement(FirstResult);
        }
        //Input and Enter
        public void SearchWithGoogle(string keyWord)
        {
            GetSearchTextBox().SendKeys(keyWord);
            GetSearchTextBox().SendKeys(Keys.Enter);
        }
        //Get page title
        public string GetPageTitle()
        {   
            string pageTitle = WEB_DRIVER.Title.ToString();
            string titleSubString = pageTitle.Substring(0, pageTitle.IndexOf(" -"));
            return titleSubString;
        }

        //3. Click to 1st result

        public void GoToFirstResultPage()
        {
            IWebElement result = WEB_DRIVER.FindElement(FirstResult);
            result.Click();
        }
        /*protected IWebElement FindElement(By by)
        {
            IWebElement e = WEB_DRIVER.FindElement(by);
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
            return e;
        }
        */
    }
}
