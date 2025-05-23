var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "✅ Hello from LibC (Port 8083)");

app.Run("http://0.0.0.0:8083");
