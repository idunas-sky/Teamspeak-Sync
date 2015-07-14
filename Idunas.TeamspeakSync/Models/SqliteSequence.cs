using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idunas.TeamspeakSync.Models
{
	[Table("sqlite_sequence")]
	public class SqliteSequence
	{
		[Key]
		public string Name { get; set; }

		public string Seq { get; set; }
	}
}
