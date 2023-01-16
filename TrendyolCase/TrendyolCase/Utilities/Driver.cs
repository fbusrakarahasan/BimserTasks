using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace TrendyolCase.Utilities
{ 
    [Binding]
    public class Driver
    { 
        public static IWebDriver driver; 
         
        public static IWebDriver get()
        { 
            if (driver == null)
            {
                driver = new ChromeDriver();
            }

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            return driver;
        }
         
        [AfterScenario]
        public void closeDriver()
        { 
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }
    }
}
