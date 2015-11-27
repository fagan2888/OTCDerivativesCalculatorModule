using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class InterestRateSwapViewModel : PayoffInfoViewModel
    {
        public InterestRateSwapViewModel() { }
        
        #region CouponPartViewModel_
        private ObservableCollection<CouponPartViewModel> couponPartViewModel_;
        public ObservableCollection<CouponPartViewModel> CouponPartViewModel_
        {
            get { return this.couponPartViewModel_; }
            set
            {
                if (this.couponPartViewModel_ != value)
                {
                    this.couponPartViewModel_ = value;
                    this.NotifyPropertyChanged("CouponPartViewModel_");
                }
            }
        }
        #endregion
        
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.PayoffInfo serial_PayoffInfo = serial_Class as FpmlSerializedCSharp.PayoffInfo;
            FpmlSerializedCSharp.InterestRateSwap serial_InterestRateSwap = serial_PayoffInfo.InterestRateSwap_;
        
            List<FpmlSerializedCSharp.CouponPart> serial_couponPart = serial_InterestRateSwap.CouponPart_;
            this.couponPartViewModel_ = new ObservableCollection<CouponPartViewModel>();
            foreach (var item in serial_couponPart)
            {
                CouponPartViewModel viewModel = new CouponPartViewModel();
                viewModel.setFromSerial(item);
                this.couponPartViewModel_.Add(viewModel);
            }
            
            this.view_ = new InterestRateSwapView();
            this.view_.DataContext = this;
        }
    
    }
    
}

