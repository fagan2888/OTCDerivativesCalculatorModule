using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ReferenceSwapCurve : ISerialized
    {
        public ReferenceSwapCurve(XmlNode xmlNode)
        {
            XmlNode swapUnwindValueNode = xmlNode.SelectSingleNode("swapUnwindValue");
            
            if (swapUnwindValueNode != null)
            {
                if (swapUnwindValueNode.Attributes["href"] != null || swapUnwindValueNode.Attributes["id"] != null) 
                {
                    if (swapUnwindValueNode.Attributes["id"] != null) 
                    {
                        swapUnwindValueIDRef_ = swapUnwindValueNode.Attributes["id"].Value;
                        SwapCurveValuation ob = new SwapCurveValuation(swapUnwindValueNode);
                        IDManager.SetID(swapUnwindValueIDRef_, ob);
                    }
                    else if (swapUnwindValueNode.Attributes["href"] != null)
                    {
                        swapUnwindValueIDRef_ = swapUnwindValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        swapUnwindValue_ = new SwapCurveValuation(swapUnwindValueNode);
                    }
                }
                else
                {
                    swapUnwindValue_ = new SwapCurveValuation(swapUnwindValueNode);
                }
            }
            
        
            XmlNode makeWholeAmountNode = xmlNode.SelectSingleNode("makeWholeAmount");
            
            if (makeWholeAmountNode != null)
            {
                if (makeWholeAmountNode.Attributes["href"] != null || makeWholeAmountNode.Attributes["id"] != null) 
                {
                    if (makeWholeAmountNode.Attributes["id"] != null) 
                    {
                        makeWholeAmountIDRef_ = makeWholeAmountNode.Attributes["id"].Value;
                        MakeWholeAmount ob = new MakeWholeAmount(makeWholeAmountNode);
                        IDManager.SetID(makeWholeAmountIDRef_, ob);
                    }
                    else if (makeWholeAmountNode.Attributes["href"] != null)
                    {
                        makeWholeAmountIDRef_ = makeWholeAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        makeWholeAmount_ = new MakeWholeAmount(makeWholeAmountNode);
                    }
                }
                else
                {
                    makeWholeAmount_ = new MakeWholeAmount(makeWholeAmountNode);
                }
            }
            
        
        }
        
    
        #region SwapUnwindValue_
        private SwapCurveValuation swapUnwindValue_;
        public SwapCurveValuation SwapUnwindValue_
        {
            get
            {
                if (this.swapUnwindValue_ != null)
                {
                    return this.swapUnwindValue_; 
                }
                else if (this.swapUnwindValueIDRef_ != null)
                {
                    swapUnwindValue_ = IDManager.getID(swapUnwindValueIDRef_) as SwapCurveValuation;
                    return this.swapUnwindValue_; 
                }
                else
                {
                      return this.swapUnwindValue_; 
                }
            }
            set
            {
                if (this.swapUnwindValue_ != value)
                {
                    this.swapUnwindValue_ = value;
                }
            }
        }
        #endregion
        
        public string swapUnwindValueIDRef_ { get; set; }
        #region MakeWholeAmount_
        private MakeWholeAmount makeWholeAmount_;
        public MakeWholeAmount MakeWholeAmount_
        {
            get
            {
                if (this.makeWholeAmount_ != null)
                {
                    return this.makeWholeAmount_; 
                }
                else if (this.makeWholeAmountIDRef_ != null)
                {
                    makeWholeAmount_ = IDManager.getID(makeWholeAmountIDRef_) as MakeWholeAmount;
                    return this.makeWholeAmount_; 
                }
                else
                {
                      return this.makeWholeAmount_; 
                }
            }
            set
            {
                if (this.makeWholeAmount_ != value)
                {
                    this.makeWholeAmount_ = value;
                }
            }
        }
        #endregion
        
        public string makeWholeAmountIDRef_ { get; set; }
        
    
        
    
    }
    
}

