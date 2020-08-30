using Contact.BusinessObjects;
using System.Collections.Generic;
using System.Linq;

namespace Contact.BusinessLayer
{
    public static class ContactBusiness
    {
        public static List<Contacts> GetAllContacts()
        {
            var allContacts = ContactList.GetAllContacts();
            return allContacts;
        }

        public static Contacts GetContactById(int id)
        {
            var allContacts = ContactList.GetAllContacts();
            var contact = allContacts.Where(a => a.Id == id).SingleOrDefault();
            return contact;
        }

        public static bool AddContact(Contacts contacts)
        {
            var allContacts = ContactList.GetAllContacts();
            allContacts.Add(contacts);
            return true;
        }

        public static bool EditContact(int id, Contacts contacts)
        {
            var allContacts = ContactList.GetAllContacts();
            var contact = allContacts.Where(a => a.Id == id).SingleOrDefault();

            MapEditContactDetails(contacts, contact);

            return true;
        }

        private static void MapEditContactDetails(Contacts contacts, Contacts contact)
        {
            contact.FirstName = contacts.FirstName;
            contact.LastName = contacts.LastName;
            contact.DateOfBirth = contacts.DateOfBirth;
            contact.Emails = contacts.Emails;
            contact.PhoneNumbers = contacts.PhoneNumbers;
        }
    }
}
