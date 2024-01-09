using DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;
using SalesWPFApp.UserControlComponent;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SalesWPFApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ServiceProvider serviceProvider;
        public App()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureService(services);
            serviceProvider = services.BuildServiceProvider();
        }

        private void ConfigureService(ServiceCollection services)
        {
            services.AddSingleton(typeof(IMemberRepository), typeof(MemberRepository));
            services.AddSingleton(typeof(IOrderRepository), typeof(OrderRepository));
            services.AddSingleton(typeof(IOrderDetailRepository), typeof(OrderDetailRepository));
            services.AddSingleton(typeof(IProductRepository), typeof(ProductRepository));
            services.AddSingleton<MainWindow>();
            services.AddSingleton<WindowHomepage>();
        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            var main = serviceProvider.GetService<MainWindow>();
            var homepage = serviceProvider.GetService<WindowHomepage>();
            main.Show();
        }
    }
}
