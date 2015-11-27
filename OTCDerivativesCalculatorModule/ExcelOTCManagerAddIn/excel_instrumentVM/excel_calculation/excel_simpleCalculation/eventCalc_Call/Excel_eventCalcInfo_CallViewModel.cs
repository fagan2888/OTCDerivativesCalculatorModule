using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class Excel_eventCalcInfo_CallViewModel : IXmlData
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
        
    
        public Excel_eventCalcInfo_CallViewModel() { }
        
    
        #region Excel_eventCalcViewModel_
        private ObservableCollection<Excel_eventCalcViewModel> excel_eventCalcViewModel_;
        public ObservableCollection<Excel_eventCalcViewModel> Excel_eventCalcViewModel_
        {
            get { return this.excel_eventCalcViewModel_; }
            set
            {
                if (this.excel_eventCalcViewModel_ != value)
                {
                    this.excel_eventCalcViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_eventCalcViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "excel_eventCalcInfo_Call");
                xmlWriter.WriteStartElement("excel_eventCalcInfo_Call");
                    excel_eventCalcViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_eventCalcInfo_Call serial_Excel_eventCalcInfo_Call = serial_Class as FpmlSerializedCSharp.Excel_eventCalcInfo_Call;
        
            List<FpmlSerializedCSharp.Excel_eventCalc> serial_excel_eventCalc = serial_Excel_eventCalcInfo_Call.Excel_eventCalc_;
            this.excel_eventCalcViewModel_ = new ObservableCollection<Excel_eventCalcViewModel>();
            foreach (var item in serial_excel_eventCalc)
            {
                string type = item.Type_.ValueStr;
                Excel_eventCalcViewModel viewModel = Excel_eventCalcViewModel.CreateExcel_eventCalc(type);
                viewModel.setFromSerial(item);
                this.excel_eventCalcViewModel_.Add(viewModel);
            }
            
            this.view_ = new Excel_eventCalcInfo_CallView();
            this.view_.DataContext = this;
        }
        
        
    
            #region SelectExcel_eventCalcInfo_
            private string selectExcel_eventCalcInfo_;
            public string SelectExcel_eventCalcInfo_
            {
                get { return this.selectExcel_eventCalcInfo_; }
                set
                {
                    if (this.selectExcel_eventCalcInfo_ != value)
                    {
                        this.selectExcel_eventCalcInfo_ = value;
                        this.NotifyPropertyChanged("SelectExcel_eventCalcInfo_");
                    }
                }
            }
            #endregion
            
            public void selectExcel_eventCalcInfo(string typeStr)
            {
                this.excel_eventCalcViewModel_ = Excel_eventCalcViewModel.CreateExcel_eventCalc(typeStr);
                this.view_.DataContext = this;
            }
            
        
    
        
    
    }
    
}

