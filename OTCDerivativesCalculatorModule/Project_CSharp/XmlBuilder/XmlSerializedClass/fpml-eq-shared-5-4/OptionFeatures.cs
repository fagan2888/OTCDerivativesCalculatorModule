using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class OptionFeatures : ISerialized
    {
        public OptionFeatures(XmlNode xmlNode)
        {
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
            
        
            XmlNode dividendAdjustmentNode = xmlNode.SelectSingleNode("dividendAdjustment");
            
            if (dividendAdjustmentNode != null)
            {
                if (dividendAdjustmentNode.Attributes["href"] != null || dividendAdjustmentNode.Attributes["id"] != null) 
                {
                    if (dividendAdjustmentNode.Attributes["id"] != null) 
                    {
                        dividendAdjustmentIDRef_ = dividendAdjustmentNode.Attributes["id"].Value;
                        DividendAdjustment ob = new DividendAdjustment(dividendAdjustmentNode);
                        IDManager.SetID(dividendAdjustmentIDRef_, ob);
                    }
                    else if (dividendAdjustmentNode.Attributes["href"] != null)
                    {
                        dividendAdjustmentIDRef_ = dividendAdjustmentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dividendAdjustment_ = new DividendAdjustment(dividendAdjustmentNode);
                    }
                }
                else
                {
                    dividendAdjustment_ = new DividendAdjustment(dividendAdjustmentNode);
                }
            }
            
        
        }
        
    
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
        #region DividendAdjustment_
        private DividendAdjustment dividendAdjustment_;
        public DividendAdjustment DividendAdjustment_
        {
            get
            {
                if (this.dividendAdjustment_ != null)
                {
                    return this.dividendAdjustment_; 
                }
                else if (this.dividendAdjustmentIDRef_ != null)
                {
                    dividendAdjustment_ = IDManager.getID(dividendAdjustmentIDRef_) as DividendAdjustment;
                    return this.dividendAdjustment_; 
                }
                else
                {
                      return this.dividendAdjustment_; 
                }
            }
            set
            {
                if (this.dividendAdjustment_ != value)
                {
                    this.dividendAdjustment_ = value;
                }
            }
        }
        #endregion
        
        public string dividendAdjustmentIDRef_ { get; set; }
        
    
        
    
    }
    
}

