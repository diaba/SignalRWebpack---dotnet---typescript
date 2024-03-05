using SignalRWebpack.Hubs;

var builder = WebApplication.CreateBuilder(args);
// Add signalR

builder.Services.AddSignalR();
var app = builder.Build();

// The following code allows the server to locate and serve the index.html file.
app.UseDefaultFiles();
app.UseStaticFiles();

// app.MapGet("/", () => "Hello World!");

app.MapHub<ChatHub>("/hub");

app.Run();
