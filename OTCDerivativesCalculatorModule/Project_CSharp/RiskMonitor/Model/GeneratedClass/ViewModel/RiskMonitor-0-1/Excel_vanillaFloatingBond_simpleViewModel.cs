using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_vanillaFloatingBond_simpleViewModel : Excel_vanillaFloatingBond_subtypeViewModel
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
        
        public Excel_vanillaFloatingBond_simpleViewModel() { }
        
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
        
        #region Excel_vanillaFloatingBond_subScheduleViewModel_
        private ObservableCollection<Excel_vanillaFloatingBond_subScheduleViewModel> excel_vanillaFloatingBond_subScheduleViewModel_;
        public ObservableCollection<Excel_vanillaFloatingBond_subScheduleViewModel> Excel_vanillaFloatingBond_subScheduleViewModel_
        {
            get { return this.excel_vanillaFloatingBond_subScheduleViewModel_; }
            set
            {
                if (this.excel_vanillaFloatingBond_subScheduleViewModel_ != value)
                {
                    this.excel_vanillaFloatingBond_subScheduleViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_vanillaFloatingBond_subScheduleViewModel_");
                }
            }
        }
        #endregion
        
        #region Gearing_
        private string gearing_;
        public string Gearing_
        {
            get { return this.gearing_; }
            set
            {
                if (this.gearing_ != value)
                {
                    this.gearing_ = value;
                    this.NotifyPropertyChanged("Gearing_");
                }
            }
        }
        #endregion
        
        #region Spread_
        private string spread_;
        public string Spread_
        {
            get { return this.spread_; }
            set
            {
                if (this.spread_ != value)
                {
                    this.spread_ = value;
                    this.NotifyPropertyChanged("Spread_");
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
            xmlWriter.WriteStartElement("excel_vanillaFloatingBond_subtype");
                xmlWriter.WriteElementString("type" , "excel_vanillaFloatingBond_simple");
                xmlWriter.WriteStartElement("excel_vanillaFloatingBond_simple");
                    xmlWriter.WriteElementString("maturity" , this.maturity_);
                    
                    xmlWriter.WriteElementString("maturityPeriod" , this.maturityPeriod_);
                    
                    xmlWriter.WriteElementString("couponTenor" , this.couponTenor_);
                    
                    xmlWriter.WriteElementString("couponTenorPeriod" , this.couponTenorPeriod_);
                    
                    foreach (var item in excel_vanillaFloatingBond_subScheduleViewModel_)
                    {
                        item.buildXml(xmlWriter);
                    }
                    
                    xmlWriter.WriteElementString("gearing" , this.gearing_);
                    
                    xmlWriter.WriteElementString("spread" , this.spread_);
                    
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
            Control v = new Excel_vanillaFloatingBond_simpleView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_vanillaFloatingBond_subtype serial_Excel_vanillaFloatingBond_subtype = serial_Class as FpmlSerializedCSharp.Excel_vanillaFloatingBond_subtype;
            FpmlSerializedCSharp.Excel_vanillaFloatingBond_simple serial_Excel_vanillaFloatingBond_simple = serial_Excel_vanillaFloatingBond_subtype.Excel_vanillaFloatingBond_simple_;
        
            this.maturity_ = serial_Excel_vanillaFloatingBond_simple.Maturity_.ValueStr;
            
            this.maturityPeriod_ = serial_Excel_vanillaFloatingBond_simple.MaturityPeriod_.ValueStr;
            
            this.couponTenor_ = serial_Excel_vanillaFloatingBond_simple.CouponTenor_.ValueStr;
            
            this.couponTenorPeriod_ = serial_Excel_vanillaFloatingBond_simple.CouponTenorPeriod_.ValueStr;
            
            List<FpmlSerializedCSharp.Excel_vanillaFloatingBond_subSchedule> serial_excel_vanillaFloatingBond_subSchedule = serial_Excel_vanillaFloatingBond_simple.Excel_vanillaFloatingBond_subSchedule_;
            this.excel_vanillaFloatingBond_subScheduleViewModel_ = new ObservableCollection<Excel_vanillaFloatingBond_subScheduleViewModel>();
            foreach (var item in serial_excel_vanillaFloatingBond_subSchedule)
            {
                string type = item.Excel_type_.ValueStr;
                Excel_vanillaFloatingBond_subScheduleViewModel viewModel = Excel_vanillaFloatingBond_subScheduleViewModel.CreateExcel_vanillaFloatingBond_subSchedule(type);
                viewModel.setFromSerial(item);
                this.excel_vanillaFloatingBond_subScheduleViewModel_.Add(viewModel);
            }
            
            this.gearing_ = serial_Excel_vanillaFloatingBond_simple.Gearing_.ValueStr;
            
            this.spread_ = serial_Excel_vanillaFloatingBond_simple.Spread_.ValueStr;
            
            this.settlementDays_ = serial_Excel_vanillaFloatingBond_simple.SettlementDays_.ValueStr;
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

