using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Reason
    {
        public Reason(XmlNode xmlNode)
        {
            XmlNodeList reasonCodeNodeList = xmlNode.SelectNodes("reasonCode");
            if (reasonCodeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in reasonCodeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        reasonCodeIDRef = item.Attributes["id"].Name;
                        ReasonCode ob = ReasonCode();
                        IDManager.SetID(reasonCodeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        reasonCodeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        reasonCode = new ReasonCode(item);
                    }
                }
            }
            
        
            XmlNodeList locationNodeList = xmlNode.SelectNodes("location");
            if (locationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in locationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        locationIDRef = item.Attributes["id"].Name;
                        ProblemLocation ob = ProblemLocation();
                        IDManager.SetID(locationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        locationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        location = new ProblemLocation(item);
                    }
                }
            }
            
        
            XmlNodeList descriptionNodeList = xmlNode.SelectNodes("description");
            if (descriptionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in descriptionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        descriptionIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(descriptionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        descriptionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        description = new XsdTypeString(item);
                    }
                }
            }
            
        
            XmlNodeList validationRuleIdNodeList = xmlNode.SelectNodes("validationRuleId");
            if (validationRuleIdNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in validationRuleIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        validationRuleIdIDRef = item.Attributes["id"].Name;
                        Validation ob = Validation();
                        IDManager.SetID(validationRuleIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        validationRuleIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        validationRuleId = new Validation(item);
                    }
                }
            }
            
        
            XmlNodeList additionalDataNodeList = xmlNode.SelectNodes("additionalData");
            
            foreach (XmlNode item in additionalDataNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        additionalDataIDRef = item.Attributes["id"].Name;
                        List<AdditionalData> ob = new List<AdditionalData>();
                        ob.Add(new AdditionalData(item));
                        IDManager.SetID(additionalDataIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        additionalDataIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    additionalData.Add(new AdditionalData(item));
                    }
                }
            }
            
        
        }
        
    
        #region ReasonCode
        private ReasonCode reasonCode;
        public ReasonCode ReasonCode
        {
            get
            {
                if (this.reasonCode != null)
                {
                    return this.reasonCode; 
                }
                else if (this.reasonCodeIDRef != null)
                {
                    reasonCode = IDManager.getID(reasonCodeIDRef) as ReasonCode;
                    return this.reasonCode; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.reasonCode != value)
                {
                    this.reasonCode = value;
                }
            }
        }
        #endregion
        
        public string ReasonCodeIDRef { get; set; }
        #region Location
        private ProblemLocation location;
        public ProblemLocation Location
        {
            get
            {
                if (this.location != null)
                {
                    return this.location; 
                }
                else if (this.locationIDRef != null)
                {
                    location = IDManager.getID(locationIDRef) as ProblemLocation;
                    return this.location; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.location != value)
                {
                    this.location = value;
                }
            }
        }
        #endregion
        
        public string ProblemLocationIDRef { get; set; }
        #region Description
        private XsdTypeString description;
        public XsdTypeString Description
        {
            get
            {
                if (this.description != null)
                {
                    return this.description; 
                }
                else if (this.descriptionIDRef != null)
                {
                    description = IDManager.getID(descriptionIDRef) as XsdTypeString;
                    return this.description; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.description != value)
                {
                    this.description = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        #region ValidationRuleId
        private Validation validationRuleId;
        public Validation ValidationRuleId
        {
            get
            {
                if (this.validationRuleId != null)
                {
                    return this.validationRuleId; 
                }
                else if (this.validationRuleIdIDRef != null)
                {
                    validationRuleId = IDManager.getID(validationRuleIdIDRef) as Validation;
                    return this.validationRuleId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.validationRuleId != value)
                {
                    this.validationRuleId = value;
                }
            }
        }
        #endregion
        
        public string ValidationIDRef { get; set; }
        #region AdditionalData
        private List<AdditionalData> additionalData;
        public List<AdditionalData> AdditionalData
        {
            get
            {
                if (this.additionalData != null)
                {
                    return this.additionalData; 
                }
                else if (this.additionalDataIDRef != null)
                {
                    additionalData = IDManager.getID(additionalDataIDRef) as List<AdditionalData>;
                    return this.additionalData; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.additionalData != value)
                {
                    this.additionalData = value;
                }
            }
        }
        #endregion
        
        public string AdditionalDataIDRef { get; set; }
        
    
        
    
    }
    
}

