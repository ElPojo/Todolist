using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Todolist.Models
	{
	public class Item
	{
		[Key]
		[DatabaseGenerated (DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		public DateTime Zeitpunkt { get; set; }
		public string Aufgabe { get; set; }
		public Priority Prioritaet { get; set; }
		public bool Erledigt { get; set; }
		public bool Verschoben { get; set; }
	}
}