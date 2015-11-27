using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Excel_Interface
{
    public class Excel_vanillaFloatingBondViewModel : Excel_interfaceViewModel
    {
        #region Excel_vanillaFloatingCouponScheduleListViewModel_
        private Excel_vanillaFloatingCouponScheduleListViewModel excel_vanillaFloatingCouponScheduleListViewModel_;
        public Excel_vanillaFloatingCouponScheduleListViewModel Excel_vanillaFloatingCouponScheduleListViewModel_
        {
            get { return this.excel_vanillaFloatingCouponScheduleListViewModel_; }
            set
            {
                if (this.excel_vanillaFloatingCouponScheduleListViewModel_ != value)
                {
                    this.excel_vanillaFloatingCouponScheduleListViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_vanillaFloatingCouponScheduleListViewModel_");
                }
            }
        }
        #endregion

        #region Excel_vanillaFloatingBond_subtypeViewModel_
        private Excel_vanillaFloatingBond_subtypeViewModel excel_vanillaFloatingBond_subtypeViewModel_;
        public Excel_vanillaFloatingBond_subtypeViewModel Excel_vanillaFloatingBond_subtypeViewModel_
        {
            get { return this.excel_vanillaFloatingBond_subtypeViewModel_; }
            set
            {
                if (this.excel_vanillaFloatingBond_subtypeViewModel_ != value)
                {
                    this.excel_vanillaFloatingBond_subtypeViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_vanillaFloatingBond_subtypeViewModel_");
                }
            }
        }
        #endregion

        public Excel_vanillaFloatingBondViewModel()
        {
            this.excel_issueInfoViewModel_ = new Excel_noteInfoViewModel();
            this.excel_underlyingCalcInfoViewModel_ = new Excel_underlyingCalcInfoViewModel();

            this.excel_vanillaFloatingCouponScheduleListViewModel_ = new Excel_vanillaFloatingCouponScheduleListViewModel();

            // default로 박을거
            this.excel_vanillaFloatingBond_subtypeViewModel_ = new Excel_vanillaFloatingBond_simpleViewModel();

            //this.excel_issueInfoViewModel_.PropertyChanged
            //    += new PropertyChangedEventHandler(this.couponScheduleInfoViewModel_.ScheduleInitialDateObserver);

            ////초기 값 set
            //this.couponScheduleInfoViewModel_.ScheduleInitialDate_ = this.excel_issueInfoViewModel_.EffectiveDate_;

            //this.view_ = new Excel_vanillaFloatingBondView();
            //this.view_.DataContext = this;
        }

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_interface");
                xmlWriter.WriteElementString("excel_type", "excel_vanillaFloatingBond");
                xmlWriter.WriteStartElement("excel_vanillaFloatingBond");

                    excel_issueInfoViewModel_.buildXml(xmlWriter);
                    excel_underlyingCalcInfoViewModel_.buildXml(xmlWriter);
                    excel_vanillaFloatingCouponScheduleListViewModel_.buildXml(xmlWriter);
                    excel_vanillaFloatingBond_subtypeViewModel_.buildXml(xmlWriter);

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
            FpmlSerializedCSharp.Excel_vanillaFloatingBond serial_Excel_vanillaFloatingBond = serial_Excel_interface.Excel_vanillaFloatingBond_;

            FpmlSerializedCSharp.Excel_issueInfo serial_excel_issueInfo = serial_Excel_vanillaFloatingBond.Excel_issueInfo_;
            string excel_issueInfotype = serial_excel_issueInfo.Excel_type_.ValueStr;
            this.excel_issueInfoViewModel_ = Excel_issueInfoViewModel.CreateExcel_issueInfo(excel_issueInfotype);
            this.excel_issueInfoViewModel_.setFromSerial(serial_excel_issueInfo);

            FpmlSerializedCSharp.Excel_underlyingCalcInfo serial_excel_underlyingCalcInfo = serial_Excel_vanillaFloatingBond.Excel_underlyingCalcInfo_;
            //string excel_underlyingCalcInfotype = serial_excel_underlyingCalcInfo.Excel_type_.ValueStr;
            this.excel_underlyingCalcInfoViewModel_ = new Excel_underlyingCalcInfoViewModel();
            this.excel_underlyingCalcInfoViewModel_.setFromSerial(serial_excel_underlyingCalcInfo);

            FpmlSerializedCSharp.Excel_vanillaFloatingCouponScheduleList serial_excel_vanillaFloatingCouponScheduleList = serial_Excel_vanillaFloatingBond.Excel_vanillaFloatingCouponScheduleList_;
            this.excel_vanillaFloatingCouponScheduleListViewModel_ = new Excel_vanillaFloatingCouponScheduleListViewModel();
            this.excel_vanillaFloatingCouponScheduleListViewModel_.setFromSerial(serial_excel_vanillaFloatingCouponScheduleList);

            FpmlSerializedCSharp.Excel_vanillaFloatingBond_subtype serial_excel_vanillaFloatingBond_subtype = serial_Excel_vanillaFloatingBond.Excel_vanillaFloatingBond_subtype_;
            string excel_vanillaFloatingBond_subtypetype = serial_excel_vanillaFloatingBond_subtype.Excel_type_.ValueStr;
            this.excel_vanillaFloatingBond_subtypeViewModel_ = Excel_vanillaFloatingBond_subtypeViewModel.CreateExcel_vanillaFloatingBond_subtype(excel_vanillaFloatingBond_subtypetype);
            this.excel_vanillaFloatingBond_subtypeViewModel_.setFromSerial(serial_excel_vanillaFloatingBond_subtype);
            
        }

        public override void bookingEvent(MasterInformationViewModel masterInformationViewModel)
        {
            //this.excel_vanillaFloatingCouponScheduleListViewModel_.bookingEvent(masterInformationViewModel);

            foreach (var item in this.excel_vanillaFloatingCouponScheduleListViewModel_.Excel_vanillaFloatingCouponScheduleViewModel_)
            {
                EVENT_INFO_Table_DAO dao = new EVENT_INFO_Table_DAO();

                dao.ITEM_CODE_ = masterInformationViewModel.Item_code_;
                dao.ITEM_TYPE_ = masterInformationViewModel.Booking_type_;
                dao.ITEM_NAME_ = masterInformationViewModel.Item_name_;

                //dao.CALCULATION_TYPE_ = 
                dao.COUNTERPARTY_ = masterInformationViewModel.Counterparty_;
                dao.CURRENCY_ = this.excel_issueInfoViewModel_.Currency_.CurrencyString_;
                //dao.EVENT_AMOUNT_ = 
                dao.EVENT_CODE_ = EventViewModel.eventCodeGen();
                //dao.EVENT_DATE_ = 
                //dao.EVENT_DESCRIPTION_ = 
                //dao.EVENT_NAME_ =
                //dao.EVENT_SUBTYPE_
                //dao.EVENT_TYPE_
                dao.EXPIRED_FLAG_ = "false";
                //dao.FIXING_FLAG_ = 
                //dao.FIXING_OBSERVATION_ =
                //dao.FIXING_UNDERLYINGS_ = 
                //dao.FLOATING_FLAG_ = 
                dao.NOTIONAL_ = this.excel_issueInfoViewModel_.Notional_;
                //dao.REMAIN_NOTIONAL_ = masterInformationViewModel.Remain_notional_;
                dao.REMAIN_NOTIONAL_ = "undefined";

                item.bookingEvent(masterInformationViewModel, dao);

                dao.insert(DataBaseConnectManager.ConnectionFactory("myDB"));

            }

        }

        public Control view(Orientation ori)
        {
            Control v = new Excel_vanillaFloatingBondView(ori);

            v.DataContext = this;

            return v;
        }

        public override Control view()
        {
            Control v = new Excel_vanillaFloatingBondView();

            v.DataContext = this;

            return v;
        }

        public override void setUnderlying()
        {
            this.excel_vanillaFloatingBond_subtypeViewModel_.setUnderlying(this.excel_underlyingCalcInfoViewModel_);
            this.excel_vanillaFloatingCouponScheduleListViewModel_.setUnderlying(this.excel_underlyingCalcInfoViewModel_);

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
