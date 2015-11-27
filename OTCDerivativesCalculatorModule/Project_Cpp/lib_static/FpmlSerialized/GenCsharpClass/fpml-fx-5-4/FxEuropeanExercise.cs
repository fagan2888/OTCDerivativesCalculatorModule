using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FxEuropeanExercise
    {
        public FxEuropeanExercise(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList expiryDateNodeList = xmlNode.SelectNodes("expiryDate");
            if (expiryDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in expiryDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        expiryDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(expiryDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        expiryDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        expiryDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList expiryTimeNodeList = xmlNode.SelectNodes("expiryTime");
            if (expiryTimeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in expiryTimeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        expiryTimeIDRef = item.Attributes["id"].Name;
                        BusinessCenterTime ob = BusinessCenterTime();
                        IDManager.SetID(expiryTimeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        expiryTimeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        expiryTime = new BusinessCenterTime(item);
                    }
                }
            }
            
        
            XmlNodeList cutNameNodeList = xmlNode.SelectNodes("cutName");
            if (cutNameNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in cutNameNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        cutNameIDRef = item.Attributes["id"].Name;
                        CutName ob = CutName();
                        IDManager.SetID(cutNameIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        cutNameIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        cutName = new CutName(item);
                    }
                }
            }
            
        
            XmlNodeList valueDateNodeList = xmlNode.SelectNodes("valueDate");
            if (valueDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in valueDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        valueDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(valueDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        valueDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        valueDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
        }
        
    
        #region ExpiryDate
        private XsdTypeDate expiryDate;
        public XsdTypeDate ExpiryDate
        {
            get
            {
                if (this.expiryDate != null)
                {
                    return this.expiryDate; 
                }
                else if (this.expiryDateIDRef != null)
                {
                    expiryDate = IDManager.getID(expiryDateIDRef) as XsdTypeDate;
                    return this.expiryDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.expiryDate != value)
                {
                    this.expiryDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region ExpiryTime
        private BusinessCenterTime expiryTime;
        public BusinessCenterTime ExpiryTime
        {
            get
            {
                if (this.expiryTime != null)
                {
                    return this.expiryTime; 
                }
                else if (this.expiryTimeIDRef != null)
                {
                    expiryTime = IDManager.getID(expiryTimeIDRef) as BusinessCenterTime;
                    return this.expiryTime; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.expiryTime != value)
                {
                    this.expiryTime = value;
                }
            }
        }
        #endregion
        
        public string BusinessCenterTimeIDRef { get; set; }
        #region CutName
        private CutName cutName;
        public CutName CutName
        {
            get
            {
                if (this.cutName != null)
                {
                    return this.cutName; 
                }
                else if (this.cutNameIDRef != null)
                {
                    cutName = IDManager.getID(cutNameIDRef) as CutName;
                    return this.cutName; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.cutName != value)
                {
                    this.cutName = value;
                }
            }
        }
        #endregion
        
        public string CutNameIDRef { get; set; }
        #region ValueDate
        private XsdTypeDate valueDate;
        public XsdTypeDate ValueDate
        {
            get
            {
                if (this.valueDate != null)
                {
                    return this.valueDate; 
                }
                else if (this.valueDateIDRef != null)
                {
                    valueDate = IDManager.getID(valueDateIDRef) as XsdTypeDate;
                    return this.valueDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.valueDate != value)
                {
                    this.valueDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        
    
        
    
    }
    
}

