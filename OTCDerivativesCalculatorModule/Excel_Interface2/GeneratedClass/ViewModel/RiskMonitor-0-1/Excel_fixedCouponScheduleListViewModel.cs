using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_fixedCouponScheduleListViewModel : IXmlData
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
        
        public Excel_fixedCouponScheduleListViewModel() { }
        
        #region FixedRate_
        private string fixedRate_;
        public string FixedRate_
        {
            get { return this.fixedRate_; }
            set
            {
                if (this.fixedRate_ != value)
                {
                    this.fixedRate_ = value;
                    this.NotifyPropertyChanged("FixedRate_");
                }
            }
        }
        #endregion
        
        #region DayCounter_
        private string dayCounter_;
        public string DayCounter_
        {
            get { return this.dayCounter_; }
            set
            {
                if (this.dayCounter_ != value)
                {
                    this.dayCounter_ = value;
                    this.NotifyPropertyChanged("DayCounter_");
                }
            }
        }
        #endregion
        
        #region Excel_couponScheduleViewModel_
        private ObservableCollection<Excel_couponScheduleViewModel> excel_couponScheduleViewModel_;
        public ObservableCollection<Excel_couponScheduleViewModel> Excel_couponScheduleViewModel_
        {
            get { return this.excel_couponScheduleViewModel_; }
            set
            {
                if (this.excel_couponScheduleViewModel_ != value)
                {
                    this.excel_couponScheduleViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_couponScheduleViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "excel_fixedCouponScheduleList");
                xmlWriter.WriteStartElement("excel_fixedCouponScheduleList");
                    xmlWriter.WriteElementString("fixedRate" , this.fixedRate_);
                    
                    xmlWriter.WriteElementString("dayCounter" , this.dayCounter_);
                    
                    foreach (var item in excel_couponScheduleViewModel_)
                    {
                        item.buildXml(xmlWriter);
                    }
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new Excel_fixedCouponScheduleListView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_fixedCouponScheduleList serial_Excel_fixedCouponScheduleList = serial_Class as FpmlSerializedCSharp.Excel_fixedCouponScheduleList;
        
            this.fixedRate_ = serial_Excel_fixedCouponScheduleList.FixedRate_.ValueStr;
            
            this.dayCounter_ = serial_Excel_fixedCouponScheduleList.DayCounter_.ValueStr;
            
            List<FpmlSerializedCSharp.Excel_couponSchedule> serial_excel_couponSchedule = serial_Excel_fixedCouponScheduleList.Excel_couponSchedule_;
            this.excel_couponScheduleViewModel_ = new ObservableCollection<Excel_couponScheduleViewModel>();
            foreach (var item in serial_excel_couponSchedule)
            {
                string type = item.Excel_type_.ValueStr;
                Excel_couponScheduleViewModel viewModel = Excel_couponScheduleViewModel.CreateExcel_couponSchedule(type);
                viewModel.setFromSerial(item);
                this.excel_couponScheduleViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

