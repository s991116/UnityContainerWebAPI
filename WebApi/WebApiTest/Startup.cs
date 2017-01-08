using System.Web.Http;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Extensions;
using Owin;
using WebApiTest;

[assembly: OwinStartup(typeof(Startup))]

namespace WebApiTest
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var httpConfiguration = new HttpConfiguration();

            WebApiConfig.Register(httpConfiguration);

            app.UseCors(CorsOptions.AllowAll);
            app.UseWebApi(httpConfiguration);

            app.UseStageMarker(PipelineStage.MapHandler);

        }
    }
}
