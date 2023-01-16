using OpenQA.Selenium;
using TrendyolCase.Utilities;

namespace TrendyolCase.Pages
{
    public class SearchPage
    {
        Helper helper = new Helper();

        public By allFilters = By.XPath("//div[contains(@class,'sort')]/select");
        public By firstProduct = By.XPath("(//div[contains(@class,'with-campaign-view')])[1]");
        public By productTitle = By.XPath("(//span[@class='prdct-desc-cntnr-name'])[1]");
        public By productPrice = By.XPath("(//div[@class='prc-box-dscntd'])[1]");

        public void FilterBy(string filter)
        {
            helper.SelectByValue(allFilters, filter);
        }

        public void ClickFirstProduct()
        {
            helper.ClickElement(firstProduct);
        } 

        public string getProductTitle()
        {
            return helper.getText(productTitle);
        }

        public string getProductPrice()
        {
            return helper.getText(productPrice);
        }
    }
}
