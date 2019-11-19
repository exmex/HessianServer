using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace HessianLoginServer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var ds = new DefaultServer(5585);
            ds.Start();
            
            var channelServer = new DefaultServer(5555);
            channelServer.Start();

            while (true)
            {
                Thread.Sleep(5000);
            }
            
            return;

            TcpListener serverSocket = new TcpListener(5585);
            int requestCount = 0;
            TcpClient clientSocket = default(TcpClient);
            serverSocket.Start();
            Console.WriteLine(" >> Server Started");
            clientSocket = serverSocket.AcceptTcpClient();
            Console.WriteLine(" >> Accept connection from client");
            requestCount = 0;

            while ((true))
            {
                try
                {
                    requestCount = requestCount + 1;
                    NetworkStream networkStream = clientSocket.GetStream();
                    byte[] bytesFrom = new byte[65536];
                    Console.WriteLine("Received: " + clientSocket.ReceiveBufferSize);
                    networkStream.Read(bytesFrom, 0, 4);
                    //networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);
                    Console.WriteLine(HexDump(bytesFrom));
                    
                    string dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                    dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                    Console.WriteLine(" >> Data from client - " + dataFromClient);
                    /*string serverResponse = "Last Message from client" + dataFromClient;
                    Byte[] sendBytes = Encoding.ASCII.GetBytes(serverResponse);
                    networkStream.Write(sendBytes, 0, sendBytes.Length);
                    networkStream.Flush();
                    Console.WriteLine(" >> " + serverResponse);*/
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

            clientSocket.Close();
            serverSocket.Stop();
            Console.WriteLine(" >> exit");
            Console.ReadLine();
        }
        
        public static string HexDump(IEnumerable<byte> buffer)
        {
            const int bytesPerLine = 16;
            var hexDump = "";
            var j = 0;
            foreach (var g in buffer.Select((c, i) => new {Char = c, Chunk = i / bytesPerLine}).GroupBy(c => c.Chunk))
            {
                var s1 = g.Select(c => $"{c.Char:X2} ").Aggregate((s, i) => s + i);
                string s2 = null;
                var first = true;
                foreach (var c in g)
                {
                    var s = $"{(c.Char < 32 || c.Char > 122 ? '·' : (char) c.Char)} ";
                    if (first)
                    {
                        first = false;
                        s2 = s;
                        continue;
                    }
                    s2 = s2 + s;
                }
                var s3 = $"{j++ * bytesPerLine:d6}: {s1} {s2}";
                hexDump = hexDump + s3 + Environment.NewLine;
            }
            return hexDump;
        }
    }
}