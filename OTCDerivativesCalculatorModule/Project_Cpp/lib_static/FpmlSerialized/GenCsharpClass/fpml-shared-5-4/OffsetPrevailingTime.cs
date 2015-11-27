using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class OffsetPrevailingTime
    {
        public OffsetPrevailingTime(XmlNode xmlNode)
        {
            XmlNodeList timeNodeList = xmlNode.SelectNodes("time");
            if (timeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in timeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        timeIDRef = item.Attributes["id"].Name;
                        PrevailingTime ob = PrevailingTime();
                        IDManager.SetID(timeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        timeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        time = new PrevailingTime(item);
                    }
                }
            }
            
        
            XmlNodeList offsetNodeList = xmlNode.SelectNodes("offset");
            if (offsetNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in offsetNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        offsetIDRef = item.Attributes["id"].Name;
                        Offset ob = Offset();
                        IDManager.SetID(offsetIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        offsetIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        offset = new Offset(item);
                    }
                }
            }
            
        
        }
        
    
        #region Time
        private PrevailingTime time;
        public PrevailingTime Time
        {
            get
            {
                if (this.time != null)
                {
                    return this.time; 
                }
                else if (this.timeIDRef != null)
                {
                    time = IDManager.getID(timeIDRef) as PrevailingTime;
                    return this.time; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.time != value)
                {
                    this.time = value;
                }
            }
        }
        #endregion
        
        public string PrevailingTimeIDRef { get; set; }
        #region Offset
        private Offset offset;
        public Offset Offset
        {
            get
            {
                if (this.offset != null)
                {
                    return this.offset; 
                }
                else if (this.offsetIDRef != null)
                {
                    offset = IDManager.getID(offsetIDRef) as Offset;
                    return this.offset; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.offset != value)
                {
                    this.offset = value;
                }
            }
        }
        #endregion
        
        public string OffsetIDRef { get; set; }
        
    
        
    
    }
    
}

