using ConvMVVM.Core.IOC;
using ConvMVVM.Core.Module;
using ConvMVVM.WPF.Component;
using ConvMVVM.WPF.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Viewer.View;
using Viewer.ViewModel;

namespace Viewer
{
    public class App: ConvMVVMApp
    {

        #region Protected Functions
        protected override void ConfigureServiceCollection(IServiceCollection serviceCollection)
        {
            serviceCollection.RegisterCache<MainWindowViewModel>();
        }

        protected override void ConfigureModule(ModuleCollection modules)
        {
            
        }


        protected override void ConfigureServiceProvider(IServiceContainer serviceProvider)
        {
           
            
        }

        protected override void ConfigureServiceLocator()
        {
          
        }

        protected override Window CreateWindow(IServiceContainer serviceProvider)
        {
            return new MainWindowView();
        }
        #endregion
    }
}
