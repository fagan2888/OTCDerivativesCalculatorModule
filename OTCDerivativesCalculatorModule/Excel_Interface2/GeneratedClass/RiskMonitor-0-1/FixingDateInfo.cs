using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FixingDateInfo : ISerialized
    {
        public FixingDateInfo() { }
        public FixingDateInfo(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode typeNode = xmlNode.SelectSingleNode("type");
            
            if (typeNode != null)
            {
                if (typeNode.Attributes["href"] != null || typeNode.Attributes["id"] != null) 
                {
                    if (typeNode.Attributes["id"] != null) 
                    {
                        typeIDRef_ = typeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(typeNode);
                        IDManager.SetID(typeIDRef_, ob);
                    }
                    else if (typeNode.Attributes["href"] != null)
                    {
                        typeIDRef_ = typeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        type_ = new XsdTypeToken(typeNode);
                    }
                }
                else
                {
                    type_ = new XsdTypeToken(typeNode);
                }
            }
            
        
            XmlNode fixedFixingDateInfoNode = xmlNode.SelectSingleNode("fixedFixingDateInfo");
            
            if (fixedFixingDateInfoNode != null)
            {
                if (fixedFixingDateInfoNode.Attributes["href"] != null || fixedFixingDateInfoNode.Attributes["id"] != null) 
                {
                    if (fixedFixingDateInfoNode.Attributes["id"] != null) 
                    {
                        fixedFixingDateInfoIDRef_ = fixedFixingDateInfoNode.Attributes["id"].Value;
                        FixedFixingDateInfo ob = new FixedFixingDateInfo(fixedFixingDateInfoNode);
                        IDManager.SetID(fixedFixingDateInfoIDRef_, ob);
                    }
                    else if (fixedFixingDateInfoNode.Attributes["href"] != null)
                    {
                        fixedFixingDateInfoIDRef_ = fixedFixingDateInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixedFixingDateInfo_ = new FixedFixingDateInfo(fixedFixingDateInfoNode);
                    }
                }
                else
                {
                    fixedFixingDateInfo_ = new FixedFixingDateInfo(fixedFixingDateInfoNode);
                }
            }
            
        
            XmlNode refVariableFixingDateInfoNode = xmlNode.SelectSingleNode("refVariableFixingDateInfo");
            
            if (refVariableFixingDateInfoNode != null)
            {
                if (refVariableFixingDateInfoNode.Attributes["href"] != null || refVariableFixingDateInfoNode.Attributes["id"] != null) 
                {
                    if (refVariableFixingDateInfoNode.Attributes["id"] != null) 
                    {
                        refVariableFixingDateInfoIDRef_ = refVariableFixingDateInfoNode.Attributes["id"].Value;
                        RefVariableFixingDateInfo ob = new RefVariableFixingDateInfo(refVariableFixingDateInfoNode);
                        IDManager.SetID(refVariableFixingDateInfoIDRef_, ob);
                    }
                    else if (refVariableFixingDateInfoNode.Attributes["href"] != null)
                    {
                        refVariableFixingDateInfoIDRef_ = refVariableFixingDateInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        refVariableFixingDateInfo_ = new RefVariableFixingDateInfo(refVariableFixingDateInfoNode);
                    }
                }
                else
                {
                    refVariableFixingDateInfo_ = new RefVariableFixingDateInfo(refVariableFixingDateInfoNode);
                }
            }
            
        
            XmlNode nullFixingDateInfoNode = xmlNode.SelectSingleNode("nullFixingDateInfo");
            
            if (nullFixingDateInfoNode != null)
            {
                if (nullFixingDateInfoNode.Attributes["href"] != null || nullFixingDateInfoNode.Attributes["id"] != null) 
                {
                    if (nullFixingDateInfoNode.Attributes["id"] != null) 
                    {
                        nullFixingDateInfoIDRef_ = nullFixingDateInfoNode.Attributes["id"].Value;
                        NullFixingDateInfo ob = new NullFixingDateInfo(nullFixingDateInfoNode);
                        IDManager.SetID(nullFixingDateInfoIDRef_, ob);
                    }
                    else if (nullFixingDateInfoNode.Attributes["href"] != null)
                    {
                        nullFixingDateInfoIDRef_ = nullFixingDateInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        nullFixingDateInfo_ = new NullFixingDateInfo(nullFixingDateInfoNode);
                    }
                }
                else
                {
                    nullFixingDateInfo_ = new NullFixingDateInfo(nullFixingDateInfoNode);
                }
            }
            
        
        }
        
    
        #region Type_
        private XsdTypeToken type_;
        public XsdTypeToken Type_
        {
            get
            {
                if (this.type_ != null)
                {
                    return this.type_; 
                }
                else if (this.typeIDRef_ != null)
                {
                    type_ = IDManager.getID(typeIDRef_) as XsdTypeToken;
                    return this.type_; 
                }
                else
                {
                    throw new Exception( "type_Node no exist!");
                }
            }
            set
            {
                if (this.type_ != value)
                {
                    this.type_ = value;
                }
            }
        }
        #endregion
        
        public string typeIDRef_ { get; set; }
        #region FixedFixingDateInfo_
        private FixedFixingDateInfo fixedFixingDateInfo_;
        public FixedFixingDateInfo FixedFixingDateInfo_
        {
            get
            {
                if (this.fixedFixingDateInfo_ != null)
                {
                    return this.fixedFixingDateInfo_; 
                }
                else if (this.fixedFixingDateInfoIDRef_ != null)
                {
                    fixedFixingDateInfo_ = IDManager.getID(fixedFixingDateInfoIDRef_) as FixedFixingDateInfo;
                    return this.fixedFixingDateInfo_; 
                }
                else
                {
                    throw new Exception( "fixedFixingDateInfo_Node no exist!");
                }
            }
            set
            {
                if (this.fixedFixingDateInfo_ != value)
                {
                    this.fixedFixingDateInfo_ = value;
                }
            }
        }
        #endregion
        
        public string fixedFixingDateInfoIDRef_ { get; set; }
        #region RefVariableFixingDateInfo_
        private RefVariableFixingDateInfo refVariableFixingDateInfo_;
        public RefVariableFixingDateInfo RefVariableFixingDateInfo_
        {
            get
            {
                if (this.refVariableFixingDateInfo_ != null)
                {
                    return this.refVariableFixingDateInfo_; 
                }
                else if (this.refVariableFixingDateInfoIDRef_ != null)
                {
                    refVariableFixingDateInfo_ = IDManager.getID(refVariableFixingDateInfoIDRef_) as RefVariableFixingDateInfo;
                    return this.refVariableFixingDateInfo_; 
                }
                else
                {
                    throw new Exception( "refVariableFixingDateInfo_Node no exist!");
                }
            }
            set
            {
                if (this.refVariableFixingDateInfo_ != value)
                {
                    this.refVariableFixingDateInfo_ = value;
                }
            }
        }
        #endregion
        
        public string refVariableFixingDateInfoIDRef_ { get; set; }
        #region NullFixingDateInfo_
        private NullFixingDateInfo nullFixingDateInfo_;
        public NullFixingDateInfo NullFixingDateInfo_
        {
            get
            {
                if (this.nullFixingDateInfo_ != null)
                {
                    return this.nullFixingDateInfo_; 
                }
                else if (this.nullFixingDateInfoIDRef_ != null)
                {
                    nullFixingDateInfo_ = IDManager.getID(nullFixingDateInfoIDRef_) as NullFixingDateInfo;
                    return this.nullFixingDateInfo_; 
                }
                else
                {
                    throw new Exception( "nullFixingDateInfo_Node no exist!");
                }
            }
            set
            {
                if (this.nullFixingDateInfo_ != value)
                {
                    this.nullFixingDateInfo_ = value;
                }
            }
        }
        #endregion
        
        public string nullFixingDateInfoIDRef_ { get; set; }
        public string choiceStr_fixingDateType;
        
    
        
    
    }
    
}

