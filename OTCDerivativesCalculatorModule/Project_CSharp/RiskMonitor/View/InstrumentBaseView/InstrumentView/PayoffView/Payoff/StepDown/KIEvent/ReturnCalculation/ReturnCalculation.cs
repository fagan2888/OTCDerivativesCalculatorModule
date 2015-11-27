using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace RiskMonitor
{
    public abstract class ReturnCalculation
    {

        #region ViewModel_
        protected ReturnCalculationViewModel viewModel_;
        public ReturnCalculationViewModel ViewModel_
        {
            get
            {
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

        protected abstract void setVM();

        public abstract void loadFromXml(XmlNode node);
        public abstract void buildProductXmlData(XmlWriter xmlWriter);

    }
}
