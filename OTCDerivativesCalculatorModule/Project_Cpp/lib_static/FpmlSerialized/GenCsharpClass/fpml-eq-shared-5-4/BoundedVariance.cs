using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class BoundedVariance
    {
        public BoundedVariance(XmlNode xmlNode)
        {
            XmlNodeList realisedVarianceMethodNodeList = xmlNode.SelectNodes("realisedVarianceMethod");
            if (realisedVarianceMethodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in realisedVarianceMethodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        realisedVarianceMethodIDRef = item.Attributes["id"].Name;
                        RealisedVarianceMethodEnum ob = RealisedVarianceMethodEnum();
                        IDManager.SetID(realisedVarianceMethodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        realisedVarianceMethodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        realisedVarianceMethod = new RealisedVarianceMethodEnum(item);
                    }
                }
            }
            
        
            XmlNodeList daysInRangeAdjustmentNodeList = xmlNode.SelectNodes("daysInRangeAdjustment");
            if (daysInRangeAdjustmentNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in daysInRangeAdjustmentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        daysInRangeAdjustmentIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(daysInRangeAdjustmentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        daysInRangeAdjustmentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        daysInRangeAdjustment = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList upperBarrierNodeList = xmlNode.SelectNodes("upperBarrier");
            if (upperBarrierNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in upperBarrierNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        upperBarrierIDRef = item.Attributes["id"].Name;
                        NonNegativeDecimal ob = NonNegativeDecimal();
                        IDManager.SetID(upperBarrierIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        upperBarrierIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        upperBarrier = new NonNegativeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList lowerBarrierNodeList = xmlNode.SelectNodes("lowerBarrier");
            if (lowerBarrierNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in lowerBarrierNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        lowerBarrierIDRef = item.Attributes["id"].Name;
                        NonNegativeDecimal ob = NonNegativeDecimal();
                        IDManager.SetID(lowerBarrierIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        lowerBarrierIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        lowerBarrier = new NonNegativeDecimal(item);
                    }
                }
            }
            
        
        }
        
    
        #region RealisedVarianceMethod
        private RealisedVarianceMethodEnum realisedVarianceMethod;
        public RealisedVarianceMethodEnum RealisedVarianceMethod
        {
            get
            {
                if (this.realisedVarianceMethod != null)
                {
                    return this.realisedVarianceMethod; 
                }
                else if (this.realisedVarianceMethodIDRef != null)
                {
                    realisedVarianceMethod = IDManager.getID(realisedVarianceMethodIDRef) as RealisedVarianceMethodEnum;
                    return this.realisedVarianceMethod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.realisedVarianceMethod != value)
                {
                    this.realisedVarianceMethod = value;
                }
            }
        }
        #endregion
        
        public string RealisedVarianceMethodEnumIDRef { get; set; }
        #region DaysInRangeAdjustment
        private XsdTypeBoolean daysInRangeAdjustment;
        public XsdTypeBoolean DaysInRangeAdjustment
        {
            get
            {
                if (this.daysInRangeAdjustment != null)
                {
                    return this.daysInRangeAdjustment; 
                }
                else if (this.daysInRangeAdjustmentIDRef != null)
                {
                    daysInRangeAdjustment = IDManager.getID(daysInRangeAdjustmentIDRef) as XsdTypeBoolean;
                    return this.daysInRangeAdjustment; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.daysInRangeAdjustment != value)
                {
                    this.daysInRangeAdjustment = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region UpperBarrier
        private NonNegativeDecimal upperBarrier;
        public NonNegativeDecimal UpperBarrier
        {
            get
            {
                if (this.upperBarrier != null)
                {
                    return this.upperBarrier; 
                }
                else if (this.upperBarrierIDRef != null)
                {
                    upperBarrier = IDManager.getID(upperBarrierIDRef) as NonNegativeDecimal;
                    return this.upperBarrier; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.upperBarrier != value)
                {
                    this.upperBarrier = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeDecimalIDRef { get; set; }
        #region LowerBarrier
        private NonNegativeDecimal lowerBarrier;
        public NonNegativeDecimal LowerBarrier
        {
            get
            {
                if (this.lowerBarrier != null)
                {
                    return this.lowerBarrier; 
                }
                else if (this.lowerBarrierIDRef != null)
                {
                    lowerBarrier = IDManager.getID(lowerBarrierIDRef) as NonNegativeDecimal;
                    return this.lowerBarrier; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.lowerBarrier != value)
                {
                    this.lowerBarrier = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeDecimalIDRef { get; set; }
        
    
        
    
    }
    
}

