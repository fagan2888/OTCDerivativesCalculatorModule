using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Xml;
using XmlBuilder.Ctrl;

namespace XmlBuilder.Views.StructuredProduct.ViewModel
{
    public class FunctionEventViewModel
    {
        private FpmlSerializedCSharp.FunctionEvents functionEvents;

        public FunctionEventViewModel(FpmlSerializedCSharp.FunctionEvents functionEvents)
        {
            // TODO: Complete member initialization
            this.functionEvents = functionEvents;
            this.buildFromSerialClass();
        }

        public void buildXml(XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("functionEvents");

            foreach (EventFunctionMModel item in eventFunctionMList_)
            {
                item.buildXml(xmlWriter);
            }

            xmlWriter.WriteRaw(jointFunctionEventModel_.buildXml().ToString());

            xmlWriter.WriteEndElement();
        }

        private void buildFromSerialClass()
        {
            this.eventFunctionMList_ = new ObservableCollection<EventFunctionMModel>();
            
            foreach (FpmlSerializedCSharp.EventFunctionM item in functionEvents.EventFunctionM_)
            {
                EventFunctionMModel efmm = new EventFunctionMModel(item);
                this.FEventDetailCtrl_ = efmm.FEventDetailCtrl_;
                this.eventFunctionMList_.Add(efmm);
                
            }

            this.jointFunctionEventModel_ = new JointFunctionEventModel(functionEvents.JointFunctionEvent_);
        
        }

        #region EventFunctionMList_
        private ObservableCollection<EventFunctionMModel> eventFunctionMList_;
        public ObservableCollection<EventFunctionMModel> EventFunctionMList_
        {
            get { return this.eventFunctionMList_; }
            set
            {
                if (this.eventFunctionMList_ != value)
                {
                    this.eventFunctionMList_ = value;
                    this.NotifyPropertyChanged("EventFunctionMList_");
                }
            }
        }
        #endregion

        #region JointFunctionEventModel_
        private JointFunctionEventModel jointFunctionEventModel_;
        public JointFunctionEventModel JointFunctionEventModel_
        {
            get { return this.jointFunctionEventModel_; }
            set
            {
                if (this.jointFunctionEventModel_ != value)
                {
                    this.jointFunctionEventModel_ = value;
                    this.NotifyPropertyChanged("JointFunctionEventModel_");
                }
            }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        public UserControl FEventDetailCtrl_ { get; set; }
    }
}
