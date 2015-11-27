using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FxDigitalAmericanExercise
    {
        public FxDigitalAmericanExercise(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList commencementDateNodeList = xmlNode.SelectNodes("commencementDate");
            if (commencementDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in commencementDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        commencementDateIDRef = item.Attributes["id"].Name;
                        AdjustableOrRelativeDate ob = AdjustableOrRelativeDate();
                        IDManager.SetID(commencementDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        commencementDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        commencementDate = new AdjustableOrRelativeDate(item);
                    }
                }
            }
            
        
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
            
        
            XmlNodeList latestValueDateNodeList = xmlNode.SelectNodes("latestValueDate");
            if (latestValueDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in latestValueDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        latestValueDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(latestValueDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        latestValueDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        latestValueDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
        }
        
    
        #region CommencementDate
        private AdjustableOrRelativeDate commencementDate;
        public AdjustableOrRelativeDate CommencementDate
        {
            get
            {
                if (this.commencementDate != null)
                {
                    return this.commencementDate; 
                }
                else if (this.commencementDateIDRef != null)
                {
                    commencementDate = IDManager.getID(commencementDateIDRef) as AdjustableOrRelativeDate;
                    return this.commencementDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.commencementDate != value)
                {
                    this.commencementDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableOrRelativeDateIDRef { get; set; }
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
        #region LatestValueDate
        private XsdTypeDate latestValueDate;
        public XsdTypeDate LatestValueDate
        {
            get
            {
                if (this.latestValueDate != null)
                {
                    return this.latestValueDate; 
                }
                else if (this.latestValueDateIDRef != null)
                {
                    latestValueDate = IDManager.getID(latestValueDateIDRef) as XsdTypeDate;
                    return this.latestValueDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.latestValueDate != value)
                {
                    this.latestValueDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        
    
        
    
    }
    
}

