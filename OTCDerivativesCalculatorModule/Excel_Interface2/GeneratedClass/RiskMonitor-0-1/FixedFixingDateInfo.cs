using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FixedFixingDateInfo : ISerialized
    {
        public FixedFixingDateInfo() { }
        public FixedFixingDateInfo(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode dateNode = xmlNode.SelectSingleNode("date");
            
            if (dateNode != null)
            {
                if (dateNode.Attributes["href"] != null || dateNode.Attributes["id"] != null) 
                {
                    if (dateNode.Attributes["id"] != null) 
                    {
                        dateIDRef_ = dateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(dateNode);
                        IDManager.SetID(dateIDRef_, ob);
                    }
                    else if (dateNode.Attributes["href"] != null)
                    {
                        dateIDRef_ = dateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        date_ = new XsdTypeToken(dateNode);
                    }
                }
                else
                {
                    date_ = new XsdTypeToken(dateNode);
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
        
    
        #region Date_
        private XsdTypeToken date_;
        public XsdTypeToken Date_
        {
            get
            {
                if (this.date_ != null)
                {
                    return this.date_; 
                }
                else if (this.dateIDRef_ != null)
                {
                    date_ = IDManager.getID(dateIDRef_) as XsdTypeToken;
                    return this.date_; 
                }
                else
                {
                    throw new Exception( "date_Node no exist!");
                }
            }
            set
            {
                if (this.date_ != value)
                {
                    this.date_ = value;
                }
            }
        }
        #endregion
        
        public string dateIDRef_ { get; set; }
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

