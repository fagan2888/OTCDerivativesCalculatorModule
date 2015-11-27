using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_fixedBond_constantRateViewModel : Excel_fixedBond_subtypeViewModel
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
        
        public Excel_fixedBond_constantRateViewModel() { }
        
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
        
        #region Excel_fixedBond_subScheduleViewModel_
        private ObservableCollection<Excel_fixedBond_subScheduleViewModel> excel_fixedBond_subScheduleViewModel_;
        public ObservableCollection<Excel_fixedBond_subScheduleViewModel> Excel_fixedBond_subScheduleViewModel_
        {
            get { return this.excel_fixedBond_subScheduleViewModel_; }
            set
            {
                if (this.excel_fixedBond_subScheduleViewModel_ != value)
                {
                    this.excel_fixedBond_subScheduleViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_fixedBond_subScheduleViewModel_");
                }
            }
        }
        #endregion
        
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
            xmlWriter.WriteStartElement("excel_fixedBond_subtype");
                xmlWriter.WriteElementString("excel_type" , "excel_fixedBond_constantRate");
                xmlWriter.WriteStartElement("excel_fixedBond_constantRate");
                    xmlWriter.WriteElementString("maturity" , this.maturity_);
                    
                    xmlWriter.WriteElementString("maturityPeriod" , this.maturityPeriod_);
                    
                    xmlWriter.WriteElementString("couponTenor" , this.couponTenor_);
                    
                    xmlWriter.WriteElementString("couponTenorPeriod" , this.couponTenorPeriod_);
                    
                    foreach (var item in excel_fixedBond_subScheduleViewModel_)
                    {
                        item.buildXml(xmlWriter);
                    }
                    
                    xmlWriter.WriteElementString("fixedRate" , this.fixedRate_);
                    
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
            Control v = new Excel_fixedBond_constantRateView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_fixedBond_subtype serial_Excel_fixedBond_subtype = serial_Class as FpmlSerializedCSharp.Excel_fixedBond_subtype;
            FpmlSerializedCSharp.Excel_fixedBond_constantRate serial_Excel_fixedBond_constantRate = serial_Excel_fixedBond_subtype.Excel_fixedBond_constantRate_;
        
            this.maturity_ = serial_Excel_fixedBond_constantRate.Maturity_.ValueStr;
            
            this.maturityPeriod_ = serial_Excel_fixedBond_constantRate.MaturityPeriod_.ValueStr;
            
            this.couponTenor_ = serial_Excel_fixedBond_constantRate.CouponTenor_.ValueStr;
            
            this.couponTenorPeriod_ = serial_Excel_fixedBond_constantRate.CouponTenorPeriod_.ValueStr;
            
            List<FpmlSerializedCSharp.Excel_fixedBond_subSchedule> serial_excel_fixedBond_subSchedule = serial_Excel_fixedBond_constantRate.Excel_fixedBond_subSchedule_;
            this.excel_fixedBond_subScheduleViewModel_ = new ObservableCollection<Excel_fixedBond_subScheduleViewModel>();
            foreach (var item in serial_excel_fixedBond_subSchedule)
            {
                string type = item.Excel_type_.ValueStr;
                Excel_fixedBond_subScheduleViewModel viewModel = Excel_fixedBond_subScheduleViewModel.CreateExcel_fixedBond_subSchedule(type);
                viewModel.setFromSerial(item);
                this.excel_fixedBond_subScheduleViewModel_.Add(viewModel);
            }
            
            this.fixedRate_ = serial_Excel_fixedBond_constantRate.FixedRate_.ValueStr;
            
            this.settlementDays_ = serial_Excel_fixedBond_constantRate.SettlementDays_.ValueStr;
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

