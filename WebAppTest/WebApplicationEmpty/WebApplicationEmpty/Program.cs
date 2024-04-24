using Microsoft.AspNetCore.Builder;
using System.Reflection.PortableExecutable;
using System.Text;
using WebApplicationEmpty;
using WebApplicationEmpty.Map;
using static System.Runtime.InteropServices.JavaScript.JSType;


AppMapping map = new AppMapping(args);





//request.Path - путь в формате "/Oleg"
//request.QueryString - запрос с вопросом в формате "?cringe=ALE&prikol=1"
//по всем параметрам в квери можно пройти foreach (var param in context.Request.Query) key и value 
//отдельная выборка: string name = context.Request.Query["name"]
//context.Response.Redirect("/new") - Редирект
