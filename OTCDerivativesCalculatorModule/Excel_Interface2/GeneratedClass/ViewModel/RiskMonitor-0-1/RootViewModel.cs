using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class RootViewModel : IXmlData
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
        
        public RootViewModel() { }
        
        #region InstrumentViewModel_
        private InstrumentViewModel instrumentViewModel_;
        public InstrumentViewModel InstrumentViewModel_
        {
            get { return this.instrumentViewModel_; }
            set
            {
                if (this.instrumentViewModel_ != value)
                {
                    this.instrumentViewModel_ = value;
                    this.NotifyPropertyChanged("InstrumentViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "root");
                xmlWriter.WriteStartElement("root");
                    instrumentViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new RootView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Root serial_Root = serial_Class as FpmlSerializedCSharp.Root;
        
            FpmlSerializedCSharp.Instrument serial_instrument = serial_Root.Instrument_;
            string instrumenttype = serial_instrument.Excel_type_.ValueStr;
            this.instrumentViewModel_ = InstrumentViewModel.CreateInstrument(instrumenttype);
            this.instrumentViewModel_.setFromSerial(serial_instrument);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

