using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_singleRangeEventCalViewModel : Excel_eventCalcInfoViewModel
    {
        public Excel_singleRangeEventCalViewModel() 
        {
            this.Excel_type_ = "excel_singleRangeEventCal";
        }
        
        // 화면에서 binding 될거임

        #region LowerRng_
        private string lowerRng_;
        public string LowerRng_
        {
            get { return this.lowerRng_; }
            set
            {
                if (this.lowerRng_ != value)
                {
                    this.lowerRng_ = value;
                    this.NotifyPropertyChanged("LowerRng_");
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

        #region UpperRng_
        private string upperRng_;
        public string UpperRng_
        {
            get { return this.upperRng_; }
            set
            {
                if (this.upperRng_ != value)
                {
                    this.upperRng_ = value;
                    this.NotifyPropertyChanged("UpperRng_");
                }
            }
        }
        #endregion

        #region Interface

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_eventCalcInfo");
                xmlWriter.WriteElementString("excel_type" , "excel_singleRangeEventCal");
                xmlWriter.WriteStartElement("excel_singleRangeEventCal");

                    xmlWriter.WriteElementString("lowerRng" , this.lowerRng_);
                    xmlWriter.WriteElementString("upperRng" , this.upperRng_);
            
                    excel_underlyingCalcIDViewModel_.buildXml(xmlWriter);

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
            FpmlSerializedCSharp.Excel_singleRangeEventCal serial_Excel_singleRangeEventCal = serial_Excel_eventCalcInfo.Excel_singleRangeEventCal_;

            this.lowerRng_ = serial_Excel_singleRangeEventCal.LowerRng_.ValueStr;

            this.upperRng_ = serial_Excel_singleRangeEventCal.UpperRng_.ValueStr;

            FpmlSerializedCSharp.Excel_underlyingCalcID serial_excel_underlyingCalcID = serial_Excel_singleRangeEventCal.Excel_underlyingCalcID_;
            string excel_underlyingCalcIDtype = serial_excel_underlyingCalcID.Excel_type_.ValueStr;
            this.excel_underlyingCalcIDViewModel_ = Excel_underlyingCalcIDViewModel.CreateExcel_underlyingCalcID(excel_underlyingCalcIDtype);
            this.excel_underlyingCalcIDViewModel_.setFromSerial(serial_excel_underlyingCalcID);

        }

        public override void setUnderlying(Excel_underlyingCalcInfoViewModel excel_under)
        {
            this.excel_underlyingCalcInfoViewModel_ = excel_under;

            this.excel_underlyingCalcIDViewModel_.setUnderlying(excel_under);
        }

        #endregion

        //public override EventCalculationInfoViewModel eventCalcInfoVM()
        //{
        //    EventCalculationInfoViewModel ecivm = new EventCalculationInfoViewModel();

        //    SimpleRangeEventCalViewModel srecvm = new SimpleRangeEventCalViewModel();

        //    Range1DViewModel r1Dvm = new Range1DViewModel();

        //    r1Dvm.LowerBound_ = (Convert.ToDouble(this.lowerRng_) / 100).ToString();
        //    r1Dvm.LowerBoundEquality_ = "true";
        //    r1Dvm.UpperBoundEquality_ = "true";
        //    r1Dvm.UpperBound_ = (Convert.ToDouble(this.upperRng_) / 100).ToString();

        //    srecvm.Range1DViewModel_ = r1Dvm;

        //    srecvm.ReferenceCalculationInfoViewModel_ = this.excel_underlyingCalcIDViewModel_.referenceCalcInfoVM();

        //    foreach (var item in srecvm.ReferenceCalculationInfoViewModel_.ReferenceCalculationViewModel_)
        //    {
        //        FixedFixingDateInfoViewModel ffdivm = new FixedFixingDateInfoViewModel();
        //        ffdivm.Date_ = this.referenceFixingDate_.ToString("yyyy-MM-dd");

        //        item.FixingDateInfoViewModel_ = ffdivm;
        //    }

        //    ecivm.EventCalculationViewModel_.Add(srecvm);

        //    return ecivm;
        //}

        public override Control view()
        {
            System.Windows.Controls.Control v = new Excel_singleRangeEventCalView();

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
            this.description_ = "singleRange Test";
        }
    }
    
}

