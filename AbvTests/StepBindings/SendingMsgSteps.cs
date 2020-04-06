using AbvTests.WebElements;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace AbvTests
{
    [Binding]
    public class SendingMsgSteps : IDisposable
    {

        private ChromeDriver driver = new ChromeDriver();

        [Given(@"I have opened abv website")]
        public void GivenIHaveOpenedAbvWebsite()
        {
            SendingAnEmail sendingMsgPage = new SendingAnEmail(driver);
            driver.Navigate().GoToUrl(sendingMsgPage.homepage);
            driver.Manage().Window.Maximize();           
        }
        
        [Given(@"I have entered username ""(.*)""")]
        public void GivenIHaveEnteredUsername(string username)
        {
            SendingAnEmail sendingMsgPage = new SendingAnEmail(driver);
            sendingMsgPage.inputUsername(username);
        }
        
        [Given(@"I have entered password ""(.*)""")]
        public void GivenIHaveEnteredPassword(string password)
        {
            SendingAnEmail sendingMsgPage = new SendingAnEmail(driver);
            sendingMsgPage.inputPassword(password);
        }
        
        [Given(@"I am in it successfully")]
        public void GivenIAmInItSuccessfully()
        {
            SendingAnEmail sendingMsgPage = new SendingAnEmail(driver);
            sendingMsgPage.clickSignInButton();
        }
        
        [Given(@"I click on the Send an email button")]
        public void GivenIClickOnTheSendAnEmailButton()
        {
            SendingAnEmail sendingMsgPage = new SendingAnEmail(driver);
            sendingMsgPage.clickSendMsgButton();
        }
        
        [Given(@"I have entered the email ""(.*)""")]
        public void GivenIHaveEnteredTheEmail(string sendingTo)
        {
            SendingAnEmail sendingMsgPage = new SendingAnEmail(driver);
            sendingMsgPage.inputSendTo(sendingTo);
        }
        
        [Given(@"I have wrote a theme ""(.*)""")]
        public void GivenIHaveWroteATheme(string themeMsg)
        {
            SendingAnEmail sendingMsgPage = new SendingAnEmail(driver);
            sendingMsgPage.inputThemeMsg(themeMsg);
        }

        [Given(@"I have clicked on send Email button")]
        public void GivenIHaveClickedOnSendEmailButton()
        {
            SendingAnEmail sendingMsgPage = new SendingAnEmail(driver);
            sendingMsgPage.ClickOnSendEmailButton();
        }

        [Then(@"the result should see the result")]
        public void ThenTheResultShouldSeeTheResult()
        {
            SendingAnEmail sendingMsgPage = new SendingAnEmail(driver);
            Assert.IsTrue(sendingMsgPage.isMsgDisplayed());
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
