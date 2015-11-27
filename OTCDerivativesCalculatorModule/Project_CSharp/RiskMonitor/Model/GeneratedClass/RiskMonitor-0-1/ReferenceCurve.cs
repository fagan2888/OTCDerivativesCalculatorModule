using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ReferenceCurve : ISerialized
    {
        public ReferenceCurve() { }
        public ReferenceCurve(XmlNode xmlNode)
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
            
        
            XmlNode cdsSpreadTermstructureNode = xmlNode.SelectSingleNode("cdsSpreadTermstructure");
            
            if (cdsSpreadTermstructureNode != null)
            {
                if (cdsSpreadTermstructureNode.Attributes["href"] != null || cdsSpreadTermstructureNode.Attributes["id"] != null) 
                {
                    if (cdsSpreadTermstructureNode.Attributes["id"] != null) 
                    {
                        cdsSpreadTermstructureIDRef_ = cdsSpreadTermstructureNode.Attributes["id"].Value;
                        CdsSpreadTermstructure ob = new CdsSpreadTermstructure(cdsSpreadTermstructureNode);
                        IDManager.SetID(cdsSpreadTermstructureIDRef_, ob);
                    }
                    else if (cdsSpreadTermstructureNode.Attributes["href"] != null)
                    {
                        cdsSpreadTermstructureIDRef_ = cdsSpreadTermstructureNode.Attributes["href"].Value;
                    }
                    else
                    {
                        cdsSpreadTermstructure_ = new CdsSpreadTermstructure(cdsSpreadTermstructureNode);
                    }
                }
                else
                {
                    cdsSpreadTermstructure_ = new CdsSpreadTermstructure(cdsSpreadTermstructureNode);
                }
            }
            
        
            XmlNode yieldTermstructureNode = xmlNode.SelectSingleNode("yieldTermstructure");
            
            if (yieldTermstructureNode != null)
            {
                if (yieldTermstructureNode.Attributes["href"] != null || yieldTermstructureNode.Attributes["id"] != null) 
                {
                    if (yieldTermstructureNode.Attributes["id"] != null) 
                    {
                        yieldTermstructureIDRef_ = yieldTermstructureNode.Attributes["id"].Value;
                        YieldTermstructure ob = new YieldTermstructure(yieldTermstructureNode);
                        IDManager.SetID(yieldTermstructureIDRef_, ob);
                    }
                    else if (yieldTermstructureNode.Attributes["href"] != null)
                    {
                        yieldTermstructureIDRef_ = yieldTermstructureNode.Attributes["href"].Value;
                    }
                    else
                    {
                        yieldTermstructure_ = new YieldTermstructure(yieldTermstructureNode);
                    }
                }
                else
                {
                    yieldTermstructure_ = new YieldTermstructure(yieldTermstructureNode);
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
        #region CdsSpreadTermstructure_
        private CdsSpreadTermstructure cdsSpreadTermstructure_;
        public CdsSpreadTermstructure CdsSpreadTermstructure_
        {
            get
            {
                if (this.cdsSpreadTermstructure_ != null)
                {
                    return this.cdsSpreadTermstructure_; 
                }
                else if (this.cdsSpreadTermstructureIDRef_ != null)
                {
                    cdsSpreadTermstructure_ = IDManager.getID(cdsSpreadTermstructureIDRef_) as CdsSpreadTermstructure;
                    return this.cdsSpreadTermstructure_; 
                }
                else
                {
                    throw new Exception( "cdsSpreadTermstructure_Node no exist!");
                }
            }
            set
            {
                if (this.cdsSpreadTermstructure_ != value)
                {
                    this.cdsSpreadTermstructure_ = value;
                }
            }
        }
        #endregion
        
        public string cdsSpreadTermstructureIDRef_ { get; set; }
        #region YieldTermstructure_
        private YieldTermstructure yieldTermstructure_;
        public YieldTermstructure YieldTermstructure_
        {
            get
            {
                if (this.yieldTermstructure_ != null)
                {
                    return this.yieldTermstructure_; 
                }
                else if (this.yieldTermstructureIDRef_ != null)
                {
                    yieldTermstructure_ = IDManager.getID(yieldTermstructureIDRef_) as YieldTermstructure;
                    return this.yieldTermstructure_; 
                }
                else
                {
                    throw new Exception( "yieldTermstructure_Node no exist!");
                }
            }
            set
            {
                if (this.yieldTermstructure_ != value)
                {
                    this.yieldTermstructure_ = value;
                }
            }
        }
        #endregion
        
        public string yieldTermstructureIDRef_ { get; set; }
        public string choiceStr_tsType;
        
    
        
    
    }
    
}

