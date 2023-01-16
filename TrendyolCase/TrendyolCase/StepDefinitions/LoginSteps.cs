using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TrendyolCase.Pages;

namespace TrendyolCase.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        LoginPage loginPage = new LoginPage();

        [When(@"Kullanıcı aşağıdaki veriler ile giriş yapar:")]
        public void WhenKullanıcıAsağıdakiVerilerİleGirisYapar(Table table)
        {
            var user = table.CreateInstance<(string mail, string password)>();

            loginPage.FillEmailField(user.mail);
            loginPage.FillPasswordField(user.password);
            loginPage.ClickLoginBtn(); 
        }
    }
}
