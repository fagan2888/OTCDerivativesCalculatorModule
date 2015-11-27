using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class InterestRateSwapPayoffViewModel : PayoffInfoViewModel
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
        
        public InterestRateSwapPayoffViewModel() { }
        
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
            xmlWriter.WriteStartElement("payoffInfo");
                xmlWriter.WriteElementString("type" , "interestRateSwapPayoff");
                xmlWriter.WriteStartElement("interestRateSwapPayoff");
                    foreach (var item in couponPartViewModel_)
                    {
                        item.buildXml(xmlWriter);
                    }
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new InterestRateSwapPayoffView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.PayoffInfo serial_PayoffInfo = serial_Class as FpmlSerializedCSharp.PayoffInfo;
            FpmlSerializedCSharp.InterestRateSwapPayoff serial_InterestRateSwapPayoff = serial_PayoffInfo.InterestRateSwapPayoff_;
        
            List<FpmlSerializedCSharp.CouponPart> serial_couponPart = serial_InterestRateSwapPayoff.CouponPart_;
            this.couponPartViewModel_ = new ObservableCollection<CouponPartViewModel>();
            foreach (var item in serial_couponPart)
            {
                string type = item.Excel_type_.ValueStr;
                CouponPartViewModel viewModel = CouponPartViewModel.CreateCouponPart(type);
                viewModel.setFromSerial(item);
                this.couponPartViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

