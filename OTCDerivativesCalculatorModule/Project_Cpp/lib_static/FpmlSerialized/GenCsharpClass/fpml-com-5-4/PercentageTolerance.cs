using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PercentageTolerance
    {
        public PercentageTolerance(XmlNode xmlNode)
        {
            XmlNodeList postitiveNodeList = xmlNode.SelectNodes("postitive");
            if (postitiveNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in postitiveNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        postitiveIDRef = item.Attributes["id"].Name;
                        RestrictedPercentage ob = RestrictedPercentage();
                        IDManager.SetID(postitiveIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        postitiveIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        postitive = new RestrictedPercentage(item);
                    }
                }
            }
            
        
            XmlNodeList negativeNodeList = xmlNode.SelectNodes("negative");
            if (negativeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in negativeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        negativeIDRef = item.Attributes["id"].Name;
                        RestrictedPercentage ob = RestrictedPercentage();
                        IDManager.SetID(negativeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        negativeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        negative = new RestrictedPercentage(item);
                    }
                }
            }
            
        
            XmlNodeList optionNodeList = xmlNode.SelectNodes("option");
            if (optionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in optionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        optionIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(optionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        optionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        option = new PartyReference(item);
                    }
                }
            }
            
        
        }
        
    
        #region Postitive
        private RestrictedPercentage postitive;
        public RestrictedPercentage Postitive
        {
            get
            {
                if (this.postitive != null)
                {
                    return this.postitive; 
                }
                else if (this.postitiveIDRef != null)
                {
                    postitive = IDManager.getID(postitiveIDRef) as RestrictedPercentage;
                    return this.postitive; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.postitive != value)
                {
                    this.postitive = value;
                }
            }
        }
        #endregion
        
        public string RestrictedPercentageIDRef { get; set; }
        #region Negative
        private RestrictedPercentage negative;
        public RestrictedPercentage Negative
        {
            get
            {
                if (this.negative != null)
                {
                    return this.negative; 
                }
                else if (this.negativeIDRef != null)
                {
                    negative = IDManager.getID(negativeIDRef) as RestrictedPercentage;
                    return this.negative; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.negative != value)
                {
                    this.negative = value;
                }
            }
        }
        #endregion
        
        public string RestrictedPercentageIDRef { get; set; }
        #region Option
        private PartyReference option;
        public PartyReference Option
        {
            get
            {
                if (this.option != null)
                {
                    return this.option; 
                }
                else if (this.optionIDRef != null)
                {
                    option = IDManager.getID(optionIDRef) as PartyReference;
                    return this.option; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.option != value)
                {
                    this.option = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        
    
        
    
    }
    
}

