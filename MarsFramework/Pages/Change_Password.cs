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
    internal class Change_Password
    {
        public Change_Password()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on Profile tab
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/div[1]/div[2]/div/span")]
        private IWebElement ClickProfile { get; set; }

        //Click on Chnage Password
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/div[1]/div[2]/div/span/div/a[2]")]
        private IWebElement ChangePassword { get; set; }

        //Current Password
        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div/div[2]/form/div[1]/input")]
        private IWebElement CurrentPassword { get; set; }

        //New Password
        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div/div[2]/form/div[2]/input")]
        private IWebElement NewPassword { get; set; }

        //Confirm Password
        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div/div[2]/form/div[3]/input")]
        private IWebElement ConfirmPassword { get; set; }

        //click save button
        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div/div[2]/form/div[4]/button")]
        private IWebElement Click_Save { get; set; }
        internal void Change_password()
        {
            Thread.Sleep(2000);
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Change_Password");
            ClickProfile.Click();
            Thread.Sleep(2000);
            ChangePassword.Click();
            Thread.Sleep(2000);
            CurrentPassword.Click();
            CurrentPassword.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Current_Password"));
            Thread.Sleep(2000);
            NewPassword.Click();
            NewPassword.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "New_Password"));
            Thread.Sleep(2000);
            ConfirmPassword.Click();
            ConfirmPassword.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Confirm_Password"));
            Thread.Sleep(2000);
            Click_Save.Click();
        }
    }
}
