using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NapsApi.Models;



namespace NapsApi.Controllers
{
    [Route("api/[controller]")]
    public class DoctorsController : ControllerBase
    {
        private readonly AppDbContext db;

        public DoctorsController(AppDbContext appDbContext)
        {
            db = appDbContext;
        }

        [Route("Insert")]
        [HttpPost]
        public IActionResult Insert([FromBody] Doctor form)
        {
           
            var doctor = new Doctor
            {
                Name= form.Name,
                Specialisation = form.Specialisation
               
            };
            db.Add(doctor);
            db.SaveChanges();

            return Ok(doctor);
        }
    }
}
