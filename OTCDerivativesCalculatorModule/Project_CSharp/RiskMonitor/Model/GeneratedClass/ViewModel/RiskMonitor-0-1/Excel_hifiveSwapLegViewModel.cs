using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_hifiveSwapLegViewModel : Excel_swapLegViewModel
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
        
        public Excel_hifiveSwapLegViewModel() { }
        
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
        
        #region Excel_hifiveViewModel_
        private Excel_hifiveViewModel excel_hifiveViewModel_;
        public Excel_hifiveViewModel Excel_hifiveViewModel_
        {
            get { return this.excel_hifiveViewModel_; }
            set
            {
                if (this.excel_hifiveViewModel_ != value)
                {
                    this.excel_hifiveViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_hifiveViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_swapLeg");
                xmlWriter.WriteElementString("type" , "excel_hifiveSwapLeg");
                xmlWriter.WriteStartElement("excel_hifiveSwapLeg");
                    excel_swapLegInfoViewModel_.buildXml(xmlWriter);
                    
                    excel_hifiveViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_hifiveSwapLegView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_swapLeg serial_Excel_swapLeg = serial_Class as FpmlSerializedCSharp.Excel_swapLeg;
            FpmlSerializedCSharp.Excel_hifiveSwapLeg serial_Excel_hifiveSwapLeg = serial_Excel_swapLeg.Excel_hifiveSwapLeg_;
        
            FpmlSerializedCSharp.Excel_swapLegInfo serial_excel_swapLegInfo = serial_Excel_hifiveSwapLeg.Excel_swapLegInfo_;
            string excel_swapLegInfotype = serial_excel_swapLegInfo.Excel_type_.ValueStr;
            this.excel_swapLegInfoViewModel_ = Excel_swapLegInfoViewModel.CreateExcel_swapLegInfo(excel_swapLegInfotype);
            this.excel_swapLegInfoViewModel_.setFromSerial(serial_excel_swapLegInfo);
            
            FpmlSerializedCSharp.Excel_hifive serial_excel_hifive = serial_Excel_hifiveSwapLeg.Excel_hifive_;
            string excel_hifivetype = serial_excel_hifive.Excel_type_.ValueStr;
            this.excel_hifiveViewModel_ = Excel_hifiveViewModel.CreateExcel_hifive(excel_hifivetype);
            this.excel_hifiveViewModel_.setFromSerial(serial_excel_hifive);
            
        }
        
        
    
            
            
            
            
        
    
        
    
    }
    
}

