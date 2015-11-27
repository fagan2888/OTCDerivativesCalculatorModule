using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace Excel_Interface
{
    public class Excel_stepDownKICustomViewModel : Excel_interfaceViewModel
    {
        public Excel_stepDownKICustomViewModel()
        {
            // default임..?
            this.excel_issueInfoViewModel_ = new Excel_noteInfoViewModel();

            this.excel_underlyingCalcInfoViewModel_ = new Excel_underlyingCalcInfoViewModel();
            this.excel_hifive_StepDownKI_ViewModel_ = new Excel_hifive_stepDown_kiViewModel(false);
            
            this.excel_hifive_StepDownKI_ViewModel_.EffectiveDate_ = DateTime.Now;

            //this.view_ = new Excel_stepDownKICustomView();
            //this.view_.DataContext = this;
        }

        //#region Excel_issueInfoViewModel_
        //private Excel_issueInfoViewModel excel_issueInfoViewModel_;
        //public Excel_issueInfoViewModel Excel_issueInfoViewModel_
        //{
        //    get { return this.excel_issueInfoViewModel_; }
        //    set
        //    {
        //        if (this.excel_issueInfoViewModel_ != value)
        //        {
        //            this.excel_issueInfoViewModel_ = value;
        //            this.NotifyPropertyChanged("Excel_issueInfoViewModel_");
        //        }
        //    }
        //}
        //#endregion

        #region Excel_hifive_StepDownKI_ViewModel_
        private Excel_hifive_stepDown_kiViewModel excel_hifive_StepDownKI_ViewModel_;
        public Excel_hifive_stepDown_kiViewModel Excel_hifive_StepDownKI_ViewModel_
        {
            get { return this.excel_hifive_StepDownKI_ViewModel_; }
            set
            {
                if (this.excel_hifive_StepDownKI_ViewModel_ != value)
                {
                    this.excel_hifive_StepDownKI_ViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_hifive_StepDownKI_ViewModel_");
                }
            }
        }
        #endregion

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_interface");
                xmlWriter.WriteElementString("excel_type", "excel_stepDownKICustom");
                xmlWriter.WriteStartElement("excel_stepDownKICustom");

                this.excel_issueInfoViewModel_.buildXml(xmlWriter);
                this.excel_underlyingCalcInfoViewModel_.buildXml(xmlWriter);

                //여기서 이걸로 픽싱시킴 그래서 얘만 gen됨.
                // 밑에서 받을때는 excel_hifive_subtype으로 받아야함
                this.excel_hifive_StepDownKI_ViewModel_.buildXml(xmlWriter);

                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            
        }

        public override void buildPricingXml(System.Xml.XmlWriter xmlWriter)
        {
            //아무짓 안함, 위에 buildXml에서 나온놈을 쓸거임
            
        }

        public override void setFromXml(System.Xml.XmlNode node)
        {
            // 로딩만 가능
            
        }

        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            //Excel_stepDownKICustomView view = this.view_ as Excel_stepDownKICustomView;
            //view.clear();

            FpmlSerializedCSharp.Excel_interface serial_Excel_interface = serial_Class as FpmlSerializedCSharp.Excel_interface;
            FpmlSerializedCSharp.Excel_stepDownKICustom serial_Excel_stepDownKICustom = serial_Excel_interface.Excel_stepDownKICustom_;

            FpmlSerializedCSharp.Excel_issueInfo serial_excel_issueInfo = serial_Excel_stepDownKICustom.Excel_issueInfo_;
            string excel_issueInfotype = serial_excel_issueInfo.Excel_type_.ValueStr;
            this.excel_issueInfoViewModel_ = Excel_issueInfoViewModel.CreateExcel_issueInfo(excel_issueInfotype);
            this.excel_issueInfoViewModel_.setFromSerial(serial_excel_issueInfo);

            FpmlSerializedCSharp.Excel_underlyingCalcInfo serial_excel_underlyingCalcInfo = serial_Excel_stepDownKICustom.Excel_underlyingCalcInfo_;
            //this.excel_underlyingCalcInfoViewModel_ = new Excel_underlyingCalcInfoViewModel();
            this.excel_underlyingCalcInfoViewModel_.setFromSerial(serial_excel_underlyingCalcInfo);

            FpmlSerializedCSharp.Excel_hifive_subtype serial_excel_hifive_subtype = serial_Excel_stepDownKICustom.Excel_hifive_subtype_;
            //string excel_hifive_subtypetype = serial_excel_hifive_subtype.Excel_Type_.ValueStr;
            //this.excel_hifive_StepDownKI_ViewModel_ = new Excel_hifive_stepDown_kiViewModel();
            this.excel_hifive_StepDownKI_ViewModel_.setFromSerial(serial_excel_hifive_subtype);

            //this.view_ = new Excel_stepDownKICustomView();
            //this.view_.DataContext = this;
            
        }

        public override void bookingEvent(MasterInformationViewModel masterInformationViewModel)
        {
            // 상품이 모두 만들어진 후에 event를 gen 해서 박아넣음

            foreach (var item in this.excel_hifive_StepDownKI_ViewModel_.SubScheduleDataList_)
            {
                EVENT_INFO_Table_DAO dao = new EVENT_INFO_Table_DAO();

                dao.EVENT_DATE_ = item.EventDate_.ToString(DataBaseStringFormat.DateFormat_);
                dao.EVENT_TYPE_ = "settlement";
                dao.EVENT_SUBTYPE_ = "earlyRedemption";
                dao.EVENT_DESCRIPTION_ = "coupon : " + item.Coupon_ + " trigger : " + item.Trigger_;
                dao.EVENT_NAME_ = "중도상환";
                dao.CURRENCY_ = "KRW";

                double amt = Convert.ToDouble(this.excel_issueInfoViewModel_.Notional_) + Convert.ToDouble(this.excel_issueInfoViewModel_.Notional_) * Convert.ToDouble(item.Coupon_) / 100;
                
                dao.EVENT_AMOUNT_ = amt.ToString();
                dao.FIXING_UNDERLYINGS_ = this.excel_underlyingCalcInfoViewModel_.underlyingString();
                dao.FIXING_FLAG_ = "false";
                //dao.OBSERVATION_END_DATE_ = dao.EVENT_DATE_;

                dao.ITEM_CODE_ = masterInformationViewModel.Item_code_;
                dao.ITEM_TYPE_ = masterInformationViewModel.Booking_type_;
                dao.ITEM_NAME_ = masterInformationViewModel.Item_name_;
                dao.REMAIN_NOTIONAL_ = masterInformationViewModel.Remain_notional_;

                dao.insert(DataBaseConnectManager.ConnectionFactory("myDB"));
            }
                
        }

        public override System.Windows.Controls.Control view()
        {
            Control v = new Excel_stepDownKICustomView();

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
