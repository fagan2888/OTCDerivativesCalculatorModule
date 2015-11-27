using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_simpleKiEventCalcViewModel : Excel_kiEventCalculationViewModel
    {
        #region AttributeValue_
        protected string attributeValue_;
        public string AttributeValue_
        {
            get { return this.attributeValue_; }
            set
            {
                if (this.attributeValue_ != value)
                {
                    this.attributeValue_ = value;
                    this.NotifyPropertyChanged("AttributeValue_");
                }
            }
        }
        #endregion

        public Excel_simpleKiEventCalcViewModel() 
        {
            this.Excel_Type_ = "excel_simpleKiEventCalc";
        }
    
        #region Excel_eventCalcInfoViewModel_
        private Excel_eventCalcInfoViewModel excel_eventCalcInfoViewModel_;
        public Excel_eventCalcInfoViewModel Excel_eventCalcInfoViewModel_
        {
            get { return this.excel_eventCalcInfoViewModel_; }
            set
            {
                if (this.excel_eventCalcInfoViewModel_ != value)
                {
                    this.excel_eventCalcInfoViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_eventCalcInfoViewModel_");
                }
            }
        }
        #endregion

        #region Excel_occReturnCalcInfoViewModel_
        private Excel_occReturnCalcInfoViewModel excel_occReturnCalcInfoViewModel_;
        public Excel_occReturnCalcInfoViewModel Excel_occReturnCalcInfoViewModel_
        {
            get { return this.excel_occReturnCalcInfoViewModel_; }
            set
            {
                if (this.excel_occReturnCalcInfoViewModel_ != value)
                {
                    this.excel_occReturnCalcInfoViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_occReturnCalcInfoViewModel_");
                }
            }
        }
        #endregion

        #region Excel_noOccReturnCalcInfoViewModel_
        private Excel_noOccReturnCalcInfoViewModel excel_noOccReturnCalcInfoViewModel_;
        public Excel_noOccReturnCalcInfoViewModel Excel_noOccReturnCalcInfoViewModel_
        {
            get { return this.excel_noOccReturnCalcInfoViewModel_; }
            set
            {
                if (this.excel_noOccReturnCalcInfoViewModel_ != value)
                {
                    this.excel_noOccReturnCalcInfoViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_noOccReturnCalcInfoViewModel_");
                }
            }
        }
        #endregion

        //
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_kiEventCalculation");
                xmlWriter.WriteElementString("excel_type", "excel_simpleKiEventCalc");
                xmlWriter.WriteStartElement("excel_simpleKiEventCalc");

                    base.buildXml(xmlWriter);

                    excel_eventCalcInfoViewModel_.buildXml(xmlWriter);
                    excel_occReturnCalcInfoViewModel_.buildXml(xmlWriter);
                    excel_noOccReturnCalcInfoViewModel_.buildXml(xmlWriter);

                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_kiEventCalculation serial_Excel_kiEventCalculation = serial_Class as FpmlSerializedCSharp.Excel_kiEventCalculation;
            FpmlSerializedCSharp.Excel_simpleKiEventCalc serial_Excel_simpleKiEventCalc = serial_Excel_kiEventCalculation.Excel_simpleKiEventCalc_;

            base.setFromSerial(serial_Class);

            //this.eventDate_ = serial_Excel_simpleKiEventCalc.EventDate_.DateTimeValue();
            //this.payoffDate_ = serial_Excel_simpleKiEventCalc.PayoffDate_.DateTimeValue();

            FpmlSerializedCSharp.Excel_eventCalcInfo serial_excel_eventCalcInfo = serial_Excel_simpleKiEventCalc.Excel_eventCalcInfo_;
            string excel_eventCalcInfotype = serial_excel_eventCalcInfo.Excel_type_.ValueStr;
            this.excel_eventCalcInfoViewModel_ = Excel_eventCalcInfoViewModel.CreateExcel_eventCalcInfo(excel_eventCalcInfotype);
            this.excel_eventCalcInfoViewModel_.setFromSerial(serial_excel_eventCalcInfo);

            FpmlSerializedCSharp.Excel_occReturnCalcInfo serial_excel_occReturnCalcInfo = serial_Excel_simpleKiEventCalc.Excel_occReturnCalcInfo_;
            this.excel_occReturnCalcInfoViewModel_ = new Excel_occReturnCalcInfoViewModel();
            this.excel_occReturnCalcInfoViewModel_.setFromSerial(serial_excel_occReturnCalcInfo);

            FpmlSerializedCSharp.Excel_noOccReturnCalcInfo serial_excel_noOccReturnCalcInfo = serial_Excel_simpleKiEventCalc.Excel_noOccReturnCalcInfo_;
            this.excel_noOccReturnCalcInfoViewModel_ = new Excel_noOccReturnCalcInfoViewModel();
            this.excel_noOccReturnCalcInfoViewModel_.setFromSerial(serial_excel_noOccReturnCalcInfo);
            
        }

        public override Control view()
        {
            Control v = new Excel_simpleKiEventCalcView();

            v.DataContext = this;

            return v;
        }

        public override void setUnderlying(Excel_underlyingCalcInfoViewModel excel_under)
        {
            this.excel_underlyingCalcInfoViewModel_ = excel_under;

            this.excel_eventCalcInfoViewModel_.setUnderlying(excel_under);
            this.excel_occReturnCalcInfoViewModel_.setUnderlying(excel_under);
            this.excel_noOccReturnCalcInfoViewModel_.setUnderlying(excel_under);

        }

        public override void defaultSetting()
        {
            this.excel_eventCalcInfoViewModel_ = new Excel_singleBarrierEventCalViewModel();
            this.excel_eventCalcInfoViewModel_.defaultSetting();

            this.excel_occReturnCalcInfoViewModel_ = new Excel_occReturnCalcInfoViewModel();
            this.excel_occReturnCalcInfoViewModel_.Excel_returnCalcInfoViewModel_ = new Excel_vanillaReturnCalViewModel();

            this.excel_occReturnCalcInfoViewModel_.Excel_returnCalcInfoViewModel_.defaultSetting();

            this.excel_noOccReturnCalcInfoViewModel_ = new Excel_noOccReturnCalcInfoViewModel();
            this.excel_noOccReturnCalcInfoViewModel_.Excel_returnCalcInfoViewModel_ = new Excel_constReturnCalViewModel();
            this.excel_noOccReturnCalcInfoViewModel_.Excel_returnCalcInfoViewModel_.defaultSetting();
            

        }
    }
    
}

