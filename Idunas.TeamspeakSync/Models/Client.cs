using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idunas.TeamspeakSync.Models
{
	public class Client
	{
		[Key]
		public int Client_Id { get; set; }

		public uint Server_Id { get; set; }

		public string Client_Unique_Id { get; set; }

		public string Client_Nickname { get; set; }

		public string Client_Login_Name { get; set; }

		public string Client_Login_Password { get; set; }

		public uint Client_LastConnected { get; set; }

		public uint Client_Month_Upload { get; set; }

		public uint Client_Month_Download { get; set; }

		public uint Client_Total_Upload { get; set; }

		public uint Client_Total_Download { get; set; }

		public string Client_LastIP { get; set; }
	}
}
