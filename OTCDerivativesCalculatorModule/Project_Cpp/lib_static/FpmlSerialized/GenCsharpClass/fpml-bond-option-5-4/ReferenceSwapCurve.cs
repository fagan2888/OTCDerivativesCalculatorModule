using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ReferenceSwapCurve
    {
        public ReferenceSwapCurve(XmlNode xmlNode)
        {
            XmlNodeList swapUnwindValueNodeList = xmlNode.SelectNodes("swapUnwindValue");
            if (swapUnwindValueNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in swapUnwindValueNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        swapUnwindValueIDRef = item.Attributes["id"].Name;
                        SwapCurveValuation ob = SwapCurveValuation();
                        IDManager.SetID(swapUnwindValueIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        swapUnwindValueIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        swapUnwindValue = new SwapCurveValuation(item);
                    }
                }
            }
            
        
            XmlNodeList makeWholeAmountNodeList = xmlNode.SelectNodes("makeWholeAmount");
            if (makeWholeAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in makeWholeAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        makeWholeAmountIDRef = item.Attributes["id"].Name;
                        MakeWholeAmount ob = MakeWholeAmount();
                        IDManager.SetID(makeWholeAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        makeWholeAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        makeWholeAmount = new MakeWholeAmount(item);
                    }
                }
            }
            
        
        }
        
    
        #region SwapUnwindValue
        private SwapCurveValuation swapUnwindValue;
        public SwapCurveValuation SwapUnwindValue
        {
            get
            {
                if (this.swapUnwindValue != null)
                {
                    return this.swapUnwindValue; 
                }
                else if (this.swapUnwindValueIDRef != null)
                {
                    swapUnwindValue = IDManager.getID(swapUnwindValueIDRef) as SwapCurveValuation;
                    return this.swapUnwindValue; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.swapUnwindValue != value)
                {
                    this.swapUnwindValue = value;
                }
            }
        }
        #endregion
        
        public string SwapCurveValuationIDRef { get; set; }
        #region MakeWholeAmount
        private MakeWholeAmount makeWholeAmount;
        public MakeWholeAmount MakeWholeAmount
        {
            get
            {
                if (this.makeWholeAmount != null)
                {
                    return this.makeWholeAmount; 
                }
                else if (this.makeWholeAmountIDRef != null)
                {
                    makeWholeAmount = IDManager.getID(makeWholeAmountIDRef) as MakeWholeAmount;
                    return this.makeWholeAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.makeWholeAmount != value)
                {
                    this.makeWholeAmount = value;
                }
            }
        }
        #endregion
        
        public string MakeWholeAmountIDRef { get; set; }
        
    
        
    
    }
    
}

