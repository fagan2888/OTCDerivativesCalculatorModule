using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class MutualFund
    {
        public MutualFund(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList openEndedFundNodeList = xmlNode.SelectNodes("openEndedFund");
            if (openEndedFundNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in openEndedFundNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        openEndedFundIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(openEndedFundIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        openEndedFundIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        openEndedFund = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList fundManagerNodeList = xmlNode.SelectNodes("fundManager");
            if (fundManagerNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fundManagerNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fundManagerIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(fundManagerIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fundManagerIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fundManager = new XsdTypeString(item);
                    }
                }
            }
            
        
        }
        
    
        #region OpenEndedFund
        private XsdTypeBoolean openEndedFund;
        public XsdTypeBoolean OpenEndedFund
        {
            get
            {
                if (this.openEndedFund != null)
                {
                    return this.openEndedFund; 
                }
                else if (this.openEndedFundIDRef != null)
                {
                    openEndedFund = IDManager.getID(openEndedFundIDRef) as XsdTypeBoolean;
                    return this.openEndedFund; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.openEndedFund != value)
                {
                    this.openEndedFund = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region FundManager
        private XsdTypeString fundManager;
        public XsdTypeString FundManager
        {
            get
            {
                if (this.fundManager != null)
                {
                    return this.fundManager; 
                }
                else if (this.fundManagerIDRef != null)
                {
                    fundManager = IDManager.getID(fundManagerIDRef) as XsdTypeString;
                    return this.fundManager; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fundManager != value)
                {
                    this.fundManager = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        
    
        
    
    }
    
}

