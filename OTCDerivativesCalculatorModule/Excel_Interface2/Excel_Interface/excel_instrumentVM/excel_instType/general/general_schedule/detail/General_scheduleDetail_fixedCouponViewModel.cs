using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class General_scheduleDetail_fixedCouponViewModel : GeneralScheduleDeatilViewModel
    {
        public General_scheduleDetail_fixedCouponViewModel() { }
    
        #region FixedRate_
        private string fixedRate_;
        public string FixedRate_
        {
            get { return this.fixedRate_; }
            set
            {
                if (this.fixedRate_ != value)
                {
                    this.fixedRate_ = value;
                    this.NotifyPropertyChanged("FixedRate_");
                }
            }
        }
        #endregion
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("generalScheduleDeatil");
                xmlWriter.WriteElementString("type" , "general_scheduleDetail_fixedCoupon");
                xmlWriter.WriteStartElement("general_scheduleDetail_fixedCoupon");
                    xmlWriter.WriteElementString("fixedRate" , this.fixedRate_);
                    
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
            //FpmlSerializedCSharp.General_scheduleDetail_fixedCoupon serial_General_scheduleDetail_fixedCoupon = serial_GeneralScheduleDeatil.General_scheduleDetail_fixedCoupon_;
        
            //this.fixedRate_ = serial_General_scheduleDetail_fixedCoupon.FixedRate_.ValueStr;
            
            //this.view_ = new General_scheduleDetail_fixedCouponView();
            //this.view_.DataContext = this;
        }

        public override GeneralScheduleDeatilViewModel Clone()
        {
            General_scheduleDetail_fixedCouponViewModel clone
                = new General_scheduleDetail_fixedCouponViewModel();

            clone.fixedRate_ = this.fixedRate_;
            clone.EventDate_ = this.EventDate_;

            return clone;
        }

        public override string description()
        {
            return "this is test General_scheduleDetail_fixedCouponViewModel";
        }


        public override void bookingDetailEvent(MasterInformationViewModel masterInformationViewModel, 
                                                EVENT_INFO_Table_DAO dao)
        {
            //dao.EVENT_AMOUNT_ = Convert.ToDouble(masterInformationViewModel.RemainNotional_)
            //                    * Convert.ToDouble( this.fixedRate_ ) * this.yearFraction_;

            dao.EVENT_AMOUNT_ = "97854673";

            dao.FIXING_UNDERLYINGS_ = "";
            dao.FIXING_FLAG_ = "TRUE";
            //dao.OBSERVATION_END_DATE_ = dao.EVENT_DATE_;
            dao.EVENT_DESCRIPTION_ = this.description();
        }
    }
    
}

