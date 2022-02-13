﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoteServer;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;

namespace ClientApp
{
    class ClientProgram
    {
        public ClientProgram()
        {

        }
        static void Main(string[] args)
        {
            HttpChannel c1 = new HttpChannel();
            ChannelServices.RegisterChannel(c1);
            //create a service class object
            Service service = (Service)Activator.GetObject(typeof(Service), "http://localhost:8001/Service");
            //call the service functions
            service.WriteMessage(10, 15);
            Console.Read();
        }
    }
}
