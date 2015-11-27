using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_hifive_stepDown_kiViewModel : Excel_hifive_subtypeViewModel
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
        
        public Excel_hifive_stepDown_kiViewModel() { }
        
        #region UnderlyingCalcType_
        private string underlyingCalcType_;
        public string UnderlyingCalcType_
        {
            get { return this.underlyingCalcType_; }
            set
            {
                if (this.underlyingCalcType_ != value)
                {
                    this.underlyingCalcType_ = value;
                    this.NotifyPropertyChanged("UnderlyingCalcType_");
                }
            }
        }
        #endregion
        
        #region Maturity_
        private string maturity_;
        public string Maturity_
        {
            get { return this.maturity_; }
            set
            {
                if (this.maturity_ != value)
                {
                    this.maturity_ = value;
                    this.NotifyPropertyChanged("Maturity_");
                }
            }
        }
        #endregion
        
        #region MaturityPeriod_
        private string maturityPeriod_;
        public string MaturityPeriod_
        {
            get { return this.maturityPeriod_; }
            set
            {
                if (this.maturityPeriod_ != value)
                {
                    this.maturityPeriod_ = value;
                    this.NotifyPropertyChanged("MaturityPeriod_");
                }
            }
        }
        #endregion
        
        #region CouponTenor_
        private string couponTenor_;
        public string CouponTenor_
        {
            get { return this.couponTenor_; }
            set
            {
                if (this.couponTenor_ != value)
                {
                    this.couponTenor_ = value;
                    this.NotifyPropertyChanged("CouponTenor_");
                }
            }
        }
        #endregion
        
        #region CouponTenorPeriod_
        private string couponTenorPeriod_;
        public string CouponTenorPeriod_
        {
            get { return this.couponTenorPeriod_; }
            set
            {
                if (this.couponTenorPeriod_ != value)
                {
                    this.couponTenorPeriod_ = value;
                    this.NotifyPropertyChanged("CouponTenorPeriod_");
                }
            }
        }
        #endregion
        
        #region Excel_stepDownKI_subScheduleViewModel_
        private ObservableCollection<Excel_stepDownKI_subScheduleViewModel> excel_stepDownKI_subScheduleViewModel_;
        public ObservableCollection<Excel_stepDownKI_subScheduleViewModel> Excel_stepDownKI_subScheduleViewModel_
        {
            get { return this.excel_stepDownKI_subScheduleViewModel_; }
            set
            {
                if (this.excel_stepDownKI_subScheduleViewModel_ != value)
                {
                    this.excel_stepDownKI_subScheduleViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_stepDownKI_subScheduleViewModel_");
                }
            }
        }
        #endregion
        
        #region Coupon_
        private string coupon_;
        public string Coupon_
        {
            get { return this.coupon_; }
            set
            {
                if (this.coupon_ != value)
                {
                    this.coupon_ = value;
                    this.NotifyPropertyChanged("Coupon_");
                }
            }
        }
        #endregion
        
        #region Ki_
        private string ki_;
        public string Ki_
        {
            get { return this.ki_; }
            set
            {
                if (this.ki_ != value)
                {
                    this.ki_ = value;
                    this.NotifyPropertyChanged("Ki_");
                }
            }
        }
        #endregion
        
        #region KiObStartDate_
        private DateTime kiObStartDate_;
        public DateTime KiObStartDate_
        {
            get { return this.kiObStartDate_; }
            set
            {
                if (this.kiObStartDate_ != value)
                {
                    this.kiObStartDate_ = value;
                    this.NotifyPropertyChanged("KiObStartDate_");
                }
            }
        }
        #endregion
        
        #region KiObEndDate_
        private DateTime kiObEndDate_;
        public DateTime KiObEndDate_
        {
            get { return this.kiObEndDate_; }
            set
            {
                if (this.kiObEndDate_ != value)
                {
                    this.kiObEndDate_ = value;
                    this.NotifyPropertyChanged("KiObEndDate_");
                }
            }
        }
        #endregion
        
        #region SettlementDays_
        private string settlementDays_;
        public string SettlementDays_
        {
            get { return this.settlementDays_; }
            set
            {
                if (this.settlementDays_ != value)
                {
                    this.settlementDays_ = value;
                    this.NotifyPropertyChanged("SettlementDays_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_hifive_subtype");
                xmlWriter.WriteElementString("type" , "excel_hifive_stepDown_ki");
                xmlWriter.WriteStartElement("excel_hifive_stepDown_ki");
                    xmlWriter.WriteElementString("underlyingCalcType" , this.underlyingCalcType_);
                    
                    xmlWriter.WriteElementString("maturity" , this.maturity_);
                    
                    xmlWriter.WriteElementString("maturityPeriod" , this.maturityPeriod_);
                    
                    xmlWriter.WriteElementString("couponTenor" , this.couponTenor_);
                    
                    xmlWriter.WriteElementString("couponTenorPeriod" , this.couponTenorPeriod_);
                    
                    foreach (var item in excel_stepDownKI_subScheduleViewModel_)
                    {
                        item.buildXml(xmlWriter);
                    }
                    
                    xmlWriter.WriteElementString("coupon" , this.coupon_);
                    
                    xmlWriter.WriteElementString("ki" , this.ki_);
                    
                    xmlWriter.WriteElementString("kiObStartDate" , StringConverter.xmlDateTimeToDateString(this.kiObStartDate_));
                    
                    xmlWriter.WriteElementString("kiObEndDate" , StringConverter.xmlDateTimeToDateString(this.kiObEndDate_));
                    
                    xmlWriter.WriteElementString("settlementDays" , this.settlementDays_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_hifive_stepDown_kiView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_hifive_subtype serial_Excel_hifive_subtype = serial_Class as FpmlSerializedCSharp.Excel_hifive_subtype;
            FpmlSerializedCSharp.Excel_hifive_stepDown_ki serial_Excel_hifive_stepDown_ki = serial_Excel_hifive_subtype.Excel_hifive_stepDown_ki_;
        
            this.underlyingCalcType_ = serial_Excel_hifive_stepDown_ki.UnderlyingCalcType_.ValueStr;
            
            this.maturity_ = serial_Excel_hifive_stepDown_ki.Maturity_.ValueStr;
            
            this.maturityPeriod_ = serial_Excel_hifive_stepDown_ki.MaturityPeriod_.ValueStr;
            
            this.couponTenor_ = serial_Excel_hifive_stepDown_ki.CouponTenor_.ValueStr;
            
            this.couponTenorPeriod_ = serial_Excel_hifive_stepDown_ki.CouponTenorPeriod_.ValueStr;
            
            List<FpmlSerializedCSharp.Excel_stepDownKI_subSchedule> serial_excel_stepDownKI_subSchedule = serial_Excel_hifive_stepDown_ki.Excel_stepDownKI_subSchedule_;
            this.excel_stepDownKI_subScheduleViewModel_ = new ObservableCollection<Excel_stepDownKI_subScheduleViewModel>();
            foreach (var item in serial_excel_stepDownKI_subSchedule)
            {
                string type = item.Excel_type_.ValueStr;
                Excel_stepDownKI_subScheduleViewModel viewModel = Excel_stepDownKI_subScheduleViewModel.CreateExcel_stepDownKI_subSchedule(type);
                viewModel.setFromSerial(item);
                this.excel_stepDownKI_subScheduleViewModel_.Add(viewModel);
            }
            
            this.coupon_ = serial_Excel_hifive_stepDown_ki.Coupon_.ValueStr;
            
            this.ki_ = serial_Excel_hifive_stepDown_ki.Ki_.ValueStr;
            
            this.kiObStartDate_ = StringConverter.xmlDateToDateTime(serial_Excel_hifive_stepDown_ki.KiObStartDate_.ValueStr);
            
            this.kiObEndDate_ = StringConverter.xmlDateToDateTime(serial_Excel_hifive_stepDown_ki.KiObEndDate_.ValueStr);
            
            this.settlementDays_ = serial_Excel_hifive_stepDown_ki.SettlementDays_.ValueStr;
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

