using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_multiAssetCompositeOptionViewModel : Excel_interfaceViewModel
    {
    
        public Excel_multiAssetCompositeOptionViewModel() 
        {
            this.excel_issueInfoViewModel_ = new Excel_noteInfoViewModel();

            this.notionalMaturityPayment_ = "100.0";

            this.excel_issueInfoViewModel_.PropertyChanged += excerciseDateUpdate;

            this.excel_underlyingCalcInfoViewModel_ = new Excel_underlyingCalcInfoViewModel();

            this.excel_underlyingCalcInfoViewModel_.EffectiveDate_ = this.excel_issueInfoViewModel_.EffectiveDate_;

            this.excel_underlyingCalcInfoViewModel_.PropertyChanged +=
                        this.underlyingUpdated;

            this.excel_multiAsset_compositeOption_subtypeViewModel_
                = new ObservableCollection<Excel_multiAsset_compositeOption_subtypeViewModel>();

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

        #region Excel_multiAsset_compositeOption_subtypeViewModel_
        private ObservableCollection<Excel_multiAsset_compositeOption_subtypeViewModel> excel_multiAsset_compositeOption_subtypeViewModel_;
        public ObservableCollection<Excel_multiAsset_compositeOption_subtypeViewModel> Excel_multiAsset_compositeOption_subtypeViewModel_
        {
            get { return this.excel_multiAsset_compositeOption_subtypeViewModel_; }
            set
            {
                if (this.excel_multiAsset_compositeOption_subtypeViewModel_ != value)
                {
                    this.excel_multiAsset_compositeOption_subtypeViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_multiAsset_compositeOption_subtypeViewModel_");
                }
            }
        }
        #endregion
        
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_interface");
                xmlWriter.WriteElementString("excel_type" , "excel_multiAssetCompositeOption");
                xmlWriter.WriteStartElement("excel_multiAssetCompositeOption");
                    excel_issueInfoViewModel_.buildXml(xmlWriter);
                    
                    excel_underlyingCalcInfoViewModel_.buildXml(xmlWriter);

                    xmlWriter.WriteElementString("exerciseDate", this.exerciseDate_.ToString(StringFormat.XmlDateFormat_));
                    xmlWriter.WriteElementString("payoffDate", this.payoffDate_.ToString(StringFormat.XmlDateFormat_));

                    xmlWriter.WriteElementString("notionalMaturityPayment", ( Convert.ToDouble(this.notionalMaturityPayment_) /100.0 ).ToString() );

                    foreach (var item in excel_multiAsset_compositeOption_subtypeViewModel_)
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
            FpmlSerializedCSharp.Excel_interface serial_Excel_interface = serial_Class as FpmlSerializedCSharp.Excel_interface;
            FpmlSerializedCSharp.Excel_multiAssetCompositeOption serial_Excel_multiAssetCompositeOption = serial_Excel_interface.Excel_multiAssetCompositeOption_;
        
            FpmlSerializedCSharp.Excel_issueInfo serial_excel_issueInfo = serial_Excel_multiAssetCompositeOption.Excel_issueInfo_;
            string excel_issueInfotype = serial_excel_issueInfo.Excel_type_.ValueStr;
            this.excel_issueInfoViewModel_ = Excel_issueInfoViewModel.CreateExcel_issueInfo(excel_issueInfotype);
            this.excel_issueInfoViewModel_.setFromSerial(serial_excel_issueInfo);
            
            FpmlSerializedCSharp.Excel_underlyingCalcInfo serial_excel_underlyingCalcInfo = serial_Excel_multiAssetCompositeOption.Excel_underlyingCalcInfo_;
            this.excel_underlyingCalcInfoViewModel_.setFromSerial(serial_excel_underlyingCalcInfo);

            this.exerciseDate_ = StringConverter.xmlDateToDateTime(serial_Excel_multiAssetCompositeOption.ExerciseDate_.ValueStr);
            this.payoffDate_ = StringConverter.xmlDateToDateTime(serial_Excel_multiAssetCompositeOption.PayoffDate_.ValueStr);
            this.notionalMaturityPayment_ = (serial_Excel_multiAssetCompositeOption.NotionalMaturityPayment_.DoubleValue() * 100.0).ToString();

            List<FpmlSerializedCSharp.Excel_multiAsset_compositeOption_subtype> serial_excel_multiAsset_compositeOption_subtype = serial_Excel_multiAssetCompositeOption.Excel_multiAsset_compositeOption_subtype_;
            this.excel_multiAsset_compositeOption_subtypeViewModel_ = new ObservableCollection<Excel_multiAsset_compositeOption_subtypeViewModel>();
            foreach (var item in serial_excel_multiAsset_compositeOption_subtype)
            {
                string type = item.Excel_type_.ValueStr;
                Excel_multiAsset_compositeOption_subtypeViewModel viewModel = Excel_multiAsset_compositeOption_subtypeViewModel.CreateExcel_multiAsset_compositeOption_subtype(type);
                viewModel.setFromSerial(item);
                this.excel_multiAsset_compositeOption_subtypeViewModel_.Add(viewModel);
            }
            
        }

        public override void buildPricingXml(XmlWriter xmlWriter)
        {
            xmlWriter.WriteElementString("implemented", "not yet");
        }

        public void underlyingUpdated(object sender, PropertyChangedEventArgs e) 
        {
            Excel_underlyingCalcInfoViewModel e_ucivm = sender as Excel_underlyingCalcInfoViewModel;

            foreach (var item in this.excel_multiAsset_compositeOption_subtypeViewModel_)
            {
                item.setUnderlying(e_ucivm);
            }
        }

        public override void bookingEvent(MasterInformationViewModel masterInformationViewModel)
        {
            EVENT_INFO_Table_DAO dao = new EVENT_INFO_Table_DAO();

            foreach (var item in this.excel_multiAsset_compositeOption_subtypeViewModel_)
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
            Control v = new Excel_multiAssetCompositeOptionView();

            v.DataContext = this;

            return v;
        }

        public override void setUnderlying()
        {
            foreach (var item in this.excel_multiAsset_compositeOption_subtypeViewModel_)
            {
                item.setUnderlying(this.excel_underlyingCalcInfoViewModel_);
            }
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

        public Excel_multiAssetCompositeOptionLoaderView defaultLoaderView()
        {
            Excel_multiAssetCompositeOptionLoaderView subTypeLoaderView;// = new Excel_compositeOptionLoaderView();

            //default;
            Excel_multiAsset_vanillaCallPutViewModel e_mvcpvm = new Excel_multiAsset_vanillaCallPutViewModel();

            e_mvcpvm.DefaultSetting(this);
            e_mvcpvm.setInterfaceViewModel(this);

            e_mvcpvm.setUnderlying(this.excel_underlyingCalcInfoViewModel_);

            subTypeLoaderView = e_mvcpvm.loaderView(this);

            subTypeLoaderView.InterfaceViewModel_ = this;

            subTypeLoaderView.Excel_underlyingCalcInfoViewModel_ = this.excel_underlyingCalcInfoViewModel_;

            return subTypeLoaderView;
        }
    }
    
}

