using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Representations
    {
        public Representations(XmlNode xmlNode)
        {
            XmlNodeList nonRelianceNodeList = xmlNode.SelectNodes("nonReliance");
            if (nonRelianceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in nonRelianceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        nonRelianceIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(nonRelianceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        nonRelianceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        nonReliance = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList agreementsRegardingHedgingNodeList = xmlNode.SelectNodes("agreementsRegardingHedging");
            if (agreementsRegardingHedgingNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in agreementsRegardingHedgingNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        agreementsRegardingHedgingIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(agreementsRegardingHedgingIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        agreementsRegardingHedgingIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        agreementsRegardingHedging = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList indexDisclaimerNodeList = xmlNode.SelectNodes("indexDisclaimer");
            if (indexDisclaimerNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in indexDisclaimerNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        indexDisclaimerIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(indexDisclaimerIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        indexDisclaimerIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        indexDisclaimer = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList additionalAcknowledgementsNodeList = xmlNode.SelectNodes("additionalAcknowledgements");
            if (additionalAcknowledgementsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in additionalAcknowledgementsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        additionalAcknowledgementsIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(additionalAcknowledgementsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        additionalAcknowledgementsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        additionalAcknowledgements = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
        }
        
    
        #region NonReliance
        private XsdTypeBoolean nonReliance;
        public XsdTypeBoolean NonReliance
        {
            get
            {
                if (this.nonReliance != null)
                {
                    return this.nonReliance; 
                }
                else if (this.nonRelianceIDRef != null)
                {
                    nonReliance = IDManager.getID(nonRelianceIDRef) as XsdTypeBoolean;
                    return this.nonReliance; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.nonReliance != value)
                {
                    this.nonReliance = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region AgreementsRegardingHedging
        private XsdTypeBoolean agreementsRegardingHedging;
        public XsdTypeBoolean AgreementsRegardingHedging
        {
            get
            {
                if (this.agreementsRegardingHedging != null)
                {
                    return this.agreementsRegardingHedging; 
                }
                else if (this.agreementsRegardingHedgingIDRef != null)
                {
                    agreementsRegardingHedging = IDManager.getID(agreementsRegardingHedgingIDRef) as XsdTypeBoolean;
                    return this.agreementsRegardingHedging; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.agreementsRegardingHedging != value)
                {
                    this.agreementsRegardingHedging = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region IndexDisclaimer
        private XsdTypeBoolean indexDisclaimer;
        public XsdTypeBoolean IndexDisclaimer
        {
            get
            {
                if (this.indexDisclaimer != null)
                {
                    return this.indexDisclaimer; 
                }
                else if (this.indexDisclaimerIDRef != null)
                {
                    indexDisclaimer = IDManager.getID(indexDisclaimerIDRef) as XsdTypeBoolean;
                    return this.indexDisclaimer; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.indexDisclaimer != value)
                {
                    this.indexDisclaimer = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region AdditionalAcknowledgements
        private XsdTypeBoolean additionalAcknowledgements;
        public XsdTypeBoolean AdditionalAcknowledgements
        {
            get
            {
                if (this.additionalAcknowledgements != null)
                {
                    return this.additionalAcknowledgements; 
                }
                else if (this.additionalAcknowledgementsIDRef != null)
                {
                    additionalAcknowledgements = IDManager.getID(additionalAcknowledgementsIDRef) as XsdTypeBoolean;
                    return this.additionalAcknowledgements; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.additionalAcknowledgements != value)
                {
                    this.additionalAcknowledgements = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        
    
        
    
    }
    
}

