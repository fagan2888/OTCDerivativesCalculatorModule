using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class PreDefinedVariableInfoViewModel : VariableInfoViewModel
    {
    
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
                xmlWriter.WriteElementString("type" , "preDefinedVariableInfo");
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
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.VariableInfo serial_VariableInfo = serial_Class as FpmlSerializedCSharp.VariableInfo;
            FpmlSerializedCSharp.PreDefinedVariableInfo serial_PreDefinedVariableInfo = serial_VariableInfo.PreDefinedVariableInfo_;
        
            this.refInstanceName_ = serial_PreDefinedVariableInfo.RefInstanceName_.ValueStr;
            
            FpmlSerializedCSharp.FixingInformation serial_fixingInformation = serial_PreDefinedVariableInfo.FixingInformation_;
            this.fixingInformationViewModel_.setFromSerial(serial_fixingInformation);
            
           //this.view_ = new PreDefinedVariableInfoView();
            this.view_.DataContext = this;
        }
        
        
    
            //#region SelectFixingInformationInfo_
            //private string selectFixingInformationInfo_;
            //public string SelectFixingInformationInfo_
            //{
            //    get { return this.selectFixingInformationInfo_; }
            //    set
            //    {
            //        if (this.selectFixingInformationInfo_ != value)
            //        {
            //            this.selectFixingInformationInfo_ = value;
            //            this.NotifyPropertyChanged("SelectFixingInformationInfo_");
            //        }
            //    }
            //}
            //#endregion
            
            //public void selectFixingInformationInfo(string typeStr)
            //{
            //    this.fixingInformationViewModel_ = FixingInformationViewModel.CreateFixingInformation(typeStr);
            //    this.view_.DataContext = this;
            //}
            
        
    
        
    
    }
    
}

