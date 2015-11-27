using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PhysicalSettlementTerms : SettlementTerms
    {
        public PhysicalSettlementTerms(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode physicalSettlementPeriodNode = xmlNode.SelectSingleNode("physicalSettlementPeriod");
            
            if (physicalSettlementPeriodNode != null)
            {
                if (physicalSettlementPeriodNode.Attributes["href"] != null || physicalSettlementPeriodNode.Attributes["id"] != null) 
                {
                    if (physicalSettlementPeriodNode.Attributes["id"] != null) 
                    {
                        physicalSettlementPeriodIDRef_ = physicalSettlementPeriodNode.Attributes["id"].Value;
                        PhysicalSettlementPeriod ob = new PhysicalSettlementPeriod(physicalSettlementPeriodNode);
                        IDManager.SetID(physicalSettlementPeriodIDRef_, ob);
                    }
                    else if (physicalSettlementPeriodNode.Attributes["href"] != null)
                    {
                        physicalSettlementPeriodIDRef_ = physicalSettlementPeriodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        physicalSettlementPeriod_ = new PhysicalSettlementPeriod(physicalSettlementPeriodNode);
                    }
                }
                else
                {
                    physicalSettlementPeriod_ = new PhysicalSettlementPeriod(physicalSettlementPeriodNode);
                }
            }
            
        
            XmlNode deliverableObligationsNode = xmlNode.SelectSingleNode("deliverableObligations");
            
            if (deliverableObligationsNode != null)
            {
                if (deliverableObligationsNode.Attributes["href"] != null || deliverableObligationsNode.Attributes["id"] != null) 
                {
                    if (deliverableObligationsNode.Attributes["id"] != null) 
                    {
                        deliverableObligationsIDRef_ = deliverableObligationsNode.Attributes["id"].Value;
                        DeliverableObligations ob = new DeliverableObligations(deliverableObligationsNode);
                        IDManager.SetID(deliverableObligationsIDRef_, ob);
                    }
                    else if (deliverableObligationsNode.Attributes["href"] != null)
                    {
                        deliverableObligationsIDRef_ = deliverableObligationsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        deliverableObligations_ = new DeliverableObligations(deliverableObligationsNode);
                    }
                }
                else
                {
                    deliverableObligations_ = new DeliverableObligations(deliverableObligationsNode);
                }
            }
            
        
            XmlNode escrowNode = xmlNode.SelectSingleNode("escrow");
            
            if (escrowNode != null)
            {
                if (escrowNode.Attributes["href"] != null || escrowNode.Attributes["id"] != null) 
                {
                    if (escrowNode.Attributes["id"] != null) 
                    {
                        escrowIDRef_ = escrowNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(escrowNode);
                        IDManager.SetID(escrowIDRef_, ob);
                    }
                    else if (escrowNode.Attributes["href"] != null)
                    {
                        escrowIDRef_ = escrowNode.Attributes["href"].Value;
                    }
                    else
                    {
                        escrow_ = new XsdTypeBoolean(escrowNode);
                    }
                }
                else
                {
                    escrow_ = new XsdTypeBoolean(escrowNode);
                }
            }
            
        
            XmlNode sixtyBusinessDaySettlementCapNode = xmlNode.SelectSingleNode("sixtyBusinessDaySettlementCap");
            
            if (sixtyBusinessDaySettlementCapNode != null)
            {
                if (sixtyBusinessDaySettlementCapNode.Attributes["href"] != null || sixtyBusinessDaySettlementCapNode.Attributes["id"] != null) 
                {
                    if (sixtyBusinessDaySettlementCapNode.Attributes["id"] != null) 
                    {
                        sixtyBusinessDaySettlementCapIDRef_ = sixtyBusinessDaySettlementCapNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(sixtyBusinessDaySettlementCapNode);
                        IDManager.SetID(sixtyBusinessDaySettlementCapIDRef_, ob);
                    }
                    else if (sixtyBusinessDaySettlementCapNode.Attributes["href"] != null)
                    {
                        sixtyBusinessDaySettlementCapIDRef_ = sixtyBusinessDaySettlementCapNode.Attributes["href"].Value;
                    }
                    else
                    {
                        sixtyBusinessDaySettlementCap_ = new XsdTypeBoolean(sixtyBusinessDaySettlementCapNode);
                    }
                }
                else
                {
                    sixtyBusinessDaySettlementCap_ = new XsdTypeBoolean(sixtyBusinessDaySettlementCapNode);
                }
            }
            
        
        }
        
    
        #region PhysicalSettlementPeriod_
        private PhysicalSettlementPeriod physicalSettlementPeriod_;
        public PhysicalSettlementPeriod PhysicalSettlementPeriod_
        {
            get
            {
                if (this.physicalSettlementPeriod_ != null)
                {
                    return this.physicalSettlementPeriod_; 
                }
                else if (this.physicalSettlementPeriodIDRef_ != null)
                {
                    physicalSettlementPeriod_ = IDManager.getID(physicalSettlementPeriodIDRef_) as PhysicalSettlementPeriod;
                    return this.physicalSettlementPeriod_; 
                }
                else
                {
                      return this.physicalSettlementPeriod_; 
                }
            }
            set
            {
                if (this.physicalSettlementPeriod_ != value)
                {
                    this.physicalSettlementPeriod_ = value;
                }
            }
        }
        #endregion
        
        public string physicalSettlementPeriodIDRef_ { get; set; }
        #region DeliverableObligations_
        private DeliverableObligations deliverableObligations_;
        public DeliverableObligations DeliverableObligations_
        {
            get
            {
                if (this.deliverableObligations_ != null)
                {
                    return this.deliverableObligations_; 
                }
                else if (this.deliverableObligationsIDRef_ != null)
                {
                    deliverableObligations_ = IDManager.getID(deliverableObligationsIDRef_) as DeliverableObligations;
                    return this.deliverableObligations_; 
                }
                else
                {
                      return this.deliverableObligations_; 
                }
            }
            set
            {
                if (this.deliverableObligations_ != value)
                {
                    this.deliverableObligations_ = value;
                }
            }
        }
        #endregion
        
        public string deliverableObligationsIDRef_ { get; set; }
        #region Escrow_
        private XsdTypeBoolean escrow_;
        public XsdTypeBoolean Escrow_
        {
            get
            {
                if (this.escrow_ != null)
                {
                    return this.escrow_; 
                }
                else if (this.escrowIDRef_ != null)
                {
                    escrow_ = IDManager.getID(escrowIDRef_) as XsdTypeBoolean;
                    return this.escrow_; 
                }
                else
                {
                      return this.escrow_; 
                }
            }
            set
            {
                if (this.escrow_ != value)
                {
                    this.escrow_ = value;
                }
            }
        }
        #endregion
        
        public string escrowIDRef_ { get; set; }
        #region SixtyBusinessDaySettlementCap_
        private XsdTypeBoolean sixtyBusinessDaySettlementCap_;
        public XsdTypeBoolean SixtyBusinessDaySettlementCap_
        {
            get
            {
                if (this.sixtyBusinessDaySettlementCap_ != null)
                {
                    return this.sixtyBusinessDaySettlementCap_; 
                }
                else if (this.sixtyBusinessDaySettlementCapIDRef_ != null)
                {
                    sixtyBusinessDaySettlementCap_ = IDManager.getID(sixtyBusinessDaySettlementCapIDRef_) as XsdTypeBoolean;
                    return this.sixtyBusinessDaySettlementCap_; 
                }
                else
                {
                      return this.sixtyBusinessDaySettlementCap_; 
                }
            }
            set
            {
                if (this.sixtyBusinessDaySettlementCap_ != value)
                {
                    this.sixtyBusinessDaySettlementCap_ = value;
                }
            }
        }
        #endregion
        
        public string sixtyBusinessDaySettlementCapIDRef_ { get; set; }
        
    
        
    
    }
    
}

