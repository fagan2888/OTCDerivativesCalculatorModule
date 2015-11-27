using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class ChoiceReferenceCalViewModel : ReferenceCalculationViewModel
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
        
        #region FixingDateInfoViewModel_
        private FixingDateInfoViewModel fixingDateInfoViewModel_;
        public FixingDateInfoViewModel FixingDateInfoViewModel_
        {
            get { return this.fixingDateInfoViewModel_; }
            set
            {
                if (this.fixingDateInfoViewModel_ != value)
                {
                    this.fixingDateInfoViewModel_ = value;
                    this.NotifyPropertyChanged("FixingDateInfoViewModel_");
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
        
        public override Control view()
        {
            Control v = new ChoiceReferenceCalView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ReferenceCalculation serial_ReferenceCalculation = serial_Class as FpmlSerializedCSharp.ReferenceCalculation;
            FpmlSerializedCSharp.ChoiceReferenceCal serial_ChoiceReferenceCal = serial_ReferenceCalculation.ChoiceReferenceCal_;
        
            this.selectedUnderName_ = serial_ChoiceReferenceCal.SelectedUnderName_.ValueStr;
            
            FpmlSerializedCSharp.FixingDateInfo serial_fixingDateInfo = serial_ChoiceReferenceCal.FixingDateInfo_;
            string fixingDateInfotype = serial_fixingDateInfo.Excel_type_.ValueStr;
            this.fixingDateInfoViewModel_ = FixingDateInfoViewModel.CreateFixingDateInfo(fixingDateInfotype);
            this.fixingDateInfoViewModel_.setFromSerial(serial_fixingDateInfo);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

