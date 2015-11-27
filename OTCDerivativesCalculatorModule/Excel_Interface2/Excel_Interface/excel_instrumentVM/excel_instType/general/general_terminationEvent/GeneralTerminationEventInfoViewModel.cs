using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class GeneralTerminationEventInfoViewModel : IXmlData
    {
        //#region View_
        //protected Control view_;
        //public Control View_
        //{
        //    get { return this.view_; }
        //    set
        //    {
        //        if (this.view_ != value)
        //        {
        //            this.view_ = value;
        //            this.NotifyPropertyChanged("View_");
        //        }
        //    }
        //}
        //#endregion

        #region Event

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region EventDate_
        private string eventDate_;
        public string EventDate_
        {
            get { return this.eventDate_; }
            set
            {
                if (this.eventDate_ != value)
                {
                    this.eventDate_ = value;
                    this.NotifyPropertyChanged("EventDate_");
                }
            }
        }
        #endregion

        #region DetailTerminationType_
        private string detailTerminationType_;
        public string DetailTerminationType_
        {
            get { return this.detailTerminationType_; }
            set
            {
                if (this.detailTerminationType_ != value)
                {
                    this.detailTerminationType_ = value;
                    this.NotifyPropertyChanged("DetailTerminationType_");
                }
            }
        }
        #endregion

        #region GeneralTerminationEventVMList_
        private ObservableCollection<GeneralTerminationEventViewModel> generalTerminationEventVMList_;
        public ObservableCollection<GeneralTerminationEventViewModel> GeneralTerminationEventVMList_
        {
            get { return this.generalTerminationEventVMList_; }
            set
            {
                if (this.generalTerminationEventVMList_ != value)
                {
                    this.generalTerminationEventVMList_ = value;
                    this.NotifyPropertyChanged("GeneralTerminationEventVMList_");
                }
            }
        }
        #endregion

        public GeneralTerminationEventInfoViewModel()
        {
            this.generalTerminationEventVMList_ = new ObservableCollection<GeneralTerminationEventViewModel>();

            //this.view_ = new GeneralTerminationEventInfoView();
            //this.view_.DataContext = this;
        }

        public void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("generalTerminationEvent");
            xmlWriter.WriteElementString("detailTerminationType", this.detailTerminationType_);

            xmlWriter.WriteElementString("eventDate", this.eventDate_);

            foreach (var item in this.generalTerminationEventVMList_)
            {
                item.buildXml(xmlWriter);
            }

            xmlWriter.WriteEndElement();
        }

        public void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }

        public void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            //FpmlSerializedCSharp.GeneralTerminationEvent serial_GeneralTerminationEvent = serial_Class as FpmlSerializedCSharp.GeneralTerminationEvent;

            //this.detailTerminationType_ = serial_GeneralTerminationEvent.DetailTerminationType_.ValueStr;

            //this.eventDate_ = serial_GeneralTerminationEvent.EventDate_.ValueStr;

            //FpmlSerializedCSharp.GeneralTerminationEventDetail serial_generalTerminationEventDetail = serial_GeneralTerminationEvent.GeneralTerminationEventDetail_;
            //string generalTerminationEventDetailtype = serial_generalTerminationEventDetail.Type_.ValueStr;
            //this.generalTerminationEventDetailViewModel_ = GeneralTerminationEventDetailViewModel.CreateGeneralTerminationEventDetail(generalTerminationEventDetailtype);
            //this.generalTerminationEventDetailViewModel_.setFromSerial(serial_generalTerminationEventDetail);

            //this.view_ = new GeneralTerminationEventView();
            //this.view_.DataContext = this;
        }

        public void bookingEvent(MasterInformationViewModel masterInformationViewModel)
        {
            foreach (var item in this.generalTerminationEventVMList_)
            {
                item.bookingEvent(masterInformationViewModel);
            }   
        }

        public System.Windows.Controls.Control view()
        {
            Control v = new GeneralTerminationEventInfoView();

            v.DataContext = this;

            return v;
        }

    }
}
