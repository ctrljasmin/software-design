using lab4.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab4
{
    internal class Task_2
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidMagazineCreation()
        {
            var magazine = new Magazine()
            {
                Title = "Invalid",
                Author = "Jane Doe",
                IssueNumber = -1
            };
            magazine.CheckValidity();
        }
    }
}
