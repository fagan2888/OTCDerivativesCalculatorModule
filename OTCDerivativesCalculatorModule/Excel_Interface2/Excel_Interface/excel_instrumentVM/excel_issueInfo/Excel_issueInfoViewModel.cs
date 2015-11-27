using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public abstract class Excel_issueInfoViewModel : IXmlData , INotifyPropertyChanged
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

        #region Currency_
        protected CurrencyViewModel currency_;
        public CurrencyViewModel Currency_
        {
            get { return this.currency_; }
            set
            {
                if (this.currency_ != value)
                {
                    this.currency_ = value;
                    this.NotifyPropertyChanged("Currency_");
                }
            }
        }
        #endregion

        #region Notional_
        protected string notional_;
        public string Notional_
        {
            get { return this.notional_; }
            set
            {
                if (this.notional_ != value)
                {
                    this.notional_ = value;
                    this.NotifyPropertyChanged("Notional_");
                }
            }
        }
        #endregion

        //#region TradeDate_
        //protected DateTime tradeDate_;
        //public DateTime TradeDate_
        //{
        //    get { return this.tradeDate_; }
        //    set
        //    {
        //        if (this.tradeDate_ != value)
        //        {
        //            this.tradeDate_ = value;
        //            this.NotifyPropertyChanged("TradeDate_");
        //        }
        //    }
        //}
        //#endregion

        #region EffectiveDate_
        protected DateTime effectiveDate_;
        public DateTime EffectiveDate_
        {
            get { return this.effectiveDate_; }
            set
            {
                if (this.effectiveDate_ != value)
                {
                    this.effectiveDate_ = value;
                    this.NotifyPropertyChanged("EffectiveDate_");
                }
            }
        }
        #endregion

        #region MaturityDate_
        protected DateTime maturityDate_;
        public DateTime MaturityDate_
        {
            get { return this.maturityDate_; }
            set
            {
                if (this.maturityDate_ != value)
                {
                    this.maturityDate_ = value;

                    //this.maturityYear_ = (this.maturityDate_ - this.effectiveDate_).TotalDays / 365;

                    this.NotifyPropertyChanged("MaturityDate_");
                }
            }
        }
        #endregion

        #region MaturityYear_
        protected double maturityYear_;
        public double MaturityYear_
        {
            get { return this.maturityYear_; }
            set
            {
                if (this.maturityYear_ != value)
                {
                    this.maturityYear_ = value;
                    //this.maturityDate_ = this.maturityDate_.AddDays(this.maturityYear_ * 365);
                    this.NotifyPropertyChanged("MaturityYear_");
                }
            }
        }
        #endregion

        #region IncludeNotionalPayment_
        protected string includeNotionalPayment_;
        public string IncludeNotionalPayment_
        {
            get { return this.includeNotionalPayment_; }
            set
            {
                if (this.includeNotionalPayment_ != value)
                {
                    this.includeNotionalPayment_ = value;
                    this.NotifyPropertyChanged("IncludeNotionalPayment_");
                }
            }
        }
        #endregion

        #region VBA_description_
        protected string vba_description_;
        public string VBA_description_
        {
            get { return this.vba_description_; }
            set
            {
                if (this.vba_description_ != value)
                {
                    this.vba_description_ = value;
                    this.NotifyPropertyChanged("VBA_description_");
                }
            }
        }
        #endregion

        public Excel_issueInfoViewModel()
        {
            //this.tradeDate_ = ProgramVariable.ReferenceDate_;
            this.effectiveDate_ = ProgramVariable.ReferenceDate_;
        }
    
        #region Excel_type_
        private string excel_type_;
        public string Excel_type_
        {
            get { return this.excel_type_; }
            set
            {
                if (this.excel_type_ != value)
                {
                    this.excel_type_ = value;
                    this.NotifyPropertyChanged("Excel_type_");
                }
            }
        }
        #endregion
        
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        //public abstract void buildPricingXml(XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);

        //public abstract void vmBuildFromExcel_interface();
        
        public void calculateMaturityYearAndDate()
        {
            
        }

        public static Excel_issueInfoViewModel CreateExcel_issueInfo(string typeStr)
        {
            if ( typeStr == "excel_noteInfo")
            {
                return new Excel_noteInfoViewModel();
            }
            else if (typeStr == "excel_swapInfo")
            {
                return new Excel_swapInfoViewModel();
            }
            else if (typeStr == "excel_swapLegInfo")
            {
                return new Excel_swapLegInfoViewModel();
            }
            else if (typeStr == "excel_emptyInfo")
            {
                return new Excel_emptyInfoViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        //public static Excel_issueInfoViewModel CreateExcel_issueInfo(FpmlSerializedCSharp.ISerialized serial_Class)
        //{
        //    FpmlSerializedCSharp.Excel_issueInfo serial_Excel_issueInfo = serial_Class as FpmlSerializedCSharp.Excel_issueInfo;
        //    string typeStr = serial_Excel_issueInfo.Type_.ValueStr;
        //    return Excel_issueInfoViewModel.CreateExcel_issueInfo(typeStr);
        //}

        public void MaturityDateObserver(object sender, PropertyChangedEventArgs e)
        {
            MasterInformationViewModel mivm = sender as MasterInformationViewModel;

            //if (e.PropertyName == "Maturity_date_")
            //{
            //    this.MaturityDate_ = mivm.Maturity_date_;
            //}
            //else 
            if (e.PropertyName == "Notional_")
            {
                this.Notional_ = mivm.Notional_;
            }
            else if (e.PropertyName == "Currency_")
            {
                this.Currency_ = mivm.Currency_.Clone();
            }

            // Excel_noteInfoView ¿¡ ¿¬°á

        }

        public abstract Control view();
    }
    
}

