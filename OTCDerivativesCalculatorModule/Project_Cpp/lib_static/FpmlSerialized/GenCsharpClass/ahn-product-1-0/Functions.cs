using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Functions
    {
        public Functions(XmlNode xmlNode)
        {
            XmlNodeList functionNodeList = xmlNode.SelectNodes("function");
            
            foreach (XmlNode item in functionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        functionIDRef = item.Attributes["id"].Name;
                        List<Function> ob = new List<Function>();
                        ob.Add(new Function(item));
                        IDManager.SetID(functionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        functionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    function.Add(new Function(item));
                    }
                }
            }
            
        
        }
        
    
        #region Function
        private List<Function> function;
        public List<Function> Function
        {
            get
            {
                if (this.function != null)
                {
                    return this.function; 
                }
                else if (this.functionIDRef != null)
                {
                    function = IDManager.getID(functionIDRef) as List<Function>;
                    return this.function; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.function != value)
                {
                    this.function = value;
                }
            }
        }
        #endregion
        
        public string FunctionIDRef { get; set; }
        
    
        
    
    }
    
}

