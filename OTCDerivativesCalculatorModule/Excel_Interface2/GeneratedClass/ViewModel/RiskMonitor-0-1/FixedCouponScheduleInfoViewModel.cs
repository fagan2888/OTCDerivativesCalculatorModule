using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class FixedCouponScheduleInfoViewModel : IXmlData
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
        
    
        public FixedCouponScheduleInfoViewModel() { }
        
    
        #region ScheduleInitialDate_
        private string scheduleInitialDate_;
        public string ScheduleInitialDate_
        {
            get { return this.scheduleInitialDate_; }
            set
            {
                if (this.scheduleInitialDate_ != value)
                {
                    this.scheduleInitialDate_ = value;
                    this.NotifyPropertyChanged("ScheduleInitialDate_");
                }
            }
        }
        #endregion
        
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
        
        #region MaturityDate_
        private string maturityDate_;
        public string MaturityDate_
        {
            get { return this.maturityDate_; }
            set
            {
                if (this.maturityDate_ != value)
                {
                    this.maturityDate_ = value;
                    this.NotifyPropertyChanged("MaturityDate_");
                }
            }
        }
        #endregion
        
        #region FixedCouponScheduleViewModel_
        private ObservableCollection<FixedCouponScheduleViewModel> fixedCouponScheduleViewModel_;
        public ObservableCollection<FixedCouponScheduleViewModel> FixedCouponScheduleViewModel_
        {
            get { return this.fixedCouponScheduleViewModel_; }
            set
            {
                if (this.fixedCouponScheduleViewModel_ != value)
                {
                    this.fixedCouponScheduleViewModel_ = value;
                    this.NotifyPropertyChanged("FixedCouponScheduleViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "fixedCouponScheduleInfo");
                xmlWriter.WriteStartElement("fixedCouponScheduleInfo");
                    xmlWriter.WriteElementString("scheduleInitialDate" , this.scheduleInitialDate_);
                    
                    xmlWriter.WriteElementString("fixedRate" , this.fixedRate_);
                    
                    xmlWriter.WriteElementString("dayCounter" , this.dayCounter_);
                    
                    xmlWriter.WriteElementString("maturityDate" , this.maturityDate_);
                    
                    fixedCouponScheduleViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.FixedCouponScheduleInfo serial_FixedCouponScheduleInfo = serial_Class as FpmlSerializedCSharp.FixedCouponScheduleInfo;
        
            this.scheduleInitialDate_ = serial_FixedCouponScheduleInfo.ScheduleInitialDate_.ValueStr;
            
            this.fixedRate_ = serial_FixedCouponScheduleInfo.FixedRate_.ValueStr;
            
            this.dayCounter_ = serial_FixedCouponScheduleInfo.DayCounter_.ValueStr;
            
            this.maturityDate_ = serial_FixedCouponScheduleInfo.MaturityDate_.ValueStr;
            
            List<FpmlSerializedCSharp.FixedCouponSchedule> serial_fixedCouponSchedule = serial_FixedCouponScheduleInfo.FixedCouponSchedule_;
            this.fixedCouponScheduleViewModel_ = new ObservableCollection<FixedCouponScheduleViewModel>();
            foreach (var item in serial_fixedCouponSchedule)
            {
                string type = item.Excel_type_.ValueStr;
                FixedCouponScheduleViewModel viewModel = FixedCouponScheduleViewModel.CreateFixedCouponSchedule(type);
                viewModel.setFromSerial(item);
                this.fixedCouponScheduleViewModel_.Add(viewModel);
            }
            
            this.view_ = new FixedCouponScheduleInfoView();
            this.view_.DataContext = this;
        }
        
        
    
            #region SelectFixedCouponScheduleInfo_
            private string selectFixedCouponScheduleInfo_;
            public string SelectFixedCouponScheduleInfo_
            {
                get { return this.selectFixedCouponScheduleInfo_; }
                set
                {
                    if (this.selectFixedCouponScheduleInfo_ != value)
                    {
                        this.selectFixedCouponScheduleInfo_ = value;
                        this.NotifyPropertyChanged("SelectFixedCouponScheduleInfo_");
                    }
                }
            }
            #endregion
            
            public void selectFixedCouponScheduleInfo(string typeStr)
            {
                this.fixedCouponScheduleViewModel_ = FixedCouponScheduleViewModel.CreateFixedCouponSchedule(typeStr);
                this.view_.DataContext = this;
            }
            
        
    
        
    
    }
    
}

