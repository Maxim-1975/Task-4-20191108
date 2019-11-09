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
            OpenHomePage();
            Login(new AccountData("admin", "secret"));
            GoToAccountPage();
            InitContactData icd = new InitContactData();
            icd.Firstname = "Maxim";
            icd.Middlename = "Vladimirovitch";
            icd.Lastename = "Kolpakov";
            InitContactCreation(icd);
            SubmitContactCreation();
            ReturnHomePage();
            Logout();
        }
    }
}
