using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_compositeOptionViewModel : Excel_interfaceViewModel
    {
        public Excel_compositeOptionViewModel() 
        {
            this.excel_issueInfoViewModel_ = new Excel_noteInfoViewModel();

            this.notionalMaturityPayment_ = "100.0";

            this.excel_issueInfoViewModel_.PropertyChanged += excerciseDateUpdate;

            this.excel_underlyingCalcInfoViewModel_ = new Excel_underlyingCalcInfoViewModel();

            this.excel_underlyingCalcInfoViewModel_.EffectiveDate_ = this.excel_issueInfoViewModel_.EffectiveDate_;

            this.excel_issueInfoViewModel_.PropertyChanged +=
                this.excel_underlyingCalcInfoViewModel_.issueInfoObserver;

            //this.excel_underlyingCalcInfoViewModel_.PropertyChanged
            //    += this.assetNumberObserver;

            this.excel_compositeOption_subtypeViewModelList_ = 
                new ObservableCollection<Excel_compositeOption_subtypeViewModel>();

            //this.view_ = new Excel_compositeOptionView();
            //this.view_.DataContext = this;
        }

        public void excerciseDateUpdate(object sender, PropertyChangedEventArgs e)
        { 
            Excel_issueInfoViewModel e_ivm = sender as Excel_issueInfoViewModel;

            if (e.PropertyName == "MaturityDate_")
            {
                this.ExerciseDate_ = e_ivm.MaturityDate_;
                this.PayoffDate_ = e_ivm.MaturityDate_;
            }

        }

        #region ExerciseDate_
        protected DateTime exerciseDate_;
        public DateTime ExerciseDate_
        {
            get { return this.exerciseDate_; }
            set
            {
                if (this.exerciseDate_ != value)
                {
                    this.exerciseDate_ = value;
                    this.NotifyPropertyChanged("ExerciseDate_");
                }
            }
        }
        #endregion

        #region PayoffDate_
        private DateTime payoffDate_;
        public DateTime PayoffDate_
        {
            get { return this.payoffDate_; }
            set
            {
                if (this.payoffDate_ != value)
                {
                    this.payoffDate_ = value;
                    this.NotifyPropertyChanged("PayoffDate_");
                }
            }
        }
        #endregion

        #region NotionalMaturityPayment_
        private string notionalMaturityPayment_;
        public string NotionalMaturityPayment_
        {
            get { return this.notionalMaturityPayment_; }
            set
            {
                if (this.notionalMaturityPayment_ != value)
                {
                    this.notionalMaturityPayment_ = value;
                    this.NotifyPropertyChanged("NotionalMaturityPayment_");
                }
            }
        }
        #endregion

        #region Excel_compositeOption_subtypeViewModelList_
        private ObservableCollection<Excel_compositeOption_subtypeViewModel> excel_compositeOption_subtypeViewModelList_;
        public ObservableCollection<Excel_compositeOption_subtypeViewModel> Excel_compositeOption_subtypeViewModelList_
        {
            get { return this.excel_compositeOption_subtypeViewModelList_; }
            set
            {
                if (this.excel_compositeOption_subtypeViewModelList_ != value)
                {
                    this.excel_compositeOption_subtypeViewModelList_ = value;
                    this.NotifyPropertyChanged("Excel_compositeOption_subtypeViewModelList_");
                }
            }
        }
        #endregion

        //#region Excel_scheduleListViewModel_ 이거 사용해야대나 굳이..
        //private Excel_scheduleListViewModel excel_scheduleListViewModel_;
        //public Excel_scheduleListViewModel Excel_scheduleListViewModel_
        //{
        //    get { return this.excel_scheduleListViewModel_; }
        //    set
        //    {
        //        if (this.excel_scheduleListViewModel_ != value)
        //        {
        //            this.excel_scheduleListViewModel_ = value;
        //            this.NotifyPropertyChanged("Excel_scheduleListViewModel_");
        //        }
        //    }
        //}
        //#endregion
        
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_interface");
                xmlWriter.WriteElementString("excel_type" , "excel_compositeOption");
                xmlWriter.WriteStartElement("excel_compositeOption");

                    xmlWriter.WriteElementString("exerciseDate", this.exerciseDate_.ToString(StringFormat.XmlDateFormat_));
                    xmlWriter.WriteElementString("payoffDate", this.payoffDate_.ToString(StringFormat.XmlDateFormat_));

                    xmlWriter.WriteElementString("notionalMaturityPayment", ( Convert.ToDouble(this.notionalMaturityPayment_) /100.0 ).ToString() );

                    excel_issueInfoViewModel_.buildXml(xmlWriter);
                    
                    excel_underlyingCalcInfoViewModel_.buildXml(xmlWriter);

                    foreach (var item in this.excel_compositeOption_subtypeViewModelList_)
                    {
                        item.ExerciseDate_ = this.exerciseDate_;
                        item.buildXml(xmlWriter);    
                    }
                    
                    //excel_scheduleListViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }

        public override void buildPricingXml(XmlWriter xmlWriter)
        {
            
        }

        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_interface serial_Excel_interface = serial_Class as FpmlSerializedCSharp.Excel_interface;
            FpmlSerializedCSharp.Excel_compositeOption serial_Excel_compositeOption = serial_Excel_interface.Excel_compositeOption_;

            FpmlSerializedCSharp.Excel_issueInfo serial_excel_issueInfo = serial_Excel_compositeOption.Excel_issueInfo_;
            string excel_issueInfotype = serial_excel_issueInfo.Excel_type_.ValueStr;
            this.excel_issueInfoViewModel_ = Excel_issueInfoViewModel.CreateExcel_issueInfo(excel_issueInfotype);
            this.excel_issueInfoViewModel_.setFromSerial(serial_excel_issueInfo);

            FpmlSerializedCSharp.Excel_underlyingCalcInfo serial_excel_underlyingCalcInfo = serial_Excel_compositeOption.Excel_underlyingCalcInfo_;
            //this.Excel_underlyingCalcInfoViewModel_ = new Excel_underlyingCalcInfoViewModel();
            this.Excel_underlyingCalcInfoViewModel_.setFromSerial(serial_excel_underlyingCalcInfo);

            this.exerciseDate_ = StringConverter.xmlDateToDateTime(serial_Excel_compositeOption.ExerciseDate_.ValueStr);
            this.payoffDate_ = StringConverter.xmlDateToDateTime(serial_Excel_compositeOption.PayoffDate_.ValueStr);
            this.notionalMaturityPayment_ = ( serial_Excel_compositeOption.NotionalMaturityPayment_.DoubleValue() * 100.0 ).ToString() ;

            List<FpmlSerializedCSharp.Excel_compositeOption_subtype> serial_excel_compositeOption_subtype = serial_Excel_compositeOption.Excel_compositeOption_subtype_;
            this.excel_compositeOption_subtypeViewModelList_ = new ObservableCollection<Excel_compositeOption_subtypeViewModel>();
            foreach (var item in serial_excel_compositeOption_subtype)
            {
                string type = item.Excel_type_.ValueStr;
                Excel_compositeOption_subtypeViewModel viewModel = Excel_compositeOption_subtypeViewModel.CreateExcel_compositeOption_subtype(type);
                viewModel.setFromSerial(item);
                this.excel_compositeOption_subtypeViewModelList_.Add(viewModel);
            }

        }

        public override void bookingEvent(MasterInformationViewModel masterInformationViewModel)
        {
            EVENT_INFO_Table_DAO dao = new EVENT_INFO_Table_DAO();

            foreach (var item in this.excel_compositeOption_subtypeViewModelList_)
            {
                item.bookingEvent(masterInformationViewModel, dao);
            }

            dao.ITEM_CODE_ = masterInformationViewModel.Item_code_;
            dao.ITEM_TYPE_ = masterInformationViewModel.Booking_type_;
            dao.ITEM_NAME_ = masterInformationViewModel.Item_name_;
            dao.REMAIN_NOTIONAL_ = masterInformationViewModel.Remain_notional_;

            dao.insert(DataBaseConnectManager.ConnectionFactory("myDB"));

        }

        public override Control view()
        {
            Control v = new Excel_compositeOptionView();

            v.DataContext = this;

            return v;
        }

        public override void setUnderlying()
        {

            foreach (var item in this.excel_compositeOption_subtypeViewModelList_)
            {
                item.setUnderlying(this.excel_underlyingCalcInfoViewModel_);
            }

            //this.excel_compositeOption_subtypeViewModelList_
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

        public Excel_compositeOptionLoaderView defaultLoaderView()
        {
            Excel_compositeOptionLoaderView subTypeLoaderView;// = new Excel_compositeOptionLoaderView();

            //default;
            Excel_vanillaCallPutViewModel e_vcpvm = new Excel_vanillaCallPutViewModel();

            e_vcpvm.setInterfaceViewModel(this);
            e_vcpvm.DefaultSetting(this);

            subTypeLoaderView = e_vcpvm.loaderView(this);

            subTypeLoaderView.InterfaceViewModel_ = this;

            return subTypeLoaderView;

        }

    }
    
}

