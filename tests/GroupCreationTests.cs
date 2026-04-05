using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace addressbook_tests_autoit
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void TestGroupCreation()
        {
            List<GroupData> oldGroups = app.Groups.GetGroupList();
            Console.WriteLine(oldGroups);
            GroupData newGroup = new GroupData()
            {
                Name = "t"
            };
            app.Groups.Add(newGroup);

            List<GroupData> newGroups = app.Groups.GetGroupList();
            Console.WriteLine(newGroups);
            oldGroups.Add(newGroup);
            Console.WriteLine(oldGroups);
            oldGroups.Sort();
            newGroups.Sort();

            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
