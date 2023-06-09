
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

public partial class MyHub : Hub
{
    bool stop = false;
    public async IAsyncEnumerable<string> Streaming
    (CancellationToken stopToken)
    {
        while (!stopToken.IsCancellationRequested)
        {
            yield return DateTime.UtcNow.ToString(format: "hh:mm:ss");
            Console.WriteLine("Dzialam");

            try
            {
                await Task.Delay(1000);

            }

            catch (OperationCanceledException)
            {
                yield break;
            }
        }
    }
    

    public async IAsyncEnumerable<Position> SnakePosition
    (CancellationToken stopToken)
    {

        while (!stopToken.IsCancellationRequested)
        {
           Random gen = new Random();
        Position snakePosition = new Position(){X=gen.Next(5), Y=4};
        Console.WriteLine("Wywoluje mnie");
       yield return snakePosition;

            try
            {
                await Task.Delay(1000);

            }

            catch (OperationCanceledException)
            {
                yield break;
            }
        }

    }

}