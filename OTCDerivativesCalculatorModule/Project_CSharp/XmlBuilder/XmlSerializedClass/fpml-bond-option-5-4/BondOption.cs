using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class BondOption : OptionBaseExtended
    {
        public BondOption(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode strikeNode = xmlNode.SelectSingleNode("strike");
            
            if (strikeNode != null)
            {
                if (strikeNode.Attributes["href"] != null || strikeNode.Attributes["id"] != null) 
                {
                    if (strikeNode.Attributes["id"] != null) 
                    {
                        strikeIDRef_ = strikeNode.Attributes["id"].Value;
                        BondOptionStrike ob = new BondOptionStrike(strikeNode);
                        IDManager.SetID(strikeIDRef_, ob);
                    }
                    else if (strikeNode.Attributes["href"] != null)
                    {
                        strikeIDRef_ = strikeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        strike_ = new BondOptionStrike(strikeNode);
                    }
                }
                else
                {
                    strike_ = new BondOptionStrike(strikeNode);
                }
            }
            
        
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
            
        
            XmlNode convertibleBondNode = xmlNode.SelectSingleNode("convertibleBond");
            
            if (convertibleBondNode != null)
            {
                if (convertibleBondNode.Attributes["href"] != null || convertibleBondNode.Attributes["id"] != null) 
                {
                    if (convertibleBondNode.Attributes["id"] != null) 
                    {
                        convertibleBondIDRef_ = convertibleBondNode.Attributes["id"].Value;
                        ConvertibleBond ob = new ConvertibleBond(convertibleBondNode);
                        IDManager.SetID(convertibleBondIDRef_, ob);
                    }
                    else if (convertibleBondNode.Attributes["href"] != null)
                    {
                        convertibleBondIDRef_ = convertibleBondNode.Attributes["href"].Value;
                    }
                    else
                    {
                        convertibleBond_ = new ConvertibleBond(convertibleBondNode);
                    }
                }
                else
                {
                    convertibleBond_ = new ConvertibleBond(convertibleBondNode);
                }
            }
            
        
        }
        
    
        #region Strike_
        private BondOptionStrike strike_;
        public BondOptionStrike Strike_
        {
            get
            {
                if (this.strike_ != null)
                {
                    return this.strike_; 
                }
                else if (this.strikeIDRef_ != null)
                {
                    strike_ = IDManager.getID(strikeIDRef_) as BondOptionStrike;
                    return this.strike_; 
                }
                else
                {
                      return this.strike_; 
                }
            }
            set
            {
                if (this.strike_ != value)
                {
                    this.strike_ = value;
                }
            }
        }
        #endregion
        
        public string strikeIDRef_ { get; set; }
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
        #region ConvertibleBond_
        private ConvertibleBond convertibleBond_;
        public ConvertibleBond ConvertibleBond_
        {
            get
            {
                if (this.convertibleBond_ != null)
                {
                    return this.convertibleBond_; 
                }
                else if (this.convertibleBondIDRef_ != null)
                {
                    convertibleBond_ = IDManager.getID(convertibleBondIDRef_) as ConvertibleBond;
                    return this.convertibleBond_; 
                }
                else
                {
                      return this.convertibleBond_; 
                }
            }
            set
            {
                if (this.convertibleBond_ != value)
                {
                    this.convertibleBond_ = value;
                }
            }
        }
        #endregion
        
        public string convertibleBondIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

