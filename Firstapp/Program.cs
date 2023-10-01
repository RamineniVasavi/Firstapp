var builder = WebApplication.CreateBuilder(args);//create Builder will create a builder for web application and that is called Web application Builder so what this Builder can do, a web application Builder loads the configuration(connection string etc),environment(api urls or server names) and default services. we will get instance of web application
var app = builder.Build();//with app we will configure the middlewares of your application

//app.MapGet("/", () => "Hello World!");
app.Run(async (HttpContext context) =>
{
    //context.Response.StatusCode = 400;
    //await context.Response.WriteAsync("hello");
    //await context.Response.WriteAsync("<h2>world</h2>");
    //context.Response.Headers["mykey"] = "my vlaue";
    //string path=context.Request.Path;
    //string method=context.Request.Method;
    //await context.Response.WriteAsync($"<p>{path}</p>");
    //await context.Response.WriteAsync($"<p>{method}</p>");
    if(context.Request.Method == "GET")
    {
        if (context.Request.Query.ContainsKey("id"))
        {
            string id = context.Request.Query["id"];
            await context.Response.WriteAsync($"<p>{id}</p>");
        }
    }
    
}
);



app.Run();// to start server
