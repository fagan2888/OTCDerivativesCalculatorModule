using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_creditEventInfoViewModel : IXmlData
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
        
        public Excel_creditEventInfoViewModel() { }
        
        #region Excel_issueInfoViewModel_
        private Excel_issueInfoViewModel excel_issueInfoViewModel_;
        public Excel_issueInfoViewModel Excel_issueInfoViewModel_
        {
            get { return this.excel_issueInfoViewModel_; }
            set
            {
                if (this.excel_issueInfoViewModel_ != value)
                {
                    this.excel_issueInfoViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_issueInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_referenceInformationListViewModel_
        private Excel_referenceInformationListViewModel excel_referenceInformationListViewModel_;
        public Excel_referenceInformationListViewModel Excel_referenceInformationListViewModel_
        {
            get { return this.excel_referenceInformationListViewModel_; }
            set
            {
                if (this.excel_referenceInformationListViewModel_ != value)
                {
                    this.excel_referenceInformationListViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_referenceInformationListViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_jointProbabilityTraitViewModel_
        private Excel_jointProbabilityTraitViewModel excel_jointProbabilityTraitViewModel_;
        public Excel_jointProbabilityTraitViewModel Excel_jointProbabilityTraitViewModel_
        {
            get { return this.excel_jointProbabilityTraitViewModel_; }
            set
            {
                if (this.excel_jointProbabilityTraitViewModel_ != value)
                {
                    this.excel_jointProbabilityTraitViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_jointProbabilityTraitViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_protectionTermsViewModel_
        private Excel_protectionTermsViewModel excel_protectionTermsViewModel_;
        public Excel_protectionTermsViewModel Excel_protectionTermsViewModel_
        {
            get { return this.excel_protectionTermsViewModel_; }
            set
            {
                if (this.excel_protectionTermsViewModel_ != value)
                {
                    this.excel_protectionTermsViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_protectionTermsViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "excel_creditEventInfo");
                xmlWriter.WriteStartElement("excel_creditEventInfo");
                    excel_issueInfoViewModel_.buildXml(xmlWriter);
                    
                    excel_referenceInformationListViewModel_.buildXml(xmlWriter);
                    
                    excel_jointProbabilityTraitViewModel_.buildXml(xmlWriter);
                    
                    excel_protectionTermsViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new Excel_creditEventInfoView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_creditEventInfo serial_Excel_creditEventInfo = serial_Class as FpmlSerializedCSharp.Excel_creditEventInfo;
        
            FpmlSerializedCSharp.Excel_issueInfo serial_excel_issueInfo = serial_Excel_creditEventInfo.Excel_issueInfo_;
            string excel_issueInfotype = serial_excel_issueInfo.Excel_type_.ValueStr;
            this.excel_issueInfoViewModel_ = Excel_issueInfoViewModel.CreateExcel_issueInfo(excel_issueInfotype);
            this.excel_issueInfoViewModel_.setFromSerial(serial_excel_issueInfo);
            
            FpmlSerializedCSharp.Excel_referenceInformationList serial_excel_referenceInformationList = serial_Excel_creditEventInfo.Excel_referenceInformationList_;
            string excel_referenceInformationListtype = serial_excel_referenceInformationList.Excel_type_.ValueStr;
            this.excel_referenceInformationListViewModel_ = Excel_referenceInformationListViewModel.CreateExcel_referenceInformationList(excel_referenceInformationListtype);
            this.excel_referenceInformationListViewModel_.setFromSerial(serial_excel_referenceInformationList);
            
            FpmlSerializedCSharp.Excel_jointProbabilityTrait serial_excel_jointProbabilityTrait = serial_Excel_creditEventInfo.Excel_jointProbabilityTrait_;
            string excel_jointProbabilityTraittype = serial_excel_jointProbabilityTrait.Excel_type_.ValueStr;
            this.excel_jointProbabilityTraitViewModel_ = Excel_jointProbabilityTraitViewModel.CreateExcel_jointProbabilityTrait(excel_jointProbabilityTraittype);
            this.excel_jointProbabilityTraitViewModel_.setFromSerial(serial_excel_jointProbabilityTrait);
            
            FpmlSerializedCSharp.Excel_protectionTerms serial_excel_protectionTerms = serial_Excel_creditEventInfo.Excel_protectionTerms_;
            string excel_protectionTermstype = serial_excel_protectionTerms.Excel_type_.ValueStr;
            this.excel_protectionTermsViewModel_ = Excel_protectionTermsViewModel.CreateExcel_protectionTerms(excel_protectionTermstype);
            this.excel_protectionTermsViewModel_.setFromSerial(serial_excel_protectionTerms);
            
        }
        
        
    
            
            
            
            
            
            
            
            
        
    
        
    
    }
    
}

