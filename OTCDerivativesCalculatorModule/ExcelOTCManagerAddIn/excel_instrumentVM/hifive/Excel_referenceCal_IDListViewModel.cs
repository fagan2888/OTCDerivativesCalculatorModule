using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class Excel_referenceCal_IDListViewModel : IXmlData
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
        
    
        public Excel_referenceCal_IDListViewModel() { }
        
    
        #region Excel_referenceCal_IDViewModel_
        private ObservableCollection<Excel_referenceCal_IDViewModel> excel_referenceCal_IDViewModel_;
        public ObservableCollection<Excel_referenceCal_IDViewModel> Excel_referenceCal_IDViewModel_
        {
            get { return this.excel_referenceCal_IDViewModel_; }
            set
            {
                if (this.excel_referenceCal_IDViewModel_ != value)
                {
                    this.excel_referenceCal_IDViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_referenceCal_IDViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "excel_referenceCal_IDList");
                xmlWriter.WriteStartElement("excel_referenceCal_IDList");
                    excel_referenceCal_IDViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_referenceCal_IDList serial_Excel_referenceCal_IDList = serial_Class as FpmlSerializedCSharp.Excel_referenceCal_IDList;
        
            List<FpmlSerializedCSharp.Excel_referenceCal_ID> serial_excel_referenceCal_ID = serial_Excel_referenceCal_IDList.Excel_referenceCal_ID_;
            this.excel_referenceCal_IDViewModel_ = new ObservableCollection<Excel_referenceCal_IDViewModel>();
            foreach (var item in serial_excel_referenceCal_ID)
            {
                string type = item.Type_.ValueStr;
                Excel_referenceCal_IDViewModel viewModel = Excel_referenceCal_IDViewModel.CreateExcel_referenceCal_ID(type);
                viewModel.setFromSerial(item);
                this.excel_referenceCal_IDViewModel_.Add(viewModel);
            }
            
            this.view_ = new Excel_referenceCal_IDListView();
            this.view_.DataContext = this;
        }
        
        
    
            #region SelectExcel_referenceCal_IDInfo_
            private string selectExcel_referenceCal_IDInfo_;
            public string SelectExcel_referenceCal_IDInfo_
            {
                get { return this.selectExcel_referenceCal_IDInfo_; }
                set
                {
                    if (this.selectExcel_referenceCal_IDInfo_ != value)
                    {
                        this.selectExcel_referenceCal_IDInfo_ = value;
                        this.NotifyPropertyChanged("SelectExcel_referenceCal_IDInfo_");
                    }
                }
            }
            #endregion
            
            public void selectExcel_referenceCal_IDInfo(string typeStr)
            {
                this.excel_referenceCal_IDViewModel_ = Excel_referenceCal_IDViewModel.CreateExcel_referenceCal_ID(typeStr);
                this.view_.DataContext = this;
            }
            
        
    
        
    
    }
    
}

