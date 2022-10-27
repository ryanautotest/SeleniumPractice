using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SeleniumPractice.Automation03.Constants.AppConstant;


namespace SeleniumPractice.Automation03.Pages
{
    public class Kenh14Page :BasePage
    {
        private readonly By TextInScreen = By.XPath("//a[@title='Ăn - Quẩy - Đi']");

        public string GetTextOnScreen()
        {
            IWebElement text = WEB_DRIVER.FindElement(TextInScreen);
            string txt = text.Text;
            return txt;
        }
    }
}
