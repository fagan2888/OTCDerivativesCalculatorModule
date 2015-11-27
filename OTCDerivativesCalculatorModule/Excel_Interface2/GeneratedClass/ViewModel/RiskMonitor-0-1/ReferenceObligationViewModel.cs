using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class ReferenceObligationViewModel : IXmlData
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
        
        public ReferenceObligationViewModel() { }
        
        #region BondViewModel_
        private BondViewModel bondViewModel_;
        public BondViewModel BondViewModel_
        {
            get { return this.bondViewModel_; }
            set
            {
                if (this.bondViewModel_ != value)
                {
                    this.bondViewModel_ = value;
                    this.NotifyPropertyChanged("BondViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "referenceObligation");
                xmlWriter.WriteStartElement("referenceObligation");
                    bondViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new ReferenceObligationView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ReferenceObligation serial_ReferenceObligation = serial_Class as FpmlSerializedCSharp.ReferenceObligation;
        
            FpmlSerializedCSharp.Bond serial_bond = serial_ReferenceObligation.Bond_;
            string bondtype = serial_bond.Excel_type_.ValueStr;
            this.bondViewModel_ = BondViewModel.CreateBond(bondtype);
            this.bondViewModel_.setFromSerial(serial_bond);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

