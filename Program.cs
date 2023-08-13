
using Grpc.Net.Client;
using GrpcClient;

var channel = GrpcChannel.ForAddress("http://localhost:5047");
var client = new Greeter.GreeterClient(channel);
HelloReply response = await client.SayHelloAsync(new HelloRequest { Name = "sazan" });
Console.WriteLine($"Response:{response.Message}");