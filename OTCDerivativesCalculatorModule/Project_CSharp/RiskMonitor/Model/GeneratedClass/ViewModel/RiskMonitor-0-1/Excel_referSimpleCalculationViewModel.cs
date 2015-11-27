using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_referSimpleCalculationViewModel : Excel_referenceCal_IDViewModel
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
        
        public Excel_referSimpleCalculationViewModel() { }
        
        #region CalculationID_
        private string calculationID_;
        public string CalculationID_
        {
            get { return this.calculationID_; }
            set
            {
                if (this.calculationID_ != value)
                {
                    this.calculationID_ = value;
                    this.NotifyPropertyChanged("CalculationID_");
                }
            }
        }
        #endregion
        
        #region ReferenceType_
        private string referenceType_;
        public string ReferenceType_
        {
            get { return this.referenceType_; }
            set
            {
                if (this.referenceType_ != value)
                {
                    this.referenceType_ = value;
                    this.NotifyPropertyChanged("ReferenceType_");
                }
            }
        }
        #endregion
        
        #region ReferenceSet_
        private string referenceSet_;
        public string ReferenceSet_
        {
            get { return this.referenceSet_; }
            set
            {
                if (this.referenceSet_ != value)
                {
                    this.referenceSet_ = value;
                    this.NotifyPropertyChanged("ReferenceSet_");
                }
            }
        }
        #endregion
        
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
        
        #region AverageDays_
        private string averageDays_;
        public string AverageDays_
        {
            get { return this.averageDays_; }
            set
            {
                if (this.averageDays_ != value)
                {
                    this.averageDays_ = value;
                    this.NotifyPropertyChanged("AverageDays_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_referenceCal_ID");
                xmlWriter.WriteElementString("type" , "excel_referSimpleCalculation");
                xmlWriter.WriteStartElement("excel_referSimpleCalculation");
                    xmlWriter.WriteElementString("calculationID" , this.calculationID_);
                    
                    xmlWriter.WriteElementString("referenceType" , this.referenceType_);
                    
                    xmlWriter.WriteElementString("referenceSet" , this.referenceSet_);
                    
                    xmlWriter.WriteElementString("nth" , this.nth_);
                    
                    xmlWriter.WriteElementString("averageDays" , this.averageDays_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_referSimpleCalculationView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_referenceCal_ID serial_Excel_referenceCal_ID = serial_Class as FpmlSerializedCSharp.Excel_referenceCal_ID;
            FpmlSerializedCSharp.Excel_referSimpleCalculation serial_Excel_referSimpleCalculation = serial_Excel_referenceCal_ID.Excel_referSimpleCalculation_;
        
            this.calculationID_ = serial_Excel_referSimpleCalculation.CalculationID_.ValueStr;
            
            this.referenceType_ = serial_Excel_referSimpleCalculation.ReferenceType_.ValueStr;
            
            this.referenceSet_ = serial_Excel_referSimpleCalculation.ReferenceSet_.ValueStr;
            
            this.nth_ = serial_Excel_referSimpleCalculation.Nth_.ValueStr;
            
            this.averageDays_ = serial_Excel_referSimpleCalculation.AverageDays_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

