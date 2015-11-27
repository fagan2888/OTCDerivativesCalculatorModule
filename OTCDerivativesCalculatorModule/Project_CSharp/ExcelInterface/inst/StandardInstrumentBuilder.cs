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
    public class StandardInstrumentBuilder : InstrumentBuilder 
    {
        private ReferenceCalFactory referenceCalFactory_;

        #region IssueInfomation_
        private IssueInformation issueInformation_;
        public IssueInformation IssueInfomation_
        {
            get { return this.issueInformation_; }
            set
            {
                if (this.issueInformation_ != value)
                {
                    this.issueInformation_ = value;
                }
            }
        }
        #endregion

        #region EventTriggerList_
        private ObservableCollection<EventTriggerXL> eventTriggerList_;
        public ObservableCollection<EventTriggerXL> EventTriggerList_
        {
            get { return this.eventTriggerList_; }
            set
            {
                if (this.eventTriggerList_ != value)
                {
                    this.eventTriggerList_ = value;
                    //this.NotifyPropertyChanged("EventTriggerList_");
                }
            }
        }
        #endregion

        #region IndexList_
        private ObservableCollection<IndexXL> indexList_;
        public ObservableCollection<IndexXL> IndexList_
        {
            get { return this.indexList_; }
            set
            {
                if (this.indexList_ != value)
                {
                    this.indexList_ = value;
                }
            }
        }
        #endregion

        #region NoteInfoVM
        private NoteInfoViewModel noteInfoVM_;
        public NoteInfoViewModel NoteInfoVM
        {
            get { return this.noteInfoVM_; }
            set
            {
                if (this.noteInfoVM_ != value)
                {
                    this.noteInfoVM_ = value;
                }
            }
        }
        #endregion

        public StandardInstrumentBuilder()
        {
            this.indexList_ = new ObservableCollection<IndexXL>();
            this.eventTriggerList_ = new ObservableCollection<EventTriggerXL>();
            this.referenceCalFactory_ = new ReferenceCalFactory();
        }

        private const int issueInfoNum_ = 5;
        public int setIssueInformation(string[] array)
        {
            this.noteInfoVM_ = new NoteInfoViewModel();

            if (array.Length != issueInfoNum_)
            {
                throw new Exception("array length must be 5 , array Length = " + array.Length);
            }

            string tradeDate = array[0];
            string effectiveDate = array[1];
            string maturityDate = array[2];
            string notional = array[3];
            string premium = array[4];

            noteInfoVM_.TradeDate_ = array[0];
            noteInfoVM_.EffectiveDate_ = array[1];
            noteInfoVM_.MaturityDate_ = array[2];
            noteInfoVM_.Notional_ = array[3];
            noteInfoVM_.Premium_ = array[4];

            return 0;
        }

        public string addIndexUnderInfo(string type, string[] array)
        {
            try
            {
                //stockIndexUnderInfo
                if (type.ToUpper() == "STOCKINDEX")
                {
                    this.addStockIndexUnderInfo(array);
                }
                else if (type.ToUpper() == "IRINDEX") //IRIndexUnderInfo
                {

                }
                else
                {
                    throw new Exception("unknown indexUnderInfo type : " + type);

                }
            }
            catch (Exception e)
            {
                errStr_ += e.Message + "\n";
                this.errNum_ += 1;
            }

            return errStr_; 
        }

        private const int stockIndexNum_ = 4;
        public void addStockIndexUnderInfo(string[] array)
        {
            
            if (array.Length != 4)
            {
                string err = "";

                err += "StockIndexUnderInfo , array length must be 4 , input array Length = " + array.Length;
                err += "parametor : type , krCode, name , basePrice";
                err += "example : stockIndex , KR02930211, LG , 54000";

                throw new Exception(err);
            }

            string type = array[0];
            string krCode = array[1];
            string name = array[2];
            string basePrice = array[3];

            try
            {
                this.indexList_.Add(
                    new StockIndexXL(type, krCode, name, basePrice));
            }
            catch (Exception e)
            {
                errStr_ += "stockIndex Error : " + e.Message;
                this.errNum_ += 1;
            }

        }

        private const int irIndexNum_ = 5;
        public void addIRIndexUnderInfo(string[] array)
        {
            if (array.Length != 4)
            {
                string err = "";

                err += "IRIndexUnderInfo , array length must be 4 , input array Length = " + array.Length;
                err += "parametor : type , krCode, name , tenor";
                err += "example : IRIndexUnderInfo , CD91AAA, CD91AAA , 3M";

                throw new Exception(err);

            }

            string type = array[0];
            string krCode = array[1];
            string name = array[2];
            string tenor = array[3];

            try
            {
                this.indexList_.Add(
                new InterestRateIndex(type, krCode, name, tenor));
            }
            catch (Exception e)
            {
                errStr_ += "IRIndexUnderInfo Error : " + e.Message;
                this.errNum_ += 1;
            }

        }

        //----------------------------------------------------------------
        //reference를 계산하는 방법에 사용할 것
        //넣은다음 나중에 빼내서 사용할 때 날짜만 setting해서 사용한다던지
        //뭐 그런것.

        public string addReferenceID(string calculationType, string[] array)
        {
            return this.referenceCalFactory_.addReferenceID(calculationType, array);
        }

        public string addUnderlyingSet(string id, string[] array)
        {
            try
            {
                if (id == "" || id == null)
                {
                    throw new Exception("underSetID can't be null");
                }

                ObservableCollection<string> underList = new ObservableCollection<string>();

                foreach (var item in array)
                {
                    if (item != "")
                    {
                        underList.Add(item);
                    }
                }
                this.referenceCalFactory_.UnderlyingSet_.Add(id,underList);
            }
            catch (Exception e)
            {
                errStr_ += e.Message + "\n";
                this.errNum_ += 1;
            }

            return errStr_; 
        }

        //-----------------------------------------------------------------
        // type을 구분해서 더함 얘가 사용할 수 있는것
        public string addSchedule(string type, string[] array)
        {
            try
            {
                //addSimpleRangeConstCoupon
                if (type.ToUpper() == "SIMPLERANGECONSTCOUPON")
                {
                    this.addSimpleRangeConstCoupon(array);
                }
                //simpleKiBarrerCoupon
                else if (type.ToUpper() == "SIMPLEKIBARRERCOUPON")
                {
                    this.addSimpleKIBarrierCoupon(array);
                }
                //multiRangeAccrualRate
                else if (type.ToUpper() == "MULTIRANGEACCRUALRATE")
                {
                    this.addMultiRangeAccrualRate(array);
                }
                //else if (type == "")
                //{

            //}
                else
                {
                    throw new Exception("unknown schedule type : " + type);

                }
            }
            catch (Exception e)
            {
                ErrorManager.setError(e);
                this.errStr_ += e.Message + "\n";
                this.errNum_ += 1;

            }

            return errStr_;
        }

        private const int simpleRangeConstCouponNum_ = 16;
        private void addSimpleRangeConstCoupon(string[] array)
        {
            if (array.Length != 16)
            {
                throw  new Exception("array length must be 16 , array Length = " + array.Length);
            }

            string eventDate = array[0];
            string payoffDate = array[1];
            
            string lowerTrigger = array[2];
            string lowerEquality = array[3];
            string referenceID = array[4];
            //string referenceSet = array[5];
            string upperEquality = array[5];
            string upperTrigger = array[6];
            string constReturn = array[7];

            string autoCallable = array[8];
            
            if ( autoCallable.ToUpper() == "TRUE" || autoCallable.ToUpper() == "T" )
            {
                string lowerTrigger_autoCall = array[9];
                string lowerEquality_autoCall = array[10];
                string referenceID_autoCall = array[11];
                string upperEquality_autoCall = array[12];
                string upperTrigger_autoCall = array[13];
                string autoCallConstReturn = array[14];

                SimpleRangeConstCoupon srcc = new SimpleRangeConstCoupon(eventDate,
                                                                        payoffDate,
                                                                        lowerTrigger,
                                                                        lowerEquality,
                                                                        referenceID,
                                                                        upperEquality,
                                                                        upperTrigger,
                                                                        constReturn,
                                                                        autoCallable,
                                                                        lowerTrigger_autoCall,
                                                                        lowerEquality_autoCall,
                                                                        referenceID_autoCall,
                                                                        upperEquality_autoCall,
                                                                        upperTrigger_autoCall,
                                                                        autoCallConstReturn);

                srcc.ReferenceCalFactory_ = this.referenceCalFactory_;

                srcc.buildVM();

                this.eventTriggerList_.Add(srcc);
            }
            else 
            {

                SimpleRangeConstCoupon srcc = new SimpleRangeConstCoupon(eventDate,
                                                                        payoffDate,
                                                                        lowerTrigger,
                                                                        lowerEquality,
                                                                        referenceID,
                                                                        upperEquality,
                                                                        upperTrigger,
                                                                        constReturn,
                                                                        autoCallable);

                srcc.ReferenceCalFactory_ = this.referenceCalFactory_;

                srcc.buildVM();

                this.eventTriggerList_.Add(srcc);
            }

        }

        private const int multiRangeAccrualRateNum_ = 17;
        private void addMultiRangeAccrualRate(string[] array)
        {
            if (array.Length != 17)
            {
                throw new Exception("array length must be 17 , array Length = " + array.Length);
            }

            string eventDate = array[0];
            string payoffDate = array[1];

            string lowerTrigger = array[2];
            string lowerEquality = array[3];
            string referenceID = array[4];
            string referenceSet = array[5];
            string upperEquality = array[6];
            string upperTrigger = array[7];
            string constReturn = array[8];

            string autoCallable = array[9];

            if (autoCallable.ToUpper() == "TRUE" || autoCallable.ToUpper() == "T")
            {
                string lowerTrigger_autoCall = array[10];
                string lowerEquality_autoCall = array[11];
                string referenceID_autoCall = array[12];
                string referenceSet_autoCall = array[13];
                string upperEquality_autoCall = array[14];
                string upperTrigger_autoCall = array[15];
                string autoCallConstReturn = array[16];


                SimpleRangeConstCoupon srcc = new SimpleRangeConstCoupon(eventDate,
                                                                        payoffDate,
                                                                        lowerTrigger,
                                                                        lowerEquality,
                                                                        referenceID,
                                                                        upperEquality,
                                                                        upperTrigger,
                                                                        constReturn,
                                                                        autoCallable,
                                                                        lowerTrigger_autoCall,
                                                                        lowerEquality_autoCall,
                                                                        referenceID_autoCall,
                                                                        upperEquality_autoCall,
                                                                        upperTrigger_autoCall,
                                                                        autoCallConstReturn);

                srcc.ReferenceCalFactory_ = this.referenceCalFactory_;

                srcc.buildVM();

                this.eventTriggerList_.Add(srcc);
            }
            else
            {

                SimpleRangeConstCoupon srcc = new SimpleRangeConstCoupon(eventDate,
                                                                        payoffDate,
                                                                        lowerTrigger,
                                                                        lowerEquality,
                                                                        referenceID,
                                                                        upperEquality,
                                                                        upperTrigger,
                                                                        constReturn,
                                                                        autoCallable);

                srcc.ReferenceCalFactory_ = this.referenceCalFactory_;

                srcc.buildVM();

                this.eventTriggerList_.Add(srcc);
            }

        }

        private const int simpleKIBarrierCouponNum_ = 14;
        private void addSimpleKIBarrierCoupon(string[] array)
        {
            if (array.Length != 14)
            {
                throw new Exception("array length must be 17 , array Length = " + array.Length);
            }

            string eventDate = array[0];
            string payoffDate = array[1];

            string observationStartDate = array[2];
            string observationEndDate = array[3];
            string barrierType = array[4];
            string downBarrierTrigger = array[5];
            string referenceCal_downID = array[6];
            string referenceCal_upperID = array[7];
            string upBarrierTrigger = array[8];
            string referenceCal_ID_returnCal = array[9];
            string gearing_returnCal = array[10];
            string spread_returnCal = array[11];
            string constReturn_complement = array[12];
            string autoCallable = array[13];

            SimpleKIBarrierCoupon skbc =
                new SimpleKIBarrierCoupon(eventDate,
                                        payoffDate,
                                        observationStartDate,
                                        observationEndDate,
                                        barrierType,
                                        downBarrierTrigger,
                                        referenceCal_downID,
                                        referenceCal_upperID, 
                                        upBarrierTrigger,
                                        referenceCal_ID_returnCal,
                                        gearing_returnCal,
                                        spread_returnCal,
                                        constReturn_complement);

            skbc.ReferenceCalFactory_ = this.referenceCalFactory_;

            skbc.buildVM();

            this.eventTriggerList_.Add(skbc);

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
                //instrument
                xmlWriter.WriteStartElement("instrument");
                {
                    xmlWriter.WriteStartElement("header");
                        xmlWriter.WriteElementString("productName", "IBK 제2013-004회 OTC");
                        xmlWriter.WriteElementString("krCode", "50202A3B16O0");
                    xmlWriter.WriteEndElement();

                    

                    //instrumentInfo
                    xmlWriter.WriteStartElement("instrumentInfo");
                    {
                        xmlWriter.WriteElementString("type", "standardInstrument");
                        //standardInstrument
                        xmlWriter.WriteStartElement("standardInstrument");
                        {

                            this.noteInfoVM_.buildXml(xmlWriter);

                            xmlWriter.WriteStartElement("underlyingInformation");
                            {
                                xmlWriter.WriteStartElement("indexUnderInfo");

                                if (this.indexList_ == null)
                                {
                                    throw new Exception("indexList is null");
                                }

                                foreach (var item in this.indexList_)
                                {
                                    item.buildXml(xmlWriter);
                                }

                                xmlWriter.WriteEndElement();
                            }
                            xmlWriter.WriteEndElement();

                            //payoffInfo
                            xmlWriter.WriteStartElement("payoffInfo");
                            xmlWriter.WriteElementString("type", "autoCallablePayoff");
                            {
                                xmlWriter.WriteStartElement("autoCallablePayoff");
                                {
                                    xmlWriter.WriteStartElement("eventTriggerList");

                                    if (this.indexList_ == null)
                                    {
                                        throw new Exception("eventTriggerList is null");
                                    }

                                    foreach (var item in this.eventTriggerList_)
                                    {
                                        item.buildXml(xmlWriter);
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            xmlWriter.WriteEndElement();

                        }
                        xmlWriter.WriteEndElement();

                    }
                    xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();
                xmlWriter.Close();

                this.resultStr_ = sb.ToString();
            }

            catch (Exception e)
            {
                errStr_ += " exception message : ";
                errStr_ += e.Message + "\n";
            }

            return errStr_;

        }

        #region getParameterNum
        
        public int underlyingDataNum(string underTypeStr)
        {
            int num = 0;

            try
            {
                if (underTypeStr.ToUpper() == "STOCKINDEX")
                {
                    num = stockIndexNum_;
                }
                else if (underTypeStr.ToUpper() == "IRINDEX")
                {
                    num = irIndexNum_;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            catch (Exception e)
            {
                ErrorManager.setError(e);
                errStr_ += e.Message + "\n";
                this.errNum_ += 1;
            }

            return num;
        }

        public int scheduleDataNum(string scheduleTypeStr)
        {
            int num = 0;

            try
            {
                if (scheduleTypeStr.ToUpper() == "SIMPLERANGECONSTCOUPON")
                {
                    num = simpleRangeConstCouponNum_;
                }
                else if (scheduleTypeStr.ToUpper() == "SIMPLEKIBARRERCOUPON")
                {
                    num = simpleKIBarrierCouponNum_;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            catch (Exception e)
            {
                ErrorManager.setError(e);
                errStr_ += e.Message + "\n";
                this.errNum_ += 1;
            }

            return num;
        }

        public int issueInfoDataNum(string issueTypeStr)
        {
            int num = 0;

            try
            {
                if (issueTypeStr.ToUpper() == "NOTEINFO")
                {
                    num = issueInfoNum_;
                }
                //else if (underTypeStr == "IRINDEX")
                //{
                //    num = irIndexNum_;
                //}
                else
                {
                    throw new NotImplementedException();
                }
            }
            catch (Exception e)
            {
                ErrorManager.setError(e);
                errStr_ += e.Message + "\n";
                this.errNum_ += 1;
            }

            return num;
        }

        public int referenceCalDataNum(string referenceCalTypeStr)
        {
            return this.referenceCalFactory_.referenceCalDataNum(referenceCalTypeStr);
        }

        #endregion





    }
}
