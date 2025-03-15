using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission10_Creer.Data;

namespace Mission10_Creer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private BowlerDbContext _context;

        public BowlerController(BowlerDbContext temp)
        {
            _context = temp;
        }

        [HttpGet(Name="GetBowlerInfo")]
        public IEnumerable<BowlerInfo> Get()
        {
           var bowlerList = _context.Bowlers
               .Include(b => b.Team) // Include the related Team data
               .ToList();
           
           return (bowlerList);
        }
    }
}

