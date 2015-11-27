using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FxSpotRateSource : ISerialized
    {
        public FxSpotRateSource(XmlNode xmlNode)
        {
            XmlNode primaryRateSourceNode = xmlNode.SelectSingleNode("primaryRateSource");
            
            if (primaryRateSourceNode != null)
            {
                if (primaryRateSourceNode.Attributes["href"] != null || primaryRateSourceNode.Attributes["id"] != null) 
                {
                    if (primaryRateSourceNode.Attributes["id"] != null) 
                    {
                        primaryRateSourceIDRef_ = primaryRateSourceNode.Attributes["id"].Value;
                        InformationSource ob = new InformationSource(primaryRateSourceNode);
                        IDManager.SetID(primaryRateSourceIDRef_, ob);
                    }
                    else if (primaryRateSourceNode.Attributes["href"] != null)
                    {
                        primaryRateSourceIDRef_ = primaryRateSourceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        primaryRateSource_ = new InformationSource(primaryRateSourceNode);
                    }
                }
                else
                {
                    primaryRateSource_ = new InformationSource(primaryRateSourceNode);
                }
            }
            
        
            XmlNode secondaryRateSourceNode = xmlNode.SelectSingleNode("secondaryRateSource");
            
            if (secondaryRateSourceNode != null)
            {
                if (secondaryRateSourceNode.Attributes["href"] != null || secondaryRateSourceNode.Attributes["id"] != null) 
                {
                    if (secondaryRateSourceNode.Attributes["id"] != null) 
                    {
                        secondaryRateSourceIDRef_ = secondaryRateSourceNode.Attributes["id"].Value;
                        InformationSource ob = new InformationSource(secondaryRateSourceNode);
                        IDManager.SetID(secondaryRateSourceIDRef_, ob);
                    }
                    else if (secondaryRateSourceNode.Attributes["href"] != null)
                    {
                        secondaryRateSourceIDRef_ = secondaryRateSourceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        secondaryRateSource_ = new InformationSource(secondaryRateSourceNode);
                    }
                }
                else
                {
                    secondaryRateSource_ = new InformationSource(secondaryRateSourceNode);
                }
            }
            
        
            XmlNode fixingTimeNode = xmlNode.SelectSingleNode("fixingTime");
            
            if (fixingTimeNode != null)
            {
                if (fixingTimeNode.Attributes["href"] != null || fixingTimeNode.Attributes["id"] != null) 
                {
                    if (fixingTimeNode.Attributes["id"] != null) 
                    {
                        fixingTimeIDRef_ = fixingTimeNode.Attributes["id"].Value;
                        BusinessCenterTime ob = new BusinessCenterTime(fixingTimeNode);
                        IDManager.SetID(fixingTimeIDRef_, ob);
                    }
                    else if (fixingTimeNode.Attributes["href"] != null)
                    {
                        fixingTimeIDRef_ = fixingTimeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixingTime_ = new BusinessCenterTime(fixingTimeNode);
                    }
                }
                else
                {
                    fixingTime_ = new BusinessCenterTime(fixingTimeNode);
                }
            }
            
        
        }
        
    
        #region PrimaryRateSource_
        private InformationSource primaryRateSource_;
        public InformationSource PrimaryRateSource_
        {
            get
            {
                if (this.primaryRateSource_ != null)
                {
                    return this.primaryRateSource_; 
                }
                else if (this.primaryRateSourceIDRef_ != null)
                {
                    primaryRateSource_ = IDManager.getID(primaryRateSourceIDRef_) as InformationSource;
                    return this.primaryRateSource_; 
                }
                else
                {
                      return this.primaryRateSource_; 
                }
            }
            set
            {
                if (this.primaryRateSource_ != value)
                {
                    this.primaryRateSource_ = value;
                }
            }
        }
        #endregion
        
        public string primaryRateSourceIDRef_ { get; set; }
        #region SecondaryRateSource_
        private InformationSource secondaryRateSource_;
        public InformationSource SecondaryRateSource_
        {
            get
            {
                if (this.secondaryRateSource_ != null)
                {
                    return this.secondaryRateSource_; 
                }
                else if (this.secondaryRateSourceIDRef_ != null)
                {
                    secondaryRateSource_ = IDManager.getID(secondaryRateSourceIDRef_) as InformationSource;
                    return this.secondaryRateSource_; 
                }
                else
                {
                      return this.secondaryRateSource_; 
                }
            }
            set
            {
                if (this.secondaryRateSource_ != value)
                {
                    this.secondaryRateSource_ = value;
                }
            }
        }
        #endregion
        
        public string secondaryRateSourceIDRef_ { get; set; }
        #region FixingTime_
        private BusinessCenterTime fixingTime_;
        public BusinessCenterTime FixingTime_
        {
            get
            {
                if (this.fixingTime_ != null)
                {
                    return this.fixingTime_; 
                }
                else if (this.fixingTimeIDRef_ != null)
                {
                    fixingTime_ = IDManager.getID(fixingTimeIDRef_) as BusinessCenterTime;
                    return this.fixingTime_; 
                }
                else
                {
                      return this.fixingTime_; 
                }
            }
            set
            {
                if (this.fixingTime_ != value)
                {
                    this.fixingTime_ = value;
                }
            }
        }
        #endregion
        
        public string fixingTimeIDRef_ { get; set; }
        
    
        
    
    }
    
}

