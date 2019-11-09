using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests:TestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            navigationHelper.OpenHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            navigationHelper.GoToAccountPage();
            InitContactData icd = new InitContactData();
            icd.Firstname = "Maxim";
            icd.Middlename = "Vladimirovitch";
            icd.Lastename = "Kolpakov";
            contactHelper.InitContactCreation(icd);
            contactHelper.SubmitContactCreation();
            navigationHelper.ReturnHomePage();
            loginHelper.Logout();
        }
    }
}
