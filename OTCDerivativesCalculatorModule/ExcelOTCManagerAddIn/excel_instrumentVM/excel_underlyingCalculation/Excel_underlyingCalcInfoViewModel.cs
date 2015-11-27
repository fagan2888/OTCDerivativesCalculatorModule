using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
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
        
        // 단지 underlying 이 이떤게 사용되는지에 대한 정보
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
        
        #region Excel_underlyingCalcIDViewModel_
        private ObservableCollection<Excel_underlyingCalcIDViewModel> excel_underlyingCalcIDViewModel_;
        public ObservableCollection<Excel_underlyingCalcIDViewModel> Excel_underlyingCalcIDViewModel_
        {
            get { return this.excel_underlyingCalcIDViewModel_; }
            set
            {
                if (this.excel_underlyingCalcIDViewModel_ != value)
                {
                    this.excel_underlyingCalcIDViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_underlyingCalcIDViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "excel_underlyingCalcInfo");
                xmlWriter.WriteStartElement("excel_underlyingCalcInfo");
                    excel_underlyingInfoViewModel_.buildXml(xmlWriter);
                    
                    excel_underlyingCalcIDViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_underlyingCalcInfo serial_Excel_underlyingCalcInfo = serial_Class as FpmlSerializedCSharp.Excel_underlyingCalcInfo;
        
            List<FpmlSerializedCSharp.Excel_underlyingInfo> serial_excel_underlyingInfo = serial_Excel_underlyingCalcInfo.Excel_underlyingInfo_;
            this.excel_underlyingInfoViewModel_ = new ObservableCollection<Excel_underlyingInfoViewModel>();
            foreach (var item in serial_excel_underlyingInfo)
            {
                string type = item.Type_.ValueStr;
                Excel_underlyingInfoViewModel viewModel = Excel_underlyingInfoViewModel.CreateExcel_underlyingInfo(type);
                viewModel.setFromSerial(item);
                this.excel_underlyingInfoViewModel_.Add(viewModel);
            }
            
            List<FpmlSerializedCSharp.Excel_underlyingCalcID> serial_excel_underlyingCalcID = serial_Excel_underlyingCalcInfo.Excel_underlyingCalcID_;
            this.excel_underlyingCalcIDViewModel_ = new ObservableCollection<Excel_underlyingCalcIDViewModel>();
            foreach (var item in serial_excel_underlyingCalcID)
            {
                string type = item.Type_.ValueStr;
                Excel_underlyingCalcIDViewModel viewModel = Excel_underlyingCalcIDViewModel.CreateExcel_underlyingCalcID(type);
                viewModel.setFromSerial(item);
                this.excel_underlyingCalcIDViewModel_.Add(viewModel);
            }
            
            this.view_ = new Excel_underlyingCalcInfoView();
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
            
            #region SelectExcel_underlyingCalcIDInfo_
            private string selectExcel_underlyingCalcIDInfo_;
            public string SelectExcel_underlyingCalcIDInfo_
            {
                get { return this.selectExcel_underlyingCalcIDInfo_; }
                set
                {
                    if (this.selectExcel_underlyingCalcIDInfo_ != value)
                    {
                        this.selectExcel_underlyingCalcIDInfo_ = value;
                        this.NotifyPropertyChanged("SelectExcel_underlyingCalcIDInfo_");
                    }
                }
            }
            #endregion
            
            public void selectExcel_underlyingCalcIDInfo(string typeStr)
            {
                this.excel_underlyingCalcIDViewModel_ = Excel_underlyingCalcIDViewModel.CreateExcel_underlyingCalcID(typeStr);
                this.view_.DataContext = this;
            }
            
        
    
        
    
    }
    
}

