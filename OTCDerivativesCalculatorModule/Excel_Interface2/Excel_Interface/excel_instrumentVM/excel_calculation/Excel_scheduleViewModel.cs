using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public abstract class Excel_scheduleViewModel : IXmlData , INotifyPropertyChanged
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
        
        public Excel_scheduleViewModel()
        {
            this.excel_additionalOptionViewModel_ = new Excel_noneOptionViewModel();
        }

        #region EventDAO_
        protected EVENT_INFO_Table_DAO eventDAO_;
        public EVENT_INFO_Table_DAO EventDAO_
        {
            get { return this.eventDAO_; }
            set
            {
                if (this.eventDAO_ != value)
                {
                    this.eventDAO_ = value;
                    this.NotifyPropertyChanged("EventDAO_");
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

        #region Excel_type_
        protected string excel_type_;
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

        #region Description_
        protected string description_;
        public string Description_
        {
            get 
            {
                this.descriptionUpdate();
                return this.description_; 
            }
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

        //edit 기능은 나중에 넣자 ㅡ.ㅡ;;

        //#region EventTriggerViewModel_
        //protected EventTriggerViewModel eventTriggerViewModel_;
        //public EventTriggerViewModel EventTriggerViewModel_
        //{
        //    get { return this.eventTriggerViewModel_; }
        //    set
        //    {
        //        if (this.eventTriggerViewModel_ != value)
        //        {
        //            this.eventTriggerViewModel_ = value;
        //            this.NotifyPropertyChanged("EventTriggerViewModel_");
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

        public virtual void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            this.excel_additionalOptionViewModel_.buildXml(xmlWriter);
        }

        //public abstract void buildPricingXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);

        public virtual void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_additionalOption serial_Excel_additionalOption = serial_Class as FpmlSerializedCSharp.Excel_additionalOption;

            string additionalOption_type = serial_Excel_additionalOption.Excel_type_.ValueStr;
            this.Excel_additionalOptionViewModel_ = Excel_additionalOptionViewModel.CreateExcel_additionalOption(additionalOption_type);
            this.Excel_additionalOptionViewModel_.setFromSerial(serial_Excel_additionalOption);

        }

        public static Excel_scheduleViewModel CreateExcel_schedule(string typeStr)
        {
            if (typeStr == "excel_simpleCalculation")
            {
                return new Excel_simpleCalculationViewModel();
            }
            //else if ( typeStr == "excel_choiceReturnCalculation")
            //{
            //    return new Excel_choiceReturnCalculationViewModel();
            //}
            else
            {
                throw new NotImplementedException();
            }
        }

        public abstract void setUnderlying(Excel_underlyingCalcInfoViewModel excel_under);

        public Control loaderView()
        {
            Excel_scheduleLoaderView scheduleLoaderView = new Excel_scheduleLoaderView();

            scheduleLoaderView.initialize(this);

            scheduleLoaderView.Excel_underlyingCalcInfoViewModel_ = this.Excel_underlyingCalcInfoViewModel_;

            scheduleLoaderView.selectedScheduleGrid_.Children.Add(this.view());

            return scheduleLoaderView;
        }

        public abstract Control view();

        public abstract void descriptionUpdate();

        public abstract void bookingEvent(MasterInformationViewModel masterInformationViewModel,
                                            EVENT_INFO_Table_DAO dao);

    }
    
}

