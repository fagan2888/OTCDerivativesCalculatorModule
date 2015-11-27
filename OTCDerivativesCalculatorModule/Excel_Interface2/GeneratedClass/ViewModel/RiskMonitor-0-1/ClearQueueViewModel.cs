using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class ClearQueueViewModel : MessageBodyViewModel
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
        
        public ClearQueueViewModel() { }
        
        #region ActionType_
        private string actionType_;
        public string ActionType_
        {
            get { return this.actionType_; }
            set
            {
                if (this.actionType_ != value)
                {
                    this.actionType_ = value;
                    this.NotifyPropertyChanged("ActionType_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("messageBody");
                xmlWriter.WriteElementString("excel_type" , "clearQueue");
                xmlWriter.WriteStartElement("clearQueue");
                    xmlWriter.WriteElementString("actionType" , this.actionType_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new ClearQueueView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.MessageBody serial_MessageBody = serial_Class as FpmlSerializedCSharp.MessageBody;
            FpmlSerializedCSharp.ClearQueue serial_ClearQueue = serial_MessageBody.ClearQueue_;
        
            this.actionType_ = serial_ClearQueue.ActionType_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

