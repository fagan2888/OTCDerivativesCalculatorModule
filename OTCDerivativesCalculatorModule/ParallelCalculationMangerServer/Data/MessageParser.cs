using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using FpmlSerializedCSharp;
using Excel_Interface;

namespace ParallelCalculationMangerServer
{
    public class MessageParser
    {
        private string messageText_;
        private JobAction jobAction_;

        protected string type_;
        protected XmlDocument xmlDoc_;

        protected MessageViewModel messageViewModel_;

        #region Result_
        private string result_;
        public string Result_
        {
            get { return this.result_; }
            set
            {
                if (this.result_ != value)
                {
                    this.result_ = value;
                }
            }
        }
        #endregion

        public MessageParser(string messageText)
        {
            this.messageText_ = messageText;
        }

        public void parsing()
        {
            this.xmlDoc_ = new XmlDocument();

            this.xmlDoc_.LoadXml(this.messageText_);

            XmlNode xmlNode = this.xmlDoc_.SelectSingleNode("message");

            FpmlSerializedCSharp.Message serial_message = new FpmlSerializedCSharp.Message(xmlNode);
            Excel_Interface.MessageViewModel e_mvm = new MessageViewModel();
            
            e_mvm.setFromSerial(serial_message);
            
            this.messageViewModel_ = e_mvm;

            string type = messageViewModel_.MessageHeaderViewModel_.MessageType_;

            this.jobAction_ = this.getJobAction(type, e_mvm);
        }

        private JobAction getJobAction(string type,MessageViewModel e_mvm)
        {
            JobAction ja;

            if (type.ToUpper() == "ENQUEUE")
            {
                ja = new InstrumentDataEnQueueJob(e_mvm);
            }
            else if (type.ToUpper() == "GRIDCALCULATIONSTART")
            {
                ja = new CalculationStartJob(e_mvm);
            }
            else if (type.ToUpper() == "ENQUEUE")
            {
                ja = new InstrumentDataEnQueueJob(e_mvm);
            }
            else
            {
                ja = new InstrumentDataEnQueueJob(e_mvm);
            }

            return ja;

        }

        public void DoJob()
        {
            this.jobAction_.DoJob();
            // db에 넣음.
            this.result_ = "complete Job";
        }


    }
}
