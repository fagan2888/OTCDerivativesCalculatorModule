using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class VariableInfo : ISerialized
    {
        public VariableInfo() { }
        public VariableInfo(XmlNode xmlNode)
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
            
        
            XmlNode nullVariableInfoNode = xmlNode.SelectSingleNode("nullVariableInfo");
            
            if (nullVariableInfoNode != null)
            {
                if (nullVariableInfoNode.Attributes["href"] != null || nullVariableInfoNode.Attributes["id"] != null) 
                {
                    if (nullVariableInfoNode.Attributes["id"] != null) 
                    {
                        nullVariableInfoIDRef_ = nullVariableInfoNode.Attributes["id"].Value;
                        NullVariableInfo ob = new NullVariableInfo(nullVariableInfoNode);
                        IDManager.SetID(nullVariableInfoIDRef_, ob);
                    }
                    else if (nullVariableInfoNode.Attributes["href"] != null)
                    {
                        nullVariableInfoIDRef_ = nullVariableInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        nullVariableInfo_ = new NullVariableInfo(nullVariableInfoNode);
                    }
                }
                else
                {
                    nullVariableInfo_ = new NullVariableInfo(nullVariableInfoNode);
                }
            }
            
        
            XmlNode overWriteVariableInfoNode = xmlNode.SelectSingleNode("overWriteVariableInfo");
            
            if (overWriteVariableInfoNode != null)
            {
                if (overWriteVariableInfoNode.Attributes["href"] != null || overWriteVariableInfoNode.Attributes["id"] != null) 
                {
                    if (overWriteVariableInfoNode.Attributes["id"] != null) 
                    {
                        overWriteVariableInfoIDRef_ = overWriteVariableInfoNode.Attributes["id"].Value;
                        OverWriteVariableInfo ob = new OverWriteVariableInfo(overWriteVariableInfoNode);
                        IDManager.SetID(overWriteVariableInfoIDRef_, ob);
                    }
                    else if (overWriteVariableInfoNode.Attributes["href"] != null)
                    {
                        overWriteVariableInfoIDRef_ = overWriteVariableInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        overWriteVariableInfo_ = new OverWriteVariableInfo(overWriteVariableInfoNode);
                    }
                }
                else
                {
                    overWriteVariableInfo_ = new OverWriteVariableInfo(overWriteVariableInfoNode);
                }
            }
            
        
            XmlNode additionVariableInfoNode = xmlNode.SelectSingleNode("additionVariableInfo");
            
            if (additionVariableInfoNode != null)
            {
                if (additionVariableInfoNode.Attributes["href"] != null || additionVariableInfoNode.Attributes["id"] != null) 
                {
                    if (additionVariableInfoNode.Attributes["id"] != null) 
                    {
                        additionVariableInfoIDRef_ = additionVariableInfoNode.Attributes["id"].Value;
                        AdditionVariableInfo ob = new AdditionVariableInfo(additionVariableInfoNode);
                        IDManager.SetID(additionVariableInfoIDRef_, ob);
                    }
                    else if (additionVariableInfoNode.Attributes["href"] != null)
                    {
                        additionVariableInfoIDRef_ = additionVariableInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        additionVariableInfo_ = new AdditionVariableInfo(additionVariableInfoNode);
                    }
                }
                else
                {
                    additionVariableInfo_ = new AdditionVariableInfo(additionVariableInfoNode);
                }
            }
            
        
            XmlNode preDefinedVariableInfoNode = xmlNode.SelectSingleNode("preDefinedVariableInfo");
            
            if (preDefinedVariableInfoNode != null)
            {
                if (preDefinedVariableInfoNode.Attributes["href"] != null || preDefinedVariableInfoNode.Attributes["id"] != null) 
                {
                    if (preDefinedVariableInfoNode.Attributes["id"] != null) 
                    {
                        preDefinedVariableInfoIDRef_ = preDefinedVariableInfoNode.Attributes["id"].Value;
                        PreDefinedVariableInfo ob = new PreDefinedVariableInfo(preDefinedVariableInfoNode);
                        IDManager.SetID(preDefinedVariableInfoIDRef_, ob);
                    }
                    else if (preDefinedVariableInfoNode.Attributes["href"] != null)
                    {
                        preDefinedVariableInfoIDRef_ = preDefinedVariableInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        preDefinedVariableInfo_ = new PreDefinedVariableInfo(preDefinedVariableInfoNode);
                    }
                }
                else
                {
                    preDefinedVariableInfo_ = new PreDefinedVariableInfo(preDefinedVariableInfoNode);
                }
            }
            
        
            XmlNode definedVariableInfoNode = xmlNode.SelectSingleNode("definedVariableInfo");
            
            if (definedVariableInfoNode != null)
            {
                if (definedVariableInfoNode.Attributes["href"] != null || definedVariableInfoNode.Attributes["id"] != null) 
                {
                    if (definedVariableInfoNode.Attributes["id"] != null) 
                    {
                        definedVariableInfoIDRef_ = definedVariableInfoNode.Attributes["id"].Value;
                        DefinedVariableInfo ob = new DefinedVariableInfo(definedVariableInfoNode);
                        IDManager.SetID(definedVariableInfoIDRef_, ob);
                    }
                    else if (definedVariableInfoNode.Attributes["href"] != null)
                    {
                        definedVariableInfoIDRef_ = definedVariableInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        definedVariableInfo_ = new DefinedVariableInfo(definedVariableInfoNode);
                    }
                }
                else
                {
                    definedVariableInfo_ = new DefinedVariableInfo(definedVariableInfoNode);
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
        #region NullVariableInfo_
        private NullVariableInfo nullVariableInfo_;
        public NullVariableInfo NullVariableInfo_
        {
            get
            {
                if (this.nullVariableInfo_ != null)
                {
                    return this.nullVariableInfo_; 
                }
                else if (this.nullVariableInfoIDRef_ != null)
                {
                    nullVariableInfo_ = IDManager.getID(nullVariableInfoIDRef_) as NullVariableInfo;
                    return this.nullVariableInfo_; 
                }
                else
                {
                    throw new Exception( "nullVariableInfo_Node no exist!");
                }
            }
            set
            {
                if (this.nullVariableInfo_ != value)
                {
                    this.nullVariableInfo_ = value;
                }
            }
        }
        #endregion
        
        public string nullVariableInfoIDRef_ { get; set; }
        #region OverWriteVariableInfo_
        private OverWriteVariableInfo overWriteVariableInfo_;
        public OverWriteVariableInfo OverWriteVariableInfo_
        {
            get
            {
                if (this.overWriteVariableInfo_ != null)
                {
                    return this.overWriteVariableInfo_; 
                }
                else if (this.overWriteVariableInfoIDRef_ != null)
                {
                    overWriteVariableInfo_ = IDManager.getID(overWriteVariableInfoIDRef_) as OverWriteVariableInfo;
                    return this.overWriteVariableInfo_; 
                }
                else
                {
                    throw new Exception( "overWriteVariableInfo_Node no exist!");
                }
            }
            set
            {
                if (this.overWriteVariableInfo_ != value)
                {
                    this.overWriteVariableInfo_ = value;
                }
            }
        }
        #endregion
        
        public string overWriteVariableInfoIDRef_ { get; set; }
        #region AdditionVariableInfo_
        private AdditionVariableInfo additionVariableInfo_;
        public AdditionVariableInfo AdditionVariableInfo_
        {
            get
            {
                if (this.additionVariableInfo_ != null)
                {
                    return this.additionVariableInfo_; 
                }
                else if (this.additionVariableInfoIDRef_ != null)
                {
                    additionVariableInfo_ = IDManager.getID(additionVariableInfoIDRef_) as AdditionVariableInfo;
                    return this.additionVariableInfo_; 
                }
                else
                {
                    throw new Exception( "additionVariableInfo_Node no exist!");
                }
            }
            set
            {
                if (this.additionVariableInfo_ != value)
                {
                    this.additionVariableInfo_ = value;
                }
            }
        }
        #endregion
        
        public string additionVariableInfoIDRef_ { get; set; }
        #region PreDefinedVariableInfo_
        private PreDefinedVariableInfo preDefinedVariableInfo_;
        public PreDefinedVariableInfo PreDefinedVariableInfo_
        {
            get
            {
                if (this.preDefinedVariableInfo_ != null)
                {
                    return this.preDefinedVariableInfo_; 
                }
                else if (this.preDefinedVariableInfoIDRef_ != null)
                {
                    preDefinedVariableInfo_ = IDManager.getID(preDefinedVariableInfoIDRef_) as PreDefinedVariableInfo;
                    return this.preDefinedVariableInfo_; 
                }
                else
                {
                    throw new Exception( "preDefinedVariableInfo_Node no exist!");
                }
            }
            set
            {
                if (this.preDefinedVariableInfo_ != value)
                {
                    this.preDefinedVariableInfo_ = value;
                }
            }
        }
        #endregion
        
        public string preDefinedVariableInfoIDRef_ { get; set; }
        #region DefinedVariableInfo_
        private DefinedVariableInfo definedVariableInfo_;
        public DefinedVariableInfo DefinedVariableInfo_
        {
            get
            {
                if (this.definedVariableInfo_ != null)
                {
                    return this.definedVariableInfo_; 
                }
                else if (this.definedVariableInfoIDRef_ != null)
                {
                    definedVariableInfo_ = IDManager.getID(definedVariableInfoIDRef_) as DefinedVariableInfo;
                    return this.definedVariableInfo_; 
                }
                else
                {
                    throw new Exception( "definedVariableInfo_Node no exist!");
                }
            }
            set
            {
                if (this.definedVariableInfo_ != value)
                {
                    this.definedVariableInfo_ = value;
                }
            }
        }
        #endregion
        
        public string definedVariableInfoIDRef_ { get; set; }
        public string choiceStr_variableInfoType;
        
    
        
    
    }
    
}

