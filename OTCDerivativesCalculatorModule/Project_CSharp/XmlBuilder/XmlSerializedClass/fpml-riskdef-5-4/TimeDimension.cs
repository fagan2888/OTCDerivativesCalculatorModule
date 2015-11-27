using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class TimeDimension : ISerialized
    {
        public TimeDimension(XmlNode xmlNode)
        {
            XmlNode tenorNode = xmlNode.SelectSingleNode("tenor");
            
            if (tenorNode != null)
            {
                if (tenorNode.Attributes["href"] != null || tenorNode.Attributes["id"] != null) 
                {
                    if (tenorNode.Attributes["id"] != null) 
                    {
                        tenorIDRef_ = tenorNode.Attributes["id"].Value;
                        Period ob = new Period(tenorNode);
                        IDManager.SetID(tenorIDRef_, ob);
                    }
                    else if (tenorNode.Attributes["href"] != null)
                    {
                        tenorIDRef_ = tenorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        tenor_ = new Period(tenorNode);
                    }
                }
                else
                {
                    tenor_ = new Period(tenorNode);
                }
            }
            
        
            XmlNode dateNode = xmlNode.SelectSingleNode("date");
            
            if (dateNode != null)
            {
                if (dateNode.Attributes["href"] != null || dateNode.Attributes["id"] != null) 
                {
                    if (dateNode.Attributes["id"] != null) 
                    {
                        dateIDRef_ = dateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(dateNode);
                        IDManager.SetID(dateIDRef_, ob);
                    }
                    else if (dateNode.Attributes["href"] != null)
                    {
                        dateIDRef_ = dateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        date_ = new XsdTypeDate(dateNode);
                    }
                }
                else
                {
                    date_ = new XsdTypeDate(dateNode);
                }
            }
            
        
        }
        
    
        #region Tenor_
        private Period tenor_;
        public Period Tenor_
        {
            get
            {
                if (this.tenor_ != null)
                {
                    return this.tenor_; 
                }
                else if (this.tenorIDRef_ != null)
                {
                    tenor_ = IDManager.getID(tenorIDRef_) as Period;
                    return this.tenor_; 
                }
                else
                {
                      return this.tenor_; 
                }
            }
            set
            {
                if (this.tenor_ != value)
                {
                    this.tenor_ = value;
                }
            }
        }
        #endregion
        
        public string tenorIDRef_ { get; set; }
        #region Date_
        private XsdTypeDate date_;
        public XsdTypeDate Date_
        {
            get
            {
                if (this.date_ != null)
                {
                    return this.date_; 
                }
                else if (this.dateIDRef_ != null)
                {
                    date_ = IDManager.getID(dateIDRef_) as XsdTypeDate;
                    return this.date_; 
                }
                else
                {
                      return this.date_; 
                }
            }
            set
            {
                if (this.date_ != value)
                {
                    this.date_ = value;
                }
            }
        }
        #endregion
        
        public string dateIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

