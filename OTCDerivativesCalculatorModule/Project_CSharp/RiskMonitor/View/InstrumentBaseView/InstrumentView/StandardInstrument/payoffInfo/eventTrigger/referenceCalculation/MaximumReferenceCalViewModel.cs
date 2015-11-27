using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class MaximumReferenceCalViewModel : ReferenceCalculationViewModel
    {
        public MaximumReferenceCalViewModel() 
        {
        
        }

        #region Nth_
        private string nth_;
        public string Nth_
        {
            get { return this.nth_; }
            set
            {
                if (this.nth_ != value)
                {
                    this.nth_ = value;
                    this.NotifyPropertyChanged("Nth_");
                }
            }
        }
        #endregion
        
        #region SelectedUnderName_
        private ObservableCollection<string> selectedUnderName_;
        public ObservableCollection<string> SelectedUnderName_
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
                xmlWriter.WriteElementString("type" , "maximumReferenceCal");
                xmlWriter.WriteStartElement("maximumReferenceCal");
                    xmlWriter.WriteElementString("nth" , this.nth_);

                    foreach (var item in selectedUnderName_)
                    {
                        xmlWriter.WriteElementString("selectedUnderName", item);
                    }
                    
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
            FpmlSerializedCSharp.MaximumReferenceCal serial_MaximumReferenceCal = serial_ReferenceCalculation.MaximumReferenceCal_;
        
            this.nth_ = serial_MaximumReferenceCal.Nth_.ValueStr;
            
            this.selectedUnderName_ = new ObservableCollection<string>();
            foreach (var item in serial_MaximumReferenceCal.SelectedUnderName_)
            {
                this.selectedUnderName_.Add(item.ValueStr);
            }
            
            FpmlSerializedCSharp.FixingDateInfo serial_fixingDateInfo = serial_MaximumReferenceCal.FixingDateInfo_;
            string fixingDateInfotype = serial_fixingDateInfo.Type_.ValueStr;
            this.fixingDateInfoViewModel_ = FixingDateInfoViewModel.CreateFixingDateInfo(fixingDateInfotype);
            this.fixingDateInfoViewModel_.setFromSerial(serial_fixingDateInfo);
            
           //this.view_ = new MaximumReferenceCalView();
            this.view_.DataContext = this;
        }
        
    }
    
}

