using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class RestructuringEvent
    {
        public RestructuringEvent(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList partialExerciseAmountNodeList = xmlNode.SelectNodes("partialExerciseAmount");
            if (partialExerciseAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in partialExerciseAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        partialExerciseAmountIDRef = item.Attributes["id"].Name;
                        Money ob = Money();
                        IDManager.SetID(partialExerciseAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        partialExerciseAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        partialExerciseAmount = new Money(item);
                    }
                }
            }
            
        
        }
        
    
        #region PartialExerciseAmount
        private Money partialExerciseAmount;
        public Money PartialExerciseAmount
        {
            get
            {
                if (this.partialExerciseAmount != null)
                {
                    return this.partialExerciseAmount; 
                }
                else if (this.partialExerciseAmountIDRef != null)
                {
                    partialExerciseAmount = IDManager.getID(partialExerciseAmountIDRef) as Money;
                    return this.partialExerciseAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.partialExerciseAmount != value)
                {
                    this.partialExerciseAmount = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        
    
        
    
    }
    
}

