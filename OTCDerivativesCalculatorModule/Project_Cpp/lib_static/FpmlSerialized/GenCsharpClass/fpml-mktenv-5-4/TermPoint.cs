using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class TermPoint
    {
        public TermPoint(XmlNode xmlNode)
        {
            XmlNodeList termNodeList = xmlNode.SelectNodes("term");
            if (termNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in termNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        termIDRef = item.Attributes["id"].Name;
                        TimeDimension ob = TimeDimension();
                        IDManager.SetID(termIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        termIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        term = new TimeDimension(item);
                    }
                }
            }
            
        
            XmlNodeList bidNodeList = xmlNode.SelectNodes("bid");
            if (bidNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in bidNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        bidIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(bidIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        bidIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        bid = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList midNodeList = xmlNode.SelectNodes("mid");
            if (midNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in midNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        midIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(midIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        midIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        mid = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList askNodeList = xmlNode.SelectNodes("ask");
            if (askNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in askNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        askIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(askIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        askIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        ask = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList spreadValueNodeList = xmlNode.SelectNodes("spreadValue");
            if (spreadValueNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in spreadValueNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        spreadValueIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(spreadValueIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        spreadValueIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        spreadValue = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList definitionNodeList = xmlNode.SelectNodes("definition");
            if (definitionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in definitionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        definitionIDRef = item.Attributes["id"].Name;
                        AssetReference ob = AssetReference();
                        IDManager.SetID(definitionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        definitionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        definition = new AssetReference(item);
                    }
                }
            }
            
        
        }
        
    
        #region Term
        private TimeDimension term;
        public TimeDimension Term
        {
            get
            {
                if (this.term != null)
                {
                    return this.term; 
                }
                else if (this.termIDRef != null)
                {
                    term = IDManager.getID(termIDRef) as TimeDimension;
                    return this.term; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.term != value)
                {
                    this.term = value;
                }
            }
        }
        #endregion
        
        public string TimeDimensionIDRef { get; set; }
        #region Bid
        private XsdTypeDecimal bid;
        public XsdTypeDecimal Bid
        {
            get
            {
                if (this.bid != null)
                {
                    return this.bid; 
                }
                else if (this.bidIDRef != null)
                {
                    bid = IDManager.getID(bidIDRef) as XsdTypeDecimal;
                    return this.bid; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.bid != value)
                {
                    this.bid = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region Mid
        private XsdTypeDecimal mid;
        public XsdTypeDecimal Mid
        {
            get
            {
                if (this.mid != null)
                {
                    return this.mid; 
                }
                else if (this.midIDRef != null)
                {
                    mid = IDManager.getID(midIDRef) as XsdTypeDecimal;
                    return this.mid; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.mid != value)
                {
                    this.mid = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region Ask
        private XsdTypeDecimal ask;
        public XsdTypeDecimal Ask
        {
            get
            {
                if (this.ask != null)
                {
                    return this.ask; 
                }
                else if (this.askIDRef != null)
                {
                    ask = IDManager.getID(askIDRef) as XsdTypeDecimal;
                    return this.ask; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.ask != value)
                {
                    this.ask = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region SpreadValue
        private XsdTypeDecimal spreadValue;
        public XsdTypeDecimal SpreadValue
        {
            get
            {
                if (this.spreadValue != null)
                {
                    return this.spreadValue; 
                }
                else if (this.spreadValueIDRef != null)
                {
                    spreadValue = IDManager.getID(spreadValueIDRef) as XsdTypeDecimal;
                    return this.spreadValue; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.spreadValue != value)
                {
                    this.spreadValue = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region Definition
        private AssetReference definition;
        public AssetReference Definition
        {
            get
            {
                if (this.definition != null)
                {
                    return this.definition; 
                }
                else if (this.definitionIDRef != null)
                {
                    definition = IDManager.getID(definitionIDRef) as AssetReference;
                    return this.definition; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.definition != value)
                {
                    this.definition = value;
                }
            }
        }
        #endregion
        
        public string AssetReferenceIDRef { get; set; }
        
    
        
    
    }
    
}

