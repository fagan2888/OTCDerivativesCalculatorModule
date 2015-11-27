using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public abstract class Excel_underlyingInfoViewModel : IXmlData , INotifyPropertyChanged
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
    
        public Excel_underlyingInfoViewModel() { }
    
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

        #region KrCode_
        protected string krCode_;
        public string KrCode_
        {
            get { return this.krCode_; }
            set
            {
                if (this.krCode_ != value)
                {
                    this.krCode_ = value;
                    this.NotifyPropertyChanged("KrCode_");
                }
            }
        }
        #endregion

        #region NameTrans_
        protected NameTrans nameTrans_;
        public NameTrans NameTrans_
        {
            get { return this.nameTrans_; }
            set
            {
                if (this.nameTrans_ != value)
                {
                    this.nameTrans_ = value;
                    this.NotifyPropertyChanged("NameTrans_");
                }
            }
        }
        #endregion

        #region Currency_
        private string currency_;
        public string Currency_
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

        #region RateType_
        private string rateType_;
        public string RateType_
        {
            get { return this.rateType_; }
            set
            {
                if (this.rateType_ != value)
                {
                    this.rateType_ = value;
                    this.NotifyPropertyChanged("RateType_");
                }
            }
        }
        #endregion

        #region BasePrice_
        protected string basePrice_;
        public string BasePrice_
        {
            get { return this.basePrice_; }
            set
            {
                if (this.basePrice_ != value)
                {
                    this.basePrice_ = value;
                    this.NotifyPropertyChanged("BasePrice_");
                }
            }
        }
        #endregion

        #region Sub_type_
        protected string sub_type_;
        public string Sub_type_
        {
            get { return this.sub_type_; }
            set
            {
                if (this.sub_type_ != value)
                {
                    this.sub_type_ = value;
                    this.NotifyPropertyChanged("Sub_type_");
                }
            }
        }
        #endregion

        #region Tenor_
        protected string tenor_;
        public string Tenor_
        {
            get { return this.tenor_; }
            set
            {
                if (this.tenor_ != value)
                {
                    this.tenor_ = value;
                    this.NotifyPropertyChanged("Tenor_");
                }
            }
        }
        #endregion

        #region LegTenor_
        private string legTenor_;
        public string LegTenor_
        {
            get { return this.legTenor_; }
            set
            {
                if (this.legTenor_ != value)
                {
                    this.legTenor_ = value;
                    this.NotifyPropertyChanged("LegTenor_");
                }
            }
        }
        #endregion

        #region LinkedCurveCode_
        protected string linkedCurveCode_;
        public string LinkedCurveCode_
        {
            get { return this.linkedCurveCode_; }
            set
            {
                if (this.linkedCurveCode_ != value)
                {
                    this.linkedCurveCode_ = value;
                    this.NotifyPropertyChanged("LinkedCurveCode_");
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

        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void buildPricingXml(XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
    
        public static Excel_underlyingInfoViewModel CreateExcel_underlyingInfo(string typeStr)
        {
            if ( typeStr == "excel_stockIndex")
            {
                return new Excel_stockIndexViewModel();
            }
            else if ( typeStr == "excel_interestRate")
            {
                return new Excel_interestRateViewModel();
            }
            else if (typeStr == "excel_indexType")
            {
                return new Excel_indexTypeViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }

        public string vba_desciption()
        {
            string str = "";

            str += "type=" + this.Excel_type_ + ";";
            str += "code=" + this.KrCode_ + ";";
            str += "name=" + this.NameTrans_.Value_ + ";";
            str += "basePrice=" + this.BasePrice_ + ";";
            str += "subtype=" + this.Sub_type_ + ";";
            str += "tenor=" + this.Tenor_+ ";";
            str += "linkedCurve=" + this.LinkedCurveCode_ + ";";
            str += "rate_type=" + this.RateType_ + ";";
            str += "leg_tenor=" + this.LegTenor_ + ";";
            str += "currency=" + this.Currency_ + ";";

            return str;
        }

        public void descriptionUpdate()
        {
            this.description_ = "basePrice : " + this.basePrice_;
        }
    }
    
}

