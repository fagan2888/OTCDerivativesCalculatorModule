using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class BondReference : ISerialized
    {
        public BondReference(XmlNode xmlNode)
        {
            XmlNode bondNode = xmlNode.SelectSingleNode("bond");
            
            if (bondNode != null)
            {
                if (bondNode.Attributes["href"] != null || bondNode.Attributes["id"] != null) 
                {
                    if (bondNode.Attributes["id"] != null) 
                    {
                        bondIDRef_ = bondNode.Attributes["id"].Value;
                        Bond ob = new Bond(bondNode);
                        IDManager.SetID(bondIDRef_, ob);
                    }
                    else if (bondNode.Attributes["href"] != null)
                    {
                        bondIDRef_ = bondNode.Attributes["href"].Value;
                    }
                    else
                    {
                        bond_ = new Bond(bondNode);
                    }
                }
                else
                {
                    bond_ = new Bond(bondNode);
                }
            }
            
        
            XmlNode conditionPrecedentBondNode = xmlNode.SelectSingleNode("conditionPrecedentBond");
            
            if (conditionPrecedentBondNode != null)
            {
                if (conditionPrecedentBondNode.Attributes["href"] != null || conditionPrecedentBondNode.Attributes["id"] != null) 
                {
                    if (conditionPrecedentBondNode.Attributes["id"] != null) 
                    {
                        conditionPrecedentBondIDRef_ = conditionPrecedentBondNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(conditionPrecedentBondNode);
                        IDManager.SetID(conditionPrecedentBondIDRef_, ob);
                    }
                    else if (conditionPrecedentBondNode.Attributes["href"] != null)
                    {
                        conditionPrecedentBondIDRef_ = conditionPrecedentBondNode.Attributes["href"].Value;
                    }
                    else
                    {
                        conditionPrecedentBond_ = new XsdTypeBoolean(conditionPrecedentBondNode);
                    }
                }
                else
                {
                    conditionPrecedentBond_ = new XsdTypeBoolean(conditionPrecedentBondNode);
                }
            }
            
        
            XmlNode discrepancyClauseNode = xmlNode.SelectSingleNode("discrepancyClause");
            
            if (discrepancyClauseNode != null)
            {
                if (discrepancyClauseNode.Attributes["href"] != null || discrepancyClauseNode.Attributes["id"] != null) 
                {
                    if (discrepancyClauseNode.Attributes["id"] != null) 
                    {
                        discrepancyClauseIDRef_ = discrepancyClauseNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(discrepancyClauseNode);
                        IDManager.SetID(discrepancyClauseIDRef_, ob);
                    }
                    else if (discrepancyClauseNode.Attributes["href"] != null)
                    {
                        discrepancyClauseIDRef_ = discrepancyClauseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        discrepancyClause_ = new XsdTypeBoolean(discrepancyClauseNode);
                    }
                }
                else
                {
                    discrepancyClause_ = new XsdTypeBoolean(discrepancyClauseNode);
                }
            }
            
        
        }
        
    
        #region Bond_
        private Bond bond_;
        public Bond Bond_
        {
            get
            {
                if (this.bond_ != null)
                {
                    return this.bond_; 
                }
                else if (this.bondIDRef_ != null)
                {
                    bond_ = IDManager.getID(bondIDRef_) as Bond;
                    return this.bond_; 
                }
                else
                {
                      return this.bond_; 
                }
            }
            set
            {
                if (this.bond_ != value)
                {
                    this.bond_ = value;
                }
            }
        }
        #endregion
        
        public string bondIDRef_ { get; set; }
        #region ConditionPrecedentBond_
        private XsdTypeBoolean conditionPrecedentBond_;
        public XsdTypeBoolean ConditionPrecedentBond_
        {
            get
            {
                if (this.conditionPrecedentBond_ != null)
                {
                    return this.conditionPrecedentBond_; 
                }
                else if (this.conditionPrecedentBondIDRef_ != null)
                {
                    conditionPrecedentBond_ = IDManager.getID(conditionPrecedentBondIDRef_) as XsdTypeBoolean;
                    return this.conditionPrecedentBond_; 
                }
                else
                {
                      return this.conditionPrecedentBond_; 
                }
            }
            set
            {
                if (this.conditionPrecedentBond_ != value)
                {
                    this.conditionPrecedentBond_ = value;
                }
            }
        }
        #endregion
        
        public string conditionPrecedentBondIDRef_ { get; set; }
        #region DiscrepancyClause_
        private XsdTypeBoolean discrepancyClause_;
        public XsdTypeBoolean DiscrepancyClause_
        {
            get
            {
                if (this.discrepancyClause_ != null)
                {
                    return this.discrepancyClause_; 
                }
                else if (this.discrepancyClauseIDRef_ != null)
                {
                    discrepancyClause_ = IDManager.getID(discrepancyClauseIDRef_) as XsdTypeBoolean;
                    return this.discrepancyClause_; 
                }
                else
                {
                      return this.discrepancyClause_; 
                }
            }
            set
            {
                if (this.discrepancyClause_ != value)
                {
                    this.discrepancyClause_ = value;
                }
            }
        }
        #endregion
        
        public string discrepancyClauseIDRef_ { get; set; }
        
    
        
    
    }
    
}

