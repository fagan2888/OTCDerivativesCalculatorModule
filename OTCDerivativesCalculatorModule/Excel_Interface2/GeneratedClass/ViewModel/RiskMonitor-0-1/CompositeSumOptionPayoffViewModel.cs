using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class CompositeSumOptionPayoffViewModel : PayoffInfoViewModel
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
        
        public CompositeSumOptionPayoffViewModel() { }
        
        #region FixingDateInfoViewModel_
        private FixingDateInfoViewModel fixingDateInfoViewModel_;
        public FixingDateInfoViewModel FixingDateInfoViewModel_
        {
            get { return this.fixingDateInfoViewModel_; }
            set
            {
                if (this.fixingDateInfoViewModel_ != value)
                {
                    this.fixingDateInfoViewModel_ = value;
                    this.NotifyPropertyChanged("FixingDateInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region PayoffDateInfoViewModel_
        private PayoffDateInfoViewModel payoffDateInfoViewModel_;
        public PayoffDateInfoViewModel PayoffDateInfoViewModel_
        {
            get { return this.payoffDateInfoViewModel_; }
            set
            {
                if (this.payoffDateInfoViewModel_ != value)
                {
                    this.payoffDateInfoViewModel_ = value;
                    this.NotifyPropertyChanged("PayoffDateInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region ReferenceCalculationInfoViewModel_
        private ReferenceCalculationInfoViewModel referenceCalculationInfoViewModel_;
        public ReferenceCalculationInfoViewModel ReferenceCalculationInfoViewModel_
        {
            get { return this.referenceCalculationInfoViewModel_; }
            set
            {
                if (this.referenceCalculationInfoViewModel_ != value)
                {
                    this.referenceCalculationInfoViewModel_ = value;
                    this.NotifyPropertyChanged("ReferenceCalculationInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region StandardOptionViewModel_
        private ObservableCollection<StandardOptionViewModel> standardOptionViewModel_;
        public ObservableCollection<StandardOptionViewModel> StandardOptionViewModel_
        {
            get { return this.standardOptionViewModel_; }
            set
            {
                if (this.standardOptionViewModel_ != value)
                {
                    this.standardOptionViewModel_ = value;
                    this.NotifyPropertyChanged("StandardOptionViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("payoffInfo");
                xmlWriter.WriteElementString("excel_type" , "compositeSumOptionPayoff");
                xmlWriter.WriteStartElement("compositeSumOptionPayoff");
                    fixingDateInfoViewModel_.buildXml(xmlWriter);
                    
                    payoffDateInfoViewModel_.buildXml(xmlWriter);
                    
                    referenceCalculationInfoViewModel_.buildXml(xmlWriter);
                    
                    foreach (var item in standardOptionViewModel_)
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
            Control v = new CompositeSumOptionPayoffView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.PayoffInfo serial_PayoffInfo = serial_Class as FpmlSerializedCSharp.PayoffInfo;
            FpmlSerializedCSharp.CompositeSumOptionPayoff serial_CompositeSumOptionPayoff = serial_PayoffInfo.CompositeSumOptionPayoff_;
        
            FpmlSerializedCSharp.FixingDateInfo serial_fixingDateInfo = serial_CompositeSumOptionPayoff.FixingDateInfo_;
            string fixingDateInfotype = serial_fixingDateInfo.Excel_type_.ValueStr;
            this.fixingDateInfoViewModel_ = FixingDateInfoViewModel.CreateFixingDateInfo(fixingDateInfotype);
            this.fixingDateInfoViewModel_.setFromSerial(serial_fixingDateInfo);
            
            FpmlSerializedCSharp.PayoffDateInfo serial_payoffDateInfo = serial_CompositeSumOptionPayoff.PayoffDateInfo_;
            string payoffDateInfotype = serial_payoffDateInfo.Excel_type_.ValueStr;
            this.payoffDateInfoViewModel_ = PayoffDateInfoViewModel.CreatePayoffDateInfo(payoffDateInfotype);
            this.payoffDateInfoViewModel_.setFromSerial(serial_payoffDateInfo);
            
            FpmlSerializedCSharp.ReferenceCalculationInfo serial_referenceCalculationInfo = serial_CompositeSumOptionPayoff.ReferenceCalculationInfo_;
            string referenceCalculationInfotype = serial_referenceCalculationInfo.Excel_type_.ValueStr;
            this.referenceCalculationInfoViewModel_ = ReferenceCalculationInfoViewModel.CreateReferenceCalculationInfo(referenceCalculationInfotype);
            this.referenceCalculationInfoViewModel_.setFromSerial(serial_referenceCalculationInfo);
            
            List<FpmlSerializedCSharp.StandardOption> serial_standardOption = serial_CompositeSumOptionPayoff.StandardOption_;
            this.standardOptionViewModel_ = new ObservableCollection<StandardOptionViewModel>();
            foreach (var item in serial_standardOption)
            {
                string type = item.Excel_type_.ValueStr;
                StandardOptionViewModel viewModel = StandardOptionViewModel.CreateStandardOption(type);
                viewModel.setFromSerial(item);
                this.standardOptionViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
            
            
            
            
            
            
        
    
        
    
    }
    
}

