using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_scheduleListViewModel : IXmlData , INotifyPropertyChanged
    {
        #region Event
        public event PropertyChangedEventHandler PropertyChanged;
        
        protected void NotifyPropertyChanged(string propertyName)
        {
            //this.view_.DataContext = this;

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

        #region Excel_underlyingCalcInfoViewModel_
        protected Excel_underlyingCalcInfoViewModel excel_underlyingCalcInfoViewModel_;
        public Excel_underlyingCalcInfoViewModel Excel_underlyingCalcInfoViewModel_
        {
            get { return this.excel_underlyingCalcInfoViewModel_; }
            set
            {
                if (this.excel_underlyingCalcInfoViewModel_ != value)
                {
                    this.excel_underlyingCalcInfoViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_underlyingCalcInfoViewModel_");
                }
            }
        }
        #endregion

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

        public void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_scheduleList");

            foreach (var item in excel_scheduleViewModel_)
            {
                item.buildXml(xmlWriter);
            }
                    
            xmlWriter.WriteEndElement();
        }

        //public void buildPricingXml(XmlWriter xmlWriter)
        //{
        //    xmlWriter.WriteStartElement("eventTriggerList");

        //    foreach (var item in this.excel_scheduleViewModel_)
        //    {
        //        item.buildPricingXml(xmlWriter);
        //    }

        //    xmlWriter.WriteEndElement();
        //}

        public void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_scheduleList serial_Excel_scheduleList = serial_Class as FpmlSerializedCSharp.Excel_scheduleList;

            List<FpmlSerializedCSharp.Excel_schedule> serial_excel_schedule = serial_Excel_scheduleList.Excel_schedule_;
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

        public void setScheduleFromClone(Excel_scheduleListViewModel e_sLVM)
        {
            this.excel_scheduleViewModel_.Clear();

            foreach (var item in e_sLVM.excel_scheduleViewModel_)
            {
                this.excel_scheduleViewModel_.Add(item);
            }

        }

        public void setUnderlying(Excel_underlyingCalcInfoViewModel excel_under)
        {
            this.excel_underlyingCalcInfoViewModel_ = excel_under;

            foreach (var item in this.excel_scheduleViewModel_)
            {
                item.setUnderlying(excel_under);
            }
        }


    }
    
}

