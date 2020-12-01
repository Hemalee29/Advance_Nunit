using MarsFramework.Global;
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
    internal class Chat
    {
        public Chat()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on Notification tab
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/div[1]/div[2]/div/a[1]")]
        private IWebElement clickChat { get; set; }

        //Click on Notification tab
        [FindsBy(How = How.XPath, Using = "//*[@id='chatTextBox']")]
        private IWebElement EnterChat { get; set; }

        //Click on Send tab
        [FindsBy(How = How.XPath, Using = "//*[@id='btnSend']")]
        private IWebElement clickSend { get; set; }

        internal void chat()
        {
            Thread.Sleep(2000);
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Chat");
            
            clickChat.Click();

            Thread.Sleep(2000);
            EnterChat.Click();
            EnterChat.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EnterText"));
            Thread.Sleep(2000);
            clickSend.Click();



        }
    }
}
