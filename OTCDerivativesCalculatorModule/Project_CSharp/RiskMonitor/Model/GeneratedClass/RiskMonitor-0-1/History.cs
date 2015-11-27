using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class History : ISerialized
    {
        public History() { }
        public History(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode hisoryDataNode = xmlNode.SelectSingleNode("hisoryData");
            
            if (hisoryDataNode != null)
            {
                if (hisoryDataNode.Attributes["href"] != null || hisoryDataNode.Attributes["id"] != null) 
                {
                    if (hisoryDataNode.Attributes["id"] != null) 
                    {
                        hisoryDataIDRef_ = hisoryDataNode.Attributes["id"].Value;
                        HisoryData ob = new HisoryData(hisoryDataNode);
                        IDManager.SetID(hisoryDataIDRef_, ob);
                    }
                    else if (hisoryDataNode.Attributes["href"] != null)
                    {
                        hisoryDataIDRef_ = hisoryDataNode.Attributes["href"].Value;
                    }
                    else
                    {
                        hisoryData_ = new HisoryData(hisoryDataNode);
                    }
                }
                else
                {
                    hisoryData_ = new HisoryData(hisoryDataNode);
                }
            }
            
        
        }
        
    
        #region HisoryData_
        private HisoryData hisoryData_;
        public HisoryData HisoryData_
        {
            get
            {
                if (this.hisoryData_ != null)
                {
                    return this.hisoryData_; 
                }
                else if (this.hisoryDataIDRef_ != null)
                {
                    hisoryData_ = IDManager.getID(hisoryDataIDRef_) as HisoryData;
                    return this.hisoryData_; 
                }
                else
                {
                    throw new Exception( "hisoryData_Node no exist!");
                }
            }
            set
            {
                if (this.hisoryData_ != value)
                {
                    this.hisoryData_ = value;
                }
            }
        }
        #endregion
        
        public string hisoryDataIDRef_ { get; set; }
        
    
        
    
    }
    
}

