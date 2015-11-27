using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class IRCalculationViewModel : IXmlData
    {
        #region View_
        protected Control view_;
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
    
        public IRCalculationViewModel() { }
        
    
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
        
        #region CalculationStartDate_
        private string calculationStartDate_;
        public string CalculationStartDate_
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
        private string calculationEndDate_;
        public string CalculationEndDate_
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
        
        #region PaymentDate_
        private string paymentDate_;
        public string PaymentDate_
        {
            get { return this.paymentDate_; }
            set
            {
                if (this.paymentDate_ != value)
                {
                    this.paymentDate_ = value;
                    this.NotifyPropertyChanged("PaymentDate_");
                }
            }
        }
        #endregion
        
        #region IRCouponCalculationViewModel_
        private IRCouponCalculationViewModel irCouponCalculationViewModel_;
        public IRCouponCalculationViewModel IRCouponCalculationViewModel_
        {
            get { return this.irCouponCalculationViewModel_; }
            set
            {
                if (this.irCouponCalculationViewModel_ != value)
                {
                    this.irCouponCalculationViewModel_ = value;
                    this.NotifyPropertyChanged("IRCouponCalculationViewModel_");
                }
            }
        }
        #endregion
        
        #region InArrear_
        private string inArrear_;
        public string InArrear_
        {
            get { return this.inArrear_; }
            set
            {
                if (this.inArrear_ != value)
                {
                    this.inArrear_ = value;
                    this.NotifyPropertyChanged("InArrear_");
                }
            }
        }
        #endregion

        #region Description_
        private string description_;
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
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.IRCalculation serial_IRCalculation = serial_Class as FpmlSerializedCSharp.IRCalculation;
        
            FpmlSerializedCSharp.CalculationAmount serial_calculationAmount = serial_IRCalculation.CalculationAmount_;
            this.calculationAmountViewModel_ = new CalculationAmountViewModel();
            this.calculationAmountViewModel_.setFromSerial(serial_calculationAmount);
            
            this.calculationStartDate_ = serial_IRCalculation.CalculationStartDate_.ValueStr;
            
            this.calculationEndDate_ = serial_IRCalculation.CalculationEndDate_.ValueStr;
            
            this.paymentDate_ = serial_IRCalculation.PaymentDate_.ValueStr;
            
            FpmlSerializedCSharp.IRCouponCalculation serial_irCouponCalculation = serial_IRCalculation.IrCouponCalculation_;
            string irCouponCalculationtype = serial_irCouponCalculation.Type_.ValueStr;
            this.irCouponCalculationViewModel_ = IRCouponCalculationViewModel.CreateIRCouponCalculation(irCouponCalculationtype);
            this.irCouponCalculationViewModel_.setFromSerial(serial_irCouponCalculation);
            
            this.inArrear_ = serial_IRCalculation.InArrear_.ValueStr;
            
        }
        
            
        #region SelectIrCouponCalculationInfo_
        private string selectIrCouponCalculationInfo_;
        public string SelectIrCouponCalculationInfo_
        {
            get { return this.selectIrCouponCalculationInfo_; }
            set
            {
                if (this.selectIrCouponCalculationInfo_ != value)
                {
                    this.selectIrCouponCalculationInfo_ = value;
                    this.NotifyPropertyChanged("SelectIrCouponCalculationInfo_");
                }
            }
        }
        #endregion
            
        public void selectIRCouponCalculationInfo(string typeStr)
        {
            this.irCouponCalculationViewModel_ = IRCouponCalculationViewModel.CreateIRCouponCalculation(typeStr);
            this.view_.DataContext = this;
        }
    }
    
}

