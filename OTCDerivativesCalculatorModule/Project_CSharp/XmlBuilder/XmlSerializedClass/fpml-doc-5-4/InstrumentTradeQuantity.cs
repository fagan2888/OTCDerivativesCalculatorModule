using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class InstrumentTradeQuantity : ISerialized
    {
        public InstrumentTradeQuantity(XmlNode xmlNode)
        {
            XmlNode numberNode = xmlNode.SelectSingleNode("number");
            
            if (numberNode != null)
            {
                if (numberNode.Attributes["href"] != null || numberNode.Attributes["id"] != null) 
                {
                    if (numberNode.Attributes["id"] != null) 
                    {
                        numberIDRef_ = numberNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(numberNode);
                        IDManager.SetID(numberIDRef_, ob);
                    }
                    else if (numberNode.Attributes["href"] != null)
                    {
                        numberIDRef_ = numberNode.Attributes["href"].Value;
                    }
                    else
                    {
                        number_ = new XsdTypeDecimal(numberNode);
                    }
                }
                else
                {
                    number_ = new XsdTypeDecimal(numberNode);
                }
            }
            
        
            XmlNode nominalNode = xmlNode.SelectSingleNode("nominal");
            
            if (nominalNode != null)
            {
                if (nominalNode.Attributes["href"] != null || nominalNode.Attributes["id"] != null) 
                {
                    if (nominalNode.Attributes["id"] != null) 
                    {
                        nominalIDRef_ = nominalNode.Attributes["id"].Value;
                        Money ob = new Money(nominalNode);
                        IDManager.SetID(nominalIDRef_, ob);
                    }
                    else if (nominalNode.Attributes["href"] != null)
                    {
                        nominalIDRef_ = nominalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        nominal_ = new Money(nominalNode);
                    }
                }
                else
                {
                    nominal_ = new Money(nominalNode);
                }
            }
            
        
        }
        
    
        #region Number_
        private XsdTypeDecimal number_;
        public XsdTypeDecimal Number_
        {
            get
            {
                if (this.number_ != null)
                {
                    return this.number_; 
                }
                else if (this.numberIDRef_ != null)
                {
                    number_ = IDManager.getID(numberIDRef_) as XsdTypeDecimal;
                    return this.number_; 
                }
                else
                {
                      return this.number_; 
                }
            }
            set
            {
                if (this.number_ != value)
                {
                    this.number_ = value;
                }
            }
        }
        #endregion
        
        public string numberIDRef_ { get; set; }
        #region Nominal_
        private Money nominal_;
        public Money Nominal_
        {
            get
            {
                if (this.nominal_ != null)
                {
                    return this.nominal_; 
                }
                else if (this.nominalIDRef_ != null)
                {
                    nominal_ = IDManager.getID(nominalIDRef_) as Money;
                    return this.nominal_; 
                }
                else
                {
                      return this.nominal_; 
                }
            }
            set
            {
                if (this.nominal_ != value)
                {
                    this.nominal_ = value;
                }
            }
        }
        #endregion
        
        public string nominalIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

