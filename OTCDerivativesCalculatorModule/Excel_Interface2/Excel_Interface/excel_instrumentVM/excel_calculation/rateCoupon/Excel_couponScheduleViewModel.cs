using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public abstract class Excel_couponScheduleViewModel : IXmlData, INotifyPropertyChanged
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

        public Excel_couponScheduleViewModel() 
        {
            this.excel_additionalOptionViewModel_ = new Excel_noneOptionViewModel();
        }

        #region Excel_type_
        private string excel_type_;
        public string Excel_type_
        {
            get { return this.excel_type_; }
            set
            {
                if (this.excel_type_ != value)
                {
                    this.excel_type_ = value;
                    this.NotifyPropertyChanged("Excel_type_");
                }
            }
        }
        #endregion

        #region Excel_additionalOptionViewModel_
        protected Excel_additionalOptionViewModel excel_additionalOptionViewModel_;
        public Excel_additionalOptionViewModel Excel_additionalOptionViewModel_
        {
            get { return this.excel_additionalOptionViewModel_; }
            set
            {
                if (this.excel_additionalOptionViewModel_ != value)
                {
                    this.excel_additionalOptionViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_additionalOptionViewModel_");
                }
            }
        }
        #endregion

        #region EventDate_
        protected DateTime eventDate_;
        public DateTime EventDate_
        {
            get { return this.eventDate_; }
            set
            {
                if (this.eventDate_ != value)
                {
                    this.eventDate_ = value;
                    this.NotifyPropertyChanged("EventDate_");
                }
            }
        }
        #endregion

        #region PayoffDate_
        protected DateTime payoffDate_;
        public DateTime PayoffDate_
        {
            get { return this.payoffDate_; }
            set
            {
                if (this.payoffDate_ != value)
                {
                    this.payoffDate_ = value;
                    this.NotifyPropertyChanged("PayoffDate_");
                }
            }
        }
        #endregion

        #region CalculationStartDate_
        protected DateTime calculationStartDate_;
        public DateTime CalculationStartDate_
        {
            get { return this.calculationStartDate_; }
            set
            {
                if (this.calculationStartDate_ != value)
                {
                    this.calculationStartDate_ = value;
                    this.NotifyPropertyChanged("CalculationStartDate_");
                }
            }
        }
        #endregion

        #region CalculationEndDate_
        protected DateTime calculationEndDate_;
        public DateTime CalculationEndDate_
        {
            get { return this.calculationEndDate_; }
            set
            {
                if (this.calculationEndDate_ != value)
                {
                    this.calculationEndDate_ = value;
                    this.NotifyPropertyChanged("CalculationEndDate_");
                }
            }
        }
        #endregion

        #region Description_
        protected string description_;
        public string Description_
        {
            get { return this.description_; }
            set
            {
                if (this.description_ != value)
                {
                    this.description_ = value;
                    this.NotifyPropertyChanged("Description_");
                }
            }
        }
        #endregion

        #region VBA_description_
        protected string vba_description_;
        public string VBA_description_
        {
            get { return this.vba_description_; }
            set
            {
                if (this.vba_description_ != value)
                {
                    this.vba_description_ = value;
                    this.NotifyPropertyChanged("VBA_description_");
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

        public virtual void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            this.excel_additionalOptionViewModel_.buildXml(xmlWriter);
        }

        public abstract void setFromXml(System.Xml.XmlNode node);

        public virtual void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            //FpmlSerializedCSharp.Excel_couponSchedule serial_Excel_couponSchedule = serial_Class as FpmlSerializedCSharp.Excel_couponSchedule;
            FpmlSerializedCSharp.Excel_additionalOption serial_Excel_additionalOption = serial_Class as FpmlSerializedCSharp.Excel_additionalOption;

            string additionalOption_type = serial_Excel_additionalOption.Excel_type_.ValueStr;
            this.Excel_additionalOptionViewModel_ = Excel_additionalOptionViewModel.CreateExcel_additionalOption(additionalOption_type);
            this.Excel_additionalOptionViewModel_.setFromSerial(serial_Excel_additionalOption);

        }

        public static Excel_couponScheduleViewModel CreateExcel_couponSchedule(string typeStr)
        {
            if (typeStr == "excel_fixedCouponSchedule")
            {
                return new Excel_fixedCouponScheduleViewModel();
            }
            else if (typeStr == "excel_vanillaFloatingCouponSchedule")
            {
                return new Excel_vanillaFloatingCouponScheduleViewModel();
            }
            else if (typeStr == "excel_floatingCouponSchedule")
            {
                return new Excel_floatingCouponScheduleViewModel();
            }
            else if (typeStr == "excel_multiCondi_structuredCouponSchedule")
            {
                return new Excel_multiCondi_structuredCouponScheduleViewModel();
            }
            else if (typeStr == "excel_multiCondi_structuredAccrualCouponSchedule")
            {
                return new Excel_multiCondi_structuredAccrualCouponScheduleViewModel();
            }
            else if (typeStr == "excel_multiCondi_multiRng_structuredAccrualCouponSchedule")
            {
                return new Excel_multiCondi_multiRng_structuredAccrualCouponScheduleViewModel();
            }
            else
            {
                OutputLogViewModel.addResult("Excel_couponScheduleViewModel CreateExcel_couponSchedule( " + typeStr + ") : unknown Type");

                throw new NotImplementedException();
            }
        }

        public Control loaderView()
        {
            Excel_couponScheduleLoaderView couponScheduleLoaderView = new Excel_couponScheduleLoaderView();

            couponScheduleLoaderView.initialize(this);

            couponScheduleLoaderView.Excel_underlyingCalcInfoViewModel_ = this.Excel_underlyingCalcInfoViewModel_;

            couponScheduleLoaderView.selectedCouponScheduleGrid_.Children.Add(this.view());

            return couponScheduleLoaderView;
        }

        public abstract Control view();

        public abstract void descriptionUpdate();

        public abstract void bookingEvent(MasterInformationViewModel masterInformationViewModel,
                                            EVENT_INFO_Table_DAO dao);

        public virtual void setUnderlying(Excel_underlyingCalcInfoViewModel excel_under)
        {
            this.excel_underlyingCalcInfoViewModel_ = excel_under;
        }

        public void bookingEvent(MasterInformationViewModel masterInformationViewModel)
        {
            throw new NotImplementedException();
        }

    }
}

