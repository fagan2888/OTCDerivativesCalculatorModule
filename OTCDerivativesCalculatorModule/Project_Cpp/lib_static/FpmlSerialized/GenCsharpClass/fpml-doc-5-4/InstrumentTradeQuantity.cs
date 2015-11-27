using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class InstrumentTradeQuantity
    {
        public InstrumentTradeQuantity(XmlNode xmlNode)
        {
            XmlNodeList numberNodeList = xmlNode.SelectNodes("number");
            if (numberNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in numberNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        numberIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(numberIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        numberIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        number = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList nominalNodeList = xmlNode.SelectNodes("nominal");
            if (nominalNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in nominalNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        nominalIDRef = item.Attributes["id"].Name;
                        Money ob = Money();
                        IDManager.SetID(nominalIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        nominalIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        nominal = new Money(item);
                    }
                }
            }
            
        
        }
        
    
        #region Number
        private XsdTypeDecimal number;
        public XsdTypeDecimal Number
        {
            get
            {
                if (this.number != null)
                {
                    return this.number; 
                }
                else if (this.numberIDRef != null)
                {
                    number = IDManager.getID(numberIDRef) as XsdTypeDecimal;
                    return this.number; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.number != value)
                {
                    this.number = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region Nominal
        private Money nominal;
        public Money Nominal
        {
            get
            {
                if (this.nominal != null)
                {
                    return this.nominal; 
                }
                else if (this.nominalIDRef != null)
                {
                    nominal = IDManager.getID(nominalIDRef) as Money;
                    return this.nominal; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.nominal != value)
                {
                    this.nominal = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

