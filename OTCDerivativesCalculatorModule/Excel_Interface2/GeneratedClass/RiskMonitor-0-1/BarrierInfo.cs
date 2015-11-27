using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class BarrierInfo : ISerialized
    {
        public BarrierInfo() { }
        public BarrierInfo(XmlNode xmlNode)
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
            
        
            XmlNode constDualBarrierInfoNode = xmlNode.SelectSingleNode("constDualBarrierInfo");
            
            if (constDualBarrierInfoNode != null)
            {
                if (constDualBarrierInfoNode.Attributes["href"] != null || constDualBarrierInfoNode.Attributes["id"] != null) 
                {
                    if (constDualBarrierInfoNode.Attributes["id"] != null) 
                    {
                        constDualBarrierInfoIDRef_ = constDualBarrierInfoNode.Attributes["id"].Value;
                        ConstDualBarrierInfo ob = new ConstDualBarrierInfo(constDualBarrierInfoNode);
                        IDManager.SetID(constDualBarrierInfoIDRef_, ob);
                    }
                    else if (constDualBarrierInfoNode.Attributes["href"] != null)
                    {
                        constDualBarrierInfoIDRef_ = constDualBarrierInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        constDualBarrierInfo_ = new ConstDualBarrierInfo(constDualBarrierInfoNode);
                    }
                }
                else
                {
                    constDualBarrierInfo_ = new ConstDualBarrierInfo(constDualBarrierInfoNode);
                }
            }
            
        
            XmlNode constLowerBarrierInfoNode = xmlNode.SelectSingleNode("constLowerBarrierInfo");
            
            if (constLowerBarrierInfoNode != null)
            {
                if (constLowerBarrierInfoNode.Attributes["href"] != null || constLowerBarrierInfoNode.Attributes["id"] != null) 
                {
                    if (constLowerBarrierInfoNode.Attributes["id"] != null) 
                    {
                        constLowerBarrierInfoIDRef_ = constLowerBarrierInfoNode.Attributes["id"].Value;
                        ConstLowerBarrierInfo ob = new ConstLowerBarrierInfo(constLowerBarrierInfoNode);
                        IDManager.SetID(constLowerBarrierInfoIDRef_, ob);
                    }
                    else if (constLowerBarrierInfoNode.Attributes["href"] != null)
                    {
                        constLowerBarrierInfoIDRef_ = constLowerBarrierInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        constLowerBarrierInfo_ = new ConstLowerBarrierInfo(constLowerBarrierInfoNode);
                    }
                }
                else
                {
                    constLowerBarrierInfo_ = new ConstLowerBarrierInfo(constLowerBarrierInfoNode);
                }
            }
            
        
            XmlNode constUpperBarrierInfoNode = xmlNode.SelectSingleNode("constUpperBarrierInfo");
            
            if (constUpperBarrierInfoNode != null)
            {
                if (constUpperBarrierInfoNode.Attributes["href"] != null || constUpperBarrierInfoNode.Attributes["id"] != null) 
                {
                    if (constUpperBarrierInfoNode.Attributes["id"] != null) 
                    {
                        constUpperBarrierInfoIDRef_ = constUpperBarrierInfoNode.Attributes["id"].Value;
                        ConstUpperBarrierInfo ob = new ConstUpperBarrierInfo(constUpperBarrierInfoNode);
                        IDManager.SetID(constUpperBarrierInfoIDRef_, ob);
                    }
                    else if (constUpperBarrierInfoNode.Attributes["href"] != null)
                    {
                        constUpperBarrierInfoIDRef_ = constUpperBarrierInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        constUpperBarrierInfo_ = new ConstUpperBarrierInfo(constUpperBarrierInfoNode);
                    }
                }
                else
                {
                    constUpperBarrierInfo_ = new ConstUpperBarrierInfo(constUpperBarrierInfoNode);
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
        #region ConstDualBarrierInfo_
        private ConstDualBarrierInfo constDualBarrierInfo_;
        public ConstDualBarrierInfo ConstDualBarrierInfo_
        {
            get
            {
                if (this.constDualBarrierInfo_ != null)
                {
                    return this.constDualBarrierInfo_; 
                }
                else if (this.constDualBarrierInfoIDRef_ != null)
                {
                    constDualBarrierInfo_ = IDManager.getID(constDualBarrierInfoIDRef_) as ConstDualBarrierInfo;
                    return this.constDualBarrierInfo_; 
                }
                else
                {
                    throw new Exception( "constDualBarrierInfo_Node no exist!");
                }
            }
            set
            {
                if (this.constDualBarrierInfo_ != value)
                {
                    this.constDualBarrierInfo_ = value;
                }
            }
        }
        #endregion
        
        public string constDualBarrierInfoIDRef_ { get; set; }
        #region ConstLowerBarrierInfo_
        private ConstLowerBarrierInfo constLowerBarrierInfo_;
        public ConstLowerBarrierInfo ConstLowerBarrierInfo_
        {
            get
            {
                if (this.constLowerBarrierInfo_ != null)
                {
                    return this.constLowerBarrierInfo_; 
                }
                else if (this.constLowerBarrierInfoIDRef_ != null)
                {
                    constLowerBarrierInfo_ = IDManager.getID(constLowerBarrierInfoIDRef_) as ConstLowerBarrierInfo;
                    return this.constLowerBarrierInfo_; 
                }
                else
                {
                    throw new Exception( "constLowerBarrierInfo_Node no exist!");
                }
            }
            set
            {
                if (this.constLowerBarrierInfo_ != value)
                {
                    this.constLowerBarrierInfo_ = value;
                }
            }
        }
        #endregion
        
        public string constLowerBarrierInfoIDRef_ { get; set; }
        #region ConstUpperBarrierInfo_
        private ConstUpperBarrierInfo constUpperBarrierInfo_;
        public ConstUpperBarrierInfo ConstUpperBarrierInfo_
        {
            get
            {
                if (this.constUpperBarrierInfo_ != null)
                {
                    return this.constUpperBarrierInfo_; 
                }
                else if (this.constUpperBarrierInfoIDRef_ != null)
                {
                    constUpperBarrierInfo_ = IDManager.getID(constUpperBarrierInfoIDRef_) as ConstUpperBarrierInfo;
                    return this.constUpperBarrierInfo_; 
                }
                else
                {
                    throw new Exception( "constUpperBarrierInfo_Node no exist!");
                }
            }
            set
            {
                if (this.constUpperBarrierInfo_ != value)
                {
                    this.constUpperBarrierInfo_ = value;
                }
            }
        }
        #endregion
        
        public string constUpperBarrierInfoIDRef_ { get; set; }
        public string choiceStr_barrierType;
        
    
        
    
    }
    
}

