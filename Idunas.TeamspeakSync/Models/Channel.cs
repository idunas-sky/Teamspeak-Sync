﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idunas.TeamspeakSync.Models
{
	public class Channel
	{
		public int Channel_Id { get; set; }

		public uint Channel_Parent_Id { get; set; }

		public uint Server_Id { get; set; }
	}
}
