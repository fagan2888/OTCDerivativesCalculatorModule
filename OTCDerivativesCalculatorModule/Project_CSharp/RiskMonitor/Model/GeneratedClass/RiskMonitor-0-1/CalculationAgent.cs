using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CalculationAgent : ISerialized
    {
        public CalculationAgent() { }
        public CalculationAgent(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode calculationAgentPartyNode = xmlNode.SelectSingleNode("calculationAgentParty");
            
            if (calculationAgentPartyNode != null)
            {
                if (calculationAgentPartyNode.Attributes["href"] != null || calculationAgentPartyNode.Attributes["id"] != null) 
                {
                    if (calculationAgentPartyNode.Attributes["id"] != null) 
                    {
                        calculationAgentPartyIDRef_ = calculationAgentPartyNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(calculationAgentPartyNode);
                        IDManager.SetID(calculationAgentPartyIDRef_, ob);
                    }
                    else if (calculationAgentPartyNode.Attributes["href"] != null)
                    {
                        calculationAgentPartyIDRef_ = calculationAgentPartyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationAgentParty_ = new XsdTypeToken(calculationAgentPartyNode);
                    }
                }
                else
                {
                    calculationAgentParty_ = new XsdTypeToken(calculationAgentPartyNode);
                }
            }
            
        
        }
        
    
        #region CalculationAgentParty_
        private XsdTypeToken calculationAgentParty_;
        public XsdTypeToken CalculationAgentParty_
        {
            get
            {
                if (this.calculationAgentParty_ != null)
                {
                    return this.calculationAgentParty_; 
                }
                else if (this.calculationAgentPartyIDRef_ != null)
                {
                    calculationAgentParty_ = IDManager.getID(calculationAgentPartyIDRef_) as XsdTypeToken;
                    return this.calculationAgentParty_; 
                }
                else
                {
                    throw new Exception( "calculationAgentParty_Node no exist!");
                }
            }
            set
            {
                if (this.calculationAgentParty_ != value)
                {
                    this.calculationAgentParty_ = value;
                }
            }
        }
        #endregion
        
        public string calculationAgentPartyIDRef_ { get; set; }
        
    
        
    
    }
    
}

