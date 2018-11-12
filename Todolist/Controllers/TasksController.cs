using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Todolist.Models;

namespace Todolist.Controllers
{
	[Route ("api/[controller]")]
	[ApiController]
	public class TasksController : ControllerBase
	{
		private readonly TodolistDbContext _context;
		public TasksController (TodolistDbContext context)
		{
			_context = context;
		}


		// GET: api/Tasks
		[HttpGet]
		public IEnumerable<Item> GetAllTasks () => _context.Items;


		// GET: api/Tasks/5
		[HttpGet ("{id}")]
		public async Task<IActionResult> GetTask ([FromRoute] int id)
		{
			var item = await _context.Items.FirstOrDefaultAsync (x => x.Id == id);

			if (item == null)
				return NotFound ();

			return Ok (item);
		}


		// POST: api/Tasks
		[HttpPost]
		public async Task<IActionResult> PostTask ([FromBody] Item item)
		{
			if (!ModelState.IsValid)
				return BadRequest (ModelState);

			_context.Items.Add (item);
			await _context.SaveChangesAsync ();
			return CreatedAtAction ("PostTask", new { id = item.Id }, item);

		}


		// DELETE: api/Tasks/
		[HttpDelete]
		public async Task<IActionResult> DeleteAllTasks ([FromRoute] string Name)
		{

			foreach (Item item in _context.Items)
				_context.Items.Remove (item);


			await _context.SaveChangesAsync ();
			return Ok ();

		}


		// DELETE: api/Tasks/5
		[HttpDelete ("{id}")]
		public async Task<IActionResult> DeleteTask ([FromRoute] int id)
		{
			var item = await _context.Items.FirstOrDefaultAsync (x => x.Id == id);

			if (item == null)
				return NotFound ();

			_context.Items.Remove (item);
			await _context.SaveChangesAsync ();
			return Ok (item);

		}
	}
}