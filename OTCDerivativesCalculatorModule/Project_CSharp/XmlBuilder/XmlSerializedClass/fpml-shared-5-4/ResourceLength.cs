using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ResourceLength : ISerialized
    {
        public ResourceLength(XmlNode xmlNode)
        {
            XmlNode lengthUnitNode = xmlNode.SelectSingleNode("lengthUnit");
            
            if (lengthUnitNode != null)
            {
                if (lengthUnitNode.Attributes["href"] != null || lengthUnitNode.Attributes["id"] != null) 
                {
                    if (lengthUnitNode.Attributes["id"] != null) 
                    {
                        lengthUnitIDRef_ = lengthUnitNode.Attributes["id"].Value;
                        LengthUnitEnum ob = new LengthUnitEnum(lengthUnitNode);
                        IDManager.SetID(lengthUnitIDRef_, ob);
                    }
                    else if (lengthUnitNode.Attributes["href"] != null)
                    {
                        lengthUnitIDRef_ = lengthUnitNode.Attributes["href"].Value;
                    }
                    else
                    {
                        lengthUnit_ = new LengthUnitEnum(lengthUnitNode);
                    }
                }
                else
                {
                    lengthUnit_ = new LengthUnitEnum(lengthUnitNode);
                }
            }
            
        
            XmlNode lengthValueNode = xmlNode.SelectSingleNode("lengthValue");
            
            if (lengthValueNode != null)
            {
                if (lengthValueNode.Attributes["href"] != null || lengthValueNode.Attributes["id"] != null) 
                {
                    if (lengthValueNode.Attributes["id"] != null) 
                    {
                        lengthValueIDRef_ = lengthValueNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(lengthValueNode);
                        IDManager.SetID(lengthValueIDRef_, ob);
                    }
                    else if (lengthValueNode.Attributes["href"] != null)
                    {
                        lengthValueIDRef_ = lengthValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        lengthValue_ = new XsdTypeDecimal(lengthValueNode);
                    }
                }
                else
                {
                    lengthValue_ = new XsdTypeDecimal(lengthValueNode);
                }
            }
            
        
        }
        
    
        #region LengthUnit_
        private LengthUnitEnum lengthUnit_;
        public LengthUnitEnum LengthUnit_
        {
            get
            {
                if (this.lengthUnit_ != null)
                {
                    return this.lengthUnit_; 
                }
                else if (this.lengthUnitIDRef_ != null)
                {
                    lengthUnit_ = IDManager.getID(lengthUnitIDRef_) as LengthUnitEnum;
                    return this.lengthUnit_; 
                }
                else
                {
                      return this.lengthUnit_; 
                }
            }
            set
            {
                if (this.lengthUnit_ != value)
                {
                    this.lengthUnit_ = value;
                }
            }
        }
        #endregion
        
        public string lengthUnitIDRef_ { get; set; }
        #region LengthValue_
        private XsdTypeDecimal lengthValue_;
        public XsdTypeDecimal LengthValue_
        {
            get
            {
                if (this.lengthValue_ != null)
                {
                    return this.lengthValue_; 
                }
                else if (this.lengthValueIDRef_ != null)
                {
                    lengthValue_ = IDManager.getID(lengthValueIDRef_) as XsdTypeDecimal;
                    return this.lengthValue_; 
                }
                else
                {
                      return this.lengthValue_; 
                }
            }
            set
            {
                if (this.lengthValue_ != value)
                {
                    this.lengthValue_ = value;
                }
            }
        }
        #endregion
        
        public string lengthValueIDRef_ { get; set; }
        
    
        
    
    }
    
}

