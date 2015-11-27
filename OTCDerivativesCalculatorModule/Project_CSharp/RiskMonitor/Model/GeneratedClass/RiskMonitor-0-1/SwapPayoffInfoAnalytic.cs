using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SwapPayoffInfoAnalytic : ISerialized
    {
        public SwapPayoffInfoAnalytic() { }
        public SwapPayoffInfoAnalytic(XmlNode xmlNode)
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
            
        
            XmlNode interestRateSwapPayoff_ANode = xmlNode.SelectSingleNode("interestRateSwapPayoff_A");
            
            if (interestRateSwapPayoff_ANode != null)
            {
                if (interestRateSwapPayoff_ANode.Attributes["href"] != null || interestRateSwapPayoff_ANode.Attributes["id"] != null) 
                {
                    if (interestRateSwapPayoff_ANode.Attributes["id"] != null) 
                    {
                        interestRateSwapPayoff_AIDRef_ = interestRateSwapPayoff_ANode.Attributes["id"].Value;
                        InterestRateSwapPayoff_A ob = new InterestRateSwapPayoff_A(interestRateSwapPayoff_ANode);
                        IDManager.SetID(interestRateSwapPayoff_AIDRef_, ob);
                    }
                    else if (interestRateSwapPayoff_ANode.Attributes["href"] != null)
                    {
                        interestRateSwapPayoff_AIDRef_ = interestRateSwapPayoff_ANode.Attributes["href"].Value;
                    }
                    else
                    {
                        interestRateSwapPayoff_A_ = new InterestRateSwapPayoff_A(interestRateSwapPayoff_ANode);
                    }
                }
                else
                {
                    interestRateSwapPayoff_A_ = new InterestRateSwapPayoff_A(interestRateSwapPayoff_ANode);
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
        #region InterestRateSwapPayoff_A_
        private InterestRateSwapPayoff_A interestRateSwapPayoff_A_;
        public InterestRateSwapPayoff_A InterestRateSwapPayoff_A_
        {
            get
            {
                if (this.interestRateSwapPayoff_A_ != null)
                {
                    return this.interestRateSwapPayoff_A_; 
                }
                else if (this.interestRateSwapPayoff_AIDRef_ != null)
                {
                    interestRateSwapPayoff_A_ = IDManager.getID(interestRateSwapPayoff_AIDRef_) as InterestRateSwapPayoff_A;
                    return this.interestRateSwapPayoff_A_; 
                }
                else
                {
                    throw new Exception( "interestRateSwapPayoff_A_Node no exist!");
                }
            }
            set
            {
                if (this.interestRateSwapPayoff_A_ != value)
                {
                    this.interestRateSwapPayoff_A_ = value;
                }
            }
        }
        #endregion
        
        public string interestRateSwapPayoff_AIDRef_ { get; set; }
        public string choiceStr_swapPayoffType_A;
        
    
        
    
    }
    
}

