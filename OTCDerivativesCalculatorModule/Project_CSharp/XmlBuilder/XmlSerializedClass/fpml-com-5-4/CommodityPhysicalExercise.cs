using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CommodityPhysicalExercise : ISerialized
    {
        public CommodityPhysicalExercise(XmlNode xmlNode)
        {
            XmlNode americanExerciseNode = xmlNode.SelectSingleNode("americanExercise");
            
            if (americanExerciseNode != null)
            {
                if (americanExerciseNode.Attributes["href"] != null || americanExerciseNode.Attributes["id"] != null) 
                {
                    if (americanExerciseNode.Attributes["id"] != null) 
                    {
                        americanExerciseIDRef_ = americanExerciseNode.Attributes["id"].Value;
                        CommodityPhysicalAmericanExercise ob = new CommodityPhysicalAmericanExercise(americanExerciseNode);
                        IDManager.SetID(americanExerciseIDRef_, ob);
                    }
                    else if (americanExerciseNode.Attributes["href"] != null)
                    {
                        americanExerciseIDRef_ = americanExerciseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        americanExercise_ = new CommodityPhysicalAmericanExercise(americanExerciseNode);
                    }
                }
                else
                {
                    americanExercise_ = new CommodityPhysicalAmericanExercise(americanExerciseNode);
                }
            }
            
        
            XmlNode europeanExerciseNode = xmlNode.SelectSingleNode("europeanExercise");
            
            if (europeanExerciseNode != null)
            {
                if (europeanExerciseNode.Attributes["href"] != null || europeanExerciseNode.Attributes["id"] != null) 
                {
                    if (europeanExerciseNode.Attributes["id"] != null) 
                    {
                        europeanExerciseIDRef_ = europeanExerciseNode.Attributes["id"].Value;
                        CommodityPhysicalEuropeanExercise ob = new CommodityPhysicalEuropeanExercise(europeanExerciseNode);
                        IDManager.SetID(europeanExerciseIDRef_, ob);
                    }
                    else if (europeanExerciseNode.Attributes["href"] != null)
                    {
                        europeanExerciseIDRef_ = europeanExerciseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        europeanExercise_ = new CommodityPhysicalEuropeanExercise(europeanExerciseNode);
                    }
                }
                else
                {
                    europeanExercise_ = new CommodityPhysicalEuropeanExercise(europeanExerciseNode);
                }
            }
            
        
            XmlNode automaticExerciseNode = xmlNode.SelectSingleNode("automaticExercise");
            
            if (automaticExerciseNode != null)
            {
                if (automaticExerciseNode.Attributes["href"] != null || automaticExerciseNode.Attributes["id"] != null) 
                {
                    if (automaticExerciseNode.Attributes["id"] != null) 
                    {
                        automaticExerciseIDRef_ = automaticExerciseNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(automaticExerciseNode);
                        IDManager.SetID(automaticExerciseIDRef_, ob);
                    }
                    else if (automaticExerciseNode.Attributes["href"] != null)
                    {
                        automaticExerciseIDRef_ = automaticExerciseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        automaticExercise_ = new XsdTypeBoolean(automaticExerciseNode);
                    }
                }
                else
                {
                    automaticExercise_ = new XsdTypeBoolean(automaticExerciseNode);
                }
            }
            
        
            XmlNode writtenConfirmationNode = xmlNode.SelectSingleNode("writtenConfirmation");
            
            if (writtenConfirmationNode != null)
            {
                if (writtenConfirmationNode.Attributes["href"] != null || writtenConfirmationNode.Attributes["id"] != null) 
                {
                    if (writtenConfirmationNode.Attributes["id"] != null) 
                    {
                        writtenConfirmationIDRef_ = writtenConfirmationNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(writtenConfirmationNode);
                        IDManager.SetID(writtenConfirmationIDRef_, ob);
                    }
                    else if (writtenConfirmationNode.Attributes["href"] != null)
                    {
                        writtenConfirmationIDRef_ = writtenConfirmationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        writtenConfirmation_ = new XsdTypeBoolean(writtenConfirmationNode);
                    }
                }
                else
                {
                    writtenConfirmation_ = new XsdTypeBoolean(writtenConfirmationNode);
                }
            }
            
        
        }
        
    
        #region AmericanExercise_
        private CommodityPhysicalAmericanExercise americanExercise_;
        public CommodityPhysicalAmericanExercise AmericanExercise_
        {
            get
            {
                if (this.americanExercise_ != null)
                {
                    return this.americanExercise_; 
                }
                else if (this.americanExerciseIDRef_ != null)
                {
                    americanExercise_ = IDManager.getID(americanExerciseIDRef_) as CommodityPhysicalAmericanExercise;
                    return this.americanExercise_; 
                }
                else
                {
                      return this.americanExercise_; 
                }
            }
            set
            {
                if (this.americanExercise_ != value)
                {
                    this.americanExercise_ = value;
                }
            }
        }
        #endregion
        
        public string americanExerciseIDRef_ { get; set; }
        #region EuropeanExercise_
        private CommodityPhysicalEuropeanExercise europeanExercise_;
        public CommodityPhysicalEuropeanExercise EuropeanExercise_
        {
            get
            {
                if (this.europeanExercise_ != null)
                {
                    return this.europeanExercise_; 
                }
                else if (this.europeanExerciseIDRef_ != null)
                {
                    europeanExercise_ = IDManager.getID(europeanExerciseIDRef_) as CommodityPhysicalEuropeanExercise;
                    return this.europeanExercise_; 
                }
                else
                {
                      return this.europeanExercise_; 
                }
            }
            set
            {
                if (this.europeanExercise_ != value)
                {
                    this.europeanExercise_ = value;
                }
            }
        }
        #endregion
        
        public string europeanExerciseIDRef_ { get; set; }
        #region AutomaticExercise_
        private XsdTypeBoolean automaticExercise_;
        public XsdTypeBoolean AutomaticExercise_
        {
            get
            {
                if (this.automaticExercise_ != null)
                {
                    return this.automaticExercise_; 
                }
                else if (this.automaticExerciseIDRef_ != null)
                {
                    automaticExercise_ = IDManager.getID(automaticExerciseIDRef_) as XsdTypeBoolean;
                    return this.automaticExercise_; 
                }
                else
                {
                      return this.automaticExercise_; 
                }
            }
            set
            {
                if (this.automaticExercise_ != value)
                {
                    this.automaticExercise_ = value;
                }
            }
        }
        #endregion
        
        public string automaticExerciseIDRef_ { get; set; }
        #region WrittenConfirmation_
        private XsdTypeBoolean writtenConfirmation_;
        public XsdTypeBoolean WrittenConfirmation_
        {
            get
            {
                if (this.writtenConfirmation_ != null)
                {
                    return this.writtenConfirmation_; 
                }
                else if (this.writtenConfirmationIDRef_ != null)
                {
                    writtenConfirmation_ = IDManager.getID(writtenConfirmationIDRef_) as XsdTypeBoolean;
                    return this.writtenConfirmation_; 
                }
                else
                {
                      return this.writtenConfirmation_; 
                }
            }
            set
            {
                if (this.writtenConfirmation_ != value)
                {
                    this.writtenConfirmation_ = value;
                }
            }
        }
        #endregion
        
        public string writtenConfirmationIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

