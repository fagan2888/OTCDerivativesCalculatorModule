using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class AutoCallRedemViewModel : RedemptionInfoViewModel
    {

        public AutoCallRedemViewModel() { }
        
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("redemptionInfo");
                xmlWriter.WriteElementString("type" , "autoCallRedem");
                xmlWriter.WriteStartElement("autoCallRedem");

                    foreach (var item in this.eventTriggerViewModel_)
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
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.RedemptionInfo serial_RedemptionInfo = serial_Class as FpmlSerializedCSharp.RedemptionInfo;
            FpmlSerializedCSharp.AutoCallRedem serial_AutoCallRedem = serial_RedemptionInfo.AutoCallRedem_;
        
            List<FpmlSerializedCSharp.EventTrigger> serial_eventTrigger = serial_AutoCallRedem.EventTrigger_;
            this.eventTriggerViewModel_ = new ObservableCollection<EventTriggerViewModel>();

            foreach (var item in serial_eventTrigger)
            {
                string type = item.Type_.ValueStr;
                EventTriggerViewModel viewModel = EventTriggerViewModel.CreateEventTrigger(type);
                viewModel.setFromSerial(item);
                this.eventTriggerViewModel_.Add(viewModel);
            }

            this.view_ = new RedemptionInfoView();
            this.view_.DataContext = this;
        }
    }
    
}

