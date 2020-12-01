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
    internal class Manage_Request
    {
        public Manage_Request()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on Manage Request tab
        [FindsBy(How = How.XPath, Using = "//div[text()='Manage Requests']")]
        private IWebElement ClickManageRequest { get; set; }

        //Select Recieved Request
        [FindsBy(How = How.LinkText, Using = "Received Requests")]
        private IWebElement SelectReq { get; set; }

        //Accept Request
        [FindsBy(How = How.XPath, Using = "//*[@id='received-request-section']/div[2]/div[1]/table/tbody/tr[1]/td[8]/button[1]")]
        private IWebElement AcceptRequest { get; set; }

        //Decline Request
        [FindsBy(How = How.XPath, Using = "//*[@id='received-request-section']/div[2]/div[1]/table/tbody/tr[1]/td[8]/button[2]")]
        private IWebElement DeclineRequest { get; set; }

        //Complete Request
        [FindsBy(How = How.XPath, Using = "//*[@id='received-request-section']/div[2]/div[1]/table/tbody/tr[3]/td[8]/button")]
        private IWebElement CompleteRequest { get; set; }


        //Sent Request(skip)
        //Select Sent Request
        [FindsBy(How = How.LinkText, Using = "Sent Requests")]
        private IWebElement SelectSent { get; set; }

        //click search icon
        [FindsBy(How = How.XPath, Using = "//*[@id='service-search-section']/div[1]/div[1]/i")]
        private IWebElement Searchicon { get; set; }

        //skill find
        [FindsBy(How = How.XPath, Using = "//*[@id='service-search-section']/div[2]/div/section/div/div[2]/div/div[2]/div/div/div[3]/div[1]/a[1]")]
        private IWebElement skillfind { get; set; }

        //selenium find
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/table/tbody/tr/td[2]/div/div[1]/div[1]/a[2]/p")]
        private IWebElement seleniumfind { get; set; }

        //textarea
        [FindsBy(How = How.XPath, Using = "//*[@id='service-detail-section']/div[2]/div/div[2]/div[2]/div[2]/div/div[2]/div/div[1]/textarea")]
        private IWebElement textarea { get; set; }


        internal void Recevied_Request()
        {
            Thread.Sleep(2000);
            ClickManageRequest.Click();
            Thread.Sleep(2000);
            SelectReq.Click();
            Thread.Sleep(2000);
            AcceptRequest.Click();
            Thread.Sleep(2000);
            CompleteRequest.Click();


        }
    }
}
