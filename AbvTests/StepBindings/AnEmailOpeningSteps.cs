using AbvTests.WebElements;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace AbvTests
{
    [Binding]
    public class AnEmailOpeningSteps : IDisposable
    {
        private ChromeDriver driver = new ChromeDriver();

        [Given(@"I have opened ABV websitee")]
        public void GivenIHaveOpenedABVWebsitee()
        {
            AnEmailOpening page = new AnEmailOpening(driver);
            driver.Navigate().GoToUrl(page.homepage);
            driver.Manage().Window.Maximize();
        }

        [Given(@"I have entered my username ""(.*)""")]
        public void GivenIHaveEnteredMyUsername(string username)
        {
            AnEmailOpening page = new AnEmailOpening(driver);
            page.InputUsername(username);
        }
        
        [Given(@"I have entered my password ""(.*)""")]
        public void GivenIHaveEnteredMyPassword(string password)
        {
            AnEmailOpening page = new AnEmailOpening(driver);
            page.InputPassword(password);
        }

        [Given(@"I have entered successfully")]
        public void GivenIHaveEnteredSuccessfully()
        {
            AnEmailOpening page = new AnEmailOpening(driver);
            page.ClickSignInButton();
        }

        [Given(@"I click the Box")]
        public void GivenIClickTheBox()
        {
            AnEmailOpening page = new AnEmailOpening(driver);
            page.ClickMyBoxButton();
        }
        
        [Given(@"I click on the first email")]
        public void GivenIClickOnTheFirstEmail()
        {
            AnEmailOpening page = new AnEmailOpening(driver);
            page.ClickOnMyEmail();
        }
        
        [Then(@"I can see what my email contains")]
        public void ThenICanSeeWhatMyEmailContains()
        {
            AnEmailOpening page = new AnEmailOpening(driver);
            Assert.IsTrue(page.IsMsgDisplayed());
        }

        public void Dispose()
        {
            if(driver != null)
            {
                driver.Dispose();
                driver = null;
            }
        }
    }
}
