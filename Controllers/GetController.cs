using ContactWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ContactWebApi.Controllers
{
    public class GetController : ApiController
    {
        Contact contact;
        List<Contact> Contacts;
        public GetController()
        {
            contact = new Contact();
        }

        public IHttpActionResult GetContact()
        {
            Contacts = contact.GetContacts();
            return Ok(Contacts);
        }

        public IHttpActionResult GetContact(Guid id)
        {
            Contacts = contact.GetContacts();
            return Ok(Contacts.Find(c => c.Id == id));
        }
    }
}
