using System.Text.RegularExpressions;

namespace WebApplicationEmpty.Map
{
    public class AppMapping
    {
        public AppMapping(string[] args) 
        {
            Init(args);
        }
        void Init(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
            WebApplication app = builder.Build();

            app.UseMiddleware<ExceptionHandlingMiddleware>();

            app.UseRouting();

            app.MapGroup("/phrases").MapPhrasesGroup();

            app.UseEndpoints(end => { });

            app.Run(HandleRequst);
            app.Run();
        }
       
        async Task HandleRequst(HttpContext context)
        {
            HttpResponse response = context.Response;
            await response.WriteAsync("Page: " + context.Request.Path);
        }
    }
}
