var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var a = 10;
var b = 12;
var c = a + b;
Console.WriteLine(c);
app.MapGet("/", () => "Hello World!"  );




app.Run();
