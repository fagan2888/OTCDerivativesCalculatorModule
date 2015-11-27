using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class NullResultViewModel : PricingResultViewModel
    {
    
    
        public NullResultViewModel() { }
    
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
            FpmlSerializedCSharp.PricingResult serial_PricingResult = serial_Class as FpmlSerializedCSharp.PricingResult;
            FpmlSerializedCSharp.NullResult serial_NullResult = serial_PricingResult.NullResult_;
        
            this.view_ = new NullResultView();
            this.view_.DataContext = this;
        }

        public override UnderylingResultViewModel getUnderlyingResult()
        {
            throw new NotImplementedException();
        }
    }
    
}

