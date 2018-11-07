using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Todolist.Models;

namespace Todolist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   public class TasksController : ControllerBase
    {
        private readonly ItemlistDbContext _context;
        public TasksController (ItemlistDbContext context) => _context = context;


		// GET: api/Tasks
		[HttpGet]
		public IEnumerable <Item> GetItem () => _context.Item;
		

        // GET: api/Tasks/5
        [HttpGet ("{id}")]
        public async Task <IActionResult> GetItem ([FromRoute] int id)
		{
            var item = await _context.Item.FirstOrDefaultAsync (x => x.Id == id);

            if (item == null)
				return NotFound ();
			
            return Ok (item);
        }


        // POST: api/Tasks
        [HttpPost]
        public async Task <IActionResult> PostItem ([FromBody] Item item)
		{
			if (!ModelState.IsValid)
				return BadRequest (ModelState);
			
           else
				_context.Item.Add (item);
				await _context.SaveChangesAsync ();
				return CreatedAtAction ("PostItem", new { id = item.Id }, item);

		}


		// DELETE: api/Tasks/
		[HttpDelete]
		public async Task <IActionResult> DeleteItem ([FromRoute] string Name)
		{

			foreach (Item item in _context.Item)
				_context.Item.Remove (item);
			

			await _context.SaveChangesAsync ();
			return Ok ();

		}


		// DELETE: api/Tasks/5
		[HttpDelete ("{id}")]
		public async Task <IActionResult> DeleteItem ([FromRoute] int id)
		{
			var item = await _context.Item.FirstOrDefaultAsync (x => x.Id == id);

			if (item == null)
				return NotFound ();

			else
				_context.Item.Remove (item);
				await _context.SaveChangesAsync ();
				return Ok ();

		}
	}
}