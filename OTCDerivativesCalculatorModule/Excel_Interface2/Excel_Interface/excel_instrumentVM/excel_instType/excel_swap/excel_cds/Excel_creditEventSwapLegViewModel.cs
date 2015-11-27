using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_creditEventSwapLegViewModel : Excel_swapLegViewModel
    {
        public Excel_creditEventSwapLegViewModel() 
        {
            this.excel_creditEventInfoViewModel_ = new Excel_creditEventInfoViewModel();
        }
        
        #region Excel_creditEventInfoViewModel_
        private Excel_creditEventInfoViewModel excel_creditEventInfoViewModel_;
        public Excel_creditEventInfoViewModel Excel_creditEventInfoViewModel_
        {
            get { return this.excel_creditEventInfoViewModel_; }
            set
            {
                if (this.excel_creditEventInfoViewModel_ != value)
                {
                    this.excel_creditEventInfoViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_creditEventInfoViewModel_");
                }
            }
        }
        #endregion
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_swapLeg");
                xmlWriter.WriteElementString("excel_type" , "excel_creditEventSwapLeg");
                xmlWriter.WriteStartElement("excel_creditEventSwapLeg");
                    //excel_swapLegInfoViewModel_.buildXml(xmlWriter);
                    
                    excel_creditEventInfoViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            return this.excel_creditEventInfoViewModel_.view();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_swapLeg serial_Excel_swapLeg = serial_Class as FpmlSerializedCSharp.Excel_swapLeg;
            FpmlSerializedCSharp.Excel_creditEventSwapLeg serial_Excel_creditEventSwapLeg = serial_Excel_swapLeg.Excel_creditEventSwapLeg_;
        
            //FpmlSerializedCSharp.Excel_swapLegInfo serial_excel_swapLegInfo = serial_Excel_creditEventSwapLeg.Excel_swapLegInfo_;
            ////string excel_swapLegInfotype = serial_excel_swapLegInfo.Excel_type_.ValueStr;
            //this.excel_swapLegInfoViewModel_ = new Excel_swapLegInfoViewModel();
            //this.excel_swapLegInfoViewModel_.setFromSerial(serial_excel_swapLegInfo);
            
            FpmlSerializedCSharp.Excel_creditEventInfo serial_excel_creditEventInfo = serial_Excel_creditEventSwapLeg.Excel_creditEventInfo_;
            //string excel_creditEventInfotype = serial_excel_creditEventInfo.Excel_type_.ValueStr;
            this.excel_creditEventInfoViewModel_ = new Excel_creditEventInfoViewModel();
            this.excel_creditEventInfoViewModel_.setFromSerial(serial_excel_creditEventInfo);
            
        }

        public override void setUnderlying()
        {

        }

        public override void bookingEvent(MasterInformationViewModel masterInformationViewModel)
        {
            OutputLogViewModel.addResult("not implemented yet");
            //this.excel_creditEventInfoViewModel_.
        }

        public override Excel_underlyingCalcInfoViewModel getExcel_underlyingCalcInfoViewModel()
        {
            throw new NotImplementedException();
        }

        public override Excel_issueInfoViewModel getExcel_issueInfoViewModel()
        {
            return this.excel_creditEventInfoViewModel_.Excel_issueInfoViewModel_;
        }
    }
    
}

