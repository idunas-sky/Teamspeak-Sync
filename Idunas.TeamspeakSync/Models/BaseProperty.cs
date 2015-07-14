using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idunas.TeamspeakSync.Models
{
	public abstract class BaseProperty
	{
		[Key, Column(Order = 0)]
		public uint Server_Id { get; set; }

		[Key, Column(Order = 1)]
		public uint Id { get; set; }

		[Key, Column(Order = 2)]
		public string Ident { get; set; }

		public string Value { get; set; }
	}
}
