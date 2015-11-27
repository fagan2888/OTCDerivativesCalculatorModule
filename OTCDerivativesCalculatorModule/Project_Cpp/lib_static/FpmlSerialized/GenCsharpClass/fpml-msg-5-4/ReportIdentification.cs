using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ReportIdentification
    {
        public ReportIdentification(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList numberOfSectionsNodeList = xmlNode.SelectNodes("numberOfSections");
            if (numberOfSectionsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in numberOfSectionsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        numberOfSectionsIDRef = item.Attributes["id"].Name;
                        XsdTypePositiveInteger ob = XsdTypePositiveInteger();
                        IDManager.SetID(numberOfSectionsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        numberOfSectionsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        numberOfSections = new XsdTypePositiveInteger(item);
                    }
                }
            }
            
        
            XmlNodeList submissionsCompleteNodeList = xmlNode.SelectNodes("submissionsComplete");
            if (submissionsCompleteNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in submissionsCompleteNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        submissionsCompleteIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(submissionsCompleteIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        submissionsCompleteIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        submissionsComplete = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
        }
        
    
        #region NumberOfSections
        private XsdTypePositiveInteger numberOfSections;
        public XsdTypePositiveInteger NumberOfSections
        {
            get
            {
                if (this.numberOfSections != null)
                {
                    return this.numberOfSections; 
                }
                else if (this.numberOfSectionsIDRef != null)
                {
                    numberOfSections = IDManager.getID(numberOfSectionsIDRef) as XsdTypePositiveInteger;
                    return this.numberOfSections; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.numberOfSections != value)
                {
                    this.numberOfSections = value;
                }
            }
        }
        #endregion
        
        public string XsdTypePositiveIntegerIDRef { get; set; }
        #region SubmissionsComplete
        private XsdTypeBoolean submissionsComplete;
        public XsdTypeBoolean SubmissionsComplete
        {
            get
            {
                if (this.submissionsComplete != null)
                {
                    return this.submissionsComplete; 
                }
                else if (this.submissionsCompleteIDRef != null)
                {
                    submissionsComplete = IDManager.getID(submissionsCompleteIDRef) as XsdTypeBoolean;
                    return this.submissionsComplete; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.submissionsComplete != value)
                {
                    this.submissionsComplete = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        
    
        
    
    }
    
}

