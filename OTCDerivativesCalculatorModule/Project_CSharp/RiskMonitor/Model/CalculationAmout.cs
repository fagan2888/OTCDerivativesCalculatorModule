using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace RiskMonitor
{
    public  class CalculationAmount
    {
        // 이거 밖으로 빼야 할지도 모름.
        // meta data 형식으로 가면 빼야함.

        public enum Type { KRW,USD,EUR }

        public static CalculationAmount CreateCalculationAmount(XmlNode node)
        {
            return CalculationAmount.CreateCalculationAmount(Type.KRW, 1);
        }

        public static CalculationAmount CreateCalculationAmount(Type type, double value)
        {
            switch (type)
	        {
                case CalculationAmount.Type.KRW :
                    return new KRWCurrency(value);

		        default:
                    throw new Exception("Unknown Currncy");
	        }
            
        }

        public CalculationAmount(string name, double value)
        {
            this.Name_ = name;
            this.Value_ = value;
        }

        public double Value_ { get; private set; }
        public string Name_{ get; private set;}
        public string Code_ { get; private set; }

        public QLNet.YieldTermStructure NumericYield_ { get; set; }
        public QLNet.YieldTermStructure DeNumericYield_ { get; set; }

    }
}
