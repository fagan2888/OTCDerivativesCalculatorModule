using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class ChoiceReferenceCalViewModel : ReferenceCalculationViewModel
    {
        public ChoiceReferenceCalViewModel() { }
    
        #region SelectedUnderName_
        private string selectedUnderName_;
        public string SelectedUnderName_
        {
            get { return this.selectedUnderName_; }
            set
            {
                if (this.selectedUnderName_ != value)
                {
                    this.selectedUnderName_ = value;
                    this.NotifyPropertyChanged("SelectedUnderName_");
                }
            }
        }
        #endregion
        
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("referenceCalculation");
                xmlWriter.WriteElementString("type" , "choiceReferenceCal");
                xmlWriter.WriteStartElement("choiceReferenceCal");
                    xmlWriter.WriteElementString("selectedUnderName" , this.selectedUnderName_);
                    
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
            FpmlSerializedCSharp.ChoiceReferenceCal serial_ChoiceReferenceCal = serial_ReferenceCalculation.ChoiceReferenceCal_;
        
            this.selectedUnderName_ = serial_ChoiceReferenceCal.SelectedUnderName_.ValueStr;
            
            FpmlSerializedCSharp.FixingDateInfo serial_fixingDateInfo = serial_ChoiceReferenceCal.FixingDateInfo_;
            string fixingDateInfotype = serial_fixingDateInfo.Type_.ValueStr;
            this.fixingDateInfoViewModel_ = FixingDateInfoViewModel.CreateFixingDateInfo(fixingDateInfotype);
            this.fixingDateInfoViewModel_.setFromSerial(serial_fixingDateInfo);
            
           //this.view_ = new ChoiceReferenceCalView();
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

