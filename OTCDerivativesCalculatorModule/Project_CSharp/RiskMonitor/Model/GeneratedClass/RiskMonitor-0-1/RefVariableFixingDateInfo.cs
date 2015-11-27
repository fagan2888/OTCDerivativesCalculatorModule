using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class RefVariableFixingDateInfo : ISerialized
    {
        public RefVariableFixingDateInfo() { }
        public RefVariableFixingDateInfo(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode refDateNameNode = xmlNode.SelectSingleNode("refDateName");
            
            if (refDateNameNode != null)
            {
                if (refDateNameNode.Attributes["href"] != null || refDateNameNode.Attributes["id"] != null) 
                {
                    if (refDateNameNode.Attributes["id"] != null) 
                    {
                        refDateNameIDRef_ = refDateNameNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(refDateNameNode);
                        IDManager.SetID(refDateNameIDRef_, ob);
                    }
                    else if (refDateNameNode.Attributes["href"] != null)
                    {
                        refDateNameIDRef_ = refDateNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        refDateName_ = new XsdTypeToken(refDateNameNode);
                    }
                }
                else
                {
                    refDateName_ = new XsdTypeToken(refDateNameNode);
                }
            }
            
        
            XmlNode autoCallFlagNode = xmlNode.SelectSingleNode("autoCallFlag");
            
            if (autoCallFlagNode != null)
            {
                if (autoCallFlagNode.Attributes["href"] != null || autoCallFlagNode.Attributes["id"] != null) 
                {
                    if (autoCallFlagNode.Attributes["id"] != null) 
                    {
                        autoCallFlagIDRef_ = autoCallFlagNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(autoCallFlagNode);
                        IDManager.SetID(autoCallFlagIDRef_, ob);
                    }
                    else if (autoCallFlagNode.Attributes["href"] != null)
                    {
                        autoCallFlagIDRef_ = autoCallFlagNode.Attributes["href"].Value;
                    }
                    else
                    {
                        autoCallFlag_ = new XsdTypeBoolean(autoCallFlagNode);
                    }
                }
                else
                {
                    autoCallFlag_ = new XsdTypeBoolean(autoCallFlagNode);
                }
            }
            
        
            XmlNode autoCallFixingDateNode = xmlNode.SelectSingleNode("autoCallFixingDate");
            
            if (autoCallFixingDateNode != null)
            {
                if (autoCallFixingDateNode.Attributes["href"] != null || autoCallFixingDateNode.Attributes["id"] != null) 
                {
                    if (autoCallFixingDateNode.Attributes["id"] != null) 
                    {
                        autoCallFixingDateIDRef_ = autoCallFixingDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(autoCallFixingDateNode);
                        IDManager.SetID(autoCallFixingDateIDRef_, ob);
                    }
                    else if (autoCallFixingDateNode.Attributes["href"] != null)
                    {
                        autoCallFixingDateIDRef_ = autoCallFixingDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        autoCallFixingDate_ = new XsdTypeDate(autoCallFixingDateNode);
                    }
                }
                else
                {
                    autoCallFixingDate_ = new XsdTypeDate(autoCallFixingDateNode);
                }
            }
            
        
        }
        
    
        #region RefDateName_
        private XsdTypeToken refDateName_;
        public XsdTypeToken RefDateName_
        {
            get
            {
                if (this.refDateName_ != null)
                {
                    return this.refDateName_; 
                }
                else if (this.refDateNameIDRef_ != null)
                {
                    refDateName_ = IDManager.getID(refDateNameIDRef_) as XsdTypeToken;
                    return this.refDateName_; 
                }
                else
                {
                    throw new Exception( "refDateName_Node no exist!");
                }
            }
            set
            {
                if (this.refDateName_ != value)
                {
                    this.refDateName_ = value;
                }
            }
        }
        #endregion
        
        public string refDateNameIDRef_ { get; set; }
        #region AutoCallFlag_
        private XsdTypeBoolean autoCallFlag_;
        public XsdTypeBoolean AutoCallFlag_
        {
            get
            {
                if (this.autoCallFlag_ != null)
                {
                    return this.autoCallFlag_; 
                }
                else if (this.autoCallFlagIDRef_ != null)
                {
                    autoCallFlag_ = IDManager.getID(autoCallFlagIDRef_) as XsdTypeBoolean;
                    return this.autoCallFlag_; 
                }
                else
                {
                    throw new Exception( "autoCallFlag_Node no exist!");
                }
            }
            set
            {
                if (this.autoCallFlag_ != value)
                {
                    this.autoCallFlag_ = value;
                }
            }
        }
        #endregion
        
        public string autoCallFlagIDRef_ { get; set; }
        #region AutoCallFixingDate_
        private XsdTypeDate autoCallFixingDate_;
        public XsdTypeDate AutoCallFixingDate_
        {
            get
            {
                if (this.autoCallFixingDate_ != null)
                {
                    return this.autoCallFixingDate_; 
                }
                else if (this.autoCallFixingDateIDRef_ != null)
                {
                    autoCallFixingDate_ = IDManager.getID(autoCallFixingDateIDRef_) as XsdTypeDate;
                    return this.autoCallFixingDate_; 
                }
                else
                {
                    throw new Exception( "autoCallFixingDate_Node no exist!");
                }
            }
            set
            {
                if (this.autoCallFixingDate_ != value)
                {
                    this.autoCallFixingDate_ = value;
                }
            }
        }
        #endregion
        
        public string autoCallFixingDateIDRef_ { get; set; }
        
    
        
    
    }
    
}

