using SimpleTCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Classes
{
    public class Server
    {
        private String textFromUser;
        SimpleTcpServer server;
        SimpleTcpClient client;
        public string getTextFromUser
        {
            get { return textFromUser; }
            set { textFromUser = value; }
        }


       

        public void serverConnection()
        {
            server = new SimpleTcpServer();
            server.StringEncoder = Encoding.UTF8;
            server.Delimiter = 0x13;
            server.DataReceived += Server_DataReceieved;
        }

        private void Server_DataReceieved(object? sender, SimpleTCP.Message e)
        {
            textFromUser += e.MessageString;
            e.ReplyLine(string.Format("You said: {0}", e.MessageString));

        }     
       
         
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }


        public void establishConnection()
        {
            System.Net.IPAddress ip = new System.Net.IPAddress(long.Parse(GetLocalIPAddress()));
            server.Start(ip, 1400);

        }

        public void tcpClient()
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
        }

        public void Client_DataReceived(object? sender, SimpleTCP.Message e)
        {
            textFromUser += e.MessageString;
            //e.ReplyLine(string.Format("You said: {0}", e.MessageString));
        }

        public void sendingMessage()
        {
            client.WriteLineAndGetReply
        }


        public string remoteIP()
        {
            ipRemote = new IPEndPoint(IPAddress.Parse(tex))
        }

    }
}
