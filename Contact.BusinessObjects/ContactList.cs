using System;
using System.Collections.Generic;

namespace Contact.BusinessObjects
{
    public static class ContactList
    {
        private static List<Contacts> allContacts = new List<Contacts>();
        public static List<Contacts> GetAllContacts()
        {
            if (allContacts.Count != 0)
            {
                return allContacts;
            }

            var contact = new Contacts();
            contact.Id = 1;
            contact.FirstName = "First1";
            contact.LastName = "Last1";
            contact.DateOfBirth = DateTime.Now.AddYears(-10);
            contact.Emails = new List<string>() {"1email1.com, 1email2.com" };
            contact.PhoneNumbers = new List<string>() { "8989","389238"};
            allContacts.Add(contact);

            contact = new Contacts();
            contact.Id = 2;
            contact.FirstName = "First2";
            contact.LastName = "Last2";
            contact.DateOfBirth = DateTime.Now.AddYears(-8);
            contact.Emails = new List<string>() { "2email1.com, 2email2.com" };
            contact.PhoneNumbers = new List<string>() { "8989", "389238" };
            allContacts.Add(contact);

            contact = new Contacts();
            contact.Id = 3;
            contact.FirstName = "First3";
            contact.LastName = "Last3";
            contact.DateOfBirth = DateTime.Now.AddYears(-6);
            contact.Emails = new List<string>() { "3email1.com, 3email2.com" };
            contact.PhoneNumbers = new List<string>() { "8989", "389238" };
            allContacts.Add(contact);

            return allContacts;
        }
    }
}
