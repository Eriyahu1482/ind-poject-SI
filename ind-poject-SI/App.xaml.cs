using ind_poject_SI.Model;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System.Windows;

namespace ind_poject_SI
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            new MainWindow().Show();

            DatabaseFacade facade = new DatabaseFacade(new ModelContext());
            facade.EnsureCreated();
        }
    }
}
