using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class Excel_scheduleListViewModel : IXmlData
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
    
        public Excel_scheduleListViewModel() 
        {
            this.excel_scheduleViewModel_ = new ObservableCollection<Excel_scheduleViewModel>();
        }
        
        #region Excel_scheduleViewModel_
        private ObservableCollection<Excel_scheduleViewModel> excel_scheduleViewModel_;
        public ObservableCollection<Excel_scheduleViewModel> Excel_scheduleViewModel_
        {
            get { return this.excel_scheduleViewModel_; }
            set
            {
                if (this.excel_scheduleViewModel_ != value)
                {
                    this.excel_scheduleViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_scheduleViewModel_");
                }
            }
        }
        #endregion
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "excel_scheduleList");
                xmlWriter.WriteStartElement("excel_scheduleList");

                foreach (var item in excel_scheduleViewModel_)
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
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_scheduleList serial_Excel_scheduleList = serial_Class as FpmlSerializedCSharp.Excel_scheduleList;
        
            List<FpmlSerializedCSharp.Excel_schedule> serial_excel_schedule = serial_Excel_scheduleList.Excel_schedule_;
            this.excel_scheduleViewModel_ = new ObservableCollection<Excel_scheduleViewModel>();
            foreach (var item in serial_excel_schedule)
            {
                string type = item.Type_.ValueStr;
                Excel_scheduleViewModel viewModel = Excel_scheduleViewModel.CreateExcel_schedule(type);
                viewModel.setFromSerial(item);
                this.excel_scheduleViewModel_.Add(viewModel);
            }
            
            this.view_ = new Excel_scheduleListView();
            this.view_.DataContext = this;
        }
        
        
    
            #region SelectExcel_scheduleInfo_
            private string selectExcel_scheduleInfo_;
            public string SelectExcel_scheduleInfo_
            {
                get { return this.selectExcel_scheduleInfo_; }
                set
                {
                    if (this.selectExcel_scheduleInfo_ != value)
                    {
                        this.selectExcel_scheduleInfo_ = value;
                        this.NotifyPropertyChanged("SelectExcel_scheduleInfo_");
                    }
                }
            }
            #endregion
            
            public void selectExcel_scheduleInfo(string typeStr)
            {
                this.excel_scheduleViewModel_ = Excel_scheduleViewModel.CreateExcel_schedule(typeStr);
                this.view_.DataContext = this;
            }
            
        
    
        
    
    }
    
}

