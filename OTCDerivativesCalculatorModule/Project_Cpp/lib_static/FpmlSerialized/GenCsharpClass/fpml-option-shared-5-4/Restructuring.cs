using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Restructuring
    {
        public Restructuring(XmlNode xmlNode)
        {
            XmlNodeList applicableNodeList = xmlNode.SelectNodes("applicable");
            if (applicableNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in applicableNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        applicableIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(applicableIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        applicableIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        applicable = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList restructuringTypeNodeList = xmlNode.SelectNodes("restructuringType");
            if (restructuringTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in restructuringTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        restructuringTypeIDRef = item.Attributes["id"].Name;
                        RestructuringType ob = RestructuringType();
                        IDManager.SetID(restructuringTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        restructuringTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        restructuringType = new RestructuringType(item);
                    }
                }
            }
            
        
            XmlNodeList multipleHolderObligationNodeList = xmlNode.SelectNodes("multipleHolderObligation");
            if (multipleHolderObligationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in multipleHolderObligationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        multipleHolderObligationIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(multipleHolderObligationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        multipleHolderObligationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        multipleHolderObligation = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList multipleCreditEventNoticesNodeList = xmlNode.SelectNodes("multipleCreditEventNotices");
            if (multipleCreditEventNoticesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in multipleCreditEventNoticesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        multipleCreditEventNoticesIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(multipleCreditEventNoticesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        multipleCreditEventNoticesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        multipleCreditEventNotices = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
        }
        
    
        #region Applicable
        private XsdTypeBoolean applicable;
        public XsdTypeBoolean Applicable
        {
            get
            {
                if (this.applicable != null)
                {
                    return this.applicable; 
                }
                else if (this.applicableIDRef != null)
                {
                    applicable = IDManager.getID(applicableIDRef) as XsdTypeBoolean;
                    return this.applicable; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.applicable != value)
                {
                    this.applicable = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region RestructuringType
        private RestructuringType restructuringType;
        public RestructuringType RestructuringType
        {
            get
            {
                if (this.restructuringType != null)
                {
                    return this.restructuringType; 
                }
                else if (this.restructuringTypeIDRef != null)
                {
                    restructuringType = IDManager.getID(restructuringTypeIDRef) as RestructuringType;
                    return this.restructuringType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.restructuringType != value)
                {
                    this.restructuringType = value;
                }
            }
        }
        #endregion
        
        public string RestructuringTypeIDRef { get; set; }
        #region MultipleHolderObligation
        private XsdTypeBoolean multipleHolderObligation;
        public XsdTypeBoolean MultipleHolderObligation
        {
            get
            {
                if (this.multipleHolderObligation != null)
                {
                    return this.multipleHolderObligation; 
                }
                else if (this.multipleHolderObligationIDRef != null)
                {
                    multipleHolderObligation = IDManager.getID(multipleHolderObligationIDRef) as XsdTypeBoolean;
                    return this.multipleHolderObligation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.multipleHolderObligation != value)
                {
                    this.multipleHolderObligation = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region MultipleCreditEventNotices
        private XsdTypeBoolean multipleCreditEventNotices;
        public XsdTypeBoolean MultipleCreditEventNotices
        {
            get
            {
                if (this.multipleCreditEventNotices != null)
                {
                    return this.multipleCreditEventNotices; 
                }
                else if (this.multipleCreditEventNoticesIDRef != null)
                {
                    multipleCreditEventNotices = IDManager.getID(multipleCreditEventNoticesIDRef) as XsdTypeBoolean;
                    return this.multipleCreditEventNotices; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.multipleCreditEventNotices != value)
                {
                    this.multipleCreditEventNotices = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        
    
        
    
    }
    
}

