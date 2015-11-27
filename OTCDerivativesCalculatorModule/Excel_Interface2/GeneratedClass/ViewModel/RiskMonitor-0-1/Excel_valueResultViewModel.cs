using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_valueResultViewModel : IXmlData
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
        
        public Excel_valueResultViewModel() { }
        
        #region Excel_valueSideResultViewModel_
        private ObservableCollection<Excel_valueSideResultViewModel> excel_valueSideResultViewModel_;
        public ObservableCollection<Excel_valueSideResultViewModel> Excel_valueSideResultViewModel_
        {
            get { return this.excel_valueSideResultViewModel_; }
            set
            {
                if (this.excel_valueSideResultViewModel_ != value)
                {
                    this.excel_valueSideResultViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_valueSideResultViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "excel_valueResult");
                xmlWriter.WriteStartElement("excel_valueResult");
                    foreach (var item in excel_valueSideResultViewModel_)
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
            Control v = new Excel_valueResultView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_valueResult serial_Excel_valueResult = serial_Class as FpmlSerializedCSharp.Excel_valueResult;
        
            List<FpmlSerializedCSharp.Excel_valueSideResult> serial_excel_valueSideResult = serial_Excel_valueResult.Excel_valueSideResult_;
            this.excel_valueSideResultViewModel_ = new ObservableCollection<Excel_valueSideResultViewModel>();
            foreach (var item in serial_excel_valueSideResult)
            {
                string type = item.Excel_type_.ValueStr;
                Excel_valueSideResultViewModel viewModel = Excel_valueSideResultViewModel.CreateExcel_valueSideResult(type);
                viewModel.setFromSerial(item);
                this.excel_valueSideResultViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

