using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_averageUnderlyingCalcID : ISerialized
    {
        public Excel_averageUnderlyingCalcID() { }
        public Excel_averageUnderlyingCalcID(XmlNode xmlNode)
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
            
        
            XmlNodeList weightNodeList = xmlNode.SelectNodes("weight");
            
            if (weightNodeList != null)
            {
                this.weight_ = new List<XsdTypeToken>();
                foreach (XmlNode item in weightNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            weightIDRef_ = item.Attributes["id"].Value;
                            weight_.Add(new XsdTypeToken(item));
                            IDManager.SetID(weightIDRef_, weight_[weight_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            weightIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        weight_.Add(new XsdTypeToken(item));
                        }
                    }
                    else
                    {
                        weight_.Add(new XsdTypeToken(item));
                    }
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
        #region Weight_
        private List<XsdTypeToken> weight_;
        public List<XsdTypeToken> Weight_
        {
            get
            {
                if (this.weight_ != null)
                {
                    return this.weight_; 
                }
                else if (this.weightIDRef_ != null)
                {
                    return this.weight_; 
                }
                else
                {
                    throw new Exception( "weight_Node no exist!");
                }
            }
            set
            {
                if (this.weight_ != value)
                {
                    this.weight_ = value;
                }
            }
        }
        #endregion
        
        public string weightIDRef_ { get; set; }
        
    
        
    
    }
    
}

