using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class InstrumentViewModel : IXmlData
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
        
        public InstrumentViewModel() { }
        
        #region HeaderViewModel_
        private HeaderViewModel headerViewModel_;
        public HeaderViewModel HeaderViewModel_
        {
            get { return this.headerViewModel_; }
            set
            {
                if (this.headerViewModel_ != value)
                {
                    this.headerViewModel_ = value;
                    this.NotifyPropertyChanged("HeaderViewModel_");
                }
            }
        }
        #endregion
        
        #region InstPositionInfoViewModel_
        private InstPositionInfoViewModel instPositionInfoViewModel_;
        public InstPositionInfoViewModel InstPositionInfoViewModel_
        {
            get { return this.instPositionInfoViewModel_; }
            set
            {
                if (this.instPositionInfoViewModel_ != value)
                {
                    this.instPositionInfoViewModel_ = value;
                    this.NotifyPropertyChanged("InstPositionInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_interfaceViewModel_
        private Excel_interfaceViewModel excel_interfaceViewModel_;
        public Excel_interfaceViewModel Excel_interfaceViewModel_
        {
            get { return this.excel_interfaceViewModel_; }
            set
            {
                if (this.excel_interfaceViewModel_ != value)
                {
                    this.excel_interfaceViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_interfaceViewModel_");
                }
            }
        }
        #endregion
        
        #region InstrumentInfoViewModel_
        private InstrumentInfoViewModel instrumentInfoViewModel_;
        public InstrumentInfoViewModel InstrumentInfoViewModel_
        {
            get { return this.instrumentInfoViewModel_; }
            set
            {
                if (this.instrumentInfoViewModel_ != value)
                {
                    this.instrumentInfoViewModel_ = value;
                    this.NotifyPropertyChanged("InstrumentInfoViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "instrument");
                xmlWriter.WriteStartElement("instrument");
                    headerViewModel_.buildXml(xmlWriter);
                    
                    instPositionInfoViewModel_.buildXml(xmlWriter);
                    
                    excel_interfaceViewModel_.buildXml(xmlWriter);
                    
                    instrumentInfoViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new InstrumentView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Instrument serial_Instrument = serial_Class as FpmlSerializedCSharp.Instrument;
        
            FpmlSerializedCSharp.Header serial_header = serial_Instrument.Header_;
            string headertype = serial_header.Excel_type_.ValueStr;
            this.headerViewModel_ = HeaderViewModel.CreateHeader(headertype);
            this.headerViewModel_.setFromSerial(serial_header);
            
            FpmlSerializedCSharp.InstPositionInfo serial_instPositionInfo = serial_Instrument.InstPositionInfo_;
            string instPositionInfotype = serial_instPositionInfo.Excel_type_.ValueStr;
            this.instPositionInfoViewModel_ = InstPositionInfoViewModel.CreateInstPositionInfo(instPositionInfotype);
            this.instPositionInfoViewModel_.setFromSerial(serial_instPositionInfo);
            
            FpmlSerializedCSharp.Excel_interface serial_excel_interface = serial_Instrument.Excel_interface_;
            string excel_interfacetype = serial_excel_interface.Excel_type_.ValueStr;
            this.excel_interfaceViewModel_ = Excel_interfaceViewModel.CreateExcel_interface(excel_interfacetype);
            this.excel_interfaceViewModel_.setFromSerial(serial_excel_interface);
            
            FpmlSerializedCSharp.InstrumentInfo serial_instrumentInfo = serial_Instrument.InstrumentInfo_;
            string instrumentInfotype = serial_instrumentInfo.Excel_type_.ValueStr;
            this.instrumentInfoViewModel_ = InstrumentInfoViewModel.CreateInstrumentInfo(instrumentInfotype);
            this.instrumentInfoViewModel_.setFromSerial(serial_instrumentInfo);
            
        }
        
        
    
            
            
            
            
            
            
            
            
        
    
        
    
    }
    
}

