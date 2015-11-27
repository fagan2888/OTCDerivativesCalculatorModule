using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CreditDerivativesNotices
    {
        public CreditDerivativesNotices(XmlNode xmlNode)
        {
            XmlNodeList creditEventNodeList = xmlNode.SelectNodes("creditEvent");
            if (creditEventNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in creditEventNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        creditEventIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(creditEventIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        creditEventIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        creditEvent = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList publiclyAvailableInformationNodeList = xmlNode.SelectNodes("publiclyAvailableInformation");
            if (publiclyAvailableInformationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in publiclyAvailableInformationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        publiclyAvailableInformationIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(publiclyAvailableInformationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        publiclyAvailableInformationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        publiclyAvailableInformation = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList physicalSettlementNodeList = xmlNode.SelectNodes("physicalSettlement");
            if (physicalSettlementNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in physicalSettlementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        physicalSettlementIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(physicalSettlementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        physicalSettlementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        physicalSettlement = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
        }
        
    
        #region CreditEvent
        private XsdTypeBoolean creditEvent;
        public XsdTypeBoolean CreditEvent
        {
            get
            {
                if (this.creditEvent != null)
                {
                    return this.creditEvent; 
                }
                else if (this.creditEventIDRef != null)
                {
                    creditEvent = IDManager.getID(creditEventIDRef) as XsdTypeBoolean;
                    return this.creditEvent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.creditEvent != value)
                {
                    this.creditEvent = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region PubliclyAvailableInformation
        private XsdTypeBoolean publiclyAvailableInformation;
        public XsdTypeBoolean PubliclyAvailableInformation
        {
            get
            {
                if (this.publiclyAvailableInformation != null)
                {
                    return this.publiclyAvailableInformation; 
                }
                else if (this.publiclyAvailableInformationIDRef != null)
                {
                    publiclyAvailableInformation = IDManager.getID(publiclyAvailableInformationIDRef) as XsdTypeBoolean;
                    return this.publiclyAvailableInformation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.publiclyAvailableInformation != value)
                {
                    this.publiclyAvailableInformation = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region PhysicalSettlement
        private XsdTypeBoolean physicalSettlement;
        public XsdTypeBoolean PhysicalSettlement
        {
            get
            {
                if (this.physicalSettlement != null)
                {
                    return this.physicalSettlement; 
                }
                else if (this.physicalSettlementIDRef != null)
                {
                    physicalSettlement = IDManager.getID(physicalSettlementIDRef) as XsdTypeBoolean;
                    return this.physicalSettlement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.physicalSettlement != value)
                {
                    this.physicalSettlement = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        
    
        
    
    }
    
}

