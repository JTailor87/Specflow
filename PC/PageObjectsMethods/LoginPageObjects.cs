using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PC.PageObjectsMethods
{
    class LoginPageObjects
    {
        [Obsolete]
        public LoginPageObjects()
        {
            PageFactory.InitElements(Configuration.PropertiesCollection.driver, this);
            //this.driver = _driver;
        }
        [FindsBy(How = How.Name, Using = "txtUserName")]
        public IWebElement Username { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@id='CB7B6DBD36A9448D8C722E40B5347F1C-inputEl']")]
        public IWebElement Password { get; set; }
        [FindsBy(How = How.Id, Using = "574C19108D0F49999209C0A9C8B0B7EF-btnIconEl")]
        public IWebElement Logon { get; set; }
        [FindsBy(How = How.Name, Using = "txtName")]
        public IWebElement LoggedInName { get; set; }
        [FindsBy(How = How.Id, Using = "2559377FF1C84BAE9CC3B4FD4F178FD2-inputEl")]
        public IWebElement Email { get; set; }
        [FindsBy(How = How.Id, Using = "D992EED8BE894F159502046FFC73FB52-btnIconEl")]
        public IWebElement Next2 { get; set; }

        public void LoginPage1(String username, String password)
        {
            SetMethods.ImplicitlyWait(10);
            Username.EnterText(username);
            Password.EnterText(password);
            Logon.Clicks();
            Thread.Sleep(1000);

            /*Username.SendKeys(username);
            Password.SendKeys(password);
            Logon.Click();
            Thread.Sleep(1000);
            LoggedInName.SendKeys(loggedInName);
            Email.SendKeys(email);
            Next2.Click();
            return new LeaveFormReqPageObjects();*/
        }

        [Obsolete]
        public NewLeaveFormPageObjects LoginPage2(String loggedInName, String email)
        {
            SetMethods.ImplicitlyWait(10);
            LoggedInName.EnterText(loggedInName);
            Email.EnterText(email);
            Next2.Clicks();
            //Thread.Sleep(5000);
            return new NewLeaveFormPageObjects();
        }
    }
}
