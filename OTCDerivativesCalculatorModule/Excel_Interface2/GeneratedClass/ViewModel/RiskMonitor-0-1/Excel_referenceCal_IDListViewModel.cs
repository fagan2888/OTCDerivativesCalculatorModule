using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
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
                xmlWriter.WriteElementString("excel_type" , "excel_referenceCal_IDList");
                xmlWriter.WriteStartElement("excel_referenceCal_IDList");
                    foreach (var item in excel_referenceCal_IDViewModel_)
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
            Control v = new Excel_referenceCal_IDListView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_referenceCal_IDList serial_Excel_referenceCal_IDList = serial_Class as FpmlSerializedCSharp.Excel_referenceCal_IDList;
        
            List<FpmlSerializedCSharp.Excel_referenceCal_ID> serial_excel_referenceCal_ID = serial_Excel_referenceCal_IDList.Excel_referenceCal_ID_;
            this.excel_referenceCal_IDViewModel_ = new ObservableCollection<Excel_referenceCal_IDViewModel>();
            foreach (var item in serial_excel_referenceCal_ID)
            {
                string type = item.Excel_type_.ValueStr;
                Excel_referenceCal_IDViewModel viewModel = Excel_referenceCal_IDViewModel.CreateExcel_referenceCal_ID(type);
                viewModel.setFromSerial(item);
                this.excel_referenceCal_IDViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

