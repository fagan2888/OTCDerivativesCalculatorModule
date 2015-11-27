using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_structuredSwapLegViewModel : Excel_swapLegViewModel
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
        
        public Excel_structuredSwapLegViewModel() { }
        
        #region Excel_swapLegInfoViewModel_
        private Excel_swapLegInfoViewModel excel_swapLegInfoViewModel_;
        public Excel_swapLegInfoViewModel Excel_swapLegInfoViewModel_
        {
            get { return this.excel_swapLegInfoViewModel_; }
            set
            {
                if (this.excel_swapLegInfoViewModel_ != value)
                {
                    this.excel_swapLegInfoViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_swapLegInfoViewModel_");
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
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_swapLeg");
                xmlWriter.WriteElementString("excel_type" , "excel_structuredSwapLeg");
                xmlWriter.WriteStartElement("excel_structuredSwapLeg");
                    excel_swapLegInfoViewModel_.buildXml(xmlWriter);
                    
                    excel_interfaceViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_structuredSwapLegView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_swapLeg serial_Excel_swapLeg = serial_Class as FpmlSerializedCSharp.Excel_swapLeg;
            FpmlSerializedCSharp.Excel_structuredSwapLeg serial_Excel_structuredSwapLeg = serial_Excel_swapLeg.Excel_structuredSwapLeg_;
        
            FpmlSerializedCSharp.Excel_swapLegInfo serial_excel_swapLegInfo = serial_Excel_structuredSwapLeg.Excel_swapLegInfo_;
            string excel_swapLegInfotype = serial_excel_swapLegInfo.Excel_type_.ValueStr;
            this.excel_swapLegInfoViewModel_ = Excel_swapLegInfoViewModel.CreateExcel_swapLegInfo(excel_swapLegInfotype);
            this.excel_swapLegInfoViewModel_.setFromSerial(serial_excel_swapLegInfo);
            
            FpmlSerializedCSharp.Excel_interface serial_excel_interface = serial_Excel_structuredSwapLeg.Excel_interface_;
            string excel_interfacetype = serial_excel_interface.Excel_type_.ValueStr;
            this.excel_interfaceViewModel_ = Excel_interfaceViewModel.CreateExcel_interface(excel_interfacetype);
            this.excel_interfaceViewModel_.setFromSerial(serial_excel_interface);
            
        }
        
        
    
            
            
            
            
        
    
        
    
    }
    
}

