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
        public Excel_targetKiEventCalcViewModel() 
        {
            this.Excel_Type_ = "excel_targetKiEventCalc";
        }
    
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
                xmlWriter.WriteElementString("excel_type" , "excel_targetKiEventCalc");
                xmlWriter.WriteStartElement("excel_targetKiEventCalc");
                    xmlWriter.WriteElementString("targetCount" , this.targetCount_);
                    
                    excel_eventCalcInfoViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            //TODO setFromSerial implementation

            //FpmlSerializedCSharp.Excel_kiEventCalculation serial_Excel_kiEventCalculation = serial_Class as FpmlSerializedCSharp.Excel_kiEventCalculation;
            //FpmlSerializedCSharp.Excel_targetKiEventCalc serial_Excel_targetKiEventCalc = serial_Excel_kiEventCalculation.Excel_targetKiEventCalc_;
        
            //this.targetCount_ = serial_Excel_targetKiEventCalc.TargetCount_.ValueStr;
            
            //FpmlSerializedCSharp.Excel_eventCalcInfo serial_excel_eventCalcInfo = serial_Excel_targetKiEventCalc.Excel_eventCalcInfo_;
            //string excel_eventCalcInfotype = serial_excel_eventCalcInfo.Type_.ValueStr;
            //this.excel_eventCalcInfoViewModel_ = Excel_eventCalcInfoViewModel.CreateExcel_eventCalcInfo(excel_eventCalcInfotype);
            //this.excel_eventCalcInfoViewModel_.setFromSerial(serial_excel_eventCalcInfo);
        }


        public override Control view()
        {
            throw new NotImplementedException();
        }

        public override void setUnderlying(Excel_underlyingCalcInfoViewModel excel_under)
        {
            throw new NotImplementedException();
        }

        public override void defaultSetting()
        {
            throw new NotImplementedException();
        }
    }
    
}

