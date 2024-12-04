
using System;
using System.Net.Sockets;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hedef IP: ");
        string target = Console.ReadLine();

        Console.Write("Port: ");
        int port = int.Parse(Console.ReadLine());

        using (TcpClient tcpClient = new TcpClient())
        {
            try
            {
                tcpClient.Connect(target, port);
                Console.WriteLine($"Port {port} açık.");
            }
            catch
            {
                Console.WriteLine($"Port {port} kapalı.");
            }
        }
    }
}
