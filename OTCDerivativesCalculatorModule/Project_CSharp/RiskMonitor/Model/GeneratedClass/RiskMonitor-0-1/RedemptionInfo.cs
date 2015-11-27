using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class RedemptionInfo : ISerialized
    {
        public RedemptionInfo() { }
        public RedemptionInfo(XmlNode xmlNode)
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
            
        
            XmlNode autoCallRedemNode = xmlNode.SelectSingleNode("autoCallRedem");
            
            if (autoCallRedemNode != null)
            {
                if (autoCallRedemNode.Attributes["href"] != null || autoCallRedemNode.Attributes["id"] != null) 
                {
                    if (autoCallRedemNode.Attributes["id"] != null) 
                    {
                        autoCallRedemIDRef_ = autoCallRedemNode.Attributes["id"].Value;
                        AutoCallRedem ob = new AutoCallRedem(autoCallRedemNode);
                        IDManager.SetID(autoCallRedemIDRef_, ob);
                    }
                    else if (autoCallRedemNode.Attributes["href"] != null)
                    {
                        autoCallRedemIDRef_ = autoCallRedemNode.Attributes["href"].Value;
                    }
                    else
                    {
                        autoCallRedem_ = new AutoCallRedem(autoCallRedemNode);
                    }
                }
                else
                {
                    autoCallRedem_ = new AutoCallRedem(autoCallRedemNode);
                }
            }
            
        
            XmlNode monthlyAutoCallRedemNode = xmlNode.SelectSingleNode("monthlyAutoCallRedem");
            
            if (monthlyAutoCallRedemNode != null)
            {
                if (monthlyAutoCallRedemNode.Attributes["href"] != null || monthlyAutoCallRedemNode.Attributes["id"] != null) 
                {
                    if (monthlyAutoCallRedemNode.Attributes["id"] != null) 
                    {
                        monthlyAutoCallRedemIDRef_ = monthlyAutoCallRedemNode.Attributes["id"].Value;
                        MonthlyAutoCallRedem ob = new MonthlyAutoCallRedem(monthlyAutoCallRedemNode);
                        IDManager.SetID(monthlyAutoCallRedemIDRef_, ob);
                    }
                    else if (monthlyAutoCallRedemNode.Attributes["href"] != null)
                    {
                        monthlyAutoCallRedemIDRef_ = monthlyAutoCallRedemNode.Attributes["href"].Value;
                    }
                    else
                    {
                        monthlyAutoCallRedem_ = new MonthlyAutoCallRedem(monthlyAutoCallRedemNode);
                    }
                }
                else
                {
                    monthlyAutoCallRedem_ = new MonthlyAutoCallRedem(monthlyAutoCallRedemNode);
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
        #region AutoCallRedem_
        private AutoCallRedem autoCallRedem_;
        public AutoCallRedem AutoCallRedem_
        {
            get
            {
                if (this.autoCallRedem_ != null)
                {
                    return this.autoCallRedem_; 
                }
                else if (this.autoCallRedemIDRef_ != null)
                {
                    autoCallRedem_ = IDManager.getID(autoCallRedemIDRef_) as AutoCallRedem;
                    return this.autoCallRedem_; 
                }
                else
                {
                    throw new Exception( "autoCallRedem_Node no exist!");
                }
            }
            set
            {
                if (this.autoCallRedem_ != value)
                {
                    this.autoCallRedem_ = value;
                }
            }
        }
        #endregion
        
        public string autoCallRedemIDRef_ { get; set; }
        #region MonthlyAutoCallRedem_
        private MonthlyAutoCallRedem monthlyAutoCallRedem_;
        public MonthlyAutoCallRedem MonthlyAutoCallRedem_
        {
            get
            {
                if (this.monthlyAutoCallRedem_ != null)
                {
                    return this.monthlyAutoCallRedem_; 
                }
                else if (this.monthlyAutoCallRedemIDRef_ != null)
                {
                    monthlyAutoCallRedem_ = IDManager.getID(monthlyAutoCallRedemIDRef_) as MonthlyAutoCallRedem;
                    return this.monthlyAutoCallRedem_; 
                }
                else
                {
                    throw new Exception( "monthlyAutoCallRedem_Node no exist!");
                }
            }
            set
            {
                if (this.monthlyAutoCallRedem_ != value)
                {
                    this.monthlyAutoCallRedem_ = value;
                }
            }
        }
        #endregion
        
        public string monthlyAutoCallRedemIDRef_ { get; set; }
        public string choiceStr_redemptionType;
        
    
        
    
    }
    
}

