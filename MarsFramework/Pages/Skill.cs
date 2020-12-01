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
    internal class Skill
    {
        public Skill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on skill tab
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")]
        private IWebElement ClickSkilltab { get; set; }

        //Add new button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")]
        private IWebElement Addnewbutton { get; set; }

        //Add Skill
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input")]
        private IWebElement AddSkill { get; set; }

        //Choose Skill
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select")]
        private IWebElement SelectSkill { get; set; }

        //Dropdown value
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]")]
        private IWebElement Intermediate { get; set; }

        //Click Add button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")]
        private IWebElement AddButton { get; set; }

        //Edit skill

        //Click edit buttton
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i")]
        private IWebElement EditButton { get; set; }

        //Edit Skill
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input")]
        private IWebElement Editskill { get; set; }

        //Edit Dropdown

        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select")]
        private IWebElement EditDropdown { get; set; }

        //Dropdown value
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[4]")]
        private IWebElement Expert { get; set; }

        //Update button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]")]
        private IWebElement Updatebutton { get; set; }


        //Delete
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i")]
        private IWebElement Deletebutton { get; set; }

        internal void Skill_Add()
        {
            Thread.Sleep(2000);
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Skill");
            ClickSkilltab.Click();
            Addnewbutton.Click();
            AddSkill.Click();
            AddSkill.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill"));
            SelectSkill.Click();
            Intermediate.Click();
            AddButton.Click();

        }

        internal void Skill_Edit()
        {
            Thread.Sleep(2000);
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Skill");
            ClickSkilltab.Click();
            EditButton.Click();
            Editskill.Click();
            Editskill.Clear();
            Editskill.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EditSkill"));
            EditDropdown.Click();
            Expert.Click();
            Updatebutton.Click();
        }

        internal void Skill_Delete()
        {
            Thread.Sleep(2000);
            ClickSkilltab.Click();
            Deletebutton.Click();

        }
    }
}
