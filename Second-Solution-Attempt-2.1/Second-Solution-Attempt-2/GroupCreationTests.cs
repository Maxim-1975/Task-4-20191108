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
            navigationHelper.OpenHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            navigationHelper.GoToGroupsPage();
            groupHelper.InitGroupCreation();
            GroupData group = new GroupData("test");
            group.Header = "test middlename";
            group.Footer = "test lastname";
            groupHelper.FillGroupForm(group);
            groupHelper.SubmitGroupCreation();
            navigationHelper.GoToGroupsPage();
            loginHelper.Logout();
            navigationHelper.OpenHomePage();
        }
    }
}
