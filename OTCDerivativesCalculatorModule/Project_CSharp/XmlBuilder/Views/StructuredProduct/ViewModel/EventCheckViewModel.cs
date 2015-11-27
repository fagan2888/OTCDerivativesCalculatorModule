using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Xml;

namespace XmlBuilder.Views.StructuredProduct.ViewModel
{
    public class EventCheckViewModel
    {
        public EventCheckViewModel(FpmlSerializedCSharp.EventCheck serial_ec) 
        {
            this.serial_ec_ = serial_ec;
            this.buildFromSerialClass();
        }

        private void buildFromSerialClass()
        {
            
            this.symbol_ = serial_ec_.ID_;

            if (serial_ec_.EventCheckNormal_ != null)
            {
                this.type_ = "Single";
                serial_ecNormal_ = serial_ec_.EventCheckNormal_;

                eitfvm_ = new EventIndexTransformationViewModel(serial_ecNormal_.EventIndexTransformation_);
                functionEventVM_ = new FunctionEventViewModel(serial_ecNormal_.FunctionEvents_);
                eventDateVM_ = new EventDateViewModel(serial_ecNormal_.EventDate_);
                payoffListVM_ = new PayoffListViewModel(serial_ecNormal_.PayoffBase_);

            }
            else if (serial_ec_.EventCheckTime_ != null)
            {
                this.type_ = "Interval";
                serial_ecTime_ = serial_ec_.EventCheckTime_;
                eitfvm_ = new EventIndexTransformationViewModel(serial_ecTime_.EventIndexTransformation_);
                functionEventVM_ = new FunctionEventViewModel(serial_ecTime_.FunctionEvents_);
                eventDateVM_ = new EventDateViewModel(serial_ecTime_.EventDates_);
                payoffListVM_ = new PayoffListViewModel(serial_ecTime_.PayoffBase_);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public void buildXml(XmlWriter xmlWriter)
        {
            if (serial_ec_.EventCheckNormal_ != null)
            {
                xmlWriter.WriteStartElement("eventCheckNormal");
            }
            else if (serial_ec_.EventCheckTime_ != null)
            {
                xmlWriter.WriteStartElement("eventCheckTime");
            }

            eitfvm_.buildXml(xmlWriter);
            eventDateVM_.buildXml(xmlWriter);
            functionEventVM_.buildXml(xmlWriter);
            payoffListVM_.buildXml(xmlWriter);

            xmlWriter.WriteEndElement();
            //xmlWriter.WriteWhitespace("\n");

        }

        #region Num_
        private int num_;
        public int Num_
        {
            get { return this.num_; }
            set
            {
                if (this.num_ != value)
                {
                    this.num_ = value;
                    this.NotifyPropertyChanged("Num_");
                }
            }
        }
        #endregion

        #region Symbol_
        private string symbol_;
        public string Symbol_
        {
            get { return this.symbol_; }
            set
            {
                if (this.symbol_ != value)
                {
                    this.symbol_ = value;
                    this.NotifyPropertyChanged("Symbol_");
                }
            }
        }
        #endregion

        #region Type_
        private string type_;
        public string Type_
        {
            get { return this.type_; }
            set
            {
                if (this.type_ != value)
                {
                    this.type_ = value;
                    this.NotifyPropertyChanged("Type_");
                }
            }
        }
        #endregion

        #region Name_
        private string name_;
        public string Name_
        {
            get { return this.name_; }
            set
            {
                if (this.name_ != value)
                {
                    this.name_ = value;
                    this.NotifyPropertyChanged("Name_");
                }
            }
        }
        #endregion

        #region Date_
        private DateTime date_;
        public DateTime Date_
        {
            get { return this.date_; }
            set
            {
                if (this.date_ != value)
                {
                    this.date_ = value;
                    this.NotifyPropertyChanged("Date_");
                }
            }
        }
        #endregion

        #region Expired_
        private bool expired_;
        public bool Expired_
        {
            get { return this.expired_; }
            set
            {
                if (this.expired_ != value)
                {
                    this.expired_ = value;
                    this.NotifyPropertyChanged("Expired_");
                }
            }
        }
        #endregion

        //-----------------------------------------------

        #region EITFVM_
        private EventIndexTransformationViewModel eitfvm_;
        public EventIndexTransformationViewModel EITFVM_
        {
            get { return this.eitfvm_; }
            set
            {
                if (this.eitfvm_ != value)
                {
                    this.eitfvm_ = value;
                    this.NotifyPropertyChanged("EITFVM_");
                }
            }
        }
        #endregion

        #region EventDateVM_
        private EventDateViewModel eventDateVM_;
        public EventDateViewModel EventDateVM_      
        {
            get { return this.eventDateVM_; }
            set
            {
                if (this.eventDateVM_ != value)
                {
                    this.eventDateVM_ = value;
                    this.NotifyPropertyChanged("EventDateVM_");
                }
            }
        }
        #endregion

        #region FunctionEventVM_
        private FunctionEventViewModel functionEventVM_;
        public FunctionEventViewModel FunctionEventVM_
        {
            get { return this.functionEventVM_; }
            set
            {
                if (this.functionEventVM_ != value)
                {
                    this.functionEventVM_ = value;
                    this.NotifyPropertyChanged("FunctionEventVM_");
                }
            }
        }
        #endregion

        #region PayoffListVM_
        private PayoffListViewModel payoffListVM_;
        public PayoffListViewModel PayoffListVM_
        {
            get { return this.payoffListVM_; }
            set
            {
                if (this.payoffListVM_ != value)
                {
                    this.payoffListVM_ = value;
                    this.NotifyPropertyChanged("PayoffListVM_");
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

        // -------------------------------------------------------

        public FpmlSerializedCSharp.EventCheck serial_ec_ { get; set; }

        public FpmlSerializedCSharp.EventCheckNormal serial_ecNormal_ { get; set; }

        public FpmlSerializedCSharp.EventCheckTime serial_ecTime_ { get; set; }


       
    }
}
