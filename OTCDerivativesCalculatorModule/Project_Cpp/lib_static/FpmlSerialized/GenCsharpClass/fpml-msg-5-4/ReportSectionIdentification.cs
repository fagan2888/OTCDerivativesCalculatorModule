using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ReportSectionIdentification
    {
        public ReportSectionIdentification(XmlNode xmlNode)
        {
            XmlNodeList reportIdNodeList = xmlNode.SelectNodes("reportId");
            if (reportIdNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in reportIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        reportIdIDRef = item.Attributes["id"].Name;
                        ReportId ob = ReportId();
                        IDManager.SetID(reportIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        reportIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        reportId = new ReportId(item);
                    }
                }
            }
            
        
            XmlNodeList sectionNumberNodeList = xmlNode.SelectNodes("sectionNumber");
            if (sectionNumberNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in sectionNumberNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        sectionNumberIDRef = item.Attributes["id"].Name;
                        XsdTypePositiveInteger ob = XsdTypePositiveInteger();
                        IDManager.SetID(sectionNumberIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        sectionNumberIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        sectionNumber = new XsdTypePositiveInteger(item);
                    }
                }
            }
            
        
        }
        
    
        #region ReportId
        private ReportId reportId;
        public ReportId ReportId
        {
            get
            {
                if (this.reportId != null)
                {
                    return this.reportId; 
                }
                else if (this.reportIdIDRef != null)
                {
                    reportId = IDManager.getID(reportIdIDRef) as ReportId;
                    return this.reportId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.reportId != value)
                {
                    this.reportId = value;
                }
            }
        }
        #endregion
        
        public string ReportIdIDRef { get; set; }
        #region SectionNumber
        private XsdTypePositiveInteger sectionNumber;
        public XsdTypePositiveInteger SectionNumber
        {
            get
            {
                if (this.sectionNumber != null)
                {
                    return this.sectionNumber; 
                }
                else if (this.sectionNumberIDRef != null)
                {
                    sectionNumber = IDManager.getID(sectionNumberIDRef) as XsdTypePositiveInteger;
                    return this.sectionNumber; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.sectionNumber != value)
                {
                    this.sectionNumber = value;
                }
            }
        }
        #endregion
        
        public string XsdTypePositiveIntegerIDRef { get; set; }
        
    
        
    
    }
    
}

