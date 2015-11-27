using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace RiskMonitor
{
    public class UnderlyingParameter : IMarketDataLoad
    {

        ParameterSetting Setting {   get;set;}

        public DateTime ReferenceDate_ { get; set; }

        public Underlying Underlying_ { get; set; }

        public string ItemCode_ { get; set; }


        public long CurrentValue_ { get; set; }
        public double Drift_ { get; set; }
        public double Dividend_ { get; set; }
        public double Vol_ { get; set; }

        private StockDataLoader stockDataLoader_;

        public UnderlyingParameter(string itemCode_) 
        {
            this.ItemCode_ = itemCode_;
        }

        public void setUnderInfo(Underlying under)
        {
            this.Underlying_ = under;

        }

        public void buildParameterXmlData(XmlWriter xmlWriter)
        {
            //load결정은 밖에서 함
            //내부 자동 load 안함
            //DateTime referenceDate = Settings.evaluationDate();
            //this.loadData(referenceDate, setting);
            this.marketDataLoad(ReferenceDate_);

            xmlWriter.WriteStartElement("underlying");

                xmlWriter.WriteElementString("krCode", this.Underlying_.KRCode_);
                xmlWriter.WriteElementString("underName", this.Underlying_.Name_);
                xmlWriter.WriteElementString("currentValue", Convert.ToString(this.CurrentValue_));

                xmlWriter.WriteElementString("drift", Convert.ToString(this.Drift_));
                xmlWriter.WriteElementString("dividend", Convert.ToString(this.Dividend_));    
                xmlWriter.WriteElementString("volatility", Convert.ToString(this.Vol_));

            xmlWriter.WriteEndElement();
        }


        public void marketDataLoad(DateTime ReferenceDate)
        {
            //stockDataLoader_ = new MROStockDataLoader();

            //stockDataLoader_.ReferenceDate_ = ReferenceDate;

            //stockDataLoader_.ItemCode_ = this.ItemCode_;
            //stockDataLoader_.UnderCode_ = this.Underlying_.KRCode_;

            //try
            //{
            //    stockDataLoader_.loadData();
            //    //Setting.stockDataLoader();
            //    this.Drift_ = stockDataLoader_.drift();
            //    this.Dividend_ = stockDataLoader_.dividend();
            //    this.Vol_ = stockDataLoader_.vol();
            //    this.CurrentValue_ = stockDataLoader_.currentValue();

            //}
            //catch (Exception e)
            //{
            //    throw;
            //}

        }


    }
}
