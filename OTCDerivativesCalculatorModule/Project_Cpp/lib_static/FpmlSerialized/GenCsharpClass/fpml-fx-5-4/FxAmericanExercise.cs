using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FxAmericanExercise
    {
        public FxAmericanExercise(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList multipleExerciseNodeList = xmlNode.SelectNodes("multipleExercise");
            if (multipleExerciseNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in multipleExerciseNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        multipleExerciseIDRef = item.Attributes["id"].Name;
                        FxMultipleExercise ob = FxMultipleExercise();
                        IDManager.SetID(multipleExerciseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        multipleExerciseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        multipleExercise = new FxMultipleExercise(item);
                    }
                }
            }
            
        
        }
        
    
        #region MultipleExercise
        private FxMultipleExercise multipleExercise;
        public FxMultipleExercise MultipleExercise
        {
            get
            {
                if (this.multipleExercise != null)
                {
                    return this.multipleExercise; 
                }
                else if (this.multipleExerciseIDRef != null)
                {
                    multipleExercise = IDManager.getID(multipleExerciseIDRef) as FxMultipleExercise;
                    return this.multipleExercise; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.multipleExercise != value)
                {
                    this.multipleExercise = value;
                }
            }
        }
        #endregion
        
        public string FxMultipleExerciseIDRef { get; set; }
        
    
        
    
    }
    
}

