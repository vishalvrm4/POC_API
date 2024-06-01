// See https://aka.ms/new-console-template for more information
using Grpc.Net.Client;
using GrpcServicePOC;

Console.WriteLine("Hello, World!");


using var channel = GrpcChannel.ForAddress("http://localhost:5260");
var client = new Greeter.GreeterClient(channel);
var reply = await client .SayHelloAsync(new HelloRequest { Name = "Hello" });
Console.WriteLine("Reply : " + reply.Message);