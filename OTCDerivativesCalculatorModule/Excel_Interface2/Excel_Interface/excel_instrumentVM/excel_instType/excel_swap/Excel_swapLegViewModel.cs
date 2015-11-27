using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public abstract class Excel_swapLegViewModel : IXmlData
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

        // ¿ÜºÎ link¿ë issueInfo

        //#region Excel_swapLegInfoViewModel_
        //protected Excel_swapLegInfoViewModel excel_swapLegInfoViewModel_;
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

        public Excel_swapLegViewModel() 
        {
        
        }
        
        #region Excel_type_
        private string excel_type_;
        public string Excel_type_
        {
            get { return this.excel_type_; }
            set
            {
                if (this.excel_type_ != value)
                {
                    this.excel_type_ = value;
                    this.NotifyPropertyChanged("Excel_type_");
                }
            }
        }
        #endregion
        
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        public abstract void setUnderlying();

        public abstract Control view();

        public static Excel_swapLegViewModel CreateExcel_swapLeg(string typeStr)
        {
            if ( typeStr == "excel_fixedRateSwapLeg")
            {
                return new Excel_fixedRateSwapLegViewModel();
            }
            else if ( typeStr == "excel_vanillaFloatingRateSwapLeg")
            {
                return new Excel_vanillaFloatingRateSwapLegViewModel();
            }
            //else if ( typeStr == "excel_structuredRateSwapLeg")
            //{
            //    return new Excel_structuredRateSwapLegViewModel();
            //}
            //else if ( typeStr == "excel_creditEventSwapLeg")
            //{
            //    return new Excel_creditEventSwapLegViewModel();
            //}
            else if ( typeStr == "excel_hifiveSwapLeg")
            {
                return new Excel_hifiveSwapLegViewModel();
            }
            else if (typeStr == "excel_structuredSwapLeg")
            {
                return new Excel_structuredSwapLegViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }

        public abstract void bookingEvent(MasterInformationViewModel masterInformationViewModel);

        public abstract Excel_underlyingCalcInfoViewModel getExcel_underlyingCalcInfoViewModel();
        public abstract Excel_issueInfoViewModel getExcel_issueInfoViewModel();
    }
    
}

