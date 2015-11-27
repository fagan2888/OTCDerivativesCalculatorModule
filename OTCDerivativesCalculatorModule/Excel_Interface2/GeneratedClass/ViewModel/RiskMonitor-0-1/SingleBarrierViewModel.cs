using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class SingleBarrierViewModel : StandardOptionViewModel
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
        
        public SingleBarrierViewModel() { }
        
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
        
        #region Rebate_
        private string rebate_;
        public string Rebate_
        {
            get { return this.rebate_; }
            set
            {
                if (this.rebate_ != value)
                {
                    this.rebate_ = value;
                    this.NotifyPropertyChanged("Rebate_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("standardOption");
                xmlWriter.WriteElementString("excel_type" , "singleBarrier");
                xmlWriter.WriteStartElement("singleBarrier");
                    payoffDateInfoViewModel_.buildXml(xmlWriter);
                    
                    xmlWriter.WriteElementString("participateRate" , this.participateRate_);
                    
                    barrierInfoViewModel_.buildXml(xmlWriter);
                    
                    xmlWriter.WriteElementString("rebate" , this.rebate_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new SingleBarrierView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.StandardOption serial_StandardOption = serial_Class as FpmlSerializedCSharp.StandardOption;
            FpmlSerializedCSharp.SingleBarrier serial_SingleBarrier = serial_StandardOption.SingleBarrier_;
        
            FpmlSerializedCSharp.PayoffDateInfo serial_payoffDateInfo = serial_SingleBarrier.PayoffDateInfo_;
            string payoffDateInfotype = serial_payoffDateInfo.Excel_type_.ValueStr;
            this.payoffDateInfoViewModel_ = PayoffDateInfoViewModel.CreatePayoffDateInfo(payoffDateInfotype);
            this.payoffDateInfoViewModel_.setFromSerial(serial_payoffDateInfo);
            
            this.participateRate_ = serial_SingleBarrier.ParticipateRate_.ValueStr;
            
            FpmlSerializedCSharp.BarrierInfo serial_barrierInfo = serial_SingleBarrier.BarrierInfo_;
            string barrierInfotype = serial_barrierInfo.Excel_type_.ValueStr;
            this.barrierInfoViewModel_ = BarrierInfoViewModel.CreateBarrierInfo(barrierInfotype);
            this.barrierInfoViewModel_.setFromSerial(serial_barrierInfo);
            
            this.rebate_ = serial_SingleBarrier.Rebate_.ValueStr;
            
        }
        
        
    
            
            
            
            
        
    
        
    
    }
    
}

