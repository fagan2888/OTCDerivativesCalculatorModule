using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_dualRangeEventCal : ISerialized
    {
        public Excel_dualRangeEventCal() { }
        public Excel_dualRangeEventCal(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode lowerRngNode = xmlNode.SelectSingleNode("lowerRng");
            
            if (lowerRngNode != null)
            {
                if (lowerRngNode.Attributes["href"] != null || lowerRngNode.Attributes["id"] != null) 
                {
                    if (lowerRngNode.Attributes["id"] != null) 
                    {
                        lowerRngIDRef_ = lowerRngNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(lowerRngNode);
                        IDManager.SetID(lowerRngIDRef_, ob);
                    }
                    else if (lowerRngNode.Attributes["href"] != null)
                    {
                        lowerRngIDRef_ = lowerRngNode.Attributes["href"].Value;
                    }
                    else
                    {
                        lowerRng_ = new XsdTypeToken(lowerRngNode);
                    }
                }
                else
                {
                    lowerRng_ = new XsdTypeToken(lowerRngNode);
                }
            }
            
        
            XmlNode upperRngNode = xmlNode.SelectSingleNode("upperRng");
            
            if (upperRngNode != null)
            {
                if (upperRngNode.Attributes["href"] != null || upperRngNode.Attributes["id"] != null) 
                {
                    if (upperRngNode.Attributes["id"] != null) 
                    {
                        upperRngIDRef_ = upperRngNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(upperRngNode);
                        IDManager.SetID(upperRngIDRef_, ob);
                    }
                    else if (upperRngNode.Attributes["href"] != null)
                    {
                        upperRngIDRef_ = upperRngNode.Attributes["href"].Value;
                    }
                    else
                    {
                        upperRng_ = new XsdTypeToken(upperRngNode);
                    }
                }
                else
                {
                    upperRng_ = new XsdTypeToken(upperRngNode);
                }
            }
            
        
            XmlNode excel_underlyingCalcIDNode = xmlNode.SelectSingleNode("excel_underlyingCalcID");
            
            if (excel_underlyingCalcIDNode != null)
            {
                if (excel_underlyingCalcIDNode.Attributes["href"] != null || excel_underlyingCalcIDNode.Attributes["id"] != null) 
                {
                    if (excel_underlyingCalcIDNode.Attributes["id"] != null) 
                    {
                        excel_underlyingCalcIDIDRef_ = excel_underlyingCalcIDNode.Attributes["id"].Value;
                        Excel_underlyingCalcID ob = new Excel_underlyingCalcID(excel_underlyingCalcIDNode);
                        IDManager.SetID(excel_underlyingCalcIDIDRef_, ob);
                    }
                    else if (excel_underlyingCalcIDNode.Attributes["href"] != null)
                    {
                        excel_underlyingCalcIDIDRef_ = excel_underlyingCalcIDNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_underlyingCalcID_ = new Excel_underlyingCalcID(excel_underlyingCalcIDNode);
                    }
                }
                else
                {
                    excel_underlyingCalcID_ = new Excel_underlyingCalcID(excel_underlyingCalcIDNode);
                }
            }
            
        
        }
        
    
        #region LowerRng_
        private XsdTypeToken lowerRng_;
        public XsdTypeToken LowerRng_
        {
            get
            {
                if (this.lowerRng_ != null)
                {
                    return this.lowerRng_; 
                }
                else if (this.lowerRngIDRef_ != null)
                {
                    lowerRng_ = IDManager.getID(lowerRngIDRef_) as XsdTypeToken;
                    return this.lowerRng_; 
                }
                else
                {
                    throw new Exception( "lowerRng_Node no exist!");
                }
            }
            set
            {
                if (this.lowerRng_ != value)
                {
                    this.lowerRng_ = value;
                }
            }
        }
        #endregion
        
        public string lowerRngIDRef_ { get; set; }
        #region UpperRng_
        private XsdTypeToken upperRng_;
        public XsdTypeToken UpperRng_
        {
            get
            {
                if (this.upperRng_ != null)
                {
                    return this.upperRng_; 
                }
                else if (this.upperRngIDRef_ != null)
                {
                    upperRng_ = IDManager.getID(upperRngIDRef_) as XsdTypeToken;
                    return this.upperRng_; 
                }
                else
                {
                    throw new Exception( "upperRng_Node no exist!");
                }
            }
            set
            {
                if (this.upperRng_ != value)
                {
                    this.upperRng_ = value;
                }
            }
        }
        #endregion
        
        public string upperRngIDRef_ { get; set; }
        #region Excel_underlyingCalcID_
        private Excel_underlyingCalcID excel_underlyingCalcID_;
        public Excel_underlyingCalcID Excel_underlyingCalcID_
        {
            get
            {
                if (this.excel_underlyingCalcID_ != null)
                {
                    return this.excel_underlyingCalcID_; 
                }
                else if (this.excel_underlyingCalcIDIDRef_ != null)
                {
                    excel_underlyingCalcID_ = IDManager.getID(excel_underlyingCalcIDIDRef_) as Excel_underlyingCalcID;
                    return this.excel_underlyingCalcID_; 
                }
                else
                {
                    throw new Exception( "excel_underlyingCalcID_Node no exist!");
                }
            }
            set
            {
                if (this.excel_underlyingCalcID_ != value)
                {
                    this.excel_underlyingCalcID_ = value;
                }
            }
        }
        #endregion
        
        public string excel_underlyingCalcIDIDRef_ { get; set; }
        
    
        
    
    }
    
}

