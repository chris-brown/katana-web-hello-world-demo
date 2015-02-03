using System;
using Owin;

namespace OWINExample.Host {
  public class Startup {
    public void Configuration(IAppBuilder app)
    {
#if DEBUG
      app.UseErrorPage();
#endif

      app.UseNancy();
      app.Run(async ctx =>
      {
        Console.WriteLine(ctx.Request.Uri.AbsoluteUri);
        await ctx.Response.WriteAsync("<h1>Hello OWIN!</h1>");
      });
    }
  }
}
