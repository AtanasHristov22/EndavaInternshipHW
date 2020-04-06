using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AbvTests.WebElements
{
    class DeletingAllEmails
    {
        public string homepage = "https://www.abv.bg/";

        private IWebDriver driver;

        readonly By usernameField = By.CssSelector("#username");
        readonly By passwordField = By.CssSelector("#password");
        readonly By signInButton = By.CssSelector("input#loginBut");
        readonly By myBoxButton = By.CssSelector(".span");
        readonly By squareBox = By.CssSelector(".abv-topMenuWrapper label");
        readonly By deleteButton = By.CssSelector(".linksHolder > div:nth-of-type(1)");
        readonly By messageConfirmation = By.CssSelector("div:nth-of-type(3) > .abv-title");

        public DeletingAllEmails(IWebDriver driver)
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

        public void ClickOnSquareBox()
        {
            Monitor.Enter(driver);
            Monitor.Wait(driver, 3000);
            Monitor.Exit(driver);
            driver.FindElement(squareBox).Click();
        }

        public void ClickOnDeleteButton()
        {
            Monitor.Enter(driver);
            Monitor.Wait(driver, 3000);
            Monitor.Exit(driver);
            driver.FindElement(deleteButton).Click();
        }

        public bool IsMsgDislplayed()
        {
            Monitor.Enter(driver);
            Monitor.Wait(driver, 3000);
            Monitor.Exit(driver);
            driver.Manage().Cookies.DeleteAllCookies();
            return driver.FindElement(messageConfirmation).Displayed;
        }

    }
}
