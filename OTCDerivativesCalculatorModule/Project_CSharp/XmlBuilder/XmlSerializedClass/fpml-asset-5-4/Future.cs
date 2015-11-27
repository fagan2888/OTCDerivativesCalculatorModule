using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Future : ExchangeTraded
    {
        public Future(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode multiplierNode = xmlNode.SelectSingleNode("multiplier");
            
            if (multiplierNode != null)
            {
                if (multiplierNode.Attributes["href"] != null || multiplierNode.Attributes["id"] != null) 
                {
                    if (multiplierNode.Attributes["id"] != null) 
                    {
                        multiplierIDRef_ = multiplierNode.Attributes["id"].Value;
                        XsdTypePositiveInteger ob = new XsdTypePositiveInteger(multiplierNode);
                        IDManager.SetID(multiplierIDRef_, ob);
                    }
                    else if (multiplierNode.Attributes["href"] != null)
                    {
                        multiplierIDRef_ = multiplierNode.Attributes["href"].Value;
                    }
                    else
                    {
                        multiplier_ = new XsdTypePositiveInteger(multiplierNode);
                    }
                }
                else
                {
                    multiplier_ = new XsdTypePositiveInteger(multiplierNode);
                }
            }
            
        
            XmlNode futureContractReferenceNode = xmlNode.SelectSingleNode("futureContractReference");
            
            if (futureContractReferenceNode != null)
            {
                if (futureContractReferenceNode.Attributes["href"] != null || futureContractReferenceNode.Attributes["id"] != null) 
                {
                    if (futureContractReferenceNode.Attributes["id"] != null) 
                    {
                        futureContractReferenceIDRef_ = futureContractReferenceNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(futureContractReferenceNode);
                        IDManager.SetID(futureContractReferenceIDRef_, ob);
                    }
                    else if (futureContractReferenceNode.Attributes["href"] != null)
                    {
                        futureContractReferenceIDRef_ = futureContractReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        futureContractReference_ = new XsdTypeString(futureContractReferenceNode);
                    }
                }
                else
                {
                    futureContractReference_ = new XsdTypeString(futureContractReferenceNode);
                }
            }
            
        
            XmlNode maturityNode = xmlNode.SelectSingleNode("maturity");
            
            if (maturityNode != null)
            {
                if (maturityNode.Attributes["href"] != null || maturityNode.Attributes["id"] != null) 
                {
                    if (maturityNode.Attributes["id"] != null) 
                    {
                        maturityIDRef_ = maturityNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(maturityNode);
                        IDManager.SetID(maturityIDRef_, ob);
                    }
                    else if (maturityNode.Attributes["href"] != null)
                    {
                        maturityIDRef_ = maturityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        maturity_ = new XsdTypeDate(maturityNode);
                    }
                }
                else
                {
                    maturity_ = new XsdTypeDate(maturityNode);
                }
            }
            
        
        }
        
    
        #region Multiplier_
        private XsdTypePositiveInteger multiplier_;
        public XsdTypePositiveInteger Multiplier_
        {
            get
            {
                if (this.multiplier_ != null)
                {
                    return this.multiplier_; 
                }
                else if (this.multiplierIDRef_ != null)
                {
                    multiplier_ = IDManager.getID(multiplierIDRef_) as XsdTypePositiveInteger;
                    return this.multiplier_; 
                }
                else
                {
                      return this.multiplier_; 
                }
            }
            set
            {
                if (this.multiplier_ != value)
                {
                    this.multiplier_ = value;
                }
            }
        }
        #endregion
        
        public string multiplierIDRef_ { get; set; }
        #region FutureContractReference_
        private XsdTypeString futureContractReference_;
        public XsdTypeString FutureContractReference_
        {
            get
            {
                if (this.futureContractReference_ != null)
                {
                    return this.futureContractReference_; 
                }
                else if (this.futureContractReferenceIDRef_ != null)
                {
                    futureContractReference_ = IDManager.getID(futureContractReferenceIDRef_) as XsdTypeString;
                    return this.futureContractReference_; 
                }
                else
                {
                      return this.futureContractReference_; 
                }
            }
            set
            {
                if (this.futureContractReference_ != value)
                {
                    this.futureContractReference_ = value;
                }
            }
        }
        #endregion
        
        public string futureContractReferenceIDRef_ { get; set; }
        #region Maturity_
        private XsdTypeDate maturity_;
        public XsdTypeDate Maturity_
        {
            get
            {
                if (this.maturity_ != null)
                {
                    return this.maturity_; 
                }
                else if (this.maturityIDRef_ != null)
                {
                    maturity_ = IDManager.getID(maturityIDRef_) as XsdTypeDate;
                    return this.maturity_; 
                }
                else
                {
                      return this.maturity_; 
                }
            }
            set
            {
                if (this.maturity_ != value)
                {
                    this.maturity_ = value;
                }
            }
        }
        #endregion
        
        public string maturityIDRef_ { get; set; }
        
    
        
    
    }
    
}

