using desafio_criptografia.Entities;
using desafio_criptografia.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using desafio_criptografia.DTO;
using desafio_criptografia.Service;


namespace desafio_criptografia.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly DesafioContext _context;

        public UserController(DesafioContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Add(User obj)
        {
            _context.Users.Add(obj);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ById), new { id = obj.Id }, obj);
        }

        [HttpGet("{id}")]
        public IActionResult ById(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }

            user.UserDocument = Hashing.ToSHA512(user.UserDocument);
            user.CreditCardToken = Hashing.ToSHA512(user.CreditCardToken);

            return Ok(user);
        }

        [HttpGet]
        public IActionResult All()
        {
            var users = _context.Users.ToList();

            var encryptedUsers = users.Select(user => new User
            {
                Id = user.Id,
                UserDocument = Hashing.ToSHA512(user.UserDocument),
                CreditCardToken = Hashing.ToSHA512(user.CreditCardToken),
                Value = user.Value

            });
            return Ok(encryptedUsers);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UserDTO obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = _context.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }

            user.UserDocument = obj.UserDocument;
            user.CreditCardToken = obj.CreditCardToken;
            user.Value = obj.Value;

            _context.Update(user);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
