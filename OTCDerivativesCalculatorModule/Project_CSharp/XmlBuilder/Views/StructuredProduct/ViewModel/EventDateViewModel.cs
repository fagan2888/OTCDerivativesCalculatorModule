using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Xml;

namespace XmlBuilder.Views.StructuredProduct.ViewModel
{
    public class EventDateViewModel :IXmlBuild
    {
        
        public EventDateViewModel(FpmlSerializedCSharp.EventDate serial_ed) 
        {
            eventDates_ = new ObservableCollection<DateTime>();
            eventDates_.Add(serial_ed.DateSingle_.DateTimeValue());

        }

        public EventDateViewModel(FpmlSerializedCSharp.EventDates serial_eds) 
        {
            eventDates_ = new ObservableCollection<DateTime>();
            if (serial_eds.DateInterval_ != null) 
            {
                eventDates_.Add(serial_eds.DateInterval_.FirstDate_.DateTimeValue() );
                eventDates_.Add(serial_eds.DateInterval_.LastDate_.DateTimeValue());
                //this.period_ = serial_eds.DateInterval_.

            }
            else if ( serial_eds.DateList_ != null )
            {
                foreach (FpmlSerializedCSharp.XsdTypeDate item in serial_eds.DateList_.Date_)
                {
                    eventDates_.Add(item.DateTimeValue());
                }
            }

            
        }

        public void buildXml(XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("eventDate");

            foreach (DateTime item in eventDates_)
            {
                //xmlWriter.WriteRaw(item.buildXml().ToString());
                xmlWriter.WriteRaw("Not implemented");
            }

            xmlWriter.WriteEndElement();

        }

        #region EventDates_
        private ObservableCollection<DateTime> eventDates_;
        public ObservableCollection<DateTime> EventDates_
        {
            get { return this.eventDates_; }
            set
            {
                if (this.eventDates_ != value)
                {
                    this.eventDates_ = value;
                    this.NotifyPropertyChanged("EventDates_");
                }
            }
        }
        #endregion

        #region Period_
        private string period_;
        public string Period_
        {
            get { return this.period_; }
            set
            {
                if (this.period_ != value)
                {
                    this.period_ = value;
                    this.NotifyPropertyChanged("Period_");
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



    }
}
