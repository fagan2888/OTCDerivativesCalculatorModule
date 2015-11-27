using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_targetKiEventCalcViewModel : Excel_kiEventCalculationViewModel
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
        
        public Excel_targetKiEventCalcViewModel() { }
        
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
        
        #region TargetCount_
        private string targetCount_;
        public string TargetCount_
        {
            get { return this.targetCount_; }
            set
            {
                if (this.targetCount_ != value)
                {
                    this.targetCount_ = value;
                    this.NotifyPropertyChanged("TargetCount_");
                }
            }
        }
        #endregion
        
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
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_kiEventCalculation");
                xmlWriter.WriteElementString("type" , "excel_targetKiEventCalc");
                xmlWriter.WriteStartElement("excel_targetKiEventCalc");
                    xmlWriter.WriteElementString("eventDate" , StringConverter.xmlDateTimeToDateString(this.eventDate_));
                    
                    xmlWriter.WriteElementString("targetCount" , this.targetCount_);
                    
                    excel_eventCalcInfoViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_targetKiEventCalcView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_kiEventCalculation serial_Excel_kiEventCalculation = serial_Class as FpmlSerializedCSharp.Excel_kiEventCalculation;
            FpmlSerializedCSharp.Excel_targetKiEventCalc serial_Excel_targetKiEventCalc = serial_Excel_kiEventCalculation.Excel_targetKiEventCalc_;
        
            this.eventDate_ = StringConverter.xmlDateToDateTime(serial_Excel_targetKiEventCalc.EventDate_.ValueStr);
            
            this.targetCount_ = serial_Excel_targetKiEventCalc.TargetCount_.ValueStr;
            
            FpmlSerializedCSharp.Excel_eventCalcInfo serial_excel_eventCalcInfo = serial_Excel_targetKiEventCalc.Excel_eventCalcInfo_;
            string excel_eventCalcInfotype = serial_excel_eventCalcInfo.Excel_type_.ValueStr;
            this.excel_eventCalcInfoViewModel_ = Excel_eventCalcInfoViewModel.CreateExcel_eventCalcInfo(excel_eventCalcInfotype);
            this.excel_eventCalcInfoViewModel_.setFromSerial(serial_excel_eventCalcInfo);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

