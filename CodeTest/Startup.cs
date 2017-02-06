using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeTest.Startup))]
namespace CodeTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           // ConfigureAuth(app);
        }
    }
}
