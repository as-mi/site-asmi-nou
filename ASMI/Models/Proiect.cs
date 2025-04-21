using System;

namespace ASMI.Models
{
	public class Proiect
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public DateTime? DateStart { get; set; }
		public DateTime? DateFin {get; set;}

		public string WebSite { get; set; }

		public string LogoPath {get; set; }

		public Proiect(string Name, string Description, DateTime? DateStart, DateTime? DateFin, string WebSite, string LogoPath) { 
			this.Name = Name;
			this.Description = Description;
			this.DateStart = DateStart;
			this.DateFin = DateFin;
			this.WebSite = WebSite;
			this.LogoPath = LogoPath;
		}
	}

}
