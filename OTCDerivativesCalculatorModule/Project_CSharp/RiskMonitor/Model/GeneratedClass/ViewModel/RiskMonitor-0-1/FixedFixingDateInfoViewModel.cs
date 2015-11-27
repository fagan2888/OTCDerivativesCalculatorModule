using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class FixedFixingDateInfoViewModel : FixingDateInfoViewModel
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
        
        public FixedFixingDateInfoViewModel() { }
        
        #region Date_
        private string date_;
        public string Date_
        {
            get { return this.date_; }
            set
            {
                if (this.date_ != value)
                {
                    this.date_ = value;
                    this.NotifyPropertyChanged("Date_");
                }
            }
        }
        #endregion
        
        #region AutoCallFlag_
        private string autoCallFlag_;
        public string AutoCallFlag_
        {
            get { return this.autoCallFlag_; }
            set
            {
                if (this.autoCallFlag_ != value)
                {
                    this.autoCallFlag_ = value;
                    this.NotifyPropertyChanged("AutoCallFlag_");
                }
            }
        }
        #endregion
        
        #region AutoCallFixingDate_
        private DateTime autoCallFixingDate_;
        public DateTime AutoCallFixingDate_
        {
            get { return this.autoCallFixingDate_; }
            set
            {
                if (this.autoCallFixingDate_ != value)
                {
                    this.autoCallFixingDate_ = value;
                    this.NotifyPropertyChanged("AutoCallFixingDate_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("fixingDateInfo");
                xmlWriter.WriteElementString("type" , "fixedFixingDateInfo");
                xmlWriter.WriteStartElement("fixedFixingDateInfo");
                    xmlWriter.WriteElementString("date" , this.date_);
                    
                    xmlWriter.WriteElementString("autoCallFlag" , this.autoCallFlag_);
                    
                    xmlWriter.WriteElementString("autoCallFixingDate" , StringConverter.xmlDateTimeToDateString(this.autoCallFixingDate_));
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new FixedFixingDateInfoView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.FixingDateInfo serial_FixingDateInfo = serial_Class as FpmlSerializedCSharp.FixingDateInfo;
            FpmlSerializedCSharp.FixedFixingDateInfo serial_FixedFixingDateInfo = serial_FixingDateInfo.FixedFixingDateInfo_;
        
            this.date_ = serial_FixedFixingDateInfo.Date_.ValueStr;
            
            this.autoCallFlag_ = serial_FixedFixingDateInfo.AutoCallFlag_.ValueStr;
            
            this.autoCallFixingDate_ = StringConverter.xmlDateToDateTime(serial_FixedFixingDateInfo.AutoCallFixingDate_.ValueStr);
            
        }
        
        
    
        
    
        
    
    }
    
}

