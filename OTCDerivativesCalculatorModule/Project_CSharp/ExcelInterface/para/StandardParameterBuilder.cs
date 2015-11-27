using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Xml;
using System.Runtime.InteropServices;
using RiskMonitor;

namespace ExcelInterface
{
    public class StandardParameterBuilder : ParameterBuilder
    {

        #region IndexParaListXL_
        private ObservableCollection<IndexParaXL> indexParaListXL_;
        public ObservableCollection<IndexParaXL> IndexParaListXL_
        {
            get { return this.indexParaListXL_; }       
            set
            {
                if (this.indexParaListXL_ != value)
                {
                    this.indexParaListXL_ = value;
                }
            }
        }
        #endregion

        #region CurveParaListXL_
        private ObservableCollection<CurveParaXL> curveParaListXL_;
        public ObservableCollection<CurveParaXL> CurveParaListXL_
        {
            get { return this.curveParaListXL_; }
            set
            {
                if (this.curveParaListXL_ != value)
                {
                    this.curveParaListXL_ = value;
                }
            }
        }
        #endregion

        #region CorrelationParaXL_
        private CorrelationParaXL correlationParaXL_;
        public CorrelationParaXL CorrelationParaXL_
        {
            get { return this.correlationParaXL_; }
            set
            {
                if (this.correlationParaXL_ != value)
                {
                    this.correlationParaXL_ = value;
                }
            }
        }
        #endregion

        public StandardParameterBuilder()
        {
            ErrorManager.clear();
            this.indexParaListXL_ = new ObservableCollection<IndexParaXL>();
            this.curveParaListXL_ = new ObservableCollection<CurveParaXL>();

        }

        public string buildXml()
        {
            StringBuilder sb = new StringBuilder();
            XmlWriterSettings setting = new XmlWriterSettings();

            setting.Indent = true;
            //setting.Encoding = Encoding.UTF8;

            XmlWriter xmlWriter = XmlWriter.Create(sb, setting);

            xmlWriter.WriteProcessingInstruction("xml", "version='1.0' encoding='UTF-8'");

            try
            {
                //pricing
                xmlWriter.WriteStartElement("pricing");
                {
                    xmlWriter.WriteElementString("evaluationTime", this.evaluationTime_);
                    xmlWriter.WriteElementString("itemCode", this.itemCode_);
                    xmlWriter.WriteElementString("itemType", "stepDownKI");

                    //pricingParameter
                    xmlWriter.WriteStartElement("pricingParameter");
                    {
                        Standard_paraViewModel standparaVM = new Standard_paraViewModel();

                        MonteViewModel mvm = new MonteViewModel();
                        mvm.SimulationNum_ = this.simulationNum_.ToString();

                        standparaVM.MethodViewModel_ = mvm;

                        standparaVM.CalculationAmountViewModel_ = new CalculationAmountViewModel();
                        standparaVM.CalculationAmountViewModel_.Amount_ = "10000";
                        standparaVM.CalculationAmountViewModel_.Currency_ = "KRW";

                        standparaVM.UnderlyingInfo_paraViewModel_ = new UnderlyingInfo_paraViewModel();
                        standparaVM.UnderlyingInfo_paraViewModel_.Underlying_paraViewModel_ = new ObservableCollection<Underlying_paraViewModel>();
                        standparaVM.UnderlyingInfo_paraViewModel_.CorrelationInfo_paraViewModel_ = this.correlationParaXL_.ViewModel_;

                        foreach (var item in this.indexParaListXL_)
                        {
                            item.buildXml();
                            standparaVM.UnderlyingInfo_paraViewModel_.Underlying_paraViewModel_.Add(item.ViewModel_);
                        }

                        foreach (var item in this.curveParaListXL_)
                        {
                            item.buildXml();
                            if (item.UsingType_ == "discount")
                            {
                                standparaVM.DiscountCurve_paraViewModel_.
                                    YieldTermstructureViewModel_.Add(((YieldTermstructureXL)item).YieldCurveVM_);
                            }
                        }
                        standparaVM.buildXml(xmlWriter);
                    }
                    xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();
                xmlWriter.Close();

                this.resultStr_ = sb.ToString();
            }
            catch (Exception e)
            {
                string buildXmlErrStr = "err while xml building process , " + e.Message;
                ErrorManager.setError(new Error(buildXmlErrStr));

                errStr_ += buildXmlErrStr + "\n";
                //errStr_ += e.Message + "\n";
            }

            this.buildXmlFlag_ = true;

            return errStr_;

        }

        public string addIndexPara(string type, string[] array)
        {
            try
            {
                //stockIndexUnderInfo
                if (type.ToUpper() == "GEOMETRICBM")
                {
                    this.addGeometricBM(array);
                }
                else if (type == "IRINDEXUNDERINFO") //IRIndexUnderInfo
                {

                }
                else
                {
                    throw new Exception("method addIndexPara : unknown indexUnderInfo type : " + type);

                }
            }
            catch (Exception e)
            {
                ErrorManager.setError(e);
                errStr_ += e.Message + "\n";
                this.errNum_ += 1;
            }

            return errStr_; 
        }

        //using 은 내부에서 나중에 끌어갈때 가져다가 박음
        public string addCurvePara(string[] array, string[] tenorArr, string[] dataArr)
        {
            //curve Type
            string type = array[5];

            try
            {
                //ZeroYield
                if (type.ToUpper() == "ZEROYIELD" ||
                    type.ToUpper() == "FORWARDRATE" ||
                    type.ToUpper() == "DISCOUNT")
                {
                    this.addYieldTermStructurePara(array, tenorArr, dataArr);
                }
                else if (type.ToUpper() == "SURVIVAL")
                {
                    throw new Exception("method addCurvePara : unknown indexUnderInfo type : " + type);
                    //this.addFXTermStructurePara();
                }
                else if (type.ToUpper() == "FX")
                {
                    throw new Exception("method addCurvePara : type \"FX\" does not implemeted");
                    //throw new Exception("unknown indexUnderInfo type : " + type);
                    //this.addFXTermStructurePara();
                }
                else
                {
                    throw new Exception("method addCurvePara : type \"" + type + "\" does not implemeted");
                    //throw new Exception("unknown indexUnderInfo type : " + type);

                }
            }
            catch (Exception e)
            {
                ErrorManager.setError(e);
                errStr_ += e.Message + "\n";
                this.errNum_ += 1;
            }

            return errStr_;
        }
        private const int yieldArrNum_ = 10; 

        private void addYieldTermStructurePara(string[] array, string[] tenorArr, string[] dataArr)
        {

            if (array.Length != yieldArrNum_)
            {
                throw new Exception("method addYieldTermStructurePara : array length must be " + yieldArrNum_ + " , input array Length = " + array.Length);
            }

            string curveID = array[0];
            string curveName = array[1];
            string dataType = array[2];
            string usingType = array[3];
            string detailType = array[4];
            string curveType = array[5];
            string interpolation = array[6];
            string daycounter = array[7];
            string calendar = array[8];
            string businessDC = array[9];

            this.curveParaListXL_.Add(
                new YieldTermstructureXL(curveID,
                                        curveName,
                                        dataType,
                                        usingType,
                                        detailType,
                                        curveType,
                                        interpolation,
                                        daycounter,
                                        calendar,
                                        businessDC,
                                        tenorArr,
                                        dataArr));

            
        }

        private const int geometricBM_ParaNum_ = 6;
        private void addGeometricBM(string[] array)
        {
            if (array.Length != geometricBM_ParaNum_)
            {
                throw new Exception("array length must be " + geometricBM_ParaNum_ + " , array Length = " + array.Length);
            }

            string krCode = array[0];
            string underName = array[1];
            string currentValue = array[2];
            string drift = array[3];
            string dividend = array[4];
            string volatility = array[5];

            this.indexParaListXL_.Add(
                new GeometricBMParaXL(krCode, 
                                    underName, 
                                    currentValue,
                                    drift,
                                    dividend,
                                    volatility));

        }

        private const int IRForwardModel_ParaNum_ = 4;
        private void addIRForwardModel(string[] array)
        {
            
        }

        private void addHullWhite(string[] array)
        {
            throw new NotImplementedException();
        }

        public string setIndexCorrPara(string[] codeList, string[,] matrix)       
        {
            try
            {
                this.correlationParaXL_ = new CorrelationParaXL(codeList, matrix);
            }
            catch (Exception e)
            {
                ErrorManager.setError(e);
                errStr_ += e.Message + "\n";
                this.errNum_ += 1;
            }

            return this.errStr_;
        }

        #region getParameterNum
        public int underlyingParaDataNum(string underParaTypeStr)
        {
            int num = 0;

            if (underParaTypeStr == "geometricBM")
            {
                num = geometricBM_ParaNum_;
            }
            else if (underParaTypeStr == "IRForwardModel")
            {
            }
            else 
            {
                
            }

            return num;
        }

	    #endregion
        
        
    }
}
