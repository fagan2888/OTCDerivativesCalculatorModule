using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class CouponPartViewModel : IXmlData
    {
        #region View_
        private Control view_;
        public Control View_
        {
            get { return this.view_; }
            set
            {
                if (this.view_ != value)
                {
                    this.view_ = value;
                    this.NotifyPropertyChanged("View_");
                }
            }
        }
        #endregion
        
    
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
        
    
        public CouponPartViewModel() { }
        
    
        #region PayRecieve_
        private string payRecieve_;
        public string PayRecieve_
        {
            get { return this.payRecieve_; }
            set
            {
                if (this.payRecieve_ != value)
                {
                    this.payRecieve_ = value;
                    this.NotifyPropertyChanged("PayRecieve_");
                }
            }
        }
        #endregion
        
        #region SwapStreamViewModel_
        private SwapStreamViewModel swapStreamViewModel_;
        public SwapStreamViewModel SwapStreamViewModel_
        {
            get { return this.swapStreamViewModel_; }
            set
            {
                if (this.swapStreamViewModel_ != value)
                {
                    this.swapStreamViewModel_ = value;
                    this.NotifyPropertyChanged("SwapStreamViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.CouponPart serial_CouponPart = serial_Class as FpmlSerializedCSharp.CouponPart;
        
            this.payRecieve_ = serial_CouponPart.PayRecieve_.ValueStr;
            
            FpmlSerializedCSharp.SwapStream serial_swapStream = serial_CouponPart.SwapStream_;
            string swapStreamtype = serial_swapStream.Type_.ValueStr;
            this.swapStreamViewModel_ = SwapStreamViewModel.CreateSwapStream(swapStreamtype);
            this.swapStreamViewModel_.setFromSerial(serial_swapStream);
            
            this.view_ = new CouponPartView();
            this.view_.DataContext = this;
        }
        
        
    
            #region SelectSwapStreamInfo_
            private string selectSwapStreamInfo_;
            public string SelectSwapStreamInfo_
            {
                get { return this.selectSwapStreamInfo_; }
                set
                {
                    if (this.selectSwapStreamInfo_ != value)
                    {
                        this.selectSwapStreamInfo_ = value;
                        this.NotifyPropertyChanged("SelectSwapStreamInfo_");
                    }
                }
            }
            #endregion
            
            public void selectSwapStreamInfo(string typeStr)
            {
                this.swapStreamViewModel_ = SwapStreamViewModel.CreateSwapStream(typeStr);
                this.view_.DataContext = this;
            }
            
        
    
        
    
    }
    
}

