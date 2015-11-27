using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_dualBarrierEventCal : ISerialized
    {
        public Excel_dualBarrierEventCal() { }
        public Excel_dualBarrierEventCal(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode lowerRngNode = xmlNode.SelectSingleNode("lowerRng");
            
            if (lowerRngNode != null)
            {
                if (lowerRngNode.Attributes["href"] != null || lowerRngNode.Attributes["id"] != null) 
                {
                    if (lowerRngNode.Attributes["id"] != null) 
                    {
                        lowerRngIDRef_ = lowerRngNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(lowerRngNode);
                        IDManager.SetID(lowerRngIDRef_, ob);
                    }
                    else if (lowerRngNode.Attributes["href"] != null)
                    {
                        lowerRngIDRef_ = lowerRngNode.Attributes["href"].Value;
                    }
                    else
                    {
                        lowerRng_ = new XsdTypeToken(lowerRngNode);
                    }
                }
                else
                {
                    lowerRng_ = new XsdTypeToken(lowerRngNode);
                }
            }
            
        
            XmlNode upperRngNode = xmlNode.SelectSingleNode("upperRng");
            
            if (upperRngNode != null)
            {
                if (upperRngNode.Attributes["href"] != null || upperRngNode.Attributes["id"] != null) 
                {
                    if (upperRngNode.Attributes["id"] != null) 
                    {
                        upperRngIDRef_ = upperRngNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(upperRngNode);
                        IDManager.SetID(upperRngIDRef_, ob);
                    }
                    else if (upperRngNode.Attributes["href"] != null)
                    {
                        upperRngIDRef_ = upperRngNode.Attributes["href"].Value;
                    }
                    else
                    {
                        upperRng_ = new XsdTypeToken(upperRngNode);
                    }
                }
                else
                {
                    upperRng_ = new XsdTypeToken(upperRngNode);
                }
            }
            
        
        }
        
    
        #region LowerRng_
        private XsdTypeToken lowerRng_;
        public XsdTypeToken LowerRng_
        {
            get
            {
                if (this.lowerRng_ != null)
                {
                    return this.lowerRng_; 
                }
                else if (this.lowerRngIDRef_ != null)
                {
                    lowerRng_ = IDManager.getID(lowerRngIDRef_) as XsdTypeToken;
                    return this.lowerRng_; 
                }
                else
                {
                    throw new Exception( "lowerRng_Node no exist!");
                }
            }
            set
            {
                if (this.lowerRng_ != value)
                {
                    this.lowerRng_ = value;
                }
            }
        }
        #endregion
        
        public string lowerRngIDRef_ { get; set; }
        #region UpperRng_
        private XsdTypeToken upperRng_;
        public XsdTypeToken UpperRng_
        {
            get
            {
                if (this.upperRng_ != null)
                {
                    return this.upperRng_; 
                }
                else if (this.upperRngIDRef_ != null)
                {
                    upperRng_ = IDManager.getID(upperRngIDRef_) as XsdTypeToken;
                    return this.upperRng_; 
                }
                else
                {
                    throw new Exception( "upperRng_Node no exist!");
                }
            }
            set
            {
                if (this.upperRng_ != value)
                {
                    this.upperRng_ = value;
                }
            }
        }
        #endregion
        
        public string upperRngIDRef_ { get; set; }
        
    
        
    
    }
    
}

