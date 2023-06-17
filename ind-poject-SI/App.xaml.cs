using ind_poject_SI.Model;
using ind_poject_SI.Model.LiderBord;
using ind_poject_SI.View.Pages.Main.Menu;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Windows;

namespace ind_poject_SI
{
    public partial class App : Application
    {
        public App() 
        {
            ServiceCollection.services = new ServiceCollection();
            services.AddDbContext<LiderContext>(p =>
            {
                p.UserSqlite("Data Sourse = Statistics");
            });
            services.AddSingleton<LiderPage>();
            serviceProvider = services.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var mainWindow = serviceProvider.GetService<LiderPage>();
            new MainWindow().Show();

            DatabaseFacade facade = new DatabaseFacade(new ModelContext());
            facade.EnsureCreated();
        }
    }
}
