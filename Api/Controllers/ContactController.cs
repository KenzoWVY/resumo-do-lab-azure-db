using Microsoft.AspNetCore.Mvc;
using Api.Context;
using Api.Entities;

namespace TestApi.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly AppointmentsContext _context;

        public ContactController(AppointmentsContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(Contact contact)
        {
            _context.Add(contact);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = contact.Id }, contact);
        }

        [HttpPost("CreateMany")]
        public IActionResult CreateMany(List<Contact> contacts)
        {
            _context.AddRange(contacts);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = contacts.First().Id }, contacts);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var contact = _context.Contacts.Find(id);

            if (contact == null)
                return NotFound();

            return Ok(contact);
        }

        [HttpGet("GetByName/{name}")]
        public IActionResult GetByName(string name)
        {
            return Ok(_context.Contacts.Where(x => x.Name.Contains(name)));
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_context.Contacts.ToList());
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Contact contact)
        {
            var contactDb = _context.Contacts.Find(id);

            if (contactDb == null)
                return NotFound();

            contactDb.Name = contact.Name;
            contactDb.PhoneNumber = contact.PhoneNumber;
            contactDb.Active = contact.Active;

            _context.Contacts.Update(contactDb);
            _context.SaveChanges();

            return Ok(contactDb);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var contactDb = _context.Contacts.Find(id);

            if (contactDb == null)
                return NotFound();

            _context.Contacts.Remove(contactDb);
            _context.SaveChanges();

            return NoContent();
        }
    }
}