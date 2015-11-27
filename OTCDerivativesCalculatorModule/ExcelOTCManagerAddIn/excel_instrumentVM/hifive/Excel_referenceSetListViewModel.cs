using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class Excel_referenceSetListViewModel : IXmlData
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
        
    
        public Excel_referenceSetListViewModel() { }
        
    
        #region Excel_referenceSetViewModel_
        private ObservableCollection<Excel_referenceSetViewModel> excel_referenceSetViewModel_;
        public ObservableCollection<Excel_referenceSetViewModel> Excel_referenceSetViewModel_
        {
            get { return this.excel_referenceSetViewModel_; }
            set
            {
                if (this.excel_referenceSetViewModel_ != value)
                {
                    this.excel_referenceSetViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_referenceSetViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "excel_referenceSetList");
                xmlWriter.WriteStartElement("excel_referenceSetList");
                    excel_referenceSetViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_referenceSetList serial_Excel_referenceSetList = serial_Class as FpmlSerializedCSharp.Excel_referenceSetList;
        
            List<FpmlSerializedCSharp.Excel_referenceSet> serial_excel_referenceSet = serial_Excel_referenceSetList.Excel_referenceSet_;
            this.excel_referenceSetViewModel_ = new ObservableCollection<Excel_referenceSetViewModel>();
            foreach (var item in serial_excel_referenceSet)
            {
                string type = item.Type_.ValueStr;
                Excel_referenceSetViewModel viewModel = Excel_referenceSetViewModel.CreateExcel_referenceSet(type);
                viewModel.setFromSerial(item);
                this.excel_referenceSetViewModel_.Add(viewModel);
            }
            
            this.view_ = new Excel_referenceSetListView();
            this.view_.DataContext = this;
        }
        
        
    
            #region SelectExcel_referenceSetInfo_
            private string selectExcel_referenceSetInfo_;
            public string SelectExcel_referenceSetInfo_
            {
                get { return this.selectExcel_referenceSetInfo_; }
                set
                {
                    if (this.selectExcel_referenceSetInfo_ != value)
                    {
                        this.selectExcel_referenceSetInfo_ = value;
                        this.NotifyPropertyChanged("SelectExcel_referenceSetInfo_");
                    }
                }
            }
            #endregion
            
            public void selectExcel_referenceSetInfo(string typeStr)
            {
                this.excel_referenceSetViewModel_ = Excel_referenceSetViewModel.CreateExcel_referenceSet(typeStr);
                this.view_.DataContext = this;
            }
            
        
    
        
    
    }
    
}

