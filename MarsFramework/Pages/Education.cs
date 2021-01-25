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
    internal class Education
    {
        public Education()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on Education tab
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")]
        private IWebElement ClickEducationtab { get; set; }

        //Click on Addnew button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div")]
        private IWebElement ClickAddnew { get; set; }

        //Enter collage
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input")]
        private IWebElement ClickCollage { get; set; }

        //select collage dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select")]
        private IWebElement collagedropdown { get; set; }

        //Collage dropdown value
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[66]")]
        private IWebElement Collagevalue { get; set; }

        //select title
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select")]
        private IWebElement selectTitle { get; set; }

        //Title dropdown value
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[7]")]
        private IWebElement Titlevalue { get; set; }

        //Enter degree
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input")]
        private IWebElement Degree { get; set; }

        //Select year of graducation
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select")]
        private IWebElement graduation { get; set; }

        //Title dropdown value
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[7]")]
        private IWebElement graduationvalue { get; set; }

        //Click add button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]")]
        private IWebElement ClickAdd { get; set; }

        //Edit Education

        //click Edit button
        
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i")]
        private IWebElement Editbutton { get; set; }

        //Edit Collage

        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[1]/input")]
        private IWebElement Editcollage { get; set; }

        //Edit collage dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[2]/select")]
        private IWebElement Editcollagedropdown { get; set; }

        //Edit collage dropdown value
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[2]/select/option[11]")]
        private IWebElement Editdropdownvalue { get; set; }

        //Edit title
       
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[1]/select")]
        private IWebElement EditTitle { get; set; }


        //Edit title value 

        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[1]/select/option[8]")]
        private IWebElement EditTitlevalue { get; set; }

        //Edit degree
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[2]/input")]
        private IWebElement EditDegree { get; set; }

        //Edit year of graducation
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[3]/select")]
        private IWebElement Editgraduationyear { get; set; }

        //Edit year of graducation value
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[3]/select/option[13]")]
        private IWebElement Editgraduationyearvalue { get; set; }

        //Click update button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]")]
        private IWebElement Updatebutton { get; set; }

        //Delete button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i")]
        private IWebElement Deletebutton { get; set; }
        public void Education_Add()
        {
            Thread.Sleep(2000);
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Education");

            ClickEducationtab.Click();
            ClickAddnew.Click();
            ClickCollage.Click();
            ClickCollage.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Collage"));
            collagedropdown.Click();
            Collagevalue.Click();
            selectTitle.Click();
            Titlevalue.Click();
            Degree.Click();
            Degree.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Degree"));
            graduation.Click();
            graduationvalue.Click();
            ClickAdd.Click();


        }

       public void Education_Edit()
        {
            Thread.Sleep(2000);
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Education");

            ClickEducationtab.Click();
            Editbutton.Click();
            Editcollage.Click();
            Editcollage.Clear();
            Editcollage.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EditCollage"));
            Editcollagedropdown.Click();
            Editdropdownvalue.Click();
            EditTitle.Click();
            EditTitlevalue.Click();
            EditDegree.Click();
            EditDegree.Clear();
            EditDegree.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EditCollage"));
            Editgraduationyear.Click();
            Editgraduationyearvalue.Click();
            Updatebutton.Click();

        }

        public void Education_Delete()
        {
            Thread.Sleep(2000);
            ClickEducationtab.Click();
            Deletebutton.Click();

        }
    }




}
