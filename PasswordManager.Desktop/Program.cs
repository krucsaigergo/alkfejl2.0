using Microsoft.EntityFrameworkCore;
using PasswordManager.Core.Data;
using PasswordManager.Core.Utils;

namespace PasswordManager.Desktop
{
    internal static class Program
    {

        internal static void TryInvoke(Control sender, Action action)
        {
            if (sender.InvokeRequired)
            {
                sender.Invoke(action);
            }
            else
            {
                action();
            }
        }

        internal static PasswordManagerDbContext GetDbContext()
        {
            string connectionStringConfig = PathUtils.ResolveVirtual(AppEnv.GetConnectionString());
            string connectionString = $"Data Source={connectionStringConfig};";
            var optionsBuilder = new DbContextOptionsBuilder<PasswordManagerDbContext>().UseSqlite(connectionString);
            return new PasswordManagerDbContext(optionsBuilder.Options);
        }


        [STAThread]
        public static void Main(string[] args)
        {
            using AppEnv env = new();
            env.Init();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}