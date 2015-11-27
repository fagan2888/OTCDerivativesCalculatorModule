using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class General_scheduleDetail_fixedAmountViewModel : GeneralScheduleDeatilViewModel
    {
    
        public General_scheduleDetail_fixedAmountViewModel() { }
        
        #region FixedAmount_
        private string fixedAmount_;
        public string FixedAmount_
        {
            get { return this.fixedAmount_; }
            set
            {
                if (this.fixedAmount_ != value)
                {
                    this.fixedAmount_ = value;
                    this.NotifyPropertyChanged("FixedAmount_");
                }
            }
        }
        #endregion
        
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("generalScheduleDeatil");
                xmlWriter.WriteElementString("type" , "general_scheduleDetail_fixedAmount");
                xmlWriter.WriteStartElement("general_scheduleDetail_fixedAmount");
                    xmlWriter.WriteElementString("fixedAmount" , this.fixedAmount_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            //FpmlSerializedCSharp.GeneralScheduleDeatil serial_GeneralScheduleDeatil = serial_Class as FpmlSerializedCSharp.GeneralScheduleDeatil;
            //FpmlSerializedCSharp.General_scheduleDetail_fixedAmount serial_General_scheduleDetail_fixedAmount = serial_GeneralScheduleDeatil.General_scheduleDetail_fixedAmount_;
        
            //this.fixedAmount_ = serial_General_scheduleDetail_fixedAmount.FixedAmount_.ValueStr;
            
            //this.view_ = new General_scheduleDetail_fixedAmountView();
            //this.view_.DataContext = this;
        }

        public override GeneralScheduleDeatilViewModel Clone()
        {
            General_scheduleDetail_fixedAmountViewModel clone
                = new General_scheduleDetail_fixedAmountViewModel();

            clone.fixedAmount_ = this.fixedAmount_;
            clone.EventDate_ = this.EventDate_;

            return clone;
        }

        public override string description()
        {
            return "this is test General_scheduleDetail_fixedAmountViewModel ";
        }

        public override void bookingDetailEvent(MasterInformationViewModel masterInformationViewModel, EVENT_INFO_Table_DAO dao)
        {
            //dao.EVENT_AMOUNT_ = Convert.ToDouble(masterInformationViewModel.RemainNotional_)
            //                    * Convert.ToDouble( this.fixedRate_ ) * this.yearFraction_;

            dao.EVENT_AMOUNT_ = "2200000";

            dao.FIXING_UNDERLYINGS_ = "";
            dao.FIXING_FLAG_ = "TRUE";
            ////dao.OBSERVATION_END_DATE_ = dao.EVENT_DATE_;
            dao.EVENT_DESCRIPTION_ = this.description();

        }
    }
    
}

