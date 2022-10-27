using SeleniumPractice.Automation03.Pages;
using static SeleniumPractice.Automation03.Constants.AppConstant;


namespace Automation03
{
    public class HomePage : BasePage
    {
        public void Open()
        {
            WEB_DRIVER.Navigate().GoToUrl(URL_APP);
        }
    }
}