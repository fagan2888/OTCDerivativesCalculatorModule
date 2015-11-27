using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public abstract class MessageBodyViewModel : IXmlData
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
        
        public MessageBodyViewModel() { }
        
        #region Msg_type_
        private string msg_type_;
        public string Msg_type_
        {
            get { return this.msg_type_; }
            set
            {
                if (this.msg_type_ != value)
                {
                    this.msg_type_ = value;
                    this.NotifyPropertyChanged("Msg_type_");
                }
            }
        }
        #endregion

        public string InnerXml_;
        
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
        public static MessageBodyViewModel CreateMessageBody(string typeStr)
        {
            if ( typeStr.ToUpper() == "GRIDCALCULATION")
            {
                return new GridCalculationViewModel();
            }
            else if (typeStr.ToUpper() == "MATURITYNOTIFICATION")
            {
                return new MaturityNotificationViewModel();
            }
            else if (typeStr.ToUpper() == "GRIDCALCULATIONSTART")
            {
                return new GridCalculationStartViewModel();
            }

            else
            {
            throw new NotImplementedException();
            }
        }

        public void setFromXml(XmlNode InstNode)
        {
            throw new NotImplementedException();
        }
    }
    
}

