using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PhysicalSettlementTerms
    {
        public PhysicalSettlementTerms(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList physicalSettlementPeriodNodeList = xmlNode.SelectNodes("physicalSettlementPeriod");
            if (physicalSettlementPeriodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in physicalSettlementPeriodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        physicalSettlementPeriodIDRef = item.Attributes["id"].Name;
                        PhysicalSettlementPeriod ob = PhysicalSettlementPeriod();
                        IDManager.SetID(physicalSettlementPeriodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        physicalSettlementPeriodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        physicalSettlementPeriod = new PhysicalSettlementPeriod(item);
                    }
                }
            }
            
        
            XmlNodeList deliverableObligationsNodeList = xmlNode.SelectNodes("deliverableObligations");
            if (deliverableObligationsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in deliverableObligationsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        deliverableObligationsIDRef = item.Attributes["id"].Name;
                        DeliverableObligations ob = DeliverableObligations();
                        IDManager.SetID(deliverableObligationsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        deliverableObligationsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        deliverableObligations = new DeliverableObligations(item);
                    }
                }
            }
            
        
            XmlNodeList escrowNodeList = xmlNode.SelectNodes("escrow");
            if (escrowNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in escrowNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        escrowIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(escrowIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        escrowIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        escrow = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList sixtyBusinessDaySettlementCapNodeList = xmlNode.SelectNodes("sixtyBusinessDaySettlementCap");
            if (sixtyBusinessDaySettlementCapNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in sixtyBusinessDaySettlementCapNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        sixtyBusinessDaySettlementCapIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(sixtyBusinessDaySettlementCapIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        sixtyBusinessDaySettlementCapIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        sixtyBusinessDaySettlementCap = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
        }
        
    
        #region PhysicalSettlementPeriod
        private PhysicalSettlementPeriod physicalSettlementPeriod;
        public PhysicalSettlementPeriod PhysicalSettlementPeriod
        {
            get
            {
                if (this.physicalSettlementPeriod != null)
                {
                    return this.physicalSettlementPeriod; 
                }
                else if (this.physicalSettlementPeriodIDRef != null)
                {
                    physicalSettlementPeriod = IDManager.getID(physicalSettlementPeriodIDRef) as PhysicalSettlementPeriod;
                    return this.physicalSettlementPeriod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.physicalSettlementPeriod != value)
                {
                    this.physicalSettlementPeriod = value;
                }
            }
        }
        #endregion
        
        public string PhysicalSettlementPeriodIDRef { get; set; }
        #region DeliverableObligations
        private DeliverableObligations deliverableObligations;
        public DeliverableObligations DeliverableObligations
        {
            get
            {
                if (this.deliverableObligations != null)
                {
                    return this.deliverableObligations; 
                }
                else if (this.deliverableObligationsIDRef != null)
                {
                    deliverableObligations = IDManager.getID(deliverableObligationsIDRef) as DeliverableObligations;
                    return this.deliverableObligations; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.deliverableObligations != value)
                {
                    this.deliverableObligations = value;
                }
            }
        }
        #endregion
        
        public string DeliverableObligationsIDRef { get; set; }
        #region Escrow
        private XsdTypeBoolean escrow;
        public XsdTypeBoolean Escrow
        {
            get
            {
                if (this.escrow != null)
                {
                    return this.escrow; 
                }
                else if (this.escrowIDRef != null)
                {
                    escrow = IDManager.getID(escrowIDRef) as XsdTypeBoolean;
                    return this.escrow; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.escrow != value)
                {
                    this.escrow = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region SixtyBusinessDaySettlementCap
        private XsdTypeBoolean sixtyBusinessDaySettlementCap;
        public XsdTypeBoolean SixtyBusinessDaySettlementCap
        {
            get
            {
                if (this.sixtyBusinessDaySettlementCap != null)
                {
                    return this.sixtyBusinessDaySettlementCap; 
                }
                else if (this.sixtyBusinessDaySettlementCapIDRef != null)
                {
                    sixtyBusinessDaySettlementCap = IDManager.getID(sixtyBusinessDaySettlementCapIDRef) as XsdTypeBoolean;
                    return this.sixtyBusinessDaySettlementCap; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.sixtyBusinessDaySettlementCap != value)
                {
                    this.sixtyBusinessDaySettlementCap = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        
    
        
    
    }
    
}

