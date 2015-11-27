using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class BondOption
    {
        public BondOption(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList strikeNodeList = xmlNode.SelectNodes("strike");
            if (strikeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in strikeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        strikeIDRef = item.Attributes["id"].Name;
                        BondOptionStrike ob = BondOptionStrike();
                        IDManager.SetID(strikeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        strikeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        strike = new BondOptionStrike(item);
                    }
                }
            }
            
        
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
            
        
            XmlNodeList convertibleBondNodeList = xmlNode.SelectNodes("convertibleBond");
            if (convertibleBondNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in convertibleBondNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        convertibleBondIDRef = item.Attributes["id"].Name;
                        ConvertibleBond ob = ConvertibleBond();
                        IDManager.SetID(convertibleBondIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        convertibleBondIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        convertibleBond = new ConvertibleBond(item);
                    }
                }
            }
            
        
        }
        
    
        #region Strike
        private BondOptionStrike strike;
        public BondOptionStrike Strike
        {
            get
            {
                if (this.strike != null)
                {
                    return this.strike; 
                }
                else if (this.strikeIDRef != null)
                {
                    strike = IDManager.getID(strikeIDRef) as BondOptionStrike;
                    return this.strike; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.strike != value)
                {
                    this.strike = value;
                }
            }
        }
        #endregion
        
        public string BondOptionStrikeIDRef { get; set; }
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
        #region ConvertibleBond
        private ConvertibleBond convertibleBond;
        public ConvertibleBond ConvertibleBond
        {
            get
            {
                if (this.convertibleBond != null)
                {
                    return this.convertibleBond; 
                }
                else if (this.convertibleBondIDRef != null)
                {
                    convertibleBond = IDManager.getID(convertibleBondIDRef) as ConvertibleBond;
                    return this.convertibleBond; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.convertibleBond != value)
                {
                    this.convertibleBond = value;
                }
            }
        }
        #endregion
        
        public string ConvertibleBondIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

