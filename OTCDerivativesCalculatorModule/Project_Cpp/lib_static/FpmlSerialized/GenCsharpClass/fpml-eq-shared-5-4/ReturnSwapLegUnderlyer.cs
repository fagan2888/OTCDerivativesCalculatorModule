using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ReturnSwapLegUnderlyer
    {
        public ReturnSwapLegUnderlyer(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList strikeDateNodeList = xmlNode.SelectNodes("strikeDate");
            if (strikeDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in strikeDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        strikeDateIDRef = item.Attributes["id"].Name;
                        AdjustableOrRelativeDate ob = AdjustableOrRelativeDate();
                        IDManager.SetID(strikeDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        strikeDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        strikeDate = new AdjustableOrRelativeDate(item);
                    }
                }
            }
            
        
            XmlNodeList underlyerNodeList = xmlNode.SelectNodes("underlyer");
            if (underlyerNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in underlyerNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        underlyerIDRef = item.Attributes["id"].Name;
                        Underlyer ob = Underlyer();
                        IDManager.SetID(underlyerIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        underlyerIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        underlyer = new Underlyer(item);
                    }
                }
            }
            
        
        }
        
    
        #region StrikeDate
        private AdjustableOrRelativeDate strikeDate;
        public AdjustableOrRelativeDate StrikeDate
        {
            get
            {
                if (this.strikeDate != null)
                {
                    return this.strikeDate; 
                }
                else if (this.strikeDateIDRef != null)
                {
                    strikeDate = IDManager.getID(strikeDateIDRef) as AdjustableOrRelativeDate;
                    return this.strikeDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.strikeDate != value)
                {
                    this.strikeDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableOrRelativeDateIDRef { get; set; }
        #region Underlyer
        private Underlyer underlyer;
        public Underlyer Underlyer
        {
            get
            {
                if (this.underlyer != null)
                {
                    return this.underlyer; 
                }
                else if (this.underlyerIDRef != null)
                {
                    underlyer = IDManager.getID(underlyerIDRef) as Underlyer;
                    return this.underlyer; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.underlyer != value)
                {
                    this.underlyer = value;
                }
            }
        }
        #endregion
        
        public string UnderlyerIDRef { get; set; }
        
    
        
    
    }
    
}

