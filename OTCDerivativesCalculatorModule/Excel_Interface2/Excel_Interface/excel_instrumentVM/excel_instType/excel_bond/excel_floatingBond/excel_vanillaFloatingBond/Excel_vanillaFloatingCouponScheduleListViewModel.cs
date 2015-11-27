using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_vanillaFloatingCouponScheduleListViewModel : IXmlData
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
    
        public Excel_vanillaFloatingCouponScheduleListViewModel() 
        {
            this.excel_vanillaFloatingCouponScheduleViewModel_ = new ObservableCollection<Excel_vanillaFloatingCouponScheduleViewModel>();

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
        
        #region Excel_vanillaFloatingCouponScheduleViewModel_
        private ObservableCollection<Excel_vanillaFloatingCouponScheduleViewModel> excel_vanillaFloatingCouponScheduleViewModel_;
        public ObservableCollection<Excel_vanillaFloatingCouponScheduleViewModel> Excel_vanillaFloatingCouponScheduleViewModel_
        {
            get { return this.excel_vanillaFloatingCouponScheduleViewModel_; }
            set
            {
                if (this.excel_vanillaFloatingCouponScheduleViewModel_ != value)
                {
                    this.excel_vanillaFloatingCouponScheduleViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_vanillaFloatingCouponScheduleViewModel_");
                }
            }
        }
        #endregion
        
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_vanillaFloatingCouponScheduleList");
                //xmlWriter.WriteElementString("scheduleInitialDate" , this.scheduleInitialDate_);
                xmlWriter.WriteElementString("fixedRate" , this.fixedRate_);
                xmlWriter.WriteElementString("dayCounter" , this.dayCounter_);
                //xmlWriter.WriteElementString("maturityDate" , this.maturityDate_);

                foreach (var item in this.excel_vanillaFloatingCouponScheduleViewModel_)
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
            FpmlSerializedCSharp.Excel_vanillaFloatingCouponScheduleList serial_Excel_vanillaFloatingCouponScheduleList = serial_Class as FpmlSerializedCSharp.Excel_vanillaFloatingCouponScheduleList;
        
            //this.scheduleInitialDate_ = serial_Excel_vanillaFloatingCouponScheduleList.ScheduleInitialDate_.ValueStr;
            this.fixedRate_ = serial_Excel_vanillaFloatingCouponScheduleList.FixedRate_.ValueStr;
            this.dayCounter_ = serial_Excel_vanillaFloatingCouponScheduleList.DayCounter_.ValueStr;
            //this.maturityDate_ = serial_Excel_vanillaFloatingCouponScheduleList.MaturityDate_.ValueStr;
            
            List<FpmlSerializedCSharp.Excel_vanillaFloatingCouponSchedule> serial_excel_vanillaFloatingCouponSchedule = serial_Excel_vanillaFloatingCouponScheduleList.Excel_vanillaFloatingCouponSchedule_;
            this.excel_vanillaFloatingCouponScheduleViewModel_ = new ObservableCollection<Excel_vanillaFloatingCouponScheduleViewModel>();
            foreach (var item in serial_excel_vanillaFloatingCouponSchedule)
            {
                Excel_vanillaFloatingCouponScheduleViewModel viewModel = new Excel_vanillaFloatingCouponScheduleViewModel();
                viewModel.setFromSerial(item);
                this.excel_vanillaFloatingCouponScheduleViewModel_.Add(viewModel);
            }
            
        }

        public Control view()
        {
            System.Windows.Controls.Control v = new Excel_vanillaFloatingCouponScheduleListView();

            v.DataContext = this;

            return v;
        }

        public void setScheduleFromClone(Excel_vanillaFloatingCouponScheduleListViewModel e_vfcslvm)
        {
            this.excel_vanillaFloatingCouponScheduleViewModel_.Clear();

            foreach (var item in e_vfcslvm.excel_vanillaFloatingCouponScheduleViewModel_)
            {
                this.excel_vanillaFloatingCouponScheduleViewModel_.Add(item);
            }

        }

        public void setUnderlying(Excel_underlyingCalcInfoViewModel excel_under)
        {
            this.excel_underlyingCalcInfoViewModel_ = excel_under;

            foreach (var item in this.excel_vanillaFloatingCouponScheduleViewModel_)
            {
                item.setUnderlying(excel_under);
            }
        }

        public void bookingEvent(MasterInformationViewModel masterInformationViewModel)
        {
            throw new NotImplementedException();
        }
    }
    
}

