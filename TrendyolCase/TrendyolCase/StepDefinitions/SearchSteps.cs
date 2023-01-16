using TechTalk.SpecFlow;
using TrendyolCase.Pages;

namespace TrendyolCase.StepDefinitions
{
    [Binding]
    public class SearchSteps
    { 
        SearchPage searchPage = new SearchPage();
        public static string firstProductTitle { get; set; }
        public static string firstProductPrice { get; set; }

        public string getProductTitle()
        {
            return firstProductTitle;
        }
        public string getProductPrice()
        {
            return firstProductPrice;
        }

        [When(@"Kullanıcı arama sonucunda gelen ürün listesini ""([^""]*)"" filtrelemesi ile sıralar")]
        public void WhenKullanıcıAramaSonucundaGelenUrunListesiniFiltrelemesiİleSıralar(string filter)
        {
            searchPage.FilterBy(filter);
            Thread.Sleep(5000);
        } 


        [When(@"Kullanıcı sıralamadaki en düşük fiyatlı ürüne tıklar")]
        public void WhenKullanıcıSıralamadakiEnDusukFiyatlıUruneTıklar()
        { 
            firstProductTitle = searchPage.getProductTitle();
            firstProductPrice = searchPage.getProductPrice();
            searchPage.ClickFirstProduct(); 
        }  
    }
}
