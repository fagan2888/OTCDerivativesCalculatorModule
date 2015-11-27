using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_kiScheduleListViewModel : IXmlData
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
        
        public Excel_kiScheduleListViewModel() { }
        
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
                xmlWriter.WriteElementString("excel_type" , "excel_kiScheduleList");
                xmlWriter.WriteStartElement("excel_kiScheduleList");
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
        
        public  Control view()
        {
            Control v = new Excel_kiScheduleListView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_kiScheduleList serial_Excel_kiScheduleList = serial_Class as FpmlSerializedCSharp.Excel_kiScheduleList;
        
            List<FpmlSerializedCSharp.Excel_schedule> serial_excel_schedule = serial_Excel_kiScheduleList.Excel_schedule_;
            this.excel_scheduleViewModel_ = new ObservableCollection<Excel_scheduleViewModel>();
            foreach (var item in serial_excel_schedule)
            {
                string type = item.Excel_type_.ValueStr;
                Excel_scheduleViewModel viewModel = Excel_scheduleViewModel.CreateExcel_schedule(type);
                viewModel.setFromSerial(item);
                this.excel_scheduleViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

