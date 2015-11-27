using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace RiskMonitor
{
    public class GreekResultInfo
    {
        public List<GreekResult> GreekResultList_ { get; set; }

        public double Notional_ { get; set; }
        public double Theta_ { get; set; }
        public double ThetaPosition { get; set; }
        public int UnderCount_ { get; set; }

        public void loadFromXml(XmlNode node)
        {
            this.GreekResultList_ = new List<GreekResult>();

            XmlNode paraNode = node.SelectSingleNode("pricingParameter");
            XmlNode resultNode = node.SelectSingleNode("pricingResult");
            this.Notional_ = Convert.ToDouble(paraNode["notional"].InnerText);

            XmlNodeList underInfoNodeList = paraNode.SelectNodes("underlyingInfo/underlying");
            XmlNodeList underResultNodeList = resultNode.SelectNodes("greek/underlying");

            if (underInfoNodeList.Count != underResultNodeList.Count)
            {
                // result not 같이 않음. 에러 ㄱㄱ
            }

            this.UnderCount_ = underInfoNodeList.Count;

            for (int i = 0; i < this.UnderCount_ ; i++)
            {
                GreekResult greekResult = new GreekResult();
                greekResult.Unit_ = 10000;
                greekResult.Notional_ = this.Notional_;
                greekResult.loadFromXml(underInfoNodeList[i],underResultNodeList[i]);
                this.GreekResultList_.Add(greekResult);

            }


            
        }

        
    }
}
