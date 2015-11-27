using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_structuredSwapLegViewModel : Excel_swapLegViewModel
    {
        public Excel_structuredSwapLegViewModel() { }
        
        //#region Excel_swapLegInfoViewModel_
        //private Excel_swapLegInfoViewModel excel_swapLegInfoViewModel_;
        //public Excel_swapLegInfoViewModel Excel_swapLegInfoViewModel_
        //{
        //    get { return this.excel_swapLegInfoViewModel_; }
        //    set
        //    {
        //        if (this.excel_swapLegInfoViewModel_ != value)
        //        {
        //            this.excel_swapLegInfoViewModel_ = value;
        //            this.NotifyPropertyChanged("Excel_swapLegInfoViewModel_");
        //        }
        //    }
        //}
        //#endregion
        
        #region Excel_interfaceViewModel_
        private Excel_interfaceViewModel excel_interfaceViewModel_;
        public Excel_interfaceViewModel Excel_interfaceViewModel_
        {
            get { return this.excel_interfaceViewModel_; }
            set
            {
                if (this.excel_interfaceViewModel_ != value)
                {
                    this.excel_interfaceViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_interfaceViewModel_");
                }
            }
        }
        #endregion
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_swapLeg");
                xmlWriter.WriteElementString("excel_type" , "excel_structuredSwapLeg");
                xmlWriter.WriteStartElement("excel_structuredSwapLeg");
                    //excel_swapLegInfoViewModel_.buildXml(xmlWriter);
                    
                    excel_interfaceViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            throw new NotImplementedException();

            //Control v = new Excel_structuredSwapLegView();
            //v.DataContext = this;
            //return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_swapLeg serial_Excel_swapLeg = serial_Class as FpmlSerializedCSharp.Excel_swapLeg;
            FpmlSerializedCSharp.Excel_structuredSwapLeg serial_Excel_structuredSwapLeg = serial_Excel_swapLeg.Excel_structuredSwapLeg_;
        
            //FpmlSerializedCSharp.Excel_swapLegInfo serial_excel_swapLegInfo = serial_Excel_structuredSwapLeg.Excel_swapLegInfo_;
            //this.excel_swapLegInfoViewModel_.setFromSerial(serial_excel_swapLegInfo);
            
            FpmlSerializedCSharp.Excel_interface serial_excel_interface = serial_Excel_structuredSwapLeg.Excel_interface_;
            //string excel_interfacetype = serial_excel_interface.Excel_type_.ValueStr;
            this.excel_interfaceViewModel_ = new Excel_structuredBondViewModel();
            this.excel_interfaceViewModel_.setFromSerial(serial_excel_interface);
            
        }

        public override void setUnderlying()
        {
            throw new NotImplementedException();
        }

        public override void bookingEvent(MasterInformationViewModel masterInformationViewModel)
        {
            throw new NotImplementedException();
        }

        public override Excel_underlyingCalcInfoViewModel getExcel_underlyingCalcInfoViewModel()
        {
            return this.excel_interfaceViewModel_.Excel_underlyingCalcInfoViewModel_;
        }

        public override Excel_issueInfoViewModel getExcel_issueInfoViewModel()
        {
            return this.excel_interfaceViewModel_.Excel_issueInfoViewModel_;
        }
    }
    
}

