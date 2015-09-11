using System.Web.Http;
using System.Web.Routing;

namespace GetstartedwithdataYuqiMobileService
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            WebApiConfig.Register();
        }
    }
}