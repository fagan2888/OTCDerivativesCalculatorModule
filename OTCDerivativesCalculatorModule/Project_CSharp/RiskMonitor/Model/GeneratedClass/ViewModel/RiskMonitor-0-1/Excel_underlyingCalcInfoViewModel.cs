using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_underlyingCalcInfoViewModel : IXmlData
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
        
        public Excel_underlyingCalcInfoViewModel() { }
        
        #region Excel_underlyingInfoViewModel_
        private ObservableCollection<Excel_underlyingInfoViewModel> excel_underlyingInfoViewModel_;
        public ObservableCollection<Excel_underlyingInfoViewModel> Excel_underlyingInfoViewModel_
        {
            get { return this.excel_underlyingInfoViewModel_; }
            set
            {
                if (this.excel_underlyingInfoViewModel_ != value)
                {
                    this.excel_underlyingInfoViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_underlyingInfoViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "excel_underlyingCalcInfo");
                xmlWriter.WriteStartElement("excel_underlyingCalcInfo");
                    foreach (var item in excel_underlyingInfoViewModel_)
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
            Control v = new Excel_underlyingCalcInfoView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_underlyingCalcInfo serial_Excel_underlyingCalcInfo = serial_Class as FpmlSerializedCSharp.Excel_underlyingCalcInfo;
        
            List<FpmlSerializedCSharp.Excel_underlyingInfo> serial_excel_underlyingInfo = serial_Excel_underlyingCalcInfo.Excel_underlyingInfo_;
            this.excel_underlyingInfoViewModel_ = new ObservableCollection<Excel_underlyingInfoViewModel>();
            foreach (var item in serial_excel_underlyingInfo)
            {
                string type = item.Excel_type_.ValueStr;
                Excel_underlyingInfoViewModel viewModel = Excel_underlyingInfoViewModel.CreateExcel_underlyingInfo(type);
                viewModel.setFromSerial(item);
                this.excel_underlyingInfoViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

