using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CorrelationInfo_para : ISerialized
    {
        public CorrelationInfo_para() { }
        public CorrelationInfo_para(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode dimensionNode = xmlNode.SelectSingleNode("dimension");
            
            if (dimensionNode != null)
            {
                if (dimensionNode.Attributes["href"] != null || dimensionNode.Attributes["id"] != null) 
                {
                    if (dimensionNode.Attributes["id"] != null) 
                    {
                        dimensionIDRef_ = dimensionNode.Attributes["id"].Value;
                        XsdTypeInteger ob = new XsdTypeInteger(dimensionNode);
                        IDManager.SetID(dimensionIDRef_, ob);
                    }
                    else if (dimensionNode.Attributes["href"] != null)
                    {
                        dimensionIDRef_ = dimensionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dimension_ = new XsdTypeInteger(dimensionNode);
                    }
                }
                else
                {
                    dimension_ = new XsdTypeInteger(dimensionNode);
                }
            }
            
        
            XmlNodeList correlation_paraNodeList = xmlNode.SelectNodes("correlation_para");
            
            if (correlation_paraNodeList != null)
            {
                this.correlation_para_ = new List<Correlation_para>();
                foreach (XmlNode item in correlation_paraNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            correlation_paraIDRef_ = item.Attributes["id"].Value;
                            correlation_para_.Add(new Correlation_para(item));
                            IDManager.SetID(correlation_paraIDRef_, correlation_para_[correlation_para_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            correlation_paraIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        correlation_para_.Add(new Correlation_para(item));
                        }
                    }
                    else
                    {
                        correlation_para_.Add(new Correlation_para(item));
                    }
                }
            }
            
        
        }
        
    
        #region Dimension_
        private XsdTypeInteger dimension_;
        public XsdTypeInteger Dimension_
        {
            get
            {
                if (this.dimension_ != null)
                {
                    return this.dimension_; 
                }
                else if (this.dimensionIDRef_ != null)
                {
                    dimension_ = IDManager.getID(dimensionIDRef_) as XsdTypeInteger;
                    return this.dimension_; 
                }
                else
                {
                    throw new Exception( "dimension_Node no exist!");
                }
            }
            set
            {
                if (this.dimension_ != value)
                {
                    this.dimension_ = value;
                }
            }
        }
        #endregion
        
        public string dimensionIDRef_ { get; set; }
        #region Correlation_para_
        private List<Correlation_para> correlation_para_;
        public List<Correlation_para> Correlation_para_
        {
            get
            {
                if (this.correlation_para_ != null)
                {
                    return this.correlation_para_; 
                }
                else if (this.correlation_paraIDRef_ != null)
                {
                    return this.correlation_para_; 
                }
                else
                {
                    throw new Exception( "correlation_para_Node no exist!");
                }
            }
            set
            {
                if (this.correlation_para_ != value)
                {
                    this.correlation_para_ = value;
                }
            }
        }
        #endregion
        
        public string correlation_paraIDRef_ { get; set; }
        
    
        
    
    }
    
}

