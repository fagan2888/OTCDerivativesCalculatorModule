using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FxEuropeanExercise : Exercise
    {
        public FxEuropeanExercise(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode expiryDateNode = xmlNode.SelectSingleNode("expiryDate");
            
            if (expiryDateNode != null)
            {
                if (expiryDateNode.Attributes["href"] != null || expiryDateNode.Attributes["id"] != null) 
                {
                    if (expiryDateNode.Attributes["id"] != null) 
                    {
                        expiryDateIDRef_ = expiryDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(expiryDateNode);
                        IDManager.SetID(expiryDateIDRef_, ob);
                    }
                    else if (expiryDateNode.Attributes["href"] != null)
                    {
                        expiryDateIDRef_ = expiryDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        expiryDate_ = new XsdTypeDate(expiryDateNode);
                    }
                }
                else
                {
                    expiryDate_ = new XsdTypeDate(expiryDateNode);
                }
            }
            
        
            XmlNode expiryTimeNode = xmlNode.SelectSingleNode("expiryTime");
            
            if (expiryTimeNode != null)
            {
                if (expiryTimeNode.Attributes["href"] != null || expiryTimeNode.Attributes["id"] != null) 
                {
                    if (expiryTimeNode.Attributes["id"] != null) 
                    {
                        expiryTimeIDRef_ = expiryTimeNode.Attributes["id"].Value;
                        BusinessCenterTime ob = new BusinessCenterTime(expiryTimeNode);
                        IDManager.SetID(expiryTimeIDRef_, ob);
                    }
                    else if (expiryTimeNode.Attributes["href"] != null)
                    {
                        expiryTimeIDRef_ = expiryTimeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        expiryTime_ = new BusinessCenterTime(expiryTimeNode);
                    }
                }
                else
                {
                    expiryTime_ = new BusinessCenterTime(expiryTimeNode);
                }
            }
            
        
            XmlNode cutNameNode = xmlNode.SelectSingleNode("cutName");
            
            if (cutNameNode != null)
            {
                if (cutNameNode.Attributes["href"] != null || cutNameNode.Attributes["id"] != null) 
                {
                    if (cutNameNode.Attributes["id"] != null) 
                    {
                        cutNameIDRef_ = cutNameNode.Attributes["id"].Value;
                        CutName ob = new CutName(cutNameNode);
                        IDManager.SetID(cutNameIDRef_, ob);
                    }
                    else if (cutNameNode.Attributes["href"] != null)
                    {
                        cutNameIDRef_ = cutNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        cutName_ = new CutName(cutNameNode);
                    }
                }
                else
                {
                    cutName_ = new CutName(cutNameNode);
                }
            }
            
        
            XmlNode valueDateNode = xmlNode.SelectSingleNode("valueDate");
            
            if (valueDateNode != null)
            {
                if (valueDateNode.Attributes["href"] != null || valueDateNode.Attributes["id"] != null) 
                {
                    if (valueDateNode.Attributes["id"] != null) 
                    {
                        valueDateIDRef_ = valueDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(valueDateNode);
                        IDManager.SetID(valueDateIDRef_, ob);
                    }
                    else if (valueDateNode.Attributes["href"] != null)
                    {
                        valueDateIDRef_ = valueDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        valueDate_ = new XsdTypeDate(valueDateNode);
                    }
                }
                else
                {
                    valueDate_ = new XsdTypeDate(valueDateNode);
                }
            }
            
        
        }
        
    
        #region ExpiryDate_
        private XsdTypeDate expiryDate_;
        public XsdTypeDate ExpiryDate_
        {
            get
            {
                if (this.expiryDate_ != null)
                {
                    return this.expiryDate_; 
                }
                else if (this.expiryDateIDRef_ != null)
                {
                    expiryDate_ = IDManager.getID(expiryDateIDRef_) as XsdTypeDate;
                    return this.expiryDate_; 
                }
                else
                {
                      return this.expiryDate_; 
                }
            }
            set
            {
                if (this.expiryDate_ != value)
                {
                    this.expiryDate_ = value;
                }
            }
        }
        #endregion
        
        public string expiryDateIDRef_ { get; set; }
        #region ExpiryTime_
        private BusinessCenterTime expiryTime_;
        public BusinessCenterTime ExpiryTime_
        {
            get
            {
                if (this.expiryTime_ != null)
                {
                    return this.expiryTime_; 
                }
                else if (this.expiryTimeIDRef_ != null)
                {
                    expiryTime_ = IDManager.getID(expiryTimeIDRef_) as BusinessCenterTime;
                    return this.expiryTime_; 
                }
                else
                {
                      return this.expiryTime_; 
                }
            }
            set
            {
                if (this.expiryTime_ != value)
                {
                    this.expiryTime_ = value;
                }
            }
        }
        #endregion
        
        public string expiryTimeIDRef_ { get; set; }
        #region CutName_
        private CutName cutName_;
        public CutName CutName_
        {
            get
            {
                if (this.cutName_ != null)
                {
                    return this.cutName_; 
                }
                else if (this.cutNameIDRef_ != null)
                {
                    cutName_ = IDManager.getID(cutNameIDRef_) as CutName;
                    return this.cutName_; 
                }
                else
                {
                      return this.cutName_; 
                }
            }
            set
            {
                if (this.cutName_ != value)
                {
                    this.cutName_ = value;
                }
            }
        }
        #endregion
        
        public string cutNameIDRef_ { get; set; }
        #region ValueDate_
        private XsdTypeDate valueDate_;
        public XsdTypeDate ValueDate_
        {
            get
            {
                if (this.valueDate_ != null)
                {
                    return this.valueDate_; 
                }
                else if (this.valueDateIDRef_ != null)
                {
                    valueDate_ = IDManager.getID(valueDateIDRef_) as XsdTypeDate;
                    return this.valueDate_; 
                }
                else
                {
                      return this.valueDate_; 
                }
            }
            set
            {
                if (this.valueDate_ != value)
                {
                    this.valueDate_ = value;
                }
            }
        }
        #endregion
        
        public string valueDateIDRef_ { get; set; }
        
    
        
    
    }
    
}

