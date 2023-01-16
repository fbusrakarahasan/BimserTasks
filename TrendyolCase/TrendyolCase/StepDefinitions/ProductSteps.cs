using TechTalk.SpecFlow;
using TrendyolCase.Pages;
using TrendyolCase.Utilities;

namespace TrendyolCase.StepDefinitions
{
    [Binding]
    public class ProductSteps
    { 
        Helper helper = new Helper();
        ProductPage productPage = new ProductPage();
         
        [When(@"Kullanıcı ürünü sepete ekler")]
        public void WhenKullanıcıUrunuSepeteEkler()
        {
            helper.switchToLastTab();
            productPage.ClickAddToBasket(); 
            Thread.Sleep(4000);
        }
    }
}
