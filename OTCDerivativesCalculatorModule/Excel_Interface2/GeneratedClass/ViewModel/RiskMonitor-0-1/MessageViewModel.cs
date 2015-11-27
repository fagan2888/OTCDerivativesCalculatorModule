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
        
        public MessageViewModel() { }
        
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
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "message");
                xmlWriter.WriteStartElement("message");
                    messageHeaderViewModel_.buildXml(xmlWriter);
                    
                    messageBodyViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new MessageView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Message serial_Message = serial_Class as FpmlSerializedCSharp.Message;
        
            FpmlSerializedCSharp.MessageHeader serial_messageHeader = serial_Message.MessageHeader_;
            string messageHeadertype = serial_messageHeader.Excel_type_.ValueStr;
            this.messageHeaderViewModel_ = MessageHeaderViewModel.CreateMessageHeader(messageHeadertype);
            this.messageHeaderViewModel_.setFromSerial(serial_messageHeader);
            
            FpmlSerializedCSharp.MessageBody serial_messageBody = serial_Message.MessageBody_;
            string messageBodytype = serial_messageBody.Excel_type_.ValueStr;
            this.messageBodyViewModel_ = MessageBodyViewModel.CreateMessageBody(messageBodytype);
            this.messageBodyViewModel_.setFromSerial(serial_messageBody);
            
        }
        
        
    
            
            
            
            
        
    
        
    
    }
    
}

