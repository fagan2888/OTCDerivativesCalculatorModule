using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_couponScheduleListViewModel : IXmlData , INotifyPropertyChanged
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
                
        #region StepMonth_
        private int stepMonth_;
        public int StepMonth_
        {
            get { return this.stepMonth_; }
            set
            {
                if (this.stepMonth_ != value)
                {
                    this.stepMonth_ = value;
                    this.NotifyPropertyChanged("StepMonth_");
                }
            }
        }
        #endregion

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

        public Excel_couponScheduleListViewModel()
        {
            this.excel_couponScheduleViewModel_ = new ObservableCollection<Excel_couponScheduleViewModel>();
        }
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            // 외부에서 setting되는 값이지만 그래도 저장함.
                //xmlWriter.WriteElementString("scheduleInitialDate", StringConverter.xmlDateTimeToDateString(this.scheduleInitialDate_));
                //xmlWriter.WriteElementString("maturityDate", StringConverter.xmlDateTimeToDateString(this.maturityDate_));

                xmlWriter.WriteStartElement("excel_couponScheduleList");

                foreach (var item in this.excel_couponScheduleViewModel_)
                {
                    item.buildXml(xmlWriter);
                }
                    
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
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

        public void ScheduleInitialDateObserver(object sender, PropertyChangedEventArgs e)
        {
            Excel_issueInfoViewModel e_iivm = sender as Excel_issueInfoViewModel;

            if (e.PropertyName == "EffectiveDate_")
            {
                //this.scheduleInitialDate_ = e_iivm.EffectiveDate_;
            }

        }

        //public void bookingEvent(MasterInformationViewModel masterInformationViewModel)
        //{
        //    foreach (var item in this.excel_couponScheduleViewModel_)
        //    {
        //        item.bookingEvent(masterInformationViewModel);
        //    }
        //}

        public Control view()
        {
            System.Windows.Controls.Control v = new Excel_couponScheduleListView();

            v.DataContext = this;

            return v;
        }

        public void setScheduleFromClone(Excel_couponScheduleListViewModel e_csLVM)
        {
            this.excel_couponScheduleViewModel_.Clear();

            foreach (var item in e_csLVM.excel_couponScheduleViewModel_)
            {
                this.excel_couponScheduleViewModel_.Add(item);
            }

        }

        public void setUnderlying(Excel_underlyingCalcInfoViewModel excel_under)
        {
            this.excel_underlyingCalcInfoViewModel_ = excel_under;

            foreach (var item in this.excel_couponScheduleViewModel_)
            {
                item.setUnderlying(excel_under);
            }
        }

        public void bookingEvent(MasterInformationViewModel masterInformationViewModel)
        {
            foreach (var item in this.excel_couponScheduleViewModel_)
            {
                item.bookingEvent(masterInformationViewModel);
            }
        }
    }
    
}

