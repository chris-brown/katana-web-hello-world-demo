using Nancy;
using Nancy.Conventions;

namespace OWINExample.Host.Modules {
  public class StaticFileBootstrapper : DefaultNancyBootstrapper {
    protected override void ConfigureConventions(NancyConventions nancyConventions)
    {
      this.Conventions.ViewLocationConventions.Add((viewName, model, context) => string.Concat("web/views/", context.ModuleName, "/", viewName));
      nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("_client", @"web/_client"));
      base.ConfigureConventions(nancyConventions);
    }
  }
}
