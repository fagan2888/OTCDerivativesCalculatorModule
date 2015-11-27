using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class MakeWholeProvisions : ISerialized
    {
        public MakeWholeProvisions(XmlNode xmlNode)
        {
            XmlNode makeWholeDateNode = xmlNode.SelectSingleNode("makeWholeDate");
            
            if (makeWholeDateNode != null)
            {
                if (makeWholeDateNode.Attributes["href"] != null || makeWholeDateNode.Attributes["id"] != null) 
                {
                    if (makeWholeDateNode.Attributes["id"] != null) 
                    {
                        makeWholeDateIDRef_ = makeWholeDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(makeWholeDateNode);
                        IDManager.SetID(makeWholeDateIDRef_, ob);
                    }
                    else if (makeWholeDateNode.Attributes["href"] != null)
                    {
                        makeWholeDateIDRef_ = makeWholeDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        makeWholeDate_ = new XsdTypeDate(makeWholeDateNode);
                    }
                }
                else
                {
                    makeWholeDate_ = new XsdTypeDate(makeWholeDateNode);
                }
            }
            
        
            XmlNode recallSpreadNode = xmlNode.SelectSingleNode("recallSpread");
            
            if (recallSpreadNode != null)
            {
                if (recallSpreadNode.Attributes["href"] != null || recallSpreadNode.Attributes["id"] != null) 
                {
                    if (recallSpreadNode.Attributes["id"] != null) 
                    {
                        recallSpreadIDRef_ = recallSpreadNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(recallSpreadNode);
                        IDManager.SetID(recallSpreadIDRef_, ob);
                    }
                    else if (recallSpreadNode.Attributes["href"] != null)
                    {
                        recallSpreadIDRef_ = recallSpreadNode.Attributes["href"].Value;
                    }
                    else
                    {
                        recallSpread_ = new XsdTypeDecimal(recallSpreadNode);
                    }
                }
                else
                {
                    recallSpread_ = new XsdTypeDecimal(recallSpreadNode);
                }
            }
            
        
        }
        
    
        #region MakeWholeDate_
        private XsdTypeDate makeWholeDate_;
        public XsdTypeDate MakeWholeDate_
        {
            get
            {
                if (this.makeWholeDate_ != null)
                {
                    return this.makeWholeDate_; 
                }
                else if (this.makeWholeDateIDRef_ != null)
                {
                    makeWholeDate_ = IDManager.getID(makeWholeDateIDRef_) as XsdTypeDate;
                    return this.makeWholeDate_; 
                }
                else
                {
                      return this.makeWholeDate_; 
                }
            }
            set
            {
                if (this.makeWholeDate_ != value)
                {
                    this.makeWholeDate_ = value;
                }
            }
        }
        #endregion
        
        public string makeWholeDateIDRef_ { get; set; }
        #region RecallSpread_
        private XsdTypeDecimal recallSpread_;
        public XsdTypeDecimal RecallSpread_
        {
            get
            {
                if (this.recallSpread_ != null)
                {
                    return this.recallSpread_; 
                }
                else if (this.recallSpreadIDRef_ != null)
                {
                    recallSpread_ = IDManager.getID(recallSpreadIDRef_) as XsdTypeDecimal;
                    return this.recallSpread_; 
                }
                else
                {
                      return this.recallSpread_; 
                }
            }
            set
            {
                if (this.recallSpread_ != value)
                {
                    this.recallSpread_ = value;
                }
            }
        }
        #endregion
        
        public string recallSpreadIDRef_ { get; set; }
        
    
        
    
    }
    
}

