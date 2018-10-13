using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XamarinNative.BackEnd.Startup))]
namespace XamarinNative.BackEnd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
