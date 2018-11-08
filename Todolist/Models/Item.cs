using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;


namespace Todolist.Models
	{
	public class Item
	{
		[Key]
		[DatabaseGenerated (DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }


		public enum Priority { low = 1, mid = 2, high = 3 }
		public DateTime Zeitpunkt => DateTime.UtcNow;
		public string Aufgabe { get; set; }
		public Priority Priorität { get; set; }
		public bool Erledigt { get; set; }
		public bool Verschoben { get; set; }
	}
}
