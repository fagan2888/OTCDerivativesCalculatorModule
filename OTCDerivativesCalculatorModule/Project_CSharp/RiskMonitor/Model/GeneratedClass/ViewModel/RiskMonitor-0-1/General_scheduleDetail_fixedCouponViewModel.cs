using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class General_scheduleDetail_fixedCouponViewModel : GeneralScheduleDeatilViewModel
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
        
        public General_scheduleDetail_fixedCouponViewModel() { }
        
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
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("generalScheduleDeatil");
                xmlWriter.WriteElementString("type" , "general_scheduleDetail_fixedCoupon");
                xmlWriter.WriteStartElement("general_scheduleDetail_fixedCoupon");
                    xmlWriter.WriteElementString("fixedRate" , this.fixedRate_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new General_scheduleDetail_fixedCouponView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.GeneralScheduleDeatil serial_GeneralScheduleDeatil = serial_Class as FpmlSerializedCSharp.GeneralScheduleDeatil;
            FpmlSerializedCSharp.General_scheduleDetail_fixedCoupon serial_General_scheduleDetail_fixedCoupon = serial_GeneralScheduleDeatil.General_scheduleDetail_fixedCoupon_;
        
            this.fixedRate_ = serial_General_scheduleDetail_fixedCoupon.FixedRate_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

