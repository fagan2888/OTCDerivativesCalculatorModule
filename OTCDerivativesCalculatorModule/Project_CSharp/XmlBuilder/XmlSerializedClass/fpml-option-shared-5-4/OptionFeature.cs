using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class OptionFeature : ISerialized
    {
        public OptionFeature(XmlNode xmlNode)
        {
            XmlNode fxFeatureNode = xmlNode.SelectSingleNode("fxFeature");
            
            if (fxFeatureNode != null)
            {
                if (fxFeatureNode.Attributes["href"] != null || fxFeatureNode.Attributes["id"] != null) 
                {
                    if (fxFeatureNode.Attributes["id"] != null) 
                    {
                        fxFeatureIDRef_ = fxFeatureNode.Attributes["id"].Value;
                        FxFeature ob = new FxFeature(fxFeatureNode);
                        IDManager.SetID(fxFeatureIDRef_, ob);
                    }
                    else if (fxFeatureNode.Attributes["href"] != null)
                    {
                        fxFeatureIDRef_ = fxFeatureNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fxFeature_ = new FxFeature(fxFeatureNode);
                    }
                }
                else
                {
                    fxFeature_ = new FxFeature(fxFeatureNode);
                }
            }
            
        
            XmlNode strategyFeatureNode = xmlNode.SelectSingleNode("strategyFeature");
            
            if (strategyFeatureNode != null)
            {
                if (strategyFeatureNode.Attributes["href"] != null || strategyFeatureNode.Attributes["id"] != null) 
                {
                    if (strategyFeatureNode.Attributes["id"] != null) 
                    {
                        strategyFeatureIDRef_ = strategyFeatureNode.Attributes["id"].Value;
                        StrategyFeature ob = new StrategyFeature(strategyFeatureNode);
                        IDManager.SetID(strategyFeatureIDRef_, ob);
                    }
                    else if (strategyFeatureNode.Attributes["href"] != null)
                    {
                        strategyFeatureIDRef_ = strategyFeatureNode.Attributes["href"].Value;
                    }
                    else
                    {
                        strategyFeature_ = new StrategyFeature(strategyFeatureNode);
                    }
                }
                else
                {
                    strategyFeature_ = new StrategyFeature(strategyFeatureNode);
                }
            }
            
        
            XmlNode asianNode = xmlNode.SelectSingleNode("asian");
            
            if (asianNode != null)
            {
                if (asianNode.Attributes["href"] != null || asianNode.Attributes["id"] != null) 
                {
                    if (asianNode.Attributes["id"] != null) 
                    {
                        asianIDRef_ = asianNode.Attributes["id"].Value;
                        Asian ob = new Asian(asianNode);
                        IDManager.SetID(asianIDRef_, ob);
                    }
                    else if (asianNode.Attributes["href"] != null)
                    {
                        asianIDRef_ = asianNode.Attributes["href"].Value;
                    }
                    else
                    {
                        asian_ = new Asian(asianNode);
                    }
                }
                else
                {
                    asian_ = new Asian(asianNode);
                }
            }
            
        
            XmlNode barrierNode = xmlNode.SelectSingleNode("barrier");
            
            if (barrierNode != null)
            {
                if (barrierNode.Attributes["href"] != null || barrierNode.Attributes["id"] != null) 
                {
                    if (barrierNode.Attributes["id"] != null) 
                    {
                        barrierIDRef_ = barrierNode.Attributes["id"].Value;
                        Barrier ob = new Barrier(barrierNode);
                        IDManager.SetID(barrierIDRef_, ob);
                    }
                    else if (barrierNode.Attributes["href"] != null)
                    {
                        barrierIDRef_ = barrierNode.Attributes["href"].Value;
                    }
                    else
                    {
                        barrier_ = new Barrier(barrierNode);
                    }
                }
                else
                {
                    barrier_ = new Barrier(barrierNode);
                }
            }
            
        
            XmlNode knockNode = xmlNode.SelectSingleNode("knock");
            
            if (knockNode != null)
            {
                if (knockNode.Attributes["href"] != null || knockNode.Attributes["id"] != null) 
                {
                    if (knockNode.Attributes["id"] != null) 
                    {
                        knockIDRef_ = knockNode.Attributes["id"].Value;
                        Knock ob = new Knock(knockNode);
                        IDManager.SetID(knockIDRef_, ob);
                    }
                    else if (knockNode.Attributes["href"] != null)
                    {
                        knockIDRef_ = knockNode.Attributes["href"].Value;
                    }
                    else
                    {
                        knock_ = new Knock(knockNode);
                    }
                }
                else
                {
                    knock_ = new Knock(knockNode);
                }
            }
            
        
            XmlNode passThroughNode = xmlNode.SelectSingleNode("passThrough");
            
            if (passThroughNode != null)
            {
                if (passThroughNode.Attributes["href"] != null || passThroughNode.Attributes["id"] != null) 
                {
                    if (passThroughNode.Attributes["id"] != null) 
                    {
                        passThroughIDRef_ = passThroughNode.Attributes["id"].Value;
                        PassThrough ob = new PassThrough(passThroughNode);
                        IDManager.SetID(passThroughIDRef_, ob);
                    }
                    else if (passThroughNode.Attributes["href"] != null)
                    {
                        passThroughIDRef_ = passThroughNode.Attributes["href"].Value;
                    }
                    else
                    {
                        passThrough_ = new PassThrough(passThroughNode);
                    }
                }
                else
                {
                    passThrough_ = new PassThrough(passThroughNode);
                }
            }
            
        
        }
        
    
        #region FxFeature_
        private FxFeature fxFeature_;
        public FxFeature FxFeature_
        {
            get
            {
                if (this.fxFeature_ != null)
                {
                    return this.fxFeature_; 
                }
                else if (this.fxFeatureIDRef_ != null)
                {
                    fxFeature_ = IDManager.getID(fxFeatureIDRef_) as FxFeature;
                    return this.fxFeature_; 
                }
                else
                {
                      return this.fxFeature_; 
                }
            }
            set
            {
                if (this.fxFeature_ != value)
                {
                    this.fxFeature_ = value;
                }
            }
        }
        #endregion
        
        public string fxFeatureIDRef_ { get; set; }
        #region StrategyFeature_
        private StrategyFeature strategyFeature_;
        public StrategyFeature StrategyFeature_
        {
            get
            {
                if (this.strategyFeature_ != null)
                {
                    return this.strategyFeature_; 
                }
                else if (this.strategyFeatureIDRef_ != null)
                {
                    strategyFeature_ = IDManager.getID(strategyFeatureIDRef_) as StrategyFeature;
                    return this.strategyFeature_; 
                }
                else
                {
                      return this.strategyFeature_; 
                }
            }
            set
            {
                if (this.strategyFeature_ != value)
                {
                    this.strategyFeature_ = value;
                }
            }
        }
        #endregion
        
        public string strategyFeatureIDRef_ { get; set; }
        #region Asian_
        private Asian asian_;
        public Asian Asian_
        {
            get
            {
                if (this.asian_ != null)
                {
                    return this.asian_; 
                }
                else if (this.asianIDRef_ != null)
                {
                    asian_ = IDManager.getID(asianIDRef_) as Asian;
                    return this.asian_; 
                }
                else
                {
                      return this.asian_; 
                }
            }
            set
            {
                if (this.asian_ != value)
                {
                    this.asian_ = value;
                }
            }
        }
        #endregion
        
        public string asianIDRef_ { get; set; }
        #region Barrier_
        private Barrier barrier_;
        public Barrier Barrier_
        {
            get
            {
                if (this.barrier_ != null)
                {
                    return this.barrier_; 
                }
                else if (this.barrierIDRef_ != null)
                {
                    barrier_ = IDManager.getID(barrierIDRef_) as Barrier;
                    return this.barrier_; 
                }
                else
                {
                      return this.barrier_; 
                }
            }
            set
            {
                if (this.barrier_ != value)
                {
                    this.barrier_ = value;
                }
            }
        }
        #endregion
        
        public string barrierIDRef_ { get; set; }
        #region Knock_
        private Knock knock_;
        public Knock Knock_
        {
            get
            {
                if (this.knock_ != null)
                {
                    return this.knock_; 
                }
                else if (this.knockIDRef_ != null)
                {
                    knock_ = IDManager.getID(knockIDRef_) as Knock;
                    return this.knock_; 
                }
                else
                {
                      return this.knock_; 
                }
            }
            set
            {
                if (this.knock_ != value)
                {
                    this.knock_ = value;
                }
            }
        }
        #endregion
        
        public string knockIDRef_ { get; set; }
        #region PassThrough_
        private PassThrough passThrough_;
        public PassThrough PassThrough_
        {
            get
            {
                if (this.passThrough_ != null)
                {
                    return this.passThrough_; 
                }
                else if (this.passThroughIDRef_ != null)
                {
                    passThrough_ = IDManager.getID(passThroughIDRef_) as PassThrough;
                    return this.passThrough_; 
                }
                else
                {
                      return this.passThrough_; 
                }
            }
            set
            {
                if (this.passThrough_ != value)
                {
                    this.passThrough_ = value;
                }
            }
        }
        #endregion
        
        public string passThroughIDRef_ { get; set; }
        
    
        
    
    }
    
}

