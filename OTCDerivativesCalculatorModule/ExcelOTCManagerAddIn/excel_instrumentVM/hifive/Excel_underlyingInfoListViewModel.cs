using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class Excel_underlyingInfoListViewModel : IXmlData
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
        
    
        public Excel_underlyingInfoListViewModel() { }
        
    
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
                xmlWriter.WriteElementString("type" , "excel_underlyingInfoList");
                xmlWriter.WriteStartElement("excel_underlyingInfoList");
                    excel_underlyingInfoViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_underlyingInfoList serial_Excel_underlyingInfoList = serial_Class as FpmlSerializedCSharp.Excel_underlyingInfoList;
        
            List<FpmlSerializedCSharp.Excel_underlyingInfo> serial_excel_underlyingInfo = serial_Excel_underlyingInfoList.Excel_underlyingInfo_;
            this.excel_underlyingInfoViewModel_ = new ObservableCollection<Excel_underlyingInfoViewModel>();
            foreach (var item in serial_excel_underlyingInfo)
            {
                string type = item.Type_.ValueStr;
                Excel_underlyingInfoViewModel viewModel = Excel_underlyingInfoViewModel.CreateExcel_underlyingInfo(type);
                viewModel.setFromSerial(item);
                this.excel_underlyingInfoViewModel_.Add(viewModel);
            }
            
            this.view_ = new Excel_underlyingInfoListView();
            this.view_.DataContext = this;
        }
        
        
    
            #region SelectExcel_underlyingInfoInfo_
            private string selectExcel_underlyingInfoInfo_;
            public string SelectExcel_underlyingInfoInfo_
            {
                get { return this.selectExcel_underlyingInfoInfo_; }
                set
                {
                    if (this.selectExcel_underlyingInfoInfo_ != value)
                    {
                        this.selectExcel_underlyingInfoInfo_ = value;
                        this.NotifyPropertyChanged("SelectExcel_underlyingInfoInfo_");
                    }
                }
            }
            #endregion
            
            public void selectExcel_underlyingInfoInfo(string typeStr)
            {
                this.excel_underlyingInfoViewModel_ = Excel_underlyingInfoViewModel.CreateExcel_underlyingInfo(typeStr);
                this.view_.DataContext = this;
            }
            
        
    
        
    
    }
    
}

