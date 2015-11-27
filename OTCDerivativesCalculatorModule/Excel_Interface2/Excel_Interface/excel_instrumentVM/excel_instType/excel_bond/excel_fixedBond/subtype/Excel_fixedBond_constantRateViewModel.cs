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
        public Excel_fixedBond_constantRateViewModel() 
        {
            this.Excel_type_ = "excel_fixedBond_constantRate";

            this.excel_fixedBond_subScheduleViewModel_ = new ObservableCollection<Excel_fixedBond_subScheduleViewModel>();

        }
        
        //#region Maturity_
        //private DateTime maturity_;
        //public DateTime Maturity_
        //{
        //    get { return this.maturity_; }
        //    set
        //    {
        //        if (this.maturity_ != value)
        //        {
        //            this.maturity_ = value;
        //            this.NotifyPropertyChanged("Maturity_");
        //        }
        //    }
        //}
        //#endregion
        
        //#region MaturityPeriod_
        //private string maturityPeriod_;
        //public string MaturityPeriod_
        //{
        //    get { return this.maturityPeriod_; }
        //    set
        //    {
        //        if (this.maturityPeriod_ != value)
        //        {
        //            this.maturityPeriod_ = value;
        //            this.NotifyPropertyChanged("MaturityPeriod_");
        //        }
        //    }
        //}
        //#endregion
        
        //#region CouponTenor_
        //private string couponTenor_;
        //public string CouponTenor_
        //{
        //    get { return this.couponTenor_; }
        //    set
        //    {
        //        if (this.couponTenor_ != value)
        //        {
        //            this.couponTenor_ = value;
        //            this.NotifyPropertyChanged("CouponTenor_");
        //        }
        //    }
        //}
        //#endregion
        
        //#region CouponTenorPeriod_
        //private string couponTenorPeriod_;
        //public string CouponTenorPeriod_
        //{
        //    get { return this.couponTenorPeriod_; }
        //    set
        //    {
        //        if (this.couponTenorPeriod_ != value)
        //        {
        //            this.couponTenorPeriod_ = value;
        //            this.NotifyPropertyChanged("CouponTenorPeriod_");
        //        }
        //    }
        //}
        //#endregion
        
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
        
        //#region SettlementDays_
        //private string settlementDays_;
        //public string SettlementDays_
        //{
        //    get { return this.settlementDays_; }
        //    set
        //    {
        //        if (this.settlementDays_ != value)
        //        {
        //            this.settlementDays_ = value;
        //            this.NotifyPropertyChanged("SettlementDays_");
        //        }
        //    }
        //}
        //#endregion
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_fixedBond_subtype");
                xmlWriter.WriteElementString("excel_type" , "excel_fixedBond_constantRate");
                xmlWriter.WriteStartElement("excel_fixedBond_constantRate");
                    //xmlWriter.WriteElementString("maturity" , this.maturity_.ToString(StringFormat.XmlDateFormat_));
                    //xmlWriter.WriteElementString("maturityPeriod" , this.maturityPeriod_);
                    //xmlWriter.WriteElementString("couponTenor" , this.couponTenor_);
                    //xmlWriter.WriteElementString("couponTenorPeriod" , this.couponTenorPeriod_);

                    foreach (var item in this.excel_fixedBond_subScheduleViewModel_)
                    {
                        item.buildXml(xmlWriter);    
                    }
                    
                    xmlWriter.WriteElementString("fixedRate" , this.fixedRate_);
                    //xmlWriter.WriteElementString("settlementDays" , this.settlementDays_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_fixedBond_subtype serial_Excel_fixedBond_subtype = serial_Class as FpmlSerializedCSharp.Excel_fixedBond_subtype;
            FpmlSerializedCSharp.Excel_fixedBond_constantRate serial_Excel_fixedBond_constantRate = serial_Excel_fixedBond_subtype.Excel_fixedBond_constantRate_;
        
            //this.maturity_ = StringConverter.xmlDateToDateTime(serial_Excel_fixedBond_constantRate.Maturity_.ValueStr);
            //this.maturityPeriod_ = serial_Excel_fixedBond_constantRate.MaturityPeriod_.ValueStr;
            //this.couponTenor_ = serial_Excel_fixedBond_constantRate.CouponTenor_.ValueStr;
            //this.couponTenorPeriod_ = serial_Excel_fixedBond_constantRate.CouponTenorPeriod_.ValueStr;
            
            List<FpmlSerializedCSharp.Excel_fixedBond_subSchedule> serial_excel_fixedBond_subSchedule = serial_Excel_fixedBond_constantRate.Excel_fixedBond_subSchedule_;
            this.excel_fixedBond_subScheduleViewModel_ = new ObservableCollection<Excel_fixedBond_subScheduleViewModel>();
            foreach (var item in serial_excel_fixedBond_subSchedule)
            {
                //string type = item.Excel_type_.ValueStr;
                Excel_fixedBond_subScheduleViewModel viewModel = new Excel_fixedBond_subScheduleViewModel();
                viewModel.setFromSerial(item);
                this.excel_fixedBond_subScheduleViewModel_.Add(viewModel);
            }
            
            this.fixedRate_ = serial_Excel_fixedBond_constantRate.FixedRate_.ValueStr;
            //this.settlementDays_ = serial_Excel_fixedBond_constantRate.SettlementDays_.ValueStr;
            
        }

        public override void buildProduct()
        {
            this.excel_scheduleListVMBuild();
        }

        public override void excel_scheduleListVMBuild()
        {
            int scheduleNum = this.excel_fixedBond_subScheduleViewModel_.Count; ;

            Excel_fixedCouponScheduleListViewModel e_fcslvm = new Excel_fixedCouponScheduleListViewModel();

            for (int i = 0; i < scheduleNum; i++)
            {
                e_fcslvm.Excel_fixedCouponScheduleViewModel_.Add(
                    this.couponScheduleVMBuild(this.excel_fixedBond_subScheduleViewModel_[i]));
            }

            this.excel_fixedCouponScheduleListViewModel_ = e_fcslvm;
        }

        private Excel_fixedCouponScheduleViewModel couponScheduleVMBuild(Excel_fixedBond_subScheduleViewModel subSchedule)
        {
            Excel_fixedCouponScheduleViewModel e_fcsvm = new Excel_fixedCouponScheduleViewModel();

            e_fcsvm.EventDate_ = subSchedule.PaymentDate_;
            e_fcsvm.CalculationStartDate_ = subSchedule.CalculationStartDate_;
            e_fcsvm.CalculationEndDate_ = subSchedule.CalculationEndDate_;
            e_fcsvm.PayoffDate_ = subSchedule.PaymentDate_;

            //

            return e_fcsvm;
        }

        public override Control view()
        {
            Control v = new Excel_fixedBond_constantRateView();

            v.DataContext = this;

            return v;
        }

        public override void setUnderlying(Excel_underlyingCalcInfoViewModel excel_under)
        {
            this.excel_underlyingCalcInfoViewModel_ = excel_under;
        }

        public override void scheduleDataGenerate()
        {
            this.excel_fixedBond_subScheduleViewModel_.Clear();

            FixedBond_TradeString fb_ts = new FixedBond_TradeString();

            fb_ts.parsingString(this.productString_);

            #region block

            #region comment
            
            
            //this.scheduleGeneratorVM_.InitialDate_ = this.effectiveDate_;
            //this.scheduleGeneratorVM_.EndDate_ = this.maturity_;
            //this.scheduleGeneratorVM_.Tenor_ = this.couponTenor_;
            //this.scheduleGeneratorVM_.PaymentDays_ = this.settlementDays_;

            //this.scheduleGeneratorVM_.Calendar_ = 
            //this.scheduleGeneratorVM_.DateGeneration_ = this.date

            //QLNet.Period maturityPeriod = new Period(maturityTenor, tu);
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

            #endregion

            this.scheduleGeneratorVM_.genDates();

            for (int i = 0; i < this.scheduleGeneratorVM_.Dates_.Count - 1; i++)
            {
                Excel_fixedBond_subScheduleViewModel data = new Excel_fixedBond_subScheduleViewModel();

                data.EventDate_ = this.scheduleGeneratorVM_.Dates_[i+1];

                data.CalculationStartDate_ = this.scheduleGeneratorVM_.Dates_[i];
                data.CalculationEndDate_ = this.scheduleGeneratorVM_.Dates_[i + 1];
                data.PaymentDate_ = this.scheduleGeneratorVM_.Dates_[i + 1].AddDays(Convert.ToDouble(this.scheduleGeneratorVM_.PaymentDays_));
                data.FixedRate_ = this.FixedRate_;

                this.excel_fixedBond_subScheduleViewModel_.Add(data);
            }

        }
    }
    
}

