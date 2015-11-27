using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using QLNet;

namespace RiskMonitor
{
    public class UnderlyingInfo
    {
        #region ViewModel_
        protected UnderlyingInfoViewModel viewModel_;
        public UnderlyingInfoViewModel ViewModel_
        {
            get
            {
                //this.setVM();

                return this.viewModel_;
            }
            set
            {
                if (this.viewModel_ != value)
                {
                    this.viewModel_ = value;
                }
            }

        }
        #endregion

        #region Underlyings_
        private List<Underlying> underlyings_;
        public List<Underlying> Underlyings_
        {
            get { return this.underlyings_; }
            set
            {
                if (this.underlyings_ != value)
                {
                    this.underlyings_ = value;
                    //this.NotifyPropertyChanged("Underlyings_");
                }
            }
        }
        #endregion

        #region Corr_
        private double corr_;
        public double Corr_
        {
            get { return this.corr_; }
            set
            {
                if (this.corr_ != value)
                {
                    this.corr_ = value;
                    //this.NotifyPropertyChanged("Corr_");
                }
            }
        }
        #endregion

        public string ItemCode_ { get; set; }

        public Underlying this[int i] { get { return underlyings_[i]; } }

        public UnderlyingInfo(string itemCode) 
        {
            this.ItemCode_ = itemCode;
        }

        //public UnderlyingInfo(List<string> underCode) 
        //{
        //    this.underlyings_ = new List<Underlying>();
        //    foreach (string item in underCode)
        //    {
        //        this.underlyings_.Add(new Underlying(item));    
        //    }
        //}

        public void addUnderlying(Underlying under) 
        {
            this.underlyings_.Add(under);

        }

        public void addUnderlying(string krcode)
        {
            //this.underlyings_.Add(under);
        }

        public List<Underlying> underlyings()
        {
            return new List<Underlying>();
        }

        public void buildProductXmlData(XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("underlyingInformation");

            foreach (Underlying item in Underlyings_)
            {
                item.buildProductXmlData(xmlWriter);
            }
            
            xmlWriter.WriteEndElement();
        }

        public void underInfoFromXml(XmlNode node)
        {

            //// product에 종속함. 나중에 어떻게 할지 생각
            //XmlNode instCodeNode = node.SelectSingleNode("issueInformation");
            //string instCode = instCodeNode["krCode"].InnerText;
            //

            //XmlNode underInfoNode = node.SelectSingleNode("ELSStepDownRedemptions/underlyingInformation");

            XmlNodeList underNodeList = node.SelectNodes("underlying");

            this.underlyings_ = new List<Underlying>();

            foreach (XmlNode item in underNodeList)
            {
                Underlying under = new Underlying();
                under.loadFromXml(item);
                //under.InstCode_ = instCode;
                this.underlyings_.Add(under);
            }

        }

        //public void loadData(DateTime refereceDate, ParameterSetting setting) 
        //{
        //    foreach (Underlying item in Underlyings_)
        //    {
        //        item.loadData(refereceDate, setting);
        //    }
        //}

        //public void buildParametorXmlData(XmlWriter xmlWriter,ParameterSetting paraSetting)
        //{
        //    // Matrix 로 나중에 수정
        //    xmlWriter.WriteValue(this.Corr_);
            
        //    //CorrelationLoader corrLoader = new CorrelationLoader();
        //    //corrLoader.Method_ = this.ParameterSetting_;

        //    foreach (Underlying item in Underlyings_)
        //    {
        //        item.buildParametorXmlData(xmlWriter,paraSetting);
        //    }
        //}

    }
}
