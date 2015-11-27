using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class CouponScheduleInfoViewModel : IXmlData
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
        
    
        public CouponScheduleInfoViewModel() { }
        
    
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
        
        #region CouponScheduleViewModel_
        private ObservableCollection<CouponScheduleViewModel> couponScheduleViewModel_;
        public ObservableCollection<CouponScheduleViewModel> CouponScheduleViewModel_
        {
            get { return this.couponScheduleViewModel_; }
            set
            {
                if (this.couponScheduleViewModel_ != value)
                {
                    this.couponScheduleViewModel_ = value;
                    this.NotifyPropertyChanged("CouponScheduleViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "couponScheduleInfo");
                xmlWriter.WriteStartElement("couponScheduleInfo");
                    xmlWriter.WriteElementString("scheduleInitialDate" , this.scheduleInitialDate_);
                    
                    xmlWriter.WriteElementString("maturityDate" , this.maturityDate_);
                    
                    couponScheduleViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.CouponScheduleInfo serial_CouponScheduleInfo = serial_Class as FpmlSerializedCSharp.CouponScheduleInfo;
        
            this.scheduleInitialDate_ = serial_CouponScheduleInfo.ScheduleInitialDate_.ValueStr;
            
            this.maturityDate_ = serial_CouponScheduleInfo.MaturityDate_.ValueStr;
            
            List<FpmlSerializedCSharp.CouponSchedule> serial_couponSchedule = serial_CouponScheduleInfo.CouponSchedule_;
            this.couponScheduleViewModel_ = new ObservableCollection<CouponScheduleViewModel>();
            foreach (var item in serial_couponSchedule)
            {
                string type = item.Excel_type_.ValueStr;
                CouponScheduleViewModel viewModel = CouponScheduleViewModel.CreateCouponSchedule(type);
                viewModel.setFromSerial(item);
                this.couponScheduleViewModel_.Add(viewModel);
            }
            
            this.view_ = new CouponScheduleInfoView();
            this.view_.DataContext = this;
        }
        
        
    
            #region SelectCouponScheduleInfo_
            private string selectCouponScheduleInfo_;
            public string SelectCouponScheduleInfo_
            {
                get { return this.selectCouponScheduleInfo_; }
                set
                {
                    if (this.selectCouponScheduleInfo_ != value)
                    {
                        this.selectCouponScheduleInfo_ = value;
                        this.NotifyPropertyChanged("SelectCouponScheduleInfo_");
                    }
                }
            }
            #endregion
            
            public void selectCouponScheduleInfo(string typeStr)
            {
                this.couponScheduleViewModel_ = CouponScheduleViewModel.CreateCouponSchedule(typeStr);
                this.view_.DataContext = this;
            }
            
        
    
        
    
    }
    
}

