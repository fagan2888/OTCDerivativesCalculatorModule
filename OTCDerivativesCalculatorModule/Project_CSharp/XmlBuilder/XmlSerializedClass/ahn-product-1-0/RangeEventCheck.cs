using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class RangeEventCheck : ISerialized
    {
        public RangeEventCheck(XmlNode xmlNode)
        {
            XmlNode highCheckValueNode = xmlNode.SelectSingleNode("highCheckValue");
            
            if (highCheckValueNode != null)
            {
                if (highCheckValueNode.Attributes["href"] != null || highCheckValueNode.Attributes["id"] != null) 
                {
                    if (highCheckValueNode.Attributes["id"] != null) 
                    {
                        highCheckValueIDRef_ = highCheckValueNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(highCheckValueNode);
                        IDManager.SetID(highCheckValueIDRef_, ob);
                    }
                    else if (highCheckValueNode.Attributes["href"] != null)
                    {
                        highCheckValueIDRef_ = highCheckValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        highCheckValue_ = new XsdTypeDouble(highCheckValueNode);
                    }
                }
                else
                {
                    highCheckValue_ = new XsdTypeDouble(highCheckValueNode);
                }
            }
            
        
            XmlNode highEqualityNode = xmlNode.SelectSingleNode("highEquality");
            
            if (highEqualityNode != null)
            {
                if (highEqualityNode.Attributes["href"] != null || highEqualityNode.Attributes["id"] != null) 
                {
                    if (highEqualityNode.Attributes["id"] != null) 
                    {
                        highEqualityIDRef_ = highEqualityNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(highEqualityNode);
                        IDManager.SetID(highEqualityIDRef_, ob);
                    }
                    else if (highEqualityNode.Attributes["href"] != null)
                    {
                        highEqualityIDRef_ = highEqualityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        highEquality_ = new XsdTypeBoolean(highEqualityNode);
                    }
                }
                else
                {
                    highEquality_ = new XsdTypeBoolean(highEqualityNode);
                }
            }
            
        
            XmlNode lowCheckValueNode = xmlNode.SelectSingleNode("lowCheckValue");
            
            if (lowCheckValueNode != null)
            {
                if (lowCheckValueNode.Attributes["href"] != null || lowCheckValueNode.Attributes["id"] != null) 
                {
                    if (lowCheckValueNode.Attributes["id"] != null) 
                    {
                        lowCheckValueIDRef_ = lowCheckValueNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(lowCheckValueNode);
                        IDManager.SetID(lowCheckValueIDRef_, ob);
                    }
                    else if (lowCheckValueNode.Attributes["href"] != null)
                    {
                        lowCheckValueIDRef_ = lowCheckValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        lowCheckValue_ = new XsdTypeDouble(lowCheckValueNode);
                    }
                }
                else
                {
                    lowCheckValue_ = new XsdTypeDouble(lowCheckValueNode);
                }
            }
            
        
            XmlNode lowEqualityNode = xmlNode.SelectSingleNode("lowEquality");
            
            if (lowEqualityNode != null)
            {
                if (lowEqualityNode.Attributes["href"] != null || lowEqualityNode.Attributes["id"] != null) 
                {
                    if (lowEqualityNode.Attributes["id"] != null) 
                    {
                        lowEqualityIDRef_ = lowEqualityNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(lowEqualityNode);
                        IDManager.SetID(lowEqualityIDRef_, ob);
                    }
                    else if (lowEqualityNode.Attributes["href"] != null)
                    {
                        lowEqualityIDRef_ = lowEqualityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        lowEquality_ = new XsdTypeBoolean(lowEqualityNode);
                    }
                }
                else
                {
                    lowEquality_ = new XsdTypeBoolean(lowEqualityNode);
                }
            }
            
        
        }
        
    
        #region HighCheckValue_
        private XsdTypeDouble highCheckValue_;
        public XsdTypeDouble HighCheckValue_
        {
            get
            {
                if (this.highCheckValue_ != null)
                {
                    return this.highCheckValue_; 
                }
                else if (this.highCheckValueIDRef_ != null)
                {
                    highCheckValue_ = IDManager.getID(highCheckValueIDRef_) as XsdTypeDouble;
                    return this.highCheckValue_; 
                }
                else
                {
                      return this.highCheckValue_; 
                }
            }
            set
            {
                if (this.highCheckValue_ != value)
                {
                    this.highCheckValue_ = value;
                }
            }
        }
        #endregion
        
        public string highCheckValueIDRef_ { get; set; }
        #region HighEquality_
        private XsdTypeBoolean highEquality_;
        public XsdTypeBoolean HighEquality_
        {
            get
            {
                if (this.highEquality_ != null)
                {
                    return this.highEquality_; 
                }
                else if (this.highEqualityIDRef_ != null)
                {
                    highEquality_ = IDManager.getID(highEqualityIDRef_) as XsdTypeBoolean;
                    return this.highEquality_; 
                }
                else
                {
                      return this.highEquality_; 
                }
            }
            set
            {
                if (this.highEquality_ != value)
                {
                    this.highEquality_ = value;
                }
            }
        }
        #endregion
        
        public string highEqualityIDRef_ { get; set; }
        #region LowCheckValue_
        private XsdTypeDouble lowCheckValue_;
        public XsdTypeDouble LowCheckValue_
        {
            get
            {
                if (this.lowCheckValue_ != null)
                {
                    return this.lowCheckValue_; 
                }
                else if (this.lowCheckValueIDRef_ != null)
                {
                    lowCheckValue_ = IDManager.getID(lowCheckValueIDRef_) as XsdTypeDouble;
                    return this.lowCheckValue_; 
                }
                else
                {
                      return this.lowCheckValue_; 
                }
            }
            set
            {
                if (this.lowCheckValue_ != value)
                {
                    this.lowCheckValue_ = value;
                }
            }
        }
        #endregion
        
        public string lowCheckValueIDRef_ { get; set; }
        #region LowEquality_
        private XsdTypeBoolean lowEquality_;
        public XsdTypeBoolean LowEquality_
        {
            get
            {
                if (this.lowEquality_ != null)
                {
                    return this.lowEquality_; 
                }
                else if (this.lowEqualityIDRef_ != null)
                {
                    lowEquality_ = IDManager.getID(lowEqualityIDRef_) as XsdTypeBoolean;
                    return this.lowEquality_; 
                }
                else
                {
                      return this.lowEquality_; 
                }
            }
            set
            {
                if (this.lowEquality_ != value)
                {
                    this.lowEquality_ = value;
                }
            }
        }
        #endregion
        
        public string lowEqualityIDRef_ { get; set; }
        
    
        
    
    }
    
}

