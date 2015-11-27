using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_discountCurve_paraViewModel : IXmlData
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
        
        public Excel_discountCurve_paraViewModel() { }
        
        #region Excel_yieldCurveViewModel_
        private ObservableCollection<Excel_yieldCurveViewModel> excel_yieldCurveViewModel_;
        public ObservableCollection<Excel_yieldCurveViewModel> Excel_yieldCurveViewModel_
        {
            get { return this.excel_yieldCurveViewModel_; }
            set
            {
                if (this.excel_yieldCurveViewModel_ != value)
                {
                    this.excel_yieldCurveViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_yieldCurveViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "excel_discountCurve_para");
                xmlWriter.WriteStartElement("excel_discountCurve_para");
                    foreach (var item in excel_yieldCurveViewModel_)
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
            Control v = new Excel_discountCurve_paraView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_discountCurve_para serial_Excel_discountCurve_para = serial_Class as FpmlSerializedCSharp.Excel_discountCurve_para;
        
            List<FpmlSerializedCSharp.Excel_yieldCurve> serial_excel_yieldCurve = serial_Excel_discountCurve_para.Excel_yieldCurve_;
            this.excel_yieldCurveViewModel_ = new ObservableCollection<Excel_yieldCurveViewModel>();
            foreach (var item in serial_excel_yieldCurve)
            {
                string type = item.Excel_type_.ValueStr;
                Excel_yieldCurveViewModel viewModel = Excel_yieldCurveViewModel.CreateExcel_yieldCurve(type);
                viewModel.setFromSerial(item);
                this.excel_yieldCurveViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

