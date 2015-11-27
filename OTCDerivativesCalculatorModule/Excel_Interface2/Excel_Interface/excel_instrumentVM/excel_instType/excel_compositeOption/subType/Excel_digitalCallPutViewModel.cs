using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_digitalCallPutViewModel : Excel_compositeOption_subtypeViewModel
    {
        public Excel_digitalCallPutViewModel() 
        {
            this.excel_Type_ = "excel_digitalCallPut";
        }

        #region CallPut_
        private string callPut_;
        public string CallPut_
        {
            get { return this.callPut_; }
            set
            {
                if (this.callPut_ != value)
                {
                    this.callPut_ = value;
                    this.NotifyPropertyChanged("CallPut_");
                }
            }
        }
        #endregion

        #region BaseCoupon_
        private string baseCoupon_;
        public string BaseCoupon_
        {
            get { return this.baseCoupon_; }
            set
            {
                if (this.baseCoupon_ != value)
                {
                    this.baseCoupon_ = value;
                    this.NotifyPropertyChanged("BaseCoupon_");
                }
            }
        }
        #endregion

        #region Strike_
        private string strike_;
        public string Strike_
        {
            get { return this.strike_; }
            set
            {
                if (this.strike_ != value)
                {
                    this.strike_ = value;
                    this.NotifyPropertyChanged("Strike_");
                }
            }
        }
        #endregion

        #region StrikeValue_
        private double strikeValue_;
        public double StrikeValue_
        {
            get { return this.strikeValue_; }
            set
            {
                if (this.strikeValue_ != value)
                {
                    this.strikeValue_ = value;
                    this.NotifyPropertyChanged("StrikeValue_");
                }
            }
        }
        #endregion

        #region Coupon_
        private string coupon_;
        public string Coupon_
        {
            get { return this.coupon_; }
            set
            {
                if (this.coupon_ != value)
                {
                    this.coupon_ = value;
                    this.NotifyPropertyChanged("Coupon_");
                }
            }
        }
        #endregion

        #region CouponValue_
        private string couponValue_;
        public string CouponValue_
        {
            get { return this.couponValue_; }
            set
            {
                if (this.couponValue_ != value)
                {
                    this.couponValue_ = value;
                    this.NotifyPropertyChanged("CouponValue_");
                }
            }
        }
        #endregion


        public override void DefaultSetting(Excel_compositeOptionViewModel e_covm)
        {
            this.callPut_ = "Call";
            this.baseCoupon_ = "0.0";
            this.strike_ = "100.0";
            //this.strikeValue_ = Convert.ToDouble(this.strike_) * this.baseUnderlyingValue_;
            this.coupon_ = "0.0";
            this.couponValue_ = "0.0";
        }

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_compositeOption_subtype");
                xmlWriter.WriteElementString("excel_type", "excel_digitalCallPut");
                xmlWriter.WriteStartElement("excel_digitalCallPut");

                    xmlWriter.WriteElementString("exerciseDate", this.exerciseDate_.ToString(StringFormat.XmlDateFormat_));
                    xmlWriter.WriteElementString("payoffDate", this.payoffDate_.ToString(StringFormat.XmlDateFormat_));
                    xmlWriter.WriteElementString("callPut", this.callPut_);
                    xmlWriter.WriteElementString("underlyingCode", this.underlyingCode_);
                    xmlWriter.WriteElementString("baseCoupon", (Convert.ToDouble( this.baseCoupon_)/100.0).ToString() );
                    xmlWriter.WriteElementString("strike", (Convert.ToDouble( this.strike_)/100.0).ToString() );
                    xmlWriter.WriteElementString("strikeValue", this.strikeValue_.ToString());
                    xmlWriter.WriteElementString("coupon", (Convert.ToDouble(this.coupon_) / 100.0).ToString() );
                    xmlWriter.WriteElementString("couponValue", this.couponValue_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_compositeOption_subtype serial_Excel_compositeOption_subtype = serial_Class as FpmlSerializedCSharp.Excel_compositeOption_subtype;
            FpmlSerializedCSharp.Excel_digitalCallPut serial_Excel_digitalCallPut = serial_Excel_compositeOption_subtype.Excel_digitalCallPut_;

            this.exerciseDate_ = StringConverter.xmlDateToDateTime(serial_Excel_digitalCallPut.ExerciseDate_.ValueStr);
            this.payoffDate_ = StringConverter.xmlDateToDateTime(serial_Excel_digitalCallPut.PayoffDate_.ValueStr);
            this.baseUnderlyingValue_ = serial_Excel_digitalCallPut.BaseUnderlyingValue_.DoubleValue();
            this.underlyingCode_ = serial_Excel_digitalCallPut.UnderlyingCode_.ValueStr;
            this.callPut_ = serial_Excel_digitalCallPut.CallPut_.ValueStr;
            this.baseCoupon_ = ( serial_Excel_digitalCallPut.BaseCoupon_.DoubleValue() * 100.0).ToString();
            this.strike_ = ( serial_Excel_digitalCallPut.Strike_.DoubleValue() * 100.0).ToString();
            this.strikeValue_ = serial_Excel_digitalCallPut.StrikeValue_.DoubleValue();
            this.coupon_ = ( serial_Excel_digitalCallPut.Coupon_.DoubleValue() * 100.0).ToString();
            this.couponValue_ = serial_Excel_digitalCallPut.CouponValue_.ValueStr;
            
        }

        public override Excel_compositeOption_subtypeViewModel Clone()
        {
            Excel_digitalCallPutViewModel clone = new Excel_digitalCallPutViewModel();

            clone.CallPut_ = this.callPut_;
            clone.BaseUnderlyingValue_ = this.baseUnderlyingValue_;
            clone.UnderlyingCode_= this.underlyingCode_;
            clone.BaseCoupon_ = this.baseCoupon_;
            clone.ExerciseDate_ = this.exerciseDate_;
            clone.PayoffDate_ = this.payoffDate_;

            clone.Strike_ = this.strike_;
            clone.StrikeValue_ = this.strikeValue_;
            clone.Coupon_ = this.coupon_;
            clone.CouponValue_ = this.couponValue_;
            clone.Description_ = this.description_;

            return clone;
        }

        public override void descriptionUpdate()
        {
            this.description_ = "Digital" + this.strike_ + " " + this.callPut_;
        }

        public override Control view()
        {
            System.Windows.Controls.Control v = new Excel_digitalCallPutView();

            v.DataContext = this;

            return v;
        }

        public override void bookingEvent(MasterInformationViewModel masterInformationViewModel, 
                                          EVENT_INFO_Table_DAO dao)
        {
            dao.EVENT_TYPE_ = "compositeOptionSubTypeTest";
            dao.EVENT_NAME_ = "digitalCallPut";
        }

        public override void setUnderlying(Excel_underlyingCalcInfoViewModel excel_under)
        {
            this.excel_underlyingCalcInfoViewModel_ = excel_under;
        }

        public override Excel_compositeOptionLoaderView loaderView(Excel_compositeOptionViewModel e_covm)
        {
            throw new NotImplementedException();
        }

        public override void setInterfaceViewModel(Excel_compositeOptionViewModel e_covm)
        {
            this.exerciseDate_ = e_covm.Excel_issueInfoViewModel_.MaturityDate_;
            this.payoffDate_ = e_covm.PayoffDate_;
            this.underlyingCode_ = e_covm.Excel_underlyingCalcInfoViewModel_.Excel_underlyingInfoViewModel_[0].KrCode_;
        }

    }
    
}

