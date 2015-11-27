using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_referenceCalcInfo_paraViewModel : IXmlData
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
        
        public Excel_referenceCalcInfo_paraViewModel() { }
        
        #region Excel_referenceInfo_paraViewModel_
        private ObservableCollection<Excel_referenceInfo_paraViewModel> excel_referenceInfo_paraViewModel_;
        public ObservableCollection<Excel_referenceInfo_paraViewModel> Excel_referenceInfo_paraViewModel_
        {
            get { return this.excel_referenceInfo_paraViewModel_; }
            set
            {
                if (this.excel_referenceInfo_paraViewModel_ != value)
                {
                    this.excel_referenceInfo_paraViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_referenceInfo_paraViewModel_");
                }
            }
        }
        #endregion
        
        #region Coupula_correlation_
        private string coupula_correlation_;
        public string Coupula_correlation_
        {
            get { return this.coupula_correlation_; }
            set
            {
                if (this.coupula_correlation_ != value)
                {
                    this.coupula_correlation_ = value;
                    this.NotifyPropertyChanged("Coupula_correlation_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "excel_referenceCalcInfo_para");
                xmlWriter.WriteStartElement("excel_referenceCalcInfo_para");
                    foreach (var item in excel_referenceInfo_paraViewModel_)
                    {
                        item.buildXml(xmlWriter);
                    }
                    
                    xmlWriter.WriteElementString("coupula_correlation" , this.coupula_correlation_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new Excel_referenceCalcInfo_paraView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_referenceCalcInfo_para serial_Excel_referenceCalcInfo_para = serial_Class as FpmlSerializedCSharp.Excel_referenceCalcInfo_para;
        
            List<FpmlSerializedCSharp.Excel_referenceInfo_para> serial_excel_referenceInfo_para = serial_Excel_referenceCalcInfo_para.Excel_referenceInfo_para_;
            this.excel_referenceInfo_paraViewModel_ = new ObservableCollection<Excel_referenceInfo_paraViewModel>();
            foreach (var item in serial_excel_referenceInfo_para)
            {
                string type = item.Excel_type_.ValueStr;
                Excel_referenceInfo_paraViewModel viewModel = Excel_referenceInfo_paraViewModel.CreateExcel_referenceInfo_para(type);
                viewModel.setFromSerial(item);
                this.excel_referenceInfo_paraViewModel_.Add(viewModel);
            }
            
            this.coupula_correlation_ = serial_Excel_referenceCalcInfo_para.Coupula_correlation_.ValueStr;
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

