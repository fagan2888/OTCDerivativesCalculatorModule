using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class VariableEventInfo : ISerialized
    {
        public VariableEventInfo() { }
        public VariableEventInfo(XmlNode xmlNode)
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
            
        
            XmlNode nullVariableEventInfoNode = xmlNode.SelectSingleNode("nullVariableEventInfo");
            
            if (nullVariableEventInfoNode != null)
            {
                if (nullVariableEventInfoNode.Attributes["href"] != null || nullVariableEventInfoNode.Attributes["id"] != null) 
                {
                    if (nullVariableEventInfoNode.Attributes["id"] != null) 
                    {
                        nullVariableEventInfoIDRef_ = nullVariableEventInfoNode.Attributes["id"].Value;
                        NullVariableEventInfo ob = new NullVariableEventInfo(nullVariableEventInfoNode);
                        IDManager.SetID(nullVariableEventInfoIDRef_, ob);
                    }
                    else if (nullVariableEventInfoNode.Attributes["href"] != null)
                    {
                        nullVariableEventInfoIDRef_ = nullVariableEventInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        nullVariableEventInfo_ = new NullVariableEventInfo(nullVariableEventInfoNode);
                    }
                }
                else
                {
                    nullVariableEventInfo_ = new NullVariableEventInfo(nullVariableEventInfoNode);
                }
            }
            
        
            XmlNode overWriteVariableEventInfoNode = xmlNode.SelectSingleNode("overWriteVariableEventInfo");
            
            if (overWriteVariableEventInfoNode != null)
            {
                if (overWriteVariableEventInfoNode.Attributes["href"] != null || overWriteVariableEventInfoNode.Attributes["id"] != null) 
                {
                    if (overWriteVariableEventInfoNode.Attributes["id"] != null) 
                    {
                        overWriteVariableEventInfoIDRef_ = overWriteVariableEventInfoNode.Attributes["id"].Value;
                        OverWriteVariableEventInfo ob = new OverWriteVariableEventInfo(overWriteVariableEventInfoNode);
                        IDManager.SetID(overWriteVariableEventInfoIDRef_, ob);
                    }
                    else if (overWriteVariableEventInfoNode.Attributes["href"] != null)
                    {
                        overWriteVariableEventInfoIDRef_ = overWriteVariableEventInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        overWriteVariableEventInfo_ = new OverWriteVariableEventInfo(overWriteVariableEventInfoNode);
                    }
                }
                else
                {
                    overWriteVariableEventInfo_ = new OverWriteVariableEventInfo(overWriteVariableEventInfoNode);
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
        #region NullVariableEventInfo_
        private NullVariableEventInfo nullVariableEventInfo_;
        public NullVariableEventInfo NullVariableEventInfo_
        {
            get
            {
                if (this.nullVariableEventInfo_ != null)
                {
                    return this.nullVariableEventInfo_; 
                }
                else if (this.nullVariableEventInfoIDRef_ != null)
                {
                    nullVariableEventInfo_ = IDManager.getID(nullVariableEventInfoIDRef_) as NullVariableEventInfo;
                    return this.nullVariableEventInfo_; 
                }
                else
                {
                    throw new Exception( "nullVariableEventInfo_Node no exist!");
                }
            }
            set
            {
                if (this.nullVariableEventInfo_ != value)
                {
                    this.nullVariableEventInfo_ = value;
                }
            }
        }
        #endregion
        
        public string nullVariableEventInfoIDRef_ { get; set; }
        #region OverWriteVariableEventInfo_
        private OverWriteVariableEventInfo overWriteVariableEventInfo_;
        public OverWriteVariableEventInfo OverWriteVariableEventInfo_
        {
            get
            {
                if (this.overWriteVariableEventInfo_ != null)
                {
                    return this.overWriteVariableEventInfo_; 
                }
                else if (this.overWriteVariableEventInfoIDRef_ != null)
                {
                    overWriteVariableEventInfo_ = IDManager.getID(overWriteVariableEventInfoIDRef_) as OverWriteVariableEventInfo;
                    return this.overWriteVariableEventInfo_; 
                }
                else
                {
                    throw new Exception( "overWriteVariableEventInfo_Node no exist!");
                }
            }
            set
            {
                if (this.overWriteVariableEventInfo_ != value)
                {
                    this.overWriteVariableEventInfo_ = value;
                }
            }
        }
        #endregion
        
        public string overWriteVariableEventInfoIDRef_ { get; set; }
        public string choiceStr_variableEventInfoType;
        
    
        
    
    }
    
}

