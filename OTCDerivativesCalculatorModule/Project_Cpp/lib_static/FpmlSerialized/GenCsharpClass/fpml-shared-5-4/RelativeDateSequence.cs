using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class RelativeDateSequence
    {
        public RelativeDateSequence(XmlNode xmlNode)
        {
            XmlNodeList dateRelativeToNodeList = xmlNode.SelectNodes("dateRelativeTo");
            if (dateRelativeToNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dateRelativeToNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dateRelativeToIDRef = item.Attributes["id"].Name;
                        DateReference ob = DateReference();
                        IDManager.SetID(dateRelativeToIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dateRelativeToIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dateRelativeTo = new DateReference(item);
                    }
                }
            }
            
        
            XmlNodeList dateOffsetNodeList = xmlNode.SelectNodes("dateOffset");
            
            foreach (XmlNode item in dateOffsetNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dateOffsetIDRef = item.Attributes["id"].Name;
                        List<DateOffset> ob = new List<DateOffset>();
                        ob.Add(new DateOffset(item));
                        IDManager.SetID(dateOffsetIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dateOffsetIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    dateOffset.Add(new DateOffset(item));
                    }
                }
            }
            
        
            XmlNodeList businessCentersReferenceNodeList = xmlNode.SelectNodes("businessCentersReference");
            if (businessCentersReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in businessCentersReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        businessCentersReferenceIDRef = item.Attributes["id"].Name;
                        BusinessCentersReference ob = BusinessCentersReference();
                        IDManager.SetID(businessCentersReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        businessCentersReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        businessCentersReference = new BusinessCentersReference(item);
                    }
                }
            }
            
        
            XmlNodeList businessCentersNodeList = xmlNode.SelectNodes("businessCenters");
            if (businessCentersNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in businessCentersNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        businessCentersIDRef = item.Attributes["id"].Name;
                        BusinessCenters ob = BusinessCenters();
                        IDManager.SetID(businessCentersIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        businessCentersIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        businessCenters = new BusinessCenters(item);
                    }
                }
            }
            
        
        }
        
    
        #region DateRelativeTo
        private DateReference dateRelativeTo;
        public DateReference DateRelativeTo
        {
            get
            {
                if (this.dateRelativeTo != null)
                {
                    return this.dateRelativeTo; 
                }
                else if (this.dateRelativeToIDRef != null)
                {
                    dateRelativeTo = IDManager.getID(dateRelativeToIDRef) as DateReference;
                    return this.dateRelativeTo; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dateRelativeTo != value)
                {
                    this.dateRelativeTo = value;
                }
            }
        }
        #endregion
        
        public string DateReferenceIDRef { get; set; }
        #region DateOffset
        private List<DateOffset> dateOffset;
        public List<DateOffset> DateOffset
        {
            get
            {
                if (this.dateOffset != null)
                {
                    return this.dateOffset; 
                }
                else if (this.dateOffsetIDRef != null)
                {
                    dateOffset = IDManager.getID(dateOffsetIDRef) as List<DateOffset>;
                    return this.dateOffset; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dateOffset != value)
                {
                    this.dateOffset = value;
                }
            }
        }
        #endregion
        
        public string DateOffsetIDRef { get; set; }
        #region BusinessCentersReference
        private BusinessCentersReference businessCentersReference;
        public BusinessCentersReference BusinessCentersReference
        {
            get
            {
                if (this.businessCentersReference != null)
                {
                    return this.businessCentersReference; 
                }
                else if (this.businessCentersReferenceIDRef != null)
                {
                    businessCentersReference = IDManager.getID(businessCentersReferenceIDRef) as BusinessCentersReference;
                    return this.businessCentersReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.businessCentersReference != value)
                {
                    this.businessCentersReference = value;
                }
            }
        }
        #endregion
        
        public string BusinessCentersReferenceIDRef { get; set; }
        #region BusinessCenters
        private BusinessCenters businessCenters;
        public BusinessCenters BusinessCenters
        {
            get
            {
                if (this.businessCenters != null)
                {
                    return this.businessCenters; 
                }
                else if (this.businessCentersIDRef != null)
                {
                    businessCenters = IDManager.getID(businessCentersIDRef) as BusinessCenters;
                    return this.businessCenters; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.businessCenters != value)
                {
                    this.businessCenters = value;
                }
            }
        }
        #endregion
        
        public string BusinessCentersIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

