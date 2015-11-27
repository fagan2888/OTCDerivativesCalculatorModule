using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_referenceInformationViewModel : IXmlData
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
        
        public Excel_referenceInformationViewModel() { }
        
        #region EntityName_
        private string entityName_;
        public string EntityName_
        {
            get { return this.entityName_; }
            set
            {
                if (this.entityName_ != value)
                {
                    this.entityName_ = value;
                    this.NotifyPropertyChanged("EntityName_");
                }
            }
        }
        #endregion
        
        #region EntityId_
        private string entityId_;
        public string EntityId_
        {
            get { return this.entityId_; }
            set
            {
                if (this.entityId_ != value)
                {
                    this.entityId_ = value;
                    this.NotifyPropertyChanged("EntityId_");
                }
            }
        }
        #endregion
        
        #region Excel_referenceObligationViewModel_
        private Excel_referenceObligationViewModel excel_referenceObligationViewModel_;
        public Excel_referenceObligationViewModel Excel_referenceObligationViewModel_
        {
            get { return this.excel_referenceObligationViewModel_; }
            set
            {
                if (this.excel_referenceObligationViewModel_ != value)
                {
                    this.excel_referenceObligationViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_referenceObligationViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "excel_referenceInformation");
                xmlWriter.WriteStartElement("excel_referenceInformation");
                    xmlWriter.WriteElementString("entityName" , this.entityName_);
                    
                    xmlWriter.WriteElementString("entityId" , this.entityId_);
                    
                    excel_referenceObligationViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new Excel_referenceInformationView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_referenceInformation serial_Excel_referenceInformation = serial_Class as FpmlSerializedCSharp.Excel_referenceInformation;
        
            this.entityName_ = serial_Excel_referenceInformation.EntityName_.ValueStr;
            
            this.entityId_ = serial_Excel_referenceInformation.EntityId_.ValueStr;
            
            FpmlSerializedCSharp.Excel_referenceObligation serial_excel_referenceObligation = serial_Excel_referenceInformation.Excel_referenceObligation_;
            string excel_referenceObligationtype = serial_excel_referenceObligation.Excel_type_.ValueStr;
            this.excel_referenceObligationViewModel_ = Excel_referenceObligationViewModel.CreateExcel_referenceObligation(excel_referenceObligationtype);
            this.excel_referenceObligationViewModel_.setFromSerial(serial_excel_referenceObligation);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

