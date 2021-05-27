using Fluent.Infrastructure.FluentStartup;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WingtipToysTutorial.StartupOwin))]

namespace WingtipToysTutorial
{
    public partial class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            AuthStartup.ConfigureAuth(app);
        }
    }
}
