using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class MinimumReferenceCalViewModel : ReferenceCalculationViewModel
    {
    
        public MinimumReferenceCalViewModel() { }
        
    
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
                xmlWriter.WriteElementString("type" , "minimumReferenceCal");
                xmlWriter.WriteStartElement("minimumReferenceCal");
                    xmlWriter.WriteElementString("nth" , this.nth_);

                    foreach (var item in selectedUnderName_)
                    {
                        xmlWriter.WriteElementString("selectedUnderName", item);
                        
                    }
                    if (fixingDateInfoViewModel_ != null)
                    {
                        fixingDateInfoViewModel_.buildXml(xmlWriter);
                    }
                    
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
            FpmlSerializedCSharp.MinimumReferenceCal serial_MinimumReferenceCal = serial_ReferenceCalculation.MinimumReferenceCal_;
        
            this.nth_ = serial_MinimumReferenceCal.Nth_.ValueStr;

            this.selectedUnderName_ = new ObservableCollection<string>();
            foreach (var item in serial_MinimumReferenceCal.SelectedUnderName_)
            {
                this.selectedUnderName_.Add(item.ValueStr);
            }
            
            FpmlSerializedCSharp.FixingDateInfo serial_fixingDateInfo = serial_MinimumReferenceCal.FixingDateInfo_;
            string fixingDateInfotype = serial_fixingDateInfo.Type_.ValueStr;
            this.fixingDateInfoViewModel_ = FixingDateInfoViewModel.CreateFixingDateInfo(fixingDateInfotype);
            this.fixingDateInfoViewModel_.setFromSerial(serial_fixingDateInfo);
            
           //this.view_ = new MinimumReferenceCalView();
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

