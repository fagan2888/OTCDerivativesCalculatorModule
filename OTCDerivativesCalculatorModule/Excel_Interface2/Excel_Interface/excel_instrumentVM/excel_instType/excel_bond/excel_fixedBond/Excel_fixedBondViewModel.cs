using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Excel_Interface
{
    public class Excel_fixedBondViewModel : Excel_interfaceViewModel
    {
        #region Excel_fixedCouponScheduleListViewModel_
        private Excel_fixedCouponScheduleListViewModel excel_fixedCouponScheduleListViewModel_;
        public Excel_fixedCouponScheduleListViewModel Excel_fixedCouponScheduleListViewModel_
        {
            get { return this.excel_fixedCouponScheduleListViewModel_; }
            set
            {
                if (this.excel_fixedCouponScheduleListViewModel_ != value)
                {
                    this.excel_fixedCouponScheduleListViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_fixedCouponScheduleListViewModel_");
                }
            }
        }
        #endregion

        #region Excel_fixedBond_subtypeViewModel_
        private Excel_fixedBond_subtypeViewModel excel_fixedBond_subtypeViewModel_;
        public Excel_fixedBond_subtypeViewModel Excel_fixedBond_subtypeViewModel_
        {
            get { return this.excel_fixedBond_subtypeViewModel_; }
            set
            {
                if (this.excel_fixedBond_subtypeViewModel_ != value)
                {
                    this.excel_fixedBond_subtypeViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_fixedBond_subtypeViewModel_");
                }
            }
        }
        #endregion

        public Excel_fixedBondViewModel()
        {
            this.excel_issueInfoViewModel_ = new Excel_noteInfoViewModel();
            
            this.excel_underlyingCalcInfoViewModel_ = new Excel_underlyingCalcInfoViewModel();

            // default로 박을거
            this.excel_fixedBond_subtypeViewModel_ = new Excel_fixedBond_constantRateViewModel();

            this.excel_fixedCouponScheduleListViewModel_ = new Excel_fixedCouponScheduleListViewModel();

        }

        public override void setUnderlying()
        {
            this.excel_fixedBond_subtypeViewModel_.setUnderlying(this.excel_underlyingCalcInfoViewModel_);
            this.excel_fixedCouponScheduleListViewModel_.setUnderlying(this.excel_underlyingCalcInfoViewModel_);
        }

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_interface");
                xmlWriter.WriteElementString("excel_type", "excel_fixedBond");
                xmlWriter.WriteStartElement("excel_fixedBond");

                this.excel_issueInfoViewModel_.buildXml(xmlWriter);
                this.excel_fixedCouponScheduleListViewModel_.buildXml(xmlWriter);
                this.excel_fixedBond_subtypeViewModel_.buildXml(xmlWriter);

                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }

        public override void buildPricingXml(System.Xml.XmlWriter xmlWriter)
        {
            
        }

        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }

        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_interface serial_Excel_interface = serial_Class as FpmlSerializedCSharp.Excel_interface;
            FpmlSerializedCSharp.Excel_fixedBond serial_Excel_fixedBond = serial_Excel_interface.Excel_fixedBond_;

            FpmlSerializedCSharp.Excel_issueInfo serial_excel_issueInfo = serial_Excel_fixedBond.Excel_issueInfo_;
            string excel_issueInfotype = serial_excel_issueInfo.Excel_type_.ValueStr;
            this.excel_issueInfoViewModel_ = Excel_issueInfoViewModel.CreateExcel_issueInfo(excel_issueInfotype);
            this.excel_issueInfoViewModel_.setFromSerial(serial_excel_issueInfo);

            FpmlSerializedCSharp.Excel_fixedCouponScheduleList serial_excel_fixedCouponScheduleList = serial_Excel_fixedBond.Excel_fixedCouponScheduleList_;
            this.excel_fixedCouponScheduleListViewModel_ = new Excel_fixedCouponScheduleListViewModel();
            this.excel_fixedCouponScheduleListViewModel_.setFromSerial(serial_excel_fixedCouponScheduleList);

            FpmlSerializedCSharp.Excel_fixedBond_subtype serial_excel_fixedBond_subtype = serial_Excel_fixedBond.Excel_fixedBond_subtype_;
            string excel_fixedBond_subtypetype = serial_excel_fixedBond_subtype.Excel_type_.ValueStr;
            this.excel_fixedBond_subtypeViewModel_ = Excel_fixedBond_subtypeViewModel.CreateExcel_fixedBond_subtype(excel_fixedBond_subtypetype);
            this.excel_fixedBond_subtypeViewModel_.setFromSerial(serial_excel_fixedBond_subtype);

        }

        public override void bookingEvent(MasterInformationViewModel masterInformationViewModel)
        {
            foreach (var item in this.excel_fixedCouponScheduleListViewModel_.Excel_fixedCouponScheduleViewModel_)
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
            Control v = new Excel_fixedBondView(ori);

            v.DataContext = this;

            return v;
        }

        public override Control view()
        {
            Control v = new Excel_fixedBondView();

            v.DataContext = this;

            return v;
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
