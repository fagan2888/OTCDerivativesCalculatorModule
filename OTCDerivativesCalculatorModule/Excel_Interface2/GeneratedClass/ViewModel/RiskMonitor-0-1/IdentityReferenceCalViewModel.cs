using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class IdentityReferenceCalViewModel : ReferenceCalculationViewModel
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
        
        public IdentityReferenceCalViewModel() { }
        
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
                xmlWriter.WriteElementString("excel_type" , "identityReferenceCal");
                xmlWriter.WriteStartElement("identityReferenceCal");
                    xmlWriter.WriteElementString("krCode" , this.krCode_);
                    
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
            Control v = new IdentityReferenceCalView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ReferenceCalculation serial_ReferenceCalculation = serial_Class as FpmlSerializedCSharp.ReferenceCalculation;
            FpmlSerializedCSharp.IdentityReferenceCal serial_IdentityReferenceCal = serial_ReferenceCalculation.IdentityReferenceCal_;
        
            this.krCode_ = serial_IdentityReferenceCal.KrCode_.ValueStr;
            
            FpmlSerializedCSharp.FixingDateInfo serial_fixingDateInfo = serial_IdentityReferenceCal.FixingDateInfo_;
            string fixingDateInfotype = serial_fixingDateInfo.Excel_type_.ValueStr;
            this.fixingDateInfoViewModel_ = FixingDateInfoViewModel.CreateFixingDateInfo(fixingDateInfotype);
            this.fixingDateInfoViewModel_.setFromSerial(serial_fixingDateInfo);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

