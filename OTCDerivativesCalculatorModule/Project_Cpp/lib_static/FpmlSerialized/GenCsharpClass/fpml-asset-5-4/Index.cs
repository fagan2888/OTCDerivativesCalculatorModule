using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Index
    {
        public Index(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList futureIdNodeList = xmlNode.SelectNodes("futureId");
            if (futureIdNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in futureIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        futureIdIDRef = item.Attributes["id"].Name;
                        FutureId ob = FutureId();
                        IDManager.SetID(futureIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        futureIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        futureId = new FutureId(item);
                    }
                }
            }
            
        
        }
        
    
        #region FutureId
        private FutureId futureId;
        public FutureId FutureId
        {
            get
            {
                if (this.futureId != null)
                {
                    return this.futureId; 
                }
                else if (this.futureIdIDRef != null)
                {
                    futureId = IDManager.getID(futureIdIDRef) as FutureId;
                    return this.futureId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.futureId != value)
                {
                    this.futureId = value;
                }
            }
        }
        #endregion
        
        public string FutureIdIDRef { get; set; }
        
    
        
    
    }
    
}

