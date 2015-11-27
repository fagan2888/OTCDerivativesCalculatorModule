using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FixingInformation : ISerialized
    {
        public FixingInformation() { }
        public FixingInformation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode initialValueNode = xmlNode.SelectSingleNode("initialValue");
            
            if (initialValueNode != null)
            {
                if (initialValueNode.Attributes["href"] != null || initialValueNode.Attributes["id"] != null) 
                {
                    if (initialValueNode.Attributes["id"] != null) 
                    {
                        initialValueIDRef_ = initialValueNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(initialValueNode);
                        IDManager.SetID(initialValueIDRef_, ob);
                    }
                    else if (initialValueNode.Attributes["href"] != null)
                    {
                        initialValueIDRef_ = initialValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        initialValue_ = new XsdTypeDouble(initialValueNode);
                    }
                }
                else
                {
                    initialValue_ = new XsdTypeDouble(initialValueNode);
                }
            }
            
        
            XmlNodeList fixingNodeList = xmlNode.SelectNodes("fixing");
            
            if (fixingNodeList != null)
            {
                this.fixing_ = new List<Fixing>();
                foreach (XmlNode item in fixingNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            fixingIDRef_ = item.Attributes["id"].Value;
                            fixing_.Add(new Fixing(item));
                            IDManager.SetID(fixingIDRef_, fixing_[fixing_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            fixingIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        fixing_.Add(new Fixing(item));
                        }
                    }
                    else
                    {
                        fixing_.Add(new Fixing(item));
                    }
                }
            }
            
        
        }
        
    
        #region InitialValue_
        private XsdTypeDouble initialValue_;
        public XsdTypeDouble InitialValue_
        {
            get
            {
                if (this.initialValue_ != null)
                {
                    return this.initialValue_; 
                }
                else if (this.initialValueIDRef_ != null)
                {
                    initialValue_ = IDManager.getID(initialValueIDRef_) as XsdTypeDouble;
                    return this.initialValue_; 
                }
                else
                {
                    throw new Exception( "initialValue_Node no exist!");
                }
            }
            set
            {
                if (this.initialValue_ != value)
                {
                    this.initialValue_ = value;
                }
            }
        }
        #endregion
        
        public string initialValueIDRef_ { get; set; }
        #region Fixing_
        private List<Fixing> fixing_;
        public List<Fixing> Fixing_
        {
            get
            {
                if (this.fixing_ != null)
                {
                    return this.fixing_; 
                }
                else if (this.fixingIDRef_ != null)
                {
                    return this.fixing_; 
                }
                else
                {
                    throw new Exception( "fixing_Node no exist!");
                }
            }
            set
            {
                if (this.fixing_ != value)
                {
                    this.fixing_ = value;
                }
            }
        }
        #endregion
        
        public string fixingIDRef_ { get; set; }
        
    
        
    
    }
    
}

