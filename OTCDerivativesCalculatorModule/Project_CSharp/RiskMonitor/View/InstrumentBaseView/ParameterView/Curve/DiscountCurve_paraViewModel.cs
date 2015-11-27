using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class DiscountCurve_paraViewModel : IXmlData
    {
        #region View_
        protected Control view_;
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
    
        public DiscountCurve_paraViewModel() 
        {
            this.view_ = new DiscountCurve_paraView();
            this.yieldTermstructureViewModel_ = new ObservableCollection<YieldTermstructureViewModel>();

        }
    
        #region YieldTermstructureViewModel_
        private ObservableCollection<YieldTermstructureViewModel> yieldTermstructureViewModel_;
        public ObservableCollection<YieldTermstructureViewModel> YieldTermstructureViewModel_
        {
            get { return this.yieldTermstructureViewModel_; }
            set
            {
                if (this.yieldTermstructureViewModel_ != value)
                {
                    this.yieldTermstructureViewModel_ = value;
                    this.NotifyPropertyChanged("YieldTermstructureViewModel_");
                }
            }
        }
        #endregion
        
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("discountCurve_para");

            foreach (var item in this.yieldTermstructureViewModel_)
            {
                item.buildXml(xmlWriter);
            }

            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.DiscountCurve_para serial_DiscountCurve_para = serial_Class as FpmlSerializedCSharp.DiscountCurve_para;
        
            FpmlSerializedCSharp.YieldTermstructure serial_yieldTermstructure = serial_DiscountCurve_para.YieldTermstructure_;

            //this.yieldTermstructureViewModel_ = new YieldTermstructureViewModel();
            //this.yieldTermstructureViewModel_.setFromSerial(serial_yieldTermstructure);

            this.view_ = new DiscountCurve_paraView();
            this.view_.DataContext = this;
        }
    
    }
    
}

