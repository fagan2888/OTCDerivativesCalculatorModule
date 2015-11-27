using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class GeneralTerminationEventViewModel : IXmlData
    {
        #region Event
        public event PropertyChangedEventHandler PropertyChanged;
        
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
        
        public GeneralTerminationEventViewModel() 
        {
            
        }

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
        
        #region GeneralTerminationEventDetailViewModel_
        private GeneralTerminationEventDetailViewModel generalTerminationEventDetailViewModel_;
        public GeneralTerminationEventDetailViewModel GeneralTerminationEventDetailViewModel_
        {
            get { return this.generalTerminationEventDetailViewModel_; }
            set
            {
                if (this.generalTerminationEventDetailViewModel_ != value)
                {
                    this.generalTerminationEventDetailViewModel_ = value;
                    this.NotifyPropertyChanged("GeneralTerminationEventDetailViewModel_");
                }
            }
        }
        #endregion

        #region Description_
        private string description_;
        public string Description_
        {
            get { return this.description_; }
            set
            {
                if (this.description_ != value)
                {
                    this.description_ = value;
                    this.NotifyPropertyChanged("Description_");
                }
            }
        }
        #endregion

        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
                xmlWriter.WriteStartElement("generalTerminationEvent");
                    xmlWriter.WriteElementString("type" , this.detailTerminationType_);
                    
                    generalTerminationEventDetailViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            //FpmlSerializedCSharp.GeneralTerminationEvent serial_GeneralTerminationEvent = serial_Class as FpmlSerializedCSharp.GeneralTerminationEvent;
        
            //this.type_ = serial_GeneralTerminationEvent.Type_.ValueStr;
            
            //FpmlSerializedCSharp.GeneralTerminationEventDetail serial_generalTerminationEventDetail = serial_GeneralTerminationEvent.GeneralTerminationEventDetail_;
            //string generalTerminationEventDetailtype = serial_generalTerminationEventDetail.Type_.ValueStr;
            //this.generalTerminationEventDetailViewModel_ = GeneralTerminationEventDetailViewModel.CreateGeneralTerminationEventDetail(generalTerminationEventDetailtype);
            //this.generalTerminationEventDetailViewModel_.setFromSerial(serial_generalTerminationEventDetail);
            
            //this.view_ = new GeneralTerminationEventView();
            //this.view_.DataContext = this;
        }

        public void descriptionUpdate()
        {
            this.description_ = this.generalTerminationEventDetailViewModel_.description();
        }

        public void bookingEvent(MasterInformationViewModel masterInformationViewModel)
        {
            EVENT_INFO_Table_DAO dao = new EVENT_INFO_Table_DAO();

            dao.EVENT_DATE_ = this.eventDate_;
            dao.EVENT_TYPE_ = "Termination";
            dao.EVENT_SUBTYPE_ = this.detailTerminationType_;
            dao.EVENT_DESCRIPTION_ = this.description_;
            dao.EVENT_NAME_ = "Early Redemption";
            dao.CURRENCY_ = "";

            generalTerminationEventDetailViewModel_.bookingDetailEvent(masterInformationViewModel, dao);

            //dao.EVENT_AMOUNT_ = generalTerminationEventDetailViewModel_.InitialFixingAmount_;
            //dao.FIXING_UNDERLYINGS_ = generalTerminationEventDetailViewModel_.FixingUnderlying_;
            //dao.FIXING_FLAG_ = generalTerminationEventDetailViewModel_.InitialFixingFlag_;
            //dao.OBSERVATION_END_DATE_ = generalTerminationEventDetailViewModel_.ObservationEndDate_;

            dao.ITEM_CODE_ = masterInformationViewModel.Item_code_;
            dao.ITEM_TYPE_ = masterInformationViewModel.Booking_type_;
            dao.ITEM_NAME_ = masterInformationViewModel.Item_name_;
            dao.REMAIN_NOTIONAL_ = masterInformationViewModel.Remain_notional_;

            dao.insert(DataBaseConnectManager.ConnectionFactory("myDB"));
        }
    }
    
}

