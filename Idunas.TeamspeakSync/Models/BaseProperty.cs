using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idunas.TeamspeakSync.Models
{
	public abstract class BaseProperty
	{
		public uint Server_Id { get; set; }

		public uint Id { get; set; }

		public string Ident { get; set; }

		public string Value { get; set; }
	}
}
