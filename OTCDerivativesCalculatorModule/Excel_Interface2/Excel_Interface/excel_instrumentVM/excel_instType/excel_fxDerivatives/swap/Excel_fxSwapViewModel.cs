using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_fxSwapViewModel : Excel_interfaceViewModel
    {
        public Excel_fxSwapViewModel() 
        {
            this.fx_exchangeLegViewModel_ = new ObservableCollection<Fx_exchangeLegViewModel>();

            Fx_exchangeLegViewModel firstLeg = new Fx_exchangeLegViewModel();
            firstLeg.ExchangeType_ = "Buy";

            Fx_exchangeLegViewModel secondLeg = new Fx_exchangeLegViewModel();
            firstLeg.ExchangeType_ = "Sell";

            this.fx_exchangeLegViewModel_.Add(firstLeg);
            this.fx_exchangeLegViewModel_.Add(secondLeg);
        }

        #region Fx_exchangeLegViewModel_
        private ObservableCollection<Fx_exchangeLegViewModel> fx_exchangeLegViewModel_;
        public ObservableCollection<Fx_exchangeLegViewModel> Fx_exchangeLegViewModel_
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
                xmlWriter.WriteElementString("excel_type", "excel_fxSwap");
                xmlWriter.WriteStartElement("excel_fxSwap");
                    excel_issueInfoViewModel_.buildXml(xmlWriter);

                    // 세개 이상이면 안댐
                    foreach (var item in fx_exchangeLegViewModel_)
                    {
                        item.buildXml(xmlWriter);   
                    }

                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }

        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }

        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            //FpmlSerializedCSharp.Excel_interface serial_Excel_interface = serial_Class as FpmlSerializedCSharp.Excel_interface;
            //FpmlSerializedCSharp.Excel_fxSwap serial_Excel_fxSwap = serial_Excel_interface.Excel_fxSwap_;

            //FpmlSerializedCSharp.Excel_issueInfo serial_excel_issueInfo = serial_Excel_fxSwap.Excel_issueInfo_;
            //string excel_issueInfotype = serial_excel_issueInfo.Type_.ValueStr;
            //this.excel_issueInfoViewModel_ = Excel_issueInfoViewModel.CreateExcel_issueInfo(excel_issueInfotype);
            //this.excel_issueInfoViewModel_.setFromSerial(serial_excel_issueInfo);

            //List<FpmlSerializedCSharp.Fx_exchangeLeg> serial_fx_exchangeLeg = serial_Excel_fxSwap.Fx_exchangeLeg_;
            //this.fx_exchangeLegViewModel_ = new ObservableCollection<Fx_exchangeLegViewModel>();
            //foreach (var item in serial_fx_exchangeLeg)
            //{
            //    string type = item.Type_.ValueStr;
            //    Fx_exchangeLegViewModel viewModel = Fx_exchangeLegViewModel.CreateFx_exchangeLeg(type);
            //    viewModel.setFromSerial(item);
            //    this.fx_exchangeLegViewModel_.Add(viewModel);
            //}

            //this.view_ = new Excel_fxSwapView();
            //this.view_.DataContext = this;
        }

        public override void buildPricingXml(XmlWriter xmlWriter)
        {
            
        }

        public override void bookingEvent(MasterInformationViewModel masterInformationViewModel)
        {
            {
                EVENT_INFO_Table_DAO daoFirst = new EVENT_INFO_Table_DAO();

                this.fx_exchangeLegViewModel_[0].bookingEvent(masterInformationViewModel, daoFirst);

                daoFirst.ITEM_CODE_ = masterInformationViewModel.Item_code_;
                daoFirst.ITEM_TYPE_ = masterInformationViewModel.Booking_type_;
                daoFirst.ITEM_NAME_ = masterInformationViewModel.Item_name_;
                daoFirst.REMAIN_NOTIONAL_ = masterInformationViewModel.Remain_notional_;
            }

            {
                EVENT_INFO_Table_DAO daoSecond = new EVENT_INFO_Table_DAO();

                this.fx_exchangeLegViewModel_[0].bookingEvent(masterInformationViewModel, daoSecond);

                daoSecond.ITEM_CODE_ = masterInformationViewModel.Item_code_;
                daoSecond.ITEM_TYPE_ = masterInformationViewModel.Booking_type_;
                daoSecond.ITEM_NAME_ = masterInformationViewModel.Item_name_;
                daoSecond.REMAIN_NOTIONAL_ = masterInformationViewModel.Remain_notional_;
            }
        }

        public override Control view()
        {
            Control v = new Excel_fxSwapView();

            v.DataContext = this;

            return v;
        }

        public override void setUnderlying()
        {
            throw new NotImplementedException();
        }

        //public override List<CurrencyViewModel> currencyList()
        //{
        //    List<CurrencyViewModel> currList = new List<CurrencyViewModel>();

        //    currList.Add(this.excel_issueInfoViewModel_.Currency_);

        //    return currList;
        //}

        public override List<CurrencyViewModel> currencyList()
        {
            throw new NotImplementedException();
        }

        public override void buildFromTradeString(TradeString tradeString)
        {
            throw new NotImplementedException();
        }
    }

}

