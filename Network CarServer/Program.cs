using System.Net.Sockets;
using System.Net;


TcpClient client = new();
client.Connect(IPAddress.Loopback, 27001);


Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Connected to server!");

Console.ForegroundColor= ConsoleColor.White;

Console.WriteLine("--------------------------------------------------------------------------");

var stream = client.GetStream();
var binaryRd = new BinaryReader(stream);
var binaryWt = new BinaryWriter(stream);

var command = string.Empty;
var answer = string.Empty;

while (true)
{
    command = Console.ReadLine();

    binaryWt.Write(command!);

    answer = binaryRd.ReadString();

    Console.Write("[");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(answer);
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("]");
    Console.WriteLine("");
    Console.Write("...");

    Console.ReadLine();
    

}