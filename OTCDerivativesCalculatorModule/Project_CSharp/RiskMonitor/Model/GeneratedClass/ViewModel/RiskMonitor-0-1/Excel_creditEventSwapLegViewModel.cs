using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_creditEventSwapLegViewModel : Excel_swapLegViewModel
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
        
        public Excel_creditEventSwapLegViewModel() { }
        
        #region Excel_creditEventInfoViewModel_
        private Excel_creditEventInfoViewModel excel_creditEventInfoViewModel_;
        public Excel_creditEventInfoViewModel Excel_creditEventInfoViewModel_
        {
            get { return this.excel_creditEventInfoViewModel_; }
            set
            {
                if (this.excel_creditEventInfoViewModel_ != value)
                {
                    this.excel_creditEventInfoViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_creditEventInfoViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_swapLeg");
                xmlWriter.WriteElementString("type" , "excel_creditEventSwapLeg");
                xmlWriter.WriteStartElement("excel_creditEventSwapLeg");
                    excel_creditEventInfoViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_creditEventSwapLegView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_swapLeg serial_Excel_swapLeg = serial_Class as FpmlSerializedCSharp.Excel_swapLeg;
            FpmlSerializedCSharp.Excel_creditEventSwapLeg serial_Excel_creditEventSwapLeg = serial_Excel_swapLeg.Excel_creditEventSwapLeg_;
        
            FpmlSerializedCSharp.Excel_creditEventInfo serial_excel_creditEventInfo = serial_Excel_creditEventSwapLeg.Excel_creditEventInfo_;
            string excel_creditEventInfotype = serial_excel_creditEventInfo.Excel_type_.ValueStr;
            this.excel_creditEventInfoViewModel_ = Excel_creditEventInfoViewModel.CreateExcel_creditEventInfo(excel_creditEventInfotype);
            this.excel_creditEventInfoViewModel_.setFromSerial(serial_excel_creditEventInfo);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

