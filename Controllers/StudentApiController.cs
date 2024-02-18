using DBConWebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DBConWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentApiController : ControllerBase
    {
        private readonly MyDbContext context;

        public StudentApiController(MyDbContext context)
        {
            this.context = context;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            var customers = await context.Students.FromSqlRaw("EXEC GetStudents").ToListAsync();
            return Ok(customers);
        }

    }
}
