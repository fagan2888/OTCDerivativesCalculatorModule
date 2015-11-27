using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_fixedRateSwapLegViewModel : Excel_swapLegViewModel
    {
        public Excel_fixedRateSwapLegViewModel() 
        {
            //this.Excel_type_ = "excel_fixedRateSwapLeg";
            //this.excel_swapLegInfoViewModel_ = new Excel_swapLegInfoViewModel();
            
            this.excel_fixedBondViewModel_ = new Excel_fixedBondViewModel();

            //this.excel_swapLegInfoViewModel_ = new Excel_swapLegInfoViewModel();

            //this.excel_fixedBondViewModel_.Excel_issueInfoViewModel_
            //    = this.excel_swapLegInfoViewModel_;

        }
        
        #region Excel_fixedBondViewModel_
        private Excel_fixedBondViewModel excel_fixedBondViewModel_;
        public Excel_fixedBondViewModel Excel_fixedBondViewModel_
        {
            get { return this.excel_fixedBondViewModel_; }
            set
            {
                if (this.excel_fixedBondViewModel_ != value)
                {
                    this.excel_fixedBondViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_fixedBondViewModel_");
                }
            }
        }
        #endregion
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_swapLeg");
                xmlWriter.WriteElementString("excel_type", "excel_fixedRateSwapLeg");
                xmlWriter.WriteStartElement("excel_fixedRateSwapLeg");
                    //excel_swapLegInfoViewModel_.buildXml(xmlWriter);
                    
                    excel_fixedBondViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            //Control v = Excel_fixedRateSwapLegView();
            //v.DataContext = this;
            return this.excel_fixedBondViewModel_.view(Orientation.Vertical);
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_swapLeg serial_Excel_swapLeg = serial_Class as FpmlSerializedCSharp.Excel_swapLeg;
            FpmlSerializedCSharp.Excel_fixedRateSwapLeg serial_Excel_fixedRateSwapLeg = serial_Excel_swapLeg.Excel_fixedRateSwapLeg_;

            //FpmlSerializedCSharp.Excel_swapLegInfo serial_excel_swapLegInfo = serial_Excel_fixedRateSwapLeg.Excel_swapLegInfo_;
            //string excel_swapLegInfotype = serial_excel_swapLegInfo.Excel_type_.ValueStr;
            //this.excel_swapLegInfoViewModel_ = Excel_swapLegInfoViewModel.CreateExcel_swapLegInfo(excel_swapLegInfotype);
            //this.excel_swapLegInfoViewModel_.setFromSerial(serial_excel_swapLegInfo);

            FpmlSerializedCSharp.Excel_interface serial_excel_interface = serial_Excel_fixedRateSwapLeg.Excel_interface_;
            string excel_interfacetype = serial_excel_interface.Excel_type_.ValueStr;
            this.excel_fixedBondViewModel_ = new Excel_fixedBondViewModel();
            this.excel_fixedBondViewModel_.setFromSerial(serial_excel_interface);

        }

        public override void setUnderlying()
        {
            this.excel_fixedBondViewModel_.setUnderlying();
        }

        public override void bookingEvent(MasterInformationViewModel masterInformationViewModel)
        {
            this.excel_fixedBondViewModel_.bookingEvent(masterInformationViewModel);
        }

        public override Excel_underlyingCalcInfoViewModel getExcel_underlyingCalcInfoViewModel()
        {
            return this.excel_fixedBondViewModel_.Excel_underlyingCalcInfoViewModel_;
        }

        public override Excel_issueInfoViewModel getExcel_issueInfoViewModel()
        {
            return this.excel_fixedBondViewModel_.Excel_issueInfoViewModel_;
        }
    }
    
}

