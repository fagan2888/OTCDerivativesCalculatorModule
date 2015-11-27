using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Correlation_para : ISerialized
    {
        public Correlation_para() { }
        public Correlation_para(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode firstNode = xmlNode.SelectSingleNode("first");
            
            if (firstNode != null)
            {
                if (firstNode.Attributes["href"] != null || firstNode.Attributes["id"] != null) 
                {
                    if (firstNode.Attributes["id"] != null) 
                    {
                        firstIDRef_ = firstNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(firstNode);
                        IDManager.SetID(firstIDRef_, ob);
                    }
                    else if (firstNode.Attributes["href"] != null)
                    {
                        firstIDRef_ = firstNode.Attributes["href"].Value;
                    }
                    else
                    {
                        first_ = new XsdTypeToken(firstNode);
                    }
                }
                else
                {
                    first_ = new XsdTypeToken(firstNode);
                }
            }
            
        
            XmlNode secondNode = xmlNode.SelectSingleNode("second");
            
            if (secondNode != null)
            {
                if (secondNode.Attributes["href"] != null || secondNode.Attributes["id"] != null) 
                {
                    if (secondNode.Attributes["id"] != null) 
                    {
                        secondIDRef_ = secondNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(secondNode);
                        IDManager.SetID(secondIDRef_, ob);
                    }
                    else if (secondNode.Attributes["href"] != null)
                    {
                        secondIDRef_ = secondNode.Attributes["href"].Value;
                    }
                    else
                    {
                        second_ = new XsdTypeToken(secondNode);
                    }
                }
                else
                {
                    second_ = new XsdTypeToken(secondNode);
                }
            }
            
        
            XmlNode valueNode = xmlNode.SelectSingleNode("value");
            
            if (valueNode != null)
            {
                if (valueNode.Attributes["href"] != null || valueNode.Attributes["id"] != null) 
                {
                    if (valueNode.Attributes["id"] != null) 
                    {
                        valueIDRef_ = valueNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(valueNode);
                        IDManager.SetID(valueIDRef_, ob);
                    }
                    else if (valueNode.Attributes["href"] != null)
                    {
                        valueIDRef_ = valueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        value_ = new XsdTypeDouble(valueNode);
                    }
                }
                else
                {
                    value_ = new XsdTypeDouble(valueNode);
                }
            }
            
        
        }
        
    
        #region First_
        private XsdTypeToken first_;
        public XsdTypeToken First_
        {
            get
            {
                if (this.first_ != null)
                {
                    return this.first_; 
                }
                else if (this.firstIDRef_ != null)
                {
                    first_ = IDManager.getID(firstIDRef_) as XsdTypeToken;
                    return this.first_; 
                }
                else
                {
                    throw new Exception( "first_Node no exist!");
                }
            }
            set
            {
                if (this.first_ != value)
                {
                    this.first_ = value;
                }
            }
        }
        #endregion
        
        public string firstIDRef_ { get; set; }
        #region Second_
        private XsdTypeToken second_;
        public XsdTypeToken Second_
        {
            get
            {
                if (this.second_ != null)
                {
                    return this.second_; 
                }
                else if (this.secondIDRef_ != null)
                {
                    second_ = IDManager.getID(secondIDRef_) as XsdTypeToken;
                    return this.second_; 
                }
                else
                {
                    throw new Exception( "second_Node no exist!");
                }
            }
            set
            {
                if (this.second_ != value)
                {
                    this.second_ = value;
                }
            }
        }
        #endregion
        
        public string secondIDRef_ { get; set; }
        #region Value_
        private XsdTypeDouble value_;
        public XsdTypeDouble Value_
        {
            get
            {
                if (this.value_ != null)
                {
                    return this.value_; 
                }
                else if (this.valueIDRef_ != null)
                {
                    value_ = IDManager.getID(valueIDRef_) as XsdTypeDouble;
                    return this.value_; 
                }
                else
                {
                    throw new Exception( "value_Node no exist!");
                }
            }
            set
            {
                if (this.value_ != value)
                {
                    this.value_ = value;
                }
            }
        }
        #endregion
        
        public string valueIDRef_ { get; set; }
        
    
        
    
    }
    
}

