using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Excel_Interface
{
    public class Excel_fxForwardViewModel : Excel_interfaceViewModel
    {

        public Excel_fxForwardViewModel() 
        {
            this.excel_issueInfoViewModel_ = new Excel_noteInfoViewModel();
            this.fx_exchangeLegViewModel_ = new Fx_exchangeLegViewModel();

            //code : E0001
            // 이게 내부에서 있는데 더해지면 이벤트를 받음. // 사용하지는 않지만, 내부적으로 추가해서 가지고 있음.. 
            // pricing을 변경하는 경우나 excel_underlyingCalcInfoViewModel_이걸 토대로 작업을 해야할 때 추가해서 사용해야함.
            // Fx_exchangeLeg 의 currency가 변경되는 경우에 사용함.
            // 현재는 사용하지 않음.
            this.excel_underlyingCalcInfoViewModel_ = new Excel_underlyingCalcInfoViewModel();

        }

        public override void masterEventObserver(object sender, PropertyChangedEventArgs e)
        {
            base.masterEventObserver(sender, e);
            this.fx_exchangeLegViewModel_.masterEventObserver(sender, e);
        }

        #region Fx_exchangeLegViewModel_
        private Fx_exchangeLegViewModel fx_exchangeLegViewModel_;
        public Fx_exchangeLegViewModel Fx_exchangeLegViewModel_
        {
            get { return this.fx_exchangeLegViewModel_; }
            set
            {
                if (this.fx_exchangeLegViewModel_ != value)
                {
                    this.fx_exchangeLegViewModel_ = value;
                    this.NotifyPropertyChanged("Fx_exchangeLegViewModel_");
                }
            }
        }
        #endregion

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_interface");
                xmlWriter.WriteElementString("excel_type", "excel_fxForward");
                xmlWriter.WriteStartElement("excel_fxForward");

                excel_issueInfoViewModel_.buildXml(xmlWriter);

                fx_exchangeLegViewModel_.buildXml(xmlWriter);

                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }

        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }

        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_interface serial_Excel_interface = serial_Class as FpmlSerializedCSharp.Excel_interface;
            FpmlSerializedCSharp.Excel_fxForward serial_Excel_fxForward = serial_Excel_interface.Excel_fxForward_;

            FpmlSerializedCSharp.Excel_issueInfo serial_excel_issueInfo = serial_Excel_fxForward.Excel_issueInfo_;
            string excel_issueInfotype = serial_excel_issueInfo.Excel_type_.ValueStr;
            this.excel_issueInfoViewModel_ = Excel_issueInfoViewModel.CreateExcel_issueInfo(excel_issueInfotype);
            this.excel_issueInfoViewModel_.setFromSerial(serial_excel_issueInfo);

            FpmlSerializedCSharp.Fx_exchangeLeg serial_fx_exchangeLeg = serial_Excel_fxForward.Fx_exchangeLeg_;
            this.fx_exchangeLegViewModel_.setFromSerial(serial_fx_exchangeLeg);

        }

        public override void buildPricingXml(System.Xml.XmlWriter xmlWriter)
        {
            
        }

        public override void bookingEvent(MasterInformationViewModel masterInformationViewModel)
        {
            EVENT_INFO_Table_DAO dao = new EVENT_INFO_Table_DAO();

            this.fx_exchangeLegViewModel_.bookingEvent(masterInformationViewModel, dao);

            //dao.EVENT_AMOUNT_ = generalScheduleDeatilViewModel_.InitialFixingAmount_;
            //dao.FIXING_UNDERLYINGS_ = generalScheduleDeatilViewModel_.FixingUnderlying_;
            //dao.FIXING_FLAG_ = generalScheduleDeatilViewModel_.InitialFixingFlag_;

            dao.ITEM_CODE_ = masterInformationViewModel.Item_code_;
            dao.ITEM_TYPE_ = masterInformationViewModel.Booking_type_;
            dao.ITEM_NAME_ = masterInformationViewModel.Item_name_;
            dao.REMAIN_NOTIONAL_ = masterInformationViewModel.Remain_notional_;

        }

        public override Control view()
        {
            Excel_fxForwardView v = new Excel_fxForwardView();

            //this.PropertyChanged +=
            //    new PropertyChangedEventHandler(v.viewModel_PropertyChanged);

            v.DataContext = this;

            return v;
        }

        public override void setUnderlying()
        {
            throw new NotImplementedException();
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
