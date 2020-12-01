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
    internal class Location_Avaliblity
    {
        public Location_Avaliblity()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on Avaliblity
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i")]
        private IWebElement ClickAvaliblity { get; set; }

        //Select Avaliblity
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select/option[3]")]
        private IWebElement SelectAvaliblity { get; set; }

        //Click on Hours
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i")]
        private IWebElement ClickonHours { get; set; }

        //Select Hours
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select/option[3]")]
        private IWebElement SelectHours { get; set; }

        //Click on Earn Target
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i")]
        private IWebElement ClickonEarnTarget { get; set; }

        //Select EarnTarget
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select/option[3]")]
        private IWebElement SelectEarnTarget { get; set; }


        internal void Location()
        {
            Thread.Sleep(2000);
            ClickAvaliblity.Click();
            SelectAvaliblity.Click();
            ClickonHours.Click();
            SelectHours.Click();
            ClickonEarnTarget.Click();
            SelectEarnTarget.Click();


        }
    }
}
