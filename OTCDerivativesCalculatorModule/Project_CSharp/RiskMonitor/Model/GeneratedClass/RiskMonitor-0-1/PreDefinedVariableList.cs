using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PreDefinedVariableList : ISerialized
    {
        public PreDefinedVariableList() { }
        public PreDefinedVariableList(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList preDefinedVariableInfoNodeList = xmlNode.SelectNodes("preDefinedVariableInfo");
            
            if (preDefinedVariableInfoNodeList != null)
            {
                this.preDefinedVariableInfo_ = new List<PreDefinedVariableInfo>();
                foreach (XmlNode item in preDefinedVariableInfoNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            preDefinedVariableInfoIDRef_ = item.Attributes["id"].Value;
                            preDefinedVariableInfo_.Add(new PreDefinedVariableInfo(item));
                            IDManager.SetID(preDefinedVariableInfoIDRef_, preDefinedVariableInfo_[preDefinedVariableInfo_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            preDefinedVariableInfoIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        preDefinedVariableInfo_.Add(new PreDefinedVariableInfo(item));
                        }
                    }
                    else
                    {
                        preDefinedVariableInfo_.Add(new PreDefinedVariableInfo(item));
                    }
                }
            }
            
        
        }
        
    
        #region PreDefinedVariableInfo_
        private List<PreDefinedVariableInfo> preDefinedVariableInfo_;
        public List<PreDefinedVariableInfo> PreDefinedVariableInfo_
        {
            get
            {
                if (this.preDefinedVariableInfo_ != null)
                {
                    return this.preDefinedVariableInfo_; 
                }
                else if (this.preDefinedVariableInfoIDRef_ != null)
                {
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
        
    
        
    
    }
    
}

