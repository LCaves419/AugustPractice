using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    //can use [RoutePrefix("api/Contact")] above/on top of class
    //then above each action only need
    //[Route("")],[Route("{id:int")],[Route("{name}")]
    //[Route("api/Contact/{id:int}/lastname/{name}")] => allows for multiple parameters in URL
    public class ContactController : ApiController
    {

        Contacts[] contacts = new Contacts[]
        {
            new Contacts () { Id = 0, FirstName = "Peter", LastName = "Parker"},
            new Contacts () { Id = 1, FirstName = "Bruce", LastName = "Wayne"},
            new Contacts () { Id = 2, FirstName = "Bruce", LastName = "Banner"}

        };
        //URL api/contact calls Get method
        //api/contact calls Get method with a number
        //Will use the Get methods for the Http requests
        // GET: api/Contact
        [Route("api/Contact")]
        public IEnumerable<Contacts> Get()
        {
            return contacts;
        }

        //Get method with single contact
        // GET: api/Contact/5
        [Route("api/Contact/{id:int}")]
        public IHttpActionResult Get(int id)
        {
            //get me the first contact with matching id.
            Contacts contact = contacts.FirstOrDefault<Contacts>(c => c.Id == id);

            if (contact == null)
            {
                return NotFound();
            }
            return Ok(contact);
        }

        //if action name was FindContactByName
        //use [HttpGet] attribute to ensure is treated as get action
        [Route("api/Contact/{name}")]
        public IEnumerable<Contacts> GetContactsByName(string name)
        {
            Contacts[] contactArray = contacts.Where<Contacts>(c => c.FirstName.Contains(name)).ToArray<Contacts>();

            return contactArray;
        }

        //Adding a Contact
        // POST: api/Contact
        [Route("api/Contact")]
        public IEnumerable<Contacts> Post([FromBody]Contacts newContact)
        {
            List<Contacts> contactList = contacts.ToList<Contacts>();
            newContact.Id = contactList.Count;
            contactList.Add(newContact);
            contacts = contactList.ToArray();

            return contacts;
        }

        //Change a Contact
        // PUT: api/Contact/5
        [Route("api/Contact/{id:int}")]
        public IEnumerable<Contacts> Put(int id, [FromBody]Contacts changedContact)
        {
            Contacts contact = contacts.FirstOrDefault<Contacts>(c => c.Id == id);
            if (contact != null)
            {
                contact.FirstName = changedContact.FirstName;
                contact.LastName = changedContact.LastName;
            }
            return contacts;
        }


        //Delete a Contact
        // DELETE: api/Contact/5
        [Route("api/Contact/{id:int}")]
        public IEnumerable<Contacts> Delete(int id)
        {
            //get all contacts that do not match given id
            contacts = contacts.Where<Contacts>(c => c.Id != id).ToArray<Contacts>();
            return contacts;
        }
    }
}
