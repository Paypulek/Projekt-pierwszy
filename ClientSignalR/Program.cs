using Microsoft.AspNetCore.SignalR.Client;

var uri = "http://localhost:5000/chat";



await using var connection = new HubConnectionBuilder()
.WithUrl(uri)
.Build();

await connection.StartAsync();


int counter = 0;
await foreach (var item in connection.StreamAsync<string>(methodName:"Streaming"))
{
    Console.WriteLine(item);
    counter++;
    if (counter>2)
    {

            break;
    }
}

Console.WriteLine("kolejnezadanie");
await foreach(var item in  connection.StreamAsync<Position>("SnakePosition"))
{
    Console.WriteLine("Elo"+ item.X + "drugaa" + item.Y);
    Console.WriteLine("S");
    counter++;
    if (counter>4)
    {break;}
}
