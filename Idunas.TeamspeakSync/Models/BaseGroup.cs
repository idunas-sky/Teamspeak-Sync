using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idunas.TeamspeakSync.Models
{
	public abstract class BaseGroup
	{
		public int Group_Id { get; set; }

		public uint Server_Id { get; set; }

		public string Name { get; set; }

		public int Type { get; set; }
	}
}
