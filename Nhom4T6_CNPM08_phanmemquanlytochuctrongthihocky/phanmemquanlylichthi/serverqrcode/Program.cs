using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace serverqrcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listenner = new Socket(SocketType.Stream, ProtocolType.Tcp);
            listenner.Bind(new IPEndPoint(IPAddress.Parse("192.168.152.1"), 1308));
            listenner.Listen(10);
            //Console.WriteLine($"Server started at {listenner.LocalEndPoint}");
            Console.WriteLine($"Server started at {listenner.LocalEndPoint}");
            while (true)
            {
                var worker = listenner.Accept();

                var stream = new NetworkStream(worker);
                var reader = new StreamReader(stream);
                var writer = new StreamWriter(stream);

                var request = reader.ReadLine();
                var response = string.Empty;
                Console.WriteLine(request);
                using (var pipeClient = new NamedPipeClientStream(".", "testpipe", PipeDirection.Out))
                {
                    pipeClient.Connect();
                    using (var sw = new StreamWriter(pipeClient))
                    {
                        sw.WriteLine(request);
                    }
                    //pipeClient.Close();
                }
                if (request != null)
                {

                }






                writer.WriteLine(response);
                writer.Flush();
                worker.Close();
            }
        }
    }
}
