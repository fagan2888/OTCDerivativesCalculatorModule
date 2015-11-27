using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class InstrumentList : ISerialized
    {
        public InstrumentList() { }
        public InstrumentList(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList instHirachyInfoNodeList = xmlNode.SelectNodes("instHirachyInfo");
            
            if (instHirachyInfoNodeList != null)
            {
                this.instHirachyInfo_ = new List<InstHirachyInfo>();
                foreach (XmlNode item in instHirachyInfoNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            instHirachyInfoIDRef_ = item.Attributes["id"].Value;
                            instHirachyInfo_.Add(new InstHirachyInfo(item));
                            IDManager.SetID(instHirachyInfoIDRef_, instHirachyInfo_[instHirachyInfo_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            instHirachyInfoIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        instHirachyInfo_.Add(new InstHirachyInfo(item));
                        }
                    }
                    else
                    {
                        instHirachyInfo_.Add(new InstHirachyInfo(item));
                    }
                }
            }
            
        
        }
        
    
        #region InstHirachyInfo_
        private List<InstHirachyInfo> instHirachyInfo_;
        public List<InstHirachyInfo> InstHirachyInfo_
        {
            get
            {
                if (this.instHirachyInfo_ != null)
                {
                    return this.instHirachyInfo_; 
                }
                else if (this.instHirachyInfoIDRef_ != null)
                {
                    return this.instHirachyInfo_; 
                }
                else
                {
                    throw new Exception( "instHirachyInfo_Node no exist!");
                }
            }
            set
            {
                if (this.instHirachyInfo_ != value)
                {
                    this.instHirachyInfo_ = value;
                }
            }
        }
        #endregion
        
        public string instHirachyInfoIDRef_ { get; set; }
        
    
        
    
    }
    
}

