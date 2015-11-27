using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_couponScheduleListViewModel : IXmlData
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
        
        public Excel_couponScheduleListViewModel() { }
        
        #region Excel_couponScheduleViewModel_
        private ObservableCollection<Excel_couponScheduleViewModel> excel_couponScheduleViewModel_;
        public ObservableCollection<Excel_couponScheduleViewModel> Excel_couponScheduleViewModel_
        {
            get { return this.excel_couponScheduleViewModel_; }
            set
            {
                if (this.excel_couponScheduleViewModel_ != value)
                {
                    this.excel_couponScheduleViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_couponScheduleViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "excel_couponScheduleList");
                xmlWriter.WriteStartElement("excel_couponScheduleList");
                    foreach (var item in excel_couponScheduleViewModel_)
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
            Control v = new Excel_couponScheduleListView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_couponScheduleList serial_Excel_couponScheduleList = serial_Class as FpmlSerializedCSharp.Excel_couponScheduleList;
        
            List<FpmlSerializedCSharp.Excel_couponSchedule> serial_excel_couponSchedule = serial_Excel_couponScheduleList.Excel_couponSchedule_;
            this.excel_couponScheduleViewModel_ = new ObservableCollection<Excel_couponScheduleViewModel>();
            foreach (var item in serial_excel_couponSchedule)
            {
                string type = item.Excel_type_.ValueStr;
                Excel_couponScheduleViewModel viewModel = Excel_couponScheduleViewModel.CreateExcel_couponSchedule(type);
                viewModel.setFromSerial(item);
                this.excel_couponScheduleViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

