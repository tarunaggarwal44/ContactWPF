using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ContactUI
{
    public class ContactService
    {
        private HttpClient client = new HttpClient();
        private string contactApi = "api/contact/";
        public ContactService()
        {
            client.BaseAddress = new Uri("https://localhost:44373/");
        }


        public async Task<List<Contact>> GetContacts()
        {
            HttpResponseMessage response = await client.GetAsync(contactApi);
            if (response.IsSuccessStatusCode)
            {
                var contacts = await response.Content.ReadAsAsync<List<Contact>>();
                return contacts;
            }
            return new List<Contact>();
        }
    }
}
