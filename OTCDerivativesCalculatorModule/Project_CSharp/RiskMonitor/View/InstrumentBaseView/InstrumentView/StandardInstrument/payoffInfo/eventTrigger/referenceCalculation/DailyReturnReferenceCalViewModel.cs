using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class DailyReturnReferenceCalViewModel : ReferenceCalculationViewModel
    {
        public DailyReturnReferenceCalViewModel() { }
        
    
        #region KrCode_
        private string krCode_;
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
        
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("referenceCalculation");
                xmlWriter.WriteElementString("type" , "dailyReturnReferenceCal");
                xmlWriter.WriteStartElement("dailyReturnReferenceCal");
                    xmlWriter.WriteElementString("krCode" , this.krCode_);
                    
                    fixingDateInfoViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ReferenceCalculation serial_ReferenceCalculation = serial_Class as FpmlSerializedCSharp.ReferenceCalculation;
            FpmlSerializedCSharp.DailyReturnReferenceCal serial_DailyReturnReferenceCal = serial_ReferenceCalculation.DailyReturnReferenceCal_;
        
            this.krCode_ = serial_DailyReturnReferenceCal.KrCode_.ValueStr;
            
            FpmlSerializedCSharp.FixingDateInfo serial_fixingDateInfo = serial_DailyReturnReferenceCal.FixingDateInfo_;
            string fixingDateInfotype = serial_fixingDateInfo.Type_.ValueStr;
            this.fixingDateInfoViewModel_ = FixingDateInfoViewModel.CreateFixingDateInfo(fixingDateInfotype);
            this.fixingDateInfoViewModel_.setFromSerial(serial_fixingDateInfo);
            
           //this.view_ = new DailyReturnReferenceCalView();
            this.view_.DataContext = this;
        }
        
        
    
            #region SelectFixingDateInfoInfo_
            private string selectFixingDateInfoInfo_;
            public string SelectFixingDateInfoInfo_
            {
                get { return this.selectFixingDateInfoInfo_; }
                set
                {
                    if (this.selectFixingDateInfoInfo_ != value)
                    {
                        this.selectFixingDateInfoInfo_ = value;
                        this.NotifyPropertyChanged("SelectFixingDateInfoInfo_");
                    }
                }
            }
            #endregion
            
            public void selectFixingDateInfoInfo(string typeStr)
            {
                this.fixingDateInfoViewModel_ = FixingDateInfoViewModel.CreateFixingDateInfo(typeStr);
                this.view_.DataContext = this;
            }
            
        
    
        
    
    }
    
}

