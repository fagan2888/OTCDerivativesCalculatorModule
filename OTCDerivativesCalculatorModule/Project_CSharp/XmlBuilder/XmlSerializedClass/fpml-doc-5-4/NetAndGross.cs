using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class NetAndGross : ISerialized
    {
        public NetAndGross(XmlNode xmlNode)
        {
            XmlNode netNode = xmlNode.SelectSingleNode("net");
            
            if (netNode != null)
            {
                if (netNode.Attributes["href"] != null || netNode.Attributes["id"] != null) 
                {
                    if (netNode.Attributes["id"] != null) 
                    {
                        netIDRef_ = netNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(netNode);
                        IDManager.SetID(netIDRef_, ob);
                    }
                    else if (netNode.Attributes["href"] != null)
                    {
                        netIDRef_ = netNode.Attributes["href"].Value;
                    }
                    else
                    {
                        net_ = new XsdTypeDecimal(netNode);
                    }
                }
                else
                {
                    net_ = new XsdTypeDecimal(netNode);
                }
            }
            
        
            XmlNode grossNode = xmlNode.SelectSingleNode("gross");
            
            if (grossNode != null)
            {
                if (grossNode.Attributes["href"] != null || grossNode.Attributes["id"] != null) 
                {
                    if (grossNode.Attributes["id"] != null) 
                    {
                        grossIDRef_ = grossNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(grossNode);
                        IDManager.SetID(grossIDRef_, ob);
                    }
                    else if (grossNode.Attributes["href"] != null)
                    {
                        grossIDRef_ = grossNode.Attributes["href"].Value;
                    }
                    else
                    {
                        gross_ = new XsdTypeDecimal(grossNode);
                    }
                }
                else
                {
                    gross_ = new XsdTypeDecimal(grossNode);
                }
            }
            
        
        }
        
    
        #region Net_
        private XsdTypeDecimal net_;
        public XsdTypeDecimal Net_
        {
            get
            {
                if (this.net_ != null)
                {
                    return this.net_; 
                }
                else if (this.netIDRef_ != null)
                {
                    net_ = IDManager.getID(netIDRef_) as XsdTypeDecimal;
                    return this.net_; 
                }
                else
                {
                      return this.net_; 
                }
            }
            set
            {
                if (this.net_ != value)
                {
                    this.net_ = value;
                }
            }
        }
        #endregion
        
        public string netIDRef_ { get; set; }
        #region Gross_
        private XsdTypeDecimal gross_;
        public XsdTypeDecimal Gross_
        {
            get
            {
                if (this.gross_ != null)
                {
                    return this.gross_; 
                }
                else if (this.grossIDRef_ != null)
                {
                    gross_ = IDManager.getID(grossIDRef_) as XsdTypeDecimal;
                    return this.gross_; 
                }
                else
                {
                      return this.gross_; 
                }
            }
            set
            {
                if (this.gross_ != value)
                {
                    this.gross_ = value;
                }
            }
        }
        #endregion
        
        public string grossIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

