using AbvTests.WebElements;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace AbvTests
{
    [Binding]
    public class LogInTestSteps : IDisposable
    {

        private ChromeDriver driver = new ChromeDriver();

        [Given(@"I have opened ABV website")]
        public void GivenIHaveOpenedABVWebsite()
        {
            LogInPage logInPage = new LogInPage(driver);
            driver.Navigate().GoToUrl(logInPage.homepage);
            driver.Manage().Window.Maximize();
        }
        
        [When(@"I enter username ""(.*)""")]
        public void WhenIEnterUsername(string username)
        {
            LogInPage logInPage = new LogInPage(driver);
            logInPage.InputUsername(username);
        }
        
        [When(@"I enter password ""(.*)""")]
        public void WhenIEnterPassword(string password)
        {
            LogInPage logInPage = new LogInPage(driver);
            logInPage.InputPassword(password);
        }
        
        [When(@"I click the button Sign in")]
        public void WhenIClickTheButtonSignIn()
        {
            LogInPage logInPage = new LogInPage(driver);
            logInPage.ClickSignInButton();
        }
        
        [Then(@"I should see the account's email page")]
        public void ThenIShouldSeeTheAccountSEmailPage()
        {
            LogInPage logInPage = new LogInPage(driver);
            Assert.IsTrue(logInPage.IsMsgDisplayed());
            
        }
        [Then(@"I should not see the account's email page")]
        public void ThenIShouldNotSeeTheAccountSEmailPage()
        {
            LogInPage logInPage = new LogInPage(driver);
            Assert.IsTrue(logInPage.IsFalseMsgDisplayed());
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
