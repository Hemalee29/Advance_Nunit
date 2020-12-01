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
    internal class Certificate
    {
        public Certificate()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on Education tab
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")]
        private IWebElement ClickCertificatetab { get; set; }

        //click addnew button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div")]
        private IWebElement Addnewbutton { get; set; }

        //Enter Certificate
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input")]
        private IWebElement EnterCertificate { get; set; }

        //Enter Certified from
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input")]
        private IWebElement CertificateFrom { get; set; }

        //Select year
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select")]
        private IWebElement Selectyear { get; set; }

        //Select year value
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[12]")]
        private IWebElement Selectyearvalue { get; set; }

        //Click add button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]")]
        private IWebElement add { get; set; }

        //Edit Certificate

        //Click on Edit button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i")]
        private IWebElement Editbutton { get; set; }

        //Edit Certificate
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[1]/input")]
        private IWebElement EditCertificate { get; set; }

        //Edit Certificate From
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[2]/input")]
        private IWebElement EditCertificateFrom { get; set; }

        //Edit year
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[3]/select")]
        private IWebElement Edityear { get; set; }

        //Edit year value
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[3]/select/option[6]")]
        private IWebElement Edityearvalue { get; set; }

        //Update button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[1]")]
        private IWebElement Updatebutton { get; set; }

        //Delete button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i")]
        private IWebElement Deletebutton { get; set; }
        internal void Certificate_Add()
        {
            Thread.Sleep(2000);
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Certificate");
            ClickCertificatetab.Click();
            Addnewbutton.Click();
            EnterCertificate.Click();
            EnterCertificate.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Certificate"));
            CertificateFrom.Click();
            CertificateFrom.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "CertificateFrom"));
            Selectyear.Click();
            Selectyearvalue.Click();
            add.Click();



        }

        internal void Certificate_Edit()
        {
            Thread.Sleep(2000);
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Certificate");
            ClickCertificatetab.Click();
            Editbutton.Click();
            EditCertificate.Click();
            EditCertificate.Clear();
            EditCertificate.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EditCertificate"));
            EditCertificateFrom.Click();
            EditCertificateFrom.Clear();
            EditCertificateFrom.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EditCertificateFrom"));
            Edityear.Click();
            Edityearvalue.Click();
            Updatebutton.Click();
        }

        internal void Certificate_Delete()
        {
            Thread.Sleep(2000);
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Certificate");
            ClickCertificatetab.Click();
            Deletebutton.Click();
        }

    }
}
