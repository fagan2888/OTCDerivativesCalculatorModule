using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class StepDownKIViewModel : PayoffInfoViewModel
    {
    
        public StepDownKIViewModel() 
        {
            
        }
        
        #region RedemptionInfoViewModel_
        private RedemptionInfoViewModel redemptionInfoViewModel_;
        public RedemptionInfoViewModel RedemptionInfoViewModel_
        {
            get { return this.redemptionInfoViewModel_; }
            set
            {
                if (this.redemptionInfoViewModel_ != value)
                {
                    this.redemptionInfoViewModel_ = value;
                    this.NotifyPropertyChanged("RedemptionInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region KiEventInfoViewModel_
        private KiEventInfoViewModel kiEventInfoViewModel_;
        public KiEventInfoViewModel KiEventInfoViewModel_
        {
            get { return this.kiEventInfoViewModel_; }
            set
            {
                if (this.kiEventInfoViewModel_ != value)
                {
                    this.kiEventInfoViewModel_ = value;
                    this.NotifyPropertyChanged("KiEventInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region NonKiEventInfoViewModel_
        private NonKiEventInfoViewModel nonKiEventInfoViewModel_;
        public NonKiEventInfoViewModel NonKiEventInfoViewModel_
        {
            get { return this.nonKiEventInfoViewModel_; }
            set
            {
                if (this.nonKiEventInfoViewModel_ != value)
                {
                    this.nonKiEventInfoViewModel_ = value;
                    this.NotifyPropertyChanged("NonKiEventInfoViewModel_");
                }
            }
        }
        #endregion

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("payoffInfo");
                xmlWriter.WriteElementString("type" , "stepDownKI");
                xmlWriter.WriteStartElement("stepDownKI");
                    redemptionInfoViewModel_.buildXml(xmlWriter);
                    
                    kiEventInfoViewModel_.buildXml(xmlWriter);
                    
                    nonKiEventInfoViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.PayoffInfo serial_PayoffInfo = serial_Class as FpmlSerializedCSharp.PayoffInfo;
            FpmlSerializedCSharp.StepDownKI serial_StepDownKI = serial_PayoffInfo.StepDownKI_;
        
            FpmlSerializedCSharp.RedemptionInfo serial_redemptionInfo = serial_StepDownKI.RedemptionInfo_;
            string redemptionInfotype = serial_redemptionInfo.Type_.ValueStr;
            this.redemptionInfoViewModel_ = RedemptionInfoViewModel.CreateRedemptionInfo(redemptionInfotype);
            this.redemptionInfoViewModel_.setFromSerial(serial_redemptionInfo);
            
            FpmlSerializedCSharp.KiEventInfo serial_kiEventInfo = serial_StepDownKI.KiEventInfo_;
            string kiEventInfotype = serial_kiEventInfo.Type_.ValueStr;
            this.kiEventInfoViewModel_ = KiEventInfoViewModel.CreateKiEventInfo(kiEventInfotype);
            this.kiEventInfoViewModel_.setFromSerial(serial_kiEventInfo);
            
            FpmlSerializedCSharp.NonKiEventInfo serial_nonKiEventInfo = serial_StepDownKI.NonKiEventInfo_;
            string nonKiEventInfotype = serial_nonKiEventInfo.Type_.ValueStr;
            this.nonKiEventInfoViewModel_ = NonKiEventInfoViewModel.CreateNonKiEventInfo(nonKiEventInfotype);
            this.nonKiEventInfoViewModel_.setFromSerial(serial_nonKiEventInfo);
            
            this.view_ = new StepDownKIView();
            this.view_.DataContext = this;
        }
        
        
    
            #region SelectRedemptionInfoInfo_
            private string selectRedemptionInfoInfo_;
            public string SelectRedemptionInfoInfo_
            {
                get { return this.selectRedemptionInfoInfo_; }
                set
                {
                    if (this.selectRedemptionInfoInfo_ != value)
                    {
                        this.selectRedemptionInfoInfo_ = value;
                        this.NotifyPropertyChanged("SelectRedemptionInfoInfo_");
                    }
                }
            }
            #endregion
            
            public void selectRedemptionInfoInfo(string typeStr)
            {
                this.redemptionInfoViewModel_ = RedemptionInfoViewModel.CreateRedemptionInfo(typeStr);
                this.view_.DataContext = this;
            }
            
            #region SelectKiEventInfoInfo_
            private string selectKiEventInfoInfo_;
            public string SelectKiEventInfoInfo_
            {
                get { return this.selectKiEventInfoInfo_; }
                set
                {
                    if (this.selectKiEventInfoInfo_ != value)
                    {
                        this.selectKiEventInfoInfo_ = value;
                        this.NotifyPropertyChanged("SelectKiEventInfoInfo_");
                    }
                }
            }
            #endregion
            
            public void selectKiEventInfoInfo(string typeStr)
            {
                this.kiEventInfoViewModel_ = KiEventInfoViewModel.CreateKiEventInfo(typeStr);
                this.view_.DataContext = this;
            }
            
            #region SelectNonKiEventInfoInfo_
            private string selectNonKiEventInfoInfo_;
            public string SelectNonKiEventInfoInfo_
            {
                get { return this.selectNonKiEventInfoInfo_; }
                set
                {
                    if (this.selectNonKiEventInfoInfo_ != value)
                    {
                        this.selectNonKiEventInfoInfo_ = value;
                        this.NotifyPropertyChanged("SelectNonKiEventInfoInfo_");
                    }
                }
            }
            #endregion
            
            public void selectNonKiEventInfoInfo(string typeStr)
            {
                this.nonKiEventInfoViewModel_ = NonKiEventInfoViewModel.CreateNonKiEventInfo(typeStr);
                this.view_.DataContext = this;
            }
            
        
    
        
    
    }
    
}

