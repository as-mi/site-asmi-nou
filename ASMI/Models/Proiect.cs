using System;

namespace ASMI.Models
{
	public class Proiect
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public DateTime? Date { get; set; }

		public string WebSite { get; set; }

		public Proiect(string Name, string Description, DateTime? Date, string WebSite) { 
			this.Name = Name;
			this.Description = Description;
			this.Date = Date;
			this.WebSite = WebSite;
		}
	}

}
