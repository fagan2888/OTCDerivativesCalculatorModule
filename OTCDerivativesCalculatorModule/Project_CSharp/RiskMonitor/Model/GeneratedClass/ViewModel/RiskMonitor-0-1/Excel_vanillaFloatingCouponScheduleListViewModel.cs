using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_vanillaFloatingCouponScheduleListViewModel : IXmlData
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
        
        public Excel_vanillaFloatingCouponScheduleListViewModel() { }
        
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
        
        #region Excel_vanillaFloatingCouponScheduleViewModel_
        private ObservableCollection<Excel_vanillaFloatingCouponScheduleViewModel> excel_vanillaFloatingCouponScheduleViewModel_;
        public ObservableCollection<Excel_vanillaFloatingCouponScheduleViewModel> Excel_vanillaFloatingCouponScheduleViewModel_
        {
            get { return this.excel_vanillaFloatingCouponScheduleViewModel_; }
            set
            {
                if (this.excel_vanillaFloatingCouponScheduleViewModel_ != value)
                {
                    this.excel_vanillaFloatingCouponScheduleViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_vanillaFloatingCouponScheduleViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "excel_vanillaFloatingCouponScheduleList");
                xmlWriter.WriteStartElement("excel_vanillaFloatingCouponScheduleList");
                    xmlWriter.WriteElementString("fixedRate" , this.fixedRate_);
                    
                    xmlWriter.WriteElementString("dayCounter" , this.dayCounter_);
                    
                    foreach (var item in excel_vanillaFloatingCouponScheduleViewModel_)
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
            Control v = new Excel_vanillaFloatingCouponScheduleListView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_vanillaFloatingCouponScheduleList serial_Excel_vanillaFloatingCouponScheduleList = serial_Class as FpmlSerializedCSharp.Excel_vanillaFloatingCouponScheduleList;
        
            this.fixedRate_ = serial_Excel_vanillaFloatingCouponScheduleList.FixedRate_.ValueStr;
            
            this.dayCounter_ = serial_Excel_vanillaFloatingCouponScheduleList.DayCounter_.ValueStr;
            
            List<FpmlSerializedCSharp.Excel_vanillaFloatingCouponSchedule> serial_excel_vanillaFloatingCouponSchedule = serial_Excel_vanillaFloatingCouponScheduleList.Excel_vanillaFloatingCouponSchedule_;
            this.excel_vanillaFloatingCouponScheduleViewModel_ = new ObservableCollection<Excel_vanillaFloatingCouponScheduleViewModel>();
            foreach (var item in serial_excel_vanillaFloatingCouponSchedule)
            {
                string type = item.Excel_type_.ValueStr;
                Excel_vanillaFloatingCouponScheduleViewModel viewModel = Excel_vanillaFloatingCouponScheduleViewModel.CreateExcel_vanillaFloatingCouponSchedule(type);
                viewModel.setFromSerial(item);
                this.excel_vanillaFloatingCouponScheduleViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

