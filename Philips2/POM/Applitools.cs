using OpenQA.Selenium;
using Applitools.Drivers;
using SeleniumExtras.PageObjects;

namespace Applitools.POM
{
    public class Applitools : webdriver
    {  
        public Applitools(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "login-item")]
        public IWebElement loginbtn;

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement email;

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement password;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"inner-form-container\"]/form/div/div[4]/button")]
        public IWebElement signinbtn;

        [FindsBy(How = How.Id, Using = "//*[@id=\"google-signin\"]/i")]
        public IWebElement google;

        [FindsBy(How = How.Id, Using = "//*[@id=\"inner-form-container\"]/form/div/div[5]/div[3]/button/i")]
        public IWebElement github;

        [FindsBy(How = How.Id, Using = "//*[@id=\"register-link-container\"]/a")]
        public IWebElement signup;

        [FindsBy(How = How.Id, Using = "//*[@id=\"inner-form-container\"]/form/div/div[2]/a")]
        public IWebElement forgot;

        [FindsBy(How = How.Id, Using = "/html/body/div/div[2]/a")]
        public IWebElement learnmorebtn;







    }


}
