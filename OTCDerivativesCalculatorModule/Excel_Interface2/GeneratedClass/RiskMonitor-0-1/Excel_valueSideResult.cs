using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_valueSideResult : ISerialized
    {
        public Excel_valueSideResult() { }
        public Excel_valueSideResult(XmlNode xmlNode)
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
            
        
            XmlNode currencyNode = xmlNode.SelectSingleNode("currency");
            
            if (currencyNode != null)
            {
                if (currencyNode.Attributes["href"] != null || currencyNode.Attributes["id"] != null) 
                {
                    if (currencyNode.Attributes["id"] != null) 
                    {
                        currencyIDRef_ = currencyNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(currencyNode);
                        IDManager.SetID(currencyIDRef_, ob);
                    }
                    else if (currencyNode.Attributes["href"] != null)
                    {
                        currencyIDRef_ = currencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        currency_ = new XsdTypeDouble(currencyNode);
                    }
                }
                else
                {
                    currency_ = new XsdTypeDouble(currencyNode);
                }
            }
            
        
            XmlNode dirtyNode = xmlNode.SelectSingleNode("dirty");
            
            if (dirtyNode != null)
            {
                if (dirtyNode.Attributes["href"] != null || dirtyNode.Attributes["id"] != null) 
                {
                    if (dirtyNode.Attributes["id"] != null) 
                    {
                        dirtyIDRef_ = dirtyNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(dirtyNode);
                        IDManager.SetID(dirtyIDRef_, ob);
                    }
                    else if (dirtyNode.Attributes["href"] != null)
                    {
                        dirtyIDRef_ = dirtyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dirty_ = new XsdTypeDouble(dirtyNode);
                    }
                }
                else
                {
                    dirty_ = new XsdTypeDouble(dirtyNode);
                }
            }
            
        
            XmlNode cleanNode = xmlNode.SelectSingleNode("clean");
            
            if (cleanNode != null)
            {
                if (cleanNode.Attributes["href"] != null || cleanNode.Attributes["id"] != null) 
                {
                    if (cleanNode.Attributes["id"] != null) 
                    {
                        cleanIDRef_ = cleanNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(cleanNode);
                        IDManager.SetID(cleanIDRef_, ob);
                    }
                    else if (cleanNode.Attributes["href"] != null)
                    {
                        cleanIDRef_ = cleanNode.Attributes["href"].Value;
                    }
                    else
                    {
                        clean_ = new XsdTypeDouble(cleanNode);
                    }
                }
                else
                {
                    clean_ = new XsdTypeDouble(cleanNode);
                }
            }
            
        
            XmlNode accrualAmtNode = xmlNode.SelectSingleNode("accrualAmt");
            
            if (accrualAmtNode != null)
            {
                if (accrualAmtNode.Attributes["href"] != null || accrualAmtNode.Attributes["id"] != null) 
                {
                    if (accrualAmtNode.Attributes["id"] != null) 
                    {
                        accrualAmtIDRef_ = accrualAmtNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(accrualAmtNode);
                        IDManager.SetID(accrualAmtIDRef_, ob);
                    }
                    else if (accrualAmtNode.Attributes["href"] != null)
                    {
                        accrualAmtIDRef_ = accrualAmtNode.Attributes["href"].Value;
                    }
                    else
                    {
                        accrualAmt_ = new XsdTypeDouble(accrualAmtNode);
                    }
                }
                else
                {
                    accrualAmt_ = new XsdTypeDouble(accrualAmtNode);
                }
            }
            
        
            XmlNode optionNode = xmlNode.SelectSingleNode("option");
            
            if (optionNode != null)
            {
                if (optionNode.Attributes["href"] != null || optionNode.Attributes["id"] != null) 
                {
                    if (optionNode.Attributes["id"] != null) 
                    {
                        optionIDRef_ = optionNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(optionNode);
                        IDManager.SetID(optionIDRef_, ob);
                    }
                    else if (optionNode.Attributes["href"] != null)
                    {
                        optionIDRef_ = optionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        option_ = new XsdTypeDouble(optionNode);
                    }
                }
                else
                {
                    option_ = new XsdTypeDouble(optionNode);
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
        #region Currency_
        private XsdTypeDouble currency_;
        public XsdTypeDouble Currency_
        {
            get
            {
                if (this.currency_ != null)
                {
                    return this.currency_; 
                }
                else if (this.currencyIDRef_ != null)
                {
                    currency_ = IDManager.getID(currencyIDRef_) as XsdTypeDouble;
                    return this.currency_; 
                }
                else
                {
                    throw new Exception( "currency_Node no exist!");
                }
            }
            set
            {
                if (this.currency_ != value)
                {
                    this.currency_ = value;
                }
            }
        }
        #endregion
        
        public string currencyIDRef_ { get; set; }
        #region Dirty_
        private XsdTypeDouble dirty_;
        public XsdTypeDouble Dirty_
        {
            get
            {
                if (this.dirty_ != null)
                {
                    return this.dirty_; 
                }
                else if (this.dirtyIDRef_ != null)
                {
                    dirty_ = IDManager.getID(dirtyIDRef_) as XsdTypeDouble;
                    return this.dirty_; 
                }
                else
                {
                    throw new Exception( "dirty_Node no exist!");
                }
            }
            set
            {
                if (this.dirty_ != value)
                {
                    this.dirty_ = value;
                }
            }
        }
        #endregion
        
        public string dirtyIDRef_ { get; set; }
        #region Clean_
        private XsdTypeDouble clean_;
        public XsdTypeDouble Clean_
        {
            get
            {
                if (this.clean_ != null)
                {
                    return this.clean_; 
                }
                else if (this.cleanIDRef_ != null)
                {
                    clean_ = IDManager.getID(cleanIDRef_) as XsdTypeDouble;
                    return this.clean_; 
                }
                else
                {
                    throw new Exception( "clean_Node no exist!");
                }
            }
            set
            {
                if (this.clean_ != value)
                {
                    this.clean_ = value;
                }
            }
        }
        #endregion
        
        public string cleanIDRef_ { get; set; }
        #region AccrualAmt_
        private XsdTypeDouble accrualAmt_;
        public XsdTypeDouble AccrualAmt_
        {
            get
            {
                if (this.accrualAmt_ != null)
                {
                    return this.accrualAmt_; 
                }
                else if (this.accrualAmtIDRef_ != null)
                {
                    accrualAmt_ = IDManager.getID(accrualAmtIDRef_) as XsdTypeDouble;
                    return this.accrualAmt_; 
                }
                else
                {
                    throw new Exception( "accrualAmt_Node no exist!");
                }
            }
            set
            {
                if (this.accrualAmt_ != value)
                {
                    this.accrualAmt_ = value;
                }
            }
        }
        #endregion
        
        public string accrualAmtIDRef_ { get; set; }
        #region Option_
        private XsdTypeDouble option_;
        public XsdTypeDouble Option_
        {
            get
            {
                if (this.option_ != null)
                {
                    return this.option_; 
                }
                else if (this.optionIDRef_ != null)
                {
                    option_ = IDManager.getID(optionIDRef_) as XsdTypeDouble;
                    return this.option_; 
                }
                else
                {
                    throw new Exception( "option_Node no exist!");
                }
            }
            set
            {
                if (this.option_ != value)
                {
                    this.option_ = value;
                }
            }
        }
        #endregion
        
        public string optionIDRef_ { get; set; }
        
    
        
    
    }
    
}

