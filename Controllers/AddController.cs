using ContactWebApi.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ContactWebApi.Controllers
{
    public class AddController : ApiController
    {
        Contact contact;

        public AddController()
        {
            contact = new Contact();
        }

        //[Route("Add")]
        //[HttpPost]
        public IHttpActionResult AddContact(Contact con)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            contact.AddContact(con);
            return Ok();
        }
    }
}
