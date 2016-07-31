using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PokemonTCGCollector.Startup))]
namespace PokemonTCGCollector
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
