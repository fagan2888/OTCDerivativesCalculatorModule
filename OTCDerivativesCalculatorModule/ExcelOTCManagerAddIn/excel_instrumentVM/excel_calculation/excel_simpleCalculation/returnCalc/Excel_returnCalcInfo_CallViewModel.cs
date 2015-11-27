using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class Excel_returnCalcInfo_CallViewModel : IXmlData
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
        
    
        public Excel_returnCalcInfo_CallViewModel() { }
        
    
        #region Excel_returnCalcViewModel_
        private ObservableCollection<Excel_returnCalcViewModel> excel_returnCalcViewModel_;
        public ObservableCollection<Excel_returnCalcViewModel> Excel_returnCalcViewModel_
        {
            get { return this.excel_returnCalcViewModel_; }
            set
            {
                if (this.excel_returnCalcViewModel_ != value)
                {
                    this.excel_returnCalcViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_returnCalcViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "excel_returnCalcInfo_Call");
                xmlWriter.WriteStartElement("excel_returnCalcInfo_Call");
                    excel_returnCalcViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_returnCalcInfo_Call serial_Excel_returnCalcInfo_Call = serial_Class as FpmlSerializedCSharp.Excel_returnCalcInfo_Call;
        
            List<FpmlSerializedCSharp.Excel_returnCalc> serial_excel_returnCalc = serial_Excel_returnCalcInfo_Call.Excel_returnCalc_;
            this.excel_returnCalcViewModel_ = new ObservableCollection<Excel_returnCalcViewModel>();
            foreach (var item in serial_excel_returnCalc)
            {
                string type = item.Type_.ValueStr;
                Excel_returnCalcViewModel viewModel = Excel_returnCalcViewModel.CreateExcel_returnCalc(type);
                viewModel.setFromSerial(item);
                this.excel_returnCalcViewModel_.Add(viewModel);
            }
            
            this.view_ = new Excel_returnCalcInfo_CallView();
            this.view_.DataContext = this;
        }
        
        
    
            #region SelectExcel_returnCalcInfo_
            private string selectExcel_returnCalcInfo_;
            public string SelectExcel_returnCalcInfo_
            {
                get { return this.selectExcel_returnCalcInfo_; }
                set
                {
                    if (this.selectExcel_returnCalcInfo_ != value)
                    {
                        this.selectExcel_returnCalcInfo_ = value;
                        this.NotifyPropertyChanged("SelectExcel_returnCalcInfo_");
                    }
                }
            }
            #endregion
            
            public void selectExcel_returnCalcInfo(string typeStr)
            {
                this.excel_returnCalcViewModel_ = Excel_returnCalcViewModel.CreateExcel_returnCalc(typeStr);
                this.view_.DataContext = this;
            }
            
        
    
        
    
    }
    
}

