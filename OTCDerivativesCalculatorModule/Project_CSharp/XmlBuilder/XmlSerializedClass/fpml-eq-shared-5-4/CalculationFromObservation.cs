using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CalculationFromObservation : ISerialized
    {
        public CalculationFromObservation(XmlNode xmlNode)
        {
            XmlNode initialLevelNode = xmlNode.SelectSingleNode("initialLevel");
            
            if (initialLevelNode != null)
            {
                if (initialLevelNode.Attributes["href"] != null || initialLevelNode.Attributes["id"] != null) 
                {
                    if (initialLevelNode.Attributes["id"] != null) 
                    {
                        initialLevelIDRef_ = initialLevelNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(initialLevelNode);
                        IDManager.SetID(initialLevelIDRef_, ob);
                    }
                    else if (initialLevelNode.Attributes["href"] != null)
                    {
                        initialLevelIDRef_ = initialLevelNode.Attributes["href"].Value;
                    }
                    else
                    {
                        initialLevel_ = new XsdTypeDecimal(initialLevelNode);
                    }
                }
                else
                {
                    initialLevel_ = new XsdTypeDecimal(initialLevelNode);
                }
            }
            
        
            XmlNode closingLevelNode = xmlNode.SelectSingleNode("closingLevel");
            
            if (closingLevelNode != null)
            {
                if (closingLevelNode.Attributes["href"] != null || closingLevelNode.Attributes["id"] != null) 
                {
                    if (closingLevelNode.Attributes["id"] != null) 
                    {
                        closingLevelIDRef_ = closingLevelNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(closingLevelNode);
                        IDManager.SetID(closingLevelIDRef_, ob);
                    }
                    else if (closingLevelNode.Attributes["href"] != null)
                    {
                        closingLevelIDRef_ = closingLevelNode.Attributes["href"].Value;
                    }
                    else
                    {
                        closingLevel_ = new XsdTypeBoolean(closingLevelNode);
                    }
                }
                else
                {
                    closingLevel_ = new XsdTypeBoolean(closingLevelNode);
                }
            }
            
        
            XmlNode expiringLevelNode = xmlNode.SelectSingleNode("expiringLevel");
            
            if (expiringLevelNode != null)
            {
                if (expiringLevelNode.Attributes["href"] != null || expiringLevelNode.Attributes["id"] != null) 
                {
                    if (expiringLevelNode.Attributes["id"] != null) 
                    {
                        expiringLevelIDRef_ = expiringLevelNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(expiringLevelNode);
                        IDManager.SetID(expiringLevelIDRef_, ob);
                    }
                    else if (expiringLevelNode.Attributes["href"] != null)
                    {
                        expiringLevelIDRef_ = expiringLevelNode.Attributes["href"].Value;
                    }
                    else
                    {
                        expiringLevel_ = new XsdTypeBoolean(expiringLevelNode);
                    }
                }
                else
                {
                    expiringLevel_ = new XsdTypeBoolean(expiringLevelNode);
                }
            }
            
        
            XmlNode expectedNNode = xmlNode.SelectSingleNode("expectedN");
            
            if (expectedNNode != null)
            {
                if (expectedNNode.Attributes["href"] != null || expectedNNode.Attributes["id"] != null) 
                {
                    if (expectedNNode.Attributes["id"] != null) 
                    {
                        expectedNIDRef_ = expectedNNode.Attributes["id"].Value;
                        XsdTypePositiveInteger ob = new XsdTypePositiveInteger(expectedNNode);
                        IDManager.SetID(expectedNIDRef_, ob);
                    }
                    else if (expectedNNode.Attributes["href"] != null)
                    {
                        expectedNIDRef_ = expectedNNode.Attributes["href"].Value;
                    }
                    else
                    {
                        expectedN_ = new XsdTypePositiveInteger(expectedNNode);
                    }
                }
                else
                {
                    expectedN_ = new XsdTypePositiveInteger(expectedNNode);
                }
            }
            
        
        }
        
    
        #region InitialLevel_
        private XsdTypeDecimal initialLevel_;
        public XsdTypeDecimal InitialLevel_
        {
            get
            {
                if (this.initialLevel_ != null)
                {
                    return this.initialLevel_; 
                }
                else if (this.initialLevelIDRef_ != null)
                {
                    initialLevel_ = IDManager.getID(initialLevelIDRef_) as XsdTypeDecimal;
                    return this.initialLevel_; 
                }
                else
                {
                      return this.initialLevel_; 
                }
            }
            set
            {
                if (this.initialLevel_ != value)
                {
                    this.initialLevel_ = value;
                }
            }
        }
        #endregion
        
        public string initialLevelIDRef_ { get; set; }
        #region ClosingLevel_
        private XsdTypeBoolean closingLevel_;
        public XsdTypeBoolean ClosingLevel_
        {
            get
            {
                if (this.closingLevel_ != null)
                {
                    return this.closingLevel_; 
                }
                else if (this.closingLevelIDRef_ != null)
                {
                    closingLevel_ = IDManager.getID(closingLevelIDRef_) as XsdTypeBoolean;
                    return this.closingLevel_; 
                }
                else
                {
                      return this.closingLevel_; 
                }
            }
            set
            {
                if (this.closingLevel_ != value)
                {
                    this.closingLevel_ = value;
                }
            }
        }
        #endregion
        
        public string closingLevelIDRef_ { get; set; }
        #region ExpiringLevel_
        private XsdTypeBoolean expiringLevel_;
        public XsdTypeBoolean ExpiringLevel_
        {
            get
            {
                if (this.expiringLevel_ != null)
                {
                    return this.expiringLevel_; 
                }
                else if (this.expiringLevelIDRef_ != null)
                {
                    expiringLevel_ = IDManager.getID(expiringLevelIDRef_) as XsdTypeBoolean;
                    return this.expiringLevel_; 
                }
                else
                {
                      return this.expiringLevel_; 
                }
            }
            set
            {
                if (this.expiringLevel_ != value)
                {
                    this.expiringLevel_ = value;
                }
            }
        }
        #endregion
        
        public string expiringLevelIDRef_ { get; set; }
        #region ExpectedN_
        private XsdTypePositiveInteger expectedN_;
        public XsdTypePositiveInteger ExpectedN_
        {
            get
            {
                if (this.expectedN_ != null)
                {
                    return this.expectedN_; 
                }
                else if (this.expectedNIDRef_ != null)
                {
                    expectedN_ = IDManager.getID(expectedNIDRef_) as XsdTypePositiveInteger;
                    return this.expectedN_; 
                }
                else
                {
                      return this.expectedN_; 
                }
            }
            set
            {
                if (this.expectedN_ != value)
                {
                    this.expectedN_ = value;
                }
            }
        }
        #endregion
        
        public string expectedNIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

