//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Xml;

//namespace RiskMonitor
//{
//    public class Instrument
//    {
//        #region ViewModel_
//        protected InstrumentViewModel viewModel_;
//        public InstrumentViewModel ViewModel_
//        {
//            get 
//            {
//                //this.setVM();

//                return this.viewModel_; 
//            }
//            set
//            {
//                if (this.viewModel_ != value)
//                {
//                    this.viewModel_ = value;
//                }
//            }

//        }
//        #endregion

//        protected abstract void setVM();

//        //public Instrument() 
//        //{
//        //    //instXml_ = new XmlDocument();
//        //    //parametorXml_ = new XmlDocument();
            
//        //}

//        #region later use
        
//        public Instrument(List<ELSUnderlyingStock> Underlying_,
//                          string PortfolioName)
//        { 
        
//        }

//        #endregion


//        public abstract void calculate();

//        public abstract void buildProductXmlData(XmlWriter xmlWriter);

//        public abstract void instrumentFromXml(XmlNode instNode);
        
//        //public abstract void instInfoFromXml(XmlNode node);
//        //public abstract void underInfoFromXml(XmlNode node);
//        //public abstract void payoffInfoFromXml(XmlNode node);


//        //public abstract void setInstInfo(string instInfoType);
//        //public abstract void setUnderInfo(string underType);
//        //public abstract void setPayoffInfo(string instInfoType);
//    }
//}
