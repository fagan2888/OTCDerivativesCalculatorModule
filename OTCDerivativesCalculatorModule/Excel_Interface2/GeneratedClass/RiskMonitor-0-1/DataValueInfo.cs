using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class DataValueInfo : ISerialized
    {
        public DataValueInfo() { }
        public DataValueInfo(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList dataValueNodeList = xmlNode.SelectNodes("dataValue");
            
            if (dataValueNodeList != null)
            {
                this.dataValue_ = new List<DataValue>();
                foreach (XmlNode item in dataValueNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            dataValueIDRef_ = item.Attributes["id"].Value;
                            dataValue_.Add(new DataValue(item));
                            IDManager.SetID(dataValueIDRef_, dataValue_[dataValue_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            dataValueIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        dataValue_.Add(new DataValue(item));
                        }
                    }
                    else
                    {
                        dataValue_.Add(new DataValue(item));
                    }
                }
            }
            
        
        }
        
    
        #region DataValue_
        private List<DataValue> dataValue_;
        public List<DataValue> DataValue_
        {
            get
            {
                if (this.dataValue_ != null)
                {
                    return this.dataValue_; 
                }
                else if (this.dataValueIDRef_ != null)
                {
                    return this.dataValue_; 
                }
                else
                {
                    throw new Exception( "dataValue_Node no exist!");
                }
            }
            set
            {
                if (this.dataValue_ != value)
                {
                    this.dataValue_ = value;
                }
            }
        }
        #endregion
        
        public string dataValueIDRef_ { get; set; }
        
    
        
    
    }
    
}

