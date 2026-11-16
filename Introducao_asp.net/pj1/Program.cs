using pj1;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
app.UseMiddleware<MeuMiddleware>();



app.MapGet("/", () => "Hello World!");

app.MapGet("/teste", () =>
{
    Thread.Sleep(2000);
    return "Hello World!";
});


app.Run();
