using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class BaseIndexes
    {
        public BaseIndexes(XmlNode xmlNode)
        {
            XmlNodeList underlyingIndexNodeList = xmlNode.SelectNodes("underlyingIndex");
            
            foreach (XmlNode item in underlyingIndexNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        underlyingIndexIDRef = item.Attributes["id"].Name;
                        List<UnderlyingIndex> ob = new List<UnderlyingIndex>();
                        ob.Add(new UnderlyingIndex(item));
                        IDManager.SetID(underlyingIndexIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        underlyingIndexIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    underlyingIndex.Add(new UnderlyingIndex(item));
                    }
                }
            }
            
        
        }
        
    
        #region UnderlyingIndex
        private List<UnderlyingIndex> underlyingIndex;
        public List<UnderlyingIndex> UnderlyingIndex
        {
            get
            {
                if (this.underlyingIndex != null)
                {
                    return this.underlyingIndex; 
                }
                else if (this.underlyingIndexIDRef != null)
                {
                    underlyingIndex = IDManager.getID(underlyingIndexIDRef) as List<UnderlyingIndex>;
                    return this.underlyingIndex; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.underlyingIndex != value)
                {
                    this.underlyingIndex = value;
                }
            }
        }
        #endregion
        
        public string UnderlyingIndexIDRef { get; set; }
        
    
        
    
    }
    
}

