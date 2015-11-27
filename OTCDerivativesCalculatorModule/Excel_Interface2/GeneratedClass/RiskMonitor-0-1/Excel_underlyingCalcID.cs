using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_underlyingCalcID : ISerialized
    {
        public Excel_underlyingCalcID() { }
        public Excel_underlyingCalcID(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode excel_typeNode = xmlNode.SelectSingleNode("excel_type");
            
            if (excel_typeNode != null)
            {
                if (excel_typeNode.Attributes["href"] != null || excel_typeNode.Attributes["id"] != null) 
                {
                    if (excel_typeNode.Attributes["id"] != null) 
                    {
                        excel_typeIDRef_ = excel_typeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(excel_typeNode);
                        IDManager.SetID(excel_typeIDRef_, ob);
                    }
                    else if (excel_typeNode.Attributes["href"] != null)
                    {
                        excel_typeIDRef_ = excel_typeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_type_ = new XsdTypeToken(excel_typeNode);
                    }
                }
                else
                {
                    excel_type_ = new XsdTypeToken(excel_typeNode);
                }
            }
            
        
            XmlNode calcIDNode = xmlNode.SelectSingleNode("calcID");
            
            if (calcIDNode != null)
            {
                if (calcIDNode.Attributes["href"] != null || calcIDNode.Attributes["id"] != null) 
                {
                    if (calcIDNode.Attributes["id"] != null) 
                    {
                        calcIDIDRef_ = calcIDNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(calcIDNode);
                        IDManager.SetID(calcIDIDRef_, ob);
                    }
                    else if (calcIDNode.Attributes["href"] != null)
                    {
                        calcIDIDRef_ = calcIDNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calcID_ = new XsdTypeToken(calcIDNode);
                    }
                }
                else
                {
                    calcID_ = new XsdTypeToken(calcIDNode);
                }
            }
            
        
            XmlNode excel_choiceUnderlyingCalcIDNode = xmlNode.SelectSingleNode("excel_choiceUnderlyingCalcID");
            
            if (excel_choiceUnderlyingCalcIDNode != null)
            {
                if (excel_choiceUnderlyingCalcIDNode.Attributes["href"] != null || excel_choiceUnderlyingCalcIDNode.Attributes["id"] != null) 
                {
                    if (excel_choiceUnderlyingCalcIDNode.Attributes["id"] != null) 
                    {
                        excel_choiceUnderlyingCalcIDIDRef_ = excel_choiceUnderlyingCalcIDNode.Attributes["id"].Value;
                        Excel_choiceUnderlyingCalcID ob = new Excel_choiceUnderlyingCalcID(excel_choiceUnderlyingCalcIDNode);
                        IDManager.SetID(excel_choiceUnderlyingCalcIDIDRef_, ob);
                    }
                    else if (excel_choiceUnderlyingCalcIDNode.Attributes["href"] != null)
                    {
                        excel_choiceUnderlyingCalcIDIDRef_ = excel_choiceUnderlyingCalcIDNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_choiceUnderlyingCalcID_ = new Excel_choiceUnderlyingCalcID(excel_choiceUnderlyingCalcIDNode);
                    }
                }
                else
                {
                    excel_choiceUnderlyingCalcID_ = new Excel_choiceUnderlyingCalcID(excel_choiceUnderlyingCalcIDNode);
                }
            }
            
        
            XmlNode excel_maximumUnderlyingCalcIDNode = xmlNode.SelectSingleNode("excel_maximumUnderlyingCalcID");
            
            if (excel_maximumUnderlyingCalcIDNode != null)
            {
                if (excel_maximumUnderlyingCalcIDNode.Attributes["href"] != null || excel_maximumUnderlyingCalcIDNode.Attributes["id"] != null) 
                {
                    if (excel_maximumUnderlyingCalcIDNode.Attributes["id"] != null) 
                    {
                        excel_maximumUnderlyingCalcIDIDRef_ = excel_maximumUnderlyingCalcIDNode.Attributes["id"].Value;
                        Excel_maximumUnderlyingCalcID ob = new Excel_maximumUnderlyingCalcID(excel_maximumUnderlyingCalcIDNode);
                        IDManager.SetID(excel_maximumUnderlyingCalcIDIDRef_, ob);
                    }
                    else if (excel_maximumUnderlyingCalcIDNode.Attributes["href"] != null)
                    {
                        excel_maximumUnderlyingCalcIDIDRef_ = excel_maximumUnderlyingCalcIDNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_maximumUnderlyingCalcID_ = new Excel_maximumUnderlyingCalcID(excel_maximumUnderlyingCalcIDNode);
                    }
                }
                else
                {
                    excel_maximumUnderlyingCalcID_ = new Excel_maximumUnderlyingCalcID(excel_maximumUnderlyingCalcIDNode);
                }
            }
            
        
            XmlNode excel_minimumUnderlyingCalcIDNode = xmlNode.SelectSingleNode("excel_minimumUnderlyingCalcID");
            
            if (excel_minimumUnderlyingCalcIDNode != null)
            {
                if (excel_minimumUnderlyingCalcIDNode.Attributes["href"] != null || excel_minimumUnderlyingCalcIDNode.Attributes["id"] != null) 
                {
                    if (excel_minimumUnderlyingCalcIDNode.Attributes["id"] != null) 
                    {
                        excel_minimumUnderlyingCalcIDIDRef_ = excel_minimumUnderlyingCalcIDNode.Attributes["id"].Value;
                        Excel_minimumUnderlyingCalcID ob = new Excel_minimumUnderlyingCalcID(excel_minimumUnderlyingCalcIDNode);
                        IDManager.SetID(excel_minimumUnderlyingCalcIDIDRef_, ob);
                    }
                    else if (excel_minimumUnderlyingCalcIDNode.Attributes["href"] != null)
                    {
                        excel_minimumUnderlyingCalcIDIDRef_ = excel_minimumUnderlyingCalcIDNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_minimumUnderlyingCalcID_ = new Excel_minimumUnderlyingCalcID(excel_minimumUnderlyingCalcIDNode);
                    }
                }
                else
                {
                    excel_minimumUnderlyingCalcID_ = new Excel_minimumUnderlyingCalcID(excel_minimumUnderlyingCalcIDNode);
                }
            }
            
        
            XmlNode excel_averageUnderlyingCalcIDNode = xmlNode.SelectSingleNode("excel_averageUnderlyingCalcID");
            
            if (excel_averageUnderlyingCalcIDNode != null)
            {
                if (excel_averageUnderlyingCalcIDNode.Attributes["href"] != null || excel_averageUnderlyingCalcIDNode.Attributes["id"] != null) 
                {
                    if (excel_averageUnderlyingCalcIDNode.Attributes["id"] != null) 
                    {
                        excel_averageUnderlyingCalcIDIDRef_ = excel_averageUnderlyingCalcIDNode.Attributes["id"].Value;
                        Excel_averageUnderlyingCalcID ob = new Excel_averageUnderlyingCalcID(excel_averageUnderlyingCalcIDNode);
                        IDManager.SetID(excel_averageUnderlyingCalcIDIDRef_, ob);
                    }
                    else if (excel_averageUnderlyingCalcIDNode.Attributes["href"] != null)
                    {
                        excel_averageUnderlyingCalcIDIDRef_ = excel_averageUnderlyingCalcIDNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_averageUnderlyingCalcID_ = new Excel_averageUnderlyingCalcID(excel_averageUnderlyingCalcIDNode);
                    }
                }
                else
                {
                    excel_averageUnderlyingCalcID_ = new Excel_averageUnderlyingCalcID(excel_averageUnderlyingCalcIDNode);
                }
            }
            
        
            XmlNode excel_orderUnderlyingCalcIDNode = xmlNode.SelectSingleNode("excel_orderUnderlyingCalcID");
            
            if (excel_orderUnderlyingCalcIDNode != null)
            {
                if (excel_orderUnderlyingCalcIDNode.Attributes["href"] != null || excel_orderUnderlyingCalcIDNode.Attributes["id"] != null) 
                {
                    if (excel_orderUnderlyingCalcIDNode.Attributes["id"] != null) 
                    {
                        excel_orderUnderlyingCalcIDIDRef_ = excel_orderUnderlyingCalcIDNode.Attributes["id"].Value;
                        Excel_orderUnderlyingCalcID ob = new Excel_orderUnderlyingCalcID(excel_orderUnderlyingCalcIDNode);
                        IDManager.SetID(excel_orderUnderlyingCalcIDIDRef_, ob);
                    }
                    else if (excel_orderUnderlyingCalcIDNode.Attributes["href"] != null)
                    {
                        excel_orderUnderlyingCalcIDIDRef_ = excel_orderUnderlyingCalcIDNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_orderUnderlyingCalcID_ = new Excel_orderUnderlyingCalcID(excel_orderUnderlyingCalcIDNode);
                    }
                }
                else
                {
                    excel_orderUnderlyingCalcID_ = new Excel_orderUnderlyingCalcID(excel_orderUnderlyingCalcIDNode);
                }
            }
            
        
        }
        
    
        #region Excel_type_
        private XsdTypeToken excel_type_;
        public XsdTypeToken Excel_type_
        {
            get
            {
                if (this.excel_type_ != null)
                {
                    return this.excel_type_; 
                }
                else if (this.excel_typeIDRef_ != null)
                {
                    excel_type_ = IDManager.getID(excel_typeIDRef_) as XsdTypeToken;
                    return this.excel_type_; 
                }
                else
                {
                    throw new Exception( "excel_type_Node no exist!");
                }
            }
            set
            {
                if (this.excel_type_ != value)
                {
                    this.excel_type_ = value;
                }
            }
        }
        #endregion
        
        public string excel_typeIDRef_ { get; set; }
        #region CalcID_
        private XsdTypeToken calcID_;
        public XsdTypeToken CalcID_
        {
            get
            {
                if (this.calcID_ != null)
                {
                    return this.calcID_; 
                }
                else if (this.calcIDIDRef_ != null)
                {
                    calcID_ = IDManager.getID(calcIDIDRef_) as XsdTypeToken;
                    return this.calcID_; 
                }
                else
                {
                    throw new Exception( "calcID_Node no exist!");
                }
            }
            set
            {
                if (this.calcID_ != value)
                {
                    this.calcID_ = value;
                }
            }
        }
        #endregion
        
        public string calcIDIDRef_ { get; set; }
        #region Excel_choiceUnderlyingCalcID_
        private Excel_choiceUnderlyingCalcID excel_choiceUnderlyingCalcID_;
        public Excel_choiceUnderlyingCalcID Excel_choiceUnderlyingCalcID_
        {
            get
            {
                if (this.excel_choiceUnderlyingCalcID_ != null)
                {
                    return this.excel_choiceUnderlyingCalcID_; 
                }
                else if (this.excel_choiceUnderlyingCalcIDIDRef_ != null)
                {
                    excel_choiceUnderlyingCalcID_ = IDManager.getID(excel_choiceUnderlyingCalcIDIDRef_) as Excel_choiceUnderlyingCalcID;
                    return this.excel_choiceUnderlyingCalcID_; 
                }
                else
                {
                    throw new Exception( "excel_choiceUnderlyingCalcID_Node no exist!");
                }
            }
            set
            {
                if (this.excel_choiceUnderlyingCalcID_ != value)
                {
                    this.excel_choiceUnderlyingCalcID_ = value;
                }
            }
        }
        #endregion
        
        public string excel_choiceUnderlyingCalcIDIDRef_ { get; set; }
        #region Excel_maximumUnderlyingCalcID_
        private Excel_maximumUnderlyingCalcID excel_maximumUnderlyingCalcID_;
        public Excel_maximumUnderlyingCalcID Excel_maximumUnderlyingCalcID_
        {
            get
            {
                if (this.excel_maximumUnderlyingCalcID_ != null)
                {
                    return this.excel_maximumUnderlyingCalcID_; 
                }
                else if (this.excel_maximumUnderlyingCalcIDIDRef_ != null)
                {
                    excel_maximumUnderlyingCalcID_ = IDManager.getID(excel_maximumUnderlyingCalcIDIDRef_) as Excel_maximumUnderlyingCalcID;
                    return this.excel_maximumUnderlyingCalcID_; 
                }
                else
                {
                    throw new Exception( "excel_maximumUnderlyingCalcID_Node no exist!");
                }
            }
            set
            {
                if (this.excel_maximumUnderlyingCalcID_ != value)
                {
                    this.excel_maximumUnderlyingCalcID_ = value;
                }
            }
        }
        #endregion
        
        public string excel_maximumUnderlyingCalcIDIDRef_ { get; set; }
        #region Excel_minimumUnderlyingCalcID_
        private Excel_minimumUnderlyingCalcID excel_minimumUnderlyingCalcID_;
        public Excel_minimumUnderlyingCalcID Excel_minimumUnderlyingCalcID_
        {
            get
            {
                if (this.excel_minimumUnderlyingCalcID_ != null)
                {
                    return this.excel_minimumUnderlyingCalcID_; 
                }
                else if (this.excel_minimumUnderlyingCalcIDIDRef_ != null)
                {
                    excel_minimumUnderlyingCalcID_ = IDManager.getID(excel_minimumUnderlyingCalcIDIDRef_) as Excel_minimumUnderlyingCalcID;
                    return this.excel_minimumUnderlyingCalcID_; 
                }
                else
                {
                    throw new Exception( "excel_minimumUnderlyingCalcID_Node no exist!");
                }
            }
            set
            {
                if (this.excel_minimumUnderlyingCalcID_ != value)
                {
                    this.excel_minimumUnderlyingCalcID_ = value;
                }
            }
        }
        #endregion
        
        public string excel_minimumUnderlyingCalcIDIDRef_ { get; set; }
        #region Excel_averageUnderlyingCalcID_
        private Excel_averageUnderlyingCalcID excel_averageUnderlyingCalcID_;
        public Excel_averageUnderlyingCalcID Excel_averageUnderlyingCalcID_
        {
            get
            {
                if (this.excel_averageUnderlyingCalcID_ != null)
                {
                    return this.excel_averageUnderlyingCalcID_; 
                }
                else if (this.excel_averageUnderlyingCalcIDIDRef_ != null)
                {
                    excel_averageUnderlyingCalcID_ = IDManager.getID(excel_averageUnderlyingCalcIDIDRef_) as Excel_averageUnderlyingCalcID;
                    return this.excel_averageUnderlyingCalcID_; 
                }
                else
                {
                    throw new Exception( "excel_averageUnderlyingCalcID_Node no exist!");
                }
            }
            set
            {
                if (this.excel_averageUnderlyingCalcID_ != value)
                {
                    this.excel_averageUnderlyingCalcID_ = value;
                }
            }
        }
        #endregion
        
        public string excel_averageUnderlyingCalcIDIDRef_ { get; set; }
        #region Excel_orderUnderlyingCalcID_
        private Excel_orderUnderlyingCalcID excel_orderUnderlyingCalcID_;
        public Excel_orderUnderlyingCalcID Excel_orderUnderlyingCalcID_
        {
            get
            {
                if (this.excel_orderUnderlyingCalcID_ != null)
                {
                    return this.excel_orderUnderlyingCalcID_; 
                }
                else if (this.excel_orderUnderlyingCalcIDIDRef_ != null)
                {
                    excel_orderUnderlyingCalcID_ = IDManager.getID(excel_orderUnderlyingCalcIDIDRef_) as Excel_orderUnderlyingCalcID;
                    return this.excel_orderUnderlyingCalcID_; 
                }
                else
                {
                    throw new Exception( "excel_orderUnderlyingCalcID_Node no exist!");
                }
            }
            set
            {
                if (this.excel_orderUnderlyingCalcID_ != value)
                {
                    this.excel_orderUnderlyingCalcID_ = value;
                }
            }
        }
        #endregion
        
        public string excel_orderUnderlyingCalcIDIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

