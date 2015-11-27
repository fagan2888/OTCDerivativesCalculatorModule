using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ReportIdentification : ReportSectionIdentification
    {
        public ReportIdentification(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode numberOfSectionsNode = xmlNode.SelectSingleNode("numberOfSections");
            
            if (numberOfSectionsNode != null)
            {
                if (numberOfSectionsNode.Attributes["href"] != null || numberOfSectionsNode.Attributes["id"] != null) 
                {
                    if (numberOfSectionsNode.Attributes["id"] != null) 
                    {
                        numberOfSectionsIDRef_ = numberOfSectionsNode.Attributes["id"].Value;
                        XsdTypePositiveInteger ob = new XsdTypePositiveInteger(numberOfSectionsNode);
                        IDManager.SetID(numberOfSectionsIDRef_, ob);
                    }
                    else if (numberOfSectionsNode.Attributes["href"] != null)
                    {
                        numberOfSectionsIDRef_ = numberOfSectionsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        numberOfSections_ = new XsdTypePositiveInteger(numberOfSectionsNode);
                    }
                }
                else
                {
                    numberOfSections_ = new XsdTypePositiveInteger(numberOfSectionsNode);
                }
            }
            
        
            XmlNode submissionsCompleteNode = xmlNode.SelectSingleNode("submissionsComplete");
            
            if (submissionsCompleteNode != null)
            {
                if (submissionsCompleteNode.Attributes["href"] != null || submissionsCompleteNode.Attributes["id"] != null) 
                {
                    if (submissionsCompleteNode.Attributes["id"] != null) 
                    {
                        submissionsCompleteIDRef_ = submissionsCompleteNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(submissionsCompleteNode);
                        IDManager.SetID(submissionsCompleteIDRef_, ob);
                    }
                    else if (submissionsCompleteNode.Attributes["href"] != null)
                    {
                        submissionsCompleteIDRef_ = submissionsCompleteNode.Attributes["href"].Value;
                    }
                    else
                    {
                        submissionsComplete_ = new XsdTypeBoolean(submissionsCompleteNode);
                    }
                }
                else
                {
                    submissionsComplete_ = new XsdTypeBoolean(submissionsCompleteNode);
                }
            }
            
        
        }
        
    
        #region NumberOfSections_
        private XsdTypePositiveInteger numberOfSections_;
        public XsdTypePositiveInteger NumberOfSections_
        {
            get
            {
                if (this.numberOfSections_ != null)
                {
                    return this.numberOfSections_; 
                }
                else if (this.numberOfSectionsIDRef_ != null)
                {
                    numberOfSections_ = IDManager.getID(numberOfSectionsIDRef_) as XsdTypePositiveInteger;
                    return this.numberOfSections_; 
                }
                else
                {
                      return this.numberOfSections_; 
                }
            }
            set
            {
                if (this.numberOfSections_ != value)
                {
                    this.numberOfSections_ = value;
                }
            }
        }
        #endregion
        
        public string numberOfSectionsIDRef_ { get; set; }
        #region SubmissionsComplete_
        private XsdTypeBoolean submissionsComplete_;
        public XsdTypeBoolean SubmissionsComplete_
        {
            get
            {
                if (this.submissionsComplete_ != null)
                {
                    return this.submissionsComplete_; 
                }
                else if (this.submissionsCompleteIDRef_ != null)
                {
                    submissionsComplete_ = IDManager.getID(submissionsCompleteIDRef_) as XsdTypeBoolean;
                    return this.submissionsComplete_; 
                }
                else
                {
                      return this.submissionsComplete_; 
                }
            }
            set
            {
                if (this.submissionsComplete_ != value)
                {
                    this.submissionsComplete_ = value;
                }
            }
        }
        #endregion
        
        public string submissionsCompleteIDRef_ { get; set; }
        
    
        
    
    }
    
}

