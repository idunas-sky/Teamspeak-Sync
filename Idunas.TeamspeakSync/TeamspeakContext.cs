using Idunas.TeamspeakSync.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idunas.TeamspeakSync
{
	internal class TeamspeakContext : DbContext
	{
		public TeamspeakContext() : base(
			new SQLiteConnection()
			{
				ConnectionString = new SQLiteConnectionStringBuilder
				{
					DataSource = @"C:\Workspace\Teamspeak-Sync\ts3server.sqlitedb"
				}.ConnectionString
			}, true)
		{
		}

		public DbSet<Client> Clients { get; set; }

		public DbSet<ClientProperty> ClientProperties { get; set; }

		public DbSet<Server> Servers { get; set; }

		public DbSet<ServerProperty> ServerProperties { get; set; }

		public DbSet<Channel> Channels { get; set; }

		public DbSet<ChannelProperty> ChannelProperties { get; set; }

		public DbSet<ServerGroup> ServerGroups { get; set; }

		public DbSet<ChannelGroup> ChannelGroups { get; set; }

		public DbSet<SqliteSequence> Sequences { get; set; }
	}
}
