using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using QLNet;

namespace RiskMonitor
{
    public class UnderlyingParameterInfo
    {
        #region ReferenceDate_
        private DateTime referenceDate_;
        public DateTime ReferenceDate_
        {
            get { return this.referenceDate_; }
            set
            {
                if (this.referenceDate_ != value)
                {
                    //this.setReferenceDate(value);
                    this.referenceDate_ = value;
                }
            }
        }
        #endregion

        #region ViewModel_
        private UnderlyingParameterInfoViewModel viewModel_;
        public UnderlyingParameterInfoViewModel ViewModel_
        {
            get { return this.viewModel_; }
            set
            {
                if (this.viewModel_ != value)
                {
                    this.viewModel_ = value;
                    //this.NotifyPropertyChanged("ViewModel_");
                }
            }
        }
        #endregion

        public string ItemCode_ { get; set; }

        public UnderlyingParameterInfo() 
        {
        
        }

        //private void setReferenceDate(DateTime referenceDate)
        //{
        //    foreach (UnderlyingParameter item in UnderlyingParameterList_)
        //    {
        //        item.ReferenceDate_ = referenceDate;
        //    }
        //}


        public List<UnderlyingParameter> UnderlyingParameterList_ { get; set; }
        

        public Matrix corrMatrix_ { get; set; }

        public void setUnderInfo(UnderlyingInfo underlyingInfo)
        {
            this.ItemCode_ = underlyingInfo.ItemCode_;
            UnderlyingParameterList_ = new List<UnderlyingParameter>();

            foreach (var item in underlyingInfo.Underlyings_)
            {
                UnderlyingParameter underPara = new UnderlyingParameter(this.ItemCode_);
                underPara.setUnderInfo(item);
                underPara.ReferenceDate_ = this.referenceDate_;
                
                this.UnderlyingParameterList_.Add(underPara);
            }
        }

        public void buildParameterXmlData(XmlWriter xmlWriter)
        {
            List<string> underStrList = new List<string>();

            xmlWriter.WriteStartElement("underlyingInfo");
                foreach (UnderlyingParameter item in UnderlyingParameterList_)
                {
                    item.buildParameterXmlData(xmlWriter);
                    underStrList.Add(item.Underlying_.KRCode_);
                }

                
                CorrelationLoader corrLoader = new CorrelationLoader();
                corrLoader.ReferenceDate_ = this.referenceDate_;
                //corrLoader.loadData();

                double corrValue = corrLoader.corr(underStrList[0], underStrList[1]);

                xmlWriter.WriteElementString("corr", corrValue.ToString());
            xmlWriter.WriteEndElement();
            //Matrix part

            //dim

            //diag

            //remain Part

        }

        public void underParaInfoFromXml(XmlNode node)
        {

            XmlNodeList underNodeList = node.SelectNodes("underlyingInfo/underlying");

            UnderlyingParameterList_ = new List<UnderlyingParameter>();

            foreach (XmlNode item in underNodeList)
            {
                UnderlyingParameter underPara = new UnderlyingParameter(this.ItemCode_);
                underPara.ReferenceDate_ = this.referenceDate_;
                this.UnderlyingParameterList_.Add(underPara);
                //underParaInfo.addUnderlying(item.InnerText);
            }
        }


    }
}
