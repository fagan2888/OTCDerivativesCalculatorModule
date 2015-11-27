using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class ConstDualBarrierInfoViewModel : BarrierInfoViewModel
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
        
        public ConstDualBarrierInfoViewModel() { }
        
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
        
        #region BarrierDateInfoViewModel_
        private BarrierDateInfoViewModel barrierDateInfoViewModel_;
        public BarrierDateInfoViewModel BarrierDateInfoViewModel_
        {
            get { return this.barrierDateInfoViewModel_; }
            set
            {
                if (this.barrierDateInfoViewModel_ != value)
                {
                    this.barrierDateInfoViewModel_ = value;
                    this.NotifyPropertyChanged("BarrierDateInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region UpperTrigger_
        private string upperTrigger_;
        public string UpperTrigger_
        {
            get { return this.upperTrigger_; }
            set
            {
                if (this.upperTrigger_ != value)
                {
                    this.upperTrigger_ = value;
                    this.NotifyPropertyChanged("UpperTrigger_");
                }
            }
        }
        #endregion
        
        #region LowerTrigger_
        private string lowerTrigger_;
        public string LowerTrigger_
        {
            get { return this.lowerTrigger_; }
            set
            {
                if (this.lowerTrigger_ != value)
                {
                    this.lowerTrigger_ = value;
                    this.NotifyPropertyChanged("LowerTrigger_");
                }
            }
        }
        #endregion
        
        #region PastEventOccDate_
        private DateTime pastEventOccDate_;
        public DateTime PastEventOccDate_
        {
            get { return this.pastEventOccDate_; }
            set
            {
                if (this.pastEventOccDate_ != value)
                {
                    this.pastEventOccDate_ = value;
                    this.NotifyPropertyChanged("PastEventOccDate_");
                }
            }
        }
        #endregion
        
        #region PastEventOccValue_
        private string pastEventOccValue_;
        public string PastEventOccValue_
        {
            get { return this.pastEventOccValue_; }
            set
            {
                if (this.pastEventOccValue_ != value)
                {
                    this.pastEventOccValue_ = value;
                    this.NotifyPropertyChanged("PastEventOccValue_");
                }
            }
        }
        #endregion
        
        #region RefVariableFlag_eventOccDate_
        private DateTime refVariableFlag_eventOccDate_;
        public DateTime RefVariableFlag_eventOccDate_
        {
            get { return this.refVariableFlag_eventOccDate_; }
            set
            {
                if (this.refVariableFlag_eventOccDate_ != value)
                {
                    this.refVariableFlag_eventOccDate_ = value;
                    this.NotifyPropertyChanged("RefVariableFlag_eventOccDate_");
                }
            }
        }
        #endregion
        
        #region RefVariableFlag_eventOccValue_
        private string refVariableFlag_eventOccValue_;
        public string RefVariableFlag_eventOccValue_
        {
            get { return this.refVariableFlag_eventOccValue_; }
            set
            {
                if (this.refVariableFlag_eventOccValue_ != value)
                {
                    this.refVariableFlag_eventOccValue_ = value;
                    this.NotifyPropertyChanged("RefVariableFlag_eventOccValue_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("barrierInfo");
                xmlWriter.WriteElementString("excel_type" , "constDualBarrierInfo");
                xmlWriter.WriteStartElement("constDualBarrierInfo");
                    referenceCalculationInfoViewModel_.buildXml(xmlWriter);
                    
                    barrierDateInfoViewModel_.buildXml(xmlWriter);
                    
                    xmlWriter.WriteElementString("upperTrigger" , this.upperTrigger_);
                    
                    xmlWriter.WriteElementString("lowerTrigger" , this.lowerTrigger_);
                    
                    xmlWriter.WriteElementString("pastEventOccDate" , StringConverter.xmlDateTimeToDateString(this.pastEventOccDate_));
                    
                    xmlWriter.WriteElementString("pastEventOccValue" , this.pastEventOccValue_);
                    
                    xmlWriter.WriteElementString("refVariableFlag_eventOccDate" , StringConverter.xmlDateTimeToDateString(this.refVariableFlag_eventOccDate_));
                    
                    xmlWriter.WriteElementString("refVariableFlag_eventOccValue" , this.refVariableFlag_eventOccValue_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new ConstDualBarrierInfoView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.BarrierInfo serial_BarrierInfo = serial_Class as FpmlSerializedCSharp.BarrierInfo;
            FpmlSerializedCSharp.ConstDualBarrierInfo serial_ConstDualBarrierInfo = serial_BarrierInfo.ConstDualBarrierInfo_;
        
            FpmlSerializedCSharp.ReferenceCalculationInfo serial_referenceCalculationInfo = serial_ConstDualBarrierInfo.ReferenceCalculationInfo_;
            string referenceCalculationInfotype = serial_referenceCalculationInfo.Excel_type_.ValueStr;
            this.referenceCalculationInfoViewModel_ = ReferenceCalculationInfoViewModel.CreateReferenceCalculationInfo(referenceCalculationInfotype);
            this.referenceCalculationInfoViewModel_.setFromSerial(serial_referenceCalculationInfo);
            
            FpmlSerializedCSharp.BarrierDateInfo serial_barrierDateInfo = serial_ConstDualBarrierInfo.BarrierDateInfo_;
            string barrierDateInfotype = serial_barrierDateInfo.Excel_type_.ValueStr;
            this.barrierDateInfoViewModel_ = BarrierDateInfoViewModel.CreateBarrierDateInfo(barrierDateInfotype);
            this.barrierDateInfoViewModel_.setFromSerial(serial_barrierDateInfo);
            
            this.upperTrigger_ = serial_ConstDualBarrierInfo.UpperTrigger_.ValueStr;
            
            this.lowerTrigger_ = serial_ConstDualBarrierInfo.LowerTrigger_.ValueStr;
            
            this.pastEventOccDate_ = StringConverter.xmlDateToDateTime(serial_ConstDualBarrierInfo.PastEventOccDate_.ValueStr);
            
            this.pastEventOccValue_ = serial_ConstDualBarrierInfo.PastEventOccValue_.ValueStr;
            
            this.refVariableFlag_eventOccDate_ = StringConverter.xmlDateToDateTime(serial_ConstDualBarrierInfo.RefVariableFlag_eventOccDate_.ValueStr);
            
            this.refVariableFlag_eventOccValue_ = serial_ConstDualBarrierInfo.RefVariableFlag_eventOccValue_.ValueStr;
            
        }
        
        
    
            
            
            
            
        
    
        
    
    }
    
}

