using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class UnderlyingInfo_para : ISerialized
    {
        public UnderlyingInfo_para() { }
        public UnderlyingInfo_para(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList underlying_paraNodeList = xmlNode.SelectNodes("underlying_para");
            
            if (underlying_paraNodeList != null)
            {
                this.underlying_para_ = new List<Underlying_para>();
                foreach (XmlNode item in underlying_paraNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            underlying_paraIDRef_ = item.Attributes["id"].Value;
                            underlying_para_.Add(new Underlying_para(item));
                            IDManager.SetID(underlying_paraIDRef_, underlying_para_[underlying_para_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            underlying_paraIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        underlying_para_.Add(new Underlying_para(item));
                        }
                    }
                    else
                    {
                        underlying_para_.Add(new Underlying_para(item));
                    }
                }
            }
            
        
            XmlNode correlationInfo_paraNode = xmlNode.SelectSingleNode("correlationInfo_para");
            
            if (correlationInfo_paraNode != null)
            {
                if (correlationInfo_paraNode.Attributes["href"] != null || correlationInfo_paraNode.Attributes["id"] != null) 
                {
                    if (correlationInfo_paraNode.Attributes["id"] != null) 
                    {
                        correlationInfo_paraIDRef_ = correlationInfo_paraNode.Attributes["id"].Value;
                        CorrelationInfo_para ob = new CorrelationInfo_para(correlationInfo_paraNode);
                        IDManager.SetID(correlationInfo_paraIDRef_, ob);
                    }
                    else if (correlationInfo_paraNode.Attributes["href"] != null)
                    {
                        correlationInfo_paraIDRef_ = correlationInfo_paraNode.Attributes["href"].Value;
                    }
                    else
                    {
                        correlationInfo_para_ = new CorrelationInfo_para(correlationInfo_paraNode);
                    }
                }
                else
                {
                    correlationInfo_para_ = new CorrelationInfo_para(correlationInfo_paraNode);
                }
            }
            
        
        }
        
    
        #region Underlying_para_
        private List<Underlying_para> underlying_para_;
        public List<Underlying_para> Underlying_para_
        {
            get
            {
                if (this.underlying_para_ != null)
                {
                    return this.underlying_para_; 
                }
                else if (this.underlying_paraIDRef_ != null)
                {
                    return this.underlying_para_; 
                }
                else
                {
                    throw new Exception( "underlying_para_Node no exist!");
                }
            }
            set
            {
                if (this.underlying_para_ != value)
                {
                    this.underlying_para_ = value;
                }
            }
        }
        #endregion
        
        public string underlying_paraIDRef_ { get; set; }
        #region CorrelationInfo_para_
        private CorrelationInfo_para correlationInfo_para_;
        public CorrelationInfo_para CorrelationInfo_para_
        {
            get
            {
                if (this.correlationInfo_para_ != null)
                {
                    return this.correlationInfo_para_; 
                }
                else if (this.correlationInfo_paraIDRef_ != null)
                {
                    correlationInfo_para_ = IDManager.getID(correlationInfo_paraIDRef_) as CorrelationInfo_para;
                    return this.correlationInfo_para_; 
                }
                else
                {
                    throw new Exception( "correlationInfo_para_Node no exist!");
                }
            }
            set
            {
                if (this.correlationInfo_para_ != value)
                {
                    this.correlationInfo_para_ = value;
                }
            }
        }
        #endregion
        
        public string correlationInfo_paraIDRef_ { get; set; }
        
    
        
    
    }
    
}

