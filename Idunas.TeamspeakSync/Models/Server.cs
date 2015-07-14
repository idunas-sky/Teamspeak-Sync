using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idunas.TeamspeakSync.Models
{
	public class Server
	{
		[Key]
		public int Server_Id { get; set; }

		public uint Server_Port { get; set; }

		public uint Server_Autostart { get; set; }

		public string Server_Machine_Id { get; set; }

		public uint Server_Month_Upload { get; set; }

		public uint Server_Month_Download { get; set; }

		public uint Server_Total_Upload { get; set; }

		public uint Server_Total_Downlaod { get; set; }
	}
}
