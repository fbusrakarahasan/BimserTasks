using OpenQA.Selenium;
using TrendyolCase.Utilities;

namespace TrendyolCase.Pages
{
    public class HomePage
    {
        Helper helper = new Helper();

        public By acceptCookiesBtn = By.Id("onetrust-accept-btn-handler");
        public By searchField = By.XPath("//input[@data-testid='suggestion']");
        public By searchBtn = By.XPath("//i[@data-testid='search-icon']");
        public By loginPageBtn = By.CssSelector(".link.account-user");
        public By myAccount = By.XPath("//div[@class='link account-user']//p[text()='Hesabım']");
        public By logOutBtn = By.XPath("//button[@class='loggedin-account-item']");

        public void AcceptCookies()
        {
            helper.ClickElement(acceptCookiesBtn);
        }

        public void Search(string keyword)
        {
            helper.SendKeysElement(searchField, keyword);
        }

        public void ClickSearchBtn()
        {
            helper.ClickElement(searchBtn);
        }

        public void ClickLoginPageBtn()
        {
            helper.ClickElement(loginPageBtn);
        }

        public void WaitToLogin()
        {
            helper.waitFor(myAccount);
        } 

        public void LogOut()
        {
            helper.Hover(myAccount);
            helper.ClickElement(logOutBtn);
        }
    }
}
