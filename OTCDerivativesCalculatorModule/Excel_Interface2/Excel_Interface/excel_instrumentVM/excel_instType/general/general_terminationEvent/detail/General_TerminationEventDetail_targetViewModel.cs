using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class General_TerminationEventDetail_targetViewModel : GeneralTerminationEventDetailViewModel
    {
        
        public General_TerminationEventDetail_targetViewModel() { }
        
        #region Target_
        private string target_;
        public string Target_
        {
            get { return this.target_; }
            set
            {
                if (this.target_ != value)
                {
                    this.target_ = value;
                    this.NotifyPropertyChanged("Target_");
                }
            }
        }
        #endregion
        
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("generalTerminationEventDetail");
                xmlWriter.WriteElementString("type" , "general_TerminationEventDetail_target");
                xmlWriter.WriteStartElement("general_TerminationEventDetail_target");
                    xmlWriter.WriteElementString("target" , this.target_);
                    
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
            //FpmlSerializedCSharp.General_TerminationEventDetail_target serial_General_TerminationEventDetail_target = serial_GeneralTerminationEventDetail.General_TerminationEventDetail_target_;
        
            //this.target_ = serial_General_TerminationEventDetail_target.Target_.ValueStr;
            
            //this.view_ = new General_TerminationEventDetail_targetView();
            //this.view_.DataContext = this;
        }

        public override GeneralTerminationEventDetailViewModel Clone()
        {
            General_TerminationEventDetail_targetViewModel clone
                = new General_TerminationEventDetail_targetViewModel();

            clone.EventDate_ = this.EventDate_;

            return clone;
        }

        public override string description()
        {
            return "this is test General_TerminationEventDetail_targetViewModel ";
        }

        public override void bookingDetailEvent(MasterInformationViewModel masterInformationViewModel, EVENT_INFO_Table_DAO dao)
        {
            //dao.EVENT_AMOUNT_ = Convert.ToDouble(masterInformationViewModel.RemainNotional_)
            //                    * Convert.ToDouble( this.fixedRate_ ) * this.yearFraction_;

            dao.EVENT_AMOUNT_ = "554443";

            dao.FIXING_UNDERLYINGS_ = "Target Underlying";
            dao.FIXING_FLAG_ = "TRUE";
            //dao.OBSERVATION_END_DATE_ = dao.EVENT_DATE_;
            dao.EVENT_DESCRIPTION_ = this.description();
        }
    }
    
}

