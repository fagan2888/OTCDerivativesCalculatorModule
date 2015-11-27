using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Excel_Interface
{
    public class MessageManager
    {
        public Dictionary<string, TargetServerInfoViewModel> TargerServerMap_;
        //public Dictionary<string, MessageHeaderViewModel> Map_;

        public List<string> Log_;
        
        private string result_;

        public MessageManager()
        { 
        
        }

        public void loadServerInformation()
        {
            this.TargerServerMap_ = new Dictionary<string, TargetServerInfoViewModel>();
            TargetServerInfoViewModel tsivm = new TargetServerInfoViewModel();

            IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            int port = 11000;
            IPEndPoint remoteEP = new IPEndPoint(ipAddress, port);

            tsivm.IPHostInfo_ = ipHostInfo;
            tsivm.IPAddress_ = ipAddress;
            tsivm.IPEndPoint_ = remoteEP;

            this.TargerServerMap_.Add("gridCalculation", tsivm);

        }

        public void send(MessageViewModel msg)
        { 
            // msg targer search    

            TargetServerInfoViewModel tsivm = TargerServerMap_[msg.TargetCode_];

            AsynchronousClient client = new AsynchronousClient();

            //client.StartClient(msg, tsivm);

            this.result_ = "message recieve complete";
        }

        public void receive(MessageViewModel msg)
        { 
            
        }



        


    }
}
