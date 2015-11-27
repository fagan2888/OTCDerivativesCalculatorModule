using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_structuredBondViewModel : Excel_interfaceViewModel
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
        
        public Excel_structuredBondViewModel() { }
        
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
        
        #region Excel_underlyingCalcInfoViewModel_
        private Excel_underlyingCalcInfoViewModel excel_underlyingCalcInfoViewModel_;
        public Excel_underlyingCalcInfoViewModel Excel_underlyingCalcInfoViewModel_
        {
            get { return this.excel_underlyingCalcInfoViewModel_; }
            set
            {
                if (this.excel_underlyingCalcInfoViewModel_ != value)
                {
                    this.excel_underlyingCalcInfoViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_underlyingCalcInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_couponScheduleListViewModel_
        private Excel_couponScheduleListViewModel excel_couponScheduleListViewModel_;
        public Excel_couponScheduleListViewModel Excel_couponScheduleListViewModel_
        {
            get { return this.excel_couponScheduleListViewModel_; }
            set
            {
                if (this.excel_couponScheduleListViewModel_ != value)
                {
                    this.excel_couponScheduleListViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_couponScheduleListViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_structuredBond_subtypeViewModel_
        private Excel_structuredBond_subtypeViewModel excel_structuredBond_subtypeViewModel_;
        public Excel_structuredBond_subtypeViewModel Excel_structuredBond_subtypeViewModel_
        {
            get { return this.excel_structuredBond_subtypeViewModel_; }
            set
            {
                if (this.excel_structuredBond_subtypeViewModel_ != value)
                {
                    this.excel_structuredBond_subtypeViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_structuredBond_subtypeViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_interface");
                xmlWriter.WriteElementString("excel_type" , "excel_structuredBond");
                xmlWriter.WriteStartElement("excel_structuredBond");
                    excel_issueInfoViewModel_.buildXml(xmlWriter);
                    
                    excel_underlyingCalcInfoViewModel_.buildXml(xmlWriter);
                    
                    excel_couponScheduleListViewModel_.buildXml(xmlWriter);
                    
                    excel_structuredBond_subtypeViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_structuredBondView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_interface serial_Excel_interface = serial_Class as FpmlSerializedCSharp.Excel_interface;
            FpmlSerializedCSharp.Excel_structuredBond serial_Excel_structuredBond = serial_Excel_interface.Excel_structuredBond_;
        
            FpmlSerializedCSharp.Excel_issueInfo serial_excel_issueInfo = serial_Excel_structuredBond.Excel_issueInfo_;
            string excel_issueInfotype = serial_excel_issueInfo.Excel_type_.ValueStr;
            this.excel_issueInfoViewModel_ = Excel_issueInfoViewModel.CreateExcel_issueInfo(excel_issueInfotype);
            this.excel_issueInfoViewModel_.setFromSerial(serial_excel_issueInfo);
            
            FpmlSerializedCSharp.Excel_underlyingCalcInfo serial_excel_underlyingCalcInfo = serial_Excel_structuredBond.Excel_underlyingCalcInfo_;
            string excel_underlyingCalcInfotype = serial_excel_underlyingCalcInfo.Excel_type_.ValueStr;
            this.excel_underlyingCalcInfoViewModel_ = Excel_underlyingCalcInfoViewModel.CreateExcel_underlyingCalcInfo(excel_underlyingCalcInfotype);
            this.excel_underlyingCalcInfoViewModel_.setFromSerial(serial_excel_underlyingCalcInfo);
            
            FpmlSerializedCSharp.Excel_couponScheduleList serial_excel_couponScheduleList = serial_Excel_structuredBond.Excel_couponScheduleList_;
            string excel_couponScheduleListtype = serial_excel_couponScheduleList.Excel_type_.ValueStr;
            this.excel_couponScheduleListViewModel_ = Excel_couponScheduleListViewModel.CreateExcel_couponScheduleList(excel_couponScheduleListtype);
            this.excel_couponScheduleListViewModel_.setFromSerial(serial_excel_couponScheduleList);
            
            FpmlSerializedCSharp.Excel_structuredBond_subtype serial_excel_structuredBond_subtype = serial_Excel_structuredBond.Excel_structuredBond_subtype_;
            string excel_structuredBond_subtypetype = serial_excel_structuredBond_subtype.Excel_type_.ValueStr;
            this.excel_structuredBond_subtypeViewModel_ = Excel_structuredBond_subtypeViewModel.CreateExcel_structuredBond_subtype(excel_structuredBond_subtypetype);
            this.excel_structuredBond_subtypeViewModel_.setFromSerial(serial_excel_structuredBond_subtype);
            
        }
        
        
    
            
            
            
            
            
            
            
            
        
    
        
    
    }
    
}

