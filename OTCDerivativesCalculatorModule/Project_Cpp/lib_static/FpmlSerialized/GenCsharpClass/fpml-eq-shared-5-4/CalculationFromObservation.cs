using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CalculationFromObservation
    {
        public CalculationFromObservation(XmlNode xmlNode)
        {
            XmlNodeList initialLevelNodeList = xmlNode.SelectNodes("initialLevel");
            if (initialLevelNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in initialLevelNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        initialLevelIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(initialLevelIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        initialLevelIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        initialLevel = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList closingLevelNodeList = xmlNode.SelectNodes("closingLevel");
            if (closingLevelNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in closingLevelNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        closingLevelIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(closingLevelIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        closingLevelIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        closingLevel = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList expiringLevelNodeList = xmlNode.SelectNodes("expiringLevel");
            if (expiringLevelNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in expiringLevelNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        expiringLevelIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(expiringLevelIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        expiringLevelIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        expiringLevel = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList expectedNNodeList = xmlNode.SelectNodes("expectedN");
            if (expectedNNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in expectedNNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        expectedNIDRef = item.Attributes["id"].Name;
                        XsdTypePositiveInteger ob = XsdTypePositiveInteger();
                        IDManager.SetID(expectedNIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        expectedNIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        expectedN = new XsdTypePositiveInteger(item);
                    }
                }
            }
            
        
        }
        
    
        #region InitialLevel
        private XsdTypeDecimal initialLevel;
        public XsdTypeDecimal InitialLevel
        {
            get
            {
                if (this.initialLevel != null)
                {
                    return this.initialLevel; 
                }
                else if (this.initialLevelIDRef != null)
                {
                    initialLevel = IDManager.getID(initialLevelIDRef) as XsdTypeDecimal;
                    return this.initialLevel; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.initialLevel != value)
                {
                    this.initialLevel = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region ClosingLevel
        private XsdTypeBoolean closingLevel;
        public XsdTypeBoolean ClosingLevel
        {
            get
            {
                if (this.closingLevel != null)
                {
                    return this.closingLevel; 
                }
                else if (this.closingLevelIDRef != null)
                {
                    closingLevel = IDManager.getID(closingLevelIDRef) as XsdTypeBoolean;
                    return this.closingLevel; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.closingLevel != value)
                {
                    this.closingLevel = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region ExpiringLevel
        private XsdTypeBoolean expiringLevel;
        public XsdTypeBoolean ExpiringLevel
        {
            get
            {
                if (this.expiringLevel != null)
                {
                    return this.expiringLevel; 
                }
                else if (this.expiringLevelIDRef != null)
                {
                    expiringLevel = IDManager.getID(expiringLevelIDRef) as XsdTypeBoolean;
                    return this.expiringLevel; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.expiringLevel != value)
                {
                    this.expiringLevel = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region ExpectedN
        private XsdTypePositiveInteger expectedN;
        public XsdTypePositiveInteger ExpectedN
        {
            get
            {
                if (this.expectedN != null)
                {
                    return this.expectedN; 
                }
                else if (this.expectedNIDRef != null)
                {
                    expectedN = IDManager.getID(expectedNIDRef) as XsdTypePositiveInteger;
                    return this.expectedN; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.expectedN != value)
                {
                    this.expectedN = value;
                }
            }
        }
        #endregion
        
        public string XsdTypePositiveIntegerIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

