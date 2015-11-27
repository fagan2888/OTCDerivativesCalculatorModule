using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class General_TerminationEventDetail_creditViewModel : GeneralTerminationEventDetailViewModel
    {
    
        public General_TerminationEventDetail_creditViewModel() { }
        
    
        #region ReferenceEntity_
        private ObservableCollection<string> referenceEntity_;
        public ObservableCollection<string> ReferenceEntity_
        {
            get { return this.referenceEntity_; }
            set
            {
                if (this.referenceEntity_ != value)
                {
                    this.referenceEntity_ = value;
                    this.NotifyPropertyChanged("ReferenceEntity_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("generalTerminationEventDetail");
                xmlWriter.WriteElementString("type" , "general_TerminationEventDetail_credit");
                xmlWriter.WriteStartElement("general_TerminationEventDetail_credit");

            
                    //xmlWriter.WriteElementString("referenceEntity" , this.referenceEntity_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            //FpmlSerializedCSharp.GeneralTerminationEventDetail serial_GeneralTerminationEventDetail = serial_Class as FpmlSerializedCSharp.GeneralTerminationEventDetail;
            //FpmlSerializedCSharp.General_TerminationEventDetail_credit serial_General_TerminationEventDetail_credit = serial_GeneralTerminationEventDetail.General_TerminationEventDetail_credit_;
        
            //this.referenceEntityViewModel_ = new ObservableCollection<ReferenceEntityViewModel>();
            //foreach (var item in serial_General_TerminationEventDetail_credit.ReferenceEntity_)
            //{
            //    this.value_.Add(item.ValueStr);
            //}
            
            //this.view_ = new General_TerminationEventDetail_creditView();
            //this.view_.DataContext = this;
        }

        public override GeneralTerminationEventDetailViewModel Clone()
        {
            General_TerminationEventDetail_creditViewModel clone
                = new General_TerminationEventDetail_creditViewModel();

            clone.EventDate_ = this.EventDate_;

            return clone;
        }

        public override string description()
        {
            return "this is test General_TerminationEventDetail_creditViewModel ";
        }

        public override void bookingDetailEvent(MasterInformationViewModel masterInformationViewModel, EVENT_INFO_Table_DAO dao)
        {
            //dao.EVENT_AMOUNT_ = Convert.ToDouble(masterInformationViewModel.RemainNotional_)
            //                    * Convert.ToDouble( this.fixedRate_ ) * this.yearFraction_;

            dao.EVENT_AMOUNT_ = "60052222";

            dao.FIXING_UNDERLYINGS_ = "Entity_CDB";
            dao.FIXING_FLAG_ = "TRUE";
            //dao.OBSERVATION_END_DATE_ = dao.EVENT_DATE_;
            dao.EVENT_DESCRIPTION_ = this.description();
        }
    }
    
}

