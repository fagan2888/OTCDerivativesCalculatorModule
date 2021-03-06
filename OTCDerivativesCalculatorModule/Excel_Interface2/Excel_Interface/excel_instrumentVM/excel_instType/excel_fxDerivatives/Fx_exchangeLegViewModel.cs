﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Fx_exchangeLegViewModel : IXmlData , INotifyPropertyChanged
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

        // true : buy , false : sell
        public Fx_exchangeLegViewModel(bool buySell = false) 
        {
            this.exchangeType_ = buySell.ToString();
            this.baseCurrency_ = ProgramVariable.CurrencyStringList_[0].Clone();
            this.targetCurrency_ = ProgramVariable.CurrencyStringList_[1].Clone();
        }

        public void masterEventObserver(object sender, PropertyChangedEventArgs e)
        {
            MasterInformationViewModel mivm = sender as MasterInformationViewModel;

            if (e.PropertyName == "Maturity_date_")
            {
                this.CalculationDate_ = mivm.Maturity_date_;
                this.PaymentDate_
                    = mivm.Maturity_date_.AddDays(Convert.ToDouble(this.PaymentDays_));
            }
            else if (e.PropertyName == "Notional_")
            {
                this.BaseNotional_ = mivm.Notional_;
                //this.BaseCurrency_ = mivm.Currency_.Clone();
            }
            else if (e.PropertyName == "Currency_")
            {
                this.BaseCurrency_.SelectedIndex_ = mivm.Currency_.SelectedIndex_;
            }

        }
        #region TargetNotional_
        private string targetNotional_;
        public string TargetNotional_
        {
            get { return this.targetNotional_; }
            set
            {
                if (this.targetNotional_ != value)
                {
                    this.targetNotional_ = value;
                    this.NotifyPropertyChanged("TargetNotional_");
                }
            }
        }
        #endregion

        #region TargetCurrency_
        private CurrencyViewModel targetCurrency_;
        public CurrencyViewModel TargetCurrency_
        {
            get { return this.targetCurrency_; }
            set
            {
                if (this.targetCurrency_ != value)
                {
                    this.targetCurrency_ = value;
                    this.NotifyPropertyChanged("TargetCurrency_");
                }
            }
        }
        #endregion

        #region BaseNotional_
        private string baseNotional_;
        public string BaseNotional_
        {
            get { return this.baseNotional_; }
            set
            {
                if (this.baseNotional_ != value)
                {
                    this.baseNotional_ = value;
                    this.NotifyPropertyChanged("BaseNotional_");
                }
            }
        }
        #endregion

        #region BaseCurrency_
        private CurrencyViewModel baseCurrency_;
        public CurrencyViewModel BaseCurrency_
        {
            get { return this.baseCurrency_; }
            set
            {
                if (this.baseCurrency_ != value)
                {
                    this.baseCurrency_ = value;
                    this.NotifyPropertyChanged("BaseCurrency_");
                }
            }
        }
        #endregion

        #region ExchangeType_
        private string exchangeType_;
        public string ExchangeType_
        {
            get { return this.exchangeType_; }
            set
            {
                if (this.exchangeType_ != value)
                {
                    this.exchangeType_ = value;
                    this.NotifyPropertyChanged("ExchangeType_");
                }
            }
        }
        #endregion

        #region ExchangeRate_
        private string exchangeRate_;
        public string ExchangeRate_
        {
            get { return this.exchangeRate_; }
            set
            {
                if (this.exchangeRate_ != value)
                {
                    this.exchangeRate_ = value;
                    this.NotifyPropertyChanged("ExchangeRate_");
                }
            }
        }
        #endregion

        #region CalculationDate_
        private DateTime calculationDate_;
        public DateTime CalculationDate_
        {
            get { return this.calculationDate_; }
            set
            {
                if (this.calculationDate_ != value)
                {
                    this.calculationDate_ = value;
                    this.NotifyPropertyChanged("CalculationDate_");
                }
            }
        }
        #endregion

        #region PaymentDays_
        private string paymentDays_;
        public string PaymentDays_
        {
            get { return this.paymentDays_; }
            set
            {
                if (this.paymentDays_ != value)
                {
                    this.paymentDays_ = value;
                    this.NotifyPropertyChanged("PaymentDays_");
                }
            }
        }
        #endregion

        #region PaymentDate_
        private DateTime paymentDate_;
        public DateTime PaymentDate_
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

        #region ForwardPoint_
        private string forwardPoint_;
        public string ForwardPoint_
        {
            get { return this.forwardPoint_; }
            set
            {
                if (this.forwardPoint_ != value)
                {
                    this.forwardPoint_ = value;
                    this.NotifyPropertyChanged("ForwardPoint_");
                }
            }
        }
        #endregion

        public void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("fx_exchangeLeg");
                xmlWriter.WriteElementString("targetNotional", this.targetNotional_);
                xmlWriter.WriteElementString("targetCurrency", this.targetCurrency_.CurrencyCode_);
                xmlWriter.WriteElementString("baseNotional", this.baseNotional_);
                xmlWriter.WriteElementString("baseCurrency", this.baseCurrency_.CurrencyCode_);
                xmlWriter.WriteElementString("exchangeType", this.exchangeType_);
                xmlWriter.WriteElementString("exchangeRate", this.exchangeRate_);
                xmlWriter.WriteElementString("calculationDate", this.calculationDate_.ToString(StringFormat.DbDateFormat_));
                xmlWriter.WriteElementString("paymentDays", this.paymentDays_);
                xmlWriter.WriteElementString("paymentDate", this.paymentDate_.ToString(StringFormat.DbDateFormat_));
                xmlWriter.WriteElementString("forwardPoint", this.forwardPoint_);
            xmlWriter.WriteEndElement();
        }

        public void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }

        public void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Fx_exchangeLeg serial_Fx_exchangeLeg = serial_Class as FpmlSerializedCSharp.Fx_exchangeLeg;

            this.targetNotional_ = serial_Fx_exchangeLeg.TargetNotional_.ValueStr;
            this.targetCurrency_ = CurrencyViewModel.CreateCurrencyComboViewModel(serial_Fx_exchangeLeg.TargetCurrency_.ValueStr);
            this.baseNotional_ = serial_Fx_exchangeLeg.BaseNotional_.ValueStr;
            this.baseCurrency_ = CurrencyViewModel.CreateCurrencyComboViewModel(serial_Fx_exchangeLeg.BaseCurrency_.ValueStr);
            this.exchangeType_ = serial_Fx_exchangeLeg.ExchangeType_.ValueStr;
            this.exchangeRate_ = serial_Fx_exchangeLeg.ExchangeRate_.ValueStr;
            this.calculationDate_ = StringConverter.dbDateToDateTime(serial_Fx_exchangeLeg.CalculationDate_.ValueStr);
            this.paymentDays_ = serial_Fx_exchangeLeg.PaymentDays_.ValueStr;
            this.paymentDate_ = StringConverter.dbDateToDateTime(serial_Fx_exchangeLeg.PaymentDate_.ValueStr);
            this.forwardPoint_ = serial_Fx_exchangeLeg.ForwardPoint_.ValueStr;

        }

        public Control view()
        {
            Control v = new Fx_exchangeLegView();

            v.DataContext = this;

            return v;
        }

        public void bookingEvent(MasterInformationViewModel masterInformationViewModel, EVENT_INFO_Table_DAO dao)
        {
            dao.EVENT_DATE_ = this.paymentDate_.ToString(StringFormat.DbDateFormat_);
            dao.EVENT_TYPE_ = "Settlement";
            dao.EVENT_SUBTYPE_ = "Pay";
            //dao.EVENT_DESCRIPTION_ = this.description_;
            dao.EVENT_NAME_ = "FxExchange";
            dao.CURRENCY_ = this.targetCurrency_.CurrencyCode_;

            ////dao.OBSERVATION_END_DATE_ = this.calculationDate_.ToString(StringFormat.DbDateFormat_);
            ////dao.OBSERVATION_END_DATE_ = this.calculationDate_.ToString(StringFormat.DbDateFormat_);

        }
    }

}

