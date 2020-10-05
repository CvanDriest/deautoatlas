using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DeAutoAtlas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeAutoAtlasUserController : ControllerBase
    {

        private readonly ILogger<DeAutoAtlasUserController> _logger;

        public DeAutoAtlasUserController(ILogger<DeAutoAtlasUserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public JsonResult GetAllUsers()
        {
            Customer user = new Customer
            {
                Achternaam = "van Driest",
                Voornaam = "Richard",
                ID = 1,
                Telefoon = "",
                Mobiel = "0612345678",
                Email = "richard.vandriest@outlook.com",
                Adres = new Adres
                {
                    Straat = "Aeolusweg",
                    Huisnummer = "67",
                    Postcode = "3731 XC",
                    Woonplaats = "De Bilt"
                }
            };

            var result = new JsonResult(user);
            result.StatusCode = 200;
            return result;
        }

        [HttpGet("{id}")]
        public JsonResult GetUserByID (int id)
        {
            User user = new User
            {
                Achternaam = "van Driest",
                Voornaam = "Richard",
                ID = id,
                Telefoon = "",
                Mobiel = "0612345678",
                Email = "richard.vandriest@outlook.com",
                Adres = new Adres
                {
                    Straat = "Aeolusweg",
                    Huisnummer = "67",
                    Postcode = "3731 XC",
                    Woonplaats = "De Bilt"
                }
            };

            var result = new JsonResult(user);
            result.StatusCode = 200;
            return result;

        }

        [HttpDelete]
        public JsonResult DeleteUserByID (int id)
        {
            return null;
        }

        [HttpPut]
        public JsonResult UpdateUser(User user)
        {
            JsonResult result = new JsonResult(user);
            result.StatusCode = 200;
            return result;
        }

        [HttpPost]
        public JsonResult PostUser (User user)
        {
            JsonResult result = new JsonResult(user);
            result.StatusCode = 200;
            return result;
        }
    }
}
