using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Multi_rangeND : ISerialized
    {
        public Multi_rangeND() { }
        public Multi_rangeND(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode joint_typeNode = xmlNode.SelectSingleNode("joint_type");
            
            if (joint_typeNode != null)
            {
                if (joint_typeNode.Attributes["href"] != null || joint_typeNode.Attributes["id"] != null) 
                {
                    if (joint_typeNode.Attributes["id"] != null) 
                    {
                        joint_typeIDRef_ = joint_typeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(joint_typeNode);
                        IDManager.SetID(joint_typeIDRef_, ob);
                    }
                    else if (joint_typeNode.Attributes["href"] != null)
                    {
                        joint_typeIDRef_ = joint_typeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        joint_type_ = new XsdTypeToken(joint_typeNode);
                    }
                }
                else
                {
                    joint_type_ = new XsdTypeToken(joint_typeNode);
                }
            }
            
        
            XmlNodeList range1DNodeList = xmlNode.SelectNodes("range1D");
            
            if (range1DNodeList != null)
            {
                this.range1D_ = new List<Range1D>();
                foreach (XmlNode item in range1DNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            range1DIDRef_ = item.Attributes["id"].Value;
                            range1D_.Add(new Range1D(item));
                            IDManager.SetID(range1DIDRef_, range1D_[range1D_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            range1DIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        range1D_.Add(new Range1D(item));
                        }
                    }
                    else
                    {
                        range1D_.Add(new Range1D(item));
                    }
                }
            }
            
        
            XmlNodeList excel_underlyingCalcIDNodeList = xmlNode.SelectNodes("excel_underlyingCalcID");
            
            if (excel_underlyingCalcIDNodeList != null)
            {
                this.excel_underlyingCalcID_ = new List<Excel_underlyingCalcID>();
                foreach (XmlNode item in excel_underlyingCalcIDNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            excel_underlyingCalcIDIDRef_ = item.Attributes["id"].Value;
                            excel_underlyingCalcID_.Add(new Excel_underlyingCalcID(item));
                            IDManager.SetID(excel_underlyingCalcIDIDRef_, excel_underlyingCalcID_[excel_underlyingCalcID_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            excel_underlyingCalcIDIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        excel_underlyingCalcID_.Add(new Excel_underlyingCalcID(item));
                        }
                    }
                    else
                    {
                        excel_underlyingCalcID_.Add(new Excel_underlyingCalcID(item));
                    }
                }
            }
            
        
        }
        
    
        #region Joint_type_
        private XsdTypeToken joint_type_;
        public XsdTypeToken Joint_type_
        {
            get
            {
                if (this.joint_type_ != null)
                {
                    return this.joint_type_; 
                }
                else if (this.joint_typeIDRef_ != null)
                {
                    joint_type_ = IDManager.getID(joint_typeIDRef_) as XsdTypeToken;
                    return this.joint_type_; 
                }
                else
                {
                    throw new Exception( "joint_type_Node no exist!");
                }
            }
            set
            {
                if (this.joint_type_ != value)
                {
                    this.joint_type_ = value;
                }
            }
        }
        #endregion
        
        public string joint_typeIDRef_ { get; set; }
        #region Range1D_
        private List<Range1D> range1D_;
        public List<Range1D> Range1D_
        {
            get
            {
                if (this.range1D_ != null)
                {
                    return this.range1D_; 
                }
                else if (this.range1DIDRef_ != null)
                {
                    return this.range1D_; 
                }
                else
                {
                    throw new Exception( "range1D_Node no exist!");
                }
            }
            set
            {
                if (this.range1D_ != value)
                {
                    this.range1D_ = value;
                }
            }
        }
        #endregion
        
        public string range1DIDRef_ { get; set; }
        #region Excel_underlyingCalcID_
        private List<Excel_underlyingCalcID> excel_underlyingCalcID_;
        public List<Excel_underlyingCalcID> Excel_underlyingCalcID_
        {
            get
            {
                if (this.excel_underlyingCalcID_ != null)
                {
                    return this.excel_underlyingCalcID_; 
                }
                else if (this.excel_underlyingCalcIDIDRef_ != null)
                {
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

