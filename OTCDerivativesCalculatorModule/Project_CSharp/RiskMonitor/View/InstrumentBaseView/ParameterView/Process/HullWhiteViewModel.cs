using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class HullWhiteViewModel : Underlying_paraViewModel
    {
    
        public HullWhiteViewModel() { }
    
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
            this.type_ = "HullWhite";

            //FpmlSerializedCSharp.Underlying_para serial_Underlying_para = serial_Class as FpmlSerializedCSharp.Underlying_para;
            //FpmlSerializedCSharp.HullWhite serial_HullWhite = serial_Underlying_para.HullWhite_;
        
            //this.alpha_ = serial_HullWhite.Alpha_.ValueStr;
            //this.sigma_ = serial_HullWhite.Sigma_.ValueStr;
            
            this.view_ = new HullWhiteView();
            this.view_.DataContext = this;
        }
        
        
    
        
    
        
    
    }
    
}

