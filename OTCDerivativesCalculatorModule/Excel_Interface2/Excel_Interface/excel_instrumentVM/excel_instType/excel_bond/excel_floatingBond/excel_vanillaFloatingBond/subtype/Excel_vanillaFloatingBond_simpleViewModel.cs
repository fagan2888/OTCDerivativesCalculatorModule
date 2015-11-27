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
        public Excel_vanillaFloatingBond_simpleViewModel() 
        {
            this.Excel_type_ = "excel_vanillaFloatingBond_simple";

            this.excel_vanillaFloatingBond_subScheduleViewModel_ 
                = new ObservableCollection<Excel_vanillaFloatingBond_subScheduleViewModel>();

        }
    
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

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_vanillaFloatingBond_subtype");
                xmlWriter.WriteElementString("excel_type" , "excel_vanillaFloatingBond_simple");
                xmlWriter.WriteStartElement("excel_vanillaFloatingBond_simple");
                    
                    xmlWriter.WriteElementString("maturity" , this.maturity_);
                    xmlWriter.WriteElementString("maturityPeriod" , this.maturityPeriod_);
                    xmlWriter.WriteElementString("couponTenor" , this.couponTenor_);
                    xmlWriter.WriteElementString("couponTenorPeriod" , this.couponTenorPeriod_);

                    foreach (var item in this.excel_vanillaFloatingBond_subScheduleViewModel_)
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
                //string type = item.Excel_type_.ValueStr;
                Excel_vanillaFloatingBond_subScheduleViewModel viewModel = new Excel_vanillaFloatingBond_subScheduleViewModel();
                viewModel.setFromSerial(item);
                this.excel_vanillaFloatingBond_subScheduleViewModel_.Add(viewModel);
            }
            
            this.gearing_ = serial_Excel_vanillaFloatingBond_simple.Gearing_.ValueStr;
            this.spread_ = serial_Excel_vanillaFloatingBond_simple.Spread_.ValueStr;
            this.settlementDays_ = serial_Excel_vanillaFloatingBond_simple.SettlementDays_.ValueStr;
            
        }

        public override void buildProduct()
        {
            this.excel_couponScheduleListVMBuild();
        }

        public override void excel_couponScheduleListVMBuild()
        {
            throw new NotImplementedException();
        }

        public override Control view()
        {
            Control v = new Excel_vanillaFloatingBond_simpleView();

            v.DataContext = this;

            return v;
        }

        public override void setUnderlying(Excel_underlyingCalcInfoViewModel excel_under)
        {
            this.excel_underlyingCalcInfoViewModel_ = excel_under;
        }

        public override void excel_scheduleListVMBuild()
        {
            int scheduleNum = this.excel_vanillaFloatingBond_subScheduleViewModel_.Count; ;

            Excel_vanillaFloatingCouponScheduleListViewModel e_vfcslvm = new Excel_vanillaFloatingCouponScheduleListViewModel();
            //excel_vanillaFloatingCouponScheduleViewModel_

            for (int i = 0; i < scheduleNum; i++)
            {
                e_vfcslvm.Excel_vanillaFloatingCouponScheduleViewModel_.Add(
                    this.excel_vanillaSimpleVMBuild(this.excel_vanillaFloatingBond_subScheduleViewModel_[i]));
            }

            this.Excel_vanillaFloatingCouponScheduleListViewModel_ = e_vfcslvm;
        }

        private Excel_vanillaFloatingCouponScheduleViewModel excel_vanillaSimpleVMBuild(Excel_vanillaFloatingBond_subScheduleViewModel excel_subScheduleVM)
        {
            Excel_vanillaFloatingCouponScheduleViewModel e_vfcsvm = new Excel_vanillaFloatingCouponScheduleViewModel();

            e_vfcsvm.EventDate_ = excel_subScheduleVM.EventDate_;

            e_vfcsvm.CalculationStartDate_ = excel_subScheduleVM.CalculationStartDate_;
            e_vfcsvm.CalculationEndDate_ = excel_subScheduleVM.CalculationEndDate_;
            e_vfcsvm.PayoffDate_ = excel_subScheduleVM.PaymentDate_;
            e_vfcsvm.Gearing_ = excel_subScheduleVM.Gearing_;
            e_vfcsvm.Spread_ = excel_subScheduleVM.Spread_;
            
            e_vfcsvm.Excel_underlyingCalcInfoViewModel_ = this.excel_underlyingCalcInfoViewModel_;

            e_vfcsvm.Excel_underlyingCalcIDViewModel_ = new Excel_maximumUnderlyingCalcIDViewModel();

            return e_vfcsvm;
        }

        public void scheduleDataGenerate()
        {
            VanillaFloatingBond_TradeString vfb_ts = new VanillaFloatingBond_TradeString();

            vfb_ts.parsingString(this.productString_);

            this.excel_vanillaFloatingBond_subScheduleViewModel_.Clear();

            #region block
            
            

            //this.scheduleGeneratorVM_.InitialDate_ = this.effectiveDate_;

            ////QLNet.Period maturityPeriod = new Period(maturityTenor, tu);
            //QLNet.Period maturityPeriod = new Period(this.maturity_);

            //// Y 말고 M도 처리해야함 // 우선은 int로 하자 1.5Y이런거는 잠시 대기
            //int maturityTenor = maturityPeriod.length();

            //TimeUnit tu = maturityPeriod.units(); //TimeUnit.Years;

            //this.scheduleGeneratorVM_.EndDate_ = this.effectiveDate_.AddYears(maturityTenor);

            //QLNet.Period couponPeriod = new Period(this.couponTenor_); //new Period(couponTenor, tu);

            //// coupon
            //int couponTenor = couponPeriod.length();
            //double couponMultiplier = Convert.ToDouble(couponPeriod.frequency());//1.0;

            //this.scheduleGeneratorVM_.Tenor_ = couponPeriod.ToShortString();

            //int addingDays = 0;

            //this.scheduleGeneratorVM_.genDates(addingDays);

            //ObservableCollection<DateTime> eventDates = this.scheduleGeneratorVM_.Dates_;

            //int scheduleLength = eventDates.Count;

            //this.SettlementDays_ = Convert.ToInt32(tsm.SettlementDays_);
            #endregion

            for (int i = 0; i < this.scheduleGeneratorVM_.Dates_.Count - 1; i++)
            {
                Excel_vanillaFloatingBond_subScheduleViewModel data = new Excel_vanillaFloatingBond_subScheduleViewModel();

                data.EventDate_ = new DateTime();

                data.CalculationStartDate_ = this.scheduleGeneratorVM_.Dates_[i];
                data.CalculationEndDate_ = this.scheduleGeneratorVM_.Dates_[i + 1];
                data.FixingDate_ = this.scheduleGeneratorVM_.Dates_[i];
                data.PaymentDate_ = this.scheduleGeneratorVM_.Dates_[i + 1].AddDays(Convert.ToDouble(this.scheduleGeneratorVM_.PaymentDays_));

                data.Gearing_ = this.Gearing_;
                data.Spread_ = this.Spread_;

                this.excel_vanillaFloatingBond_subScheduleViewModel_.Add(data);
            }
        }
    }
    
}

