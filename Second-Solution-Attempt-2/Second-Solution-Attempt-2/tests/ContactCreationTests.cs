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
            app.navigator.OpenHomePage();
            app.auth.Login(new AccountData("admin", "secret"));
            app.navigator.GoToAccountPage();
            InitContactData icd = new InitContactData();
            icd.Firstname = "Maxim";
            icd.Middlename = "Vladimirovitch";
            icd.Lastename = "Kolpakov";
            app.contact.InitContactCreation(icd);
            app.contact.SubmitContactCreation();
            app.navigator.ReturnHomePage();
            app.auth.Logout();
        }
    }
}
