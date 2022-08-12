using SimpleTCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Classes
{
    public class Server
    {
        private String textFromUser;

        public string getTextFromUser
        {
            get { return textFromUser; }
            set { textFromUser = value; }
        }


        SimpleTcpServer server;

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
    }
}
