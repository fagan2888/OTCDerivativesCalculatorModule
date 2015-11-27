using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CommodityPhysicalExercise
    {
        public CommodityPhysicalExercise(XmlNode xmlNode)
        {
            XmlNodeList americanExerciseNodeList = xmlNode.SelectNodes("americanExercise");
            if (americanExerciseNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in americanExerciseNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        americanExerciseIDRef = item.Attributes["id"].Name;
                        CommodityPhysicalAmericanExercise ob = CommodityPhysicalAmericanExercise();
                        IDManager.SetID(americanExerciseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        americanExerciseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        americanExercise = new CommodityPhysicalAmericanExercise(item);
                    }
                }
            }
            
        
            XmlNodeList europeanExerciseNodeList = xmlNode.SelectNodes("europeanExercise");
            if (europeanExerciseNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in europeanExerciseNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        europeanExerciseIDRef = item.Attributes["id"].Name;
                        CommodityPhysicalEuropeanExercise ob = CommodityPhysicalEuropeanExercise();
                        IDManager.SetID(europeanExerciseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        europeanExerciseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        europeanExercise = new CommodityPhysicalEuropeanExercise(item);
                    }
                }
            }
            
        
            XmlNodeList automaticExerciseNodeList = xmlNode.SelectNodes("automaticExercise");
            if (automaticExerciseNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in automaticExerciseNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        automaticExerciseIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(automaticExerciseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        automaticExerciseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        automaticExercise = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList writtenConfirmationNodeList = xmlNode.SelectNodes("writtenConfirmation");
            if (writtenConfirmationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in writtenConfirmationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        writtenConfirmationIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(writtenConfirmationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        writtenConfirmationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        writtenConfirmation = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
        }
        
    
        #region AmericanExercise
        private CommodityPhysicalAmericanExercise americanExercise;
        public CommodityPhysicalAmericanExercise AmericanExercise
        {
            get
            {
                if (this.americanExercise != null)
                {
                    return this.americanExercise; 
                }
                else if (this.americanExerciseIDRef != null)
                {
                    americanExercise = IDManager.getID(americanExerciseIDRef) as CommodityPhysicalAmericanExercise;
                    return this.americanExercise; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.americanExercise != value)
                {
                    this.americanExercise = value;
                }
            }
        }
        #endregion
        
        public string CommodityPhysicalAmericanExerciseIDRef { get; set; }
        #region EuropeanExercise
        private CommodityPhysicalEuropeanExercise europeanExercise;
        public CommodityPhysicalEuropeanExercise EuropeanExercise
        {
            get
            {
                if (this.europeanExercise != null)
                {
                    return this.europeanExercise; 
                }
                else if (this.europeanExerciseIDRef != null)
                {
                    europeanExercise = IDManager.getID(europeanExerciseIDRef) as CommodityPhysicalEuropeanExercise;
                    return this.europeanExercise; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.europeanExercise != value)
                {
                    this.europeanExercise = value;
                }
            }
        }
        #endregion
        
        public string CommodityPhysicalEuropeanExerciseIDRef { get; set; }
        #region AutomaticExercise
        private XsdTypeBoolean automaticExercise;
        public XsdTypeBoolean AutomaticExercise
        {
            get
            {
                if (this.automaticExercise != null)
                {
                    return this.automaticExercise; 
                }
                else if (this.automaticExerciseIDRef != null)
                {
                    automaticExercise = IDManager.getID(automaticExerciseIDRef) as XsdTypeBoolean;
                    return this.automaticExercise; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.automaticExercise != value)
                {
                    this.automaticExercise = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region WrittenConfirmation
        private XsdTypeBoolean writtenConfirmation;
        public XsdTypeBoolean WrittenConfirmation
        {
            get
            {
                if (this.writtenConfirmation != null)
                {
                    return this.writtenConfirmation; 
                }
                else if (this.writtenConfirmationIDRef != null)
                {
                    writtenConfirmation = IDManager.getID(writtenConfirmationIDRef) as XsdTypeBoolean;
                    return this.writtenConfirmation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.writtenConfirmation != value)
                {
                    this.writtenConfirmation = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

