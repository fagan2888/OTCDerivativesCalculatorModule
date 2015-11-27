using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class SimpleCashFlowResultViewModel : CashFlowInfoResultViewModel
    {
        
        public SimpleCashFlowResultViewModel() { }
    
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
            FpmlSerializedCSharp.CashFlowInfoResult serial_CashFlowInfoResult = serial_Class as FpmlSerializedCSharp.CashFlowInfoResult;
            FpmlSerializedCSharp.SimpleCashFlowResult serial_SimpleCashFlowResult = serial_CashFlowInfoResult.SimpleCashFlowResult_;
        
            //this.view_ = new SimpleCashFlowResultView();
            this.view_.DataContext = this;
        }
        
        
    
        
    
        
    
    }
    
}

