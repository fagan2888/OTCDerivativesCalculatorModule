using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class RoutingIdsAndExplicitDetails : ISerialized
    {
        public RoutingIdsAndExplicitDetails(XmlNode xmlNode)
        {
            XmlNodeList routingIdsNodeList = xmlNode.SelectNodes("routingIds");
            
            if (routingIdsNodeList != null)
            {
                this.routingIds_ = new List<RoutingIds>();
                foreach (XmlNode item in routingIdsNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            routingIdsIDRef_ = item.Attributes["id"].Value;
                            routingIds_.Add(new RoutingIds(item));
                            IDManager.SetID(routingIdsIDRef_, routingIds_[routingIds_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            routingIdsIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        routingIds_.Add(new RoutingIds(item));
                        }
                    }
                    else
                    {
                        routingIds_.Add(new RoutingIds(item));
                    }
                }
            }
            
        
            XmlNode routingNameNode = xmlNode.SelectSingleNode("routingName");
            
            if (routingNameNode != null)
            {
                if (routingNameNode.Attributes["href"] != null || routingNameNode.Attributes["id"] != null) 
                {
                    if (routingNameNode.Attributes["id"] != null) 
                    {
                        routingNameIDRef_ = routingNameNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(routingNameNode);
                        IDManager.SetID(routingNameIDRef_, ob);
                    }
                    else if (routingNameNode.Attributes["href"] != null)
                    {
                        routingNameIDRef_ = routingNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        routingName_ = new XsdTypeString(routingNameNode);
                    }
                }
                else
                {
                    routingName_ = new XsdTypeString(routingNameNode);
                }
            }
            
        
            XmlNode routingAddressNode = xmlNode.SelectSingleNode("routingAddress");
            
            if (routingAddressNode != null)
            {
                if (routingAddressNode.Attributes["href"] != null || routingAddressNode.Attributes["id"] != null) 
                {
                    if (routingAddressNode.Attributes["id"] != null) 
                    {
                        routingAddressIDRef_ = routingAddressNode.Attributes["id"].Value;
                        Address ob = new Address(routingAddressNode);
                        IDManager.SetID(routingAddressIDRef_, ob);
                    }
                    else if (routingAddressNode.Attributes["href"] != null)
                    {
                        routingAddressIDRef_ = routingAddressNode.Attributes["href"].Value;
                    }
                    else
                    {
                        routingAddress_ = new Address(routingAddressNode);
                    }
                }
                else
                {
                    routingAddress_ = new Address(routingAddressNode);
                }
            }
            
        
            XmlNode routingAccountNumberNode = xmlNode.SelectSingleNode("routingAccountNumber");
            
            if (routingAccountNumberNode != null)
            {
                if (routingAccountNumberNode.Attributes["href"] != null || routingAccountNumberNode.Attributes["id"] != null) 
                {
                    if (routingAccountNumberNode.Attributes["id"] != null) 
                    {
                        routingAccountNumberIDRef_ = routingAccountNumberNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(routingAccountNumberNode);
                        IDManager.SetID(routingAccountNumberIDRef_, ob);
                    }
                    else if (routingAccountNumberNode.Attributes["href"] != null)
                    {
                        routingAccountNumberIDRef_ = routingAccountNumberNode.Attributes["href"].Value;
                    }
                    else
                    {
                        routingAccountNumber_ = new XsdTypeString(routingAccountNumberNode);
                    }
                }
                else
                {
                    routingAccountNumber_ = new XsdTypeString(routingAccountNumberNode);
                }
            }
            
        
            XmlNodeList routingReferenceTextNodeList = xmlNode.SelectNodes("routingReferenceText");
            
            if (routingReferenceTextNodeList != null)
            {
                this.routingReferenceText_ = new List<XsdTypeString>();
                foreach (XmlNode item in routingReferenceTextNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            routingReferenceTextIDRef_ = item.Attributes["id"].Value;
                            routingReferenceText_.Add(new XsdTypeString(item));
                            IDManager.SetID(routingReferenceTextIDRef_, routingReferenceText_[routingReferenceText_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            routingReferenceTextIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        routingReferenceText_.Add(new XsdTypeString(item));
                        }
                    }
                    else
                    {
                        routingReferenceText_.Add(new XsdTypeString(item));
                    }
                }
            }
            
        
        }
        
    
        #region RoutingIds_
        private List<RoutingIds> routingIds_;
        public List<RoutingIds> RoutingIds_
        {
            get
            {
                if (this.routingIds_ != null)
                {
                    return this.routingIds_; 
                }
                else if (this.routingIdsIDRef_ != null)
                {
                    return this.routingIds_; 
                }
                else
                {
                      return this.routingIds_; 
                }
            }
            set
            {
                if (this.routingIds_ != value)
                {
                    this.routingIds_ = value;
                }
            }
        }
        #endregion
        
        public string routingIdsIDRef_ { get; set; }
        #region RoutingName_
        private XsdTypeString routingName_;
        public XsdTypeString RoutingName_
        {
            get
            {
                if (this.routingName_ != null)
                {
                    return this.routingName_; 
                }
                else if (this.routingNameIDRef_ != null)
                {
                    routingName_ = IDManager.getID(routingNameIDRef_) as XsdTypeString;
                    return this.routingName_; 
                }
                else
                {
                      return this.routingName_; 
                }
            }
            set
            {
                if (this.routingName_ != value)
                {
                    this.routingName_ = value;
                }
            }
        }
        #endregion
        
        public string routingNameIDRef_ { get; set; }
        #region RoutingAddress_
        private Address routingAddress_;
        public Address RoutingAddress_
        {
            get
            {
                if (this.routingAddress_ != null)
                {
                    return this.routingAddress_; 
                }
                else if (this.routingAddressIDRef_ != null)
                {
                    routingAddress_ = IDManager.getID(routingAddressIDRef_) as Address;
                    return this.routingAddress_; 
                }
                else
                {
                      return this.routingAddress_; 
                }
            }
            set
            {
                if (this.routingAddress_ != value)
                {
                    this.routingAddress_ = value;
                }
            }
        }
        #endregion
        
        public string routingAddressIDRef_ { get; set; }
        #region RoutingAccountNumber_
        private XsdTypeString routingAccountNumber_;
        public XsdTypeString RoutingAccountNumber_
        {
            get
            {
                if (this.routingAccountNumber_ != null)
                {
                    return this.routingAccountNumber_; 
                }
                else if (this.routingAccountNumberIDRef_ != null)
                {
                    routingAccountNumber_ = IDManager.getID(routingAccountNumberIDRef_) as XsdTypeString;
                    return this.routingAccountNumber_; 
                }
                else
                {
                      return this.routingAccountNumber_; 
                }
            }
            set
            {
                if (this.routingAccountNumber_ != value)
                {
                    this.routingAccountNumber_ = value;
                }
            }
        }
        #endregion
        
        public string routingAccountNumberIDRef_ { get; set; }
        #region RoutingReferenceText_
        private List<XsdTypeString> routingReferenceText_;
        public List<XsdTypeString> RoutingReferenceText_
        {
            get
            {
                if (this.routingReferenceText_ != null)
                {
                    return this.routingReferenceText_; 
                }
                else if (this.routingReferenceTextIDRef_ != null)
                {
                    return this.routingReferenceText_; 
                }
                else
                {
                      return this.routingReferenceText_; 
                }
            }
            set
            {
                if (this.routingReferenceText_ != value)
                {
                    this.routingReferenceText_ = value;
                }
            }
        }
        #endregion
        
        public string routingReferenceTextIDRef_ { get; set; }
        
    
        
    
    }
    
}

