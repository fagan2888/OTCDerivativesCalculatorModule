using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class ComplementReturnCalculationViewModel : IXmlData
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
        
        public ComplementReturnCalculationViewModel() { }
        
        #region ReturnCalculationInfoViewModel_
        private ReturnCalculationInfoViewModel returnCalculationInfoViewModel_;
        public ReturnCalculationInfoViewModel ReturnCalculationInfoViewModel_
        {
            get { return this.returnCalculationInfoViewModel_; }
            set
            {
                if (this.returnCalculationInfoViewModel_ != value)
                {
                    this.returnCalculationInfoViewModel_ = value;
                    this.NotifyPropertyChanged("ReturnCalculationInfoViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "complementReturnCalculation");
                xmlWriter.WriteStartElement("complementReturnCalculation");
                    returnCalculationInfoViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new ComplementReturnCalculationView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ComplementReturnCalculation serial_ComplementReturnCalculation = serial_Class as FpmlSerializedCSharp.ComplementReturnCalculation;
        
            FpmlSerializedCSharp.ReturnCalculationInfo serial_returnCalculationInfo = serial_ComplementReturnCalculation.ReturnCalculationInfo_;
            string returnCalculationInfotype = serial_returnCalculationInfo.Excel_type_.ValueStr;
            this.returnCalculationInfoViewModel_ = ReturnCalculationInfoViewModel.CreateReturnCalculationInfo(returnCalculationInfotype);
            this.returnCalculationInfoViewModel_.setFromSerial(serial_returnCalculationInfo);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

