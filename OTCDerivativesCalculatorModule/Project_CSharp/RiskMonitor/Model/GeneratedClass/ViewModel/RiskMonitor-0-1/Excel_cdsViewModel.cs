using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_cdsViewModel : Excel_swapInterfaceViewModel
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
        
        public Excel_cdsViewModel() { }
        
        #region Excel_swapLegViewModel_
        private Excel_swapLegViewModel excel_swapLegViewModel_;
        public Excel_swapLegViewModel Excel_swapLegViewModel_
        {
            get { return this.excel_swapLegViewModel_; }
            set
            {
                if (this.excel_swapLegViewModel_ != value)
                {
                    this.excel_swapLegViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_swapLegViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_creditEventSwapLegViewModel_
        private Excel_creditEventSwapLegViewModel excel_creditEventSwapLegViewModel_;
        public Excel_creditEventSwapLegViewModel Excel_creditEventSwapLegViewModel_
        {
            get { return this.excel_creditEventSwapLegViewModel_; }
            set
            {
                if (this.excel_creditEventSwapLegViewModel_ != value)
                {
                    this.excel_creditEventSwapLegViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_creditEventSwapLegViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_swapInterface");
                xmlWriter.WriteElementString("type" , "excel_cds");
                xmlWriter.WriteStartElement("excel_cds");
                    excel_swapLegViewModel_.buildXml(xmlWriter);
                    
                    excel_creditEventSwapLegViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_cdsView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_swapInterface serial_Excel_swapInterface = serial_Class as FpmlSerializedCSharp.Excel_swapInterface;
            FpmlSerializedCSharp.Excel_cds serial_Excel_cds = serial_Excel_swapInterface.Excel_cds_;
        
            FpmlSerializedCSharp.Excel_swapLeg serial_excel_swapLeg = serial_Excel_cds.Excel_swapLeg_;
            string excel_swapLegtype = serial_excel_swapLeg.Excel_type_.ValueStr;
            this.excel_swapLegViewModel_ = Excel_swapLegViewModel.CreateExcel_swapLeg(excel_swapLegtype);
            this.excel_swapLegViewModel_.setFromSerial(serial_excel_swapLeg);
            
            FpmlSerializedCSharp.Excel_creditEventSwapLeg serial_excel_creditEventSwapLeg = serial_Excel_cds.Excel_creditEventSwapLeg_;
            string excel_creditEventSwapLegtype = serial_excel_creditEventSwapLeg.Excel_type_.ValueStr;
            this.excel_creditEventSwapLegViewModel_ = Excel_creditEventSwapLegViewModel.CreateExcel_creditEventSwapLeg(excel_creditEventSwapLegtype);
            this.excel_creditEventSwapLegViewModel_.setFromSerial(serial_excel_creditEventSwapLeg);
            
        }
        
        
    
            
            
            
            
        
    
        
    
    }
    
}

