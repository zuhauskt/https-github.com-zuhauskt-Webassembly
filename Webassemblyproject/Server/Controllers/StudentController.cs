using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webassemblyproject.Shared;
using Webassemblyproject.Server.Data;

namespace Webassemblyproject.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public StudentController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        // GET: api/student
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            return await _appDbContext.Students.ToListAsync();
        }

        // GET: api/student/marks/80
        [HttpGet("marks/{min}")]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudentsWithMarksGreaterThan(int min)
        {
            var students = await _appDbContext.Students.Where(s => s.Mark > min).ToListAsync();
            return students;
        }

        // GET: api/student/marks/75
        [HttpGet("marks75")]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudentsWithMarksGreaterThan75()
        {
            var students = await _appDbContext.Students.Where(s => s.Mark > 75).ToListAsync();
            return students;
        }

        // GET: api/student/marks/50
        [HttpGet("marks55")]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudentsWithMarksequalto50()
        {
            var students = await _appDbContext.Students.Where(s => s.Mark==50).ToListAsync();
            return students;
        }

        // Other actions (e.g., POST, PUT, DELETE) can be added based on your requirements
    }
}
