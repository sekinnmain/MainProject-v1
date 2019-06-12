using MAIN_GUI_Mangaer_window.ma_controller;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Xml;

namespace Main.ServerOs
{
    public static class MyTcpListener
    {
        public static object ClientSocket { get; private set; }

        public static void StartListening()
        {
            TcpListener server = null;
            try
            {
                // Set the TcpListener on port 13000.
                Int32 port = 9999;
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");

                // TcpListener server = new TcpListener(port);
                server = new TcpListener(localAddr, port);

                // Start listening for client requests.
                server.Start();

                // Buffer for reading data


                // Enter the listening loop.
                while (true)
                {
                    Console.Write("Waiting for a connection... ");

                    // Perform a blocking call to accept requests.
                    // You could also user server.AcceptSocket() here.
                    Socket client = server.AcceptSocket();
                    Console.WriteLine("Connected!");


                    // Get a stream object for reading and writing


                    // Loop to receive all the data sent by the client.
                    XmlDocument myDoc = new XmlDocument();
                    myDoc.Load(XmlParser.xmlOrder);
                    string welcome = $"{GetXMLAsString(myDoc)}";
                    byte[] data = new byte[1024];
                    data = Encoding.ASCII.GetBytes(welcome);
                    client.Send(data, data.Length, SocketFlags.None);

                    // Shutdown and end connection
                    client.Close();
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            finally
            {
                // Stop listening for new clients.
                server.Stop();

            }


            Console.WriteLine("\nHit enter to continue...");
            Console.Read();
        }
        public static string GetXMLAsString(XmlDocument myxml)
        {

            StringWriter sw = new StringWriter();
            XmlTextWriter tx = new XmlTextWriter(sw);
            myxml.WriteTo(tx);

            string str = sw.ToString();// 
            return str;
        }
    }

}
