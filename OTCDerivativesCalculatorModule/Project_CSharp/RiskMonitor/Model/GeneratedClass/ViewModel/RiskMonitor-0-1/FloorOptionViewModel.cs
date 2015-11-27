using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class FloorOptionViewModel : IXmlData
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
        
        public FloorOptionViewModel() { }
        
        #region ReferenceStr_
        private string referenceStr_;
        public string ReferenceStr_
        {
            get { return this.referenceStr_; }
            set
            {
                if (this.referenceStr_ != value)
                {
                    this.referenceStr_ = value;
                    this.NotifyPropertyChanged("ReferenceStr_");
                }
            }
        }
        #endregion
        
        #region FloorRate_
        private string floorRate_;
        public string FloorRate_
        {
            get { return this.floorRate_; }
            set
            {
                if (this.floorRate_ != value)
                {
                    this.floorRate_ = value;
                    this.NotifyPropertyChanged("FloorRate_");
                }
            }
        }
        #endregion
        
        #region Vol_
        private string vol_;
        public string Vol_
        {
            get { return this.vol_; }
            set
            {
                if (this.vol_ != value)
                {
                    this.vol_ = value;
                    this.NotifyPropertyChanged("Vol_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "floorOption");
                xmlWriter.WriteStartElement("floorOption");
                    xmlWriter.WriteElementString("referenceStr" , this.referenceStr_);
                    
                    xmlWriter.WriteElementString("floorRate" , this.floorRate_);
                    
                    xmlWriter.WriteElementString("vol" , this.vol_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new FloorOptionView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.FloorOption serial_FloorOption = serial_Class as FpmlSerializedCSharp.FloorOption;
        
            this.referenceStr_ = serial_FloorOption.ReferenceStr_.ValueStr;
            
            this.floorRate_ = serial_FloorOption.FloorRate_.ValueStr;
            
            this.vol_ = serial_FloorOption.Vol_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

