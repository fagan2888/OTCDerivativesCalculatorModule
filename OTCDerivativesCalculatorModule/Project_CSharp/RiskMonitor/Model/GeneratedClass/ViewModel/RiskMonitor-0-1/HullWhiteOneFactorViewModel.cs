using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class HullWhiteOneFactorViewModel : Underlying_paraViewModel
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
        
        public HullWhiteOneFactorViewModel() { }
        
        #region Alpha_
        private string alpha_;
        public string Alpha_
        {
            get { return this.alpha_; }
            set
            {
                if (this.alpha_ != value)
                {
                    this.alpha_ = value;
                    this.NotifyPropertyChanged("Alpha_");
                }
            }
        }
        #endregion
        
        #region Sigma_
        private string sigma_;
        public string Sigma_
        {
            get { return this.sigma_; }
            set
            {
                if (this.sigma_ != value)
                {
                    this.sigma_ = value;
                    this.NotifyPropertyChanged("Sigma_");
                }
            }
        }
        #endregion
        
        #region TenorViewModel_
        private TenorViewModel tenorViewModel_;
        public TenorViewModel TenorViewModel_
        {
            get { return this.tenorViewModel_; }
            set
            {
                if (this.tenorViewModel_ != value)
                {
                    this.tenorViewModel_ = value;
                    this.NotifyPropertyChanged("TenorViewModel_");
                }
            }
        }
        #endregion
        
        #region FittingYieldCurveViewModel_
        private FittingYieldCurveViewModel fittingYieldCurveViewModel_;
        public FittingYieldCurveViewModel FittingYieldCurveViewModel_
        {
            get { return this.fittingYieldCurveViewModel_; }
            set
            {
                if (this.fittingYieldCurveViewModel_ != value)
                {
                    this.fittingYieldCurveViewModel_ = value;
                    this.NotifyPropertyChanged("FittingYieldCurveViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("underlying_para");
                xmlWriter.WriteElementString("type" , "hullWhiteOneFactor");
                xmlWriter.WriteStartElement("hullWhiteOneFactor");
                    xmlWriter.WriteElementString("alpha" , this.alpha_);
                    
                    xmlWriter.WriteElementString("sigma" , this.sigma_);
                    
                    tenorViewModel_.buildXml(xmlWriter);
                    
                    fittingYieldCurveViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new HullWhiteOneFactorView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Underlying_para serial_Underlying_para = serial_Class as FpmlSerializedCSharp.Underlying_para;
            FpmlSerializedCSharp.HullWhiteOneFactor serial_HullWhiteOneFactor = serial_Underlying_para.HullWhiteOneFactor_;
        
            this.alpha_ = serial_HullWhiteOneFactor.Alpha_.ValueStr;
            
            this.sigma_ = serial_HullWhiteOneFactor.Sigma_.ValueStr;
            
            FpmlSerializedCSharp.Tenor serial_tenor = serial_HullWhiteOneFactor.Tenor_;
            string tenortype = serial_tenor.Excel_type_.ValueStr;
            this.tenorViewModel_ = TenorViewModel.CreateTenor(tenortype);
            this.tenorViewModel_.setFromSerial(serial_tenor);
            
            FpmlSerializedCSharp.FittingYieldCurve serial_fittingYieldCurve = serial_HullWhiteOneFactor.FittingYieldCurve_;
            string fittingYieldCurvetype = serial_fittingYieldCurve.Excel_type_.ValueStr;
            this.fittingYieldCurveViewModel_ = FittingYieldCurveViewModel.CreateFittingYieldCurve(fittingYieldCurvetype);
            this.fittingYieldCurveViewModel_.setFromSerial(serial_fittingYieldCurve);
            
        }
        
        
    
            
            
            
            
        
    
        
    
    }
    
}

