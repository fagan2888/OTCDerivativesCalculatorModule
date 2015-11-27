using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ConstPayoff : ISerialized
    {
        public ConstPayoff(XmlNode xmlNode)
        {
            XmlNode constValueNode = xmlNode.SelectSingleNode("constValue");
            
            if (constValueNode != null)
            {
                if (constValueNode.Attributes["href"] != null || constValueNode.Attributes["id"] != null) 
                {
                    if (constValueNode.Attributes["id"] != null) 
                    {
                        constValueIDRef_ = constValueNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(constValueNode);
                        IDManager.SetID(constValueIDRef_, ob);
                    }
                    else if (constValueNode.Attributes["href"] != null)
                    {
                        constValueIDRef_ = constValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        constValue_ = new XsdTypeDouble(constValueNode);
                    }
                }
                else
                {
                    constValue_ = new XsdTypeDouble(constValueNode);
                }
            }
            
        
        }
        
    
        #region ConstValue_
        private XsdTypeDouble constValue_;
        public XsdTypeDouble ConstValue_
        {
            get
            {
                if (this.constValue_ != null)
                {
                    return this.constValue_; 
                }
                else if (this.constValueIDRef_ != null)
                {
                    constValue_ = IDManager.getID(constValueIDRef_) as XsdTypeDouble;
                    return this.constValue_; 
                }
                else
                {
                      return this.constValue_; 
                }
            }
            set
            {
                if (this.constValue_ != value)
                {
                    this.constValue_ = value;
                }
            }
        }
        #endregion
        
        public string constValueIDRef_ { get; set; }
        
    
        
    
    }
    
}

