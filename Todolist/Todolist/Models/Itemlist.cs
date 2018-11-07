using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Todolist.Models
{
	public class Itemlist
	{
		[Key]
		[DatabaseGenerated (DatabaseGeneratedOption.Identity)]
		public int ItemlistId { get; set; }

		public List <Item> Items { get; set; }
		public Itemlist ()
			{
				Items = new List <Item> ();
			}
	}
}
