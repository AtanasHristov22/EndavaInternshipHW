﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AbvTests.WebElements
{
    class LogInPage
    {
        public string homepage = "https://www.abv.bg/";

        private IWebDriver driver;

        readonly By usernameField = By.CssSelector("#username");  
        readonly By passwordField = By.CssSelector("#password");
        readonly By signInButton = By.CssSelector("input#loginBut");
        readonly By messageConfirmation = By.CssSelector(".userEmail");
        readonly By messageFail = By.CssSelector("p#form\\.errors");
        public LogInPage(IWebDriver driver)
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

        public bool IsMsgDisplayed()
        {
            Monitor.Enter(driver);
            Monitor.Wait(driver, 3000);
            Monitor.Exit(driver);
            return driver.FindElement(messageConfirmation).Displayed;
        }
        public bool IsFalseMsgDisplayed()
        {
            Monitor.Enter(driver);
            Monitor.Wait(driver, 3000);
            Monitor.Exit(driver);
            driver.Manage().Cookies.DeleteAllCookies();
            return driver.FindElement(messageFail).Displayed;
        }

    }
}
