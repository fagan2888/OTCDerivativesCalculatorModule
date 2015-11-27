using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class Excel_couponScheduleViewModel : IXmlData
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
        
        public Excel_couponScheduleViewModel() { }
        
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
        private Excel_additionalOptionViewModel excel_additionalOptionViewModel_;
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
        
        #region Excel_fixedCouponScheduleViewModel_
        private Excel_fixedCouponScheduleViewModel excel_fixedCouponScheduleViewModel_;
        public Excel_fixedCouponScheduleViewModel Excel_fixedCouponScheduleViewModel_
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
        
        #region Excel_vanillaFloatingCouponScheduleViewModel_
        private Excel_vanillaFloatingCouponScheduleViewModel excel_vanillaFloatingCouponScheduleViewModel_;
        public Excel_vanillaFloatingCouponScheduleViewModel Excel_vanillaFloatingCouponScheduleViewModel_
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
        
        #region Excel_floatingCouponScheduleViewModel_
        private Excel_floatingCouponScheduleViewModel excel_floatingCouponScheduleViewModel_;
        public Excel_floatingCouponScheduleViewModel Excel_floatingCouponScheduleViewModel_
        {
            get { return this.excel_floatingCouponScheduleViewModel_; }
            set
            {
                if (this.excel_floatingCouponScheduleViewModel_ != value)
                {
                    this.excel_floatingCouponScheduleViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_floatingCouponScheduleViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_condi_structuredCouponScheduleViewModel_
        private Excel_condi_structuredCouponScheduleViewModel excel_condi_structuredCouponScheduleViewModel_;
        public Excel_condi_structuredCouponScheduleViewModel Excel_condi_structuredCouponScheduleViewModel_
        {
            get { return this.excel_condi_structuredCouponScheduleViewModel_; }
            set
            {
                if (this.excel_condi_structuredCouponScheduleViewModel_ != value)
                {
                    this.excel_condi_structuredCouponScheduleViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_condi_structuredCouponScheduleViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_condi_structuredAccrualCouponScheduleViewModel_
        private Excel_condi_structuredAccrualCouponScheduleViewModel excel_condi_structuredAccrualCouponScheduleViewModel_;
        public Excel_condi_structuredAccrualCouponScheduleViewModel Excel_condi_structuredAccrualCouponScheduleViewModel_
        {
            get { return this.excel_condi_structuredAccrualCouponScheduleViewModel_; }
            set
            {
                if (this.excel_condi_structuredAccrualCouponScheduleViewModel_ != value)
                {
                    this.excel_condi_structuredAccrualCouponScheduleViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_condi_structuredAccrualCouponScheduleViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_multiCondi_structuredCouponScheduleViewModel_
        private Excel_multiCondi_structuredCouponScheduleViewModel excel_multiCondi_structuredCouponScheduleViewModel_;
        public Excel_multiCondi_structuredCouponScheduleViewModel Excel_multiCondi_structuredCouponScheduleViewModel_
        {
            get { return this.excel_multiCondi_structuredCouponScheduleViewModel_; }
            set
            {
                if (this.excel_multiCondi_structuredCouponScheduleViewModel_ != value)
                {
                    this.excel_multiCondi_structuredCouponScheduleViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_multiCondi_structuredCouponScheduleViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_multiCondi_structuredAccrualCouponScheduleViewModel_
        private Excel_multiCondi_structuredAccrualCouponScheduleViewModel excel_multiCondi_structuredAccrualCouponScheduleViewModel_;
        public Excel_multiCondi_structuredAccrualCouponScheduleViewModel Excel_multiCondi_structuredAccrualCouponScheduleViewModel_
        {
            get { return this.excel_multiCondi_structuredAccrualCouponScheduleViewModel_; }
            set
            {
                if (this.excel_multiCondi_structuredAccrualCouponScheduleViewModel_ != value)
                {
                    this.excel_multiCondi_structuredAccrualCouponScheduleViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_multiCondi_structuredAccrualCouponScheduleViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_multiCondi_multiRng_structuredAccrualCouponScheduleViewModel_
        private Excel_multiCondi_multiRng_structuredAccrualCouponScheduleViewModel excel_multiCondi_multiRng_structuredAccrualCouponScheduleViewModel_;
        public Excel_multiCondi_multiRng_structuredAccrualCouponScheduleViewModel Excel_multiCondi_multiRng_structuredAccrualCouponScheduleViewModel_
        {
            get { return this.excel_multiCondi_multiRng_structuredAccrualCouponScheduleViewModel_; }
            set
            {
                if (this.excel_multiCondi_multiRng_structuredAccrualCouponScheduleViewModel_ != value)
                {
                    this.excel_multiCondi_multiRng_structuredAccrualCouponScheduleViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_multiCondi_multiRng_structuredAccrualCouponScheduleViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_0;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static Excel_couponScheduleViewModel CreateExcel_couponSchedule(string typeStr)
        {
            if ( typeStr == "excel_additionalOption")
            {
                return new Excel_additionalOptionViewModel();
            }
            else if ( typeStr == "excel_fixedCouponSchedule")
            {
                return new Excel_fixedCouponScheduleViewModel();
            }
            else if ( typeStr == "excel_vanillaFloatingCouponSchedule")
            {
                return new Excel_vanillaFloatingCouponScheduleViewModel();
            }
            else if ( typeStr == "excel_floatingCouponSchedule")
            {
                return new Excel_floatingCouponScheduleViewModel();
            }
            else if ( typeStr == "excel_condi_structuredCouponSchedule")
            {
                return new Excel_condi_structuredCouponScheduleViewModel();
            }
            else if ( typeStr == "excel_condi_structuredAccrualCouponSchedule")
            {
                return new Excel_condi_structuredAccrualCouponScheduleViewModel();
            }
            else if ( typeStr == "excel_multiCondi_structuredCouponSchedule")
            {
                return new Excel_multiCondi_structuredCouponScheduleViewModel();
            }
            else if ( typeStr == "excel_multiCondi_structuredAccrualCouponSchedule")
            {
                return new Excel_multiCondi_structuredAccrualCouponScheduleViewModel();
            }
            else if ( typeStr == "excel_multiCondi_multiRng_structuredAccrualCouponSchedule")
            {
                return new Excel_multiCondi_multiRng_structuredAccrualCouponScheduleViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}

