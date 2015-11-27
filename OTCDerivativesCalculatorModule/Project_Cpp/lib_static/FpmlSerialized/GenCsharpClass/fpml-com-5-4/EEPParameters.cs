using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class EEPParameters
    {
        public EEPParameters(XmlNode xmlNode)
        {
            XmlNodeList eEPApplicableNodeList = xmlNode.SelectNodes("eEPApplicable");
            if (eEPApplicableNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in eEPApplicableNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        eEPApplicableIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(eEPApplicableIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        eEPApplicableIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        eEPApplicable = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList riskPeriodNodeList = xmlNode.SelectNodes("riskPeriod");
            if (riskPeriodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in riskPeriodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        riskPeriodIDRef = item.Attributes["id"].Name;
                        EEPRiskPeriod ob = EEPRiskPeriod();
                        IDManager.SetID(riskPeriodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        riskPeriodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        riskPeriod = new EEPRiskPeriod(item);
                    }
                }
            }
            
        
            XmlNodeList equivalentApplicableNodeList = xmlNode.SelectNodes("equivalentApplicable");
            if (equivalentApplicableNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in equivalentApplicableNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        equivalentApplicableIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(equivalentApplicableIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        equivalentApplicableIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        equivalentApplicable = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList penaltyApplicableNodeList = xmlNode.SelectNodes("penaltyApplicable");
            if (penaltyApplicableNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in penaltyApplicableNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        penaltyApplicableIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(penaltyApplicableIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        penaltyApplicableIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        penaltyApplicable = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
        }
        
    
        #region EEPApplicable
        private XsdTypeBoolean eEPApplicable;
        public XsdTypeBoolean EEPApplicable
        {
            get
            {
                if (this.eEPApplicable != null)
                {
                    return this.eEPApplicable; 
                }
                else if (this.eEPApplicableIDRef != null)
                {
                    eEPApplicable = IDManager.getID(eEPApplicableIDRef) as XsdTypeBoolean;
                    return this.eEPApplicable; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.eEPApplicable != value)
                {
                    this.eEPApplicable = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region RiskPeriod
        private EEPRiskPeriod riskPeriod;
        public EEPRiskPeriod RiskPeriod
        {
            get
            {
                if (this.riskPeriod != null)
                {
                    return this.riskPeriod; 
                }
                else if (this.riskPeriodIDRef != null)
                {
                    riskPeriod = IDManager.getID(riskPeriodIDRef) as EEPRiskPeriod;
                    return this.riskPeriod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.riskPeriod != value)
                {
                    this.riskPeriod = value;
                }
            }
        }
        #endregion
        
        public string EEPRiskPeriodIDRef { get; set; }
        #region EquivalentApplicable
        private XsdTypeBoolean equivalentApplicable;
        public XsdTypeBoolean EquivalentApplicable
        {
            get
            {
                if (this.equivalentApplicable != null)
                {
                    return this.equivalentApplicable; 
                }
                else if (this.equivalentApplicableIDRef != null)
                {
                    equivalentApplicable = IDManager.getID(equivalentApplicableIDRef) as XsdTypeBoolean;
                    return this.equivalentApplicable; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.equivalentApplicable != value)
                {
                    this.equivalentApplicable = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region PenaltyApplicable
        private XsdTypeBoolean penaltyApplicable;
        public XsdTypeBoolean PenaltyApplicable
        {
            get
            {
                if (this.penaltyApplicable != null)
                {
                    return this.penaltyApplicable; 
                }
                else if (this.penaltyApplicableIDRef != null)
                {
                    penaltyApplicable = IDManager.getID(penaltyApplicableIDRef) as XsdTypeBoolean;
                    return this.penaltyApplicable; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.penaltyApplicable != value)
                {
                    this.penaltyApplicable = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        
    
        
    
    }
    
}

