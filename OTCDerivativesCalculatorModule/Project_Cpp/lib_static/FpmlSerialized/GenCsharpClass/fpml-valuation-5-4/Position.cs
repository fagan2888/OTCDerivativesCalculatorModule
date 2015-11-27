using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Position
    {
        public Position(XmlNode xmlNode)
        {
            XmlNodeList positionIdNodeList = xmlNode.SelectNodes("positionId");
            if (positionIdNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in positionIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        positionIdIDRef = item.Attributes["id"].Name;
                        PositionId ob = PositionId();
                        IDManager.SetID(positionIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        positionIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        positionId = new PositionId(item);
                    }
                }
            }
            
        
            XmlNodeList versionNodeList = xmlNode.SelectNodes("version");
            if (versionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in versionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        versionIDRef = item.Attributes["id"].Name;
                        XsdTypePositiveInteger ob = XsdTypePositiveInteger();
                        IDManager.SetID(versionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        versionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        version = new XsdTypePositiveInteger(item);
                    }
                }
            }
            
        
            XmlNodeList statusNodeList = xmlNode.SelectNodes("status");
            if (statusNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in statusNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        statusIDRef = item.Attributes["id"].Name;
                        PositionStatusEnum ob = PositionStatusEnum();
                        IDManager.SetID(statusIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        statusIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        status = new PositionStatusEnum(item);
                    }
                }
            }
            
        
            XmlNodeList creationDateNodeList = xmlNode.SelectNodes("creationDate");
            if (creationDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in creationDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        creationDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(creationDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        creationDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        creationDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList originatingEventNodeList = xmlNode.SelectNodes("originatingEvent");
            if (originatingEventNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in originatingEventNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        originatingEventIDRef = item.Attributes["id"].Name;
                        PositionOriginEnum ob = PositionOriginEnum();
                        IDManager.SetID(originatingEventIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        originatingEventIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        originatingEvent = new PositionOriginEnum(item);
                    }
                }
            }
            
        
            XmlNodeList historyNodeList = xmlNode.SelectNodes("history");
            if (historyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in historyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        historyIDRef = item.Attributes["id"].Name;
                        PositionHistory ob = PositionHistory();
                        IDManager.SetID(historyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        historyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        history = new PositionHistory(item);
                    }
                }
            }
            
        
            XmlNodeList reportingRolesNodeList = xmlNode.SelectNodes("reportingRoles");
            if (reportingRolesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in reportingRolesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        reportingRolesIDRef = item.Attributes["id"].Name;
                        ReportingRoles ob = ReportingRoles();
                        IDManager.SetID(reportingRolesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        reportingRolesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        reportingRoles = new ReportingRoles(item);
                    }
                }
            }
            
        
            XmlNodeList constituentNodeList = xmlNode.SelectNodes("constituent");
            if (constituentNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in constituentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        constituentIDRef = item.Attributes["id"].Name;
                        PositionConstituent ob = PositionConstituent();
                        IDManager.SetID(constituentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        constituentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        constituent = new PositionConstituent(item);
                    }
                }
            }
            
        
            XmlNodeList scheduledDateNodeList = xmlNode.SelectNodes("scheduledDate");
            
            foreach (XmlNode item in scheduledDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        scheduledDateIDRef = item.Attributes["id"].Name;
                        List<ScheduledDate> ob = new List<ScheduledDate>();
                        ob.Add(new ScheduledDate(item));
                        IDManager.SetID(scheduledDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        scheduledDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    scheduledDate.Add(new ScheduledDate(item));
                    }
                }
            }
            
        
            XmlNodeList valuationNodeList = xmlNode.SelectNodes("valuation");
            
            foreach (XmlNode item in valuationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        valuationIDRef = item.Attributes["id"].Name;
                        List<AssetValuation> ob = new List<AssetValuation>();
                        ob.Add(new AssetValuation(item));
                        IDManager.SetID(valuationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        valuationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    valuation.Add(new AssetValuation(item));
                    }
                }
            }
            
        
        }
        
    
        #region PositionId
        private PositionId positionId;
        public PositionId PositionId
        {
            get
            {
                if (this.positionId != null)
                {
                    return this.positionId; 
                }
                else if (this.positionIdIDRef != null)
                {
                    positionId = IDManager.getID(positionIdIDRef) as PositionId;
                    return this.positionId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.positionId != value)
                {
                    this.positionId = value;
                }
            }
        }
        #endregion
        
        public string PositionIdIDRef { get; set; }
        #region Version
        private XsdTypePositiveInteger version;
        public XsdTypePositiveInteger Version
        {
            get
            {
                if (this.version != null)
                {
                    return this.version; 
                }
                else if (this.versionIDRef != null)
                {
                    version = IDManager.getID(versionIDRef) as XsdTypePositiveInteger;
                    return this.version; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.version != value)
                {
                    this.version = value;
                }
            }
        }
        #endregion
        
        public string XsdTypePositiveIntegerIDRef { get; set; }
        #region Status
        private PositionStatusEnum status;
        public PositionStatusEnum Status
        {
            get
            {
                if (this.status != null)
                {
                    return this.status; 
                }
                else if (this.statusIDRef != null)
                {
                    status = IDManager.getID(statusIDRef) as PositionStatusEnum;
                    return this.status; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.status != value)
                {
                    this.status = value;
                }
            }
        }
        #endregion
        
        public string PositionStatusEnumIDRef { get; set; }
        #region CreationDate
        private XsdTypeDate creationDate;
        public XsdTypeDate CreationDate
        {
            get
            {
                if (this.creationDate != null)
                {
                    return this.creationDate; 
                }
                else if (this.creationDateIDRef != null)
                {
                    creationDate = IDManager.getID(creationDateIDRef) as XsdTypeDate;
                    return this.creationDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.creationDate != value)
                {
                    this.creationDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region OriginatingEvent
        private PositionOriginEnum originatingEvent;
        public PositionOriginEnum OriginatingEvent
        {
            get
            {
                if (this.originatingEvent != null)
                {
                    return this.originatingEvent; 
                }
                else if (this.originatingEventIDRef != null)
                {
                    originatingEvent = IDManager.getID(originatingEventIDRef) as PositionOriginEnum;
                    return this.originatingEvent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.originatingEvent != value)
                {
                    this.originatingEvent = value;
                }
            }
        }
        #endregion
        
        public string PositionOriginEnumIDRef { get; set; }
        #region History
        private PositionHistory history;
        public PositionHistory History
        {
            get
            {
                if (this.history != null)
                {
                    return this.history; 
                }
                else if (this.historyIDRef != null)
                {
                    history = IDManager.getID(historyIDRef) as PositionHistory;
                    return this.history; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.history != value)
                {
                    this.history = value;
                }
            }
        }
        #endregion
        
        public string PositionHistoryIDRef { get; set; }
        #region ReportingRoles
        private ReportingRoles reportingRoles;
        public ReportingRoles ReportingRoles
        {
            get
            {
                if (this.reportingRoles != null)
                {
                    return this.reportingRoles; 
                }
                else if (this.reportingRolesIDRef != null)
                {
                    reportingRoles = IDManager.getID(reportingRolesIDRef) as ReportingRoles;
                    return this.reportingRoles; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.reportingRoles != value)
                {
                    this.reportingRoles = value;
                }
            }
        }
        #endregion
        
        public string ReportingRolesIDRef { get; set; }
        #region Constituent
        private PositionConstituent constituent;
        public PositionConstituent Constituent
        {
            get
            {
                if (this.constituent != null)
                {
                    return this.constituent; 
                }
                else if (this.constituentIDRef != null)
                {
                    constituent = IDManager.getID(constituentIDRef) as PositionConstituent;
                    return this.constituent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.constituent != value)
                {
                    this.constituent = value;
                }
            }
        }
        #endregion
        
        public string PositionConstituentIDRef { get; set; }
        #region ScheduledDate
        private List<ScheduledDate> scheduledDate;
        public List<ScheduledDate> ScheduledDate
        {
            get
            {
                if (this.scheduledDate != null)
                {
                    return this.scheduledDate; 
                }
                else if (this.scheduledDateIDRef != null)
                {
                    scheduledDate = IDManager.getID(scheduledDateIDRef) as List<ScheduledDate>;
                    return this.scheduledDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.scheduledDate != value)
                {
                    this.scheduledDate = value;
                }
            }
        }
        #endregion
        
        public string ScheduledDateIDRef { get; set; }
        #region Valuation
        private List<AssetValuation> valuation;
        public List<AssetValuation> Valuation
        {
            get
            {
                if (this.valuation != null)
                {
                    return this.valuation; 
                }
                else if (this.valuationIDRef != null)
                {
                    valuation = IDManager.getID(valuationIDRef) as List<AssetValuation>;
                    return this.valuation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.valuation != value)
                {
                    this.valuation = value;
                }
            }
        }
        #endregion
        
        public string AssetValuationIDRef { get; set; }
        
    
        
    
    }
    
}

