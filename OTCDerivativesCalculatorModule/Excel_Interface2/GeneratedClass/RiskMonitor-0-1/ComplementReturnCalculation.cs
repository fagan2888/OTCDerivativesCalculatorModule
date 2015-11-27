using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ComplementReturnCalculation : ISerialized
    {
        public ComplementReturnCalculation() { }
        public ComplementReturnCalculation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode returnCalculationInfoNode = xmlNode.SelectSingleNode("returnCalculationInfo");
            
            if (returnCalculationInfoNode != null)
            {
                if (returnCalculationInfoNode.Attributes["href"] != null || returnCalculationInfoNode.Attributes["id"] != null) 
                {
                    if (returnCalculationInfoNode.Attributes["id"] != null) 
                    {
                        returnCalculationInfoIDRef_ = returnCalculationInfoNode.Attributes["id"].Value;
                        ReturnCalculationInfo ob = new ReturnCalculationInfo(returnCalculationInfoNode);
                        IDManager.SetID(returnCalculationInfoIDRef_, ob);
                    }
                    else if (returnCalculationInfoNode.Attributes["href"] != null)
                    {
                        returnCalculationInfoIDRef_ = returnCalculationInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        returnCalculationInfo_ = new ReturnCalculationInfo(returnCalculationInfoNode);
                    }
                }
                else
                {
                    returnCalculationInfo_ = new ReturnCalculationInfo(returnCalculationInfoNode);
                }
            }
            
        
        }
        
    
        #region ReturnCalculationInfo_
        private ReturnCalculationInfo returnCalculationInfo_;
        public ReturnCalculationInfo ReturnCalculationInfo_
        {
            get
            {
                if (this.returnCalculationInfo_ != null)
                {
                    return this.returnCalculationInfo_; 
                }
                else if (this.returnCalculationInfoIDRef_ != null)
                {
                    returnCalculationInfo_ = IDManager.getID(returnCalculationInfoIDRef_) as ReturnCalculationInfo;
                    return this.returnCalculationInfo_; 
                }
                else
                {
                    throw new Exception( "returnCalculationInfo_Node no exist!");
                }
            }
            set
            {
                if (this.returnCalculationInfo_ != value)
                {
                    this.returnCalculationInfo_ = value;
                }
            }
        }
        #endregion
        
        public string returnCalculationInfoIDRef_ { get; set; }
        
    
        
    
    }
    
}

