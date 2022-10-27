using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPractice.Automation03.Constants
{
    public static class AppConstant
    {
        public static IWebDriver? WEB_DRIVER;
        public static string URL_APP = "http://www.google.com/";
        public static string keyWord = "kenh14";
        public static string expectedText = "Ăn - Quẩy - Đi";
    }
}
