using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ElectricityTransmissionContingency : ISerialized
    {
        public ElectricityTransmissionContingency(XmlNode xmlNode)
        {
            XmlNode contingencyNode = xmlNode.SelectSingleNode("contingency");
            
            if (contingencyNode != null)
            {
                if (contingencyNode.Attributes["href"] != null || contingencyNode.Attributes["id"] != null) 
                {
                    if (contingencyNode.Attributes["id"] != null) 
                    {
                        contingencyIDRef_ = contingencyNode.Attributes["id"].Value;
                        ElectricityTransmissionContingencyType ob = new ElectricityTransmissionContingencyType(contingencyNode);
                        IDManager.SetID(contingencyIDRef_, ob);
                    }
                    else if (contingencyNode.Attributes["href"] != null)
                    {
                        contingencyIDRef_ = contingencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        contingency_ = new ElectricityTransmissionContingencyType(contingencyNode);
                    }
                }
                else
                {
                    contingency_ = new ElectricityTransmissionContingencyType(contingencyNode);
                }
            }
            
        
            XmlNodeList contingentPartyNodeList = xmlNode.SelectNodes("contingentParty");
            
            if (contingentPartyNodeList != null)
            {
                this.contingentParty_ = new List<PartyReference>();
                foreach (XmlNode item in contingentPartyNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            contingentPartyIDRef_ = item.Attributes["id"].Value;
                            contingentParty_.Add(new PartyReference(item));
                            IDManager.SetID(contingentPartyIDRef_, contingentParty_[contingentParty_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            contingentPartyIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        contingentParty_.Add(new PartyReference(item));
                        }
                    }
                    else
                    {
                        contingentParty_.Add(new PartyReference(item));
                    }
                }
            }
            
        
        }
        
    
        #region Contingency_
        private ElectricityTransmissionContingencyType contingency_;
        public ElectricityTransmissionContingencyType Contingency_
        {
            get
            {
                if (this.contingency_ != null)
                {
                    return this.contingency_; 
                }
                else if (this.contingencyIDRef_ != null)
                {
                    contingency_ = IDManager.getID(contingencyIDRef_) as ElectricityTransmissionContingencyType;
                    return this.contingency_; 
                }
                else
                {
                      return this.contingency_; 
                }
            }
            set
            {
                if (this.contingency_ != value)
                {
                    this.contingency_ = value;
                }
            }
        }
        #endregion
        
        public string contingencyIDRef_ { get; set; }
        #region ContingentParty_
        private List<PartyReference> contingentParty_;
        public List<PartyReference> ContingentParty_
        {
            get
            {
                if (this.contingentParty_ != null)
                {
                    return this.contingentParty_; 
                }
                else if (this.contingentPartyIDRef_ != null)
                {
                    return this.contingentParty_; 
                }
                else
                {
                      return this.contingentParty_; 
                }
            }
            set
            {
                if (this.contingentParty_ != value)
                {
                    this.contingentParty_ = value;
                }
            }
        }
        #endregion
        
        public string contingentPartyIDRef_ { get; set; }
        
    
        
    
    }
    
}

