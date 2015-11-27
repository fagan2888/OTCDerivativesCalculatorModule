using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class BarrierDateInfoViewModel : IXmlData
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
        
        public BarrierDateInfoViewModel() { }
        
        #region DateInformationViewModel_
        private DateInformationViewModel dateInformationViewModel_;
        public DateInformationViewModel DateInformationViewModel_
        {
            get { return this.dateInformationViewModel_; }
            set
            {
                if (this.dateInformationViewModel_ != value)
                {
                    this.dateInformationViewModel_ = value;
                    this.NotifyPropertyChanged("DateInformationViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "barrierDateInfo");
                xmlWriter.WriteStartElement("barrierDateInfo");
                    dateInformationViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new BarrierDateInfoView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.BarrierDateInfo serial_BarrierDateInfo = serial_Class as FpmlSerializedCSharp.BarrierDateInfo;
        
            FpmlSerializedCSharp.DateInformation serial_dateInformation = serial_BarrierDateInfo.DateInformation_;
            string dateInformationtype = serial_dateInformation.Excel_type_.ValueStr;
            this.dateInformationViewModel_ = DateInformationViewModel.CreateDateInformation(dateInformationtype);
            this.dateInformationViewModel_.setFromSerial(serial_dateInformation);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

