//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Xml;

//namespace RiskMonitor
//{
//    public abstract class InstrumentBase
//    {
//        public string ItemCode_ { get; set; }
//        public bool IsCalculated_ { get; set; }

//        //public DateTime ReferenceDate_ { get; set; }
//        //public Instrument Instrument_ { get; set; }
//        public Parameter Parameter_ { get; set; }
//        public ResultModel Result_ { get; set; }

//        public XmlDocument InstXml_ { get; set; }
//        public XmlDocument ResultParametorXml_ { get; set; }

//        //각각에 맞는 엔진을 적용하여 계산함 
//        public abstract void calculate();
//        //public void batchCalculate(string instXml, string resultXml)
//        //{ 
            
//        //}

//        //Insrument Xml을 만들어냄. From Instrument_로 부터
//        // build하는 동시에 save함.

//        public abstract void instrumentFromXml(XmlNode instNode);

//        //한파일에 묶여 있음 이 두개는
//        public abstract void parameterFromXml(XmlNode resultparaXml);
//        public abstract void resultFromXml(XmlNode resultparaXml);

        
//    }
//}
