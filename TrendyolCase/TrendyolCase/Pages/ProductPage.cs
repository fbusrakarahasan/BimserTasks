using OpenQA.Selenium;
using TrendyolCase.Utilities;

namespace TrendyolCase.Pages
{
    public class ProductPage
    {
        Helper helper = new Helper(); 
        public By addToBasket = By.XPath("//button[@class='add-to-basket']");
         
        public void ClickAddToBasket()
        {
            helper.ClickElement(addToBasket);
        } 
    }
}
