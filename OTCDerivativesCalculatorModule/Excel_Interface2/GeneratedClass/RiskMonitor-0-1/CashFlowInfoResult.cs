using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CashFlowInfoResult : ISerialized
    {
        public CashFlowInfoResult() { }
        public CashFlowInfoResult(XmlNode xmlNode)
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
            
        
            XmlNode simpleCashFlowResultNode = xmlNode.SelectSingleNode("simpleCashFlowResult");
            
            if (simpleCashFlowResultNode != null)
            {
                if (simpleCashFlowResultNode.Attributes["href"] != null || simpleCashFlowResultNode.Attributes["id"] != null) 
                {
                    if (simpleCashFlowResultNode.Attributes["id"] != null) 
                    {
                        simpleCashFlowResultIDRef_ = simpleCashFlowResultNode.Attributes["id"].Value;
                        SimpleCashFlowResult ob = new SimpleCashFlowResult(simpleCashFlowResultNode);
                        IDManager.SetID(simpleCashFlowResultIDRef_, ob);
                    }
                    else if (simpleCashFlowResultNode.Attributes["href"] != null)
                    {
                        simpleCashFlowResultIDRef_ = simpleCashFlowResultNode.Attributes["href"].Value;
                    }
                    else
                    {
                        simpleCashFlowResult_ = new SimpleCashFlowResult(simpleCashFlowResultNode);
                    }
                }
                else
                {
                    simpleCashFlowResult_ = new SimpleCashFlowResult(simpleCashFlowResultNode);
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
        #region SimpleCashFlowResult_
        private SimpleCashFlowResult simpleCashFlowResult_;
        public SimpleCashFlowResult SimpleCashFlowResult_
        {
            get
            {
                if (this.simpleCashFlowResult_ != null)
                {
                    return this.simpleCashFlowResult_; 
                }
                else if (this.simpleCashFlowResultIDRef_ != null)
                {
                    simpleCashFlowResult_ = IDManager.getID(simpleCashFlowResultIDRef_) as SimpleCashFlowResult;
                    return this.simpleCashFlowResult_; 
                }
                else
                {
                    throw new Exception( "simpleCashFlowResult_Node no exist!");
                }
            }
            set
            {
                if (this.simpleCashFlowResult_ != value)
                {
                    this.simpleCashFlowResult_ = value;
                }
            }
        }
        #endregion
        
        public string simpleCashFlowResultIDRef_ { get; set; }
        public string choiceStr_cashFlowType;
        
    
        
    
    }
    
}

