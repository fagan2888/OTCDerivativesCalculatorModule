using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class OptionFeature
    {
        public OptionFeature(XmlNode xmlNode)
        {
            XmlNodeList fxFeatureNodeList = xmlNode.SelectNodes("fxFeature");
            if (fxFeatureNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fxFeatureNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fxFeatureIDRef = item.Attributes["id"].Name;
                        FxFeature ob = FxFeature();
                        IDManager.SetID(fxFeatureIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fxFeatureIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fxFeature = new FxFeature(item);
                    }
                }
            }
            
        
            XmlNodeList strategyFeatureNodeList = xmlNode.SelectNodes("strategyFeature");
            if (strategyFeatureNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in strategyFeatureNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        strategyFeatureIDRef = item.Attributes["id"].Name;
                        StrategyFeature ob = StrategyFeature();
                        IDManager.SetID(strategyFeatureIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        strategyFeatureIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        strategyFeature = new StrategyFeature(item);
                    }
                }
            }
            
        
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
                        Asian ob = Asian();
                        IDManager.SetID(asianIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        asianIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        asian = new Asian(item);
                    }
                }
            }
            
        
            XmlNodeList barrierNodeList = xmlNode.SelectNodes("barrier");
            if (barrierNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in barrierNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        barrierIDRef = item.Attributes["id"].Name;
                        Barrier ob = Barrier();
                        IDManager.SetID(barrierIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        barrierIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        barrier = new Barrier(item);
                    }
                }
            }
            
        
            XmlNodeList knockNodeList = xmlNode.SelectNodes("knock");
            if (knockNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in knockNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        knockIDRef = item.Attributes["id"].Name;
                        Knock ob = Knock();
                        IDManager.SetID(knockIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        knockIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        knock = new Knock(item);
                    }
                }
            }
            
        
            XmlNodeList passThroughNodeList = xmlNode.SelectNodes("passThrough");
            if (passThroughNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in passThroughNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        passThroughIDRef = item.Attributes["id"].Name;
                        PassThrough ob = PassThrough();
                        IDManager.SetID(passThroughIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        passThroughIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        passThrough = new PassThrough(item);
                    }
                }
            }
            
        
        }
        
    
        #region FxFeature
        private FxFeature fxFeature;
        public FxFeature FxFeature
        {
            get
            {
                if (this.fxFeature != null)
                {
                    return this.fxFeature; 
                }
                else if (this.fxFeatureIDRef != null)
                {
                    fxFeature = IDManager.getID(fxFeatureIDRef) as FxFeature;
                    return this.fxFeature; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fxFeature != value)
                {
                    this.fxFeature = value;
                }
            }
        }
        #endregion
        
        public string FxFeatureIDRef { get; set; }
        #region StrategyFeature
        private StrategyFeature strategyFeature;
        public StrategyFeature StrategyFeature
        {
            get
            {
                if (this.strategyFeature != null)
                {
                    return this.strategyFeature; 
                }
                else if (this.strategyFeatureIDRef != null)
                {
                    strategyFeature = IDManager.getID(strategyFeatureIDRef) as StrategyFeature;
                    return this.strategyFeature; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.strategyFeature != value)
                {
                    this.strategyFeature = value;
                }
            }
        }
        #endregion
        
        public string StrategyFeatureIDRef { get; set; }
        #region Asian
        private Asian asian;
        public Asian Asian
        {
            get
            {
                if (this.asian != null)
                {
                    return this.asian; 
                }
                else if (this.asianIDRef != null)
                {
                    asian = IDManager.getID(asianIDRef) as Asian;
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
        
        public string AsianIDRef { get; set; }
        #region Barrier
        private Barrier barrier;
        public Barrier Barrier
        {
            get
            {
                if (this.barrier != null)
                {
                    return this.barrier; 
                }
                else if (this.barrierIDRef != null)
                {
                    barrier = IDManager.getID(barrierIDRef) as Barrier;
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
        
        public string BarrierIDRef { get; set; }
        #region Knock
        private Knock knock;
        public Knock Knock
        {
            get
            {
                if (this.knock != null)
                {
                    return this.knock; 
                }
                else if (this.knockIDRef != null)
                {
                    knock = IDManager.getID(knockIDRef) as Knock;
                    return this.knock; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.knock != value)
                {
                    this.knock = value;
                }
            }
        }
        #endregion
        
        public string KnockIDRef { get; set; }
        #region PassThrough
        private PassThrough passThrough;
        public PassThrough PassThrough
        {
            get
            {
                if (this.passThrough != null)
                {
                    return this.passThrough; 
                }
                else if (this.passThroughIDRef != null)
                {
                    passThrough = IDManager.getID(passThroughIDRef) as PassThrough;
                    return this.passThrough; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.passThrough != value)
                {
                    this.passThrough = value;
                }
            }
        }
        #endregion
        
        public string PassThroughIDRef { get; set; }
        
    
        
    
    }
    
}

