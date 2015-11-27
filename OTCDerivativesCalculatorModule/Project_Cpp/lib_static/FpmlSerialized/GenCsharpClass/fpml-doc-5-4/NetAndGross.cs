using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class NetAndGross
    {
        public NetAndGross(XmlNode xmlNode)
        {
            XmlNodeList netNodeList = xmlNode.SelectNodes("net");
            if (netNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in netNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        netIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(netIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        netIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        net = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList grossNodeList = xmlNode.SelectNodes("gross");
            if (grossNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in grossNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        grossIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(grossIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        grossIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        gross = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
        }
        
    
        #region Net
        private XsdTypeDecimal net;
        public XsdTypeDecimal Net
        {
            get
            {
                if (this.net != null)
                {
                    return this.net; 
                }
                else if (this.netIDRef != null)
                {
                    net = IDManager.getID(netIDRef) as XsdTypeDecimal;
                    return this.net; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.net != value)
                {
                    this.net = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region Gross
        private XsdTypeDecimal gross;
        public XsdTypeDecimal Gross
        {
            get
            {
                if (this.gross != null)
                {
                    return this.gross; 
                }
                else if (this.grossIDRef != null)
                {
                    gross = IDManager.getID(grossIDRef) as XsdTypeDecimal;
                    return this.gross; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.gross != value)
                {
                    this.gross = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

