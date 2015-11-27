using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_defaultCurve_paraViewModel : IXmlData
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
        
        public Excel_defaultCurve_paraViewModel() { }
        
        #region Excel_defaultCurveViewModel_
        private ObservableCollection<Excel_defaultCurveViewModel> excel_defaultCurveViewModel_;
        public ObservableCollection<Excel_defaultCurveViewModel> Excel_defaultCurveViewModel_
        {
            get { return this.excel_defaultCurveViewModel_; }
            set
            {
                if (this.excel_defaultCurveViewModel_ != value)
                {
                    this.excel_defaultCurveViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_defaultCurveViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "excel_defaultCurve_para");
                xmlWriter.WriteStartElement("excel_defaultCurve_para");
                    foreach (var item in excel_defaultCurveViewModel_)
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
            Control v = new Excel_defaultCurve_paraView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_defaultCurve_para serial_Excel_defaultCurve_para = serial_Class as FpmlSerializedCSharp.Excel_defaultCurve_para;
        
            List<FpmlSerializedCSharp.Excel_defaultCurve> serial_excel_defaultCurve = serial_Excel_defaultCurve_para.Excel_defaultCurve_;
            this.excel_defaultCurveViewModel_ = new ObservableCollection<Excel_defaultCurveViewModel>();
            foreach (var item in serial_excel_defaultCurve)
            {
                string type = item.Excel_type_.ValueStr;
                Excel_defaultCurveViewModel viewModel = Excel_defaultCurveViewModel.CreateExcel_defaultCurve(type);
                viewModel.setFromSerial(item);
                this.excel_defaultCurveViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

