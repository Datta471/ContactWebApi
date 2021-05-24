using ContactWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ContactWebApi.Controllers
{
    public class UpdateController : ApiController
    {
        Contact contact;

        public UpdateController()
        {
            contact = new Contact();
        }

        //[Route("Update")]
        //[HttpPut]
        public IHttpActionResult UpdateContact(Contact con)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            contact.UpdateContact(con);
            return Ok();
        }
    }
}
