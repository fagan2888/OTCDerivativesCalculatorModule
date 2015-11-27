using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace CSharpCodeGen
{
    public class Swap : Product
    {
        public Swap(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList swapStreamNodeList = xmlNode.SelectNodes("swapStream");
            
            foreach (XmlNode item in swapStreamNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        swapStreamIDRef = item.Attributes["id"].Name;
                        List<InterstRateStream> ob = new List<InterstRateStream>();
                        ob.Add(new InterstRateStream(item));
                        IDManager.SetID(swapStreamIDRef, ob);
                    }
                    else if (item.Attributes["href"] != null)
                    {
                        swapStreamIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        throw new NotImplementedException();
                    }
                }
                else
                {
                    swapStream.Add(new InterstRateStream(item));
                }
            }
        }

        #region IsSwapStream
        private string isSwapStream;
        public string IsSwapStream
        {
            get { return this.isSwapStream; }
            set
            {
                if (this.isSwapStream != value)
                {
                    this.isSwapStream = value;
                    //this.RaisePropertyChanged("IsSwapStream");
                }
            }
        }
        #endregion

        #region SwapStream
        private List<InterstRateStream> swapStream;
        public List<InterstRateStream> SwapStream
        {
            get 
            {
                if (swapStream != null) 
                {
                    return this.swapStream;     
                }
                else if (swapStreamIDRef != null)
                {
                    swapStream = IDManager.getID(swapStreamIDRef) as List<InterstRateStream>;
                    return this.swapStream;     
                }
                else 
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.swapStream != value)
                {
                    this.swapStream = value;
                    //this.RaisePropertyChanged("SwapStream");
                }
            }
        }
        #endregion

        public string swapStreamIDRef { get; set; }
        public List<string> choiceStr { get; set; }
    }
}
