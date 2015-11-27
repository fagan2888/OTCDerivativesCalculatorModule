using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ForwardRateCurve
    {
        public ForwardRateCurve(XmlNode xmlNode)
        {
            XmlNodeList assetReferenceNodeList = xmlNode.SelectNodes("assetReference");
            if (assetReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in assetReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        assetReferenceIDRef = item.Attributes["id"].Name;
                        AssetReference ob = AssetReference();
                        IDManager.SetID(assetReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        assetReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        assetReference = new AssetReference(item);
                    }
                }
            }
            
        
            XmlNodeList rateCurveNodeList = xmlNode.SelectNodes("rateCurve");
            if (rateCurveNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in rateCurveNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        rateCurveIDRef = item.Attributes["id"].Name;
                        TermCurve ob = TermCurve();
                        IDManager.SetID(rateCurveIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        rateCurveIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        rateCurve = new TermCurve(item);
                    }
                }
            }
            
        
        }
        
    
        #region AssetReference
        private AssetReference assetReference;
        public AssetReference AssetReference
        {
            get
            {
                if (this.assetReference != null)
                {
                    return this.assetReference; 
                }
                else if (this.assetReferenceIDRef != null)
                {
                    assetReference = IDManager.getID(assetReferenceIDRef) as AssetReference;
                    return this.assetReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.assetReference != value)
                {
                    this.assetReference = value;
                }
            }
        }
        #endregion
        
        public string AssetReferenceIDRef { get; set; }
        #region RateCurve
        private TermCurve rateCurve;
        public TermCurve RateCurve
        {
            get
            {
                if (this.rateCurve != null)
                {
                    return this.rateCurve; 
                }
                else if (this.rateCurveIDRef != null)
                {
                    rateCurve = IDManager.getID(rateCurveIDRef) as TermCurve;
                    return this.rateCurve; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.rateCurve != value)
                {
                    this.rateCurve = value;
                }
            }
        }
        #endregion
        
        public string TermCurveIDRef { get; set; }
        
    
        
    
    }
    
}

