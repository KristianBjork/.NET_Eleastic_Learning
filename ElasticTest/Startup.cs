using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ElasticTest.Startup))]
namespace ElasticTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
