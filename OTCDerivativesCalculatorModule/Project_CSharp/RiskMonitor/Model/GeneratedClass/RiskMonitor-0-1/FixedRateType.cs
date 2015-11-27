using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FixedRateType : ISerialized
    {
        public FixedRateType() { }
        public FixedRateType(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode fixedRateNode = xmlNode.SelectSingleNode("fixedRate");
            
            if (fixedRateNode != null)
            {
                if (fixedRateNode.Attributes["href"] != null || fixedRateNode.Attributes["id"] != null) 
                {
                    if (fixedRateNode.Attributes["id"] != null) 
                    {
                        fixedRateIDRef_ = fixedRateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(fixedRateNode);
                        IDManager.SetID(fixedRateIDRef_, ob);
                    }
                    else if (fixedRateNode.Attributes["href"] != null)
                    {
                        fixedRateIDRef_ = fixedRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixedRate_ = new XsdTypeToken(fixedRateNode);
                    }
                }
                else
                {
                    fixedRate_ = new XsdTypeToken(fixedRateNode);
                }
            }
            
        
        }
        
    
        #region FixedRate_
        private XsdTypeToken fixedRate_;
        public XsdTypeToken FixedRate_
        {
            get
            {
                if (this.fixedRate_ != null)
                {
                    return this.fixedRate_; 
                }
                else if (this.fixedRateIDRef_ != null)
                {
                    fixedRate_ = IDManager.getID(fixedRateIDRef_) as XsdTypeToken;
                    return this.fixedRate_; 
                }
                else
                {
                    throw new Exception( "fixedRate_Node no exist!");
                }
            }
            set
            {
                if (this.fixedRate_ != value)
                {
                    this.fixedRate_ = value;
                }
            }
        }
        #endregion
        
        public string fixedRateIDRef_ { get; set; }
        
    
        
    
    }
    
}

