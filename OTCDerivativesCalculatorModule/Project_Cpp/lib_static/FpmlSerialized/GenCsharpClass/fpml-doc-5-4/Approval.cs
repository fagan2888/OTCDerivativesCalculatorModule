using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Approval
    {
        public Approval(XmlNode xmlNode)
        {
            XmlNodeList typeNodeList = xmlNode.SelectNodes("type");
            if (typeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in typeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        typeIDRef = item.Attributes["id"].Name;
                        XsdTypeNormalizedString ob = XsdTypeNormalizedString();
                        IDManager.SetID(typeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        typeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        type = new XsdTypeNormalizedString(item);
                    }
                }
            }
            
        
            XmlNodeList statusNodeList = xmlNode.SelectNodes("status");
            if (statusNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in statusNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        statusIDRef = item.Attributes["id"].Name;
                        XsdTypeNormalizedString ob = XsdTypeNormalizedString();
                        IDManager.SetID(statusIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        statusIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        status = new XsdTypeNormalizedString(item);
                    }
                }
            }
            
        
            XmlNodeList approverNodeList = xmlNode.SelectNodes("approver");
            if (approverNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in approverNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        approverIDRef = item.Attributes["id"].Name;
                        XsdTypeNormalizedString ob = XsdTypeNormalizedString();
                        IDManager.SetID(approverIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        approverIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        approver = new XsdTypeNormalizedString(item);
                    }
                }
            }
            
        
        }
        
    
        #region Type
        private XsdTypeNormalizedString type;
        public XsdTypeNormalizedString Type
        {
            get
            {
                if (this.type != null)
                {
                    return this.type; 
                }
                else if (this.typeIDRef != null)
                {
                    type = IDManager.getID(typeIDRef) as XsdTypeNormalizedString;
                    return this.type; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.type != value)
                {
                    this.type = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeNormalizedStringIDRef { get; set; }
        #region Status
        private XsdTypeNormalizedString status;
        public XsdTypeNormalizedString Status
        {
            get
            {
                if (this.status != null)
                {
                    return this.status; 
                }
                else if (this.statusIDRef != null)
                {
                    status = IDManager.getID(statusIDRef) as XsdTypeNormalizedString;
                    return this.status; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.status != value)
                {
                    this.status = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeNormalizedStringIDRef { get; set; }
        #region Approver
        private XsdTypeNormalizedString approver;
        public XsdTypeNormalizedString Approver
        {
            get
            {
                if (this.approver != null)
                {
                    return this.approver; 
                }
                else if (this.approverIDRef != null)
                {
                    approver = IDManager.getID(approverIDRef) as XsdTypeNormalizedString;
                    return this.approver; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.approver != value)
                {
                    this.approver = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeNormalizedStringIDRef { get; set; }
        
    
        
    
    }
    
}

