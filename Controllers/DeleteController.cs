using ContactWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ContactWebApi.Controllers
{
    public class DeleteController : ApiController
    {
        Contact contact;

        public DeleteController()
        {
            contact = new Contact();
        }

        //[Route("Delete")]
        [HttpDelete]
        public IHttpActionResult DeleteContact(Guid id)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            contact.DeleteContact(id);
            return Ok();
        }
    }
}
