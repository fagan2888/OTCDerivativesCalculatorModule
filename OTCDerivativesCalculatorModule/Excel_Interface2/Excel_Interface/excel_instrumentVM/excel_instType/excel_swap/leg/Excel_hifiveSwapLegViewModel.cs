using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_hifiveSwapLegViewModel : Excel_swapLegViewModel
    {
        public Excel_hifiveSwapLegViewModel()
        {
            this.Excel_type_ = "excel_hifiveSwapLeg";

            this.excel_hifiveViewModel_ = new Excel_hifiveViewModel();

            //this.excel_swapLegInfoViewModel_ = new Excel_swapLegInfoViewModel();
            //this.excel_hifiveViewModel_.Excel_issueInfoViewModel_
            //    = this.excel_swapLegInfoViewModel_;

        }
        
        #region Excel_hifiveViewModel_
        private Excel_hifiveViewModel excel_hifiveViewModel_;
        public Excel_hifiveViewModel Excel_hifiveViewModel_
        {
            get { return this.excel_hifiveViewModel_; }
            set
            {
                if (this.excel_hifiveViewModel_ != value)
                {
                    this.excel_hifiveViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_hifiveViewModel_");
                }
            }
        }
        #endregion
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_swapLeg");
                xmlWriter.WriteElementString("excel_type" , "excel_hifiveSwapLeg");
                xmlWriter.WriteStartElement("excel_hifiveSwapLeg");
                    //excel_swapLegInfoViewModel_.buildXml(xmlWriter);
                    
                    excel_hifiveViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            //Control v = new Excel_hifiveSwapLegView();
            //v.DataContext = this;
            return this.excel_hifiveViewModel_.view(); ;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_swapLeg serial_Excel_swapLeg = serial_Class as FpmlSerializedCSharp.Excel_swapLeg;
            FpmlSerializedCSharp.Excel_hifiveSwapLeg serial_Excel_hifiveSwapLeg = serial_Excel_swapLeg.Excel_hifiveSwapLeg_;
        
            //FpmlSerializedCSharp.Excel_swapLegInfo serial_excel_swapLegInfo = serial_Excel_hifiveSwapLeg.Excel_swapLegInfo_;
            ////string excel_swapLegInfotype = serial_excel_swapLegInfo.Excel_type_.ValueStr;
            //this.excel_swapLegInfoViewModel_ = new Excel_swapLegInfoViewModel();
            //this.excel_swapLegInfoViewModel_.setFromSerial(serial_excel_swapLegInfo);

            FpmlSerializedCSharp.Excel_interface serial_excel_interface = serial_Excel_hifiveSwapLeg.Excel_interface_;
            //string excel_hifivetype = serial_excel_hifive.Excel_type_.ValueStr;
            this.excel_hifiveViewModel_ = new Excel_hifiveViewModel();
            this.excel_hifiveViewModel_.setFromSerial(serial_excel_interface);
            
        }

        public override void setUnderlying()
        {
            this.excel_hifiveViewModel_.setUnderlying();
        }

        public override void bookingEvent(MasterInformationViewModel masterInformationViewModel)
        {
            this.excel_hifiveViewModel_.bookingEvent(masterInformationViewModel);
        }

        public override Excel_underlyingCalcInfoViewModel getExcel_underlyingCalcInfoViewModel()
        {
            return this.excel_hifiveViewModel_.Excel_underlyingCalcInfoViewModel_;
        }

        public override Excel_issueInfoViewModel getExcel_issueInfoViewModel()
        {
            return this.excel_hifiveViewModel_.Excel_issueInfoViewModel_;
        }
    }
    
}

