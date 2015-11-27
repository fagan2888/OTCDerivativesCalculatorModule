using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class DownEventCheck : ISerialized
    {
        public DownEventCheck(XmlNode xmlNode)
        {
            XmlNode checkValueNode = xmlNode.SelectSingleNode("checkValue");
            
            if (checkValueNode != null)
            {
                if (checkValueNode.Attributes["href"] != null || checkValueNode.Attributes["id"] != null) 
                {
                    if (checkValueNode.Attributes["id"] != null) 
                    {
                        checkValueIDRef_ = checkValueNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(checkValueNode);
                        IDManager.SetID(checkValueIDRef_, ob);
                    }
                    else if (checkValueNode.Attributes["href"] != null)
                    {
                        checkValueIDRef_ = checkValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        checkValue_ = new XsdTypeDouble(checkValueNode);
                    }
                }
                else
                {
                    checkValue_ = new XsdTypeDouble(checkValueNode);
                }
            }
            
        
            XmlNode equalityNode = xmlNode.SelectSingleNode("equality");
            
            if (equalityNode != null)
            {
                if (equalityNode.Attributes["href"] != null || equalityNode.Attributes["id"] != null) 
                {
                    if (equalityNode.Attributes["id"] != null) 
                    {
                        equalityIDRef_ = equalityNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(equalityNode);
                        IDManager.SetID(equalityIDRef_, ob);
                    }
                    else if (equalityNode.Attributes["href"] != null)
                    {
                        equalityIDRef_ = equalityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        equality_ = new XsdTypeBoolean(equalityNode);
                    }
                }
                else
                {
                    equality_ = new XsdTypeBoolean(equalityNode);
                }
            }
            
        
        }
        
    
        #region CheckValue_
        private XsdTypeDouble checkValue_;
        public XsdTypeDouble CheckValue_
        {
            get
            {
                if (this.checkValue_ != null)
                {
                    return this.checkValue_; 
                }
                else if (this.checkValueIDRef_ != null)
                {
                    checkValue_ = IDManager.getID(checkValueIDRef_) as XsdTypeDouble;
                    return this.checkValue_; 
                }
                else
                {
                      return this.checkValue_; 
                }
            }
            set
            {
                if (this.checkValue_ != value)
                {
                    this.checkValue_ = value;
                }
            }
        }
        #endregion
        
        public string checkValueIDRef_ { get; set; }
        #region Equality_
        private XsdTypeBoolean equality_;
        public XsdTypeBoolean Equality_
        {
            get
            {
                if (this.equality_ != null)
                {
                    return this.equality_; 
                }
                else if (this.equalityIDRef_ != null)
                {
                    equality_ = IDManager.getID(equalityIDRef_) as XsdTypeBoolean;
                    return this.equality_; 
                }
                else
                {
                      return this.equality_; 
                }
            }
            set
            {
                if (this.equality_ != value)
                {
                    this.equality_ = value;
                }
            }
        }
        #endregion
        
        public string equalityIDRef_ { get; set; }
        
    
        
    
    }
    
}

