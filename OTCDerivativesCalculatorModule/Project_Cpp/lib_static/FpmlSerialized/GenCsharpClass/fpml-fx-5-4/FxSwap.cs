using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FxSwap
    {
        public FxSwap(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList nearLegNodeList = xmlNode.SelectNodes("nearLeg");
            if (nearLegNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in nearLegNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        nearLegIDRef = item.Attributes["id"].Name;
                        FxSwapLeg ob = FxSwapLeg();
                        IDManager.SetID(nearLegIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        nearLegIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        nearLeg = new FxSwapLeg(item);
                    }
                }
            }
            
        
            XmlNodeList farLegNodeList = xmlNode.SelectNodes("farLeg");
            if (farLegNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in farLegNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        farLegIDRef = item.Attributes["id"].Name;
                        FxSwapLeg ob = FxSwapLeg();
                        IDManager.SetID(farLegIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        farLegIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        farLeg = new FxSwapLeg(item);
                    }
                }
            }
            
        
        }
        
    
        #region NearLeg
        private FxSwapLeg nearLeg;
        public FxSwapLeg NearLeg
        {
            get
            {
                if (this.nearLeg != null)
                {
                    return this.nearLeg; 
                }
                else if (this.nearLegIDRef != null)
                {
                    nearLeg = IDManager.getID(nearLegIDRef) as FxSwapLeg;
                    return this.nearLeg; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.nearLeg != value)
                {
                    this.nearLeg = value;
                }
            }
        }
        #endregion
        
        public string FxSwapLegIDRef { get; set; }
        #region FarLeg
        private FxSwapLeg farLeg;
        public FxSwapLeg FarLeg
        {
            get
            {
                if (this.farLeg != null)
                {
                    return this.farLeg; 
                }
                else if (this.farLegIDRef != null)
                {
                    farLeg = IDManager.getID(farLegIDRef) as FxSwapLeg;
                    return this.farLeg; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.farLeg != value)
                {
                    this.farLeg = value;
                }
            }
        }
        #endregion
        
        public string FxSwapLegIDRef { get; set; }
        
    
        
    
    }
    
}

