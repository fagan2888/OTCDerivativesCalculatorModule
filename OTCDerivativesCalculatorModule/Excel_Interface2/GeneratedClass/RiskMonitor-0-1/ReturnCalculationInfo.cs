using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ReturnCalculationInfo : ISerialized
    {
        public ReturnCalculationInfo() { }
        public ReturnCalculationInfo(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList returnCalculationNodeList = xmlNode.SelectNodes("returnCalculation");
            
            if (returnCalculationNodeList != null)
            {
                this.returnCalculation_ = new List<ReturnCalculation>();
                foreach (XmlNode item in returnCalculationNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            returnCalculationIDRef_ = item.Attributes["id"].Value;
                            returnCalculation_.Add(new ReturnCalculation(item));
                            IDManager.SetID(returnCalculationIDRef_, returnCalculation_[returnCalculation_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            returnCalculationIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        returnCalculation_.Add(new ReturnCalculation(item));
                        }
                    }
                    else
                    {
                        returnCalculation_.Add(new ReturnCalculation(item));
                    }
                }
            }
            
        
            XmlNode operatorNDNode = xmlNode.SelectSingleNode("operatorND");
            
            if (operatorNDNode != null)
            {
                if (operatorNDNode.Attributes["href"] != null || operatorNDNode.Attributes["id"] != null) 
                {
                    if (operatorNDNode.Attributes["id"] != null) 
                    {
                        operatorNDIDRef_ = operatorNDNode.Attributes["id"].Value;
                        OperatorND ob = new OperatorND(operatorNDNode);
                        IDManager.SetID(operatorNDIDRef_, ob);
                    }
                    else if (operatorNDNode.Attributes["href"] != null)
                    {
                        operatorNDIDRef_ = operatorNDNode.Attributes["href"].Value;
                    }
                    else
                    {
                        operatorND_ = new OperatorND(operatorNDNode);
                    }
                }
                else
                {
                    operatorND_ = new OperatorND(operatorNDNode);
                }
            }
            
        
        }
        
    
        #region ReturnCalculation_
        private List<ReturnCalculation> returnCalculation_;
        public List<ReturnCalculation> ReturnCalculation_
        {
            get
            {
                if (this.returnCalculation_ != null)
                {
                    return this.returnCalculation_; 
                }
                else if (this.returnCalculationIDRef_ != null)
                {
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
        #region OperatorND_
        private OperatorND operatorND_;
        public OperatorND OperatorND_
        {
            get
            {
                if (this.operatorND_ != null)
                {
                    return this.operatorND_; 
                }
                else if (this.operatorNDIDRef_ != null)
                {
                    operatorND_ = IDManager.getID(operatorNDIDRef_) as OperatorND;
                    return this.operatorND_; 
                }
                else
                {
                    throw new Exception( "operatorND_Node no exist!");
                }
            }
            set
            {
                if (this.operatorND_ != value)
                {
                    this.operatorND_ = value;
                }
            }
        }
        #endregion
        
        public string operatorNDIDRef_ { get; set; }
        
    
        
    
    }
    
}

