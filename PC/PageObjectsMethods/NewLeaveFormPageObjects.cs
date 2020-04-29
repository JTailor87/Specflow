using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PC.PageObjectsMethods
{
    class NewLeaveFormPageObjects
    {
        [Obsolete]
        public NewLeaveFormPageObjects()
        {
            PageFactory.InitElements(Configuration.PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "ext-gen1555")]
        public IWebElement DropDownArrow1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//li[@class='x-boundlist-item x-boundlist-item-over']")]
        public IWebElement ClientDetail1 { get; set; }
        [FindsBy(How = How.Id, Using = "ext-gen1559")]
        public IWebElement DropDownArrow2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//li[@class='x-boundlist-item x-boundlist-item-over']")]
        public IWebElement ClientDetail2 { get; set; }
        [FindsBy(How = How.Id, Using = "ext-gen1561")]
        public IWebElement DropDownArrow3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//li[@class='x-boundlist-item x-boundlist-item-over']")]
        public IWebElement ClientDetail3 { get; set; }
        [FindsBy(How = How.Id, Using = "ext-gen1564")]
        public IWebElement DropDownArrow4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@id='boundlist-1083-listEl']")]
        public IWebElement ClientDetail4 { get; set; }
        [FindsBy(How = How.Id, Using = "861E025F1EF14F8AA8864974298F0915-btnIconEl")]
        public IWebElement Find { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@id='tblResults_Name_3']")]
        public IWebElement JHT { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[@id='EFAC60A5CE1C45448DBB7BB55296ABF6-btnIconEl']")]
        public IWebElement OK { get; set; }
        [FindsBy(How = How.Id, Using = "E64DB1090A6A4CFB8A4EB23B3D006D80-inputEl")]
        public IWebElement PersalNum { get; set; }
        [FindsBy(How = How.Id, Using = "ext-gen1570")]
        public IWebElement TitleArrow { get; set; }
        [FindsBy(How = How.XPath, Using = "//li[@class='x-boundlist-item x-boundlist-item-over']")]
        public IWebElement Mr { get; set; }
        [FindsBy(How = How.Id, Using = "262D9995D69E47D0BCFEF51A2789595D-inputEl")]
        public IWebElement Surname { get; set; }
        [FindsBy(How = How.Id, Using = "FEE169D4BBE94A0793EE34BC47B795CD-inputEl")]
        public IWebElement Initial { get; set; }
        [FindsBy(How = How.Id, Using = "AB76F837AA7F4BF6919AF762E228144B-inputEl")]
        public IWebElement IDNum { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@id='wrapper']")]
        public IWebElement OutSide { get; set; }
        [FindsBy(How = How.Id, Using = "DD4B12F923884202850FE62590BDFD85-inputEl")]
        public IWebElement Age { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@id='ext-gen1578']")]
        public IWebElement GenderArrow { get; set; }
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[9]/div[1]/ul[1]/li[2]")]
        public IWebElement Male { get; set; }
        [FindsBy(How = How.Id, Using = "E329170CE5134AF7A2D26A5DE50E01A5-inputEl")]
        public IWebElement JTTitle { get; set; }
        [FindsBy(How = How.Id, Using = "BE8A34C836F641C6A53C2CC7EF4F1312-inputEl")]
        public IWebElement JobTitleDes { get; set; }
        [FindsBy(How = How.Id, Using = "D6D63D8E3AA449569D45D855DDD6DBD4-inputEl")]
        public IWebElement Qualification { get; set; }
        [FindsBy(How = How.Id, Using = "0A78C27BAEF540B597EB206901F37B89-inputEl")]
        public IWebElement DateAppointed { get; set; }
        [FindsBy(How = How.Id, Using = "968258A5FB1B4005B938DE9799F60A9D-inputEl")]
        public IWebElement Salary { get; set; }
        [FindsBy(How = How.Id, Using = "ext-gen1586")]
        public IWebElement SalaryLevelArrow { get; set; }
        [FindsBy(How = How.Id, Using = "41B10331AE234688A7CF5BE6C29C44BE-inputEl")]
        public IWebElement SalaryLevelvalue { get; set; }
        [FindsBy(How = How.Id, Using = "40FFEC223D9F490AB114A3CFE7F3C4C7-inputEl")]
        public IWebElement UniqueCaseNo { get; set; }
        [FindsBy(How = How.Id, Using = "F0C23874D5A646A5BF39483F5FF5E24D-inputEl")]
        public IWebElement CaseType { get; set; }
        [FindsBy(How = How.Id, Using = "48567B3EFA4048199FD46EF820E87755-inputEl")]
        public IWebElement CaseOrigin { get; set; }
        [FindsBy(How = How.Id, Using = "BF0B4BA3FBE14FD9AC2BC7F14E2A7B8E-inputEl")]
        public IWebElement LeaveCycle { get; set; }
        [FindsBy(How = How.Id, Using = "BD70FA11643543889CC9560789901593-inputEl")]
        public IWebElement IncidentStartDate { get; set; }
        [FindsBy(How = How.Id, Using = "147C859E1E7A4DF9907497CB367409B8-inputEl")]
        public IWebElement IncidentEndDate { get; set; }
        [FindsBy(How = How.Id, Using = "4A680D94558440B2B405368F09B8E39C-inputEl")]
        public IWebElement EmployeeSignedDate { get; set; }
        [FindsBy(How = How.XPath, Using = "//td[@id='DB845C20E83F4D57985A6AD4B9D66055-browseButtonWrap']")]
        public IWebElement MedCertificateBrowse { get; set; }
        [FindsBy(How = How.Id, Using = "F4EBEFB607874311986E6CF2DB8B6F96-btnIconEl")]
        public IWebElement MedCertificateUpload { get; set; }
        [FindsBy(How = How.Id, Using = "2C2355C99D0D4D03830B3C4BEEB97B3A-inputEl")]
        public IWebElement Disclaimer { get; set; }
        [FindsBy(How = How.Id, Using = "459A656D374942AE9D46B1E7C008D624-inputEl")]
        public IWebElement Status { get; set; }
        [FindsBy(How = How.Id, Using = "4224A04589F24B32A4DDCDA6B1A1EF19-btnIconEl")]
        public IWebElement Update { get; set; }
        [FindsBy(How = How.Id, Using = "radiofield-1015-inputEl")]
        public IWebElement Search { get; set; }
        [FindsBy(How = How.Id, Using = "4A2BA84F3A2747D4BD7AA3425186BA51-btnIconEl")]
        public IWebElement Start { get; set; }
        [FindsBy(How = How.Id, Using = "DACF9C91F86D44A8AF12E7BBE65C3C5E-btnIconEl")]
        public IWebElement Search_Refresh { get; set; }

        [Obsolete]
        public void ClientDetails()
        {
            /*Client details*/
            //Thread.Sleep(3000);
            //SwitchTo is Seleniums InBuilt Code and Driver is WebDriver
            SetMethods.SwitchtoAnotherWindow("Child");

            SetMethods.ImplicitlyWait(10);
            SetMethods.PageLoadTimeout(20);
            Thread.Sleep(5000);

            DropDownArrow1.Clicks();
            Thread.Sleep(500);
            ClientDetail1.Clicks();
            Thread.Sleep(500);
            DropDownArrow2.Clicks();
            Thread.Sleep(500);
            ClientDetail2.Clicks();
            Thread.Sleep(500);
            DropDownArrow3.Clicks();
            Thread.Sleep(500);
            ClientDetail3.Clicks();
            Thread.Sleep(500);
            DropDownArrow4.Clicks();
            Thread.Sleep(1000);
            ClientDetail4.Clicks();
            Thread.Sleep(500);
            Find.Clicks();
            /*DropDownArrow1.Click();
            Thread.Sleep(500);
            ClientDetail1.Click();
            Thread.Sleep(500);
            DropDownArrow2.Click();
            Thread.Sleep(500);
            ClientDetail2.Click();
            Thread.Sleep(500);
            DropDownArrow3.Click();
            Thread.Sleep(500);
            ClientDetail3.Click();
            Thread.Sleep(500);
            DropDownArrow4.Click();
            Thread.Sleep(1000);
            ClientDetail4.Click();
            Thread.Sleep(500);
            Find.Click();*/

            //Look at the output for i-Frames count
            SetMethods.HowmanyIFrames();

            Configuration.PropertiesCollection.driver.SwitchTo().Frame(1);
            Thread.Sleep(500);
            JHT.Clicks();
            Thread.Sleep(500);
            OK.Clicks();

            //Switch back to your parent frame
            Configuration.PropertiesCollection.driver.SwitchTo().DefaultContent();
            //PropertiesCollection.driver.SwitchTo().ParentFrame();
        }
        [Obsolete]
        public void IndividualDetails()
        {
            /*Individual details*/
            SetMethods.ImplicitlyWait(10);
            PersalNum.EnterText("061375468");
            TitleArrow.Clicks();
            Thread.Sleep(500);
            Mr.Clicks();
            Surname.EnterText("Tailor");
            Initial.EnterText("D");
            IDNum.EnterText("8710039822081");
            OutSide.Clicks();
            Thread.Sleep(1500);
            Age.EnterText("32");
            Thread.Sleep(1000);
            GenderArrow.Clicks();
            Thread.Sleep(500);
            Male.Clicks();

            /*PersalNum.SendKeys("061375468");
            TitleArrow.Click();
            Thread.Sleep(500);
            Mr.Click();
            Surname.SendKeys("Tailor");
            Initial.SendKeys("JH");
            IDNum.SendKeys("8710039822081");
            OutSide.Click();
            Age.SendKeys("32");
            GenderArrow.Click();
            Thread.Sleep(500);
            Male.Click();*/
        }
        [Obsolete]
        public void ClaimDetails()
        {
            SetMethods.ImplicitlyWait(10);
            JTTitle.EnterText("ABCDEFGHIJKLMNOP");
            JobTitleDes.EnterText("Test Automation Engineer");
            Qualification.EnterText("ISTQB");
            DateAppointed.EnterText("03-06-2019");
            OutSide.Clicks();
            Salary.EnterText("123456");
            //SalaryLevelArrow.Clicks();
            SalaryLevelvalue.EnterText("5");
            OutSide.Clicks();
            /*//Look at the output for i-Frames count
            SetMethods.HowmanyIFrames();

            PropertiesCollection.driver.SwitchTo().Frame(0);*/
            //SalaryLevelvalue.Clicks();

            /*//Switch back to your parent frame
            PropertiesCollection.driver.SwitchTo().DefaultContent();
            //PropertiesCollection.driver.SwitchTo().ParentFrame();*/

            UniqueCaseNo.EnterText("AB015OH03");
            CaseType.EnterText("Short Period");
            OutSide.Clicks();
            CaseOrigin.EnterText("New");
            OutSide.Clicks();
            LeaveCycle.EnterText("2019-2021");
            OutSide.Clicks();
            IncidentStartDate.EnterText("11-03-2020");
            OutSide.Clicks();
            IncidentEndDate.EnterText("15-03-2020");
            OutSide.Clicks();

            //Scrolling down the page
            SetMethods.ScrollById("DD22D8EF4EF14AA1ACC97772D3D130D7-bodyEl");

            EmployeeSignedDate.EnterText("16-03-2020");
            MedCertificateBrowse.Clicks();
            Thread.Sleep(1500);

            //AutoIT
            SetMethods.AutoITUpload("Open", "C:\\Users\\TailorJ\\Downloads\\Fake ID.pdf");
            Thread.Sleep(1000);
            MedCertificateUpload.Clicks();
            Thread.Sleep(1000);

            //Alert handeling - enter either Accept or Cancel
            SetMethods.Alert("Accept");

            Thread.Sleep(15000);
            /*SetMethods.WaitAlertState(60, true);*/

            //Alert handeling - enter either Accept or Cancel
            /*SetMethods.Alert("Accept");*/

            //Need to write a method for Action class in SetMethods
            Actions builder = new Actions(Configuration.PropertiesCollection.driver);
            builder.SendKeys(Keys.Enter);

            Disclaimer.Clicks();
            Status.EnterText("Save as Draft");
            Update.Clicks();
            Thread.Sleep(1000);
            SetMethods.SwitchtoAnotherWindow("Parent");
            //SetMethods.SwitchtoParentWindow();
            Thread.Sleep(1000);
            Search.Clicks();
            Start.Clicks();
            Thread.Sleep(2000);
            Search_Refresh.Clicks();
            SetMethods.ScrollById("frmHMSTILsubmissionListing-lblFormCode");
        }
    }
}
