using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class BrokerEquityOption
    {
        public BrokerEquityOption(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList deltaCrossedNodeList = xmlNode.SelectNodes("deltaCrossed");
            if (deltaCrossedNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in deltaCrossedNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        deltaCrossedIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(deltaCrossedIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        deltaCrossedIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        deltaCrossed = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList brokerageFeeNodeList = xmlNode.SelectNodes("brokerageFee");
            if (brokerageFeeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in brokerageFeeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        brokerageFeeIDRef = item.Attributes["id"].Name;
                        Money ob = Money();
                        IDManager.SetID(brokerageFeeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        brokerageFeeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        brokerageFee = new Money(item);
                    }
                }
            }
            
        
            XmlNodeList brokerNotesNodeList = xmlNode.SelectNodes("brokerNotes");
            if (brokerNotesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in brokerNotesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        brokerNotesIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(brokerNotesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        brokerNotesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        brokerNotes = new XsdTypeString(item);
                    }
                }
            }
            
        
        }
        
    
        #region DeltaCrossed
        private XsdTypeBoolean deltaCrossed;
        public XsdTypeBoolean DeltaCrossed
        {
            get
            {
                if (this.deltaCrossed != null)
                {
                    return this.deltaCrossed; 
                }
                else if (this.deltaCrossedIDRef != null)
                {
                    deltaCrossed = IDManager.getID(deltaCrossedIDRef) as XsdTypeBoolean;
                    return this.deltaCrossed; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.deltaCrossed != value)
                {
                    this.deltaCrossed = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region BrokerageFee
        private Money brokerageFee;
        public Money BrokerageFee
        {
            get
            {
                if (this.brokerageFee != null)
                {
                    return this.brokerageFee; 
                }
                else if (this.brokerageFeeIDRef != null)
                {
                    brokerageFee = IDManager.getID(brokerageFeeIDRef) as Money;
                    return this.brokerageFee; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.brokerageFee != value)
                {
                    this.brokerageFee = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        #region BrokerNotes
        private XsdTypeString brokerNotes;
        public XsdTypeString BrokerNotes
        {
            get
            {
                if (this.brokerNotes != null)
                {
                    return this.brokerNotes; 
                }
                else if (this.brokerNotesIDRef != null)
                {
                    brokerNotes = IDManager.getID(brokerNotesIDRef) as XsdTypeString;
                    return this.brokerNotes; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.brokerNotes != value)
                {
                    this.brokerNotes = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        
    
        
    
    }
    
}

