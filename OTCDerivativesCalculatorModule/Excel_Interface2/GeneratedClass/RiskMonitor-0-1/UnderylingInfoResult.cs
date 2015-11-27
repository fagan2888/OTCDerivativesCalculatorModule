using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class UnderylingInfoResult : ISerialized
    {
        public UnderylingInfoResult() { }
        public UnderylingInfoResult(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList underylingResultNodeList = xmlNode.SelectNodes("underylingResult");
            
            if (underylingResultNodeList != null)
            {
                this.underylingResult_ = new List<UnderylingResult>();
                foreach (XmlNode item in underylingResultNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            underylingResultIDRef_ = item.Attributes["id"].Value;
                            underylingResult_.Add(new UnderylingResult(item));
                            IDManager.SetID(underylingResultIDRef_, underylingResult_[underylingResult_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            underylingResultIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        underylingResult_.Add(new UnderylingResult(item));
                        }
                    }
                    else
                    {
                        underylingResult_.Add(new UnderylingResult(item));
                    }
                }
            }
            
        
        }
        
    
        #region UnderylingResult_
        private List<UnderylingResult> underylingResult_;
        public List<UnderylingResult> UnderylingResult_
        {
            get
            {
                if (this.underylingResult_ != null)
                {
                    return this.underylingResult_; 
                }
                else if (this.underylingResultIDRef_ != null)
                {
                    return this.underylingResult_; 
                }
                else
                {
                    throw new Exception( "underylingResult_Node no exist!");
                }
            }
            set
            {
                if (this.underylingResult_ != value)
                {
                    this.underylingResult_ = value;
                }
            }
        }
        #endregion
        
        public string underylingResultIDRef_ { get; set; }
        
    
        
    
    }
    
}

