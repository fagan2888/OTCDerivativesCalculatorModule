using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    // 상속 받은 클래스

    // Excel_instrument_hifiveViewModel
    // Excel_instrument_stepDownKICustomViewModel 
    public class Excel_instrumentViewModel
    {
        #region Trade_id_
        public string Trade_id_
        {
            get 
            {
                return this.masterInformationViewModel_.Trade_id_;
                //return this.tradeID_; 
            }
            set
            {

                if (this.masterInformationViewModel_.Trade_id_ != value)
                {
                    this.masterInformationViewModel_.Trade_id_ = value;
                    this.NotifyPropertyChanged("Trade_id_");
                }
            }
        }
        #endregion

        #region ItemCode_
        public string Item_code_
        {
            get
            {
                return this.masterInformationViewModel_.Item_code_;
                //return this.item_code_; 
            }
            set
            {
                if (this.masterInformationViewModel_.Item_code_ != value)
                {
                    this.masterInformationViewModel_.Item_code_ = value;
                    this.NotifyPropertyChanged("Item_code_");
                }
            }
        }
        #endregion
        
        private bool bookingMode_;
        protected string booking_type_;
        private XmlDocument inst_xmlDoc_;
        private XmlDocument para_xmlDoc_;

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

        void createSub()
        {
            //Excel_instrument_hifiveViewModel a;
            //Excel_instrument_stepDownKICustomViewModel b;
            //Excel_instrument_generalViewModel c;
            //Excel_instrument_compositeOptionViewModel d;
        }

        public Excel_instrumentViewModel(bool bookingMode = false)
        {
            this.bookingMode_ = bookingMode;

            this.excel_profitLossViewModel_ = new Excel_profitLossViewModel();

            this.masterInformationViewModel_ = new MasterInformationViewModel();

            this.masterInformationViewModel_.PropertyChanged += 
                new PropertyChangedEventHandler(masterInformationViewModel_PropertyChanged);

            this.excel_eventManagerViewModel_ = new Excel_eventManagerViewModel();

            //if (bookingMode)
            //{
            //    this.view_ = new Excel_InstrumentBookingView();
            //    this.masterInformationViewModel_.Trade_date_ = DateTime.Now;
            //    this.masterInformationViewModel_.Trade_id_ = CodeClassificationGenerator.CreateTradeID();
            //}
            //else
            //{
                
            //    this.view_ = new Excel_InstrumentView();
            //}

            //this.view_.DataContext = this; 밑으로 내렸음
        }

        protected void bookingModelSetting()
        {
            this.masterInformationViewModel_.Booking_type_ = this.booking_type_;

            this.masterInformationViewModel_.Item_code_
               = CodeClassificationGenerator.CreateItemCode(this.booking_type_);

            this.masterInformationViewModel_.Trade_id_
                = CodeClassificationGenerator.CreateTradeID();
        }

        public void dataContextRefesh()
        {
            // 새로 그림...?

            //this.masterInformationViewModel_.dataContextRefersh();

            //this.view_ = new Excel_InstrumentView();
            //this.view_.DataContext = this;
        }

        void masterInformationViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {

            if (e.PropertyName == "Item_code_")
            {
                //this.trade_id_ = this.masterInformationViewModel_.Trade_id_;
                //this.item_code_ = ((MasterInformationViewModel)sender).Item_code_;

                this.excel_profitLossViewModel_.ExportItemCode_ = this.masterInformationViewModel_.Export_itemcode_;
                this.excel_profitLossViewModel_.TradeID_ = this.masterInformationViewModel_.Trade_id_;
            }
            
        }

        public void linkEventPass()
        {
            //임시

            bool dummy = false;

            if (dummy)
            {
                //code : E0001 event passing under->para
                this.excel_interfaceViewModel_.Excel_underlyingCalcInfoViewModel_.PropertyChanged
                    += this.excel_parameterViewModel_.instrumentEventObserver;
            }

            //this.excel_parameterViewModel_.instrumentEventObserver(
            //    this.excel_interfaceViewModel_.Excel_underlyingCalcInfoViewModel_, new PropertyChangedEventArgs(""));



            //code : E0002 masterEvent passing master->excel_interface
            this.masterInformationViewModel_.PropertyChanged
                += this.excel_interfaceViewModel_.masterEventObserver;

            this.excel_interfaceViewModel_.masterEventObserver(
                this.masterInformationViewModel_, new PropertyChangedEventArgs("Currency_"));

            this.excel_interfaceViewModel_.masterEventObserver(
                this.masterInformationViewModel_, new PropertyChangedEventArgs("Maturity_date_"));

            // 그냥 같은 걸 박음. 잘 안대네.. ㅡ.ㅡ;; 이런 쉬팔
            this.excel_interfaceViewModel_.Excel_issueInfoViewModel_.MaturityDate_
                = this.masterInformationViewModel_.Maturity_date_;

            this.excel_interfaceViewModel_.masterEventObserver(
                this.masterInformationViewModel_, new PropertyChangedEventArgs("Notional_"));

            //code : E0003 masterEvent passing master->excel_profitloss
            this.masterInformationViewModel_.PropertyChanged
                += this.excel_profitLossViewModel_.masterEventObserver;

            this.excel_profitLossViewModel_.masterEventObserver(
                this.masterInformationViewModel_, new PropertyChangedEventArgs("Trade_id_"));

            if (dummy)
            {
                //code : E0004 discountEvent passing interface(swap or bond or other currency)->para discount
                this.excel_interfaceViewModel_.PropertyChanged
                    += this.excel_parameterViewModel_.dicountCurveEventObserver;

            }

            //code : E0005 excel_interface issuedate and maturityDate passing master for update
            //     : master's issue and maturity must subInterval of interface eff , maturity 
            //     : becuase payoff day or trade date initial baseprice.

            this.excel_interfaceViewModel_.Excel_issueInfoViewModel_.PropertyChanged
                += this.masterInformationViewModel_.issueInformationObserver;

        }

        #region instPositionVM or bookingInfoVM

        #endregion

        #region MasterInformationViewModel_
        protected MasterInformationViewModel masterInformationViewModel_;
        public MasterInformationViewModel MasterInformationViewModel_
        {
            get { return this.masterInformationViewModel_; }
            set
            {
                if (this.masterInformationViewModel_ != value)
                {
                    this.masterInformationViewModel_ = value;
                    this.NotifyPropertyChanged("MasterInformationViewModel_");
                }
            }
        }
        #endregion

        #region TradePositionInfoViewModel_
        protected TradePositionInfoViewModel tradePositionInfoViewModel_;
        public TradePositionInfoViewModel TradePositionInfoViewModel_
        {
            get { return this.tradePositionInfoViewModel_; }
            set
            {
                if (this.tradePositionInfoViewModel_ != value)
                {
                    this.tradePositionInfoViewModel_ = value;
                    this.NotifyPropertyChanged("TradePositionInfoViewModel_");
                }
            }
        }
        #endregion

        #region Excel_interfaceViewModel_
        protected Excel_interfaceViewModel excel_interfaceViewModel_;
        public Excel_interfaceViewModel Excel_interfaceViewModel_
        {
            get { return this.excel_interfaceViewModel_; }
            set
            {
                if (this.excel_interfaceViewModel_ != value)
                {
                    this.excel_interfaceViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_interfaceViewModel_");
                }
            }
        }
        #endregion

        #region Excel_parameterViewModel_
        protected Excel_parameterViewModel excel_parameterViewModel_;
        public Excel_parameterViewModel Excel_parameterViewModel_
        {
            get { return this.excel_parameterViewModel_; }
            set
            {
                if (this.excel_parameterViewModel_ != value)
                {
                    this.excel_parameterViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_parameterViewModel_");
                }
            }
        }
        #endregion

        #region Excel_profitLossViewModel_
        protected Excel_profitLossViewModel excel_profitLossViewModel_;
        public Excel_profitLossViewModel Excel_profitLossViewModel_
        {
            get { return this.excel_profitLossViewModel_; }
            set
            {
                if (this.excel_profitLossViewModel_ != value)
                {
                    this.excel_profitLossViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_profitLossViewModel_");
                }
            }
        }
        #endregion

        #region Excel_eventManagerViewModel_
        private Excel_eventManagerViewModel excel_eventManagerViewModel_;
        public Excel_eventManagerViewModel Excel_eventManagerViewModel_
        {
            get { return this.excel_eventManagerViewModel_; }
            set
            {
                if (this.excel_eventManagerViewModel_ != value)
                {
                    this.excel_eventManagerViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_eventManagerViewModel_");
                }
            }
        }
        #endregion
    
        public void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("instrument");
                
                if (this.Trade_id_ == null || this.Trade_id_ == "")
                {
                    this.Trade_id_ = "testCode";
                }

                xmlWriter.WriteElementString("code", this.Trade_id_);

                this.excel_interfaceViewModel_.buildXml(xmlWriter);
                    
            xmlWriter.WriteEndElement();
        }
        
        public void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            //FpmlSerializedCSharp.Instrument serial_Instrument = serial_Class as FpmlSerializedCSharp.Instrument;
        
            //FpmlSerializedCSharp.Header serial_header = serial_Instrument.Header_;
            //string headertype = serial_header.Type_.ValueStr;
            //this.headerViewModel_ = HeaderViewModel.CreateHeader(headertype);
            //this.headerViewModel_.setFromSerial(serial_header);
            
            //FpmlSerializedCSharp.InstPositionInfo serial_instPositionInfo = serial_Instrument.InstPositionInfo_;
            //string instPositionInfotype = serial_instPositionInfo.Type_.ValueStr;
            //this.instPositionInfoViewModel_ = InstPositionInfoViewModel.CreateInstPositionInfo(instPositionInfotype);
            //this.instPositionInfoViewModel_.setFromSerial(serial_instPositionInfo);
            
            //FpmlSerializedCSharp.Excel_interface serial_excel_interface = serial_Instrument.Excel_interface_;
            //string excel_interfacetype = serial_excel_interface.Type_.ValueStr;
            //this.excel_interfaceViewModel_ = Excel_interfaceViewModel.CreateExcel_interface(excel_interfacetype);
            //this.excel_interfaceViewModel_.setFromSerial(serial_excel_interface);
            
            //FpmlSerializedCSharp.InstrumentInfo serial_instrumentInfo = serial_Instrument.InstrumentInfo_;
            //string instrumentInfotype = serial_instrumentInfo.Type_.ValueStr;
            //this.instrumentInfoViewModel_ = InstrumentInfoViewModel.CreateInstrumentInfo(instrumentInfotype);
            //this.instrumentInfoViewModel_.setFromSerial(serial_instrumentInfo);
            
            //this.view_ = new InstrumentView();
            //this.view_.DataContext = this;
        }

        public void bookingInstrument()
        {
            this.masterInformationViewModel_.bookingMasterInfo();

            try
            {
                this.excel_interfaceViewModel_.bookingEvent(this.masterInformationViewModel_);
            }
            catch (Exception e)
            {
                OutputLogViewModel.addResult("bookingEvent error : " + e.Message);
            }
            

            this.excel_profitLossViewModel_.bookingPL();

        }

        public void loadBatchDetailContext()
        {
            string type = this.masterInformationViewModel_.Booking_type_;

            this.excel_interfaceViewModel_ = Excel_InterfaceLoader.Load(type);
            this.excel_interfaceViewModel_.ItemCode_ = this.masterInformationViewModel_.Item_code_;

            this.loadInterfaceVMFromXml();

            this.excel_eventManagerViewModel_ = new Excel_eventManagerViewModel();
            this.excel_eventManagerViewModel_.ItemCode_ = this.masterInformationViewModel_.Item_code_;
            this.excel_eventManagerViewModel_.dbLoad();

        }

        public void loadDetailContext()
        {
            //try
            //{
                string type = this.masterInformationViewModel_.Booking_type_;

                this.excel_interfaceViewModel_ = Excel_InterfaceLoader.Load(type);
                this.excel_interfaceViewModel_.ItemCode_ = this.masterInformationViewModel_.Item_code_;
                //this.excel_interfaceViewModel_.TradeID_ = this.masterInformationViewModel_.Trade_id_;

                this.excel_parameterViewModel_ = Excel_parameterLoader.Load(type);
                this.excel_parameterViewModel_.ItemCode_ = this.masterInformationViewModel_.Item_code_;
                //this.excel_parameterViewModel_.TradeID_ = this.masterInformationViewModel_.Trade_id_;
                this.excel_parameterViewModel_.ReferenceDate_ = RootBookViewModel.rootBookReferenceDate();

                //링크
                //this.linkEventPass();

                this.excel_profitLossViewModel_ = new Excel_profitLossViewModel();
                this.excel_profitLossViewModel_.ItemCode_ = this.masterInformationViewModel_.Item_code_;
                this.excel_profitLossViewModel_.TradeID_ = this.masterInformationViewModel_.Trade_id_;
                this.excel_profitLossViewModel_.ExportItemCode_ = this.masterInformationViewModel_.Export_itemcode_;

                this.loadInterfaceVMFromXml();
                this.loadParameterFromXml();

                // xml이 로드된 후에 setting 함.. xml로드할때 class가 생성되므로..
                this.excel_interfaceViewModel_.setUnderlying();

                //d 나중에 클릭 대면 로드함 왜냐면 DB접속이니까... 느릴까바.. 흐앙
                this.excel_profitLossViewModel_.ReferenceDate_ = RootBookViewModel.rootBookReferenceDate();
                this.excel_profitLossViewModel_.loadBookingInfo();
                //this.excel_profitLossViewModel_.loadNPV();
                //this.excel_profitLossViewModel_.loadTradeEvent();

                this.excel_eventManagerViewModel_ = new Excel_eventManagerViewModel();
                this.excel_eventManagerViewModel_.ItemCode_ = this.masterInformationViewModel_.Item_code_;
                this.excel_eventManagerViewModel_.dbLoad();
            //}
            //catch (Exception e)
            //{
            //    e.Source += "\n" + this.Item_code_;

            //    throw e;
            //}
            
        }

        public void loadInterfaceVMFromXml(XmlDocument xmlDoc = null)
        {
            //this.excel_interfaceViewModel_.loadInterfaceFromXml();

            try
            {

            }
            catch (Exception)
            {
                OutputLogViewModel.addResult(masterInformationViewModel_.Item_name_ + " : Xml invalid!");
            }

            //XmlDocument xmlDoc = XMLFileLoader.LoadInstrument(this.masterInformationViewModel_.Item_code_);
            if (xmlDoc == null)
            {
                this.inst_xmlDoc_ = XMLFileLoader.LoadInstrument(this.masterInformationViewModel_.Item_code_);
            }
            else
            {
                this.inst_xmlDoc_ = xmlDoc;
            }

            try
            {

                FpmlSerializedCSharp.Instrument_Menual xml_instrument 
                    = new FpmlSerializedCSharp.Instrument_Menual(inst_xmlDoc_.SelectSingleNode("instrument"));

                //XmlNode interfaceNode = inst_xmlDoc_.SelectSingleNode("instrument/excel_interface");
                
                //FpmlSerializedCSharp.Excel_interface excel_interface
                //    = new FpmlSerializedCSharp.Excel_interface(interfaceNode);

                if (xml_instrument.Excel_interface_ != null)
                {
                    FpmlSerializedCSharp.Excel_interface excel_interface = xml_instrument.Excel_interface_;
                    this.excel_interfaceViewModel_.setFromSerial(excel_interface);
                }
                else if (xml_instrument.Excel_swapInterface_ != null)
                {
                    FpmlSerializedCSharp.Excel_swapInterface excel_swapInterface = xml_instrument.Excel_swapInterface_;
                    this.excel_interfaceViewModel_.setFromSerial(excel_swapInterface);
                }
                else
                {
                    throw new Exception("interfaceXml is null");
                }

                // 여기서 로드해야할거 같은데... 
                // settle event , termination event
                // settle 된거 라던지... 
                // 임의로 call 할거 라던지..
                // 

                //Event

                //FpmlSerializedCSharp.Excel_interface excel_interface
                //= new FpmlSerializedCSharp.Excel_interface(interfaceNode);

                //this.excel_interfaceViewModel_.setFromSerial(excel_interface);

            }
            catch (Exception e)
            {
                OutputLogViewModel.addResult("interface load error : " + e.Message);

                throw new Exception("interface load error" + " : " + e.Message);
                //OutputLogViewModel.addResult(masterInformationViewModel_.Item_name_ + " : Xml invalid!");

            }

            //this.setFromXml(instNode);


        }

        public void loadParameterFromXml(XmlDocument xmlDoc = null)
        {
            //this.excel_parameterViewModel_.loadParameterFromXml();

            //XmlDocument xmlDoc = XMLFileLoader.LoadParameter(this.masterInformationViewModel_.Item_code_, 
            //                                                 this.excel_parameterViewModel_.ReferenceDate_);

            if (xmlDoc == null)
            {
                this.para_xmlDoc_ = XMLFileLoader.LoadParameter(this.masterInformationViewModel_.Item_code_,
                                                             this.excel_parameterViewModel_.ReferenceDate_);

            }
            else
            {
                this.para_xmlDoc_ = xmlDoc;

            }
            
            try
            {
                if (this.para_xmlDoc_ != null)
                {

                    XmlNode paraNode = this.para_xmlDoc_.SelectSingleNode("pricing/excel_parameter");

                    FpmlSerializedCSharp.Excel_parameter serial_excel_parameter
                        = new FpmlSerializedCSharp.Excel_parameter(paraNode);

                    this.excel_parameterViewModel_.setFromSerial(serial_excel_parameter);

                    XmlNode resultNode = this.para_xmlDoc_.SelectSingleNode("pricing/pricingResult");

                    if (resultNode != null)
                    {
                        FpmlSerializedCSharp.PricingResult serial_pricingResult
                            = new FpmlSerializedCSharp.PricingResult(resultNode);

                        this.excel_parameterViewModel_.Excel_resultViewModel_.setFromSerial(serial_pricingResult);
                    }
                }

            }
            catch (Exception e)
            {
                OutputLogViewModel.addResult("parameter load error : " + e.Message);
            }

        }

        //public ObservableCollection<GreekPositionViewModel> greekPosition()
        //{
        //    return this.excel_parameterViewModel_.greekPosition();
        //}

        public void saveXml()
        {
            throw new NotImplementedException();
        }

        public Control view(bool bookingMode)
        {
            if (bookingMode)
            {
                Control v = new Excel_InstrumentBookingView();

                //this.masterInformationViewModel_.Trade_date_ = DateTime.Now;
                //this.masterInformationViewModel_.Trade_id_ = CodeClassificationGenerator.CreateTradeID();

                v.DataContext = this;

                //this.view_ = v;

                return v;
                
            }
            else
            {
                System.Windows.Controls.Control v = new Excel_InstrumentView();

                v.DataContext = this;

                return v;
            }
        }

        public virtual void calculate(string instCode,DateTime refDate)
        {

            this.inst_xmlDoc_ = XMLFileLoader.LoadInstrument(instCode);
            this.para_xmlDoc_ = XMLFileLoader.LoadParameter(instCode, refDate);

            this.calculateSavedXml(refDate);
        }

        public virtual void calculate() 
        {
            this.Excel_parameterViewModel_.calculate(this);
            
            //string productXmlStr = this.Excel_interfaceViewModel_.productXml();
            //string parameterXmlStr = this.Excel_parameterViewModel_.paraXml();

            //// < date , value > //
            //string underHistData = this.Excel_parameterViewModel_.historyUnderData();

            ////string result = CalculationModuleDLL.calculationLibCall(productXmlStr, parameterXmlStr);
            //string result = CalculationModuleDLL.calculationLibCall(productXmlStr,
            //                                                        parameterXmlStr,
            //                                                        underHistData
            //                                                        );

            ////this.viewModel_.Excel_parameterViewModel_.Excel_resultViewModel_.Price_ = result;

            //this.Excel_parameterViewModel_.loadResult(result);
            //this.viewModel_.Excel_profitLossViewModel_.
        }

        public virtual void calculateSavedXml(DateTime refDate)
        {
            this.loadInterfaceVMFromXml(this.inst_xmlDoc_);

            this.excel_parameterViewModel_.ReferenceDate_ = refDate;

            this.loadParameterFromXml(this.para_xmlDoc_);

            string productXmlStr = this.inst_xmlDoc_.InnerXml;
            string parameterXmlStr = this.para_xmlDoc_.InnerXml;

            //DateTime tradeDate = this.MasterInformationViewModel_.Trade_date_;
            DateTime effectiveDate = this.Excel_interfaceViewModel_.Excel_issueInfoViewModel_.EffectiveDate_;
            // < date , value > //

            //string underHistData = this.excel_parameterViewModel_.historyUnderData(effectiveDate, refDate);
            string underHistData = this.excel_interfaceViewModel_.Excel_underlyingCalcInfoViewModel_.historyUnderData(effectiveDate, refDate);

            //string result = CalculationModuleDLL.calculationLibCall(productXmlStr, parameterXmlStr);
            //string result = CalculationModuleDLL.calculationLibCall("HIFIVE",
            string result = CalculationModuleDLL.calculationLibCall(this.booking_type_,
                                                                    productXmlStr,
                                                                    parameterXmlStr,
                                                                    underHistData,
                                                                    refDate
                                                                    );



            this.excel_parameterViewModel_.loadResult(this,result);

        }

        public virtual string generateParameterXml() 
        {
            return this.excel_parameterViewModel_.paraXml();
        }

        public string mergedXml(DateTime refDate)
        {
            StringBuilder sb = new StringBuilder();

            string productXmlStr = this.inst_xmlDoc_.DocumentElement.OuterXml;   //InnerXml;
            string parameterXmlStr = this.para_xmlDoc_.DocumentElement.OuterXml; //InnerXml;

            DateTime effectiveDate = this.Excel_interfaceViewModel_.Excel_issueInfoViewModel_.EffectiveDate_;
            // < date , value > //

            //string underHistData = this.excel_parameterViewModel_.historyUnderData(effectiveDate, refDate);
            string underHistData = this.excel_interfaceViewModel_.Excel_underlyingCalcInfoViewModel_.historyUnderData(effectiveDate, refDate,true);

            sb.AppendLine(productXmlStr);
            sb.AppendLine(parameterXmlStr);
            sb.AppendLine(underHistData);

            return sb.ToString();
        }

        public virtual void buildParameterFromInstrument(DateTime refDate)
        {
            Excel_parameterViewModel e_pvm = Excel_parameterLoader.Load(this.booking_type_);

            e_pvm.IssueDate_ = this.excel_interfaceViewModel_.Excel_issueInfoViewModel_.EffectiveDate_;

            e_pvm.ReferenceDate_ = refDate;

            e_pvm.ItemCode_ = this.masterInformationViewModel_.Item_code_;

            ParameterSettingManager parameterSettingManager
                = ParameterSettingManagerBuilder.makeParaSettingManager("default", refDate, this);

            e_pvm.buildParaSetting(parameterSettingManager);

            this.excel_parameterViewModel_ = e_pvm;
        }

        public virtual void buildParameterFromInstrumentWithOutData(DateTime refDate)
        {
            Excel_parameterViewModel e_pvm = Excel_parameterLoader.Load(this.booking_type_);

            e_pvm.IssueDate_ = this.excel_interfaceViewModel_.Excel_issueInfoViewModel_.EffectiveDate_;

            e_pvm.ItemCode_ = this.masterInformationViewModel_.Item_code_;

            //ParameterSettingManager parameterSettingManager = new ParameterSettingManager(refDate,this);
            ParameterSettingManager parameterSettingManager 
                = ParameterSettingManagerBuilder.makeParaSettingManager ("default",refDate, this);

            e_pvm.buildParaSetting(parameterSettingManager);

            this.excel_parameterViewModel_ = e_pvm;
        }

        public virtual void bookingFromTradeString(TradeString tradeString)
        { 
            // not implemeted , implement in derived class

            throw new NotImplementedException();

        }

        public void loadMarketData(DateTime refDate)
        {
            this.excel_parameterViewModel_.loadMarketData(refDate);
        }

        public string calculationXml()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.excel_interfaceViewModel_.productXml(true));
            sb.AppendLine(this.excel_parameterViewModel_.paraXml(true));
            
            DateTime effectiveDate = this.Excel_interfaceViewModel_.Excel_issueInfoViewModel_.EffectiveDate_;

            sb.AppendLine(this.excel_interfaceViewModel_.Excel_underlyingCalcInfoViewModel_.historyUnderData(effectiveDate, this.excel_parameterViewModel_.ReferenceDate_,true));

            return sb.ToString();

        }

    }
}
