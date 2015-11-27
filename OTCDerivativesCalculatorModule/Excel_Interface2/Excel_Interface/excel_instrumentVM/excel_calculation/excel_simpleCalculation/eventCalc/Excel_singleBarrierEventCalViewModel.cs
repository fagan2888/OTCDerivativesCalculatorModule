using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_singleBarrierEventCalViewModel : Excel_eventCalcInfoViewModel
    {
        public Excel_singleBarrierEventCalViewModel() 
        {
            this.Excel_type_ = "excel_singleBarrierEventCal";
        }

        #region LowerTrigger_
        private string lowerTrigger_;
        public string LowerTrigger_
        {
            get { return this.lowerTrigger_; }
            set
            {
                if (this.lowerTrigger_ != value)
                {
                    this.lowerTrigger_ = value;
                    this.NotifyPropertyChanged("LowerRng_");
                }
            }
        }
        #endregion

        #region UpperTrigger_
        private string upperTrigger_;
        public string UpperTrigger_
        {
            get { return this.upperTrigger_; }
            set
            {
                if (this.upperTrigger_ != value)
                {
                    this.upperTrigger_ = value;
                    this.NotifyPropertyChanged("UpperRng_");
                }
            }
        }
        #endregion

        #region Excel_underlyingCalcIDViewModel_
        private Excel_underlyingCalcIDViewModel excel_underlyingCalcIDViewModel_;
        public Excel_underlyingCalcIDViewModel Excel_underlyingCalcIDViewModel_
        {
            get { return this.excel_underlyingCalcIDViewModel_; }
            set
            {
                if (this.excel_underlyingCalcIDViewModel_ != value)
                {
                    this.excel_underlyingCalcIDViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_underlyingCalcID_");
                }
            }
        }
        #endregion

        #region ObservationStartDate_
        private DateTime observationStartDate_;
        public DateTime ObservationStartDate_
        {
            get { return this.observationStartDate_; }
            set
            {
                if (this.observationStartDate_ != value)
                {
                    this.observationStartDate_ = value;
                    this.NotifyPropertyChanged("ObservationStartDate_");
                }
            }
        }
        #endregion

        #region ObservationEndDate_
        private DateTime observationEndDate_;
        public DateTime ObservationEndDate_
        {
            get { return this.observationEndDate_; }
            set
            {
                if (this.observationEndDate_ != value)
                {
                    this.observationEndDate_ = value;
                    this.NotifyPropertyChanged("ObservationEndDate_");
                }
            }
        }
        #endregion

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_eventCalcInfo");
                xmlWriter.WriteElementString("excel_type" , "excel_singleBarrierEventCal");
                xmlWriter.WriteStartElement("excel_singleBarrierEventCal");
                    xmlWriter.WriteElementString("lowerTrigger", this.lowerTrigger_);
                    xmlWriter.WriteElementString("upperTrigger", this.upperTrigger_);

                    excel_underlyingCalcIDViewModel_.buildXml(xmlWriter);

                    xmlWriter.WriteElementString("observationStartDate",StringConverter.xmlDateTimeToDateString(this.observationStartDate_));
                    xmlWriter.WriteElementString("observationEndDate", StringConverter.xmlDateTimeToDateString(this.observationEndDate_));

                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }

        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_eventCalcInfo serial_Excel_eventCalcInfo = serial_Class as FpmlSerializedCSharp.Excel_eventCalcInfo;
            FpmlSerializedCSharp.Excel_singleBarrierEventCal serial_Excel_singleBarrierEventCal = serial_Excel_eventCalcInfo.Excel_singleBarrierEventCal_;

            this.lowerTrigger_ = serial_Excel_singleBarrierEventCal.LowerTrigger_.ValueStr;

            this.upperTrigger_ = serial_Excel_singleBarrierEventCal.UpperTrigger_.ValueStr;

            FpmlSerializedCSharp.Excel_underlyingCalcID serial_excel_underlyingCalcID = serial_Excel_singleBarrierEventCal.Excel_underlyingCalcID_;
            string excel_underlyingCalcIDtype = serial_excel_underlyingCalcID.Excel_type_.ValueStr;
            this.excel_underlyingCalcIDViewModel_ = Excel_underlyingCalcIDViewModel.CreateExcel_underlyingCalcID(excel_underlyingCalcIDtype);
            this.excel_underlyingCalcIDViewModel_.setFromSerial(serial_excel_underlyingCalcID);

            this.observationStartDate_ = StringConverter.xmlDateToDateTime(serial_Excel_singleBarrierEventCal.ObservationStartDate_.ValueStr);
            this.observationEndDate_ = StringConverter.xmlDateToDateTime(serial_Excel_singleBarrierEventCal.ObservationEndDate_.ValueStr);
        }

        //public override EventCalculationInfoViewModel eventCalcInfoVM()
        //{
        //    EventCalculationInfoViewModel ecivm = new EventCalculationInfoViewModel();

        //    LowerBarrierEventCalViewModel lbecvm = new LowerBarrierEventCalViewModel();

        //    ObservableCollection<string> lowerTriggerList = new ObservableCollection<string>();

        //    lowerTriggerList.Add(this.lowerTrigger_);

        //    lbecvm.LowerTrigger_ = lowerTriggerList;

        //    //lbecvm.DateInformationViewModel_ = new DailyIntervalViewModel();

        //    ecivm.EventCalculationViewModel_.Add(lbecvm);

        //    return ecivm;

        //}

        public override void setUnderlying(Excel_underlyingCalcInfoViewModel excel_under)
        {
            this.excel_underlyingCalcInfoViewModel_ = excel_under;

            this.excel_underlyingCalcIDViewModel_.setUnderlying(excel_under);
        }

        public override Control view()
        {
            System.Windows.Controls.Control v = new Excel_singleBarrierEventCalView();

            v.DataContext = this;

            return v;
        }

        public override void defaultSetting()
        {
            Excel_maximumUnderlyingCalcIDViewModel e_mucidvm = new Excel_maximumUnderlyingCalcIDViewModel();
            e_mucidvm.AverageDays_ = "1";

            this.excel_underlyingCalcIDViewModel_ = e_mucidvm;
        }

        public override void descriptionUpdate()
        {
            this.description_ = "singleBarrier Test";
        }
    }
    
}

