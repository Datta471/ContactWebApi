using ContactWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ContactWebApi.Controllers
{
    public class ContactController : ApiController
    {
        List<Contact> Contacts;

        public ContactController()
        {
            Contacts = new List<Contact>()
            {
                new Contact { Id = 1, FirstName = "Sachin", LastName = "Tendulkar", Email = "Sachin.Ten@gmail.com", PhoneNumber = 9988776655, Status = true },
                new Contact { Id = 2, FirstName = "Rohit", LastName = "Sharma", Email = "Rohit.Sharma@gmail.com", PhoneNumber = 1122334455, Status = true },
                new Contact { Id = 3, FirstName = "Virat", LastName = "Kohli", Email = "Virat.Kohli@gmail.com", PhoneNumber = 1234567890, Status = false }
            };
        }

        public IHttpActionResult GetContact()
        {
            return Ok(Contacts);
        }

        public IHttpActionResult GetContact(int id)
        {
            return Ok(Contacts.Find(c => c.Id == id));
        }
    }
}
