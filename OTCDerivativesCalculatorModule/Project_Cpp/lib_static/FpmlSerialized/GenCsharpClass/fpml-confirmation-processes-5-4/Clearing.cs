using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Clearing
    {
        public Clearing(XmlNode xmlNode)
        {
            XmlNodeList submittedNodeList = xmlNode.SelectNodes("submitted");
            if (submittedNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in submittedNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        submittedIDRef = item.Attributes["id"].Name;
                        TradeWrapper ob = TradeWrapper();
                        IDManager.SetID(submittedIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        submittedIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        submitted = new TradeWrapper(item);
                    }
                }
            }
            
        
            XmlNodeList clearedNodeList = xmlNode.SelectNodes("cleared");
            
            foreach (XmlNode item in clearedNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        clearedIDRef = item.Attributes["id"].Name;
                        List<TradeWrapper> ob = new List<TradeWrapper>();
                        ob.Add(new TradeWrapper(item));
                        IDManager.SetID(clearedIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        clearedIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    cleared.Add(new TradeWrapper(item));
                    }
                }
            }
            
        
        }
        
    
        #region Submitted
        private TradeWrapper submitted;
        public TradeWrapper Submitted
        {
            get
            {
                if (this.submitted != null)
                {
                    return this.submitted; 
                }
                else if (this.submittedIDRef != null)
                {
                    submitted = IDManager.getID(submittedIDRef) as TradeWrapper;
                    return this.submitted; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.submitted != value)
                {
                    this.submitted = value;
                }
            }
        }
        #endregion
        
        public string TradeWrapperIDRef { get; set; }
        #region Cleared
        private List<TradeWrapper> cleared;
        public List<TradeWrapper> Cleared
        {
            get
            {
                if (this.cleared != null)
                {
                    return this.cleared; 
                }
                else if (this.clearedIDRef != null)
                {
                    cleared = IDManager.getID(clearedIDRef) as List<TradeWrapper>;
                    return this.cleared; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.cleared != value)
                {
                    this.cleared = value;
                }
            }
        }
        #endregion
        
        public string TradeWrapperIDRef { get; set; }
        
    
        
    
    }
    
}

