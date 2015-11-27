using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using QLNet;

namespace RiskMonitor
{
    public class Underlying
    {

        #region ViewModel_
        private UnderlyingViewModel viewModel_;
        public UnderlyingViewModel ViewModel_
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

        #region Master
        
        // 밑으로 내릴거임 상품에 종속하는 거라
        public string InstCode_ { get; set; }

        public string Name_ { get; set; }
        public string KRCode_ { get; set; }
        public double BasePrice_ { get; set; }
        
        #endregion

        #region Daily   
        
        public long CurrentValue_ { get; set; }
        public double Drift_ { get; set; }
        public double Dividend_ { get; set; }
        public double Vol_ { get; set; }

        #endregion

        public DateTime ReferenceDate_ { get; set; }
        public UnderlyingLoader Loader_ { get; set; }

        public enum UnderlyingGroupType { Stock, Commodity, IR, ETC }

        public UnderlyingGroupType groupType_ { get; set; }

        public Underlying()
        { 
        }

        private void setVM()
        {
            this.viewModel_ = new UnderlyingViewModel();
            //this.viewModel_.setUnderlyingVM(this);
        }
        
        public void loadFromXml(XmlNode node)
        {
            this.KRCode_ = node["krCode"].InnerText;
            this.Name_ = node["name"].InnerText;
            this.BasePrice_ = Convert.ToInt64(node["basePrice"].InnerText);

            this.setVM();
        }

        //internal Handle<Quote> quoteValue(QLNet.Date today)
        //{
        //    throw new NotImplementedException();
        //}

        //public void loadData(DateTime refereceDate,ParameterSetting setting) 
        //{

        //    this.ReferenceDate_ = refereceDate;

        //    //UnderlyingLoader underLoader = new UnderlyingLoader(setting);
        //    UnderlyingLoader underLoader = new MROUnderlyingLoader(setting);
        //    underLoader.ReferenceDate_ = refereceDate;

        //    underLoader.StockKRCode_ = this.KRCode_;
        //    underLoader.InstCode_ = this.InstCode_;

        //    this.CurrentValue_ = underLoader.currentValue();

        //    //YieldTS ?
        //    this.Drift_ = underLoader.drift();
        //    this.Dividend_ = underLoader.dividend();
        //    this.Vol_ = underLoader.vol();
            
        //}

        // 상품별 Underlying에서 추가적인 것들을 구현. Ex) basePrice
        public virtual void buildProductXmlData(XmlWriter xmlWriter) 
        {
            xmlWriter.WriteStartElement("underlying");

                xmlWriter.WriteStartElement("krcode");
                    xmlWriter.WriteValue(this.KRCode_);
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("name");
                    xmlWriter.WriteValue(this.Name_);
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("basePrice");
                    xmlWriter.WriteValue(this.BasePrice_);
                xmlWriter.WriteEndElement();

            xmlWriter.WriteEndElement();
        }

        //public virtual void buildParametorXmlData(XmlWriter xmlWriter, ParameterSetting setting)
        //{
        //    //load결정은 밖에서 함
        //    //내부 자동 load 안함
        //    //DateTime referenceDate = Settings.evaluationDate();
        //    //this.loadData(referenceDate, setting);

        //    xmlWriter.WriteStartElement("underlying");

        //        xmlWriter.WriteStartElement("krcode");
        //            xmlWriter.WriteValue(this.KRCode_);
        //        xmlWriter.WriteEndElement();
        //            xmlWriter.WriteStartElement("currentValue");
        //        xmlWriter.WriteValue(this.CurrentValue_);
        //            xmlWriter.WriteEndElement();
        //        xmlWriter.WriteStartElement("drift");
        //            xmlWriter.WriteValue(this.Drift_);
        //        xmlWriter.WriteEndElement();
        //            xmlWriter.WriteStartElement("dividend");
        //        xmlWriter.WriteValue(this.Dividend_);
        //            xmlWriter.WriteEndElement();
        //        xmlWriter.WriteStartElement("volatility");
        //            xmlWriter.WriteValue(this.Vol_);
        //        xmlWriter.WriteEndElement();

        //    xmlWriter.WriteEndElement();
        //}


    }
}
