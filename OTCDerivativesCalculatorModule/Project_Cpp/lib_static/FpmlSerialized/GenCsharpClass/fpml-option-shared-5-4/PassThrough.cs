using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PassThrough
    {
        public PassThrough(XmlNode xmlNode)
        {
            XmlNodeList passThroughItemNodeList = xmlNode.SelectNodes("passThroughItem");
            
            foreach (XmlNode item in passThroughItemNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        passThroughItemIDRef = item.Attributes["id"].Name;
                        List<PassThroughItem> ob = new List<PassThroughItem>();
                        ob.Add(new PassThroughItem(item));
                        IDManager.SetID(passThroughItemIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        passThroughItemIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    passThroughItem.Add(new PassThroughItem(item));
                    }
                }
            }
            
        
        }
        
    
        #region PassThroughItem
        private List<PassThroughItem> passThroughItem;
        public List<PassThroughItem> PassThroughItem
        {
            get
            {
                if (this.passThroughItem != null)
                {
                    return this.passThroughItem; 
                }
                else if (this.passThroughItemIDRef != null)
                {
                    passThroughItem = IDManager.getID(passThroughItemIDRef) as List<PassThroughItem>;
                    return this.passThroughItem; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.passThroughItem != value)
                {
                    this.passThroughItem = value;
                }
            }
        }
        #endregion
        
        public string PassThroughItemIDRef { get; set; }
        
    
        
    
    }
    
}

