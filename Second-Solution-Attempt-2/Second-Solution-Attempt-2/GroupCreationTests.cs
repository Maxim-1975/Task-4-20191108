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
            OpenHomePage();
            Login(new AccountData("admin", "secret"));
            GoToGroupsPage();
            InitGroupCreation();
            GroupData group = new GroupData("test");
            group.Header = "test middlename";
            group.Footer = "test lastname";
            FillGroupForm(group);
            SubmitGroupCreation();
            GoToGroupsPage();
            Logout();
            OpenHomePage();
        }
    }
}
