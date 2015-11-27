using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CalculationAgent
    {
        public CalculationAgent(XmlNode xmlNode)
        {
            XmlNodeList calculationAgentPartyReferenceNodeList = xmlNode.SelectNodes("calculationAgentPartyReference");
            
            foreach (XmlNode item in calculationAgentPartyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationAgentPartyReferenceIDRef = item.Attributes["id"].Name;
                        List<PartyReference> ob = new List<PartyReference>();
                        ob.Add(new PartyReference(item));
                        IDManager.SetID(calculationAgentPartyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationAgentPartyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    calculationAgentPartyReference.Add(new PartyReference(item));
                    }
                }
            }
            
        
            XmlNodeList calculationAgentPartyNodeList = xmlNode.SelectNodes("calculationAgentParty");
            if (calculationAgentPartyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculationAgentPartyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationAgentPartyIDRef = item.Attributes["id"].Name;
                        CalculationAgentPartyEnum ob = CalculationAgentPartyEnum();
                        IDManager.SetID(calculationAgentPartyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationAgentPartyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculationAgentParty = new CalculationAgentPartyEnum(item);
                    }
                }
            }
            
        
        }
        
    
        #region CalculationAgentPartyReference
        private List<PartyReference> calculationAgentPartyReference;
        public List<PartyReference> CalculationAgentPartyReference
        {
            get
            {
                if (this.calculationAgentPartyReference != null)
                {
                    return this.calculationAgentPartyReference; 
                }
                else if (this.calculationAgentPartyReferenceIDRef != null)
                {
                    calculationAgentPartyReference = IDManager.getID(calculationAgentPartyReferenceIDRef) as List<PartyReference>;
                    return this.calculationAgentPartyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculationAgentPartyReference != value)
                {
                    this.calculationAgentPartyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region CalculationAgentParty
        private CalculationAgentPartyEnum calculationAgentParty;
        public CalculationAgentPartyEnum CalculationAgentParty
        {
            get
            {
                if (this.calculationAgentParty != null)
                {
                    return this.calculationAgentParty; 
                }
                else if (this.calculationAgentPartyIDRef != null)
                {
                    calculationAgentParty = IDManager.getID(calculationAgentPartyIDRef) as CalculationAgentPartyEnum;
                    return this.calculationAgentParty; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculationAgentParty != value)
                {
                    this.calculationAgentParty = value;
                }
            }
        }
        #endregion
        
        public string CalculationAgentPartyEnumIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

