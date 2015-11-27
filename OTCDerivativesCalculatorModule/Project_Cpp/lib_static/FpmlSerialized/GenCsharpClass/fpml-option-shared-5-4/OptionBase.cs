using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class OptionBase
    {
        public OptionBase(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList optionTypeNodeList = xmlNode.SelectNodes("optionType");
            if (optionTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in optionTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        optionTypeIDRef = item.Attributes["id"].Name;
                        OptionTypeEnum ob = OptionTypeEnum();
                        IDManager.SetID(optionTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        optionTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        optionType = new OptionTypeEnum(item);
                    }
                }
            }
            
        
        }
        
    
        #region OptionType
        private OptionTypeEnum optionType;
        public OptionTypeEnum OptionType
        {
            get
            {
                if (this.optionType != null)
                {
                    return this.optionType; 
                }
                else if (this.optionTypeIDRef != null)
                {
                    optionType = IDManager.getID(optionTypeIDRef) as OptionTypeEnum;
                    return this.optionType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.optionType != value)
                {
                    this.optionType = value;
                }
            }
        }
        #endregion
        
        public string OptionTypeEnumIDRef { get; set; }
        
    
        
    
    }
    
}

