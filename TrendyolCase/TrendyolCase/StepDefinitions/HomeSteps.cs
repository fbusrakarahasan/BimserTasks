using TechTalk.SpecFlow;
using TrendyolCase.Pages;

namespace TrendyolCase.StepDefinitions
{
    [Binding]
    public class HomeSteps
    {
        HomePage homePage = new HomePage();

        [When(@"Kullanıcı çerez politikasını kabul eder")]
        public void WhenKullanıcıCerezPolitikasınıKabulEder()
        {
            homePage.AcceptCookies();
        }

        [When(@"Kullanıcı giriş yap butonuna tıklar")]
        public void WhenKullanıcıGirisYapButonunaTıklar()
        {
            homePage.ClickLoginPageBtn();
        }

        [When(@"Kullanıcı arama alanına ""([^""]*)"" yazar ve ara butonuna tıklar")]
        public void WhenKullanıcıAramaAlanınaYazarVeAraButonunaTıklar(string searchKey)
        {
            homePage.WaitToLogin();
            homePage.Search(searchKey);
            homePage.ClickSearchBtn();
        }

        [Then(@"Kullanıcı çıkış yapar")]
        public void ThenKullanıcıCıkısYapar()
        {
            homePage.LogOut();
        } 
    }
}
