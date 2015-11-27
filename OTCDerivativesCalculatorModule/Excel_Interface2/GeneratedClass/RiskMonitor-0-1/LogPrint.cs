using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class LogPrint : ISerialized
    {
        public LogPrint() { }
        public LogPrint(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode generatedPathLogNode = xmlNode.SelectSingleNode("generatedPathLog");
            
            if (generatedPathLogNode != null)
            {
                if (generatedPathLogNode.Attributes["href"] != null || generatedPathLogNode.Attributes["id"] != null) 
                {
                    if (generatedPathLogNode.Attributes["id"] != null) 
                    {
                        generatedPathLogIDRef_ = generatedPathLogNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(generatedPathLogNode);
                        IDManager.SetID(generatedPathLogIDRef_, ob);
                    }
                    else if (generatedPathLogNode.Attributes["href"] != null)
                    {
                        generatedPathLogIDRef_ = generatedPathLogNode.Attributes["href"].Value;
                    }
                    else
                    {
                        generatedPathLog_ = new XsdTypeToken(generatedPathLogNode);
                    }
                }
                else
                {
                    generatedPathLog_ = new XsdTypeToken(generatedPathLogNode);
                }
            }
            
        
            XmlNode payoffCalcLogNode = xmlNode.SelectSingleNode("payoffCalcLog");
            
            if (payoffCalcLogNode != null)
            {
                if (payoffCalcLogNode.Attributes["href"] != null || payoffCalcLogNode.Attributes["id"] != null) 
                {
                    if (payoffCalcLogNode.Attributes["id"] != null) 
                    {
                        payoffCalcLogIDRef_ = payoffCalcLogNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(payoffCalcLogNode);
                        IDManager.SetID(payoffCalcLogIDRef_, ob);
                    }
                    else if (payoffCalcLogNode.Attributes["href"] != null)
                    {
                        payoffCalcLogIDRef_ = payoffCalcLogNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payoffCalcLog_ = new XsdTypeToken(payoffCalcLogNode);
                    }
                }
                else
                {
                    payoffCalcLog_ = new XsdTypeToken(payoffCalcLogNode);
                }
            }
            
        
        }
        
    
        #region GeneratedPathLog_
        private XsdTypeToken generatedPathLog_;
        public XsdTypeToken GeneratedPathLog_
        {
            get
            {
                if (this.generatedPathLog_ != null)
                {
                    return this.generatedPathLog_; 
                }
                else if (this.generatedPathLogIDRef_ != null)
                {
                    generatedPathLog_ = IDManager.getID(generatedPathLogIDRef_) as XsdTypeToken;
                    return this.generatedPathLog_; 
                }
                else
                {
                    throw new Exception( "generatedPathLog_Node no exist!");
                }
            }
            set
            {
                if (this.generatedPathLog_ != value)
                {
                    this.generatedPathLog_ = value;
                }
            }
        }
        #endregion
        
        public string generatedPathLogIDRef_ { get; set; }
        #region PayoffCalcLog_
        private XsdTypeToken payoffCalcLog_;
        public XsdTypeToken PayoffCalcLog_
        {
            get
            {
                if (this.payoffCalcLog_ != null)
                {
                    return this.payoffCalcLog_; 
                }
                else if (this.payoffCalcLogIDRef_ != null)
                {
                    payoffCalcLog_ = IDManager.getID(payoffCalcLogIDRef_) as XsdTypeToken;
                    return this.payoffCalcLog_; 
                }
                else
                {
                    throw new Exception( "payoffCalcLog_Node no exist!");
                }
            }
            set
            {
                if (this.payoffCalcLog_ != value)
                {
                    this.payoffCalcLog_ = value;
                }
            }
        }
        #endregion
        
        public string payoffCalcLogIDRef_ { get; set; }
        
    
        
    
    }
    
}

