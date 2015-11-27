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
        
        public Excel_digitalCallPutViewModel() { }
        
        #region PayoffDate_
        private DateTime payoffDate_;
        public DateTime PayoffDate_
        {
            get { return this.payoffDate_; }
            set
            {
                if (this.payoffDate_ != value)
                {
                    this.payoffDate_ = value;
                    this.NotifyPropertyChanged("PayoffDate_");
                }
            }
        }
        #endregion
        
        #region ExerciseDate_
        private DateTime exerciseDate_;
        public DateTime ExerciseDate_
        {
            get { return this.exerciseDate_; }
            set
            {
                if (this.exerciseDate_ != value)
                {
                    this.exerciseDate_ = value;
                    this.NotifyPropertyChanged("ExerciseDate_");
                }
            }
        }
        #endregion
        
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
        
        #region UnderlyingCode_
        private string underlyingCode_;
        public string UnderlyingCode_
        {
            get { return this.underlyingCode_; }
            set
            {
                if (this.underlyingCode_ != value)
                {
                    this.underlyingCode_ = value;
                    this.NotifyPropertyChanged("UnderlyingCode_");
                }
            }
        }
        #endregion
        
        #region BaseUnderlyingValue_
        private string baseUnderlyingValue_;
        public string BaseUnderlyingValue_
        {
            get { return this.baseUnderlyingValue_; }
            set
            {
                if (this.baseUnderlyingValue_ != value)
                {
                    this.baseUnderlyingValue_ = value;
                    this.NotifyPropertyChanged("BaseUnderlyingValue_");
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
        private string strikeValue_;
        public string StrikeValue_
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
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_compositeOption_subtype");
                xmlWriter.WriteElementString("excel_type" , "excel_digitalCallPut");
                xmlWriter.WriteStartElement("excel_digitalCallPut");
                    xmlWriter.WriteElementString("payoffDate" , StringConverter.xmlDateTimeToDateString(this.payoffDate_));
                    
                    xmlWriter.WriteElementString("exerciseDate" , StringConverter.xmlDateTimeToDateString(this.exerciseDate_));
                    
                    xmlWriter.WriteElementString("callPut" , this.callPut_);
                    
                    xmlWriter.WriteElementString("underlyingCode" , this.underlyingCode_);
                    
                    xmlWriter.WriteElementString("baseUnderlyingValue" , this.baseUnderlyingValue_);
                    
                    xmlWriter.WriteElementString("baseCoupon" , this.baseCoupon_);
                    
                    xmlWriter.WriteElementString("strike" , this.strike_);
                    
                    xmlWriter.WriteElementString("strikeValue" , this.strikeValue_);
                    
                    xmlWriter.WriteElementString("coupon" , this.coupon_);
                    
                    xmlWriter.WriteElementString("couponValue" , this.couponValue_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_digitalCallPutView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_compositeOption_subtype serial_Excel_compositeOption_subtype = serial_Class as FpmlSerializedCSharp.Excel_compositeOption_subtype;
            FpmlSerializedCSharp.Excel_digitalCallPut serial_Excel_digitalCallPut = serial_Excel_compositeOption_subtype.Excel_digitalCallPut_;
        
            this.payoffDate_ = StringConverter.xmlDateToDateTime(serial_Excel_digitalCallPut.PayoffDate_.ValueStr);
            
            this.exerciseDate_ = StringConverter.xmlDateToDateTime(serial_Excel_digitalCallPut.ExerciseDate_.ValueStr);
            
            this.callPut_ = serial_Excel_digitalCallPut.CallPut_.ValueStr;
            
            this.underlyingCode_ = serial_Excel_digitalCallPut.UnderlyingCode_.ValueStr;
            
            this.baseUnderlyingValue_ = serial_Excel_digitalCallPut.BaseUnderlyingValue_.ValueStr;
            
            this.baseCoupon_ = serial_Excel_digitalCallPut.BaseCoupon_.ValueStr;
            
            this.strike_ = serial_Excel_digitalCallPut.Strike_.ValueStr;
            
            this.strikeValue_ = serial_Excel_digitalCallPut.StrikeValue_.ValueStr;
            
            this.coupon_ = serial_Excel_digitalCallPut.Coupon_.ValueStr;
            
            this.couponValue_ = serial_Excel_digitalCallPut.CouponValue_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

