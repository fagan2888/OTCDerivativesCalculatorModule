using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ElectricityTransmissionContingency
    {
        public ElectricityTransmissionContingency(XmlNode xmlNode)
        {
            XmlNodeList contingencyNodeList = xmlNode.SelectNodes("contingency");
            if (contingencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in contingencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        contingencyIDRef = item.Attributes["id"].Name;
                        ElectricityTransmissionContingencyType ob = ElectricityTransmissionContingencyType();
                        IDManager.SetID(contingencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        contingencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        contingency = new ElectricityTransmissionContingencyType(item);
                    }
                }
            }
            
        
            XmlNodeList contingentPartyNodeList = xmlNode.SelectNodes("contingentParty");
            
            foreach (XmlNode item in contingentPartyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        contingentPartyIDRef = item.Attributes["id"].Name;
                        List<PartyReference> ob = new List<PartyReference>();
                        ob.Add(new PartyReference(item));
                        IDManager.SetID(contingentPartyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        contingentPartyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    contingentParty.Add(new PartyReference(item));
                    }
                }
            }
            
        
        }
        
    
        #region Contingency
        private ElectricityTransmissionContingencyType contingency;
        public ElectricityTransmissionContingencyType Contingency
        {
            get
            {
                if (this.contingency != null)
                {
                    return this.contingency; 
                }
                else if (this.contingencyIDRef != null)
                {
                    contingency = IDManager.getID(contingencyIDRef) as ElectricityTransmissionContingencyType;
                    return this.contingency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.contingency != value)
                {
                    this.contingency = value;
                }
            }
        }
        #endregion
        
        public string ElectricityTransmissionContingencyTypeIDRef { get; set; }
        #region ContingentParty
        private List<PartyReference> contingentParty;
        public List<PartyReference> ContingentParty
        {
            get
            {
                if (this.contingentParty != null)
                {
                    return this.contingentParty; 
                }
                else if (this.contingentPartyIDRef != null)
                {
                    contingentParty = IDManager.getID(contingentPartyIDRef) as List<PartyReference>;
                    return this.contingentParty; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.contingentParty != value)
                {
                    this.contingentParty = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        
    
        
    
    }
    
}

