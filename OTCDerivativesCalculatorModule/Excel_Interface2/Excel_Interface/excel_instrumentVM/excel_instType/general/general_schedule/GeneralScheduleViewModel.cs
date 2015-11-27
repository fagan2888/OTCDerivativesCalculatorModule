using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class GeneralScheduleViewModel : IXmlData
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
    
        public GeneralScheduleViewModel() 
        { 
        
        }
    
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
        
        #region DetailScheduleType_
        private string detailScheduleType_;
        public string DetailScheduleType_
        {
            get { return this.detailScheduleType_; }
            set
            {
                if (this.detailScheduleType_ != value)
                {
                    this.detailScheduleType_ = value;
                    this.NotifyPropertyChanged("DetailScheduleType_");
                }
            }
        }
        #endregion
        
        #region GeneralScheduleDeatilViewModel_
        private GeneralScheduleDeatilViewModel generalScheduleDeatilViewModel_;
        public GeneralScheduleDeatilViewModel GeneralScheduleDeatilViewModel_
        {
            get { return this.generalScheduleDeatilViewModel_; }
            set
            {
                if (this.generalScheduleDeatilViewModel_ != value)
                {
                    this.generalScheduleDeatilViewModel_ = value;
                    this.NotifyPropertyChanged("GeneralScheduleDeatilViewModel_");
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

        #region Currency_
        private string currency_;
        public string Currency_
        {
            get { return this.currency_; }
            set
            {
                if (this.currency_ != value)
                {
                    this.currency_ = value;
                    this.NotifyPropertyChanged("Currency_");
                }
            }
        }
        #endregion

        public void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("generalSchedule");
                xmlWriter.WriteElementString("eventDate" , this.eventDate_);
                    
                xmlWriter.WriteElementString("detailScheduleType" , this.detailScheduleType_);
                    
                generalScheduleDeatilViewModel_.buildXml(xmlWriter);
                    
            xmlWriter.WriteEndElement();
        }
        
        public void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            //FpmlSerializedCSharp.GeneralSchedule serial_GeneralSchedule = serial_Class as FpmlSerializedCSharp.GeneralSchedule;
        
            //this.eventDate_ = serial_GeneralSchedule.EventDate_.ValueStr;
            
            //this.detailScheduleType_ = serial_GeneralSchedule.DetailScheduleType_.ValueStr;
            
            //FpmlSerializedCSharp.GeneralScheduleDeatil serial_generalScheduleDeatil = serial_GeneralSchedule.GeneralScheduleDeatil_;
            //string generalScheduleDeatiltype = serial_generalScheduleDeatil.Type_.ValueStr;
            //this.generalScheduleDeatilViewModel_ = GeneralScheduleDeatilViewModel.CreateGeneralScheduleDeatil(generalScheduleDeatiltype);
            //this.generalScheduleDeatilViewModel_.setFromSerial(serial_generalScheduleDeatil);
            
            //this.view_ = new GeneralScheduleView();
            //this.view_.DataContext = this;
        }

        public void descriptionUpdate()
        {
            this.description_ = this.generalScheduleDeatilViewModel_.description();
        }

        public static GeneralScheduleViewModel Create(string lastEventDate)
        {
            GeneralScheduleViewModel gsvm = new GeneralScheduleViewModel();

            gsvm.EventDate_ = lastEventDate + 3;

            gsvm.generalScheduleDeatilViewModel_
                = GeneralScheduleDeatilViewModel.CreateGeneralScheduleDeatil("general_scheduleDetail_fixedCoupon");

            return gsvm;
        }

        public void bookingEvent(MasterInformationViewModel masterInformationViewModel)
        {
            EVENT_INFO_Table_DAO dao = new EVENT_INFO_Table_DAO();

            dao.EVENT_DATE_ = this.eventDate_;
            dao.EVENT_TYPE_ = "Fixed";
            dao.EVENT_SUBTYPE_ = detailScheduleType_;
            dao.EVENT_DESCRIPTION_ = this.description_;
            dao.EVENT_NAME_ = "Coupon";
            dao.CURRENCY_ = this.currency_;
            dao.EVENT_AMOUNT_ = generalScheduleDeatilViewModel_.InitialFixingAmount_;
            dao.FIXING_UNDERLYINGS_ = generalScheduleDeatilViewModel_.FixingUnderlying_;
            dao.FIXING_FLAG_ = generalScheduleDeatilViewModel_.InitialFixingFlag_;
            ////dao.OBSERVATION_END_DATE_ = generalScheduleDeatilViewModel_.ObservationEndDate_;
            dao.ITEM_CODE_ = masterInformationViewModel.Item_code_;
            dao.ITEM_TYPE_ = masterInformationViewModel.Booking_type_;
            dao.ITEM_NAME_ = masterInformationViewModel.Item_name_;
            dao.REMAIN_NOTIONAL_ = masterInformationViewModel.Remain_notional_;

            dao.insert(DataBaseConnectManager.ConnectionFactory("myDB"));

        }
    }
    
}

