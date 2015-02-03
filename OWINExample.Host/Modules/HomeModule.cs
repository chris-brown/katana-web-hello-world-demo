using Nancy;
using Nancy.Owin;

namespace OWINExample.Host.Modules {
  public class HomeModule : NancyModule {

    public HomeModule() {
      Get["/{page?}"] = _ => {
        var env = this.Context.GetOwinEnvironment();

        var requestPath = (string)env["owin.RequestPath"];

        return !string.IsNullOrEmpty(_.page) ? View[_.page] : View["Index"];
      };

    }
  }

  public class AccountModule : NancyModule
  {
    public AccountModule()
    {
      Get["/account/{category?}"] = _ => {
        return !string.IsNullOrEmpty(_.category) ? View[string.Format(@"{0}/{1}",_.category, "Index")] : View["Index"];
      };
    }
  }
}
