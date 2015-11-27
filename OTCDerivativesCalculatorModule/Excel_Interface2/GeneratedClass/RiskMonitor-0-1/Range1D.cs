using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Range1D : ISerialized
    {
        public Range1D() { }
        public Range1D(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode lowerBoundNode = xmlNode.SelectSingleNode("lowerBound");
            
            if (lowerBoundNode != null)
            {
                if (lowerBoundNode.Attributes["href"] != null || lowerBoundNode.Attributes["id"] != null) 
                {
                    if (lowerBoundNode.Attributes["id"] != null) 
                    {
                        lowerBoundIDRef_ = lowerBoundNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(lowerBoundNode);
                        IDManager.SetID(lowerBoundIDRef_, ob);
                    }
                    else if (lowerBoundNode.Attributes["href"] != null)
                    {
                        lowerBoundIDRef_ = lowerBoundNode.Attributes["href"].Value;
                    }
                    else
                    {
                        lowerBound_ = new XsdTypeDouble(lowerBoundNode);
                    }
                }
                else
                {
                    lowerBound_ = new XsdTypeDouble(lowerBoundNode);
                }
            }
            
        
            XmlNode upperBoundNode = xmlNode.SelectSingleNode("upperBound");
            
            if (upperBoundNode != null)
            {
                if (upperBoundNode.Attributes["href"] != null || upperBoundNode.Attributes["id"] != null) 
                {
                    if (upperBoundNode.Attributes["id"] != null) 
                    {
                        upperBoundIDRef_ = upperBoundNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(upperBoundNode);
                        IDManager.SetID(upperBoundIDRef_, ob);
                    }
                    else if (upperBoundNode.Attributes["href"] != null)
                    {
                        upperBoundIDRef_ = upperBoundNode.Attributes["href"].Value;
                    }
                    else
                    {
                        upperBound_ = new XsdTypeDouble(upperBoundNode);
                    }
                }
                else
                {
                    upperBound_ = new XsdTypeDouble(upperBoundNode);
                }
            }
            
        
            XmlNode lowerBoundEqualityNode = xmlNode.SelectSingleNode("lowerBoundEquality");
            
            if (lowerBoundEqualityNode != null)
            {
                if (lowerBoundEqualityNode.Attributes["href"] != null || lowerBoundEqualityNode.Attributes["id"] != null) 
                {
                    if (lowerBoundEqualityNode.Attributes["id"] != null) 
                    {
                        lowerBoundEqualityIDRef_ = lowerBoundEqualityNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(lowerBoundEqualityNode);
                        IDManager.SetID(lowerBoundEqualityIDRef_, ob);
                    }
                    else if (lowerBoundEqualityNode.Attributes["href"] != null)
                    {
                        lowerBoundEqualityIDRef_ = lowerBoundEqualityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        lowerBoundEquality_ = new XsdTypeDouble(lowerBoundEqualityNode);
                    }
                }
                else
                {
                    lowerBoundEquality_ = new XsdTypeDouble(lowerBoundEqualityNode);
                }
            }
            
        
            XmlNode upperBoundEqualityNode = xmlNode.SelectSingleNode("upperBoundEquality");
            
            if (upperBoundEqualityNode != null)
            {
                if (upperBoundEqualityNode.Attributes["href"] != null || upperBoundEqualityNode.Attributes["id"] != null) 
                {
                    if (upperBoundEqualityNode.Attributes["id"] != null) 
                    {
                        upperBoundEqualityIDRef_ = upperBoundEqualityNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(upperBoundEqualityNode);
                        IDManager.SetID(upperBoundEqualityIDRef_, ob);
                    }
                    else if (upperBoundEqualityNode.Attributes["href"] != null)
                    {
                        upperBoundEqualityIDRef_ = upperBoundEqualityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        upperBoundEquality_ = new XsdTypeDouble(upperBoundEqualityNode);
                    }
                }
                else
                {
                    upperBoundEquality_ = new XsdTypeDouble(upperBoundEqualityNode);
                }
            }
            
        
        }
        
    
        #region LowerBound_
        private XsdTypeDouble lowerBound_;
        public XsdTypeDouble LowerBound_
        {
            get
            {
                if (this.lowerBound_ != null)
                {
                    return this.lowerBound_; 
                }
                else if (this.lowerBoundIDRef_ != null)
                {
                    lowerBound_ = IDManager.getID(lowerBoundIDRef_) as XsdTypeDouble;
                    return this.lowerBound_; 
                }
                else
                {
                    throw new Exception( "lowerBound_Node no exist!");
                }
            }
            set
            {
                if (this.lowerBound_ != value)
                {
                    this.lowerBound_ = value;
                }
            }
        }
        #endregion
        
        public string lowerBoundIDRef_ { get; set; }
        #region UpperBound_
        private XsdTypeDouble upperBound_;
        public XsdTypeDouble UpperBound_
        {
            get
            {
                if (this.upperBound_ != null)
                {
                    return this.upperBound_; 
                }
                else if (this.upperBoundIDRef_ != null)
                {
                    upperBound_ = IDManager.getID(upperBoundIDRef_) as XsdTypeDouble;
                    return this.upperBound_; 
                }
                else
                {
                    throw new Exception( "upperBound_Node no exist!");
                }
            }
            set
            {
                if (this.upperBound_ != value)
                {
                    this.upperBound_ = value;
                }
            }
        }
        #endregion
        
        public string upperBoundIDRef_ { get; set; }
        #region LowerBoundEquality_
        private XsdTypeDouble lowerBoundEquality_;
        public XsdTypeDouble LowerBoundEquality_
        {
            get
            {
                if (this.lowerBoundEquality_ != null)
                {
                    return this.lowerBoundEquality_; 
                }
                else if (this.lowerBoundEqualityIDRef_ != null)
                {
                    lowerBoundEquality_ = IDManager.getID(lowerBoundEqualityIDRef_) as XsdTypeDouble;
                    return this.lowerBoundEquality_; 
                }
                else
                {
                    throw new Exception( "lowerBoundEquality_Node no exist!");
                }
            }
            set
            {
                if (this.lowerBoundEquality_ != value)
                {
                    this.lowerBoundEquality_ = value;
                }
            }
        }
        #endregion
        
        public string lowerBoundEqualityIDRef_ { get; set; }
        #region UpperBoundEquality_
        private XsdTypeDouble upperBoundEquality_;
        public XsdTypeDouble UpperBoundEquality_
        {
            get
            {
                if (this.upperBoundEquality_ != null)
                {
                    return this.upperBoundEquality_; 
                }
                else if (this.upperBoundEqualityIDRef_ != null)
                {
                    upperBoundEquality_ = IDManager.getID(upperBoundEqualityIDRef_) as XsdTypeDouble;
                    return this.upperBoundEquality_; 
                }
                else
                {
                    throw new Exception( "upperBoundEquality_Node no exist!");
                }
            }
            set
            {
                if (this.upperBoundEquality_ != value)
                {
                    this.upperBoundEquality_ = value;
                }
            }
        }
        #endregion
        
        public string upperBoundEqualityIDRef_ { get; set; }
        
    
        
    
    }
    
}

