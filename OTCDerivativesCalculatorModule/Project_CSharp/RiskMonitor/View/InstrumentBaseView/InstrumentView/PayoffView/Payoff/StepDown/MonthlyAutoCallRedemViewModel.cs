using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class MonthlyAutoCallRedemViewModel : RedemptionInfoViewModel
    {
        public MonthlyAutoCallRedemViewModel() { }
        
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
            FpmlSerializedCSharp.RedemptionInfo serial_RedemptionInfo = serial_Class as FpmlSerializedCSharp.RedemptionInfo;
            FpmlSerializedCSharp.MonthlyAutoCallRedem serial_MonthlyAutoCallRedem = serial_RedemptionInfo.MonthlyAutoCallRedem_;
        
            List<FpmlSerializedCSharp.EventTrigger> serial_eventTrigger = serial_MonthlyAutoCallRedem.EventTrigger_;
            foreach (var item in serial_eventTrigger)
            {
                string type = item.Type_.ValueStr;
                EventTriggerViewModel viewModel = EventTriggerViewModel.CreateEventTrigger(type);
                viewModel.setFromSerial(serial_MonthlyAutoCallRedem);
                this.eventTriggerViewModel_.Add(viewModel);
            }

            this.view_ = new RedemptionInfoView();
            this.view_.DataContext = this;
        }
        
        
    
        
    
    }
    
}

