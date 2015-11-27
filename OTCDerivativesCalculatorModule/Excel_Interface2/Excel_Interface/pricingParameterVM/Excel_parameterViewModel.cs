using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

using QLNet;

namespace Excel_Interface
{
    public abstract class Excel_parameterViewModel : IXmlData
    {
        #region IssueDate_
        protected DateTime issueDate_;
        public DateTime IssueDate_
        {
            get { return this.issueDate_; }
            set
            {
                if (this.issueDate_ != value)
                {
                    this.issueDate_ = value;
                    this.NotifyPropertyChanged("IssueDate_");
                }
            }
        }
        #endregion

        #region ReferenceDate_
        protected DateTime referenceDate_;
        public DateTime ReferenceDate_
        {
            get { return this.referenceDate_; }
            set
            {
                if (this.referenceDate_ != value)
                {
                    this.referenceDate_ = value;
                    this.NotifyPropertyChanged("ReferenceDate_");
                }
            }
        }
        #endregion

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

        #region ItemCode_
        private string itemCode_;
        public string ItemCode_
        {
            get { return this.itemCode_; }
            set
            {
                if (this.itemCode_ != value)
                {
                    this.itemCode_ = value;
                    this.NotifyPropertyChanged("ItemCode_");
                }
            }
        }
        #endregion

        #region UnderlyingModelSetting_
        private UnderlyingModelSetting underlyingModelSetting_;
        public UnderlyingModelSetting UnderlyingModelSetting_
        {
            get { return this.underlyingModelSetting_; }
            set
            {
                if (this.underlyingModelSetting_ != value)
                {
                    this.underlyingModelSetting_ = value;
                    this.NotifyPropertyChanged("UnderlyingModelSetting_");
                }
            }
        }
        #endregion

        #region ParameterSettingManager_
        protected ParameterSettingManager parameterSettingManager_;
        public ParameterSettingManager ParameterSettingManager_
        {
            get { return this.parameterSettingManager_; }
            set
            {
                if (this.parameterSettingManager_ != value)
                {
                    this.parameterSettingManager_ = value;
                    this.NotifyPropertyChanged("ParameterSettingManager_");
                }
            }
        }
        #endregion

        #region SimulationNum_
        protected string simulationNum_;
        public string SimulationNum_
        {
            get { return this.simulationNum_; }
            set
            {
                if (this.simulationNum_ != value)
                {
                    this.simulationNum_ = value;
                    this.NotifyPropertyChanged("SimulationNum_");
                }
            }
        }
        #endregion

        public Excel_parameterViewModel() 
        {
            this.simulationNum_ = "10000"; //default;

            if (this.underlyingModelSetting_ == null)
            { 
                //default setting
                this.underlyingModelSetting_ = ProgramVariable.UnderlyingModelSetting_;
            }
        }
        
        #region Excel_workBookType_
        private string excel_workBookType_;
        public string Excel_workBookType_
        {
            get { return this.excel_workBookType_; }
            set
            {
                if (this.excel_workBookType_ != value)
                {
                    this.excel_workBookType_ = value;
                    this.NotifyPropertyChanged("Excel_workBookType_");
                }
            }
        }
        #endregion

        #region Excel_resultViewModel_
        private Excel_resultViewModel excel_resultViewModel_;
        public Excel_resultViewModel Excel_resultViewModel_
        {
            get { return this.excel_resultViewModel_; }
            set
            {
                if (this.excel_resultViewModel_ != value)
                {
                    this.excel_resultViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_resultViewModel_");
                }
            }
        }
        #endregion

        public abstract void instrumentEventObserver(object sender, PropertyChangedEventArgs e);
        public abstract void masterEventObserver(object sender, PropertyChangedEventArgs e);
        public virtual void dicountCurveEventObserver(object sender, PropertyChangedEventArgs e)
        { 
        
        }

        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void buildPricingXml(XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);

        public virtual void calculate(Excel_instrumentViewModel e_inst)
        {
            string productXmlStr = e_inst.Excel_interfaceViewModel_.productXml(true);
            string parameterXmlStr = this.paraXml(false);
            
            //DateTime tradeDate = e_inst.MasterInformationViewModel_.Trade_date_;
            DateTime effectiveDate = e_inst.Excel_interfaceViewModel_.Excel_issueInfoViewModel_.EffectiveDate_;
            // < date , value > //
            //string underHistData = this.historyUnderData(effectiveDate, false);

            string underHistData = e_inst.Excel_interfaceViewModel_.Excel_underlyingCalcInfoViewModel_.historyUnderData(effectiveDate,this.referenceDate_, false);

            string calculationType = e_inst.MasterInformationViewModel_.Booking_type_.ToUpper();

            string result = "not calculated";

            try
            {
                result = CalculationModuleDLL.calculationLibCall(calculationType,
                                                               productXmlStr,
                                                               parameterXmlStr,
                                                               underHistData,
                                                               this.referenceDate_
                                                               );

                this.loadResult(e_inst,result);

            }
            catch (Exception e )
            {
                result = "dll error : " + e.Message;

                OutputLogViewModel.addResult(result);

                throw;
            }
            

            //string result = "empty";
            
            //try
            //{
            //    MessageManager messageManager = new MessageManager();

            //    messageManager.loadServerInformation();

            //    MessageViewModel mvm = new MessageViewModel();
                
            //    GridCalculationViewModel gcvm = MessageBodyViewModel.CreateMessageBody("gridCalculation") as GridCalculationViewModel;

            //    gcvm.mergeSetXml(productXmlStr, parameterXmlStr, underHistData);

            //    mvm.TargetCode_ = "gridCalculation";
            //    mvm.MessageBodyViewModel_ = gcvm;

            //    messageManager.send(mvm);

            //    //result = CalculationModuleDLL.calculationLibCall(calculationType,
            //    //                                                        productXmlStr,
            //    //                                                        parameterXmlStr,
            //    //                                                        underHistData
            //    //                                                        );
            //}
            //catch (Exception)
            //{
            //    result = "dll error";
            //}

        }

        public void loadResult(Excel_instrumentViewModel e_inst,string result)
        {
            this.excel_resultViewModel_.Notional_ =
                e_inst.Excel_interfaceViewModel_.Excel_issueInfoViewModel_.Notional_;

            this.excel_resultViewModel_.loadResultXml(result);
        }

        public void saveXml()
        {
            XMLFileLoader.SaveParameter(this.itemCode_, this.paraXml(), this.referenceDate_);
        }

        public string paraXml(bool bodyOnly = false)
        {
            //XmlDocument InstXml = new XmlDocument();

            StringBuilder sb = new StringBuilder();
            XmlWriterSettings setting = new XmlWriterSettings();

            setting.Indent = true;
            //setting.Encoding = Encoding.UTF8;
            
            if (bodyOnly == true)
                setting.OmitXmlDeclaration = true;

            XmlWriter xmlWriter = XmlWriter.Create(sb, setting);
            
            xmlWriter.WriteProcessingInstruction("xml", "version='1.0' encoding='UTF-8'");

            xmlWriter.WriteStartElement("pricing");

                xmlWriter.WriteElementString("evaluationTime", this.referenceDate_.ToString("yyyy-MM-dd"));
                
                this.buildXml(xmlWriter);
                //this.buildPricingXml(xmlWriter);

            xmlWriter.WriteEndElement();

            xmlWriter.Close();

            //InstXml.LoadXml(sb.ToString());

            return sb.ToString();
        }

        //public static Excel_parameterViewModel CreateExcel_parameter(string typeStr)
        //{
        //    if ( typeStr == "excel_standardPara")
        //    {
        //        return new Excel_standardParaViewModel();
        //    }
        //    else
        //    {
        //    throw new NotImplementedException();
        //    }
        //}

        //public static Excel_parameterViewModel CreateExcel_parameter(FpmlSerializedCSharp.ISerialized serial_Class)
        //{
        //    FpmlSerializedCSharp.Excel_parameter serial_Excel_parameter = serial_Class as FpmlSerializedCSharp.Excel_parameter;
        //    string typeStr = serial_Excel_parameter.Type_.ValueStr;
        //    return Excel_parameterViewModel.CreateExcel_parameter(typeStr);
        //}

        // < date , value > //

        //public abstract string historyUnderData(DateTime startDate, bool bodyOnly = false);




        // 최초에 xml을 만들때만 db를 통해서 만들고
        // 그 이후에 과거 para를 로드한다던가 할때는 xml만하고만 작업함.
        // 라이브로 할때는 직접 db와 대화함.
        //public void loadParameterFromXml()
        //{
        //    XmlDocument xmlDoc = XMLFileLoader.LoadParameter(this.itemCode_, this.referenceDate_);

        //    //XmlNode paraNode = xmlDoc.SelectSingleNode("
        //    XmlNode resultNode = xmlDoc.SelectSingleNode("pricing/pricingResult");

        //    this.excel_resultViewModel_.setFromXml(resultNode);

        //}

        public abstract Control view();

        public abstract void loadMarketData(DateTime referenceDate);

        public abstract void buildParaSetting(ParameterSettingManager paraSettingManager);
    }
    
}

