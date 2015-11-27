using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ReferencePool
    {
        public ReferencePool(XmlNode xmlNode)
        {
            XmlNodeList referencePoolItemNodeList = xmlNode.SelectNodes("referencePoolItem");
            
            foreach (XmlNode item in referencePoolItemNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        referencePoolItemIDRef = item.Attributes["id"].Name;
                        List<ReferencePoolItem> ob = new List<ReferencePoolItem>();
                        ob.Add(new ReferencePoolItem(item));
                        IDManager.SetID(referencePoolItemIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        referencePoolItemIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    referencePoolItem.Add(new ReferencePoolItem(item));
                    }
                }
            }
            
        
        }
        
    
        #region ReferencePoolItem
        private List<ReferencePoolItem> referencePoolItem;
        public List<ReferencePoolItem> ReferencePoolItem
        {
            get
            {
                if (this.referencePoolItem != null)
                {
                    return this.referencePoolItem; 
                }
                else if (this.referencePoolItemIDRef != null)
                {
                    referencePoolItem = IDManager.getID(referencePoolItemIDRef) as List<ReferencePoolItem>;
                    return this.referencePoolItem; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.referencePoolItem != value)
                {
                    this.referencePoolItem = value;
                }
            }
        }
        #endregion
        
        public string ReferencePoolItemIDRef { get; set; }
        
    
        
    
    }
    
}

