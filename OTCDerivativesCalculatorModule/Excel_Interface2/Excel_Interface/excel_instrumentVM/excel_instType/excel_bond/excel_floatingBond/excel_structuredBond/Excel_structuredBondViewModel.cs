using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Excel_Interface
{
    public class Excel_structuredBondViewModel : Excel_interfaceViewModel
    {
        #region Excel_couponScheduleListViewModel_
        private Excel_couponScheduleListViewModel excel_couponScheduleListViewModel_;
        public Excel_couponScheduleListViewModel Excel_couponScheduleListViewModel_
        {
            get { return this.excel_couponScheduleListViewModel_; }
            set
            {
                if (this.excel_couponScheduleListViewModel_ != value)
                {
                    this.excel_couponScheduleListViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_couponScheduleListViewModel_");
                }
            }
        }
        #endregion

        public Excel_structuredBondViewModel()
        {
            this.excel_issueInfoViewModel_ = new Excel_noteInfoViewModel();
            this.excel_underlyingCalcInfoViewModel_ = new Excel_underlyingCalcInfoViewModel();

            this.excel_underlyingCalcInfoViewModel_.EffectiveDate_ = this.excel_issueInfoViewModel_.EffectiveDate_;

            this.excel_issueInfoViewModel_.PropertyChanged +=
                this.excel_underlyingCalcInfoViewModel_.issueInfoObserver;

            this.excel_couponScheduleListViewModel_ = new Excel_couponScheduleListViewModel();

            //this.excel_issueInfoViewModel_.PropertyChanged
            //    += new PropertyChangedEventHandler(this.excel_couponScheduleListViewModel_.ScheduleInitialDateObserver);

            //초기 값 set
            //this.excel_couponScheduleListViewModel_.ScheduleInitialDate_ = this.excel_issueInfoViewModel_.EffectiveDate_;

            //this.view_ = new Excel_vanillaFloatingBondView();
            //this.view_.DataContext = this;
        }

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_interface");
                xmlWriter.WriteElementString("excel_type", "excel_structuredBond");
                xmlWriter.WriteStartElement("excel_structuredBond");
            
                    this.excel_issueInfoViewModel_.buildXml(xmlWriter);

                    this.excel_underlyingCalcInfoViewModel_.buildXml(xmlWriter);

                    this.excel_couponScheduleListViewModel_.buildXml(xmlWriter);

                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }

        public override void buildPricingXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteElementString("buildPricingXml", "NotImplemented!");
        }

        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }

        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_interface serial_Excel_interface = serial_Class as FpmlSerializedCSharp.Excel_interface;
            FpmlSerializedCSharp.Excel_structuredBond serial_Excel_structuredBond = serial_Excel_interface.Excel_structuredBond_;

            FpmlSerializedCSharp.Excel_issueInfo serial_excel_issueInfo = serial_Excel_structuredBond.Excel_issueInfo_;
            string excel_issueInfotype = serial_excel_issueInfo.Excel_type_.ValueStr;
            this.excel_issueInfoViewModel_ = Excel_issueInfoViewModel.CreateExcel_issueInfo(excel_issueInfotype);
            this.excel_issueInfoViewModel_.setFromSerial(serial_excel_issueInfo);

            FpmlSerializedCSharp.Excel_underlyingCalcInfo serial_excel_underlyingCalcInfo = serial_Excel_structuredBond.Excel_underlyingCalcInfo_;
            //이미 있음 Linked 된게
            //this.excel_underlyingCalcInfoViewModel_ = new Excel_underlyingCalcInfoViewModel();
            this.excel_underlyingCalcInfoViewModel_.setFromSerial(serial_excel_underlyingCalcInfo);

            FpmlSerializedCSharp.Excel_couponScheduleList serial_excel_couponScheduleList = serial_Excel_structuredBond.Excel_couponScheduleList_;
            this.excel_couponScheduleListViewModel_ = new Excel_couponScheduleListViewModel();
            this.excel_couponScheduleListViewModel_.setFromSerial(serial_excel_couponScheduleList);

        }

        public override void bookingEvent(MasterInformationViewModel masterInformationViewModel)
        {
            this.excel_couponScheduleListViewModel_.bookingEvent(masterInformationViewModel);
        }

        public override System.Windows.Controls.Control view()
        {
            Control v = new Excel_structuredBondView();

            v.DataContext = this;

            return v;
        }

        public override void setUnderlying()
        {
            this.excel_couponScheduleListViewModel_.setUnderlying(this.excel_underlyingCalcInfoViewModel_);
        }

        public override List<CurrencyViewModel> currencyList()
        {
            List<CurrencyViewModel> currList = new List<CurrencyViewModel>();

            currList.Add(this.excel_issueInfoViewModel_.Currency_);

            return currList;
        }

        public override void buildFromTradeString(TradeString tradeString)
        {
            throw new NotImplementedException();
        }
    }
}
