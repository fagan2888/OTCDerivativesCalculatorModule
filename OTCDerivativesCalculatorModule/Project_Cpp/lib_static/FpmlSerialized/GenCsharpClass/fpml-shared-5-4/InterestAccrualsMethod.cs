using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class InterestAccrualsMethod
    {
        public InterestAccrualsMethod(XmlNode xmlNode)
        {
            XmlNodeList floatingRateCalculationNodeList = xmlNode.SelectNodes("floatingRateCalculation");
            if (floatingRateCalculationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in floatingRateCalculationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        floatingRateCalculationIDRef = item.Attributes["id"].Name;
                        FloatingRateCalculation ob = FloatingRateCalculation();
                        IDManager.SetID(floatingRateCalculationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        floatingRateCalculationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        floatingRateCalculation = new FloatingRateCalculation(item);
                    }
                }
            }
            
        
            XmlNodeList fixedRateNodeList = xmlNode.SelectNodes("fixedRate");
            if (fixedRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fixedRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fixedRateIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(fixedRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fixedRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fixedRate = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
        }
        
    
        #region FloatingRateCalculation
        private FloatingRateCalculation floatingRateCalculation;
        public FloatingRateCalculation FloatingRateCalculation
        {
            get
            {
                if (this.floatingRateCalculation != null)
                {
                    return this.floatingRateCalculation; 
                }
                else if (this.floatingRateCalculationIDRef != null)
                {
                    floatingRateCalculation = IDManager.getID(floatingRateCalculationIDRef) as FloatingRateCalculation;
                    return this.floatingRateCalculation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.floatingRateCalculation != value)
                {
                    this.floatingRateCalculation = value;
                }
            }
        }
        #endregion
        
        public string FloatingRateCalculationIDRef { get; set; }
        #region FixedRate
        private XsdTypeDecimal fixedRate;
        public XsdTypeDecimal FixedRate
        {
            get
            {
                if (this.fixedRate != null)
                {
                    return this.fixedRate; 
                }
                else if (this.fixedRateIDRef != null)
                {
                    fixedRate = IDManager.getID(fixedRateIDRef) as XsdTypeDecimal;
                    return this.fixedRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fixedRate != value)
                {
                    this.fixedRate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

