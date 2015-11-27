using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_downInOutPutViewModel : Excel_compositeOption_subtypeViewModel
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
        
        public Excel_downInOutPutViewModel() { }
        
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
        
        #region InOut_
        private string inOut_;
        public string InOut_
        {
            get { return this.inOut_; }
            set
            {
                if (this.inOut_ != value)
                {
                    this.inOut_ = value;
                    this.NotifyPropertyChanged("InOut_");
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
        
        #region Barrier_
        private string barrier_;
        public string Barrier_
        {
            get { return this.barrier_; }
            set
            {
                if (this.barrier_ != value)
                {
                    this.barrier_ = value;
                    this.NotifyPropertyChanged("Barrier_");
                }
            }
        }
        #endregion
        
        #region BarrierValue_
        private string barrierValue_;
        public string BarrierValue_
        {
            get { return this.barrierValue_; }
            set
            {
                if (this.barrierValue_ != value)
                {
                    this.barrierValue_ = value;
                    this.NotifyPropertyChanged("BarrierValue_");
                }
            }
        }
        #endregion
        
        #region RebateCoupon_
        private string rebateCoupon_;
        public string RebateCoupon_
        {
            get { return this.rebateCoupon_; }
            set
            {
                if (this.rebateCoupon_ != value)
                {
                    this.rebateCoupon_ = value;
                    this.NotifyPropertyChanged("RebateCoupon_");
                }
            }
        }
        #endregion
        
        #region RebateCouponValue_
        private string rebateCouponValue_;
        public string RebateCouponValue_
        {
            get { return this.rebateCouponValue_; }
            set
            {
                if (this.rebateCouponValue_ != value)
                {
                    this.rebateCouponValue_ = value;
                    this.NotifyPropertyChanged("RebateCouponValue_");
                }
            }
        }
        #endregion
        
        #region ObservationStartDate_
        private DateTime observationStartDate_;
        public DateTime ObservationStartDate_
        {
            get { return this.observationStartDate_; }
            set
            {
                if (this.observationStartDate_ != value)
                {
                    this.observationStartDate_ = value;
                    this.NotifyPropertyChanged("ObservationStartDate_");
                }
            }
        }
        #endregion
        
        #region ObservationEndDate_
        private DateTime observationEndDate_;
        public DateTime ObservationEndDate_
        {
            get { return this.observationEndDate_; }
            set
            {
                if (this.observationEndDate_ != value)
                {
                    this.observationEndDate_ = value;
                    this.NotifyPropertyChanged("ObservationEndDate_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_compositeOption_subtype");
                xmlWriter.WriteElementString("type" , "excel_downInOutPut");
                xmlWriter.WriteStartElement("excel_downInOutPut");
                    xmlWriter.WriteElementString("payoffDate" , StringConverter.xmlDateTimeToDateString(this.payoffDate_));
                    
                    xmlWriter.WriteElementString("exerciseDate" , StringConverter.xmlDateTimeToDateString(this.exerciseDate_));
                    
                    xmlWriter.WriteElementString("inOut" , this.inOut_);
                    
                    xmlWriter.WriteElementString("underlyingCode" , this.underlyingCode_);
                    
                    xmlWriter.WriteElementString("baseUnderlyingValue" , this.baseUnderlyingValue_);
                    
                    xmlWriter.WriteElementString("baseCoupon" , this.baseCoupon_);
                    
                    xmlWriter.WriteElementString("strike" , this.strike_);
                    
                    xmlWriter.WriteElementString("strikeValue" , this.strikeValue_);
                    
                    xmlWriter.WriteElementString("partiRate" , this.partiRate_);
                    
                    xmlWriter.WriteElementString("barrier" , this.barrier_);
                    
                    xmlWriter.WriteElementString("barrierValue" , this.barrierValue_);
                    
                    xmlWriter.WriteElementString("rebateCoupon" , this.rebateCoupon_);
                    
                    xmlWriter.WriteElementString("rebateCouponValue" , this.rebateCouponValue_);
                    
                    xmlWriter.WriteElementString("observationStartDate" , StringConverter.xmlDateTimeToDateString(this.observationStartDate_));
                    
                    xmlWriter.WriteElementString("observationEndDate" , StringConverter.xmlDateTimeToDateString(this.observationEndDate_));
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_downInOutPutView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_compositeOption_subtype serial_Excel_compositeOption_subtype = serial_Class as FpmlSerializedCSharp.Excel_compositeOption_subtype;
            FpmlSerializedCSharp.Excel_downInOutPut serial_Excel_downInOutPut = serial_Excel_compositeOption_subtype.Excel_downInOutPut_;
        
            this.payoffDate_ = StringConverter.xmlDateToDateTime(serial_Excel_downInOutPut.PayoffDate_.ValueStr);
            
            this.exerciseDate_ = StringConverter.xmlDateToDateTime(serial_Excel_downInOutPut.ExerciseDate_.ValueStr);
            
            this.inOut_ = serial_Excel_downInOutPut.InOut_.ValueStr;
            
            this.underlyingCode_ = serial_Excel_downInOutPut.UnderlyingCode_.ValueStr;
            
            this.baseUnderlyingValue_ = serial_Excel_downInOutPut.BaseUnderlyingValue_.ValueStr;
            
            this.baseCoupon_ = serial_Excel_downInOutPut.BaseCoupon_.ValueStr;
            
            this.strike_ = serial_Excel_downInOutPut.Strike_.ValueStr;
            
            this.strikeValue_ = serial_Excel_downInOutPut.StrikeValue_.ValueStr;
            
            this.partiRate_ = serial_Excel_downInOutPut.PartiRate_.ValueStr;
            
            this.barrier_ = serial_Excel_downInOutPut.Barrier_.ValueStr;
            
            this.barrierValue_ = serial_Excel_downInOutPut.BarrierValue_.ValueStr;
            
            this.rebateCoupon_ = serial_Excel_downInOutPut.RebateCoupon_.ValueStr;
            
            this.rebateCouponValue_ = serial_Excel_downInOutPut.RebateCouponValue_.ValueStr;
            
            this.observationStartDate_ = StringConverter.xmlDateToDateTime(serial_Excel_downInOutPut.ObservationStartDate_.ValueStr);
            
            this.observationEndDate_ = StringConverter.xmlDateToDateTime(serial_Excel_downInOutPut.ObservationEndDate_.ValueStr);
            
        }
        
        
    
        
    
        
    
    }
    
}

