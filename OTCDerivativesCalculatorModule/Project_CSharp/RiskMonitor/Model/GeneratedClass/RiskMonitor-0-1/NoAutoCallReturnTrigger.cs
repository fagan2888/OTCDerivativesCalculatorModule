using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class NoAutoCallReturnTrigger : ISerialized
    {
        public NoAutoCallReturnTrigger() { }
        public NoAutoCallReturnTrigger(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode payoffDateInfoNode = xmlNode.SelectSingleNode("payoffDateInfo");
            
            if (payoffDateInfoNode != null)
            {
                if (payoffDateInfoNode.Attributes["href"] != null || payoffDateInfoNode.Attributes["id"] != null) 
                {
                    if (payoffDateInfoNode.Attributes["id"] != null) 
                    {
                        payoffDateInfoIDRef_ = payoffDateInfoNode.Attributes["id"].Value;
                        PayoffDateInfo ob = new PayoffDateInfo(payoffDateInfoNode);
                        IDManager.SetID(payoffDateInfoIDRef_, ob);
                    }
                    else if (payoffDateInfoNode.Attributes["href"] != null)
                    {
                        payoffDateInfoIDRef_ = payoffDateInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payoffDateInfo_ = new PayoffDateInfo(payoffDateInfoNode);
                    }
                }
                else
                {
                    payoffDateInfo_ = new PayoffDateInfo(payoffDateInfoNode);
                }
            }
            
        
            XmlNode returnCalculationNode = xmlNode.SelectSingleNode("returnCalculation");
            
            if (returnCalculationNode != null)
            {
                if (returnCalculationNode.Attributes["href"] != null || returnCalculationNode.Attributes["id"] != null) 
                {
                    if (returnCalculationNode.Attributes["id"] != null) 
                    {
                        returnCalculationIDRef_ = returnCalculationNode.Attributes["id"].Value;
                        ReturnCalculation ob = new ReturnCalculation(returnCalculationNode);
                        IDManager.SetID(returnCalculationIDRef_, ob);
                    }
                    else if (returnCalculationNode.Attributes["href"] != null)
                    {
                        returnCalculationIDRef_ = returnCalculationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        returnCalculation_ = new ReturnCalculation(returnCalculationNode);
                    }
                }
                else
                {
                    returnCalculation_ = new ReturnCalculation(returnCalculationNode);
                }
            }
            
        
        }
        
    
        #region PayoffDateInfo_
        private PayoffDateInfo payoffDateInfo_;
        public PayoffDateInfo PayoffDateInfo_
        {
            get
            {
                if (this.payoffDateInfo_ != null)
                {
                    return this.payoffDateInfo_; 
                }
                else if (this.payoffDateInfoIDRef_ != null)
                {
                    payoffDateInfo_ = IDManager.getID(payoffDateInfoIDRef_) as PayoffDateInfo;
                    return this.payoffDateInfo_; 
                }
                else
                {
                    throw new Exception( "payoffDateInfo_Node no exist!");
                }
            }
            set
            {
                if (this.payoffDateInfo_ != value)
                {
                    this.payoffDateInfo_ = value;
                }
            }
        }
        #endregion
        
        public string payoffDateInfoIDRef_ { get; set; }
        #region ReturnCalculation_
        private ReturnCalculation returnCalculation_;
        public ReturnCalculation ReturnCalculation_
        {
            get
            {
                if (this.returnCalculation_ != null)
                {
                    return this.returnCalculation_; 
                }
                else if (this.returnCalculationIDRef_ != null)
                {
                    returnCalculation_ = IDManager.getID(returnCalculationIDRef_) as ReturnCalculation;
                    return this.returnCalculation_; 
                }
                else
                {
                    throw new Exception( "returnCalculation_Node no exist!");
                }
            }
            set
            {
                if (this.returnCalculation_ != value)
                {
                    this.returnCalculation_ = value;
                }
            }
        }
        #endregion
        
        public string returnCalculationIDRef_ { get; set; }
        
    
        
    
    }
    
}

