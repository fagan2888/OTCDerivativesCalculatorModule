using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class TermPoint : ISerialized
    {
        public TermPoint(XmlNode xmlNode)
        {
            XmlNode termNode = xmlNode.SelectSingleNode("term");
            
            if (termNode != null)
            {
                if (termNode.Attributes["href"] != null || termNode.Attributes["id"] != null) 
                {
                    if (termNode.Attributes["id"] != null) 
                    {
                        termIDRef_ = termNode.Attributes["id"].Value;
                        TimeDimension ob = new TimeDimension(termNode);
                        IDManager.SetID(termIDRef_, ob);
                    }
                    else if (termNode.Attributes["href"] != null)
                    {
                        termIDRef_ = termNode.Attributes["href"].Value;
                    }
                    else
                    {
                        term_ = new TimeDimension(termNode);
                    }
                }
                else
                {
                    term_ = new TimeDimension(termNode);
                }
            }
            
        
            XmlNode bidNode = xmlNode.SelectSingleNode("bid");
            
            if (bidNode != null)
            {
                if (bidNode.Attributes["href"] != null || bidNode.Attributes["id"] != null) 
                {
                    if (bidNode.Attributes["id"] != null) 
                    {
                        bidIDRef_ = bidNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(bidNode);
                        IDManager.SetID(bidIDRef_, ob);
                    }
                    else if (bidNode.Attributes["href"] != null)
                    {
                        bidIDRef_ = bidNode.Attributes["href"].Value;
                    }
                    else
                    {
                        bid_ = new XsdTypeDecimal(bidNode);
                    }
                }
                else
                {
                    bid_ = new XsdTypeDecimal(bidNode);
                }
            }
            
        
            XmlNode midNode = xmlNode.SelectSingleNode("mid");
            
            if (midNode != null)
            {
                if (midNode.Attributes["href"] != null || midNode.Attributes["id"] != null) 
                {
                    if (midNode.Attributes["id"] != null) 
                    {
                        midIDRef_ = midNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(midNode);
                        IDManager.SetID(midIDRef_, ob);
                    }
                    else if (midNode.Attributes["href"] != null)
                    {
                        midIDRef_ = midNode.Attributes["href"].Value;
                    }
                    else
                    {
                        mid_ = new XsdTypeDecimal(midNode);
                    }
                }
                else
                {
                    mid_ = new XsdTypeDecimal(midNode);
                }
            }
            
        
            XmlNode askNode = xmlNode.SelectSingleNode("ask");
            
            if (askNode != null)
            {
                if (askNode.Attributes["href"] != null || askNode.Attributes["id"] != null) 
                {
                    if (askNode.Attributes["id"] != null) 
                    {
                        askIDRef_ = askNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(askNode);
                        IDManager.SetID(askIDRef_, ob);
                    }
                    else if (askNode.Attributes["href"] != null)
                    {
                        askIDRef_ = askNode.Attributes["href"].Value;
                    }
                    else
                    {
                        ask_ = new XsdTypeDecimal(askNode);
                    }
                }
                else
                {
                    ask_ = new XsdTypeDecimal(askNode);
                }
            }
            
        
            XmlNode spreadValueNode = xmlNode.SelectSingleNode("spreadValue");
            
            if (spreadValueNode != null)
            {
                if (spreadValueNode.Attributes["href"] != null || spreadValueNode.Attributes["id"] != null) 
                {
                    if (spreadValueNode.Attributes["id"] != null) 
                    {
                        spreadValueIDRef_ = spreadValueNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(spreadValueNode);
                        IDManager.SetID(spreadValueIDRef_, ob);
                    }
                    else if (spreadValueNode.Attributes["href"] != null)
                    {
                        spreadValueIDRef_ = spreadValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        spreadValue_ = new XsdTypeDecimal(spreadValueNode);
                    }
                }
                else
                {
                    spreadValue_ = new XsdTypeDecimal(spreadValueNode);
                }
            }
            
        
            XmlNode definitionNode = xmlNode.SelectSingleNode("definition");
            
            if (definitionNode != null)
            {
                if (definitionNode.Attributes["href"] != null || definitionNode.Attributes["id"] != null) 
                {
                    if (definitionNode.Attributes["id"] != null) 
                    {
                        definitionIDRef_ = definitionNode.Attributes["id"].Value;
                        AssetReference ob = new AssetReference(definitionNode);
                        IDManager.SetID(definitionIDRef_, ob);
                    }
                    else if (definitionNode.Attributes["href"] != null)
                    {
                        definitionIDRef_ = definitionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        definition_ = new AssetReference(definitionNode);
                    }
                }
                else
                {
                    definition_ = new AssetReference(definitionNode);
                }
            }
            
        
        }
        
    
        #region Term_
        private TimeDimension term_;
        public TimeDimension Term_
        {
            get
            {
                if (this.term_ != null)
                {
                    return this.term_; 
                }
                else if (this.termIDRef_ != null)
                {
                    term_ = IDManager.getID(termIDRef_) as TimeDimension;
                    return this.term_; 
                }
                else
                {
                      return this.term_; 
                }
            }
            set
            {
                if (this.term_ != value)
                {
                    this.term_ = value;
                }
            }
        }
        #endregion
        
        public string termIDRef_ { get; set; }
        #region Bid_
        private XsdTypeDecimal bid_;
        public XsdTypeDecimal Bid_
        {
            get
            {
                if (this.bid_ != null)
                {
                    return this.bid_; 
                }
                else if (this.bidIDRef_ != null)
                {
                    bid_ = IDManager.getID(bidIDRef_) as XsdTypeDecimal;
                    return this.bid_; 
                }
                else
                {
                      return this.bid_; 
                }
            }
            set
            {
                if (this.bid_ != value)
                {
                    this.bid_ = value;
                }
            }
        }
        #endregion
        
        public string bidIDRef_ { get; set; }
        #region Mid_
        private XsdTypeDecimal mid_;
        public XsdTypeDecimal Mid_
        {
            get
            {
                if (this.mid_ != null)
                {
                    return this.mid_; 
                }
                else if (this.midIDRef_ != null)
                {
                    mid_ = IDManager.getID(midIDRef_) as XsdTypeDecimal;
                    return this.mid_; 
                }
                else
                {
                      return this.mid_; 
                }
            }
            set
            {
                if (this.mid_ != value)
                {
                    this.mid_ = value;
                }
            }
        }
        #endregion
        
        public string midIDRef_ { get; set; }
        #region Ask_
        private XsdTypeDecimal ask_;
        public XsdTypeDecimal Ask_
        {
            get
            {
                if (this.ask_ != null)
                {
                    return this.ask_; 
                }
                else if (this.askIDRef_ != null)
                {
                    ask_ = IDManager.getID(askIDRef_) as XsdTypeDecimal;
                    return this.ask_; 
                }
                else
                {
                      return this.ask_; 
                }
            }
            set
            {
                if (this.ask_ != value)
                {
                    this.ask_ = value;
                }
            }
        }
        #endregion
        
        public string askIDRef_ { get; set; }
        #region SpreadValue_
        private XsdTypeDecimal spreadValue_;
        public XsdTypeDecimal SpreadValue_
        {
            get
            {
                if (this.spreadValue_ != null)
                {
                    return this.spreadValue_; 
                }
                else if (this.spreadValueIDRef_ != null)
                {
                    spreadValue_ = IDManager.getID(spreadValueIDRef_) as XsdTypeDecimal;
                    return this.spreadValue_; 
                }
                else
                {
                      return this.spreadValue_; 
                }
            }
            set
            {
                if (this.spreadValue_ != value)
                {
                    this.spreadValue_ = value;
                }
            }
        }
        #endregion
        
        public string spreadValueIDRef_ { get; set; }
        #region Definition_
        private AssetReference definition_;
        public AssetReference Definition_
        {
            get
            {
                if (this.definition_ != null)
                {
                    return this.definition_; 
                }
                else if (this.definitionIDRef_ != null)
                {
                    definition_ = IDManager.getID(definitionIDRef_) as AssetReference;
                    return this.definition_; 
                }
                else
                {
                      return this.definition_; 
                }
            }
            set
            {
                if (this.definition_ != value)
                {
                    this.definition_ = value;
                }
            }
        }
        #endregion
        
        public string definitionIDRef_ { get; set; }
        
    
        
    
    }
    
}

