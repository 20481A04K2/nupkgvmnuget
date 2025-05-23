var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "✅ Hello from LibB (Port 8082)");

app.Run("http://0.0.0.0:8082");
