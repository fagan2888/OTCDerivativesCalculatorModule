using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_multiAsset_digitalCallPutViewModel : Excel_multiAsset_compositeOption_subtypeViewModel
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
        
        public Excel_multiAsset_digitalCallPutViewModel() { }
        
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
        
        #region Excel_underlyingCalcIDViewModel_
        private Excel_underlyingCalcIDViewModel excel_underlyingCalcIDViewModel_;
        public Excel_underlyingCalcIDViewModel Excel_underlyingCalcIDViewModel_
        {
            get { return this.excel_underlyingCalcIDViewModel_; }
            set
            {
                if (this.excel_underlyingCalcIDViewModel_ != value)
                {
                    this.excel_underlyingCalcIDViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_underlyingCalcIDViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_multiAsset_compositeOption_subtype");
                xmlWriter.WriteElementString("type" , "excel_multiAsset_digitalCallPut");
                xmlWriter.WriteStartElement("excel_multiAsset_digitalCallPut");
                    xmlWriter.WriteElementString("payoffDate" , StringConverter.xmlDateTimeToDateString(this.payoffDate_));
                    
                    xmlWriter.WriteElementString("exerciseDate" , StringConverter.xmlDateTimeToDateString(this.exerciseDate_));
                    
                    xmlWriter.WriteElementString("callPut" , this.callPut_);
                    
                    xmlWriter.WriteElementString("baseUnderlyingValue" , this.baseUnderlyingValue_);
                    
                    xmlWriter.WriteElementString("baseCoupon" , this.baseCoupon_);
                    
                    xmlWriter.WriteElementString("strike" , this.strike_);
                    
                    xmlWriter.WriteElementString("strikeValue" , this.strikeValue_);
                    
                    xmlWriter.WriteElementString("coupon" , this.coupon_);
                    
                    xmlWriter.WriteElementString("couponValue" , this.couponValue_);
                    
                    excel_underlyingCalcIDViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_multiAsset_digitalCallPutView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_multiAsset_compositeOption_subtype serial_Excel_multiAsset_compositeOption_subtype = serial_Class as FpmlSerializedCSharp.Excel_multiAsset_compositeOption_subtype;
            FpmlSerializedCSharp.Excel_multiAsset_digitalCallPut serial_Excel_multiAsset_digitalCallPut = serial_Excel_multiAsset_compositeOption_subtype.Excel_multiAsset_digitalCallPut_;
        
            this.payoffDate_ = StringConverter.xmlDateToDateTime(serial_Excel_multiAsset_digitalCallPut.PayoffDate_.ValueStr);
            
            this.exerciseDate_ = StringConverter.xmlDateToDateTime(serial_Excel_multiAsset_digitalCallPut.ExerciseDate_.ValueStr);
            
            this.callPut_ = serial_Excel_multiAsset_digitalCallPut.CallPut_.ValueStr;
            
            this.baseUnderlyingValue_ = serial_Excel_multiAsset_digitalCallPut.BaseUnderlyingValue_.ValueStr;
            
            this.baseCoupon_ = serial_Excel_multiAsset_digitalCallPut.BaseCoupon_.ValueStr;
            
            this.strike_ = serial_Excel_multiAsset_digitalCallPut.Strike_.ValueStr;
            
            this.strikeValue_ = serial_Excel_multiAsset_digitalCallPut.StrikeValue_.ValueStr;
            
            this.coupon_ = serial_Excel_multiAsset_digitalCallPut.Coupon_.ValueStr;
            
            this.couponValue_ = serial_Excel_multiAsset_digitalCallPut.CouponValue_.ValueStr;
            
            FpmlSerializedCSharp.Excel_underlyingCalcID serial_excel_underlyingCalcID = serial_Excel_multiAsset_digitalCallPut.Excel_underlyingCalcID_;
            string excel_underlyingCalcIDtype = serial_excel_underlyingCalcID.Excel_type_.ValueStr;
            this.excel_underlyingCalcIDViewModel_ = Excel_underlyingCalcIDViewModel.CreateExcel_underlyingCalcID(excel_underlyingCalcIDtype);
            this.excel_underlyingCalcIDViewModel_.setFromSerial(serial_excel_underlyingCalcID);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

