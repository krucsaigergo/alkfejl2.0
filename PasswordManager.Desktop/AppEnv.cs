using Microsoft.Data.Sqlite;
using PasswordManager.Core.Utils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Desktop
{
    internal class AppEnv : IDisposable
    {

        private SqliteConnection? _keepAliveConnection;

        public static string GetConnectionName() => ConfigurationManager.AppSettings["Connection"]
                ?? throw new KeyNotFoundException($"Application setting 'Connection' not found.");

        public static string GetConnectionString(string? connection = null) => ConfigurationManager.ConnectionStrings[connection ?? GetConnectionName()].ConnectionString
                ?? throw new KeyNotFoundException($"Connection string '{connection}' not found.");

        public void Init()
        {
            InitDb();
        }

        public void Dispose()
        {
            _keepAliveConnection?.Dispose();
        }

        private void InitMemDb(string appConnectionConfig)
        {
            string connectionStringConfig = GetConnectionString(appConnectionConfig);
            connectionStringConfig = PathUtils.ResolveVirtual(connectionStringConfig);
            string connectionString = $"Data Source={connectionStringConfig};";
            _keepAliveConnection = new(connectionString);
            _keepAliveConnection.Open();
        }

        private void InitDiskDb(string appConnectionConfig)
        {
            string connectionStringConfig = GetConnectionString(appConnectionConfig);
            connectionStringConfig = PathUtils.ResolveVirtual(connectionStringConfig);
            string? dirname = Directory.GetParent(connectionStringConfig)?.FullName;
            if (dirname != null && !Directory.Exists(dirname))
            {
                Directory.CreateDirectory(dirname);
            }
        }

        private void InitDb()
        {
            string appConnectionConfig = GetConnectionName();
            switch (appConnectionConfig)
            {
                case "PasswordManagerMemDb":
                    InitMemDb(appConnectionConfig);
                    break;
                case "PasswordManagerDiskDb":
                    InitDiskDb(appConnectionConfig);
                    break;
            }
            using var context = Program.GetDbContext();
            bool created = context.Database.EnsureCreated();
            Debug.WriteLine(created ? "Initialized database." : "Database already created.");
        }
    }
}

