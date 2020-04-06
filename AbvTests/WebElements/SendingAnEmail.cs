using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AbvTests.WebElements
{
    class SendingAnEmail
    {
        public string homepage = "https://www.abv.bg/";

        private IWebDriver driver;

        readonly By usernameField = By.CssSelector("#username");
        readonly By passwordField = By.CssSelector("#password");
        readonly By signInButton = By.CssSelector("input#loginBut");
        readonly By sendMsgButton = By.CssSelector(".abv-button");
        readonly By sendingToField = By.CssSelector("tr:nth-of-type(2) > .clientField  .fl");
        readonly By themeMsgField = By.CssSelector(".gwt-TextBox");  
        readonly By sendEmailButton = By.CssSelector(".abv-button");
        readonly By confirmationMsg = By.CssSelector("div:nth-of-type(1) > .abv-h2");

        public SendingAnEmail(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void inputUsername(string username)
        {
            driver.FindElement(usernameField).Clear();
            driver.FindElement(usernameField).SendKeys(username);
        }

        public void inputPassword(string password)
        {
            driver.FindElement(passwordField).Clear();
            driver.FindElement(passwordField).SendKeys(password);
        }

        public void clickSignInButton()
        {           
            driver.FindElement(signInButton).Click();
        }

        public void clickSendMsgButton()
        {
            Monitor.Enter(driver);
            Monitor.Wait(driver, 3000);
            Monitor.Exit(driver);
            driver.FindElement(sendMsgButton).Click();
        }

        public void inputSendTo(string sendingTo)
        {
            Monitor.Enter(driver);
            Monitor.Wait(driver, 3000);
            Monitor.Exit(driver);
            driver.FindElement(sendingToField).Clear();
            driver.FindElement(sendingToField).SendKeys(sendingTo);
        }

        public void inputThemeMsg(string themeMsg)
        {
            Monitor.Enter(driver);
            Monitor.Wait(driver, 3000);
            Monitor.Exit(driver);
            driver.FindElement(themeMsgField).Clear();
            driver.FindElement(themeMsgField).SendKeys(themeMsg);
        }

        public void ClickOnSendEmailButton()
        {
            Monitor.Enter(driver);
            Monitor.Wait(driver, 3000);
            Monitor.Exit(driver);
            driver.FindElement(sendEmailButton).Click();
        }

        public bool isMsgDisplayed()
        {
            Monitor.Enter(driver);
            Monitor.Wait(driver, 3000);
            Monitor.Exit(driver);
            driver.Manage().Cookies.DeleteAllCookies();   
            return driver.FindElement(confirmationMsg).Displayed;
        }

    }
}
