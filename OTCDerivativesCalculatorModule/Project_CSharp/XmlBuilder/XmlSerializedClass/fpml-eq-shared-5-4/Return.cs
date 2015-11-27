using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Return : ISerialized
    {
        public Return(XmlNode xmlNode)
        {
            XmlNode returnTypeNode = xmlNode.SelectSingleNode("returnType");
            
            if (returnTypeNode != null)
            {
                if (returnTypeNode.Attributes["href"] != null || returnTypeNode.Attributes["id"] != null) 
                {
                    if (returnTypeNode.Attributes["id"] != null) 
                    {
                        returnTypeIDRef_ = returnTypeNode.Attributes["id"].Value;
                        ReturnTypeEnum ob = new ReturnTypeEnum(returnTypeNode);
                        IDManager.SetID(returnTypeIDRef_, ob);
                    }
                    else if (returnTypeNode.Attributes["href"] != null)
                    {
                        returnTypeIDRef_ = returnTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        returnType_ = new ReturnTypeEnum(returnTypeNode);
                    }
                }
                else
                {
                    returnType_ = new ReturnTypeEnum(returnTypeNode);
                }
            }
            
        
            XmlNode dividendConditionsNode = xmlNode.SelectSingleNode("dividendConditions");
            
            if (dividendConditionsNode != null)
            {
                if (dividendConditionsNode.Attributes["href"] != null || dividendConditionsNode.Attributes["id"] != null) 
                {
                    if (dividendConditionsNode.Attributes["id"] != null) 
                    {
                        dividendConditionsIDRef_ = dividendConditionsNode.Attributes["id"].Value;
                        DividendConditions ob = new DividendConditions(dividendConditionsNode);
                        IDManager.SetID(dividendConditionsIDRef_, ob);
                    }
                    else if (dividendConditionsNode.Attributes["href"] != null)
                    {
                        dividendConditionsIDRef_ = dividendConditionsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dividendConditions_ = new DividendConditions(dividendConditionsNode);
                    }
                }
                else
                {
                    dividendConditions_ = new DividendConditions(dividendConditionsNode);
                }
            }
            
        
        }
        
    
        #region ReturnType_
        private ReturnTypeEnum returnType_;
        public ReturnTypeEnum ReturnType_
        {
            get
            {
                if (this.returnType_ != null)
                {
                    return this.returnType_; 
                }
                else if (this.returnTypeIDRef_ != null)
                {
                    returnType_ = IDManager.getID(returnTypeIDRef_) as ReturnTypeEnum;
                    return this.returnType_; 
                }
                else
                {
                      return this.returnType_; 
                }
            }
            set
            {
                if (this.returnType_ != value)
                {
                    this.returnType_ = value;
                }
            }
        }
        #endregion
        
        public string returnTypeIDRef_ { get; set; }
        #region DividendConditions_
        private DividendConditions dividendConditions_;
        public DividendConditions DividendConditions_
        {
            get
            {
                if (this.dividendConditions_ != null)
                {
                    return this.dividendConditions_; 
                }
                else if (this.dividendConditionsIDRef_ != null)
                {
                    dividendConditions_ = IDManager.getID(dividendConditionsIDRef_) as DividendConditions;
                    return this.dividendConditions_; 
                }
                else
                {
                      return this.dividendConditions_; 
                }
            }
            set
            {
                if (this.dividendConditions_ != value)
                {
                    this.dividendConditions_ = value;
                }
            }
        }
        #endregion
        
        public string dividendConditionsIDRef_ { get; set; }
        
    
        
    
    }
    
}

