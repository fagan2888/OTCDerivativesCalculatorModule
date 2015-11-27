using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CalculationAgent : ISerialized
    {
        public CalculationAgent(XmlNode xmlNode)
        {
            XmlNodeList calculationAgentPartyReferenceNodeList = xmlNode.SelectNodes("calculationAgentPartyReference");
            
            if (calculationAgentPartyReferenceNodeList != null)
            {
                this.calculationAgentPartyReference_ = new List<PartyReference>();
                foreach (XmlNode item in calculationAgentPartyReferenceNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            calculationAgentPartyReferenceIDRef_ = item.Attributes["id"].Value;
                            calculationAgentPartyReference_.Add(new PartyReference(item));
                            IDManager.SetID(calculationAgentPartyReferenceIDRef_, calculationAgentPartyReference_[calculationAgentPartyReference_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            calculationAgentPartyReferenceIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        calculationAgentPartyReference_.Add(new PartyReference(item));
                        }
                    }
                    else
                    {
                        calculationAgentPartyReference_.Add(new PartyReference(item));
                    }
                }
            }
            
        
            XmlNode calculationAgentPartyNode = xmlNode.SelectSingleNode("calculationAgentParty");
            
            if (calculationAgentPartyNode != null)
            {
                if (calculationAgentPartyNode.Attributes["href"] != null || calculationAgentPartyNode.Attributes["id"] != null) 
                {
                    if (calculationAgentPartyNode.Attributes["id"] != null) 
                    {
                        calculationAgentPartyIDRef_ = calculationAgentPartyNode.Attributes["id"].Value;
                        CalculationAgentPartyEnum ob = new CalculationAgentPartyEnum(calculationAgentPartyNode);
                        IDManager.SetID(calculationAgentPartyIDRef_, ob);
                    }
                    else if (calculationAgentPartyNode.Attributes["href"] != null)
                    {
                        calculationAgentPartyIDRef_ = calculationAgentPartyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationAgentParty_ = new CalculationAgentPartyEnum(calculationAgentPartyNode);
                    }
                }
                else
                {
                    calculationAgentParty_ = new CalculationAgentPartyEnum(calculationAgentPartyNode);
                }
            }
            
        
        }
        
    
        #region CalculationAgentPartyReference_
        private List<PartyReference> calculationAgentPartyReference_;
        public List<PartyReference> CalculationAgentPartyReference_
        {
            get
            {
                if (this.calculationAgentPartyReference_ != null)
                {
                    return this.calculationAgentPartyReference_; 
                }
                else if (this.calculationAgentPartyReferenceIDRef_ != null)
                {
                    return this.calculationAgentPartyReference_; 
                }
                else
                {
                      return this.calculationAgentPartyReference_; 
                }
            }
            set
            {
                if (this.calculationAgentPartyReference_ != value)
                {
                    this.calculationAgentPartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string calculationAgentPartyReferenceIDRef_ { get; set; }
        #region CalculationAgentParty_
        private CalculationAgentPartyEnum calculationAgentParty_;
        public CalculationAgentPartyEnum CalculationAgentParty_
        {
            get
            {
                if (this.calculationAgentParty_ != null)
                {
                    return this.calculationAgentParty_; 
                }
                else if (this.calculationAgentPartyIDRef_ != null)
                {
                    calculationAgentParty_ = IDManager.getID(calculationAgentPartyIDRef_) as CalculationAgentPartyEnum;
                    return this.calculationAgentParty_; 
                }
                else
                {
                      return this.calculationAgentParty_; 
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
        public string choiceStr_0;
        
    
        
    
    }
    
}

