using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace RiskMonitor
{
    public class ProtectionTermViewModel : IXmlData
    {

        #region View_
        private Control view_;
        public Control View_
        {
            get { return this.view_; }
            set
            {
                if (this.view_ != value)
                {
                    this.view_ = value;
                    this.NotifyPropertyChanged("View_");
                }
            }
        }
        #endregion

        #region CalculationAmountViewModel_
        private CalculationAmountViewModel calculationAmountViewModel_;
        public CalculationAmountViewModel CalculationAmountViewModel_
        {
            get { return this.calculationAmountViewModel_; }
            set
            {
                if (this.calculationAmountViewModel_ != value)
                {
                    this.calculationAmountViewModel_ = value;
                    this.NotifyPropertyChanged("CalculationAmountViewModel_");
                }
            }
        }
        #endregion

        //#region Notional_
        //private double notional_;
        //public double Notional_
        //{
        //    get { return this.notional_; }
        //    set
        //    {
        //        if (this.notional_ != value)
        //        {
        //            this.notional_ = value;
        //            this.NotifyPropertyChanged("Notional_");
        //        }
        //    }
        //}
        //#endregion

        //#region Currency_
        //private string currency_;
        //public string Currency_
        //{
        //    get { return this.currency_; }
        //    set
        //    {
        //        if (this.currency_ != value)
        //        {
        //            this.currency_ = value;
        //            this.NotifyPropertyChanged("Currency_");
        //        }
        //    }
        //}
        //#endregion

        #region CreditEventsVM_
        private CreditEventUnderInfoViewModel creditEventsVM_;
        public CreditEventUnderInfoViewModel CreditEventsVM_
        {
            get { return this.creditEventsVM_; }
            set
            {
                if (this.creditEventsVM_ != value)
                {
                    this.creditEventsVM_ = value;
                    this.NotifyPropertyChanged("CreditEventsVM_");
                }
            }
        }
        #endregion

        #region ObligationsVM_
        private ObligationsViewModel obligationsVM_;
        public ObligationsViewModel ObligationsVM_
        {
            get { return this.obligationsVM_; }
            set
            {
                if (this.obligationsVM_ != value)
                {
                    this.obligationsVM_ = value;
                    this.NotifyPropertyChanged("ObligationsVM_");
                }
            }
        }
        #endregion

        #region AccrualCoupon_
        private bool accrualCoupon_;
        public bool AccrualCoupon_
        {
            get { return this.accrualCoupon_; }
            set
            {
                if (this.accrualCoupon_ != value)
                {
                    this.accrualCoupon_ = value;
                    this.NotifyPropertyChanged("AccrualCoupon_");
                }
            }
        }
        #endregion

        #region Event

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        public void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }

        public void setFromXml(System.Xml.XmlNode InstNode)
        {
            throw new NotImplementedException();
        }

        public void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ProtectionTerms serial_protect = serial_Class as FpmlSerializedCSharp.ProtectionTerms;

            CreditEventUnderInfoViewModel creditEventsVM = new CreditEventUnderInfoViewModel();
            creditEventsVM.setFromSerial(serial_protect.CreditEvents_);

            ObligationsViewModel obliVM = new ObligationsViewModel();
            obliVM.setFromSerial(serial_protect.Obligations_);

            this.view_ = new ProtectionTermView();
            this.view_.DataContext = this;

        }
    }
}
