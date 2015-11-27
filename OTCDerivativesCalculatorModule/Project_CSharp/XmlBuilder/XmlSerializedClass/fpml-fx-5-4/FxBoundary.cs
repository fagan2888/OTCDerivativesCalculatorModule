using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FxBoundary : ISerialized
    {
        public FxBoundary(XmlNode xmlNode)
        {
            XmlNode inclusiveNode = xmlNode.SelectSingleNode("inclusive");
            
            if (inclusiveNode != null)
            {
                if (inclusiveNode.Attributes["href"] != null || inclusiveNode.Attributes["id"] != null) 
                {
                    if (inclusiveNode.Attributes["id"] != null) 
                    {
                        inclusiveIDRef_ = inclusiveNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(inclusiveNode);
                        IDManager.SetID(inclusiveIDRef_, ob);
                    }
                    else if (inclusiveNode.Attributes["href"] != null)
                    {
                        inclusiveIDRef_ = inclusiveNode.Attributes["href"].Value;
                    }
                    else
                    {
                        inclusive_ = new XsdTypeBoolean(inclusiveNode);
                    }
                }
                else
                {
                    inclusive_ = new XsdTypeBoolean(inclusiveNode);
                }
            }
            
        
            XmlNode exclusiveNode = xmlNode.SelectSingleNode("exclusive");
            
            if (exclusiveNode != null)
            {
                if (exclusiveNode.Attributes["href"] != null || exclusiveNode.Attributes["id"] != null) 
                {
                    if (exclusiveNode.Attributes["id"] != null) 
                    {
                        exclusiveIDRef_ = exclusiveNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(exclusiveNode);
                        IDManager.SetID(exclusiveIDRef_, ob);
                    }
                    else if (exclusiveNode.Attributes["href"] != null)
                    {
                        exclusiveIDRef_ = exclusiveNode.Attributes["href"].Value;
                    }
                    else
                    {
                        exclusive_ = new XsdTypeBoolean(exclusiveNode);
                    }
                }
                else
                {
                    exclusive_ = new XsdTypeBoolean(exclusiveNode);
                }
            }
            
        
        }
        
    
        #region Inclusive_
        private XsdTypeBoolean inclusive_;
        public XsdTypeBoolean Inclusive_
        {
            get
            {
                if (this.inclusive_ != null)
                {
                    return this.inclusive_; 
                }
                else if (this.inclusiveIDRef_ != null)
                {
                    inclusive_ = IDManager.getID(inclusiveIDRef_) as XsdTypeBoolean;
                    return this.inclusive_; 
                }
                else
                {
                      return this.inclusive_; 
                }
            }
            set
            {
                if (this.inclusive_ != value)
                {
                    this.inclusive_ = value;
                }
            }
        }
        #endregion
        
        public string inclusiveIDRef_ { get; set; }
        #region Exclusive_
        private XsdTypeBoolean exclusive_;
        public XsdTypeBoolean Exclusive_
        {
            get
            {
                if (this.exclusive_ != null)
                {
                    return this.exclusive_; 
                }
                else if (this.exclusiveIDRef_ != null)
                {
                    exclusive_ = IDManager.getID(exclusiveIDRef_) as XsdTypeBoolean;
                    return this.exclusive_; 
                }
                else
                {
                      return this.exclusive_; 
                }
            }
            set
            {
                if (this.exclusive_ != value)
                {
                    this.exclusive_ = value;
                }
            }
        }
        #endregion
        
        public string exclusiveIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

