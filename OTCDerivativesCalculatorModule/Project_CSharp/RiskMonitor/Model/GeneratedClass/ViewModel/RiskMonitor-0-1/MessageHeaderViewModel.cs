using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class MessageHeaderViewModel : IXmlData
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
        
        public MessageHeaderViewModel() { }
        
        #region MessageId_
        private string messageId_;
        public string MessageId_
        {
            get { return this.messageId_; }
            set
            {
                if (this.messageId_ != value)
                {
                    this.messageId_ = value;
                    this.NotifyPropertyChanged("MessageId_");
                }
            }
        }
        #endregion
        
        #region MessageType_
        private string messageType_;
        public string MessageType_
        {
            get { return this.messageType_; }
            set
            {
                if (this.messageType_ != value)
                {
                    this.messageType_ = value;
                    this.NotifyPropertyChanged("MessageType_");
                }
            }
        }
        #endregion
        
        #region SentBy_
        private string sentBy_;
        public string SentBy_
        {
            get { return this.sentBy_; }
            set
            {
                if (this.sentBy_ != value)
                {
                    this.sentBy_ = value;
                    this.NotifyPropertyChanged("SentBy_");
                }
            }
        }
        #endregion
        
        #region SendTo_
        private string sendTo_;
        public string SendTo_
        {
            get { return this.sendTo_; }
            set
            {
                if (this.sendTo_ != value)
                {
                    this.sendTo_ = value;
                    this.NotifyPropertyChanged("SendTo_");
                }
            }
        }
        #endregion
        
        #region CreationTimestamp_
        private string creationTimestamp_;
        public string CreationTimestamp_
        {
            get { return this.creationTimestamp_; }
            set
            {
                if (this.creationTimestamp_ != value)
                {
                    this.creationTimestamp_ = value;
                    this.NotifyPropertyChanged("CreationTimestamp_");
                }
            }
        }
        #endregion
        
        #region IsCorrection_
        private string isCorrection_;
        public string IsCorrection_
        {
            get { return this.isCorrection_; }
            set
            {
                if (this.isCorrection_ != value)
                {
                    this.isCorrection_ = value;
                    this.NotifyPropertyChanged("IsCorrection_");
                }
            }
        }
        #endregion
        
        #region CorrelationId_
        private string correlationId_;
        public string CorrelationId_
        {
            get { return this.correlationId_; }
            set
            {
                if (this.correlationId_ != value)
                {
                    this.correlationId_ = value;
                    this.NotifyPropertyChanged("CorrelationId_");
                }
            }
        }
        #endregion
        
        #region SequenceNumber_
        private string sequenceNumber_;
        public string SequenceNumber_
        {
            get { return this.sequenceNumber_; }
            set
            {
                if (this.sequenceNumber_ != value)
                {
                    this.sequenceNumber_ = value;
                    this.NotifyPropertyChanged("SequenceNumber_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "messageHeader");
                xmlWriter.WriteStartElement("messageHeader");
                    xmlWriter.WriteElementString("messageId" , this.messageId_);
                    
                    xmlWriter.WriteElementString("messageType" , this.messageType_);
                    
                    xmlWriter.WriteElementString("sentBy" , this.sentBy_);
                    
                    xmlWriter.WriteElementString("sendTo" , this.sendTo_);
                    
                    xmlWriter.WriteElementString("creationTimestamp" , this.creationTimestamp_);
                    
                    xmlWriter.WriteElementString("isCorrection" , this.isCorrection_);
                    
                    xmlWriter.WriteElementString("correlationId" , this.correlationId_);
                    
                    xmlWriter.WriteElementString("sequenceNumber" , this.sequenceNumber_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new MessageHeaderView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.MessageHeader serial_MessageHeader = serial_Class as FpmlSerializedCSharp.MessageHeader;
        
            this.messageId_ = serial_MessageHeader.MessageId_.ValueStr;
            
            this.messageType_ = serial_MessageHeader.MessageType_.ValueStr;
            
            this.sentBy_ = serial_MessageHeader.SentBy_.ValueStr;
            
            this.sendTo_ = serial_MessageHeader.SendTo_.ValueStr;
            
            this.creationTimestamp_ = serial_MessageHeader.CreationTimestamp_.ValueStr;
            
            this.isCorrection_ = serial_MessageHeader.IsCorrection_.ValueStr;
            
            this.correlationId_ = serial_MessageHeader.CorrelationId_.ValueStr;
            
            this.sequenceNumber_ = serial_MessageHeader.SequenceNumber_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

