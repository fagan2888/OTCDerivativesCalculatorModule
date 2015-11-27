using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_stepDownKI_subScheduleViewModel : IXmlData
    {
    
        //public enum UnderCalcTypeEnum 
        //{
        //    Maximum , 
        //    Minimum , 
        //    Average
        //};

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
    
        public Excel_stepDownKI_subScheduleViewModel() 
        {
        
        }
    
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
        
        #region EventDate_
        private DateTime eventDate_;
        public DateTime EventDate_
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
        
        #region Trigger_
        private string trigger_;
        public string Trigger_
        {
            get { return this.trigger_; }
            set
            {
                if (this.trigger_ != value)
                {
                    this.trigger_ = value;
                    this.NotifyPropertyChanged("Trigger_");
                }
            }
        }
        #endregion
        
        #region Coupon_
        private string coupon_;
        public string Coupon_
        {
            get { return this.coupon_; }
            set
            {
                if (this.coupon_ != value)
                {
                    this.coupon_ = value;
                    this.NotifyPropertyChanged("Coupon_");
                }
            }
        }
        #endregion

        #region UnderCalcType_
        private string underCalcType_;
        public string UnderCalcType_
        {
            get { return this.underCalcType_; }
            set
            {
                if (this.underCalcType_ != value)
                {
                    this.underCalcType_ = value;
                    this.NotifyPropertyChanged("UnderCalcType_");
                }
            }
        }
        #endregion

        #region AverageDays_
        private string averageDays_;
        public string AverageDays_
        {
            get { return this.averageDays_; }
            set
            {
                if (this.averageDays_ != value)
                {
                    this.averageDays_ = value;
                    this.NotifyPropertyChanged("AverageDays_");
                }
            }
        }
        #endregion

        public void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_stepDownKI_subSchedule");
            
                xmlWriter.WriteElementString("excel_type" , this.type_);
                xmlWriter.WriteElementString("eventDate" , this.eventDate_.ToString("yyyy-MM-dd"));
                xmlWriter.WriteElementString("trigger" , this.trigger_);
                xmlWriter.WriteElementString("coupon" , this.coupon_);
                xmlWriter.WriteElementString("underCalcType", this.underCalcType_);
                xmlWriter.WriteElementString("averageDays", this.averageDays_);

            xmlWriter.WriteEndElement();
        }
        
        public void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_stepDownKI_subSchedule serial_Excel_stepDownKI_subSchedule = serial_Class as FpmlSerializedCSharp.Excel_stepDownKI_subSchedule;

            this.type_ = serial_Excel_stepDownKI_subSchedule.Excel_type_.ValueStr;

            this.eventDate_ = DateTime.ParseExact(serial_Excel_stepDownKI_subSchedule.EventDate_.ValueStr,StringFormat.XmlDateFormat_,null);

            this.trigger_ = serial_Excel_stepDownKI_subSchedule.Trigger_.ValueStr;

            this.coupon_ = serial_Excel_stepDownKI_subSchedule.Coupon_.ValueStr;

            this.underCalcType_ = serial_Excel_stepDownKI_subSchedule.UnderCalcType_.ValueStr;
            
            this.averageDays_ = serial_Excel_stepDownKI_subSchedule.AverageDays_.ValueStr;

        }

        public static Excel_underlyingCalcIDViewModel CreateExcel_underlyingCalcID(Excel_stepDownKI_subScheduleViewModel e_s_svm)
        {
            string typeStr = e_s_svm.UnderCalcType_;

            if (typeStr.ToUpper() == "MAXIMUM" || typeStr.ToUpper() == "MAX")
            {
                Excel_maximumUnderlyingCalcIDViewModel e_mucidvm = new Excel_maximumUnderlyingCalcIDViewModel();

                e_mucidvm.EventDate_ = e_s_svm.EventDate_;
                e_mucidvm.AverageDays_ = e_s_svm.AverageDays_;

                return e_mucidvm;
            }
            else if (typeStr.ToUpper() == "MINIMUM" || typeStr.ToUpper() == "MIN")
            {
                Excel_minimumUnderlyingCalcIDViewModel e_mucidvm = new Excel_minimumUnderlyingCalcIDViewModel();

                e_mucidvm.EventDate_ = e_s_svm.EventDate_;
                e_mucidvm.AverageDays_ = e_s_svm.AverageDays_;

                return e_mucidvm;

            }
            else if (typeStr.ToUpper() == "AVERAGE" || typeStr.ToUpper() == "AVER")
            {
                Excel_averageUnderlyingCalcIDViewModel e_mucidvm = new Excel_averageUnderlyingCalcIDViewModel();

                e_mucidvm.EventDate_ = e_s_svm.EventDate_;
                //e_mucidvm.AverageDays_ = e_s_svm.AverageDays_;

                return e_mucidvm;
            }
            //else if (typeStr == "excel_orderUnderlyingCalcID")
            //{
            //    return new Excel_orderUnderlyingCalcIDViewModel();
            //}
            else
            {
                throw new NotImplementedException();
            }
        }



    }
    
}

