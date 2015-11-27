using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class YieldTermstructureViewModel : ReferenceCurveViewModel
    {
        
    
        public YieldTermstructureViewModel() 
        {
            this.rateDataViewModel_ = new ObservableCollection<RateDataViewModel>();
        }

        #region CurveType_
        private string curveType_;
        public string CurveType_
        {
            get { return this.curveType_; }
            set
            {
                if (this.curveType_ != value)
                {
                    this.curveType_ = value;
                    this.NotifyPropertyChanged("CurveType_");
                }
            }
        }
        #endregion

        #region Interpolation_
        private string interpolation_;
        public string Interpolation_
        {
            get { return this.interpolation_; }
            set
            {
                if (this.interpolation_ != value)
                {
                    this.interpolation_ = value;
                    this.NotifyPropertyChanged("Interpolation_");
                }
            }
        }
        #endregion
        
        #region Daycounter_
        private string daycounter_;
        public string Daycounter_
        {
            get { return this.daycounter_; }
            set
            {
                if (this.daycounter_ != value)
                {
                    this.daycounter_ = value;
                    this.NotifyPropertyChanged("Daycounter_");
                }
            }
        }
        #endregion
        
        #region Calendar_
        private string calendar_;
        public string Calendar_
        {
            get { return this.calendar_; }
            set
            {
                if (this.calendar_ != value)
                {
                    this.calendar_ = value;
                    this.NotifyPropertyChanged("Calendar_");
                }
            }
        }
        #endregion
        
        #region BusinessDayConvention_
        private string businessDayConvention_;
        public string BusinessDayConvention_
        {
            get { return this.businessDayConvention_; }
            set
            {
                if (this.businessDayConvention_ != value)
                {
                    this.businessDayConvention_ = value;
                    this.NotifyPropertyChanged("BusinessDayConvention_");
                }
            }
        }
        #endregion
        
        #region RateDataViewModel_
        private ObservableCollection<RateDataViewModel> rateDataViewModel_;
        public ObservableCollection<RateDataViewModel> RateDataViewModel_
        {
            get { return this.rateDataViewModel_; }
            set
            {
                if (this.rateDataViewModel_ != value)
                {
                    this.rateDataViewModel_ = value;
                    this.NotifyPropertyChanged("RateDataViewModel_");
                }
            }
        }
        #endregion
        
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("yieldTermstructure");
            xmlWriter.WriteElementString("type", this.type_);
            xmlWriter.WriteElementString("curveType", this.curveType_);
            xmlWriter.WriteElementString("interpolation", this.interpolation_);
            xmlWriter.WriteElementString("daycounter", this.daycounter_);
            xmlWriter.WriteElementString("calendar", this.calendar_);
            xmlWriter.WriteElementString("businessDayConvention", this.businessDayConvention_);

            foreach (var item in this.rateDataViewModel_)
            {
                item.buildXml(xmlWriter);                
            }
            
            xmlWriter.WriteEndElement();
        }

        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }

        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.YieldTermstructure serial_YieldTermstructure = serial_Class as FpmlSerializedCSharp.YieldTermstructure;
        
            this.type_ = serial_YieldTermstructure.CurveType_.ValueStr;
            //this.curveType_ = serial_YieldTermstructure.c .ValueStr;
            this.interpolation_ = serial_YieldTermstructure.Interpolation_.ValueStr;
            this.daycounter_ = serial_YieldTermstructure.Daycounter_.ValueStr;
            this.calendar_ = serial_YieldTermstructure.Calendar_.ValueStr;
            this.businessDayConvention_ = serial_YieldTermstructure.BusinessDayConvention_.ValueStr;
            
            List<FpmlSerializedCSharp.RateData> serial_rateData = serial_YieldTermstructure.RateData_;
            this.rateDataViewModel_ = new ObservableCollection<RateDataViewModel>();
            foreach (var item in serial_rateData)
            {
                RateDataViewModel viewModel = new RateDataViewModel();
                viewModel.setFromSerial(item);
                this.rateDataViewModel_.Add(viewModel);
            }
            
            this.view_ = new YieldTermstructureView();
            this.view_.DataContext = this;
        }
        
    }
    
}

