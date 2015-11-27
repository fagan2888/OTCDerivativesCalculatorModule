//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Xml;

//namespace RiskMonitor
//{
//    public abstract class Parameter : IXmlData
//    {

        
//        //public UnderlyingParaInfo UnderlyingParaInfo_ { get; set; }
//        //public DiscountFactor DiscountFactor_ { get; set; }
        

//        //Live로 받을때 쓸려고 만듬.
//        //그냥 xml을 빌드하고 로드하는 방식?은 안댈듯 class 개념이 꼬임..
//        //어차피 빌드방식은 개개 class가 가지고 있음 ( 왜냐면 개개 class에 depend하므로)

//        protected abstract void setReferenceDate(DateTime value);

//        public void loadParameterSetting(string settingStr)
//        {
//            this.ParameterSetting_ = ParameterSetting.createSetting(settingStr);
//        }



//        public abstract void loadParameter();
//        public abstract void saveParameter();

//        public abstract void buildXml(XmlWriter xmlWriter);
//        public abstract void setFromXml(XmlNode InstNode);
//        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
//    }
//}
