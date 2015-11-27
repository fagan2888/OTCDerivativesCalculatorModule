using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FxOptionFeatures
    {
        public FxOptionFeatures(XmlNode xmlNode)
        {
            XmlNodeList asianNodeList = xmlNode.SelectNodes("asian");
            if (asianNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in asianNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        asianIDRef = item.Attributes["id"].Name;
                        FxAsianFeature ob = FxAsianFeature();
                        IDManager.SetID(asianIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        asianIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        asian = new FxAsianFeature(item);
                    }
                }
            }
            
        
            XmlNodeList barrierNodeList = xmlNode.SelectNodes("barrier");
            
            foreach (XmlNode item in barrierNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        barrierIDRef = item.Attributes["id"].Name;
                        List<FxBarrierFeature> ob = new List<FxBarrierFeature>();
                        ob.Add(new FxBarrierFeature(item));
                        IDManager.SetID(barrierIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        barrierIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    barrier.Add(new FxBarrierFeature(item));
                    }
                }
            }
            
        
        }
        
    
        #region Asian
        private FxAsianFeature asian;
        public FxAsianFeature Asian
        {
            get
            {
                if (this.asian != null)
                {
                    return this.asian; 
                }
                else if (this.asianIDRef != null)
                {
                    asian = IDManager.getID(asianIDRef) as FxAsianFeature;
                    return this.asian; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.asian != value)
                {
                    this.asian = value;
                }
            }
        }
        #endregion
        
        public string FxAsianFeatureIDRef { get; set; }
        #region Barrier
        private List<FxBarrierFeature> barrier;
        public List<FxBarrierFeature> Barrier
        {
            get
            {
                if (this.barrier != null)
                {
                    return this.barrier; 
                }
                else if (this.barrierIDRef != null)
                {
                    barrier = IDManager.getID(barrierIDRef) as List<FxBarrierFeature>;
                    return this.barrier; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.barrier != value)
                {
                    this.barrier = value;
                }
            }
        }
        #endregion
        
        public string FxBarrierFeatureIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

