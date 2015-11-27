using System;
using System.Text;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class DayOfWeekEnum : ISerialized
    {
        public DayOfWeekEnum(XmlNode xmlNode)
        {
            if (xmlNode.InnerText != null)
            {
                this.valueStr = xmlNode.InnerText;
            }
            else
            {
                throw new Exception();
            }
        }
    


    public string StringValue() { return valueStr; }
    public double DoubleValue() { return Convert.ToDouble(valueStr); }
    public int IntValue() { return Convert.ToInt32(valueStr); }
    public Decimal DecimalValue() { return Convert.ToDecimal(valueStr); }
    public bool BooleanValue() { return Convert.ToBoolean(valueStr); }
    public DateTime DateTimeValue() { return Convert.ToDateTime(valueStr); }
    


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

