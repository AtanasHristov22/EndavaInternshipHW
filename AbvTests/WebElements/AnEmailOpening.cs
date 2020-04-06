using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AbvTests.WebElements
{
    class AnEmailOpening
    {
        public string homepage = "https://www.abv.bg/";

        private IWebDriver driver;

        readonly By usernameField = By.CssSelector("#username");
        readonly By passwordField = By.CssSelector("#password");
        readonly By signInButton = By.CssSelector("input#loginBut");
        readonly By myBoxButton = By.CssSelector(".abv-foldersTable > tbody:nth-of-type(1) > tr:nth-of-type(1)");
        readonly By myEmail = By.CssSelector(".GG3HBNKBDI.inbox-cellTableCell.inbox-cellTableSecondColumn");
        readonly By msgConfirmation = By.CssSelector("tr:nth-of-type(1) > td:nth-of-type(2) > div > .abv-mr.fl");

        public AnEmailOpening(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void InputUsername(string username)
        {
            driver.FindElement(usernameField).Clear();
            driver.FindElement(usernameField).SendKeys(username);
        }

        public void InputPassword(string password)
        {
            driver.FindElement(passwordField).Clear();
            driver.FindElement(passwordField).SendKeys(password);
        }

        public void ClickSignInButton()
        {
            driver.FindElement(signInButton).Click();
        }

        public void ClickMyBoxButton()
        {
            Monitor.Enter(driver);
            Monitor.Wait(driver, 3000);
            Monitor.Exit(driver);
            driver.FindElement(myBoxButton).Click();
        }

        public void ClickOnMyEmail()
        {
            Monitor.Enter(driver);
            Monitor.Wait(driver, 3000);
            Monitor.Exit(driver);
            driver.FindElement(myEmail).Click();
        }

        public bool IsMsgDisplayed()
        {
            Monitor.Enter(driver);
            Monitor.Wait(driver, 3000);
            Monitor.Exit(driver);
            driver.Manage().Cookies.DeleteAllCookies();
            return driver.FindElement(msgConfirmation).Displayed;
        }    
    }
}
