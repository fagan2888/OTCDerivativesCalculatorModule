using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class GracePeriodExtension : ISerialized
    {
        public GracePeriodExtension(XmlNode xmlNode)
        {
            XmlNode applicableNode = xmlNode.SelectSingleNode("applicable");
            
            if (applicableNode != null)
            {
                if (applicableNode.Attributes["href"] != null || applicableNode.Attributes["id"] != null) 
                {
                    if (applicableNode.Attributes["id"] != null) 
                    {
                        applicableIDRef_ = applicableNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(applicableNode);
                        IDManager.SetID(applicableIDRef_, ob);
                    }
                    else if (applicableNode.Attributes["href"] != null)
                    {
                        applicableIDRef_ = applicableNode.Attributes["href"].Value;
                    }
                    else
                    {
                        applicable_ = new XsdTypeBoolean(applicableNode);
                    }
                }
                else
                {
                    applicable_ = new XsdTypeBoolean(applicableNode);
                }
            }
            
        
            XmlNode gracePeriodNode = xmlNode.SelectSingleNode("gracePeriod");
            
            if (gracePeriodNode != null)
            {
                if (gracePeriodNode.Attributes["href"] != null || gracePeriodNode.Attributes["id"] != null) 
                {
                    if (gracePeriodNode.Attributes["id"] != null) 
                    {
                        gracePeriodIDRef_ = gracePeriodNode.Attributes["id"].Value;
                        Offset ob = new Offset(gracePeriodNode);
                        IDManager.SetID(gracePeriodIDRef_, ob);
                    }
                    else if (gracePeriodNode.Attributes["href"] != null)
                    {
                        gracePeriodIDRef_ = gracePeriodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        gracePeriod_ = new Offset(gracePeriodNode);
                    }
                }
                else
                {
                    gracePeriod_ = new Offset(gracePeriodNode);
                }
            }
            
        
        }
        
    
        #region Applicable_
        private XsdTypeBoolean applicable_;
        public XsdTypeBoolean Applicable_
        {
            get
            {
                if (this.applicable_ != null)
                {
                    return this.applicable_; 
                }
                else if (this.applicableIDRef_ != null)
                {
                    applicable_ = IDManager.getID(applicableIDRef_) as XsdTypeBoolean;
                    return this.applicable_; 
                }
                else
                {
                      return this.applicable_; 
                }
            }
            set
            {
                if (this.applicable_ != value)
                {
                    this.applicable_ = value;
                }
            }
        }
        #endregion
        
        public string applicableIDRef_ { get; set; }
        #region GracePeriod_
        private Offset gracePeriod_;
        public Offset GracePeriod_
        {
            get
            {
                if (this.gracePeriod_ != null)
                {
                    return this.gracePeriod_; 
                }
                else if (this.gracePeriodIDRef_ != null)
                {
                    gracePeriod_ = IDManager.getID(gracePeriodIDRef_) as Offset;
                    return this.gracePeriod_; 
                }
                else
                {
                      return this.gracePeriod_; 
                }
            }
            set
            {
                if (this.gracePeriod_ != value)
                {
                    this.gracePeriod_ = value;
                }
            }
        }
        #endregion
        
        public string gracePeriodIDRef_ { get; set; }
        
    
        
    
    }
    
}

