using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests:TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            app.navigator.OpenHomePage();
            app.auth.Login(new AccountData("admin", "secret"));
            app.navigator.GoToGroupsPage();
            app.group.InitGroupCreation();
            GroupData group = new GroupData("test");
            group.Header = "test middlename";
            group.Footer = "test lastname";
            app.group.FillGroupForm(group);
            app.group.SubmitGroupCreation();
            app.navigator.GoToGroupsPage();
            app.auth.Logout();
            app.navigator.OpenHomePage();
        }
    }
}
