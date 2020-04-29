using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC.PageObjectsMethods
{
    class LeaveFormReqPageObjects
    {
        [Obsolete]
        public LeaveFormReqPageObjects()
        {
            PageFactory.InitElements(Configuration.PropertiesCollection.driver, this);
            //this.driver = _driver;
        }

        [FindsBy(How = How.Id, Using = "radiofield-1013-inputEl")]
        public IWebElement NewSubmission { get; set; }
        [FindsBy(How = How.Id, Using = "4A2BA84F3A2747D4BD7AA3425186BA51-btnIconEl")]
        public IWebElement Start { get; set; }

        [Obsolete]
        public NewLeaveFormPageObjects LeaveFormReq()
        {
            SetMethods.ImplicitlyWait(10);
            NewSubmission.Click();
            Start.Click();
            return new NewLeaveFormPageObjects();
        }
    }
}
