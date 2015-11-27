using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_vanillaFloatingRateSwapLegViewModel : Excel_swapLegViewModel
    {
        public Excel_vanillaFloatingRateSwapLegViewModel() 
        {
            this.Excel_type_ = "excel_vanillaFloatingRateSwapLeg";
            //this.excel_swapLegInfoViewModel_ = new Excel_swapLegInfoViewModel();
            this.excel_vanillaFloatingBondViewModel_ = new Excel_vanillaFloatingBondViewModel();

            //this.excel_swapLegInfoViewModel_ = new Excel_swapLegInfoViewModel();

            //this.excel_vanillaFloatingBondViewModel_.Excel_issueInfoViewModel_ =
            //    this.excel_swapLegInfoViewModel_;

        }
        
        #region Excel_vanillaFloatingBondViewModel_
        private Excel_vanillaFloatingBondViewModel excel_vanillaFloatingBondViewModel_;
        public Excel_vanillaFloatingBondViewModel Excel_vanillaFloatingBondViewModel_
        {
            get { return this.excel_vanillaFloatingBondViewModel_; }
            set
            {
                if (this.excel_vanillaFloatingBondViewModel_ != value)
                {
                    this.excel_vanillaFloatingBondViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_vanillaFloatingBondViewModel_");
                }
            }
        }
        #endregion
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_swapLeg");
                xmlWriter.WriteElementString("excel_type", "excel_vanillaFloatingRateSwapLeg");
                xmlWriter.WriteStartElement("excel_vanillaFloatingRateSwapLeg");
                    //excel_swapLegInfoViewModel_.buildXml(xmlWriter);
                    
                    excel_vanillaFloatingBondViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            //Control v = new Excel_vanillaFloatingRateSwapLegView();
            //v.DataContext = this;
            return this.excel_vanillaFloatingBondViewModel_.view(Orientation.Vertical);
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_swapLeg serial_Excel_swapLeg = serial_Class as FpmlSerializedCSharp.Excel_swapLeg;
            FpmlSerializedCSharp.Excel_vanillaFloatingRateSwapLeg serial_Excel_vanillaFloatingRateSwapLeg = serial_Excel_swapLeg.Excel_vanillaFloatingRateSwapLeg_;
        
            //FpmlSerializedCSharp.Excel_swapLegInfo serial_excel_swapLegInfo = serial_Excel_vanillaFloatingRateSwapLeg.Excel_swapLegInfo_;
            ////string excel_swapLegInfotype = serial_excel_swapLegInfo.Excel_type_.ValueStr;
            //this.excel_swapLegInfoViewModel_ = new Excel_swapLegInfoViewModel();
            //this.excel_swapLegInfoViewModel_.setFromSerial(serial_excel_swapLegInfo);

            FpmlSerializedCSharp.Excel_interface serial_excel_interface = serial_Excel_vanillaFloatingRateSwapLeg.Excel_interface_;
            string excel_interfacetype = serial_excel_interface.Excel_type_.ValueStr;
            this.excel_vanillaFloatingBondViewModel_ = new Excel_vanillaFloatingBondViewModel();//.CreateExcel_vanillaFloatingBond(excel_vanillaFloatingBondtype);
            this.excel_vanillaFloatingBondViewModel_.setFromSerial(serial_excel_interface);
            
        }

        public override void setUnderlying()
        {
            this.excel_vanillaFloatingBondViewModel_.setUnderlying();
        }

        public override void bookingEvent(MasterInformationViewModel masterInformationViewModel)
        {
            this.excel_vanillaFloatingBondViewModel_.bookingEvent(masterInformationViewModel);
        }

        public override Excel_underlyingCalcInfoViewModel getExcel_underlyingCalcInfoViewModel()
        {
            return this.excel_vanillaFloatingBondViewModel_.Excel_underlyingCalcInfoViewModel_;
        }

        public override Excel_issueInfoViewModel getExcel_issueInfoViewModel()
        {
            return this.excel_vanillaFloatingBondViewModel_.Excel_issueInfoViewModel_;
        }
    }
    
}

