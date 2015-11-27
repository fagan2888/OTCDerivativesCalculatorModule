using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class StopLossReturnCalViewModel : ReturnCalculationViewModel
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
        
        public StopLossReturnCalViewModel() { }
        
        #region Power_
        private string power_;
        public string Power_
        {
            get { return this.power_; }
            set
            {
                if (this.power_ != value)
                {
                    this.power_ = value;
                    this.NotifyPropertyChanged("Power_");
                }
            }
        }
        #endregion
        
        #region LossTrigger_
        private string lossTrigger_;
        public string LossTrigger_
        {
            get { return this.lossTrigger_; }
            set
            {
                if (this.lossTrigger_ != value)
                {
                    this.lossTrigger_ = value;
                    this.NotifyPropertyChanged("LossTrigger_");
                }
            }
        }
        #endregion
        
        #region MaximumLoss_
        private string maximumLoss_;
        public string MaximumLoss_
        {
            get { return this.maximumLoss_; }
            set
            {
                if (this.maximumLoss_ != value)
                {
                    this.maximumLoss_ = value;
                    this.NotifyPropertyChanged("MaximumLoss_");
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
        
        #region WithNotional_
        private string withNotional_;
        public string WithNotional_
        {
            get { return this.withNotional_; }
            set
            {
                if (this.withNotional_ != value)
                {
                    this.withNotional_ = value;
                    this.NotifyPropertyChanged("WithNotional_");
                }
            }
        }
        #endregion
        
        #region IsExpired_
        private string isExpired_;
        public string IsExpired_
        {
            get { return this.isExpired_; }
            set
            {
                if (this.isExpired_ != value)
                {
                    this.isExpired_ = value;
                    this.NotifyPropertyChanged("IsExpired_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("returnCalculation");
                xmlWriter.WriteElementString("type" , "stopLossReturnCal");
                xmlWriter.WriteStartElement("stopLossReturnCal");
                    xmlWriter.WriteElementString("power" , this.power_);
                    
                    xmlWriter.WriteElementString("lossTrigger" , this.lossTrigger_);
                    
                    xmlWriter.WriteElementString("maximumLoss" , this.maximumLoss_);
                    
                    referenceCalculationInfoViewModel_.buildXml(xmlWriter);
                    
                    xmlWriter.WriteElementString("withNotional" , this.withNotional_);
                    
                    xmlWriter.WriteElementString("isExpired" , this.isExpired_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new StopLossReturnCalView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ReturnCalculation serial_ReturnCalculation = serial_Class as FpmlSerializedCSharp.ReturnCalculation;
            FpmlSerializedCSharp.StopLossReturnCal serial_StopLossReturnCal = serial_ReturnCalculation.StopLossReturnCal_;
        
            this.power_ = serial_StopLossReturnCal.Power_.ValueStr;
            
            this.lossTrigger_ = serial_StopLossReturnCal.LossTrigger_.ValueStr;
            
            this.maximumLoss_ = serial_StopLossReturnCal.MaximumLoss_.ValueStr;
            
            FpmlSerializedCSharp.ReferenceCalculationInfo serial_referenceCalculationInfo = serial_StopLossReturnCal.ReferenceCalculationInfo_;
            string referenceCalculationInfotype = serial_referenceCalculationInfo.Excel_type_.ValueStr;
            this.referenceCalculationInfoViewModel_ = ReferenceCalculationInfoViewModel.CreateReferenceCalculationInfo(referenceCalculationInfotype);
            this.referenceCalculationInfoViewModel_.setFromSerial(serial_referenceCalculationInfo);
            
            this.withNotional_ = serial_StopLossReturnCal.WithNotional_.ValueStr;
            
            this.isExpired_ = serial_StopLossReturnCal.IsExpired_.ValueStr;
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

