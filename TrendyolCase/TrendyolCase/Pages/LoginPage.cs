using OpenQA.Selenium;
using TrendyolCase.Utilities;

namespace TrendyolCase.Pages
{
    public class LoginPage : Helper
    {
        public By emailField = By.Id("login-email");
        public By passField = By.Id("login-password-input");
        public By loginBtn = By.CssSelector(".q-button.submit");

        public void FillEmailField(string email)
        {
            SendKeysElement(emailField, email);
        }

        public void FillPasswordField(string password)
        {
            SendKeysElement(passField, password);
        }

        public void ClickLoginBtn()
        {
            ClickElement(loginBtn);
        }
    }
}
