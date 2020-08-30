using Contact.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ContactsApi.Controllers
{
    public class ContactController : ApiController
    {
        // GET: api/Contact
        public IEnumerable<Contact.BusinessObjects.Contacts> Get()
        {
            return ContactBusiness.GetAllContacts();
        }

        // GET: api/Contact/5
        public Contact.BusinessObjects.Contacts Get(int id)
        {
            var contact = ContactBusiness.GetContactById(id);
            return contact;
        }

        // POST: api/Contact
        public bool Post([FromBody] Contact.BusinessObjects.Contacts contact)
        {
            return ContactBusiness.AddContact(contact);
        }

        // PUT: api/Contact/5
        public bool Put(int id, [FromBody] Contact.BusinessObjects.Contacts contact)
        {
            return ContactBusiness.EditContact(id, contact);
        }

        // DELETE: api/Contact/5
        public void Delete(int id)
        {
        }
    }
}
