using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_hestonModel : ISerialized
    {
        public Excel_hestonModel() { }
        public Excel_hestonModel(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode currentValueNode = xmlNode.SelectSingleNode("currentValue");
            
            if (currentValueNode != null)
            {
                if (currentValueNode.Attributes["href"] != null || currentValueNode.Attributes["id"] != null) 
                {
                    if (currentValueNode.Attributes["id"] != null) 
                    {
                        currentValueIDRef_ = currentValueNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(currentValueNode);
                        IDManager.SetID(currentValueIDRef_, ob);
                    }
                    else if (currentValueNode.Attributes["href"] != null)
                    {
                        currentValueIDRef_ = currentValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        currentValue_ = new XsdTypeToken(currentValueNode);
                    }
                }
                else
                {
                    currentValue_ = new XsdTypeToken(currentValueNode);
                }
            }
            
        
            XmlNode vba_descriptionNode = xmlNode.SelectSingleNode("vba_description");
            
            if (vba_descriptionNode != null)
            {
                if (vba_descriptionNode.Attributes["href"] != null || vba_descriptionNode.Attributes["id"] != null) 
                {
                    if (vba_descriptionNode.Attributes["id"] != null) 
                    {
                        vba_descriptionIDRef_ = vba_descriptionNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(vba_descriptionNode);
                        IDManager.SetID(vba_descriptionIDRef_, ob);
                    }
                    else if (vba_descriptionNode.Attributes["href"] != null)
                    {
                        vba_descriptionIDRef_ = vba_descriptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        vba_description_ = new XsdTypeToken(vba_descriptionNode);
                    }
                }
                else
                {
                    vba_description_ = new XsdTypeToken(vba_descriptionNode);
                }
            }
            
        
        }
        
    
        #region CurrentValue_
        private XsdTypeToken currentValue_;
        public XsdTypeToken CurrentValue_
        {
            get
            {
                if (this.currentValue_ != null)
                {
                    return this.currentValue_; 
                }
                else if (this.currentValueIDRef_ != null)
                {
                    currentValue_ = IDManager.getID(currentValueIDRef_) as XsdTypeToken;
                    return this.currentValue_; 
                }
                else
                {
                    throw new Exception( "currentValue_Node no exist!");
                }
            }
            set
            {
                if (this.currentValue_ != value)
                {
                    this.currentValue_ = value;
                }
            }
        }
        #endregion
        
        public string currentValueIDRef_ { get; set; }
        #region Vba_description_
        private XsdTypeToken vba_description_;
        public XsdTypeToken Vba_description_
        {
            get
            {
                if (this.vba_description_ != null)
                {
                    return this.vba_description_; 
                }
                else if (this.vba_descriptionIDRef_ != null)
                {
                    vba_description_ = IDManager.getID(vba_descriptionIDRef_) as XsdTypeToken;
                    return this.vba_description_; 
                }
                else
                {
                    throw new Exception( "vba_description_Node no exist!");
                }
            }
            set
            {
                if (this.vba_description_ != value)
                {
                    this.vba_description_ = value;
                }
            }
        }
        #endregion
        
        public string vba_descriptionIDRef_ { get; set; }
        
    
        
    
    }
    
}

