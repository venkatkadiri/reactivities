using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistance;

namespace API.Controllers
{
    public class ActiivitiesController : BaseApiController
    {
        private readonly DataContext _context;
        public ActiivitiesController(DataContext context)
        {
            _context = context;

        }
        [HttpGet]
        public async Task<ActionResult<List<Activity>>> getActivitiesAsync()
        {
            return await _context.Activities.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivityAsync(Guid id)
        {
            return await _context.Activities.FindAsync(id);
        }
    }
}