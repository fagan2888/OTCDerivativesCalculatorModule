using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FxDigitalAmericanExercise : Exercise
    {
        public FxDigitalAmericanExercise(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode commencementDateNode = xmlNode.SelectSingleNode("commencementDate");
            
            if (commencementDateNode != null)
            {
                if (commencementDateNode.Attributes["href"] != null || commencementDateNode.Attributes["id"] != null) 
                {
                    if (commencementDateNode.Attributes["id"] != null) 
                    {
                        commencementDateIDRef_ = commencementDateNode.Attributes["id"].Value;
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(commencementDateNode);
                        IDManager.SetID(commencementDateIDRef_, ob);
                    }
                    else if (commencementDateNode.Attributes["href"] != null)
                    {
                        commencementDateIDRef_ = commencementDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        commencementDate_ = new AdjustableOrRelativeDate(commencementDateNode);
                    }
                }
                else
                {
                    commencementDate_ = new AdjustableOrRelativeDate(commencementDateNode);
                }
            }
            
        
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
            
        
            XmlNode latestValueDateNode = xmlNode.SelectSingleNode("latestValueDate");
            
            if (latestValueDateNode != null)
            {
                if (latestValueDateNode.Attributes["href"] != null || latestValueDateNode.Attributes["id"] != null) 
                {
                    if (latestValueDateNode.Attributes["id"] != null) 
                    {
                        latestValueDateIDRef_ = latestValueDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(latestValueDateNode);
                        IDManager.SetID(latestValueDateIDRef_, ob);
                    }
                    else if (latestValueDateNode.Attributes["href"] != null)
                    {
                        latestValueDateIDRef_ = latestValueDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        latestValueDate_ = new XsdTypeDate(latestValueDateNode);
                    }
                }
                else
                {
                    latestValueDate_ = new XsdTypeDate(latestValueDateNode);
                }
            }
            
        
        }
        
    
        #region CommencementDate_
        private AdjustableOrRelativeDate commencementDate_;
        public AdjustableOrRelativeDate CommencementDate_
        {
            get
            {
                if (this.commencementDate_ != null)
                {
                    return this.commencementDate_; 
                }
                else if (this.commencementDateIDRef_ != null)
                {
                    commencementDate_ = IDManager.getID(commencementDateIDRef_) as AdjustableOrRelativeDate;
                    return this.commencementDate_; 
                }
                else
                {
                      return this.commencementDate_; 
                }
            }
            set
            {
                if (this.commencementDate_ != value)
                {
                    this.commencementDate_ = value;
                }
            }
        }
        #endregion
        
        public string commencementDateIDRef_ { get; set; }
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
        #region LatestValueDate_
        private XsdTypeDate latestValueDate_;
        public XsdTypeDate LatestValueDate_
        {
            get
            {
                if (this.latestValueDate_ != null)
                {
                    return this.latestValueDate_; 
                }
                else if (this.latestValueDateIDRef_ != null)
                {
                    latestValueDate_ = IDManager.getID(latestValueDateIDRef_) as XsdTypeDate;
                    return this.latestValueDate_; 
                }
                else
                {
                      return this.latestValueDate_; 
                }
            }
            set
            {
                if (this.latestValueDate_ != value)
                {
                    this.latestValueDate_ = value;
                }
            }
        }
        #endregion
        
        public string latestValueDateIDRef_ { get; set; }
        
    
        
    
    }
    
}

