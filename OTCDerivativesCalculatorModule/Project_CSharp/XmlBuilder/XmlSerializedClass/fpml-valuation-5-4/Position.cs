using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Position : ISerialized
    {
        public Position(XmlNode xmlNode)
        {
            XmlNode positionIdNode = xmlNode.SelectSingleNode("positionId");
            
            if (positionIdNode != null)
            {
                if (positionIdNode.Attributes["href"] != null || positionIdNode.Attributes["id"] != null) 
                {
                    if (positionIdNode.Attributes["id"] != null) 
                    {
                        positionIdIDRef_ = positionIdNode.Attributes["id"].Value;
                        PositionId ob = new PositionId(positionIdNode);
                        IDManager.SetID(positionIdIDRef_, ob);
                    }
                    else if (positionIdNode.Attributes["href"] != null)
                    {
                        positionIdIDRef_ = positionIdNode.Attributes["href"].Value;
                    }
                    else
                    {
                        positionId_ = new PositionId(positionIdNode);
                    }
                }
                else
                {
                    positionId_ = new PositionId(positionIdNode);
                }
            }
            
        
            XmlNode versionNode = xmlNode.SelectSingleNode("version");
            
            if (versionNode != null)
            {
                if (versionNode.Attributes["href"] != null || versionNode.Attributes["id"] != null) 
                {
                    if (versionNode.Attributes["id"] != null) 
                    {
                        versionIDRef_ = versionNode.Attributes["id"].Value;
                        XsdTypePositiveInteger ob = new XsdTypePositiveInteger(versionNode);
                        IDManager.SetID(versionIDRef_, ob);
                    }
                    else if (versionNode.Attributes["href"] != null)
                    {
                        versionIDRef_ = versionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        version_ = new XsdTypePositiveInteger(versionNode);
                    }
                }
                else
                {
                    version_ = new XsdTypePositiveInteger(versionNode);
                }
            }
            
        
            XmlNode statusNode = xmlNode.SelectSingleNode("status");
            
            if (statusNode != null)
            {
                if (statusNode.Attributes["href"] != null || statusNode.Attributes["id"] != null) 
                {
                    if (statusNode.Attributes["id"] != null) 
                    {
                        statusIDRef_ = statusNode.Attributes["id"].Value;
                        PositionStatusEnum ob = new PositionStatusEnum(statusNode);
                        IDManager.SetID(statusIDRef_, ob);
                    }
                    else if (statusNode.Attributes["href"] != null)
                    {
                        statusIDRef_ = statusNode.Attributes["href"].Value;
                    }
                    else
                    {
                        status_ = new PositionStatusEnum(statusNode);
                    }
                }
                else
                {
                    status_ = new PositionStatusEnum(statusNode);
                }
            }
            
        
            XmlNode creationDateNode = xmlNode.SelectSingleNode("creationDate");
            
            if (creationDateNode != null)
            {
                if (creationDateNode.Attributes["href"] != null || creationDateNode.Attributes["id"] != null) 
                {
                    if (creationDateNode.Attributes["id"] != null) 
                    {
                        creationDateIDRef_ = creationDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(creationDateNode);
                        IDManager.SetID(creationDateIDRef_, ob);
                    }
                    else if (creationDateNode.Attributes["href"] != null)
                    {
                        creationDateIDRef_ = creationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        creationDate_ = new XsdTypeDate(creationDateNode);
                    }
                }
                else
                {
                    creationDate_ = new XsdTypeDate(creationDateNode);
                }
            }
            
        
            XmlNode originatingEventNode = xmlNode.SelectSingleNode("originatingEvent");
            
            if (originatingEventNode != null)
            {
                if (originatingEventNode.Attributes["href"] != null || originatingEventNode.Attributes["id"] != null) 
                {
                    if (originatingEventNode.Attributes["id"] != null) 
                    {
                        originatingEventIDRef_ = originatingEventNode.Attributes["id"].Value;
                        PositionOriginEnum ob = new PositionOriginEnum(originatingEventNode);
                        IDManager.SetID(originatingEventIDRef_, ob);
                    }
                    else if (originatingEventNode.Attributes["href"] != null)
                    {
                        originatingEventIDRef_ = originatingEventNode.Attributes["href"].Value;
                    }
                    else
                    {
                        originatingEvent_ = new PositionOriginEnum(originatingEventNode);
                    }
                }
                else
                {
                    originatingEvent_ = new PositionOriginEnum(originatingEventNode);
                }
            }
            
        
            XmlNode historyNode = xmlNode.SelectSingleNode("history");
            
            if (historyNode != null)
            {
                if (historyNode.Attributes["href"] != null || historyNode.Attributes["id"] != null) 
                {
                    if (historyNode.Attributes["id"] != null) 
                    {
                        historyIDRef_ = historyNode.Attributes["id"].Value;
                        PositionHistory ob = new PositionHistory(historyNode);
                        IDManager.SetID(historyIDRef_, ob);
                    }
                    else if (historyNode.Attributes["href"] != null)
                    {
                        historyIDRef_ = historyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        history_ = new PositionHistory(historyNode);
                    }
                }
                else
                {
                    history_ = new PositionHistory(historyNode);
                }
            }
            
        
            XmlNode reportingRolesNode = xmlNode.SelectSingleNode("reportingRoles");
            
            if (reportingRolesNode != null)
            {
                if (reportingRolesNode.Attributes["href"] != null || reportingRolesNode.Attributes["id"] != null) 
                {
                    if (reportingRolesNode.Attributes["id"] != null) 
                    {
                        reportingRolesIDRef_ = reportingRolesNode.Attributes["id"].Value;
                        ReportingRoles ob = new ReportingRoles(reportingRolesNode);
                        IDManager.SetID(reportingRolesIDRef_, ob);
                    }
                    else if (reportingRolesNode.Attributes["href"] != null)
                    {
                        reportingRolesIDRef_ = reportingRolesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        reportingRoles_ = new ReportingRoles(reportingRolesNode);
                    }
                }
                else
                {
                    reportingRoles_ = new ReportingRoles(reportingRolesNode);
                }
            }
            
        
            XmlNode constituentNode = xmlNode.SelectSingleNode("constituent");
            
            if (constituentNode != null)
            {
                if (constituentNode.Attributes["href"] != null || constituentNode.Attributes["id"] != null) 
                {
                    if (constituentNode.Attributes["id"] != null) 
                    {
                        constituentIDRef_ = constituentNode.Attributes["id"].Value;
                        PositionConstituent ob = new PositionConstituent(constituentNode);
                        IDManager.SetID(constituentIDRef_, ob);
                    }
                    else if (constituentNode.Attributes["href"] != null)
                    {
                        constituentIDRef_ = constituentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        constituent_ = new PositionConstituent(constituentNode);
                    }
                }
                else
                {
                    constituent_ = new PositionConstituent(constituentNode);
                }
            }
            
        
            XmlNodeList scheduledDateNodeList = xmlNode.SelectNodes("scheduledDate");
            
            if (scheduledDateNodeList != null)
            {
                this.scheduledDate_ = new List<ScheduledDate>();
                foreach (XmlNode item in scheduledDateNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            scheduledDateIDRef_ = item.Attributes["id"].Value;
                            scheduledDate_.Add(new ScheduledDate(item));
                            IDManager.SetID(scheduledDateIDRef_, scheduledDate_[scheduledDate_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            scheduledDateIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        scheduledDate_.Add(new ScheduledDate(item));
                        }
                    }
                    else
                    {
                        scheduledDate_.Add(new ScheduledDate(item));
                    }
                }
            }
            
        
            XmlNodeList valuationNodeList = xmlNode.SelectNodes("valuation");
            
            if (valuationNodeList != null)
            {
                this.valuation_ = new List<AssetValuation>();
                foreach (XmlNode item in valuationNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            valuationIDRef_ = item.Attributes["id"].Value;
                            valuation_.Add(new AssetValuation(item));
                            IDManager.SetID(valuationIDRef_, valuation_[valuation_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            valuationIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        valuation_.Add(new AssetValuation(item));
                        }
                    }
                    else
                    {
                        valuation_.Add(new AssetValuation(item));
                    }
                }
            }
            
        
        }
        
    
        #region PositionId_
        private PositionId positionId_;
        public PositionId PositionId_
        {
            get
            {
                if (this.positionId_ != null)
                {
                    return this.positionId_; 
                }
                else if (this.positionIdIDRef_ != null)
                {
                    positionId_ = IDManager.getID(positionIdIDRef_) as PositionId;
                    return this.positionId_; 
                }
                else
                {
                      return this.positionId_; 
                }
            }
            set
            {
                if (this.positionId_ != value)
                {
                    this.positionId_ = value;
                }
            }
        }
        #endregion
        
        public string positionIdIDRef_ { get; set; }
        #region Version_
        private XsdTypePositiveInteger version_;
        public XsdTypePositiveInteger Version_
        {
            get
            {
                if (this.version_ != null)
                {
                    return this.version_; 
                }
                else if (this.versionIDRef_ != null)
                {
                    version_ = IDManager.getID(versionIDRef_) as XsdTypePositiveInteger;
                    return this.version_; 
                }
                else
                {
                      return this.version_; 
                }
            }
            set
            {
                if (this.version_ != value)
                {
                    this.version_ = value;
                }
            }
        }
        #endregion
        
        public string versionIDRef_ { get; set; }
        #region Status_
        private PositionStatusEnum status_;
        public PositionStatusEnum Status_
        {
            get
            {
                if (this.status_ != null)
                {
                    return this.status_; 
                }
                else if (this.statusIDRef_ != null)
                {
                    status_ = IDManager.getID(statusIDRef_) as PositionStatusEnum;
                    return this.status_; 
                }
                else
                {
                      return this.status_; 
                }
            }
            set
            {
                if (this.status_ != value)
                {
                    this.status_ = value;
                }
            }
        }
        #endregion
        
        public string statusIDRef_ { get; set; }
        #region CreationDate_
        private XsdTypeDate creationDate_;
        public XsdTypeDate CreationDate_
        {
            get
            {
                if (this.creationDate_ != null)
                {
                    return this.creationDate_; 
                }
                else if (this.creationDateIDRef_ != null)
                {
                    creationDate_ = IDManager.getID(creationDateIDRef_) as XsdTypeDate;
                    return this.creationDate_; 
                }
                else
                {
                      return this.creationDate_; 
                }
            }
            set
            {
                if (this.creationDate_ != value)
                {
                    this.creationDate_ = value;
                }
            }
        }
        #endregion
        
        public string creationDateIDRef_ { get; set; }
        #region OriginatingEvent_
        private PositionOriginEnum originatingEvent_;
        public PositionOriginEnum OriginatingEvent_
        {
            get
            {
                if (this.originatingEvent_ != null)
                {
                    return this.originatingEvent_; 
                }
                else if (this.originatingEventIDRef_ != null)
                {
                    originatingEvent_ = IDManager.getID(originatingEventIDRef_) as PositionOriginEnum;
                    return this.originatingEvent_; 
                }
                else
                {
                      return this.originatingEvent_; 
                }
            }
            set
            {
                if (this.originatingEvent_ != value)
                {
                    this.originatingEvent_ = value;
                }
            }
        }
        #endregion
        
        public string originatingEventIDRef_ { get; set; }
        #region History_
        private PositionHistory history_;
        public PositionHistory History_
        {
            get
            {
                if (this.history_ != null)
                {
                    return this.history_; 
                }
                else if (this.historyIDRef_ != null)
                {
                    history_ = IDManager.getID(historyIDRef_) as PositionHistory;
                    return this.history_; 
                }
                else
                {
                      return this.history_; 
                }
            }
            set
            {
                if (this.history_ != value)
                {
                    this.history_ = value;
                }
            }
        }
        #endregion
        
        public string historyIDRef_ { get; set; }
        #region ReportingRoles_
        private ReportingRoles reportingRoles_;
        public ReportingRoles ReportingRoles_
        {
            get
            {
                if (this.reportingRoles_ != null)
                {
                    return this.reportingRoles_; 
                }
                else if (this.reportingRolesIDRef_ != null)
                {
                    reportingRoles_ = IDManager.getID(reportingRolesIDRef_) as ReportingRoles;
                    return this.reportingRoles_; 
                }
                else
                {
                      return this.reportingRoles_; 
                }
            }
            set
            {
                if (this.reportingRoles_ != value)
                {
                    this.reportingRoles_ = value;
                }
            }
        }
        #endregion
        
        public string reportingRolesIDRef_ { get; set; }
        #region Constituent_
        private PositionConstituent constituent_;
        public PositionConstituent Constituent_
        {
            get
            {
                if (this.constituent_ != null)
                {
                    return this.constituent_; 
                }
                else if (this.constituentIDRef_ != null)
                {
                    constituent_ = IDManager.getID(constituentIDRef_) as PositionConstituent;
                    return this.constituent_; 
                }
                else
                {
                      return this.constituent_; 
                }
            }
            set
            {
                if (this.constituent_ != value)
                {
                    this.constituent_ = value;
                }
            }
        }
        #endregion
        
        public string constituentIDRef_ { get; set; }
        #region ScheduledDate_
        private List<ScheduledDate> scheduledDate_;
        public List<ScheduledDate> ScheduledDate_
        {
            get
            {
                if (this.scheduledDate_ != null)
                {
                    return this.scheduledDate_; 
                }
                else if (this.scheduledDateIDRef_ != null)
                {
                    return this.scheduledDate_; 
                }
                else
                {
                      return this.scheduledDate_; 
                }
            }
            set
            {
                if (this.scheduledDate_ != value)
                {
                    this.scheduledDate_ = value;
                }
            }
        }
        #endregion
        
        public string scheduledDateIDRef_ { get; set; }
        #region Valuation_
        private List<AssetValuation> valuation_;
        public List<AssetValuation> Valuation_
        {
            get
            {
                if (this.valuation_ != null)
                {
                    return this.valuation_; 
                }
                else if (this.valuationIDRef_ != null)
                {
                    return this.valuation_; 
                }
                else
                {
                      return this.valuation_; 
                }
            }
            set
            {
                if (this.valuation_ != value)
                {
                    this.valuation_ = value;
                }
            }
        }
        #endregion
        
        public string valuationIDRef_ { get; set; }
        
    
        
    
    }
    
}

