using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using Excel_Interface;

namespace ParallelCalculationMangerServer
{
    public abstract class JobAction
    {
        protected MessageViewModel MessageViewModel_;
        
        //protected string type_;
        //protected XmlDocument xmlDoc_;
        //protected MessageHeader messageHeader_;

        public JobAction()
        {

        }

        //private void loadXml()
        //{
        //    this.xmlDoc_ = new XmlDocument();

        //    this.xmlDoc_.LoadXml(this.messageText_);

        //    XmlNode xmlNode = this.xmlDoc_.SelectSingleNode("messageHeader");

        //    MessageHeader serial_messageHeader = new MessageHeader(xmlNode);

        //}

        public abstract void DoJob();
    }
}
