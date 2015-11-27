using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class Make_instrument_structuredBond
    {
        #region InstVM_
        private Excel_instrument_structuredBondViewModel instVM_;
        public Excel_instrument_structuredBondViewModel InstVM_
        {
            get { return this.instVM_; }
            set
            {
                if (this.instVM_ != value)
                {
                    this.instVM_ = value;
                }
            }
        }
        #endregion

        public Make_instrument_structuredBond()
        {
            this.instVM_ = new Excel_instrument_structuredBondViewModel(true);
        }

        public void makeIssueInfo(DateTime effectiveDate,DateTime maturityDate, double notional, string currency,string dayCounter)
        {
            Excel_noteInfoViewModel e_nvm = new Excel_noteInfoViewModel();

            e_nvm.EffectiveDate_ = effectiveDate;
            e_nvm.MaturityDate_ = maturityDate;
            e_nvm.Notional_ = notional.ToString();
            e_nvm.Currency_ = new CurrencyViewModel(currency,currency);
            //e_nvm.dayCounter
            
            this.instVM_.Excel_interfaceViewModel_.Excel_issueInfoViewModel_ = e_nvm;
        }

        private void addUnderlying(DateTime effDate, string underCode )
        {
            foreach (var item in this.instVM_.Excel_interfaceViewModel_.Excel_underlyingCalcInfoViewModel_.Excel_underlyingInfoViewModel_)
            {
                if (underCode == item.KrCode_)
                {
                    return;
                }
            }

            this.instVM_.Excel_interfaceViewModel_.Excel_underlyingCalcInfoViewModel_.Excel_underlyingInfoViewModel_
                .Add(Excel_loaderViewModel.loadUnderInfo2(effDate, underCode));


        }

        // coupon
        public void addFixedCoupon(DateTime calculationStartDate, DateTime calculationEndDate, DateTime payoffDate, double fixedRate)
        { 
            Excel_fixedCouponScheduleViewModel e_fcsvm = new Excel_fixedCouponScheduleViewModel();

            e_fcsvm.EventDate_ = payoffDate;

            e_fcsvm.CalculationStartDate_ = calculationStartDate;
            e_fcsvm.CalculationEndDate_ = calculationEndDate;
            e_fcsvm.PayoffDate_ = payoffDate;
            e_fcsvm.FixedRate_ = fixedRate.ToString();

            Excel_structuredBondViewModel e_sbvm = this.instVM_.Excel_interfaceViewModel_ as Excel_structuredBondViewModel;

            e_sbvm.Excel_couponScheduleListViewModel_.Excel_couponScheduleViewModel_.Add(e_fcsvm);

            //this.instVM_.Excel_interfaceViewModel_ = e_sbvm;

        }

        public void addSingleConditionDualRangAccrualFixedCoupon(DateTime calculationStartDate,
                                                DateTime calculationEndDate,
                                                DateTime payoffDate,
                                                List<double> lowerRngList,
                                                List<string> referenceUnderCodeList,
                                                List<double> upperRngList,
                                                double fixedRate)
        {
            Excel_multiCondi_multiRng_structuredAccrualCouponScheduleViewModel e_mc_mr_sacsvm
                    = new Excel_multiCondi_multiRng_structuredAccrualCouponScheduleViewModel();

            e_mc_mr_sacsvm.EventDate_ = payoffDate;

            e_mc_mr_sacsvm.CalculationStartDate_ = calculationStartDate;
            e_mc_mr_sacsvm.CalculationEndDate_ = calculationEndDate;
            e_mc_mr_sacsvm.PayoffDate_ = payoffDate;

            int rangeCount = lowerRngList.Count;

            Excel_multi_rangeNDViewModel e_m_rngNDVM = new Excel_multi_rangeNDViewModel();

            for (int i = 0; i < rangeCount; i++)
            {
                Range1DViewModel accRng1D = new Range1DViewModel();

                accRng1D.LowerBound_ = lowerRngList[i].ToString();

                DateTime effDate = this.instVM_.Excel_interfaceViewModel_.Excel_issueInfoViewModel_.EffectiveDate_;
                
                //this.addUnderlying(Excel_loaderViewModel.loadUnderInfo2(effDate, referenceUnderCodeList[i]));
                this.addUnderlying(effDate, referenceUnderCodeList[i]);

                Excel_choiceUnderlyingCalcIDViewModel choiceUnderCalcIDVM = new Excel_choiceUnderlyingCalcIDViewModel();

                choiceUnderCalcIDVM.EventDate_ = payoffDate;

                Excel_selectedUnderlyingViewModel selectedUnder = new Excel_selectedUnderlyingViewModel();
                selectedUnder.Code_ = referenceUnderCodeList[i];
                selectedUnder.NameTrans_ = new NameTrans(referenceUnderCodeList[i]);
                selectedUnder.Checked_ = true;

                choiceUnderCalcIDVM.Excel_selectedUnderlyingViewModel_.Add(selectedUnder);

                accRng1D.UpperBound_ = upperRngList[i].ToString();

                e_m_rngNDVM.Range1DViewModel_.Add(accRng1D);
                e_m_rngNDVM.Excel_underlyingCalcIDViewModel_.Add(choiceUnderCalcIDVM);
            }

            e_mc_mr_sacsvm.Excel_multi_rangeNDViewModel_.Add(e_m_rngNDVM);

            Excel_constReturnCalViewModel e_crcvm = new Excel_constReturnCalViewModel();

            e_crcvm.ConstReturn_ = fixedRate.ToString();

            e_mc_mr_sacsvm.Excel_returnCalcInfoViewModel_.Add(e_crcvm);

            //e_mc_sacsvm.FixedRate_ = fixedRate.ToString();

            Excel_structuredBondViewModel e_sbvm = this.instVM_.Excel_interfaceViewModel_ as Excel_structuredBondViewModel;

            e_sbvm.Excel_couponScheduleListViewModel_.Excel_couponScheduleViewModel_.Add(e_mc_mr_sacsvm);

            //this.instVM_.Excel_interfaceViewModel_ = e_sbvm;
        }

        public void addConditionMultiRangAccrualFixedCoupon(DateTime calculationStartDate, 
                                                DateTime calculationEndDate, 
                                                DateTime payoffDate, 
                                                List<double> lowerRngList,
                                                List<string> referenceUnderCodeList,
                                                List<double> upperRngList,
                                                double fixedRate)
        {
            Excel_multiCondi_structuredAccrualCouponScheduleViewModel e_mc_sacsvm
                = new Excel_multiCondi_structuredAccrualCouponScheduleViewModel();

            e_mc_sacsvm.EventDate_ = payoffDate;

            e_mc_sacsvm.CalculationStartDate_ = calculationStartDate;
            e_mc_sacsvm.CalculationEndDate_ = calculationEndDate;
            e_mc_sacsvm.PaymentDate_ = payoffDate;

            int rangeCount = lowerRngList.Count;

            for (int i = 0; i < rangeCount; i++)
            {
                Range1DViewModel accRng1D = new Range1DViewModel();

                accRng1D.LowerBound_ = lowerRngList[i].ToString();

                DateTime effDate = this.instVM_.Excel_interfaceViewModel_.Excel_issueInfoViewModel_.EffectiveDate_;
                //this.addUnderlying(Excel_loaderViewModel.loadUnderInfo2(effDate, referenceUnderCodeList[i]));
                this.addUnderlying(effDate, referenceUnderCodeList[i]);

                Excel_choiceUnderlyingCalcIDViewModel choiceUnderCalcIDVM = new Excel_choiceUnderlyingCalcIDViewModel();
                
                choiceUnderCalcIDVM.EventDate_ = payoffDate;

                Excel_selectedUnderlyingViewModel selectedUnder = new Excel_selectedUnderlyingViewModel();
                selectedUnder.Code_ = referenceUnderCodeList[i];
                selectedUnder.NameTrans_ = new NameTrans(referenceUnderCodeList[i]);
                selectedUnder.Checked_ = true;

                choiceUnderCalcIDVM.Excel_selectedUnderlyingViewModel_.Add(selectedUnder);

                accRng1D.UpperBound_ = upperRngList[i].ToString();

                e_mc_sacsvm.Range1DViewModel_.Add(accRng1D);
                e_mc_sacsvm.Excel_underlyingCalcIDViewModel_.Add(choiceUnderCalcIDVM);
            }
                

            Excel_constReturnCalViewModel e_crcvm = new Excel_constReturnCalViewModel();

            e_crcvm.ConstReturn_ = fixedRate.ToString();

            e_mc_sacsvm.Excel_returnCalcInfoViewModel_.Add(e_crcvm);

            //e_mc_sacsvm.FixedRate_ = fixedRate.ToString();

            Excel_structuredBondViewModel e_sbvm = this.instVM_.Excel_interfaceViewModel_ as Excel_structuredBondViewModel;

            e_sbvm.Excel_couponScheduleListViewModel_.Excel_couponScheduleViewModel_.Add(e_mc_sacsvm);

            //this.instVM_.Excel_interfaceViewModel_ = e_sbvm;

        }

     


        public void addVanillaCoupon(DateTime calculationStartDate, 
                                    DateTime calculationEndDate, 
                                    DateTime payoffDate, 
                                    double gearing, 
                                    double spread,
                                    string underlyingCode )
        {

        }




        


    }
}
