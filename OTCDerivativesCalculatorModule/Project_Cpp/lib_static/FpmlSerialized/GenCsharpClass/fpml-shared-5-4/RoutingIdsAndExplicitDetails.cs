using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class RoutingIdsAndExplicitDetails
    {
        public RoutingIdsAndExplicitDetails(XmlNode xmlNode)
        {
            XmlNodeList routingIdsNodeList = xmlNode.SelectNodes("routingIds");
            
            foreach (XmlNode item in routingIdsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        routingIdsIDRef = item.Attributes["id"].Name;
                        List<RoutingIds> ob = new List<RoutingIds>();
                        ob.Add(new RoutingIds(item));
                        IDManager.SetID(routingIdsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        routingIdsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    routingIds.Add(new RoutingIds(item));
                    }
                }
            }
            
        
            XmlNodeList routingNameNodeList = xmlNode.SelectNodes("routingName");
            if (routingNameNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in routingNameNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        routingNameIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(routingNameIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        routingNameIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        routingName = new XsdTypeString(item);
                    }
                }
            }
            
        
            XmlNodeList routingAddressNodeList = xmlNode.SelectNodes("routingAddress");
            if (routingAddressNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in routingAddressNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        routingAddressIDRef = item.Attributes["id"].Name;
                        Address ob = Address();
                        IDManager.SetID(routingAddressIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        routingAddressIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        routingAddress = new Address(item);
                    }
                }
            }
            
        
            XmlNodeList routingAccountNumberNodeList = xmlNode.SelectNodes("routingAccountNumber");
            if (routingAccountNumberNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in routingAccountNumberNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        routingAccountNumberIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(routingAccountNumberIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        routingAccountNumberIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        routingAccountNumber = new XsdTypeString(item);
                    }
                }
            }
            
        
            XmlNodeList routingReferenceTextNodeList = xmlNode.SelectNodes("routingReferenceText");
            
            foreach (XmlNode item in routingReferenceTextNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        routingReferenceTextIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = new XsdTypeString();
                        ob.Add(new XsdTypeString(item));
                        IDManager.SetID(routingReferenceTextIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        routingReferenceTextIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    routingReferenceText.Add(new XsdTypeString(item));
                    }
                }
            }
            
        
        }
        
    
        #region RoutingIds
        private List<RoutingIds> routingIds;
        public List<RoutingIds> RoutingIds
        {
            get
            {
                if (this.routingIds != null)
                {
                    return this.routingIds; 
                }
                else if (this.routingIdsIDRef != null)
                {
                    routingIds = IDManager.getID(routingIdsIDRef) as List<RoutingIds>;
                    return this.routingIds; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.routingIds != value)
                {
                    this.routingIds = value;
                }
            }
        }
        #endregion
        
        public string RoutingIdsIDRef { get; set; }
        #region RoutingName
        private XsdTypeString routingName;
        public XsdTypeString RoutingName
        {
            get
            {
                if (this.routingName != null)
                {
                    return this.routingName; 
                }
                else if (this.routingNameIDRef != null)
                {
                    routingName = IDManager.getID(routingNameIDRef) as XsdTypeString;
                    return this.routingName; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.routingName != value)
                {
                    this.routingName = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        #region RoutingAddress
        private Address routingAddress;
        public Address RoutingAddress
        {
            get
            {
                if (this.routingAddress != null)
                {
                    return this.routingAddress; 
                }
                else if (this.routingAddressIDRef != null)
                {
                    routingAddress = IDManager.getID(routingAddressIDRef) as Address;
                    return this.routingAddress; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.routingAddress != value)
                {
                    this.routingAddress = value;
                }
            }
        }
        #endregion
        
        public string AddressIDRef { get; set; }
        #region RoutingAccountNumber
        private XsdTypeString routingAccountNumber;
        public XsdTypeString RoutingAccountNumber
        {
            get
            {
                if (this.routingAccountNumber != null)
                {
                    return this.routingAccountNumber; 
                }
                else if (this.routingAccountNumberIDRef != null)
                {
                    routingAccountNumber = IDManager.getID(routingAccountNumberIDRef) as XsdTypeString;
                    return this.routingAccountNumber; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.routingAccountNumber != value)
                {
                    this.routingAccountNumber = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        #region RoutingReferenceText
        private XsdTypeString routingReferenceText;
        public XsdTypeString RoutingReferenceText
        {
            get
            {
                if (this.routingReferenceText != null)
                {
                    return this.routingReferenceText; 
                }
                else if (this.routingReferenceTextIDRef != null)
                {
                    routingReferenceText = IDManager.getID(routingReferenceTextIDRef) as XsdTypeString;
                    return this.routingReferenceText; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.routingReferenceText != value)
                {
                    this.routingReferenceText = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        
    
        
    
    }
    
}

