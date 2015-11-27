using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class CdsSpreadTermstructureViewModel : ReferenceCurveViewModel
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
        
        public CdsSpreadTermstructureViewModel() { }
        
        #region Type_
        private string type_;
        public string Type_
        {
            get { return this.type_; }
            set
            {
                if (this.type_ != value)
                {
                    this.type_ = value;
                    this.NotifyPropertyChanged("Type_");
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
        
        #region DateGeneration_
        private string dateGeneration_;
        public string DateGeneration_
        {
            get { return this.dateGeneration_; }
            set
            {
                if (this.dateGeneration_ != value)
                {
                    this.dateGeneration_ = value;
                    this.NotifyPropertyChanged("DateGeneration_");
                }
            }
        }
        #endregion
        
        #region RecoveryRate_
        private string recoveryRate_;
        public string RecoveryRate_
        {
            get { return this.recoveryRate_; }
            set
            {
                if (this.recoveryRate_ != value)
                {
                    this.recoveryRate_ = value;
                    this.NotifyPropertyChanged("RecoveryRate_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("referenceCurve");
                xmlWriter.WriteElementString("excel_type" , "cdsSpreadTermstructure");
                xmlWriter.WriteStartElement("cdsSpreadTermstructure");
                    xmlWriter.WriteElementString("type" , this.type_);
                    
                    xmlWriter.WriteElementString("interpolation" , this.interpolation_);
                    
                    xmlWriter.WriteElementString("daycounter" , this.daycounter_);
                    
                    xmlWriter.WriteElementString("calendar" , this.calendar_);
                    
                    xmlWriter.WriteElementString("businessDayConvention" , this.businessDayConvention_);
                    
                    foreach (var item in rateDataViewModel_)
                    {
                        item.buildXml(xmlWriter);
                    }
                    
                    xmlWriter.WriteElementString("dateGeneration" , this.dateGeneration_);
                    
                    xmlWriter.WriteElementString("recoveryRate" , this.recoveryRate_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new CdsSpreadTermstructureView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ReferenceCurve serial_ReferenceCurve = serial_Class as FpmlSerializedCSharp.ReferenceCurve;
            FpmlSerializedCSharp.CdsSpreadTermstructure serial_CdsSpreadTermstructure = serial_ReferenceCurve.CdsSpreadTermstructure_;
        
            this.type_ = serial_CdsSpreadTermstructure.Type_.ValueStr;
            
            this.interpolation_ = serial_CdsSpreadTermstructure.Interpolation_.ValueStr;
            
            this.daycounter_ = serial_CdsSpreadTermstructure.Daycounter_.ValueStr;
            
            this.calendar_ = serial_CdsSpreadTermstructure.Calendar_.ValueStr;
            
            this.businessDayConvention_ = serial_CdsSpreadTermstructure.BusinessDayConvention_.ValueStr;
            
            List<FpmlSerializedCSharp.RateData> serial_rateData = serial_CdsSpreadTermstructure.RateData_;
            this.rateDataViewModel_ = new ObservableCollection<RateDataViewModel>();
            foreach (var item in serial_rateData)
            {
                string type = item.Excel_type_.ValueStr;
                RateDataViewModel viewModel = RateDataViewModel.CreateRateData(type);
                viewModel.setFromSerial(item);
                this.rateDataViewModel_.Add(viewModel);
            }
            
            this.dateGeneration_ = serial_CdsSpreadTermstructure.DateGeneration_.ValueStr;
            
            this.recoveryRate_ = serial_CdsSpreadTermstructure.RecoveryRate_.ValueStr;
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

