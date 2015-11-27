using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ReportSectionIdentification : ISerialized
    {
        public ReportSectionIdentification(XmlNode xmlNode)
        {
            XmlNode reportIdNode = xmlNode.SelectSingleNode("reportId");
            
            if (reportIdNode != null)
            {
                if (reportIdNode.Attributes["href"] != null || reportIdNode.Attributes["id"] != null) 
                {
                    if (reportIdNode.Attributes["id"] != null) 
                    {
                        reportIdIDRef_ = reportIdNode.Attributes["id"].Value;
                        ReportId ob = new ReportId(reportIdNode);
                        IDManager.SetID(reportIdIDRef_, ob);
                    }
                    else if (reportIdNode.Attributes["href"] != null)
                    {
                        reportIdIDRef_ = reportIdNode.Attributes["href"].Value;
                    }
                    else
                    {
                        reportId_ = new ReportId(reportIdNode);
                    }
                }
                else
                {
                    reportId_ = new ReportId(reportIdNode);
                }
            }
            
        
            XmlNode sectionNumberNode = xmlNode.SelectSingleNode("sectionNumber");
            
            if (sectionNumberNode != null)
            {
                if (sectionNumberNode.Attributes["href"] != null || sectionNumberNode.Attributes["id"] != null) 
                {
                    if (sectionNumberNode.Attributes["id"] != null) 
                    {
                        sectionNumberIDRef_ = sectionNumberNode.Attributes["id"].Value;
                        XsdTypePositiveInteger ob = new XsdTypePositiveInteger(sectionNumberNode);
                        IDManager.SetID(sectionNumberIDRef_, ob);
                    }
                    else if (sectionNumberNode.Attributes["href"] != null)
                    {
                        sectionNumberIDRef_ = sectionNumberNode.Attributes["href"].Value;
                    }
                    else
                    {
                        sectionNumber_ = new XsdTypePositiveInteger(sectionNumberNode);
                    }
                }
                else
                {
                    sectionNumber_ = new XsdTypePositiveInteger(sectionNumberNode);
                }
            }
            
        
        }
        
    
        #region ReportId_
        private ReportId reportId_;
        public ReportId ReportId_
        {
            get
            {
                if (this.reportId_ != null)
                {
                    return this.reportId_; 
                }
                else if (this.reportIdIDRef_ != null)
                {
                    reportId_ = IDManager.getID(reportIdIDRef_) as ReportId;
                    return this.reportId_; 
                }
                else
                {
                      return this.reportId_; 
                }
            }
            set
            {
                if (this.reportId_ != value)
                {
                    this.reportId_ = value;
                }
            }
        }
        #endregion
        
        public string reportIdIDRef_ { get; set; }
        #region SectionNumber_
        private XsdTypePositiveInteger sectionNumber_;
        public XsdTypePositiveInteger SectionNumber_
        {
            get
            {
                if (this.sectionNumber_ != null)
                {
                    return this.sectionNumber_; 
                }
                else if (this.sectionNumberIDRef_ != null)
                {
                    sectionNumber_ = IDManager.getID(sectionNumberIDRef_) as XsdTypePositiveInteger;
                    return this.sectionNumber_; 
                }
                else
                {
                      return this.sectionNumber_; 
                }
            }
            set
            {
                if (this.sectionNumber_ != value)
                {
                    this.sectionNumber_ = value;
                }
            }
        }
        #endregion
        
        public string sectionNumberIDRef_ { get; set; }
        
    
        
    
    }
    
}

