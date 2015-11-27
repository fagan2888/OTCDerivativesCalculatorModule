using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EventDate : ISerialized
    {
        public EventDate(XmlNode xmlNode)
        {
            XmlNode dateSingleNode = xmlNode.SelectSingleNode("dateSingle");
            
            if (dateSingleNode != null)
            {
                if (dateSingleNode.Attributes["href"] != null || dateSingleNode.Attributes["id"] != null) 
                {
                    if (dateSingleNode.Attributes["id"] != null) 
                    {
                        dateSingleIDRef_ = dateSingleNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(dateSingleNode);
                        IDManager.SetID(dateSingleIDRef_, ob);
                    }
                    else if (dateSingleNode.Attributes["href"] != null)
                    {
                        dateSingleIDRef_ = dateSingleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dateSingle_ = new XsdTypeDate(dateSingleNode);
                    }
                }
                else
                {
                    dateSingle_ = new XsdTypeDate(dateSingleNode);
                }
            }
            
        
        }
        
    
        #region DateSingle_
        private XsdTypeDate dateSingle_;
        public XsdTypeDate DateSingle_
        {
            get
            {
                if (this.dateSingle_ != null)
                {
                    return this.dateSingle_; 
                }
                else if (this.dateSingleIDRef_ != null)
                {
                    dateSingle_ = IDManager.getID(dateSingleIDRef_) as XsdTypeDate;
                    return this.dateSingle_; 
                }
                else
                {
                      return this.dateSingle_; 
                }
            }
            set
            {
                if (this.dateSingle_ != value)
                {
                    this.dateSingle_ = value;
                }
            }
        }
        #endregion
        
        public string dateSingleIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

