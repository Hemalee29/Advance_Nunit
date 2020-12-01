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
    internal class Search_Skill
    {
        public Search_Skill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //find search skil
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/div[1]/div[1]/input")]
        private IWebElement clicksearckskill { get; set; }

        //Enter search skil
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/div[1]/div[1]/i")]
        private IWebElement Entersearckskill { get; set; }

        // search skil
        [FindsBy(How = How.XPath, Using = "//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[2]/input")]
        private IWebElement searckskill { get; set; }

        //Enter click search skil
        [FindsBy(How = How.XPath, Using = "//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[2]/i")]
        private IWebElement EnterClicksearckskill { get; set; }

        //Search user
        [FindsBy(How = How.XPath, Using = "//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[3]/div[1]/div/div[1]/input")]
        private IWebElement Searchuser { get; set; }

        //click Search user
        [FindsBy(How = How.XPath, Using = "//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[3]/div[1]/div/div[2]/div[1]/div/span")]
        private IWebElement ClickSearchuser { get; set; }



        //Search by filter online
        [FindsBy(How = How.XPath, Using = "//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[5]/button[1]")]
        private IWebElement filter_Online { get; set; }

        //Search by filter onsite
        [FindsBy(How = How.XPath, Using = "//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[5]/button[2]")]
        private IWebElement filter_Onsite { get; set; }

        //Search by filter Showall
        [FindsBy(How = How.XPath, Using = "//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[5]/button[3]")]
        private IWebElement filter_Showall { get; set; }
        internal void Search_skill()
        {
            Thread.Sleep(2000);
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Search_Skill");
            Thread.Sleep(2000);
            clicksearckskill.Click();
            clicksearckskill.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "search_Skill"));
            Thread.Sleep(2000);
            Entersearckskill.Click();
            Thread.Sleep(2000);
            searckskill.Click();
            searckskill.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "searchskill"));
            Thread.Sleep(2000);
            EnterClicksearckskill.Click();
            Thread.Sleep(2000);
            Searchuser.Click();
            Thread.Sleep(2000);
            Searchuser.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "searchuser"));
            Thread.Sleep(2000);
            ClickSearchuser.Click();


        }


        internal void Search_Filter()
        {
            Entersearckskill.Click();
            Thread.Sleep(2000);
            filter_Online.Click();
            Thread.Sleep(2000);
            filter_Onsite.Click();
            Thread.Sleep(2000);
            filter_Showall.Click();


        }
    }
}
