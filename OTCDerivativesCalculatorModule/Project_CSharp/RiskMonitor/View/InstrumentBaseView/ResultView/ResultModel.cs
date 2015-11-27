using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace RiskMonitor{

    public abstract class ResultModel
    {
        #region ViewModel_
        protected ResultViewModel viewModel_;
        public ResultViewModel ViewModel_
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

        public abstract void setVM();

        // 기본
        public ResultModel()
        {
            // TODO: Complete member initialization
        }

        //public ResultModel(string itemCode,
        //           DateTime referenceDate)
        //{
        //    this.ItemCode = itemCode;
        //    this.ReferenceDate = referenceDate;
        //    this.UnitValue_ = 9999;
        //    this.Price_ = 9999;
        //}

        public ResultModel(string itemCode,
                           DateTime referenceDate,
                           double unitValue,
                           long price) 
        {
            this.ItemCode_ = itemCode;
            this.ReferenceDate_ = referenceDate;
            this.UnitPrice_ = unitValue;
            this.Price_ = price;
        }

        public string ItemCode_ { get; set; }
        public DateTime ReferenceDate_ { get; set; }

        public double UnitPrice_ { get; set; }
        public long Price_ { get; set; }

        public GreekResultInfo GreekResultInfo_ { get; set; }

        //protected Dictionary<string, object> additionalResults_ = new Dictionary<string, object>();

        public void loadFromXml(XmlNode node)
        {

            //this.ReferenceDate = node.SelectSingleNode("evaluationTime");
            //XmlNode resultNode = node.SelectSingleNode("pricingResult");
            XmlNode resultNode = node.SelectSingleNode("pricingResult");

            string unitValueStr = resultNode.SelectSingleNode("unitPrice").InnerText;
            string priceStr = resultNode.SelectSingleNode("price").InnerText;

            this.UnitPrice_ = Convert.ToDouble(unitValueStr);
            this.Price_ = Convert.ToInt64(priceStr) ;

            GreekResultInfo_ = new GreekResultInfo();
            GreekResultInfo_.loadFromXml(node);

        }

        internal void buildParametorXmlData(XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }
    }
}
