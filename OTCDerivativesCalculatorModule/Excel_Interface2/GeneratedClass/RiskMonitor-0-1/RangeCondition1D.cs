using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class RangeCondition1D : ISerialized
    {
        public RangeCondition1D() { }
        public RangeCondition1D(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode range1DNode = xmlNode.SelectSingleNode("range1D");
            
            if (range1DNode != null)
            {
                if (range1DNode.Attributes["href"] != null || range1DNode.Attributes["id"] != null) 
                {
                    if (range1DNode.Attributes["id"] != null) 
                    {
                        range1DIDRef_ = range1DNode.Attributes["id"].Value;
                        Range1D ob = new Range1D(range1DNode);
                        IDManager.SetID(range1DIDRef_, ob);
                    }
                    else if (range1DNode.Attributes["href"] != null)
                    {
                        range1DIDRef_ = range1DNode.Attributes["href"].Value;
                    }
                    else
                    {
                        range1D_ = new Range1D(range1DNode);
                    }
                }
                else
                {
                    range1D_ = new Range1D(range1DNode);
                }
            }
            
        
            XmlNode constValueNode = xmlNode.SelectSingleNode("constValue");
            
            if (constValueNode != null)
            {
                if (constValueNode.Attributes["href"] != null || constValueNode.Attributes["id"] != null) 
                {
                    if (constValueNode.Attributes["id"] != null) 
                    {
                        constValueIDRef_ = constValueNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(constValueNode);
                        IDManager.SetID(constValueIDRef_, ob);
                    }
                    else if (constValueNode.Attributes["href"] != null)
                    {
                        constValueIDRef_ = constValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        constValue_ = new XsdTypeToken(constValueNode);
                    }
                }
                else
                {
                    constValue_ = new XsdTypeToken(constValueNode);
                }
            }
            
        
            XmlNode refNameNode = xmlNode.SelectSingleNode("refName");
            
            if (refNameNode != null)
            {
                if (refNameNode.Attributes["href"] != null || refNameNode.Attributes["id"] != null) 
                {
                    if (refNameNode.Attributes["id"] != null) 
                    {
                        refNameIDRef_ = refNameNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(refNameNode);
                        IDManager.SetID(refNameIDRef_, ob);
                    }
                    else if (refNameNode.Attributes["href"] != null)
                    {
                        refNameIDRef_ = refNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        refName_ = new XsdTypeToken(refNameNode);
                    }
                }
                else
                {
                    refName_ = new XsdTypeToken(refNameNode);
                }
            }
            
        
        }
        
    
        #region Range1D_
        private Range1D range1D_;
        public Range1D Range1D_
        {
            get
            {
                if (this.range1D_ != null)
                {
                    return this.range1D_; 
                }
                else if (this.range1DIDRef_ != null)
                {
                    range1D_ = IDManager.getID(range1DIDRef_) as Range1D;
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
        #region ConstValue_
        private XsdTypeToken constValue_;
        public XsdTypeToken ConstValue_
        {
            get
            {
                if (this.constValue_ != null)
                {
                    return this.constValue_; 
                }
                else if (this.constValueIDRef_ != null)
                {
                    constValue_ = IDManager.getID(constValueIDRef_) as XsdTypeToken;
                    return this.constValue_; 
                }
                else
                {
                    throw new Exception( "constValue_Node no exist!");
                }
            }
            set
            {
                if (this.constValue_ != value)
                {
                    this.constValue_ = value;
                }
            }
        }
        #endregion
        
        public string constValueIDRef_ { get; set; }
        #region RefName_
        private XsdTypeToken refName_;
        public XsdTypeToken RefName_
        {
            get
            {
                if (this.refName_ != null)
                {
                    return this.refName_; 
                }
                else if (this.refNameIDRef_ != null)
                {
                    refName_ = IDManager.getID(refNameIDRef_) as XsdTypeToken;
                    return this.refName_; 
                }
                else
                {
                    throw new Exception( "refName_Node no exist!");
                }
            }
            set
            {
                if (this.refName_ != value)
                {
                    this.refName_ = value;
                }
            }
        }
        #endregion
        
        public string refNameIDRef_ { get; set; }
        
    
        
    
    }
    
}

