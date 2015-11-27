using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Operator1DList : ISerialized
    {
        public Operator1DList() { }
        public Operator1DList(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList operator1DNodeList = xmlNode.SelectNodes("operator1D");
            
            if (operator1DNodeList != null)
            {
                this.operator1D_ = new List<Operator1D>();
                foreach (XmlNode item in operator1DNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            operator1DIDRef_ = item.Attributes["id"].Value;
                            operator1D_.Add(new Operator1D(item));
                            IDManager.SetID(operator1DIDRef_, operator1D_[operator1D_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            operator1DIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        operator1D_.Add(new Operator1D(item));
                        }
                    }
                    else
                    {
                        operator1D_.Add(new Operator1D(item));
                    }
                }
            }
            
        
        }
        
    
        #region Operator1D_
        private List<Operator1D> operator1D_;
        public List<Operator1D> Operator1D_
        {
            get
            {
                if (this.operator1D_ != null)
                {
                    return this.operator1D_; 
                }
                else if (this.operator1DIDRef_ != null)
                {
                    return this.operator1D_; 
                }
                else
                {
                    throw new Exception( "operator1D_Node no exist!");
                }
            }
            set
            {
                if (this.operator1D_ != value)
                {
                    this.operator1D_ = value;
                }
            }
        }
        #endregion
        
        public string operator1DIDRef_ { get; set; }
        
    
        
    
    }
    
}

