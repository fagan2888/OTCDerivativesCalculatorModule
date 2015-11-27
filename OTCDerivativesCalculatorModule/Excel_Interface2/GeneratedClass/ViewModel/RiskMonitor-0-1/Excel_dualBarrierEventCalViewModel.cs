using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_dualBarrierEventCalViewModel : Excel_eventCalcInfoViewModel
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
        
        public Excel_dualBarrierEventCalViewModel() { }
        
        #region LowerRng_
        private string lowerRng_;
        public string LowerRng_
        {
            get { return this.lowerRng_; }
            set
            {
                if (this.lowerRng_ != value)
                {
                    this.lowerRng_ = value;
                    this.NotifyPropertyChanged("LowerRng_");
                }
            }
        }
        #endregion
        
        #region UpperRng_
        private string upperRng_;
        public string UpperRng_
        {
            get { return this.upperRng_; }
            set
            {
                if (this.upperRng_ != value)
                {
                    this.upperRng_ = value;
                    this.NotifyPropertyChanged("UpperRng_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_eventCalcInfo");
                xmlWriter.WriteElementString("excel_type" , "excel_dualBarrierEventCal");
                xmlWriter.WriteStartElement("excel_dualBarrierEventCal");
                    xmlWriter.WriteElementString("lowerRng" , this.lowerRng_);
                    
                    xmlWriter.WriteElementString("upperRng" , this.upperRng_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_dualBarrierEventCalView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_eventCalcInfo serial_Excel_eventCalcInfo = serial_Class as FpmlSerializedCSharp.Excel_eventCalcInfo;
            FpmlSerializedCSharp.Excel_dualBarrierEventCal serial_Excel_dualBarrierEventCal = serial_Excel_eventCalcInfo.Excel_dualBarrierEventCal_;
        
            this.lowerRng_ = serial_Excel_dualBarrierEventCal.LowerRng_.ValueStr;
            
            this.upperRng_ = serial_Excel_dualBarrierEventCal.UpperRng_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

