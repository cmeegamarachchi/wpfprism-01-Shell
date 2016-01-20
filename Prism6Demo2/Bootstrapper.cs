using System.Windows;
using Prism.Unity;
using Microsoft.Practices.Unity;
using Prism6Demo2.Views;

namespace Prism6Demo2
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }
    }
}