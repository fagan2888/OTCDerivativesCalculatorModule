using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_correlationInfo_paraViewModel : IXmlData
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
        
        public Excel_correlationInfo_paraViewModel() { }
        
        #region Dimension_
        private string dimension_;
        public string Dimension_
        {
            get { return this.dimension_; }
            set
            {
                if (this.dimension_ != value)
                {
                    this.dimension_ = value;
                    this.NotifyPropertyChanged("Dimension_");
                }
            }
        }
        #endregion
        
        #region Excel_correlation_paraViewModel_
        private ObservableCollection<Excel_correlation_paraViewModel> excel_correlation_paraViewModel_;
        public ObservableCollection<Excel_correlation_paraViewModel> Excel_correlation_paraViewModel_
        {
            get { return this.excel_correlation_paraViewModel_; }
            set
            {
                if (this.excel_correlation_paraViewModel_ != value)
                {
                    this.excel_correlation_paraViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_correlation_paraViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "excel_correlationInfo_para");
                xmlWriter.WriteStartElement("excel_correlationInfo_para");
                    xmlWriter.WriteElementString("dimension" , this.dimension_);
                    
                    foreach (var item in excel_correlation_paraViewModel_)
                    {
                        item.buildXml(xmlWriter);
                    }
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new Excel_correlationInfo_paraView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_correlationInfo_para serial_Excel_correlationInfo_para = serial_Class as FpmlSerializedCSharp.Excel_correlationInfo_para;
        
            this.dimension_ = serial_Excel_correlationInfo_para.Dimension_.ValueStr;
            
            List<FpmlSerializedCSharp.Excel_correlation_para> serial_excel_correlation_para = serial_Excel_correlationInfo_para.Excel_correlation_para_;
            this.excel_correlation_paraViewModel_ = new ObservableCollection<Excel_correlation_paraViewModel>();
            foreach (var item in serial_excel_correlation_para)
            {
                string type = item.Excel_type_.ValueStr;
                Excel_correlation_paraViewModel viewModel = Excel_correlation_paraViewModel.CreateExcel_correlation_para(type);
                viewModel.setFromSerial(item);
                this.excel_correlation_paraViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

