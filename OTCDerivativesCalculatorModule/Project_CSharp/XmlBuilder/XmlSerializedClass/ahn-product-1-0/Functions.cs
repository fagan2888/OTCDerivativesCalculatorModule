using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Functions : ISerialized
    {
        public Functions(XmlNode xmlNode)
        {
            XmlNodeList functionNodeList = xmlNode.SelectNodes("function");
            
            if (functionNodeList != null)
            {
                this.function_ = new List<Function>();
                foreach (XmlNode item in functionNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            functionIDRef_ = item.Attributes["id"].Value;
                            function_.Add(new Function(item));
                            IDManager.SetID(functionIDRef_, function_[function_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            functionIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        function_.Add(new Function(item));
                        }
                    }
                    else
                    {
                        function_.Add(new Function(item));
                    }
                }
            }
            
        
        }
        
    
        #region Function_
        private List<Function> function_;
        public List<Function> Function_
        {
            get
            {
                if (this.function_ != null)
                {
                    return this.function_; 
                }
                else if (this.functionIDRef_ != null)
                {
                    return this.function_; 
                }
                else
                {
                      return this.function_; 
                }
            }
            set
            {
                if (this.function_ != value)
                {
                    this.function_ = value;
                }
            }
        }
        #endregion
        
        public string functionIDRef_ { get; set; }
        
    
        
    
    }
    
}

