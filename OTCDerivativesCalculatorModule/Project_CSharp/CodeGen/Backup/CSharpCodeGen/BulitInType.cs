using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace CSharpCodeGen
{
    class XsdTypeDate
    {
        public XsdTypeDate(XmlNode xmlNode) 
        {
            if (xmlNode.Value != null)
            {
                this.valueStr = xmlNode.Value;
            }
            else 
            {
                throw new Exception();
            }
        }
        public string StringValue() { return valueStr; }
        public double DoubleValue() { return Convert.ToDouble(valueStr); }
        public int IntValue()
        {
            return Convert.ToInt32(valueStr);
        }
        
        public Decimal DecimalValue()
        {
            return Convert.ToDecimal(valueStr);
        }

        
        




        #region ValueStr
        private string valueStr;
        public string ValueStr
        {
            get { return this.valueStr; }
            set
            {
                if (this.valueStr != value)
                {
                    this.valueStr = value;
                    //this.RaisePropertyChanged("ValueStr");
                }
            }
        }
        #endregion
    }
}
