using System;
using Contact.BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Contact.Business.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetContactById_PassExisitingId_ReturnsOneContact()
        {
            var contact = ContactBusiness.GetContactById(1);
            Assert.IsNotNull(contact);
            Assert.AreEqual(contact.FirstName, "First1");
        }

        [TestMethod]
        public void GetContactById_PassNonExisitingId_ReturnsNull()
        {
            var contact = ContactBusiness.GetContactById(4);
            Assert.IsNull(contact);
        }

    }
}
