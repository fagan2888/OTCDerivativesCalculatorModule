using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class PreDefinedVariableInfoViewModel : VariableInfoViewModel
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
        
        public PreDefinedVariableInfoViewModel() { }
        
        #region RefInstanceName_
        private string refInstanceName_;
        public string RefInstanceName_
        {
            get { return this.refInstanceName_; }
            set
            {
                if (this.refInstanceName_ != value)
                {
                    this.refInstanceName_ = value;
                    this.NotifyPropertyChanged("RefInstanceName_");
                }
            }
        }
        #endregion
        
        #region FixingInformationViewModel_
        private FixingInformationViewModel fixingInformationViewModel_;
        public FixingInformationViewModel FixingInformationViewModel_
        {
            get { return this.fixingInformationViewModel_; }
            set
            {
                if (this.fixingInformationViewModel_ != value)
                {
                    this.fixingInformationViewModel_ = value;
                    this.NotifyPropertyChanged("FixingInformationViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("variableInfo");
                xmlWriter.WriteElementString("excel_type" , "preDefinedVariableInfo");
                xmlWriter.WriteStartElement("preDefinedVariableInfo");
                    xmlWriter.WriteElementString("refInstanceName" , this.refInstanceName_);
                    
                    fixingInformationViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new PreDefinedVariableInfoView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.VariableInfo serial_VariableInfo = serial_Class as FpmlSerializedCSharp.VariableInfo;
            FpmlSerializedCSharp.PreDefinedVariableInfo serial_PreDefinedVariableInfo = serial_VariableInfo.PreDefinedVariableInfo_;
        
            this.refInstanceName_ = serial_PreDefinedVariableInfo.RefInstanceName_.ValueStr;
            
            FpmlSerializedCSharp.FixingInformation serial_fixingInformation = serial_PreDefinedVariableInfo.FixingInformation_;
            string fixingInformationtype = serial_fixingInformation.Excel_type_.ValueStr;
            this.fixingInformationViewModel_ = FixingInformationViewModel.CreateFixingInformation(fixingInformationtype);
            this.fixingInformationViewModel_.setFromSerial(serial_fixingInformation);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

