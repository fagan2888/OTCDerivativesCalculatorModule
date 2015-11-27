using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Operator1D : ISerialized
    {
        public Operator1D() { }
        public Operator1D(XmlNode xmlNode)
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
            
        
            XmlNode additionOper1DNode = xmlNode.SelectSingleNode("additionOper1D");
            
            if (additionOper1DNode != null)
            {
                if (additionOper1DNode.Attributes["href"] != null || additionOper1DNode.Attributes["id"] != null) 
                {
                    if (additionOper1DNode.Attributes["id"] != null) 
                    {
                        additionOper1DIDRef_ = additionOper1DNode.Attributes["id"].Value;
                        AdditionOper1D ob = new AdditionOper1D(additionOper1DNode);
                        IDManager.SetID(additionOper1DIDRef_, ob);
                    }
                    else if (additionOper1DNode.Attributes["href"] != null)
                    {
                        additionOper1DIDRef_ = additionOper1DNode.Attributes["href"].Value;
                    }
                    else
                    {
                        additionOper1D_ = new AdditionOper1D(additionOper1DNode);
                    }
                }
                else
                {
                    additionOper1D_ = new AdditionOper1D(additionOper1DNode);
                }
            }
            
        
            XmlNode multipleOper1DNode = xmlNode.SelectSingleNode("multipleOper1D");
            
            if (multipleOper1DNode != null)
            {
                if (multipleOper1DNode.Attributes["href"] != null || multipleOper1DNode.Attributes["id"] != null) 
                {
                    if (multipleOper1DNode.Attributes["id"] != null) 
                    {
                        multipleOper1DIDRef_ = multipleOper1DNode.Attributes["id"].Value;
                        MultipleOper1D ob = new MultipleOper1D(multipleOper1DNode);
                        IDManager.SetID(multipleOper1DIDRef_, ob);
                    }
                    else if (multipleOper1DNode.Attributes["href"] != null)
                    {
                        multipleOper1DIDRef_ = multipleOper1DNode.Attributes["href"].Value;
                    }
                    else
                    {
                        multipleOper1D_ = new MultipleOper1D(multipleOper1DNode);
                    }
                }
                else
                {
                    multipleOper1D_ = new MultipleOper1D(multipleOper1DNode);
                }
            }
            
        
            XmlNode maximumOper1DNode = xmlNode.SelectSingleNode("maximumOper1D");
            
            if (maximumOper1DNode != null)
            {
                if (maximumOper1DNode.Attributes["href"] != null || maximumOper1DNode.Attributes["id"] != null) 
                {
                    if (maximumOper1DNode.Attributes["id"] != null) 
                    {
                        maximumOper1DIDRef_ = maximumOper1DNode.Attributes["id"].Value;
                        MaximumOper1D ob = new MaximumOper1D(maximumOper1DNode);
                        IDManager.SetID(maximumOper1DIDRef_, ob);
                    }
                    else if (maximumOper1DNode.Attributes["href"] != null)
                    {
                        maximumOper1DIDRef_ = maximumOper1DNode.Attributes["href"].Value;
                    }
                    else
                    {
                        maximumOper1D_ = new MaximumOper1D(maximumOper1DNode);
                    }
                }
                else
                {
                    maximumOper1D_ = new MaximumOper1D(maximumOper1DNode);
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
        #region AdditionOper1D_
        private AdditionOper1D additionOper1D_;
        public AdditionOper1D AdditionOper1D_
        {
            get
            {
                if (this.additionOper1D_ != null)
                {
                    return this.additionOper1D_; 
                }
                else if (this.additionOper1DIDRef_ != null)
                {
                    additionOper1D_ = IDManager.getID(additionOper1DIDRef_) as AdditionOper1D;
                    return this.additionOper1D_; 
                }
                else
                {
                    throw new Exception( "additionOper1D_Node no exist!");
                }
            }
            set
            {
                if (this.additionOper1D_ != value)
                {
                    this.additionOper1D_ = value;
                }
            }
        }
        #endregion
        
        public string additionOper1DIDRef_ { get; set; }
        #region MultipleOper1D_
        private MultipleOper1D multipleOper1D_;
        public MultipleOper1D MultipleOper1D_
        {
            get
            {
                if (this.multipleOper1D_ != null)
                {
                    return this.multipleOper1D_; 
                }
                else if (this.multipleOper1DIDRef_ != null)
                {
                    multipleOper1D_ = IDManager.getID(multipleOper1DIDRef_) as MultipleOper1D;
                    return this.multipleOper1D_; 
                }
                else
                {
                    throw new Exception( "multipleOper1D_Node no exist!");
                }
            }
            set
            {
                if (this.multipleOper1D_ != value)
                {
                    this.multipleOper1D_ = value;
                }
            }
        }
        #endregion
        
        public string multipleOper1DIDRef_ { get; set; }
        #region MaximumOper1D_
        private MaximumOper1D maximumOper1D_;
        public MaximumOper1D MaximumOper1D_
        {
            get
            {
                if (this.maximumOper1D_ != null)
                {
                    return this.maximumOper1D_; 
                }
                else if (this.maximumOper1DIDRef_ != null)
                {
                    maximumOper1D_ = IDManager.getID(maximumOper1DIDRef_) as MaximumOper1D;
                    return this.maximumOper1D_; 
                }
                else
                {
                    throw new Exception( "maximumOper1D_Node no exist!");
                }
            }
            set
            {
                if (this.maximumOper1D_ != value)
                {
                    this.maximumOper1D_ = value;
                }
            }
        }
        #endregion
        
        public string maximumOper1DIDRef_ { get; set; }
        public string choiceStr_operator1DType;
        
    
        
    
    }
    
}

