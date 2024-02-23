var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

if (app.Environment.IsDevelopment()) { app.UseDeveloperExceptionPage(); }

app.MapGet("/", () => $"Hello, World! {System.Environment.Version}");

app.Run();