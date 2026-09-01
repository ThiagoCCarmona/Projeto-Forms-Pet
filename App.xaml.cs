using Microsoft.Extensions.DependencyInjection;

namespace Projeto_forms_Vet
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        // Forma nova e correta de inicializar a navegação no MAUI atual
        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new Views.FrmPrincipal()));
        }
    }
}