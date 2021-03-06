﻿using AbvTests.WebElements;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace AbvTests
{
    [Binding]
    public class DeletingAllEmailsSteps : IDisposable
    {
        private ChromeDriver driver = new ChromeDriver();

        [Given(@"I've opened abv website")]
        public void GivenIVeOpenedAbvWebsite()
        {
            DeletingAllEmails page = new DeletingAllEmails(driver);
            driver.Navigate().GoToUrl(page.homepage);
            driver.Manage().Window.Maximize();
        }
        
        [Given(@"I've entered my username ""(.*)""")]
        public void GivenIVeEnteredMyUsername(string username)
        {
            DeletingAllEmails page = new DeletingAllEmails(driver);
            page.InputUsername(username);
        }
        
        [Given(@"I've entered my password ""(.*)""")]
        public void GivenIVeEnteredMyPassword(string password)
        {
            DeletingAllEmails page = new DeletingAllEmails(driver);
            page.InputPassword(password);
        }
        
        [Given(@"I've entered successfully")]
        public void GivenIVeEnteredSuccessfully()
        {
            DeletingAllEmails page = new DeletingAllEmails(driver);
            page.ClickSignInButton();
        }
        
        [Given(@"I click on my email box")]
        public void GivenIClickOnMyEmailBox()
        {
            DeletingAllEmails page = new DeletingAllEmails(driver);
            page.ClickMyBoxButton();
        }
        
        [Given(@"I click on mark all of my emails square")]
        public void GivenIClickOnMarkAllOfMyEmailsSquare()
        {
            DeletingAllEmails page = new DeletingAllEmails(driver);
            page.ClickOnSquareBox();
        }
        
        [Given(@"I click the button delete")]
        public void GivenIClickTheButtonDelete()
        {
            DeletingAllEmails page = new DeletingAllEmails(driver);
            page.ClickOnDeleteButton();
        }
        
        [Then(@"I can see the result")]
        public void ThenICanSeeTheResult()
        {
            DeletingAllEmails page = new DeletingAllEmails(driver);
            Assert.IsTrue(page.IsMsgDislplayed());
        }
        public void Dispose()
        {
            if (driver != null)
            {
                driver.Dispose();
                driver = null;
            }
        }
    }
}
