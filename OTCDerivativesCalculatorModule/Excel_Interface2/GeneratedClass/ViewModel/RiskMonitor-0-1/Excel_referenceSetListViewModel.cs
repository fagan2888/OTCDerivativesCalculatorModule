using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
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
                xmlWriter.WriteElementString("excel_type" , "excel_referenceSetList");
                xmlWriter.WriteStartElement("excel_referenceSetList");
                    foreach (var item in excel_referenceSetViewModel_)
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
            Control v = new Excel_referenceSetListView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_referenceSetList serial_Excel_referenceSetList = serial_Class as FpmlSerializedCSharp.Excel_referenceSetList;
        
            List<FpmlSerializedCSharp.Excel_referenceSet> serial_excel_referenceSet = serial_Excel_referenceSetList.Excel_referenceSet_;
            this.excel_referenceSetViewModel_ = new ObservableCollection<Excel_referenceSetViewModel>();
            foreach (var item in serial_excel_referenceSet)
            {
                string type = item.Excel_type_.ValueStr;
                Excel_referenceSetViewModel viewModel = Excel_referenceSetViewModel.CreateExcel_referenceSet(type);
                viewModel.setFromSerial(item);
                this.excel_referenceSetViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

