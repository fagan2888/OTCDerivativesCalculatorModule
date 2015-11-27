using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ReferenceInformation
    {
        public ReferenceInformation(XmlNode xmlNode)
        {
            XmlNodeList referenceEntityNodeList = xmlNode.SelectNodes("referenceEntity");
            if (referenceEntityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in referenceEntityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        referenceEntityIDRef = item.Attributes["id"].Name;
                        LegalEntity ob = LegalEntity();
                        IDManager.SetID(referenceEntityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        referenceEntityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        referenceEntity = new LegalEntity(item);
                    }
                }
            }
            
        
            XmlNodeList referenceObligationNodeList = xmlNode.SelectNodes("referenceObligation");
            
            foreach (XmlNode item in referenceObligationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        referenceObligationIDRef = item.Attributes["id"].Name;
                        List<ReferenceObligation> ob = new List<ReferenceObligation>();
                        ob.Add(new ReferenceObligation(item));
                        IDManager.SetID(referenceObligationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        referenceObligationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    referenceObligation.Add(new ReferenceObligation(item));
                    }
                }
            }
            
        
            XmlNodeList noReferenceObligationNodeList = xmlNode.SelectNodes("noReferenceObligation");
            if (noReferenceObligationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in noReferenceObligationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        noReferenceObligationIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(noReferenceObligationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        noReferenceObligationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        noReferenceObligation = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList unknownReferenceObligationNodeList = xmlNode.SelectNodes("unknownReferenceObligation");
            if (unknownReferenceObligationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in unknownReferenceObligationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        unknownReferenceObligationIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(unknownReferenceObligationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        unknownReferenceObligationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        unknownReferenceObligation = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList allGuaranteesNodeList = xmlNode.SelectNodes("allGuarantees");
            if (allGuaranteesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in allGuaranteesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        allGuaranteesIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(allGuaranteesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        allGuaranteesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        allGuarantees = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList referencePriceNodeList = xmlNode.SelectNodes("referencePrice");
            if (referencePriceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in referencePriceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        referencePriceIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(referencePriceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        referencePriceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        referencePrice = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList referencePolicyNodeList = xmlNode.SelectNodes("referencePolicy");
            if (referencePolicyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in referencePolicyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        referencePolicyIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(referencePolicyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        referencePolicyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        referencePolicy = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList securedListNodeList = xmlNode.SelectNodes("securedList");
            if (securedListNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in securedListNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        securedListIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(securedListIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        securedListIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        securedList = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
        }
        
    
        #region ReferenceEntity
        private LegalEntity referenceEntity;
        public LegalEntity ReferenceEntity
        {
            get
            {
                if (this.referenceEntity != null)
                {
                    return this.referenceEntity; 
                }
                else if (this.referenceEntityIDRef != null)
                {
                    referenceEntity = IDManager.getID(referenceEntityIDRef) as LegalEntity;
                    return this.referenceEntity; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.referenceEntity != value)
                {
                    this.referenceEntity = value;
                }
            }
        }
        #endregion
        
        public string LegalEntityIDRef { get; set; }
        #region ReferenceObligation
        private List<ReferenceObligation> referenceObligation;
        public List<ReferenceObligation> ReferenceObligation
        {
            get
            {
                if (this.referenceObligation != null)
                {
                    return this.referenceObligation; 
                }
                else if (this.referenceObligationIDRef != null)
                {
                    referenceObligation = IDManager.getID(referenceObligationIDRef) as List<ReferenceObligation>;
                    return this.referenceObligation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.referenceObligation != value)
                {
                    this.referenceObligation = value;
                }
            }
        }
        #endregion
        
        public string ReferenceObligationIDRef { get; set; }
        #region NoReferenceObligation
        private XsdTypeBoolean noReferenceObligation;
        public XsdTypeBoolean NoReferenceObligation
        {
            get
            {
                if (this.noReferenceObligation != null)
                {
                    return this.noReferenceObligation; 
                }
                else if (this.noReferenceObligationIDRef != null)
                {
                    noReferenceObligation = IDManager.getID(noReferenceObligationIDRef) as XsdTypeBoolean;
                    return this.noReferenceObligation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.noReferenceObligation != value)
                {
                    this.noReferenceObligation = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region UnknownReferenceObligation
        private XsdTypeBoolean unknownReferenceObligation;
        public XsdTypeBoolean UnknownReferenceObligation
        {
            get
            {
                if (this.unknownReferenceObligation != null)
                {
                    return this.unknownReferenceObligation; 
                }
                else if (this.unknownReferenceObligationIDRef != null)
                {
                    unknownReferenceObligation = IDManager.getID(unknownReferenceObligationIDRef) as XsdTypeBoolean;
                    return this.unknownReferenceObligation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.unknownReferenceObligation != value)
                {
                    this.unknownReferenceObligation = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region AllGuarantees
        private XsdTypeBoolean allGuarantees;
        public XsdTypeBoolean AllGuarantees
        {
            get
            {
                if (this.allGuarantees != null)
                {
                    return this.allGuarantees; 
                }
                else if (this.allGuaranteesIDRef != null)
                {
                    allGuarantees = IDManager.getID(allGuaranteesIDRef) as XsdTypeBoolean;
                    return this.allGuarantees; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.allGuarantees != value)
                {
                    this.allGuarantees = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region ReferencePrice
        private XsdTypeDecimal referencePrice;
        public XsdTypeDecimal ReferencePrice
        {
            get
            {
                if (this.referencePrice != null)
                {
                    return this.referencePrice; 
                }
                else if (this.referencePriceIDRef != null)
                {
                    referencePrice = IDManager.getID(referencePriceIDRef) as XsdTypeDecimal;
                    return this.referencePrice; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.referencePrice != value)
                {
                    this.referencePrice = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region ReferencePolicy
        private XsdTypeBoolean referencePolicy;
        public XsdTypeBoolean ReferencePolicy
        {
            get
            {
                if (this.referencePolicy != null)
                {
                    return this.referencePolicy; 
                }
                else if (this.referencePolicyIDRef != null)
                {
                    referencePolicy = IDManager.getID(referencePolicyIDRef) as XsdTypeBoolean;
                    return this.referencePolicy; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.referencePolicy != value)
                {
                    this.referencePolicy = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region SecuredList
        private XsdTypeBoolean securedList;
        public XsdTypeBoolean SecuredList
        {
            get
            {
                if (this.securedList != null)
                {
                    return this.securedList; 
                }
                else if (this.securedListIDRef != null)
                {
                    securedList = IDManager.getID(securedListIDRef) as XsdTypeBoolean;
                    return this.securedList; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.securedList != value)
                {
                    this.securedList = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

