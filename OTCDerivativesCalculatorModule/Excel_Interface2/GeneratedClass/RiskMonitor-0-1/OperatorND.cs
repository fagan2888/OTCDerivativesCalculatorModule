using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class OperatorND : ISerialized
    {
        public OperatorND() { }
        public OperatorND(XmlNode xmlNode)
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
            
        
            XmlNode additionOperNDNode = xmlNode.SelectSingleNode("additionOperND");
            
            if (additionOperNDNode != null)
            {
                if (additionOperNDNode.Attributes["href"] != null || additionOperNDNode.Attributes["id"] != null) 
                {
                    if (additionOperNDNode.Attributes["id"] != null) 
                    {
                        additionOperNDIDRef_ = additionOperNDNode.Attributes["id"].Value;
                        AdditionOperND ob = new AdditionOperND(additionOperNDNode);
                        IDManager.SetID(additionOperNDIDRef_, ob);
                    }
                    else if (additionOperNDNode.Attributes["href"] != null)
                    {
                        additionOperNDIDRef_ = additionOperNDNode.Attributes["href"].Value;
                    }
                    else
                    {
                        additionOperND_ = new AdditionOperND(additionOperNDNode);
                    }
                }
                else
                {
                    additionOperND_ = new AdditionOperND(additionOperNDNode);
                }
            }
            
        
            XmlNode multipleOperNDNode = xmlNode.SelectSingleNode("multipleOperND");
            
            if (multipleOperNDNode != null)
            {
                if (multipleOperNDNode.Attributes["href"] != null || multipleOperNDNode.Attributes["id"] != null) 
                {
                    if (multipleOperNDNode.Attributes["id"] != null) 
                    {
                        multipleOperNDIDRef_ = multipleOperNDNode.Attributes["id"].Value;
                        MultipleOperND ob = new MultipleOperND(multipleOperNDNode);
                        IDManager.SetID(multipleOperNDIDRef_, ob);
                    }
                    else if (multipleOperNDNode.Attributes["href"] != null)
                    {
                        multipleOperNDIDRef_ = multipleOperNDNode.Attributes["href"].Value;
                    }
                    else
                    {
                        multipleOperND_ = new MultipleOperND(multipleOperNDNode);
                    }
                }
                else
                {
                    multipleOperND_ = new MultipleOperND(multipleOperNDNode);
                }
            }
            
        
            XmlNode divisionOperNDNode = xmlNode.SelectSingleNode("divisionOperND");
            
            if (divisionOperNDNode != null)
            {
                if (divisionOperNDNode.Attributes["href"] != null || divisionOperNDNode.Attributes["id"] != null) 
                {
                    if (divisionOperNDNode.Attributes["id"] != null) 
                    {
                        divisionOperNDIDRef_ = divisionOperNDNode.Attributes["id"].Value;
                        DivisionOperND ob = new DivisionOperND(divisionOperNDNode);
                        IDManager.SetID(divisionOperNDIDRef_, ob);
                    }
                    else if (divisionOperNDNode.Attributes["href"] != null)
                    {
                        divisionOperNDIDRef_ = divisionOperNDNode.Attributes["href"].Value;
                    }
                    else
                    {
                        divisionOperND_ = new DivisionOperND(divisionOperNDNode);
                    }
                }
                else
                {
                    divisionOperND_ = new DivisionOperND(divisionOperNDNode);
                }
            }
            
        
            XmlNode maximumOperNDNode = xmlNode.SelectSingleNode("maximumOperND");
            
            if (maximumOperNDNode != null)
            {
                if (maximumOperNDNode.Attributes["href"] != null || maximumOperNDNode.Attributes["id"] != null) 
                {
                    if (maximumOperNDNode.Attributes["id"] != null) 
                    {
                        maximumOperNDIDRef_ = maximumOperNDNode.Attributes["id"].Value;
                        MaximumOperND ob = new MaximumOperND(maximumOperNDNode);
                        IDManager.SetID(maximumOperNDIDRef_, ob);
                    }
                    else if (maximumOperNDNode.Attributes["href"] != null)
                    {
                        maximumOperNDIDRef_ = maximumOperNDNode.Attributes["href"].Value;
                    }
                    else
                    {
                        maximumOperND_ = new MaximumOperND(maximumOperNDNode);
                    }
                }
                else
                {
                    maximumOperND_ = new MaximumOperND(maximumOperNDNode);
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
        #region AdditionOperND_
        private AdditionOperND additionOperND_;
        public AdditionOperND AdditionOperND_
        {
            get
            {
                if (this.additionOperND_ != null)
                {
                    return this.additionOperND_; 
                }
                else if (this.additionOperNDIDRef_ != null)
                {
                    additionOperND_ = IDManager.getID(additionOperNDIDRef_) as AdditionOperND;
                    return this.additionOperND_; 
                }
                else
                {
                    throw new Exception( "additionOperND_Node no exist!");
                }
            }
            set
            {
                if (this.additionOperND_ != value)
                {
                    this.additionOperND_ = value;
                }
            }
        }
        #endregion
        
        public string additionOperNDIDRef_ { get; set; }
        #region MultipleOperND_
        private MultipleOperND multipleOperND_;
        public MultipleOperND MultipleOperND_
        {
            get
            {
                if (this.multipleOperND_ != null)
                {
                    return this.multipleOperND_; 
                }
                else if (this.multipleOperNDIDRef_ != null)
                {
                    multipleOperND_ = IDManager.getID(multipleOperNDIDRef_) as MultipleOperND;
                    return this.multipleOperND_; 
                }
                else
                {
                    throw new Exception( "multipleOperND_Node no exist!");
                }
            }
            set
            {
                if (this.multipleOperND_ != value)
                {
                    this.multipleOperND_ = value;
                }
            }
        }
        #endregion
        
        public string multipleOperNDIDRef_ { get; set; }
        #region DivisionOperND_
        private DivisionOperND divisionOperND_;
        public DivisionOperND DivisionOperND_
        {
            get
            {
                if (this.divisionOperND_ != null)
                {
                    return this.divisionOperND_; 
                }
                else if (this.divisionOperNDIDRef_ != null)
                {
                    divisionOperND_ = IDManager.getID(divisionOperNDIDRef_) as DivisionOperND;
                    return this.divisionOperND_; 
                }
                else
                {
                    throw new Exception( "divisionOperND_Node no exist!");
                }
            }
            set
            {
                if (this.divisionOperND_ != value)
                {
                    this.divisionOperND_ = value;
                }
            }
        }
        #endregion
        
        public string divisionOperNDIDRef_ { get; set; }
        #region MaximumOperND_
        private MaximumOperND maximumOperND_;
        public MaximumOperND MaximumOperND_
        {
            get
            {
                if (this.maximumOperND_ != null)
                {
                    return this.maximumOperND_; 
                }
                else if (this.maximumOperNDIDRef_ != null)
                {
                    maximumOperND_ = IDManager.getID(maximumOperNDIDRef_) as MaximumOperND;
                    return this.maximumOperND_; 
                }
                else
                {
                    throw new Exception( "maximumOperND_Node no exist!");
                }
            }
            set
            {
                if (this.maximumOperND_ != value)
                {
                    this.maximumOperND_ = value;
                }
            }
        }
        #endregion
        
        public string maximumOperNDIDRef_ { get; set; }
        public string choiceStr_operatorNDType;
        
    
        
    
    }
    
}

