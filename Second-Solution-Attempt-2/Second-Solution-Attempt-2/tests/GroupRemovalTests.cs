using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests:TestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            app.navigator.OpenHomePage();
            app.auth.Login(new AccountData("admin", "secret"));
            app.navigator.GoToGroupsPage();
            app.group.SelectGroup(1);
            app.group.RemoveGroup();
            app.navigator.GoToGroupsPage();
            app.navigator.ReturnHomePage();
            app.auth.Logout();
        }       
    }
}
