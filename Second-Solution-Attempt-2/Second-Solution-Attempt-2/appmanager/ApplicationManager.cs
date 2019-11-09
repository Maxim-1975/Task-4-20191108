using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class ApplicationManager
    {
        protected LoginHelper loginHelper;
        protected NavigationHelper navigationHelper;
        protected ContactHelper contactHelper;
        protected GroupHelper groupHelper;

        protected IWebDriver driver = new FirefoxDriver();        
        protected string baseURL = "http://localhost/addressbook/";

        public ApplicationManager()
        {
            loginHelper = new LoginHelper(driver);
            navigationHelper = new NavigationHelper(driver, baseURL);
            contactHelper = new ContactHelper(driver);
            groupHelper = new GroupHelper(driver);
        }
        //-----properties
        public LoginHelper auth { get { return loginHelper; } }
        public NavigationHelper navigator { get { return navigationHelper; } }
        public ContactHelper contact { get { return contactHelper; } }
        public GroupHelper group { get { return groupHelper; } }
        //------Method Stop
        public void Stop()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }
    }
}
