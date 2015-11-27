using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SubEvent : ISerialized
    {
        public SubEvent(XmlNode xmlNode)
        {
            XmlNode refEventIDNode = xmlNode.SelectSingleNode("refEventID");
            
            if (refEventIDNode != null)
            {
                if (refEventIDNode.Attributes["href"] != null || refEventIDNode.Attributes["id"] != null) 
                {
                    if (refEventIDNode.Attributes["id"] != null) 
                    {
                        refEventIDIDRef_ = refEventIDNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(refEventIDNode);
                        IDManager.SetID(refEventIDIDRef_, ob);
                    }
                    else if (refEventIDNode.Attributes["href"] != null)
                    {
                        refEventIDIDRef_ = refEventIDNode.Attributes["href"].Value;
                    }
                    else
                    {
                        refEventID_ = new XsdTypeToken(refEventIDNode);
                    }
                }
                else
                {
                    refEventID_ = new XsdTypeToken(refEventIDNode);
                }
            }
            
        
            XmlNode truefalseNode = xmlNode.SelectSingleNode("truefalse");
            
            if (truefalseNode != null)
            {
                if (truefalseNode.Attributes["href"] != null || truefalseNode.Attributes["id"] != null) 
                {
                    if (truefalseNode.Attributes["id"] != null) 
                    {
                        truefalseIDRef_ = truefalseNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(truefalseNode);
                        IDManager.SetID(truefalseIDRef_, ob);
                    }
                    else if (truefalseNode.Attributes["href"] != null)
                    {
                        truefalseIDRef_ = truefalseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        truefalse_ = new XsdTypeBoolean(truefalseNode);
                    }
                }
                else
                {
                    truefalse_ = new XsdTypeBoolean(truefalseNode);
                }
            }
            
        
        }
        
    
        #region RefEventID_
        private XsdTypeToken refEventID_;
        public XsdTypeToken RefEventID_
        {
            get
            {
                if (this.refEventID_ != null)
                {
                    return this.refEventID_; 
                }
                else if (this.refEventIDIDRef_ != null)
                {
                    refEventID_ = IDManager.getID(refEventIDIDRef_) as XsdTypeToken;
                    return this.refEventID_; 
                }
                else
                {
                      return this.refEventID_; 
                }
            }
            set
            {
                if (this.refEventID_ != value)
                {
                    this.refEventID_ = value;
                }
            }
        }
        #endregion
        
        public string refEventIDIDRef_ { get; set; }
        #region Truefalse_
        private XsdTypeBoolean truefalse_;
        public XsdTypeBoolean Truefalse_
        {
            get
            {
                if (this.truefalse_ != null)
                {
                    return this.truefalse_; 
                }
                else if (this.truefalseIDRef_ != null)
                {
                    truefalse_ = IDManager.getID(truefalseIDRef_) as XsdTypeBoolean;
                    return this.truefalse_; 
                }
                else
                {
                      return this.truefalse_; 
                }
            }
            set
            {
                if (this.truefalse_ != value)
                {
                    this.truefalse_ = value;
                }
            }
        }
        #endregion
        
        public string truefalseIDRef_ { get; set; }
        
    
        
    
    }
    
}

