using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ParametricAdjustmentPoint : ISerialized
    {
        public ParametricAdjustmentPoint(XmlNode xmlNode)
        {
            XmlNode parameterValueNode = xmlNode.SelectSingleNode("parameterValue");
            
            if (parameterValueNode != null)
            {
                if (parameterValueNode.Attributes["href"] != null || parameterValueNode.Attributes["id"] != null) 
                {
                    if (parameterValueNode.Attributes["id"] != null) 
                    {
                        parameterValueIDRef_ = parameterValueNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(parameterValueNode);
                        IDManager.SetID(parameterValueIDRef_, ob);
                    }
                    else if (parameterValueNode.Attributes["href"] != null)
                    {
                        parameterValueIDRef_ = parameterValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        parameterValue_ = new XsdTypeDecimal(parameterValueNode);
                    }
                }
                else
                {
                    parameterValue_ = new XsdTypeDecimal(parameterValueNode);
                }
            }
            
        
            XmlNode adjustmentValueNode = xmlNode.SelectSingleNode("adjustmentValue");
            
            if (adjustmentValueNode != null)
            {
                if (adjustmentValueNode.Attributes["href"] != null || adjustmentValueNode.Attributes["id"] != null) 
                {
                    if (adjustmentValueNode.Attributes["id"] != null) 
                    {
                        adjustmentValueIDRef_ = adjustmentValueNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(adjustmentValueNode);
                        IDManager.SetID(adjustmentValueIDRef_, ob);
                    }
                    else if (adjustmentValueNode.Attributes["href"] != null)
                    {
                        adjustmentValueIDRef_ = adjustmentValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        adjustmentValue_ = new XsdTypeDecimal(adjustmentValueNode);
                    }
                }
                else
                {
                    adjustmentValue_ = new XsdTypeDecimal(adjustmentValueNode);
                }
            }
            
        
        }
        
    
        #region ParameterValue_
        private XsdTypeDecimal parameterValue_;
        public XsdTypeDecimal ParameterValue_
        {
            get
            {
                if (this.parameterValue_ != null)
                {
                    return this.parameterValue_; 
                }
                else if (this.parameterValueIDRef_ != null)
                {
                    parameterValue_ = IDManager.getID(parameterValueIDRef_) as XsdTypeDecimal;
                    return this.parameterValue_; 
                }
                else
                {
                      return this.parameterValue_; 
                }
            }
            set
            {
                if (this.parameterValue_ != value)
                {
                    this.parameterValue_ = value;
                }
            }
        }
        #endregion
        
        public string parameterValueIDRef_ { get; set; }
        #region AdjustmentValue_
        private XsdTypeDecimal adjustmentValue_;
        public XsdTypeDecimal AdjustmentValue_
        {
            get
            {
                if (this.adjustmentValue_ != null)
                {
                    return this.adjustmentValue_; 
                }
                else if (this.adjustmentValueIDRef_ != null)
                {
                    adjustmentValue_ = IDManager.getID(adjustmentValueIDRef_) as XsdTypeDecimal;
                    return this.adjustmentValue_; 
                }
                else
                {
                      return this.adjustmentValue_; 
                }
            }
            set
            {
                if (this.adjustmentValue_ != value)
                {
                    this.adjustmentValue_ = value;
                }
            }
        }
        #endregion
        
        public string adjustmentValueIDRef_ { get; set; }
        
    
        
    
    }
    
}

