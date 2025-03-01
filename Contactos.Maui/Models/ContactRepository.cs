using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contactos.Maui.Models
{
    public static class ContactRepository
    {
        public static List<Contact> _contacts = new List<Contact>()       
        {
        	new Contact { Name= "Alex", Email="alex@mail.com"},
            new Contact { Name= "Iza", Email="iza@mail.com"},
            new Contact { Name = "Cris", Email = "cris@mail.com" },
        };

        public static List<Contact> GetContacts() => _contacts;

        public static Contact GetContactById(int contactId)
        {
            return _contacts.FirstOrDefault(x => x.ContactId == contactId);
        }
    }
}
