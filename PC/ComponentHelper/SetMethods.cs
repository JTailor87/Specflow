using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoIt;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace PC
{
    public static class SetMethods
    {        //Enter Test
        public static void EnterText(this IWebElement element, String value)
        {
            element.SendKeys(value);
        }
        //Click on to a Button, Checkbox, Option etc.
        public static void Clicks(this IWebElement element)
        {
            element.Click();
        }
        //Selecting a Drop Down Controls
        public static void SlectDropDown(this IWebElement element, String value)
        {
            new SelectElement(element).SelectByText(value);
        }
        public static void ImplicitlyWait(double Time)
        {
            Configuration.PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Time);
        }
        public static void PageLoadTimeout(double Time)
        {
            Configuration.PropertiesCollection.driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(Time);
        }
        //SwitchTo is Seleniums InBuilt Code and Driver is WebDriver 
        public static void SwitchtoAnotherWindow(String windowName)
        {
            int i = Configuration.PropertiesCollection.driver.WindowHandles.Count;
            if (windowName == "Child")
            {
                //switch to child window
                Configuration.PropertiesCollection.driver.SwitchTo().Window(Configuration.PropertiesCollection.driver.WindowHandles[1]);
            }
            else if (windowName == "Parent")
            {
                //switch to parent window
                Configuration.PropertiesCollection.driver.SwitchTo().Window(Configuration.PropertiesCollection.driver.WindowHandles[0]);
            }
            else if (windowName == "Last")
            {
                //switch to parent Last
                Configuration.PropertiesCollection.driver.SwitchTo().Window(Configuration.PropertiesCollection.driver.WindowHandles.Last());
            }
        }
        public static void SwitchtoParentWindow()
        {
            Configuration.PropertiesCollection.driver.SwitchTo().Window(Configuration.PropertiesCollection.driver.WindowHandles[0]);
        }
        public static void HowmanyIFrames()
        {
            List<IWebElement> frames = new List<IWebElement>(Configuration.PropertiesCollection.driver.FindElements(By.TagName("iframe")));
            Console.WriteLine("Number of Frames: " + frames.Count);
            for (int i = 0; i < frames.Count; i++)
            {
                Console.WriteLine("frame[" + i + "]: " + frames[i].GetAttribute("id").ToString());
            }
        }
        public static void ScrollById(String ID)
        {
            var element = Configuration.PropertiesCollection.driver.FindElement(By.Id(ID));
            Actions actions = new Actions(Configuration.PropertiesCollection.driver);
            actions.MoveToElement(element);
            actions.Perform();
        }
        public static void AutoITUpload(String windowsName, String filePath)
        {
           /* AutoItX3 autoIt = new AutoItX3();*/
            //Open - is depend upon your browser i.e. for firefox it is "File Upload"
            AutoItX.WinActivate(windowsName);
            Thread.Sleep(1000);
            AutoItX.Send(@filePath);
            Thread.Sleep(1000);
            AutoItX.Send("{ENTER}");
        }
        public static void Alert(String Action)
        {
            if (Action == "Accept")
            {
                try
                {
                    IAlert alert = Configuration.PropertiesCollection.driver.SwitchTo().Alert();
                    Console.WriteLine(alert.Text);
                    alert.Accept();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else if (Action == "Cancel")
            {
                try
                {
                    IAlert alert = Configuration.PropertiesCollection.driver.SwitchTo().Alert();
                    Console.WriteLine(alert.Text);
                    alert.Dismiss();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        [Obsolete]
        public static void WaitElementExists(double Time, string element, string valueOfElement)
        {
            var wait = new WebDriverWait(Configuration.PropertiesCollection.driver, TimeSpan.FromSeconds(Time));
            if (element == "Id")
            {
                wait.Until(ExpectedConditions.ElementExists((By.Id(valueOfElement))));
            }
            else if (element == "Xpath")
            {
                wait.Until(ExpectedConditions.ElementExists((By.XPath(valueOfElement))));
            }
            else if (element == "Name")
            {
                wait.Until(ExpectedConditions.ElementExists((By.Name(valueOfElement))));
            }
            else if (element == "LinkText")
            {
                wait.Until(ExpectedConditions.ElementExists((By.LinkText(valueOfElement))));
            }
        }
        [Obsolete]
        public static void WaitElementToBeClickable(double Time, string element, string valueOfElement)
        {
            var wait = new WebDriverWait(Configuration.PropertiesCollection.driver, TimeSpan.FromSeconds(Time));
            if (element == "Id")
            {
                wait.Until(ExpectedConditions.ElementToBeClickable((By.Id(valueOfElement))));
            }
            else if (element == "Xpath")
            {
                wait.Until(ExpectedConditions.ElementToBeClickable((By.XPath(valueOfElement))));
            }
            else if (element == "Name")
            {
                wait.Until(ExpectedConditions.ElementToBeClickable((By.Name(valueOfElement))));
            }
            else if (element == "LinkText")
            {
                wait.Until(ExpectedConditions.ElementToBeClickable((By.LinkText(valueOfElement))));
            }
        }

        [Obsolete]
        public static void WaitElementIsVisible(double Time, string element, string valueOfElement)
        {
            var wait = new WebDriverWait(Configuration.PropertiesCollection.driver, TimeSpan.FromSeconds(Time));
            if (element == "Id")
            {
                wait.Until(ExpectedConditions.ElementIsVisible((By.Id(valueOfElement))));
            }
            else if (element == "Xpath")
            {
                wait.Until(ExpectedConditions.ElementIsVisible((By.XPath(valueOfElement))));
            }
            else if (element == "Name")
            {
                wait.Until(ExpectedConditions.ElementIsVisible((By.Name(valueOfElement))));
            }
            else if (element == "LinkText")
            {
                wait.Until(ExpectedConditions.ElementIsVisible((By.LinkText(valueOfElement))));
            }
        }

        [Obsolete]
        public static void WaitElementToBeSelected(double Time, string element, string valueOfElement)
        {
            var wait = new WebDriverWait(Configuration.PropertiesCollection.driver, TimeSpan.FromSeconds(Time));
            if (element == "Id")
            {
                wait.Until(ExpectedConditions.ElementToBeSelected((By.Id(valueOfElement))));
            }
            else if (element == "Xpath")
            {
                wait.Until(ExpectedConditions.ElementToBeSelected((By.XPath(valueOfElement))));
            }
            else if (element == "Name")
            {
                wait.Until(ExpectedConditions.ElementToBeSelected((By.Name(valueOfElement))));
            }
            else if (element == "LinkText")
            {
                wait.Until(ExpectedConditions.ElementToBeSelected((By.LinkText(valueOfElement))));
            }
        }

        [Obsolete]
        public static void WaitTitleContains(double Time, string checkValue)
        {
            var wait = new WebDriverWait(Configuration.PropertiesCollection.driver, TimeSpan.FromSeconds(Time));
            wait.Until(ExpectedConditions.TitleContains(checkValue));
        }

        [Obsolete]
        public static void WaitAlertIsPresent(double Time)
        {
            var wait = new WebDriverWait(Configuration.PropertiesCollection.driver, TimeSpan.FromSeconds(Time));
            wait.Until(ExpectedConditions.AlertIsPresent());
        }

        [Obsolete]
        public static void WaitAlertState(double Time, bool State)
        {
            var wait = new WebDriverWait(Configuration.PropertiesCollection.driver, TimeSpan.FromSeconds(Time));
            wait.Until(ExpectedConditions.AlertState(State));
        }
    }
}
