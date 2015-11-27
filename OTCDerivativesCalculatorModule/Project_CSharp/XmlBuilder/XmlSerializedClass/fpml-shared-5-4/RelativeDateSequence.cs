using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class RelativeDateSequence : ISerialized
    {
        public RelativeDateSequence(XmlNode xmlNode)
        {
            XmlNode dateRelativeToNode = xmlNode.SelectSingleNode("dateRelativeTo");
            
            if (dateRelativeToNode != null)
            {
                if (dateRelativeToNode.Attributes["href"] != null || dateRelativeToNode.Attributes["id"] != null) 
                {
                    if (dateRelativeToNode.Attributes["id"] != null) 
                    {
                        dateRelativeToIDRef_ = dateRelativeToNode.Attributes["id"].Value;
                        DateReference ob = new DateReference(dateRelativeToNode);
                        IDManager.SetID(dateRelativeToIDRef_, ob);
                    }
                    else if (dateRelativeToNode.Attributes["href"] != null)
                    {
                        dateRelativeToIDRef_ = dateRelativeToNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dateRelativeTo_ = new DateReference(dateRelativeToNode);
                    }
                }
                else
                {
                    dateRelativeTo_ = new DateReference(dateRelativeToNode);
                }
            }
            
        
            XmlNodeList dateOffsetNodeList = xmlNode.SelectNodes("dateOffset");
            
            if (dateOffsetNodeList != null)
            {
                this.dateOffset_ = new List<DateOffset>();
                foreach (XmlNode item in dateOffsetNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            dateOffsetIDRef_ = item.Attributes["id"].Value;
                            dateOffset_.Add(new DateOffset(item));
                            IDManager.SetID(dateOffsetIDRef_, dateOffset_[dateOffset_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            dateOffsetIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        dateOffset_.Add(new DateOffset(item));
                        }
                    }
                    else
                    {
                        dateOffset_.Add(new DateOffset(item));
                    }
                }
            }
            
        
            XmlNode businessCentersReferenceNode = xmlNode.SelectSingleNode("businessCentersReference");
            
            if (businessCentersReferenceNode != null)
            {
                if (businessCentersReferenceNode.Attributes["href"] != null || businessCentersReferenceNode.Attributes["id"] != null) 
                {
                    if (businessCentersReferenceNode.Attributes["id"] != null) 
                    {
                        businessCentersReferenceIDRef_ = businessCentersReferenceNode.Attributes["id"].Value;
                        BusinessCentersReference ob = new BusinessCentersReference(businessCentersReferenceNode);
                        IDManager.SetID(businessCentersReferenceIDRef_, ob);
                    }
                    else if (businessCentersReferenceNode.Attributes["href"] != null)
                    {
                        businessCentersReferenceIDRef_ = businessCentersReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        businessCentersReference_ = new BusinessCentersReference(businessCentersReferenceNode);
                    }
                }
                else
                {
                    businessCentersReference_ = new BusinessCentersReference(businessCentersReferenceNode);
                }
            }
            
        
            XmlNode businessCentersNode = xmlNode.SelectSingleNode("businessCenters");
            
            if (businessCentersNode != null)
            {
                if (businessCentersNode.Attributes["href"] != null || businessCentersNode.Attributes["id"] != null) 
                {
                    if (businessCentersNode.Attributes["id"] != null) 
                    {
                        businessCentersIDRef_ = businessCentersNode.Attributes["id"].Value;
                        BusinessCenters ob = new BusinessCenters(businessCentersNode);
                        IDManager.SetID(businessCentersIDRef_, ob);
                    }
                    else if (businessCentersNode.Attributes["href"] != null)
                    {
                        businessCentersIDRef_ = businessCentersNode.Attributes["href"].Value;
                    }
                    else
                    {
                        businessCenters_ = new BusinessCenters(businessCentersNode);
                    }
                }
                else
                {
                    businessCenters_ = new BusinessCenters(businessCentersNode);
                }
            }
            
        
        }
        
    
        #region DateRelativeTo_
        private DateReference dateRelativeTo_;
        public DateReference DateRelativeTo_
        {
            get
            {
                if (this.dateRelativeTo_ != null)
                {
                    return this.dateRelativeTo_; 
                }
                else if (this.dateRelativeToIDRef_ != null)
                {
                    dateRelativeTo_ = IDManager.getID(dateRelativeToIDRef_) as DateReference;
                    return this.dateRelativeTo_; 
                }
                else
                {
                      return this.dateRelativeTo_; 
                }
            }
            set
            {
                if (this.dateRelativeTo_ != value)
                {
                    this.dateRelativeTo_ = value;
                }
            }
        }
        #endregion
        
        public string dateRelativeToIDRef_ { get; set; }
        #region DateOffset_
        private List<DateOffset> dateOffset_;
        public List<DateOffset> DateOffset_
        {
            get
            {
                if (this.dateOffset_ != null)
                {
                    return this.dateOffset_; 
                }
                else if (this.dateOffsetIDRef_ != null)
                {
                    return this.dateOffset_; 
                }
                else
                {
                      return this.dateOffset_; 
                }
            }
            set
            {
                if (this.dateOffset_ != value)
                {
                    this.dateOffset_ = value;
                }
            }
        }
        #endregion
        
        public string dateOffsetIDRef_ { get; set; }
        #region BusinessCentersReference_
        private BusinessCentersReference businessCentersReference_;
        public BusinessCentersReference BusinessCentersReference_
        {
            get
            {
                if (this.businessCentersReference_ != null)
                {
                    return this.businessCentersReference_; 
                }
                else if (this.businessCentersReferenceIDRef_ != null)
                {
                    businessCentersReference_ = IDManager.getID(businessCentersReferenceIDRef_) as BusinessCentersReference;
                    return this.businessCentersReference_; 
                }
                else
                {
                      return this.businessCentersReference_; 
                }
            }
            set
            {
                if (this.businessCentersReference_ != value)
                {
                    this.businessCentersReference_ = value;
                }
            }
        }
        #endregion
        
        public string businessCentersReferenceIDRef_ { get; set; }
        #region BusinessCenters_
        private BusinessCenters businessCenters_;
        public BusinessCenters BusinessCenters_
        {
            get
            {
                if (this.businessCenters_ != null)
                {
                    return this.businessCenters_; 
                }
                else if (this.businessCentersIDRef_ != null)
                {
                    businessCenters_ = IDManager.getID(businessCentersIDRef_) as BusinessCenters;
                    return this.businessCenters_; 
                }
                else
                {
                      return this.businessCenters_; 
                }
            }
            set
            {
                if (this.businessCenters_ != value)
                {
                    this.businessCenters_ = value;
                }
            }
        }
        #endregion
        
        public string businessCentersIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

