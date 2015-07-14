using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idunas.TeamspeakSync
{
	public class SyncManager
	{
		public static void Start()
		{
            using(var context = new TeamspeakContext())
			{
				var clients = context.Clients.ToList();
				var props = context.ClientProperties.ToList();
			}
		}
	}
}
