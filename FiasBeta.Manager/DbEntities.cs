using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FiasBeta.Manager
{
	[Table("Subjects")]
	public class Subject
	{
		public Subject()
		{
			Areas = new HashSet<Area>();
			Cities = new HashSet<City>();
		}

		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[MaxLength(3)]
		public string Code { get; set; }

		[MaxLength(16)]
		public string Name { get; set; }

		public virtual ICollection<Area> Areas { get; set; }

		public virtual ICollection<City> Cities { get; set; }
	}

	[Table("Cities")]
	public class City
	{
		public City()
		{
			Areas = new HashSet<Area>();
			Streets = new HashSet<Street>();
		}

		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[MaxLength(32)]
		public string Name { get; set; }

		[MaxLength(16)]
		public string Type { get; set; }

		public virtual Subject Subject { get; set; }

		public virtual ICollection<Area> Areas { get; set; }

		public virtual ICollection<Street> Streets { get; set; }
	}

	[Table("Streets")]
	public class Street
	{
		public Street() => Houses = new HashSet<House>();

		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[MaxLength(32)]
		public string Name { get; set; }

		[MaxLength(16)]
		public string Type { get; set; }

		public virtual City City { get; set; }

		public virtual ICollection<House> Houses { get; set; }
	}

	[Table("Houses")]
	public class House
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		public int Number { get; set; }

		[MaxLength(2)]
		public string Case { get; set; }

		public virtual Street Street { get; set; }
	}

	[Table("Areas")]
	public class Area
	{
		public Area() => Cities = new HashSet<City>();

		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[MaxLength(32)]
		public string Name { get; set; }

		public virtual Subject Subject { get; set; }

		public virtual ICollection<City> Cities { get; set; }
	}
}
