using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace RiskMonitor
{
    public class CreditEventUnderInfoViewModel : UnderlyingInfoViewModel
    {

        #region FailureToPay_
        private bool failureToPay_;
        public bool FailureToPay_
        {
            get { return this.failureToPay_; }
            set
            {
                if (this.failureToPay_ != value)
                {
                    this.failureToPay_ = value;
                    this.NotifyPropertyChanged("FailureToPay_");
                }
            }
        }
        #endregion

        #region ObligationAcceleration_
        private bool obligationAcceleration_;
        public bool ObligationAcceleration_
        {
            get { return this.obligationAcceleration_; }
            set
            {
                if (this.obligationAcceleration_ != value)
                {
                    this.obligationAcceleration_ = value;
                    this.NotifyPropertyChanged("ObligationAcceleration_");
                }
            }
        }
        #endregion

        #region RepudiationMoratorium_
        private bool repudiationMoratorium_;
        public bool RepudiationMoratorium_
        {
            get { return this.repudiationMoratorium_; }
            set
            {
                if (this.repudiationMoratorium_ != value)
                {
                    this.repudiationMoratorium_ = value;
                    this.NotifyPropertyChanged("RepudiationMoratorium_");
                }
            }
        }
        #endregion

        #region Restructuring_
        private bool restructuring_;
        public bool Restructuring_
        {
            get { return this.restructuring_; }
            set
            {
                if (this.restructuring_ != value)
                {
                    this.restructuring_ = value;
                    this.NotifyPropertyChanged("Restructuring_");
                }
            }
        }
        #endregion

        #region DefaultRequirement_
        private bool defaultRequirement_;
        public bool DefaultRequirement_
        {
            get { return this.defaultRequirement_; }
            set
            {
                if (this.defaultRequirement_ != value)
                {
                    this.defaultRequirement_ = value;
                    this.NotifyPropertyChanged("DefaultRequirement_");
                }
            }
        }
        #endregion

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }

        public override void setFromXml(System.Xml.XmlNode InstNode)
        {
            throw new NotImplementedException();
        }

        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.CreditEvents serial_creditEvents = serial_Class as FpmlSerializedCSharp.CreditEvents;

            this.failureToPay_ = serial_creditEvents.FailureToPay_.BooleanValue();
            this.obligationAcceleration_ = serial_creditEvents.ObligationAcceleration_.BooleanValue();
            this.repudiationMoratorium_ = serial_creditEvents.RepudiationMoratorium_.BooleanValue();
            this.restructuring_ = serial_creditEvents.Restructuring_.BooleanValue();
            this.defaultRequirement_ = serial_creditEvents.DefaultRequirement_.BooleanValue();

            this.view_ = new CreditEventsView();
            this.view_.DataContext = this;
        }
    }
}
