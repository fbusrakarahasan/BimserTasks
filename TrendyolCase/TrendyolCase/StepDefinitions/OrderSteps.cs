using TechTalk.SpecFlow;
using TrendyolCase.Pages;

namespace TrendyolCase.StepDefinitions
{
    [Binding]
    public class OrderSteps
    {
        OrderPage orderPage = new OrderPage(); 
         
        [Then(@"Kullanıcı sepetteki ürünün en düşük fiyatlı ürün olduğunu doğrular")]
        public void ThenKullanıcıSepettekiUrununEnDusukFiyatlıUrunOlduğunuDoğrular()
        {
            orderPage.ICheckThatIHaveAddedTheCorrectProductToTheBasket();
        }
    }
}
