using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Excel_Interface
{
    public class TargetServerInfoViewModel
    {
        public TargetServerInfoViewModel()
        { 

        }

        public IPHostEntry IPHostInfo_;
        public IPAddress IPAddress_;
        public IPEndPoint IPEndPoint_;



        //IPHostEntry ipHostInfo = Dns.Resolve("host.contoso.com");
        //IPAddress ipAddress = ipHostInfo.AddressList[0];
        //IPEndPoint remoteEP = new IPEndPoint(ipAddress, port);
    }
}
