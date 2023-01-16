using TechTalk.SpecFlow;
using TrendyolCase.Utilities;

namespace TrendyolCase.StepDefinitions
{
    [Binding]
    public class GeneralSteps
    {
        Helper helper = new Helper();

        [Given(@"Kullanıcı ""([^""]*)"" sitesini ziyaret eder")]
        public void GivenKullanıcıSitesiniZiyaretEder(string url)
        {
            helper.GoToUrl(url);
        } 
    }
}
