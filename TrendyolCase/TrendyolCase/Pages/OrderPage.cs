using NUnit.Framework;
using OpenQA.Selenium;
using TrendyolCase.StepDefinitions;
using TrendyolCase.Utilities;

namespace TrendyolCase.Pages
{
    public class OrderPage
    {
        Helper helper = new Helper();
        SearchSteps searchSteps = new SearchSteps();
         
        public By basketProductTitle = By.XPath("//span[@class='product-preview-product-name']");
        public By basketProductPrice = By.XPath("//span[@class='basket-recommendation-preview-product-price']");

        public void ICheckThatIHaveAddedTheCorrectProductToTheBasket()
        { 
            Assert.AreEqual(searchSteps.getProductTitle(), helper.getText(basketProductTitle));
            Assert.AreEqual(searchSteps.getProductPrice(), helper.getText(basketProductPrice));
        }
    }
}
