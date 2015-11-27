using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class IndexChange
    {
        public IndexChange(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList indexFactorNodeList = xmlNode.SelectNodes("indexFactor");
            if (indexFactorNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in indexFactorNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        indexFactorIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(indexFactorIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        indexFactorIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        indexFactor = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList factoredCalculationAmountNodeList = xmlNode.SelectNodes("factoredCalculationAmount");
            if (factoredCalculationAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in factoredCalculationAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        factoredCalculationAmountIDRef = item.Attributes["id"].Name;
                        Money ob = Money();
                        IDManager.SetID(factoredCalculationAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        factoredCalculationAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        factoredCalculationAmount = new Money(item);
                    }
                }
            }
            
        
        }
        
    
        #region IndexFactor
        private XsdTypeDecimal indexFactor;
        public XsdTypeDecimal IndexFactor
        {
            get
            {
                if (this.indexFactor != null)
                {
                    return this.indexFactor; 
                }
                else if (this.indexFactorIDRef != null)
                {
                    indexFactor = IDManager.getID(indexFactorIDRef) as XsdTypeDecimal;
                    return this.indexFactor; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.indexFactor != value)
                {
                    this.indexFactor = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region FactoredCalculationAmount
        private Money factoredCalculationAmount;
        public Money FactoredCalculationAmount
        {
            get
            {
                if (this.factoredCalculationAmount != null)
                {
                    return this.factoredCalculationAmount; 
                }
                else if (this.factoredCalculationAmountIDRef != null)
                {
                    factoredCalculationAmount = IDManager.getID(factoredCalculationAmountIDRef) as Money;
                    return this.factoredCalculationAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.factoredCalculationAmount != value)
                {
                    this.factoredCalculationAmount = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        
    
        
    
    }
    
}

