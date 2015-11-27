using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_hifiveViewModel : Excel_interfaceViewModel
    {
        public Excel_hifiveViewModel() 
        {
            this.excel_issueInfoViewModel_ = new Excel_noteInfoViewModel();
            this.excel_underlyingCalcInfoViewModel_ = new Excel_underlyingCalcInfoViewModel();

            this.excel_underlyingCalcInfoViewModel_.EffectiveDate_ = this.excel_issueInfoViewModel_.EffectiveDate_;

            this.excel_issueInfoViewModel_.PropertyChanged +=
                this.excel_underlyingCalcInfoViewModel_.issueInfoObserver;

            this.excel_underlyingCalcInfoViewModel_.PropertyChanged +=
                this.underlyingAddedObserver;

            //// underlying에다가 이거 등록
            //this.excel_underlyingCalcInfoViewModel_.PropertyChanged +=
            //    new PropertyChangedEventHandler(underlyingPropertyChangeObserver);

            // default로 박을거
            //this.Excel_hifive_subtypeViewModel_ = new Excel_hifive_stepDown_kiViewModel();

            this.excel_scheduleListViewModel_ = new Excel_scheduleListViewModel();

            this.excel_kiEventCalculationViewModel_ = new Excel_simpleKiEventCalcViewModel();
            this.excel_kiEventCalculationViewModel_.defaultSetting();
            //this.excel_kiEventCalculationViewModel_.setUnderlying(this.excel_underlyingCalcInfoViewModel_);

        }

        // subType 이 정해지고 underlying을 바꾸는 경우
        // 다시 schedule을 gen 하기 위함.
        // subType 으로 부터 원래 꺼를 gen하고 만들어내는 상품에 한함.
        public virtual void underlyingAddedObserver(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Excel_underlyingInfoViewModel_" && this.excel_hifive_subtypeViewModel_ != null)
            {
                this.setUnderlying();

                this.updateFromSubType(this.excel_hifive_subtypeViewModel_);
            }
        }

        public override void setUnderlying()
        {
            this.excel_hifive_subtypeViewModel_.setUnderlying(this.excel_underlyingCalcInfoViewModel_);
            this.excel_scheduleListViewModel_.setUnderlying(this.excel_underlyingCalcInfoViewModel_);
            this.excel_kiEventCalculationViewModel_.setUnderlying(this.excel_underlyingCalcInfoViewModel_);
        }
        
        // sub Type 즐겨찾기용
        #region Excel_hifive_subtypeViewModel_
        private Excel_hifive_subtypeViewModel excel_hifive_subtypeViewModel_;
        public Excel_hifive_subtypeViewModel Excel_hifive_subtypeViewModel_
        {
            get { return this.excel_hifive_subtypeViewModel_; }
            set
            {
                if (this.excel_hifive_subtypeViewModel_ != value)
                {
                    this.excel_hifive_subtypeViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_hifive_subtypeViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_scheduleListViewModel_
        private Excel_scheduleListViewModel excel_scheduleListViewModel_;
        public Excel_scheduleListViewModel Excel_scheduleListViewModel_
        {
            get { return this.excel_scheduleListViewModel_; }
            set
            {
                if (this.excel_scheduleListViewModel_ != value)
                {
                    this.excel_scheduleListViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_scheduleListViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_kiEventCalculationViewModel_
        private Excel_kiEventCalculationViewModel excel_kiEventCalculationViewModel_;
        public Excel_kiEventCalculationViewModel Excel_kiEventCalculationViewModel_
        {
            get { return this.excel_kiEventCalculationViewModel_; }
            set
            {
                if (this.excel_kiEventCalculationViewModel_ != value)
                {
                    this.excel_kiEventCalculationViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_kiEventCalculationViewModel_");
                }
            }
        }
        #endregion

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_interface");
                xmlWriter.WriteElementString("excel_type" , "excel_hifive");
                xmlWriter.WriteStartElement("excel_hifive");
                    excel_issueInfoViewModel_.buildXml(xmlWriter);
                    
                    excel_underlyingCalcInfoViewModel_.buildXml(xmlWriter);

                    if (excel_hifive_subtypeViewModel_ == null)
                    {
                        xmlWriter.WriteStartElement("excel_hifive_subtype");
                            xmlWriter.WriteElementString("excel_type", "empty");
                        xmlWriter.WriteEndElement();
                    }
                    else 
                    {
                        excel_hifive_subtypeViewModel_.buildXml(xmlWriter);
                    }
                    
                    
                    excel_scheduleListViewModel_.buildXml(xmlWriter);

                    excel_kiEventCalculationViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();

        }

        public override void buildPricingXml(System.Xml.XmlWriter xmlWriter) 
        {
            //xmlWriter.WriteStartElement("instrumentInfo");
            //    xmlWriter.WriteElementString("type", "standardInstrument");
            //    xmlWriter.WriteStartElement("standardInstrument");

            //    this.excel_issueInfoViewModel_.vmBuildFromExcel_interface();

            //    excel_issueInfoViewModel_.buildPricingXml(xmlWriter);

            //    excel_underlyingCalcInfoViewModel_.buildPricingXml(xmlWriter);

            //    excel_hifive_subtypeViewModel_.buildPricingXml(xmlWriter);

            //xmlWriter.WriteEndElement();
        }

        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        //load part임
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_interface serial_Excel_interface = serial_Class as FpmlSerializedCSharp.Excel_interface;
            FpmlSerializedCSharp.Excel_hifive serial_Excel_hifive = serial_Excel_interface.Excel_hifive_;

            FpmlSerializedCSharp.Excel_issueInfo serial_excel_issueInfo = serial_Excel_hifive.Excel_issueInfo_;
            string excel_issueInfotype = serial_excel_issueInfo.Excel_type_.ValueStr;
            this.excel_issueInfoViewModel_ = Excel_issueInfoViewModel.CreateExcel_issueInfo(excel_issueInfotype);
            this.excel_issueInfoViewModel_.setFromSerial(serial_excel_issueInfo);

            FpmlSerializedCSharp.Excel_underlyingCalcInfo serial_excel_underlyingCalcInfo = serial_Excel_hifive.Excel_underlyingCalcInfo_;
            //이미 있음 Linked 된게
            //this.excel_underlyingCalcInfoViewModel_ = new Excel_underlyingCalcInfoViewModel();
            this.excel_underlyingCalcInfoViewModel_.setFromSerial(serial_excel_underlyingCalcInfo);

            FpmlSerializedCSharp.Excel_hifive_subtype serial_excel_hifive_subtype = serial_Excel_hifive.Excel_hifive_subtype_;
            string excel_hifive_subtypetype = serial_excel_hifive_subtype.Excel_type_.ValueStr;

            if (excel_hifive_subtypetype.ToUpper() != "EMPTY")
            {
                this.excel_hifive_subtypeViewModel_ = Excel_hifive_subtypeViewModel.CreateExcel_hifive_subtype(excel_hifive_subtypetype);
                this.excel_hifive_subtypeViewModel_.setFromSerial(serial_excel_hifive_subtype);
            }

            FpmlSerializedCSharp.Excel_scheduleList serial_excel_scheduleList = serial_Excel_hifive.Excel_scheduleList_;
            this.excel_scheduleListViewModel_ = new Excel_scheduleListViewModel();
            this.excel_scheduleListViewModel_.setFromSerial(serial_excel_scheduleList);

            FpmlSerializedCSharp.Excel_kiEventCalculation serial_excel_kiEventCalculation = serial_Excel_hifive.Excel_kiEventCalculation_;
            string excel_kiEventCalculationtype = serial_excel_kiEventCalculation.Excel_type_.ValueStr;
            this.excel_kiEventCalculationViewModel_ = Excel_kiEventCalculationViewModel.CreateExcel_kiEventCalculation(excel_kiEventCalculationtype);
            this.excel_kiEventCalculationViewModel_.setFromSerial(serial_excel_kiEventCalculation);
            
        }

        ////excel_vm으로 부터 각각의 subType을 만드는 작업
        //public void buildHifive()
        //{

        //    // setting된 정보를 토대로 상품을 만듬
        //    this.excel_hifive_subtypeViewModel_.buildProduct();

        //    this.excel_underlyingCalcIDViewModel_ = this.excel_hifive_subtypeViewModel_.Excel_underlyingCalcIDVMList_;

        //    // 이미 세부 calculation 을 만들 vm은 생성이 되어있음
        //    this.excel_scheduleListViewModel_ = this.excel_hifive_subtypeViewModel_.Excel_scheduleListViewModel_;
        //    this.excel_kiScheduleListViewModel_ = this.excel_hifive_subtypeViewModel_.Excel_kiScheduleListViewModel_;

        //}

        public string testString()
        {
            //XmlDocument InstXml = new XmlDocument();

            StringBuilder sb = new StringBuilder();
            XmlWriterSettings setting = new XmlWriterSettings();

            setting.Indent = true;
            //setting.Encoding = Encoding.UTF8;

            XmlWriter xmlWriter = XmlWriter.Create(sb, setting);

            xmlWriter.WriteProcessingInstruction("xml", "version='1.0' encoding='UTF-8'");


            xmlWriter.WriteStartElement("instrumentInfo");
                xmlWriter.WriteElementString("type", "standardInstrument");
                xmlWriter.WriteStartElement("standardInstrument");

                    this.buildXml(xmlWriter);
            
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();

            xmlWriter.Close();

            //InstXml.LoadXml(sb.ToString());

            return sb.ToString();

        }

        public override void bookingEvent(MasterInformationViewModel masterInformationViewModel)
        {
            foreach (var item in this.excel_scheduleListViewModel_.Excel_scheduleViewModel_)
	        {
                EVENT_INFO_Table_DAO dao = new EVENT_INFO_Table_DAO();

                dao.ITEM_CODE_ = masterInformationViewModel.Item_code_;
                dao.ITEM_TYPE_ = masterInformationViewModel.Booking_type_;
                dao.ITEM_NAME_ = masterInformationViewModel.Item_name_;

                //dao.CALCULATION_TYPE_ = 
                dao.COUNTERPARTY_ = masterInformationViewModel.Counterparty_;
                dao.CURRENCY_ = masterInformationViewModel.Currency_.CurrencyString_;
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
                dao.NOTIONAL_ = masterInformationViewModel.Notional_;
                dao.REMAIN_NOTIONAL_ = masterInformationViewModel.Remain_notional_;

                item.bookingEvent(masterInformationViewModel, dao);

                dao.insert(DataBaseConnectManager.ConnectionFactory("myDB"));
	        }
            
        }

        public override Control view()
        {
            Control v = new Excel_hifiveView();

            v.DataContext = this;

            return v;
        }

        public override List<CurrencyViewModel> currencyList()
        {
            List<CurrencyViewModel> currList = new List<CurrencyViewModel>();

            currList.Add(this.excel_issueInfoViewModel_.Currency_);

            return currList;
        }

        public void refreshUnderlyingUpdate()
        {
            this.setUnderlying();

        }

        public void updateFromSubType(Excel_hifive_subtypeViewModel e_h_h_s_kvm)
        {
            //e_h_slv.SelectedViewModel_.descriptionUpdate();
            e_h_h_s_kvm.excel_scheduleListVMBuild();
            this.Excel_scheduleListViewModel_.setScheduleFromClone(e_h_h_s_kvm.Excel_scheduleListViewModel_);

            this.Excel_hifive_subtypeViewModel_ = e_h_h_s_kvm;

            e_h_h_s_kvm.excel_kiEventCalculationBuild();

            this.Excel_kiEventCalculationViewModel_ = e_h_h_s_kvm.Excel_kiEventCalculationViewModel_;

            this.setUnderlying();

            // gen된 schedule을 기준으로 maturity를 조정함.
            int lastCount = this.Excel_scheduleListViewModel_.Excel_scheduleViewModel_.Count;

            this.Excel_issueInfoViewModel_.EffectiveDate_ =
                this.Excel_hifive_subtypeViewModel_.EffectiveDate_;

            this.Excel_issueInfoViewModel_.MaturityDate_ =
                this.Excel_scheduleListViewModel_.Excel_scheduleViewModel_[lastCount - 1].PayoffDate_;
        }


        public override void buildFromTradeString(TradeString tradeString)
        {
            string typeStr = tradeString.InstType_;

            //this.excel_issueInfoViewModel_.Notional_ = tradeString.Notional_;
            this.excel_issueInfoViewModel_.Notional_ = "10000";
            this.excel_issueInfoViewModel_.Currency_ = CurrencyViewModel.CreateCurrencyComboViewModel("KRW");

            this.excel_underlyingCalcInfoViewModel_.buildFromTradeString(tradeString);

            this.excel_hifive_subtypeViewModel_ = Excel_hifive_subtypeViewModel.CreateExcel_hifive_subtype(typeStr);

            this.excel_hifive_subtypeViewModel_.EffectiveDate_ = StringConverter.xmlDateToDateTime(tradeString.EffectiveDate_);

            this.excel_hifive_subtypeViewModel_.ProductString_ = tradeString.ProductString_;

            this.excel_hifive_subtypeViewModel_.scheduleDataGenerate();

            this.excel_hifive_subtypeViewModel_.Excel_underlyingCalcInfoViewModel_ 
                = this.Excel_underlyingCalcInfoViewModel_;

            //this.Excel_issueInfoViewModel_.EffectiveDate_ = this.excel_hifive_subtypeViewModel_.EffectiveDate_ = ;
            //this.excel_hifive_subtypeViewModel_.MaturityDate_ = this.Excel_issueInfoViewModel_.MaturityDate_;

            this.updateFromSubType(this.excel_hifive_subtypeViewModel_);
        }
    }
    
}

