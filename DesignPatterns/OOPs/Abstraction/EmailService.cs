using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.OOPs.Abstraction
{
    public class EmailService
    {
        public void SendEmail()
        {
            connect();
            authenticate();
            Console.WriteLine("Sending the Mail");
            disconnect();

        }
        private void connect()
        {
            Console.WriteLine("Connected to email server.");
        }
        private void authenticate()
        {
            Console.WriteLine("Authenticated with email server.");
        }
        private void disconnect()
        {
            Console.WriteLine("Disconnected from email server."); 
        }
    }
}
