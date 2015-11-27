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
        //#region View_
        //protected Control view_;
        //public Control View_
        //{
        //    get { return this.view_; }
        //    set
        //    {
        //        if (this.view_ != value)
        //        {
        //            this.view_ = value;
        //            this.NotifyPropertyChanged("View_");
        //        }
        //    }
        //}

        //#endregion

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
    
        public Excel_kiScheduleListViewModel() 
        {
            this.excel_scheduleViewModel_ = new ObservableCollection<Excel_scheduleViewModel>();

            //this.view_ = new Excel_scheduleListView();
            //this.view_.DataContext = this;
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
            xmlWriter.WriteStartElement("excel_kiScheduleList");

            foreach (var item in excel_scheduleViewModel_)
            {
                item.buildXml(xmlWriter);
            }
                    
            xmlWriter.WriteEndElement();
        }

        //public void buildPricingXml(XmlWriter xmlWriter)
        //{
        //    foreach (var item in this.excel_scheduleViewModel_)
        //    {
        //        item.buildPricingXml(xmlWriter);
        //    }
        //}

        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
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

        public Control view()
        {
            System.Windows.Controls.Control v = new Excel_scheduleListView();

            v.DataContext = this;

            return v;
        
        }
    
    }
    
}

