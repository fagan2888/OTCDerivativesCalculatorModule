using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class BarrierWithConstRebatePutOptionViewModel : StandardOptionViewModel
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
        
        public BarrierWithConstRebatePutOptionViewModel() { }
        
        #region PayoffDateInfoViewModel_
        private PayoffDateInfoViewModel payoffDateInfoViewModel_;
        public PayoffDateInfoViewModel PayoffDateInfoViewModel_
        {
            get { return this.payoffDateInfoViewModel_; }
            set
            {
                if (this.payoffDateInfoViewModel_ != value)
                {
                    this.payoffDateInfoViewModel_ = value;
                    this.NotifyPropertyChanged("PayoffDateInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region ParticipateRate_
        private string participateRate_;
        public string ParticipateRate_
        {
            get { return this.participateRate_; }
            set
            {
                if (this.participateRate_ != value)
                {
                    this.participateRate_ = value;
                    this.NotifyPropertyChanged("ParticipateRate_");
                }
            }
        }
        #endregion
        
        #region ReferenceCalculationInfoViewModel_
        private ReferenceCalculationInfoViewModel referenceCalculationInfoViewModel_;
        public ReferenceCalculationInfoViewModel ReferenceCalculationInfoViewModel_
        {
            get { return this.referenceCalculationInfoViewModel_; }
            set
            {
                if (this.referenceCalculationInfoViewModel_ != value)
                {
                    this.referenceCalculationInfoViewModel_ = value;
                    this.NotifyPropertyChanged("ReferenceCalculationInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region BarrierInfoViewModel_
        private BarrierInfoViewModel barrierInfoViewModel_;
        public BarrierInfoViewModel BarrierInfoViewModel_
        {
            get { return this.barrierInfoViewModel_; }
            set
            {
                if (this.barrierInfoViewModel_ != value)
                {
                    this.barrierInfoViewModel_ = value;
                    this.NotifyPropertyChanged("BarrierInfoViewModel_");
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
        
        #region LowerBound_
        private string lowerBound_;
        public string LowerBound_
        {
            get { return this.lowerBound_; }
            set
            {
                if (this.lowerBound_ != value)
                {
                    this.lowerBound_ = value;
                    this.NotifyPropertyChanged("LowerBound_");
                }
            }
        }
        #endregion
        
        #region RebateRate_
        private string rebateRate_;
        public string RebateRate_
        {
            get { return this.rebateRate_; }
            set
            {
                if (this.rebateRate_ != value)
                {
                    this.rebateRate_ = value;
                    this.NotifyPropertyChanged("RebateRate_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("standardOption");
                xmlWriter.WriteElementString("type" , "barrierWithConstRebatePutOption");
                xmlWriter.WriteStartElement("barrierWithConstRebatePutOption");
                    payoffDateInfoViewModel_.buildXml(xmlWriter);
                    
                    xmlWriter.WriteElementString("participateRate" , this.participateRate_);
                    
                    referenceCalculationInfoViewModel_.buildXml(xmlWriter);
                    
                    barrierInfoViewModel_.buildXml(xmlWriter);
                    
                    xmlWriter.WriteElementString("strike" , this.strike_);
                    
                    xmlWriter.WriteElementString("lowerBound" , this.lowerBound_);
                    
                    xmlWriter.WriteElementString("rebateRate" , this.rebateRate_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new BarrierWithConstRebatePutOptionView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.StandardOption serial_StandardOption = serial_Class as FpmlSerializedCSharp.StandardOption;
            FpmlSerializedCSharp.BarrierWithConstRebatePutOption serial_BarrierWithConstRebatePutOption = serial_StandardOption.BarrierWithConstRebatePutOption_;
        
            FpmlSerializedCSharp.PayoffDateInfo serial_payoffDateInfo = serial_BarrierWithConstRebatePutOption.PayoffDateInfo_;
            string payoffDateInfotype = serial_payoffDateInfo.Excel_type_.ValueStr;
            this.payoffDateInfoViewModel_ = PayoffDateInfoViewModel.CreatePayoffDateInfo(payoffDateInfotype);
            this.payoffDateInfoViewModel_.setFromSerial(serial_payoffDateInfo);
            
            this.participateRate_ = serial_BarrierWithConstRebatePutOption.ParticipateRate_.ValueStr;
            
            FpmlSerializedCSharp.ReferenceCalculationInfo serial_referenceCalculationInfo = serial_BarrierWithConstRebatePutOption.ReferenceCalculationInfo_;
            string referenceCalculationInfotype = serial_referenceCalculationInfo.Excel_type_.ValueStr;
            this.referenceCalculationInfoViewModel_ = ReferenceCalculationInfoViewModel.CreateReferenceCalculationInfo(referenceCalculationInfotype);
            this.referenceCalculationInfoViewModel_.setFromSerial(serial_referenceCalculationInfo);
            
            FpmlSerializedCSharp.BarrierInfo serial_barrierInfo = serial_BarrierWithConstRebatePutOption.BarrierInfo_;
            string barrierInfotype = serial_barrierInfo.Excel_type_.ValueStr;
            this.barrierInfoViewModel_ = BarrierInfoViewModel.CreateBarrierInfo(barrierInfotype);
            this.barrierInfoViewModel_.setFromSerial(serial_barrierInfo);
            
            this.strike_ = serial_BarrierWithConstRebatePutOption.Strike_.ValueStr;
            
            this.lowerBound_ = serial_BarrierWithConstRebatePutOption.LowerBound_.ValueStr;
            
            this.rebateRate_ = serial_BarrierWithConstRebatePutOption.RebateRate_.ValueStr;
            
        }
        
        
    
            
            
            
            
            
            
        
    
        
    
    }
    
}

