using Automation03;
using OpenQA.Selenium;
using SeleniumPractice.Automation03.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static SeleniumPractice.Automation03.Constants.AppConstant;


namespace SeleniumPractice.Automation03.Test
{
    public class SearchOnGoogleTest : BaseTest
    {
        
        [Test]
        public void Scenario01()
        {
            HomePage homePage = new HomePage();
            homePage.Open();

            BasePage basePage = new BasePage();
            basePage.SearchWithGoogle(keyWord);

            string titleSubString = basePage.GetPageTitle();
            Assert.AreEqual(keyWord, titleSubString, "Matched Result");

            homePage.GoToFirstResultPage();
            Kenh14Page kenh14Page = new Kenh14Page();
            string textOnScreen = kenh14Page.GetTextOnScreen();
            Assert.AreEqual(expectedText, textOnScreen, "Matched Text");
        }
    }

}
