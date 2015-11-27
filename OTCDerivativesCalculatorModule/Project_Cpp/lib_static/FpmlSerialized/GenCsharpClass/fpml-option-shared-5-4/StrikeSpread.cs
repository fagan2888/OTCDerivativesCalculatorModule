using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class StrikeSpread
    {
        public StrikeSpread(XmlNode xmlNode)
        {
            XmlNodeList upperStrikeNodeList = xmlNode.SelectNodes("upperStrike");
            if (upperStrikeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in upperStrikeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        upperStrikeIDRef = item.Attributes["id"].Name;
                        OptionStrike ob = OptionStrike();
                        IDManager.SetID(upperStrikeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        upperStrikeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        upperStrike = new OptionStrike(item);
                    }
                }
            }
            
        
            XmlNodeList upperStrikeNumberOfOptionsNodeList = xmlNode.SelectNodes("upperStrikeNumberOfOptions");
            if (upperStrikeNumberOfOptionsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in upperStrikeNumberOfOptionsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        upperStrikeNumberOfOptionsIDRef = item.Attributes["id"].Name;
                        PositiveDecimal ob = PositiveDecimal();
                        IDManager.SetID(upperStrikeNumberOfOptionsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        upperStrikeNumberOfOptionsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        upperStrikeNumberOfOptions = new PositiveDecimal(item);
                    }
                }
            }
            
        
        }
        
    
        #region UpperStrike
        private OptionStrike upperStrike;
        public OptionStrike UpperStrike
        {
            get
            {
                if (this.upperStrike != null)
                {
                    return this.upperStrike; 
                }
                else if (this.upperStrikeIDRef != null)
                {
                    upperStrike = IDManager.getID(upperStrikeIDRef) as OptionStrike;
                    return this.upperStrike; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.upperStrike != value)
                {
                    this.upperStrike = value;
                }
            }
        }
        #endregion
        
        public string OptionStrikeIDRef { get; set; }
        #region UpperStrikeNumberOfOptions
        private PositiveDecimal upperStrikeNumberOfOptions;
        public PositiveDecimal UpperStrikeNumberOfOptions
        {
            get
            {
                if (this.upperStrikeNumberOfOptions != null)
                {
                    return this.upperStrikeNumberOfOptions; 
                }
                else if (this.upperStrikeNumberOfOptionsIDRef != null)
                {
                    upperStrikeNumberOfOptions = IDManager.getID(upperStrikeNumberOfOptionsIDRef) as PositiveDecimal;
                    return this.upperStrikeNumberOfOptions; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.upperStrikeNumberOfOptions != value)
                {
                    this.upperStrikeNumberOfOptions = value;
                }
            }
        }
        #endregion
        
        public string PositiveDecimalIDRef { get; set; }
        
    
        
    
    }
    
}

