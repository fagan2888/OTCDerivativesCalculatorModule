//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.ComponentModel;
//using System.Collections.ObjectModel;
//using System.Xml;
//using FpmlSerializedCSharp;
//using XmlBuilder.Views.StructuredProduct.ViewModel;

//namespace XmlBuilder.ViewModel
//{
//    public class EventCheckInfoCtrlViewModel : IXmlBuild
//    {
//        public EventCheckInfoCtrlViewModel(StructuredProduct serial_sp) 
//        {
//            this.serial_sp_ = serial_sp;
//        }

//        private void buildXml() 
//        {
//            eventCheckVMList_ = new ObservableCollection<EventCheckViewModel>();

//            foreach (EventCheck item in serial_sp_.StructuredProductPayoff_.EventSchedule_.EventCheck_)
//            {
//                eventCheckVMList_.Add(new EventCheckViewModel(item));
//            }
            
//        }

//        // ----------------------------------------------------
//        public ObservableCollection<EventCheckViewModel> eventCheckVMList_ { get; set; }

//        //// --------------------------------------------------
//        //public EventIndexTransformation eventIndexTransformation_ { get; set; }

//        //public EventDate eventDate_ { get; set; }

//        //public PayoffBase payoffBase_ { get; set; }




//        public StructuredProduct serial_sp_ { get; set; }

//        public StringBuilder buildXml()
//        {
//            StringBuilder sb = new StringBuilder("");
//            XmlWriterSettings setting = new XmlWriterSettings();
//            setting.Indent = true;

//            XmlWriter xmlWriter = XmlWriter.Create(sb, setting);

//            xmlWriter.WriteStartElement("eventSchedule");

//            foreach (EventCheckViewModel item in eventCheckVMList_)
//            {
//                xmlWriter.WriteRaw(item.buildXml().ToString());
//            }

//            xmlWriter.WriteEndElement();

//            return sb;
//        }
//    }
//}
