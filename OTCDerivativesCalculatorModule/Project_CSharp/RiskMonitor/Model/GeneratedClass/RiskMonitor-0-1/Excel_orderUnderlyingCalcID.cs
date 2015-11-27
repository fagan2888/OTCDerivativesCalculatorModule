using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_orderUnderlyingCalcID : ISerialized
    {
        public Excel_orderUnderlyingCalcID() { }
        public Excel_orderUnderlyingCalcID(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList excel_selectedUnderlyingNodeList = xmlNode.SelectNodes("excel_selectedUnderlying");
            
            if (excel_selectedUnderlyingNodeList != null)
            {
                this.excel_selectedUnderlying_ = new List<Excel_selectedUnderlying>();
                foreach (XmlNode item in excel_selectedUnderlyingNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            excel_selectedUnderlyingIDRef_ = item.Attributes["id"].Value;
                            excel_selectedUnderlying_.Add(new Excel_selectedUnderlying(item));
                            IDManager.SetID(excel_selectedUnderlyingIDRef_, excel_selectedUnderlying_[excel_selectedUnderlying_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            excel_selectedUnderlyingIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        excel_selectedUnderlying_.Add(new Excel_selectedUnderlying(item));
                        }
                    }
                    else
                    {
                        excel_selectedUnderlying_.Add(new Excel_selectedUnderlying(item));
                    }
                }
            }
            
        
            XmlNode eventDateNode = xmlNode.SelectSingleNode("eventDate");
            
            if (eventDateNode != null)
            {
                if (eventDateNode.Attributes["href"] != null || eventDateNode.Attributes["id"] != null) 
                {
                    if (eventDateNode.Attributes["id"] != null) 
                    {
                        eventDateIDRef_ = eventDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(eventDateNode);
                        IDManager.SetID(eventDateIDRef_, ob);
                    }
                    else if (eventDateNode.Attributes["href"] != null)
                    {
                        eventDateIDRef_ = eventDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        eventDate_ = new XsdTypeToken(eventDateNode);
                    }
                }
                else
                {
                    eventDate_ = new XsdTypeToken(eventDateNode);
                }
            }
            
        
            XmlNode nthNode = xmlNode.SelectSingleNode("nth");
            
            if (nthNode != null)
            {
                if (nthNode.Attributes["href"] != null || nthNode.Attributes["id"] != null) 
                {
                    if (nthNode.Attributes["id"] != null) 
                    {
                        nthIDRef_ = nthNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(nthNode);
                        IDManager.SetID(nthIDRef_, ob);
                    }
                    else if (nthNode.Attributes["href"] != null)
                    {
                        nthIDRef_ = nthNode.Attributes["href"].Value;
                    }
                    else
                    {
                        nth_ = new XsdTypeToken(nthNode);
                    }
                }
                else
                {
                    nth_ = new XsdTypeToken(nthNode);
                }
            }
            
        
        }
        
    
        #region Excel_selectedUnderlying_
        private List<Excel_selectedUnderlying> excel_selectedUnderlying_;
        public List<Excel_selectedUnderlying> Excel_selectedUnderlying_
        {
            get
            {
                if (this.excel_selectedUnderlying_ != null)
                {
                    return this.excel_selectedUnderlying_; 
                }
                else if (this.excel_selectedUnderlyingIDRef_ != null)
                {
                    return this.excel_selectedUnderlying_; 
                }
                else
                {
                    throw new Exception( "excel_selectedUnderlying_Node no exist!");
                }
            }
            set
            {
                if (this.excel_selectedUnderlying_ != value)
                {
                    this.excel_selectedUnderlying_ = value;
                }
            }
        }
        #endregion
        
        public string excel_selectedUnderlyingIDRef_ { get; set; }
        #region EventDate_
        private XsdTypeToken eventDate_;
        public XsdTypeToken EventDate_
        {
            get
            {
                if (this.eventDate_ != null)
                {
                    return this.eventDate_; 
                }
                else if (this.eventDateIDRef_ != null)
                {
                    eventDate_ = IDManager.getID(eventDateIDRef_) as XsdTypeToken;
                    return this.eventDate_; 
                }
                else
                {
                    throw new Exception( "eventDate_Node no exist!");
                }
            }
            set
            {
                if (this.eventDate_ != value)
                {
                    this.eventDate_ = value;
                }
            }
        }
        #endregion
        
        public string eventDateIDRef_ { get; set; }
        #region Nth_
        private XsdTypeToken nth_;
        public XsdTypeToken Nth_
        {
            get
            {
                if (this.nth_ != null)
                {
                    return this.nth_; 
                }
                else if (this.nthIDRef_ != null)
                {
                    nth_ = IDManager.getID(nthIDRef_) as XsdTypeToken;
                    return this.nth_; 
                }
                else
                {
                    throw new Exception( "nth_Node no exist!");
                }
            }
            set
            {
                if (this.nth_ != value)
                {
                    this.nth_ = value;
                }
            }
        }
        #endregion
        
        public string nthIDRef_ { get; set; }
        
    
        
    
    }
    
}

