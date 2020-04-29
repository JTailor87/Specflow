using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC.PageObjectsMethods
{
    class LandingPageObjects
    {
        //private IWebDriver driver;        
        [Obsolete]
        public LandingPageObjects()
        {
            PageFactory.InitElements(Configuration.PropertiesCollection.driver, this);
            //this.driver = _driver;
        }

        [FindsBy(How = How.XPath, Using = "//input[@id='radiofield-1013-inputEl']")]
        public IWebElement Originator { get; set; }
        [FindsBy(How = How.Id, Using = "EADD6FB760044669B87D8D9D6C0AF4B1-btnIconEl")]
        public IWebElement Next1 { get; set; }

        [Obsolete]
        public LoginPageObjects LandingPage()
        {
            SetMethods.ImplicitlyWait(10);
            Originator.Clicks();
            Next1.Clicks();
            return new LoginPageObjects();

            /*SetMethods.Click(Originator);
            SetMethods.Click(Next1);
            return new LoginPageObjects();*/

            /*Originator.Click();
            Next1.Click();
            return new LoginPageObjects();*/
        }
    }
}
