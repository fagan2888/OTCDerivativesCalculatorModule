using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class MessageViewModel : IXmlData
    {
        #region Event
        public event PropertyChangedEventHandler PropertyChanged;
        
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
        
        public MessageViewModel() 
        {
            this.messageHeaderViewModel_ = new MessageHeaderViewModel();

        }

        public string TargetCode_;
        public string MessageXmlStr_;

        #region MessageHeaderViewModel_
        private MessageHeaderViewModel messageHeaderViewModel_;
        public MessageHeaderViewModel MessageHeaderViewModel_
        {
            get { return this.messageHeaderViewModel_; }
            set
            {
                if (this.messageHeaderViewModel_ != value)
                {
                    this.messageHeaderViewModel_ = value;
                    this.NotifyPropertyChanged("MessageHeaderViewModel_");
                }
            }
        }
        #endregion
        
        #region MessageBodyViewModel_
        private MessageBodyViewModel messageBodyViewModel_;
        public MessageBodyViewModel MessageBodyViewModel_
        {
            get { return this.messageBodyViewModel_; }
            set
            {
                if (this.messageBodyViewModel_ != value)
                {
                    this.messageBodyViewModel_ = value;
                    this.NotifyPropertyChanged("MessageBodyViewModel_");
                }
            }
        }
        #endregion
        
        public void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("message");
        
                messageHeaderViewModel_.buildXml(xmlWriter);
                    
                messageBodyViewModel_.buildXml(xmlWriter);
                    
            xmlWriter.WriteEndElement();
        }
        
        public void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        //public  Control view()
        //{
        //    Control v = new MessageView();
        //    v.DataContext = this;
        //    return v;
        //}
        
        public void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Message serial_Message = serial_Class as FpmlSerializedCSharp.Message;
                    
            FpmlSerializedCSharp.MessageHeader serial_messageHeader = serial_Message.MessageHeader_;
            this.messageHeaderViewModel_.setFromSerial(serial_messageHeader);
            
            FpmlSerializedCSharp.MessageBody serial_messageBody = serial_Message.MessageBody_;
            string messageBodytype = serial_messageBody.Msg_type_.ValueStr;
            this.messageBodyViewModel_ = MessageBodyViewModel.CreateMessageBody(messageBodytype);
            this.messageBodyViewModel_.setFromSerial(serial_messageBody);

            this.MessageXmlStr_ = serial_Message.Node_.InnerXml;
            
        }

        public string getMessegeStr()
        {

            XmlDocument InstXml = new XmlDocument();

            StringBuilder sb = new StringBuilder();
            XmlWriterSettings setting = new XmlWriterSettings();

            setting.Indent = true;
            //setting.Encoding = Encoding.UTF8;

            XmlWriter xmlWriter = XmlWriter.Create(sb, setting);

            xmlWriter.WriteProcessingInstruction("xml", "version='1.0' encoding='UTF-8'");

            this.buildXml(xmlWriter);

            xmlWriter.Close();

            //InstXml.LoadXml(sb.ToString());

            return sb.ToString();
        }

    }
    
}

