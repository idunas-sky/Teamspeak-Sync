using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Idunas.TeamspeakSync.Service
{
	static class Program
	{
		public static ServiceBase[] ServicesToRun
		{
			get;
			private set;
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			ServicesToRun = new ServiceBase[]
			{
				new SyncService()
			};

			if(Environment.UserInteractive)
			{
				// Start in console mode
				RunInteractive();
			}
			else
			{
				// Start in service mode
				ServiceBase.Run(ServicesToRun);
			}
		}

		private static void RunInteractive()
		{
			Console.WriteLine("Starting services ... ");

			var startMethod = typeof(ServiceBase).GetMethod("OnStart", BindingFlags.Instance | BindingFlags.NonPublic);

			foreach(var service in ServicesToRun)
			{
				Console.WriteLine("Starting service: " + service.GetType().Name);
				startMethod.Invoke(service, new object[] { new string[0] });
				Console.WriteLine("Started service: " + service.GetType().Name);
			}

			Console.WriteLine("All services started ... press any key to shut them down.");
			Console.ReadKey();

			var stopMethod = typeof(ServiceBase).GetMethod("OnStop", BindingFlags.Instance | BindingFlags.NonPublic);

			foreach(var service in ServicesToRun)
			{
				Console.WriteLine("Stopping service: " + service.GetType().Name);
				stopMethod.Invoke(service, null);
				Console.WriteLine("Stopped service: " + service.GetType().Name);
			}
		}
	}
}
