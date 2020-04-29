using OpenQA.Selenium.Chrome;
using PC.PageObjectsMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace PC
{
    [Binding]
    public class PClaimsStepDef
    {
        [Given(@"Open URL")]
        public void GivenOpenURL(Table table)
        {
            Configuration.Util details = table.CreateInstance<Configuration.Util>();
            //Headless chrome and Supress the chrome driver logs
            var chromeOptions = new ChromeOptions();
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            service.SuppressInitialDiagnosticInformation = true;
            chromeOptions.AddArguments("headless");
            Configuration.PropertiesCollection.driver = new ChromeDriver(service, chromeOptions);
            /*Configuration.PropertiesCollection.driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), chromeOptions);*/
            /*Configuration.PropertiesCollection.driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));*/
            /*Configuration.PropertiesCollection.driver = new ChromeDriver();*/
            Configuration.PropertiesCollection.driver.Navigate().GoToUrl(details.URL);
            SetMethods.PageLoadTimeout(20);
            Configuration.PropertiesCollection.driver.Manage().Window.Maximize();
        }

        [Given(@"Select originator and click next")]
        [Obsolete]
        public void GivenSelectOriginatorAndClickNext()
        {
            LandingPageObjects landingPage = new LandingPageObjects();
            landingPage.LandingPage();
        }

        [Then(@"Provide credential and click logon")]
        [Obsolete]
        public void ThenProvideCredentialAndClickLogon()
        {
            LoginPageObjects LoginPage = new LoginPageObjects();
            LoginPage.LoginPage1("HMSTIL_User", "HMSTIL_User");
        }

        [Then(@"Provide logged in name and email address and click next")]
        [Obsolete]
        public void ThenProvideLoggedInNameAndEmailAddressAndClickNext()
        {
            LoginPageObjects LoginPage = new LoginPageObjects();
            LoginPage.LoginPage2("Jigar", "tailorj@aforbes.com");
        }

        [Then(@"Slect new submission and click start")]
        [Obsolete]
        public void ThenSlectNewSubmissionAndClickStart()
        {
            LeaveFormReqPageObjects leaveFormReq = new LeaveFormReqPageObjects();
            leaveFormReq.LeaveFormReq();
        }

        [Then(@"Provide all client details")]
        [Obsolete]
        public void ThenProvideAllClientDetails()
        {
            NewLeaveFormPageObjects newLeaveForm = new NewLeaveFormPageObjects();
            newLeaveForm.ClientDetails();
        }

        [Then(@"Provide all individual details")]
        [Obsolete]
        public void ThenProvideAllIndividualDetails()
        {
            NewLeaveFormPageObjects newLeaveForm = new NewLeaveFormPageObjects();
            newLeaveForm.IndividualDetails();
        }

        [Then(@"Provide all claims details")]
        [Obsolete]
        public void ThenProvideAllClaimsDetails()
        {
            NewLeaveFormPageObjects newLeaveForm = new NewLeaveFormPageObjects();
            newLeaveForm.ClaimDetails();
        }

        /*[Then(@"Close the browser")]
        public void ThenCloseTheBrowser()
        {
            ScenarioContext.Current.Pending();
        }*/

        [Then(@"Close the browser")]
        public void ThenCloseTheBrowser()
        {
            Thread.Sleep(2000);
            Configuration.PropertiesCollection.driver.Quit();
        }

    }
}
