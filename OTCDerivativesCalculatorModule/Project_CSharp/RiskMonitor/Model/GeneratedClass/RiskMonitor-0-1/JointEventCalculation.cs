using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class JointEventCalculation : ISerialized
    {
        public JointEventCalculation() { }
        public JointEventCalculation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode typeNode = xmlNode.SelectSingleNode("type");
            
            if (typeNode != null)
            {
                if (typeNode.Attributes["href"] != null || typeNode.Attributes["id"] != null) 
                {
                    if (typeNode.Attributes["id"] != null) 
                    {
                        typeIDRef_ = typeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(typeNode);
                        IDManager.SetID(typeIDRef_, ob);
                    }
                    else if (typeNode.Attributes["href"] != null)
                    {
                        typeIDRef_ = typeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        type_ = new XsdTypeToken(typeNode);
                    }
                }
                else
                {
                    type_ = new XsdTypeToken(typeNode);
                }
            }
            
        
            XmlNode andEventCalNode = xmlNode.SelectSingleNode("andEventCal");
            
            if (andEventCalNode != null)
            {
                if (andEventCalNode.Attributes["href"] != null || andEventCalNode.Attributes["id"] != null) 
                {
                    if (andEventCalNode.Attributes["id"] != null) 
                    {
                        andEventCalIDRef_ = andEventCalNode.Attributes["id"].Value;
                        AndEventCal ob = new AndEventCal(andEventCalNode);
                        IDManager.SetID(andEventCalIDRef_, ob);
                    }
                    else if (andEventCalNode.Attributes["href"] != null)
                    {
                        andEventCalIDRef_ = andEventCalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        andEventCal_ = new AndEventCal(andEventCalNode);
                    }
                }
                else
                {
                    andEventCal_ = new AndEventCal(andEventCalNode);
                }
            }
            
        
            XmlNode orEventCalNode = xmlNode.SelectSingleNode("orEventCal");
            
            if (orEventCalNode != null)
            {
                if (orEventCalNode.Attributes["href"] != null || orEventCalNode.Attributes["id"] != null) 
                {
                    if (orEventCalNode.Attributes["id"] != null) 
                    {
                        orEventCalIDRef_ = orEventCalNode.Attributes["id"].Value;
                        OrEventCal ob = new OrEventCal(orEventCalNode);
                        IDManager.SetID(orEventCalIDRef_, ob);
                    }
                    else if (orEventCalNode.Attributes["href"] != null)
                    {
                        orEventCalIDRef_ = orEventCalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        orEventCal_ = new OrEventCal(orEventCalNode);
                    }
                }
                else
                {
                    orEventCal_ = new OrEventCal(orEventCalNode);
                }
            }
            
        
            XmlNode atLeastEventCalNode = xmlNode.SelectSingleNode("atLeastEventCal");
            
            if (atLeastEventCalNode != null)
            {
                if (atLeastEventCalNode.Attributes["href"] != null || atLeastEventCalNode.Attributes["id"] != null) 
                {
                    if (atLeastEventCalNode.Attributes["id"] != null) 
                    {
                        atLeastEventCalIDRef_ = atLeastEventCalNode.Attributes["id"].Value;
                        AtLeastEventCal ob = new AtLeastEventCal(atLeastEventCalNode);
                        IDManager.SetID(atLeastEventCalIDRef_, ob);
                    }
                    else if (atLeastEventCalNode.Attributes["href"] != null)
                    {
                        atLeastEventCalIDRef_ = atLeastEventCalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        atLeastEventCal_ = new AtLeastEventCal(atLeastEventCalNode);
                    }
                }
                else
                {
                    atLeastEventCal_ = new AtLeastEventCal(atLeastEventCalNode);
                }
            }
            
        
            XmlNode atMostEventCalNode = xmlNode.SelectSingleNode("atMostEventCal");
            
            if (atMostEventCalNode != null)
            {
                if (atMostEventCalNode.Attributes["href"] != null || atMostEventCalNode.Attributes["id"] != null) 
                {
                    if (atMostEventCalNode.Attributes["id"] != null) 
                    {
                        atMostEventCalIDRef_ = atMostEventCalNode.Attributes["id"].Value;
                        AtMostEventCal ob = new AtMostEventCal(atMostEventCalNode);
                        IDManager.SetID(atMostEventCalIDRef_, ob);
                    }
                    else if (atMostEventCalNode.Attributes["href"] != null)
                    {
                        atMostEventCalIDRef_ = atMostEventCalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        atMostEventCal_ = new AtMostEventCal(atMostEventCalNode);
                    }
                }
                else
                {
                    atMostEventCal_ = new AtMostEventCal(atMostEventCalNode);
                }
            }
            
        
            XmlNode countEventCalNode = xmlNode.SelectSingleNode("countEventCal");
            
            if (countEventCalNode != null)
            {
                if (countEventCalNode.Attributes["href"] != null || countEventCalNode.Attributes["id"] != null) 
                {
                    if (countEventCalNode.Attributes["id"] != null) 
                    {
                        countEventCalIDRef_ = countEventCalNode.Attributes["id"].Value;
                        CountEventCal ob = new CountEventCal(countEventCalNode);
                        IDManager.SetID(countEventCalIDRef_, ob);
                    }
                    else if (countEventCalNode.Attributes["href"] != null)
                    {
                        countEventCalIDRef_ = countEventCalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        countEventCal_ = new CountEventCal(countEventCalNode);
                    }
                }
                else
                {
                    countEventCal_ = new CountEventCal(countEventCalNode);
                }
            }
            
        
        }
        
    
        #region Type_
        private XsdTypeToken type_;
        public XsdTypeToken Type_
        {
            get
            {
                if (this.type_ != null)
                {
                    return this.type_; 
                }
                else if (this.typeIDRef_ != null)
                {
                    type_ = IDManager.getID(typeIDRef_) as XsdTypeToken;
                    return this.type_; 
                }
                else
                {
                    throw new Exception( "type_Node no exist!");
                }
            }
            set
            {
                if (this.type_ != value)
                {
                    this.type_ = value;
                }
            }
        }
        #endregion
        
        public string typeIDRef_ { get; set; }
        #region AndEventCal_
        private AndEventCal andEventCal_;
        public AndEventCal AndEventCal_
        {
            get
            {
                if (this.andEventCal_ != null)
                {
                    return this.andEventCal_; 
                }
                else if (this.andEventCalIDRef_ != null)
                {
                    andEventCal_ = IDManager.getID(andEventCalIDRef_) as AndEventCal;
                    return this.andEventCal_; 
                }
                else
                {
                    throw new Exception( "andEventCal_Node no exist!");
                }
            }
            set
            {
                if (this.andEventCal_ != value)
                {
                    this.andEventCal_ = value;
                }
            }
        }
        #endregion
        
        public string andEventCalIDRef_ { get; set; }
        #region OrEventCal_
        private OrEventCal orEventCal_;
        public OrEventCal OrEventCal_
        {
            get
            {
                if (this.orEventCal_ != null)
                {
                    return this.orEventCal_; 
                }
                else if (this.orEventCalIDRef_ != null)
                {
                    orEventCal_ = IDManager.getID(orEventCalIDRef_) as OrEventCal;
                    return this.orEventCal_; 
                }
                else
                {
                    throw new Exception( "orEventCal_Node no exist!");
                }
            }
            set
            {
                if (this.orEventCal_ != value)
                {
                    this.orEventCal_ = value;
                }
            }
        }
        #endregion
        
        public string orEventCalIDRef_ { get; set; }
        #region AtLeastEventCal_
        private AtLeastEventCal atLeastEventCal_;
        public AtLeastEventCal AtLeastEventCal_
        {
            get
            {
                if (this.atLeastEventCal_ != null)
                {
                    return this.atLeastEventCal_; 
                }
                else if (this.atLeastEventCalIDRef_ != null)
                {
                    atLeastEventCal_ = IDManager.getID(atLeastEventCalIDRef_) as AtLeastEventCal;
                    return this.atLeastEventCal_; 
                }
                else
                {
                    throw new Exception( "atLeastEventCal_Node no exist!");
                }
            }
            set
            {
                if (this.atLeastEventCal_ != value)
                {
                    this.atLeastEventCal_ = value;
                }
            }
        }
        #endregion
        
        public string atLeastEventCalIDRef_ { get; set; }
        #region AtMostEventCal_
        private AtMostEventCal atMostEventCal_;
        public AtMostEventCal AtMostEventCal_
        {
            get
            {
                if (this.atMostEventCal_ != null)
                {
                    return this.atMostEventCal_; 
                }
                else if (this.atMostEventCalIDRef_ != null)
                {
                    atMostEventCal_ = IDManager.getID(atMostEventCalIDRef_) as AtMostEventCal;
                    return this.atMostEventCal_; 
                }
                else
                {
                    throw new Exception( "atMostEventCal_Node no exist!");
                }
            }
            set
            {
                if (this.atMostEventCal_ != value)
                {
                    this.atMostEventCal_ = value;
                }
            }
        }
        #endregion
        
        public string atMostEventCalIDRef_ { get; set; }
        #region CountEventCal_
        private CountEventCal countEventCal_;
        public CountEventCal CountEventCal_
        {
            get
            {
                if (this.countEventCal_ != null)
                {
                    return this.countEventCal_; 
                }
                else if (this.countEventCalIDRef_ != null)
                {
                    countEventCal_ = IDManager.getID(countEventCalIDRef_) as CountEventCal;
                    return this.countEventCal_; 
                }
                else
                {
                    throw new Exception( "countEventCal_Node no exist!");
                }
            }
            set
            {
                if (this.countEventCal_ != value)
                {
                    this.countEventCal_ = value;
                }
            }
        }
        #endregion
        
        public string countEventCalIDRef_ { get; set; }
        public string choiceStr_jointEventType;
        
    
        
    
    }
    
}

