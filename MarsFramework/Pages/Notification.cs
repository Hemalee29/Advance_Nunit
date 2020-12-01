using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    class Notification
    {
        public Notification()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on Notification tab
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/div[1]/div[2]/div/div")]
        private IWebElement ClickNotification { get; set; }

        //Click on See all
        [FindsBy(How = How.LinkText, Using = "See All...")]
        private IWebElement ClickonSeeall { get; set; }

        //Select All
        [FindsBy(How = How.XPath, Using = "//*[@id='notification-section']/div[2]/div/div/div[3]/div[1]/div[1]/i")]
        private IWebElement SelectAll{ get; set; }

        //UnSelect All
        [FindsBy(How = How.XPath, Using = "//*[@id='notification-section']/div[2]/div/div/div[3]/div[1]/div[2]")]
        private IWebElement UnSelectAll { get; set; }

        //Select one
        [FindsBy(How = How.XPath, Using = "//*[@id='notification-section']/div[2]/div/div/div[3]/div[2]/span/span/div/div[1]/div/div/div[3]/input")]
        private IWebElement SelectOne { get; set; }

        //Mark Selction as read
        [FindsBy(How = How.XPath, Using = "//*[@id='notification-section']/div[2]/div/div/div[3]/div[1]/div[4]")]
        private IWebElement  MarkSelection { get; set; }

        //Delete
        [FindsBy(How = How.XPath, Using = "//*[@id='notification-section']/div[2]/div/div/div[3]/div[1]/div[3]/i")]
        private IWebElement Delete { get; set; }
        internal void notification()
        {
            Thread.Sleep(2000);
            //GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Certificate");
            ClickNotification.Click();
            Thread.Sleep(2000);
            ClickonSeeall.Click();
            Thread.Sleep(2000);
            SelectAll.Click();
            Thread.Sleep(2000);
            UnSelectAll.Click();
            Thread.Sleep(2000);
            SelectOne.Click();
            Thread.Sleep(2000);
            Delete.Click();
            Thread.Sleep(2000);
            SelectOne.Click();
            Thread.Sleep(2000);
            MarkSelection.Click();
            Thread.Sleep(2000);



        }
    }
}
