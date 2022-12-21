using Applitools.Drivers;
using Applitools.POM;

namespace Applitools.StepDefinitions
{

    [Binding]
    public class ScenariosStepDefinitions : webdriver
    {
        POM.Applitools w;

        [Given(@"Navigate to url")]
        public void GivenNavigateToUrl()
        {
            setup();
        }

        [When(@"click on about link")]
        public void WhenClickOnAboutLink()
        {
            w = new POM.Applitools(driver);
        }

        [Then(@"about link page should open")]
        public void ThenAboutLinkPageShouldOpen()
        {
            Thread.Sleep(3000);
            closedriver();
        }
    }
}

    

