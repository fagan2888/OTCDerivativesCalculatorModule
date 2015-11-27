using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class CapFloorOptionViewModel : IXmlData
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
        
        public CapFloorOptionViewModel() { }
        
        #region CapOptionViewModel_
        private CapOptionViewModel capOptionViewModel_;
        public CapOptionViewModel CapOptionViewModel_
        {
            get { return this.capOptionViewModel_; }
            set
            {
                if (this.capOptionViewModel_ != value)
                {
                    this.capOptionViewModel_ = value;
                    this.NotifyPropertyChanged("CapOptionViewModel_");
                }
            }
        }
        #endregion
        
        #region FloorOptionViewModel_
        private FloorOptionViewModel floorOptionViewModel_;
        public FloorOptionViewModel FloorOptionViewModel_
        {
            get { return this.floorOptionViewModel_; }
            set
            {
                if (this.floorOptionViewModel_ != value)
                {
                    this.floorOptionViewModel_ = value;
                    this.NotifyPropertyChanged("FloorOptionViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "capFloorOption");
                xmlWriter.WriteStartElement("capFloorOption");
                    capOptionViewModel_.buildXml(xmlWriter);
                    
                    floorOptionViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new CapFloorOptionView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.CapFloorOption serial_CapFloorOption = serial_Class as FpmlSerializedCSharp.CapFloorOption;
        
            FpmlSerializedCSharp.CapOption serial_capOption = serial_CapFloorOption.CapOption_;
            string capOptiontype = serial_capOption.Excel_type_.ValueStr;
            this.capOptionViewModel_ = CapOptionViewModel.CreateCapOption(capOptiontype);
            this.capOptionViewModel_.setFromSerial(serial_capOption);
            
            FpmlSerializedCSharp.FloorOption serial_floorOption = serial_CapFloorOption.FloorOption_;
            string floorOptiontype = serial_floorOption.Excel_type_.ValueStr;
            this.floorOptionViewModel_ = FloorOptionViewModel.CreateFloorOption(floorOptiontype);
            this.floorOptionViewModel_.setFromSerial(serial_floorOption);
            
        }
        
        
    
            
            
            
            
        
    
        
    
    }
    
}

