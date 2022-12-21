using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Applitools.Drivers
{
    public class webdriver
    {
        public IWebDriver driver;   

        public void setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://applitools.com/");
        }
        public void closedriver()
        {
            driver.Quit();
        }
    }
}
