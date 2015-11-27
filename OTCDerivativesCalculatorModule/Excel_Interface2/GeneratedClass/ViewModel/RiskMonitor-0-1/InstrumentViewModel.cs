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
        
        #region Code_
        private string code_;
        public string Code_
        {
            get { return this.code_; }
            set
            {
                if (this.code_ != value)
                {
                    this.code_ = value;
                    this.NotifyPropertyChanged("Code_");
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
        
        #region Excel_swapInterfaceViewModel_
        private Excel_swapInterfaceViewModel excel_swapInterfaceViewModel_;
        public Excel_swapInterfaceViewModel Excel_swapInterfaceViewModel_
        {
            get { return this.excel_swapInterfaceViewModel_; }
            set
            {
                if (this.excel_swapInterfaceViewModel_ != value)
                {
                    this.excel_swapInterfaceViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_swapInterfaceViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "instrument");
                xmlWriter.WriteStartElement("instrument");
                    xmlWriter.WriteElementString("code" , this.code_);
                    
                    excel_interfaceViewModel_.buildXml(xmlWriter);
                    
                    excel_swapInterfaceViewModel_.buildXml(xmlWriter);
                    
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
        
            this.code_ = serial_Instrument.Code_.ValueStr;
            
            FpmlSerializedCSharp.Excel_interface serial_excel_interface = serial_Instrument.Excel_interface_;
            string excel_interfacetype = serial_excel_interface.Excel_type_.ValueStr;
            this.excel_interfaceViewModel_ = Excel_interfaceViewModel.CreateExcel_interface(excel_interfacetype);
            this.excel_interfaceViewModel_.setFromSerial(serial_excel_interface);
            
            FpmlSerializedCSharp.Excel_swapInterface serial_excel_swapInterface = serial_Instrument.Excel_swapInterface_;
            string excel_swapInterfacetype = serial_excel_swapInterface.Excel_type_.ValueStr;
            this.excel_swapInterfaceViewModel_ = Excel_swapInterfaceViewModel.CreateExcel_swapInterface(excel_swapInterfacetype);
            this.excel_swapInterfaceViewModel_.setFromSerial(serial_excel_swapInterface);
            
        }
        
        
    
            
            
            
            
        
    
        
    
    }
    
}

