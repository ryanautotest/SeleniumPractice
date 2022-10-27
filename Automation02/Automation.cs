using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Automation02
{
    public class Tests
    {
        public IWebDriver? _driver;
        public WebDriverWait? _wait;
        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

        }

        [TearDown]
        public void Close()
        {
            _driver.Close();
        }

        [Test]
        public void Test1()
        {
            //Goto page
            _driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            //print message inform open successfuly
            if (_driver.FindElement(By.XPath("//img[@class='logo img-responsive']")).Displayed)
            {
                Console.WriteLine("Open page sucessfully");
            }
            else
            {
                Console.WriteLine("Cannot open page");
            }

            //wait for an element is clickable
            IWebElement contacUs = _wait.Until
                (SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable
                (By.XPath("//a[@title='Contact Us']")));
            //click to contact us

            contacUs.Click();
            //wait for display
            IWebElement formTitle = _wait.Until
                (SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible
                (By.XPath("//h1")));
            //title of form is contact us

            if (formTitle.Text.Equals("CUSTOMER SERVICE - CONTACT US"))
            {
                Console.WriteLine("Form Title is correct");
            }
            else
            {
                Console.WriteLine("Form Title is incorrect");
            }
            //wait for is selected - not finished

            // _wait.Until
            /*
            SelectElement dropDown = new SelectElement(_driver.FindElement(By.XPath("//select")));
            dropDown.SelectByIndex(2);
            Console.WriteLine("Dropdown is selected 1");
            IWebElement dropValue = _driver.FindElement(By.XPath("//select"));
            Console.WriteLine("Dropdown is selected 3");
            */

            //back to homepage
            _driver.Navigate().Back();
            //verify title of page is My store
            Boolean verifyTitle = _driver.Title.Equals("My Store");
            Assert.That(verifyTitle, Is.True);
            Console.WriteLine("Page Title is correct");

            //use forward command
            _driver.Navigate().Forward();
        }

        public SelectElement SelectValue (By by)
        {
            SelectElement d = (SelectElement)_driver.FindElement(by);
            _wait.Until
               (SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeSelected(
                   by));
            d.SelectByIndex(2);
            return d;
            

        }
    }
}