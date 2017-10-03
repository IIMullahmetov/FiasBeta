using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FiasBeta.Manager
{
	[Table("Subjects")]
	public class Subject
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[MaxLength(3)]
		public string Code { get; set; }

		[MaxLength(16)]
		public string Name { get; set; }


	}

	[Table("Cities")]
	public class City
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[MaxLength(32)]
		public string Name { get; set; }
	}
}
