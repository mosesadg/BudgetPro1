using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BudgetPro1.Startup))]
namespace BudgetPro1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
