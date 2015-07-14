using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Idunas.TeamspeakSync.Service
{
	public class SyncService : ServiceBase
	{
		protected override void OnStart( string[] args )
		{
			base.OnStart( args );

			SyncManager.Start();
		}

		protected override void OnStop()
		{
			base.OnStop();
		}
	}
}
