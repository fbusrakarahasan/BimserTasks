using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace TrendyolCase.Utilities
{
    public class Helper
    {
        public static IWebDriver driver = Driver.get();
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(25));
         
        public void ClickElement(By locator)
        {
            IWebElement element = driver.FindElement(locator);
            
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
            try
            {
                element.Click(); 
            }
            catch (StaleElementReferenceException)
            {
                IWebElement staleElement = driver.FindElement(locator);
                staleElement.Click();
            }
        }

        public void SendKeysElement(By locator, String value)
        {
            IWebElement element = driver.FindElement(locator); 
            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(locator));
            element.SendKeys(value);
        } 

        public void waitFor(By locator)
        { 
            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(locator)); 
        }

        public void GoToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }  

        public void SelectByValue(By locator,string text)
        {
            IWebElement element = driver.FindElement(locator);

            SelectElement categories = new SelectElement(element);  //kategori seçimi yapıldı
            categories.SelectByValue(text);
        }

        public void switchToLastTab()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
        }

        public string getText(By locator)
        {
            IWebElement element = driver.FindElement(locator);

            return element.Text;
        }

        public void Hover(By locator)
        {
            IWebElement element = driver.FindElement(locator);

            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }
    }
}
