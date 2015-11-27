using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_vanillaFloatingBondViewModel : Excel_interfaceViewModel
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
        
        public Excel_vanillaFloatingBondViewModel() { }
        
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
        
        #region Excel_vanillaFloatingCouponScheduleListViewModel_
        private Excel_vanillaFloatingCouponScheduleListViewModel excel_vanillaFloatingCouponScheduleListViewModel_;
        public Excel_vanillaFloatingCouponScheduleListViewModel Excel_vanillaFloatingCouponScheduleListViewModel_
        {
            get { return this.excel_vanillaFloatingCouponScheduleListViewModel_; }
            set
            {
                if (this.excel_vanillaFloatingCouponScheduleListViewModel_ != value)
                {
                    this.excel_vanillaFloatingCouponScheduleListViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_vanillaFloatingCouponScheduleListViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_vanillaFloatingBond_subtypeViewModel_
        private Excel_vanillaFloatingBond_subtypeViewModel excel_vanillaFloatingBond_subtypeViewModel_;
        public Excel_vanillaFloatingBond_subtypeViewModel Excel_vanillaFloatingBond_subtypeViewModel_
        {
            get { return this.excel_vanillaFloatingBond_subtypeViewModel_; }
            set
            {
                if (this.excel_vanillaFloatingBond_subtypeViewModel_ != value)
                {
                    this.excel_vanillaFloatingBond_subtypeViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_vanillaFloatingBond_subtypeViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_interface");
                xmlWriter.WriteElementString("type" , "excel_vanillaFloatingBond");
                xmlWriter.WriteStartElement("excel_vanillaFloatingBond");
                    excel_issueInfoViewModel_.buildXml(xmlWriter);
                    
                    excel_underlyingCalcInfoViewModel_.buildXml(xmlWriter);
                    
                    excel_vanillaFloatingCouponScheduleListViewModel_.buildXml(xmlWriter);
                    
                    excel_vanillaFloatingBond_subtypeViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_vanillaFloatingBondView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_interface serial_Excel_interface = serial_Class as FpmlSerializedCSharp.Excel_interface;
            FpmlSerializedCSharp.Excel_vanillaFloatingBond serial_Excel_vanillaFloatingBond = serial_Excel_interface.Excel_vanillaFloatingBond_;
        
            FpmlSerializedCSharp.Excel_issueInfo serial_excel_issueInfo = serial_Excel_vanillaFloatingBond.Excel_issueInfo_;
            string excel_issueInfotype = serial_excel_issueInfo.Excel_type_.ValueStr;
            this.excel_issueInfoViewModel_ = Excel_issueInfoViewModel.CreateExcel_issueInfo(excel_issueInfotype);
            this.excel_issueInfoViewModel_.setFromSerial(serial_excel_issueInfo);
            
            FpmlSerializedCSharp.Excel_underlyingCalcInfo serial_excel_underlyingCalcInfo = serial_Excel_vanillaFloatingBond.Excel_underlyingCalcInfo_;
            string excel_underlyingCalcInfotype = serial_excel_underlyingCalcInfo.Excel_type_.ValueStr;
            this.excel_underlyingCalcInfoViewModel_ = Excel_underlyingCalcInfoViewModel.CreateExcel_underlyingCalcInfo(excel_underlyingCalcInfotype);
            this.excel_underlyingCalcInfoViewModel_.setFromSerial(serial_excel_underlyingCalcInfo);
            
            FpmlSerializedCSharp.Excel_vanillaFloatingCouponScheduleList serial_excel_vanillaFloatingCouponScheduleList = serial_Excel_vanillaFloatingBond.Excel_vanillaFloatingCouponScheduleList_;
            string excel_vanillaFloatingCouponScheduleListtype = serial_excel_vanillaFloatingCouponScheduleList.Excel_type_.ValueStr;
            this.excel_vanillaFloatingCouponScheduleListViewModel_ = Excel_vanillaFloatingCouponScheduleListViewModel.CreateExcel_vanillaFloatingCouponScheduleList(excel_vanillaFloatingCouponScheduleListtype);
            this.excel_vanillaFloatingCouponScheduleListViewModel_.setFromSerial(serial_excel_vanillaFloatingCouponScheduleList);
            
            FpmlSerializedCSharp.Excel_vanillaFloatingBond_subtype serial_excel_vanillaFloatingBond_subtype = serial_Excel_vanillaFloatingBond.Excel_vanillaFloatingBond_subtype_;
            string excel_vanillaFloatingBond_subtypetype = serial_excel_vanillaFloatingBond_subtype.Excel_type_.ValueStr;
            this.excel_vanillaFloatingBond_subtypeViewModel_ = Excel_vanillaFloatingBond_subtypeViewModel.CreateExcel_vanillaFloatingBond_subtype(excel_vanillaFloatingBond_subtypetype);
            this.excel_vanillaFloatingBond_subtypeViewModel_.setFromSerial(serial_excel_vanillaFloatingBond_subtype);
            
        }
        
        
    
            
            
            
            
            
            
            
            
        
    
        
    
    }
    
}

