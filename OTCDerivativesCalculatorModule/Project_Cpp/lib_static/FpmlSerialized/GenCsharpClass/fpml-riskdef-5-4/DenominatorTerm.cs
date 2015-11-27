using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class DenominatorTerm
    {
        public DenominatorTerm(XmlNode xmlNode)
        {
            XmlNodeList weightedPartialNodeList = xmlNode.SelectNodes("weightedPartial");
            if (weightedPartialNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in weightedPartialNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        weightedPartialIDRef = item.Attributes["id"].Name;
                        WeightedPartialDerivative ob = WeightedPartialDerivative();
                        IDManager.SetID(weightedPartialIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        weightedPartialIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        weightedPartial = new WeightedPartialDerivative(item);
                    }
                }
            }
            
        
            XmlNodeList powerNodeList = xmlNode.SelectNodes("power");
            if (powerNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in powerNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        powerIDRef = item.Attributes["id"].Name;
                        XsdTypePositiveInteger ob = XsdTypePositiveInteger();
                        IDManager.SetID(powerIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        powerIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        power = new XsdTypePositiveInteger(item);
                    }
                }
            }
            
        
        }
        
    
        #region WeightedPartial
        private WeightedPartialDerivative weightedPartial;
        public WeightedPartialDerivative WeightedPartial
        {
            get
            {
                if (this.weightedPartial != null)
                {
                    return this.weightedPartial; 
                }
                else if (this.weightedPartialIDRef != null)
                {
                    weightedPartial = IDManager.getID(weightedPartialIDRef) as WeightedPartialDerivative;
                    return this.weightedPartial; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.weightedPartial != value)
                {
                    this.weightedPartial = value;
                }
            }
        }
        #endregion
        
        public string WeightedPartialDerivativeIDRef { get; set; }
        #region Power
        private XsdTypePositiveInteger power;
        public XsdTypePositiveInteger Power
        {
            get
            {
                if (this.power != null)
                {
                    return this.power; 
                }
                else if (this.powerIDRef != null)
                {
                    power = IDManager.getID(powerIDRef) as XsdTypePositiveInteger;
                    return this.power; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.power != value)
                {
                    this.power = value;
                }
            }
        }
        #endregion
        
        public string XsdTypePositiveIntegerIDRef { get; set; }
        
    
        
    
    }
    
}

