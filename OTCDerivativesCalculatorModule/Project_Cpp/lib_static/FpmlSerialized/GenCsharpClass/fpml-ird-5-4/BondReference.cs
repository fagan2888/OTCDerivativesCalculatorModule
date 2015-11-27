using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class BondReference
    {
        public BondReference(XmlNode xmlNode)
        {
            XmlNodeList bondNodeList = xmlNode.SelectNodes("bond");
            if (bondNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in bondNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        bondIDRef = item.Attributes["id"].Name;
                        Bond ob = Bond();
                        IDManager.SetID(bondIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        bondIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        bond = new Bond(item);
                    }
                }
            }
            
        
            XmlNodeList conditionPrecedentBondNodeList = xmlNode.SelectNodes("conditionPrecedentBond");
            if (conditionPrecedentBondNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in conditionPrecedentBondNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        conditionPrecedentBondIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(conditionPrecedentBondIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        conditionPrecedentBondIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        conditionPrecedentBond = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList discrepancyClauseNodeList = xmlNode.SelectNodes("discrepancyClause");
            if (discrepancyClauseNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in discrepancyClauseNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        discrepancyClauseIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(discrepancyClauseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        discrepancyClauseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        discrepancyClause = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
        }
        
    
        #region Bond
        private Bond bond;
        public Bond Bond
        {
            get
            {
                if (this.bond != null)
                {
                    return this.bond; 
                }
                else if (this.bondIDRef != null)
                {
                    bond = IDManager.getID(bondIDRef) as Bond;
                    return this.bond; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.bond != value)
                {
                    this.bond = value;
                }
            }
        }
        #endregion
        
        public string BondIDRef { get; set; }
        #region ConditionPrecedentBond
        private XsdTypeBoolean conditionPrecedentBond;
        public XsdTypeBoolean ConditionPrecedentBond
        {
            get
            {
                if (this.conditionPrecedentBond != null)
                {
                    return this.conditionPrecedentBond; 
                }
                else if (this.conditionPrecedentBondIDRef != null)
                {
                    conditionPrecedentBond = IDManager.getID(conditionPrecedentBondIDRef) as XsdTypeBoolean;
                    return this.conditionPrecedentBond; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.conditionPrecedentBond != value)
                {
                    this.conditionPrecedentBond = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region DiscrepancyClause
        private XsdTypeBoolean discrepancyClause;
        public XsdTypeBoolean DiscrepancyClause
        {
            get
            {
                if (this.discrepancyClause != null)
                {
                    return this.discrepancyClause; 
                }
                else if (this.discrepancyClauseIDRef != null)
                {
                    discrepancyClause = IDManager.getID(discrepancyClauseIDRef) as XsdTypeBoolean;
                    return this.discrepancyClause; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.discrepancyClause != value)
                {
                    this.discrepancyClause = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        
    
        
    
    }
    
}

