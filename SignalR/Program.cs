
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", builder => builder
    .WithOrigins("http://localhost:59280")
    .AllowAnyMethod()
    .AllowAnyHeader()
    .AllowCredentials());
});

var app = builder.Build();

app.UseCors(policyName: "CorsPolicy");
app.MapHub<MyHub>(pattern: "/chat");
app.Run();

public class MyHub : Hub
{
    public async IAsyncEnumerable<string> Streaming
    (CancellationToken stoppingToken)
    {
          while (!stoppingToken.IsCancellationRequested)
          {
            yield return DateTime.UtcNow.ToString(format:"hh:mm:ss");

            try
            {
                await Task.Delay(1000, stoppingToken);

            }

            catch (OperationCanceledException)
            {
                yield break;
            }
          }
    }

}