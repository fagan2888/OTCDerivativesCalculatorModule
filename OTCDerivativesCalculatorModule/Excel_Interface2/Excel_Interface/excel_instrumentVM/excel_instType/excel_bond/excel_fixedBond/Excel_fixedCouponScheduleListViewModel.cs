using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_fixedCouponScheduleListViewModel : IXmlData , INotifyPropertyChanged
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
    
        public Excel_fixedCouponScheduleListViewModel() 
        {
            this.excel_fixedCouponScheduleViewModel_ = new ObservableCollection<Excel_fixedCouponScheduleViewModel>();
        }

        //#region ScheduleInitialDate_
        //private string scheduleInitialDate_;
        //public string ScheduleInitialDate_
        //{
        //    get { return this.scheduleInitialDate_; }
        //    set
        //    {
        //        if (this.scheduleInitialDate_ != value)
        //        {
        //            this.scheduleInitialDate_ = value;
        //            this.NotifyPropertyChanged("ScheduleInitialDate_");
        //        }
        //    }
        //}
        //#endregion
        
        #region FixedRate_
        private string fixedRate_;
        public string FixedRate_
        {
            get { return this.fixedRate_; }
            set
            {
                if (this.fixedRate_ != value)
                {
                    this.fixedRate_ = value;
                    this.NotifyPropertyChanged("FixedRate_");
                }
            }
        }
        #endregion
        
        #region DayCounter_
        private string dayCounter_;
        public string DayCounter_
        {
            get { return this.dayCounter_; }
            set
            {
                if (this.dayCounter_ != value)
                {
                    this.dayCounter_ = value;
                    this.NotifyPropertyChanged("DayCounter_");
                }
            }
        }
        #endregion
        
        //#region MaturityDate_
        //private string maturityDate_;
        //public string MaturityDate_
        //{
        //    get { return this.maturityDate_; }
        //    set
        //    {
        //        if (this.maturityDate_ != value)
        //        {
        //            this.maturityDate_ = value;
        //            this.NotifyPropertyChanged("MaturityDate_");
        //        }
        //    }
        //}
        //#endregion

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

        #region Excel_fixedCouponScheduleViewModel_
        private ObservableCollection<Excel_fixedCouponScheduleViewModel> excel_fixedCouponScheduleViewModel_;
        public ObservableCollection<Excel_fixedCouponScheduleViewModel> Excel_fixedCouponScheduleViewModel_
        {
            get { return this.excel_fixedCouponScheduleViewModel_; }
            set
            {
                if (this.excel_fixedCouponScheduleViewModel_ != value)
                {
                    this.excel_fixedCouponScheduleViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_fixedCouponScheduleViewModel_");
                }
            }
        }
        #endregion
        
        public void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_fixedCouponScheduleList");

                //xmlWriter.WriteElementString("scheduleInitialDate" , this.scheduleInitialDate_);
                xmlWriter.WriteElementString("fixedRate" , this.fixedRate_);
                xmlWriter.WriteElementString("dayCounter" , this.dayCounter_);
                //xmlWriter.WriteElementString("maturityDate" , this.maturityDate_);

                foreach (var item in this.excel_fixedCouponScheduleViewModel_)
                {
                    item.buildXml(xmlWriter);    
                }
                    
            xmlWriter.WriteEndElement();
        }
        
        public void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_fixedCouponScheduleList serial_Excel_fixedCouponScheduleList = serial_Class as FpmlSerializedCSharp.Excel_fixedCouponScheduleList;
        
            //this.scheduleInitialDate_ = serial_Excel_fixedCouponScheduleList.ScheduleInitialDate_.ValueStr;
            this.fixedRate_ = serial_Excel_fixedCouponScheduleList.FixedRate_.ValueStr;
            this.dayCounter_ = serial_Excel_fixedCouponScheduleList.DayCounter_.ValueStr;
            //this.maturityDate_ = serial_Excel_fixedCouponScheduleList.MaturityDate_.ValueStr;

            List<FpmlSerializedCSharp.Excel_couponSchedule> serial_excel_couponSchedule = serial_Excel_fixedCouponScheduleList.Excel_couponSchedule_;
            this.excel_fixedCouponScheduleViewModel_ = new ObservableCollection<Excel_fixedCouponScheduleViewModel>();
            foreach (var item in serial_excel_couponSchedule)
            {
                string type = item.Excel_type_.ValueStr;
                Excel_couponScheduleViewModel viewModel = Excel_couponScheduleViewModel.CreateExcel_couponSchedule(type);
                viewModel.setFromSerial(item);
                this.excel_fixedCouponScheduleViewModel_.Add((Excel_fixedCouponScheduleViewModel)viewModel);
            }
            
        }

        public void bookingEvent(MasterInformationViewModel masterInformationViewModel)
        {
            // list가 issue 정보를 사용하기 위해 한칸 위로 올림
        }

        public Control view()
        {
            Control v = new Excel_fixedCouponScheduleListView();

            v.DataContext = this;

            return v;
        }

        public void setUnderlying(Excel_underlyingCalcInfoViewModel excel_under)
        {
            this.excel_underlyingCalcInfoViewModel_ = excel_under;

            foreach (var item in this.excel_fixedCouponScheduleViewModel_)
            {
                item.setUnderlying(excel_under);
            }
        }

        public void setScheduleFromClone(Excel_fixedCouponScheduleListViewModel excel_cslvm)
        {
            this.FixedRate_ = excel_cslvm.FixedRate_;

            this.excel_fixedCouponScheduleViewModel_.Clear();

            foreach (var item in excel_cslvm.excel_fixedCouponScheduleViewModel_)
            {
                this.excel_fixedCouponScheduleViewModel_.Add(item);
            }
        }
    }
    
}

