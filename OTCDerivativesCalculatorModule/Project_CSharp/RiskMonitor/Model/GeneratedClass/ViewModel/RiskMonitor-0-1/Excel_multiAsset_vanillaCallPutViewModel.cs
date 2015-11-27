using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_multiAsset_vanillaCallPutViewModel : Excel_multiAsset_compositeOption_subtypeViewModel
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
        
        public Excel_multiAsset_vanillaCallPutViewModel() { }
        
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
        
        #region PartiRate_
        private string partiRate_;
        public string PartiRate_
        {
            get { return this.partiRate_; }
            set
            {
                if (this.partiRate_ != value)
                {
                    this.partiRate_ = value;
                    this.NotifyPropertyChanged("PartiRate_");
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
                xmlWriter.WriteElementString("type" , "excel_multiAsset_vanillaCallPut");
                xmlWriter.WriteStartElement("excel_multiAsset_vanillaCallPut");
                    xmlWriter.WriteElementString("payoffDate" , StringConverter.xmlDateTimeToDateString(this.payoffDate_));
                    
                    xmlWriter.WriteElementString("exerciseDate" , StringConverter.xmlDateTimeToDateString(this.exerciseDate_));
                    
                    xmlWriter.WriteElementString("baseUnderlyingValue" , this.baseUnderlyingValue_);
                    
                    xmlWriter.WriteElementString("callPut" , this.callPut_);
                    
                    xmlWriter.WriteElementString("baseCoupon" , this.baseCoupon_);
                    
                    xmlWriter.WriteElementString("strike" , this.strike_);
                    
                    xmlWriter.WriteElementString("strikeValue" , this.strikeValue_);
                    
                    xmlWriter.WriteElementString("partiRate" , this.partiRate_);
                    
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
            Control v = new Excel_multiAsset_vanillaCallPutView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_multiAsset_compositeOption_subtype serial_Excel_multiAsset_compositeOption_subtype = serial_Class as FpmlSerializedCSharp.Excel_multiAsset_compositeOption_subtype;
            FpmlSerializedCSharp.Excel_multiAsset_vanillaCallPut serial_Excel_multiAsset_vanillaCallPut = serial_Excel_multiAsset_compositeOption_subtype.Excel_multiAsset_vanillaCallPut_;
        
            this.payoffDate_ = StringConverter.xmlDateToDateTime(serial_Excel_multiAsset_vanillaCallPut.PayoffDate_.ValueStr);
            
            this.exerciseDate_ = StringConverter.xmlDateToDateTime(serial_Excel_multiAsset_vanillaCallPut.ExerciseDate_.ValueStr);
            
            this.baseUnderlyingValue_ = serial_Excel_multiAsset_vanillaCallPut.BaseUnderlyingValue_.ValueStr;
            
            this.callPut_ = serial_Excel_multiAsset_vanillaCallPut.CallPut_.ValueStr;
            
            this.baseCoupon_ = serial_Excel_multiAsset_vanillaCallPut.BaseCoupon_.ValueStr;
            
            this.strike_ = serial_Excel_multiAsset_vanillaCallPut.Strike_.ValueStr;
            
            this.strikeValue_ = serial_Excel_multiAsset_vanillaCallPut.StrikeValue_.ValueStr;
            
            this.partiRate_ = serial_Excel_multiAsset_vanillaCallPut.PartiRate_.ValueStr;
            
            FpmlSerializedCSharp.Excel_underlyingCalcID serial_excel_underlyingCalcID = serial_Excel_multiAsset_vanillaCallPut.Excel_underlyingCalcID_;
            string excel_underlyingCalcIDtype = serial_excel_underlyingCalcID.Excel_type_.ValueStr;
            this.excel_underlyingCalcIDViewModel_ = Excel_underlyingCalcIDViewModel.CreateExcel_underlyingCalcID(excel_underlyingCalcIDtype);
            this.excel_underlyingCalcIDViewModel_.setFromSerial(serial_excel_underlyingCalcID);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

