using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_underlyingCalcInfo_paraViewModel : IXmlData
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
        
        public Excel_underlyingCalcInfo_paraViewModel() { }
        
        #region Excel_underlyingInfo_paraViewModel_
        private ObservableCollection<Excel_underlyingInfo_paraViewModel> excel_underlyingInfo_paraViewModel_;
        public ObservableCollection<Excel_underlyingInfo_paraViewModel> Excel_underlyingInfo_paraViewModel_
        {
            get { return this.excel_underlyingInfo_paraViewModel_; }
            set
            {
                if (this.excel_underlyingInfo_paraViewModel_ != value)
                {
                    this.excel_underlyingInfo_paraViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_underlyingInfo_paraViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_correlationInfo_paraViewModel_
        private Excel_correlationInfo_paraViewModel excel_correlationInfo_paraViewModel_;
        public Excel_correlationInfo_paraViewModel Excel_correlationInfo_paraViewModel_
        {
            get { return this.excel_correlationInfo_paraViewModel_; }
            set
            {
                if (this.excel_correlationInfo_paraViewModel_ != value)
                {
                    this.excel_correlationInfo_paraViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_correlationInfo_paraViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "excel_underlyingCalcInfo_para");
                xmlWriter.WriteStartElement("excel_underlyingCalcInfo_para");
                    foreach (var item in excel_underlyingInfo_paraViewModel_)
                    {
                        item.buildXml(xmlWriter);
                    }
                    
                    excel_correlationInfo_paraViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new Excel_underlyingCalcInfo_paraView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_underlyingCalcInfo_para serial_Excel_underlyingCalcInfo_para = serial_Class as FpmlSerializedCSharp.Excel_underlyingCalcInfo_para;
        
            List<FpmlSerializedCSharp.Excel_underlyingInfo_para> serial_excel_underlyingInfo_para = serial_Excel_underlyingCalcInfo_para.Excel_underlyingInfo_para_;
            this.excel_underlyingInfo_paraViewModel_ = new ObservableCollection<Excel_underlyingInfo_paraViewModel>();
            foreach (var item in serial_excel_underlyingInfo_para)
            {
                string type = item.Excel_type_.ValueStr;
                Excel_underlyingInfo_paraViewModel viewModel = Excel_underlyingInfo_paraViewModel.CreateExcel_underlyingInfo_para(type);
                viewModel.setFromSerial(item);
                this.excel_underlyingInfo_paraViewModel_.Add(viewModel);
            }
            
            FpmlSerializedCSharp.Excel_correlationInfo_para serial_excel_correlationInfo_para = serial_Excel_underlyingCalcInfo_para.Excel_correlationInfo_para_;
            string excel_correlationInfo_paratype = serial_excel_correlationInfo_para.Excel_type_.ValueStr;
            this.excel_correlationInfo_paraViewModel_ = Excel_correlationInfo_paraViewModel.CreateExcel_correlationInfo_para(excel_correlationInfo_paratype);
            this.excel_correlationInfo_paraViewModel_.setFromSerial(serial_excel_correlationInfo_para);
            
        }
        
        
    
            
            
            
            
        
    
        
    
    }
    
}

