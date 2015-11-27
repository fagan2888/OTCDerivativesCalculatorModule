using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_fixedBondViewModel : Excel_interfaceViewModel
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
        
        public Excel_fixedBondViewModel() { }
        
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
        
        #region Excel_fixedCouponScheduleListViewModel_
        private Excel_fixedCouponScheduleListViewModel excel_fixedCouponScheduleListViewModel_;
        public Excel_fixedCouponScheduleListViewModel Excel_fixedCouponScheduleListViewModel_
        {
            get { return this.excel_fixedCouponScheduleListViewModel_; }
            set
            {
                if (this.excel_fixedCouponScheduleListViewModel_ != value)
                {
                    this.excel_fixedCouponScheduleListViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_fixedCouponScheduleListViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_fixedBond_subtypeViewModel_
        private Excel_fixedBond_subtypeViewModel excel_fixedBond_subtypeViewModel_;
        public Excel_fixedBond_subtypeViewModel Excel_fixedBond_subtypeViewModel_
        {
            get { return this.excel_fixedBond_subtypeViewModel_; }
            set
            {
                if (this.excel_fixedBond_subtypeViewModel_ != value)
                {
                    this.excel_fixedBond_subtypeViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_fixedBond_subtypeViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_interface");
                xmlWriter.WriteElementString("type" , "excel_fixedBond");
                xmlWriter.WriteStartElement("excel_fixedBond");
                    excel_issueInfoViewModel_.buildXml(xmlWriter);
                    
                    excel_fixedCouponScheduleListViewModel_.buildXml(xmlWriter);
                    
                    excel_fixedBond_subtypeViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_fixedBondView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_interface serial_Excel_interface = serial_Class as FpmlSerializedCSharp.Excel_interface;
            FpmlSerializedCSharp.Excel_fixedBond serial_Excel_fixedBond = serial_Excel_interface.Excel_fixedBond_;
        
            FpmlSerializedCSharp.Excel_issueInfo serial_excel_issueInfo = serial_Excel_fixedBond.Excel_issueInfo_;
            string excel_issueInfotype = serial_excel_issueInfo.Excel_type_.ValueStr;
            this.excel_issueInfoViewModel_ = Excel_issueInfoViewModel.CreateExcel_issueInfo(excel_issueInfotype);
            this.excel_issueInfoViewModel_.setFromSerial(serial_excel_issueInfo);
            
            FpmlSerializedCSharp.Excel_fixedCouponScheduleList serial_excel_fixedCouponScheduleList = serial_Excel_fixedBond.Excel_fixedCouponScheduleList_;
            string excel_fixedCouponScheduleListtype = serial_excel_fixedCouponScheduleList.Excel_type_.ValueStr;
            this.excel_fixedCouponScheduleListViewModel_ = Excel_fixedCouponScheduleListViewModel.CreateExcel_fixedCouponScheduleList(excel_fixedCouponScheduleListtype);
            this.excel_fixedCouponScheduleListViewModel_.setFromSerial(serial_excel_fixedCouponScheduleList);
            
            FpmlSerializedCSharp.Excel_fixedBond_subtype serial_excel_fixedBond_subtype = serial_Excel_fixedBond.Excel_fixedBond_subtype_;
            string excel_fixedBond_subtypetype = serial_excel_fixedBond_subtype.Excel_type_.ValueStr;
            this.excel_fixedBond_subtypeViewModel_ = Excel_fixedBond_subtypeViewModel.CreateExcel_fixedBond_subtype(excel_fixedBond_subtypetype);
            this.excel_fixedBond_subtypeViewModel_.setFromSerial(serial_excel_fixedBond_subtype);
            
        }
        
        
    
            
            
            
            
            
            
        
    
        
    
    }
    
}

