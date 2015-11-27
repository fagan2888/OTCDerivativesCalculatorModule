using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace CSharpCodeGen
{
    public class FlatRateEnum
    {
        public FlatRateEnum(XmlNode xmlNode)
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
    public double IntValue() { return Convert.ToInt32(valueStr); }
    public double DecimalValue() { return Convert.ToDecimal(valueStr); }
    public double BooleanValue() { return Convert.ToBoolean(valueStr); }
    public double DateTimeValue() { return Convert.ToDateTime(valueStr); }
    


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

