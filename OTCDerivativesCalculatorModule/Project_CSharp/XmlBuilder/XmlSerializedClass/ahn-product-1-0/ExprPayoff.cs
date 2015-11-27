using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ExprPayoff : ISerialized
    {
        public ExprPayoff(XmlNode xmlNode)
        {
            XmlNodeList dateNodeList = xmlNode.SelectNodes("date");
            
            if (dateNodeList != null)
            {
                this.date_ = new List<XsdTypeDate>();
                foreach (XmlNode item in dateNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            dateIDRef_ = item.Attributes["id"].Value;
                            date_.Add(new XsdTypeDate(item));
                            IDManager.SetID(dateIDRef_, date_[date_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            dateIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        date_.Add(new XsdTypeDate(item));
                        }
                    }
                    else
                    {
                        date_.Add(new XsdTypeDate(item));
                    }
                }
            }
            
        
        }
        
    
        #region Date_
        private List<XsdTypeDate> date_;
        public List<XsdTypeDate> Date_
        {
            get
            {
                if (this.date_ != null)
                {
                    return this.date_; 
                }
                else if (this.dateIDRef_ != null)
                {
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
        
    
        
    
    }
    
}

