using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class MakeWholeProvisions
    {
        public MakeWholeProvisions(XmlNode xmlNode)
        {
            XmlNodeList makeWholeDateNodeList = xmlNode.SelectNodes("makeWholeDate");
            if (makeWholeDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in makeWholeDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        makeWholeDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(makeWholeDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        makeWholeDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        makeWholeDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList recallSpreadNodeList = xmlNode.SelectNodes("recallSpread");
            if (recallSpreadNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in recallSpreadNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        recallSpreadIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(recallSpreadIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        recallSpreadIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        recallSpread = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
        }
        
    
        #region MakeWholeDate
        private XsdTypeDate makeWholeDate;
        public XsdTypeDate MakeWholeDate
        {
            get
            {
                if (this.makeWholeDate != null)
                {
                    return this.makeWholeDate; 
                }
                else if (this.makeWholeDateIDRef != null)
                {
                    makeWholeDate = IDManager.getID(makeWholeDateIDRef) as XsdTypeDate;
                    return this.makeWholeDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.makeWholeDate != value)
                {
                    this.makeWholeDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region RecallSpread
        private XsdTypeDecimal recallSpread;
        public XsdTypeDecimal RecallSpread
        {
            get
            {
                if (this.recallSpread != null)
                {
                    return this.recallSpread; 
                }
                else if (this.recallSpreadIDRef != null)
                {
                    recallSpread = IDManager.getID(recallSpreadIDRef) as XsdTypeDecimal;
                    return this.recallSpread; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.recallSpread != value)
                {
                    this.recallSpread = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        
    
        
    
    }
    
}

