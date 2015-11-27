//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Xml;

//namespace RiskMonitor
//{
//    public class NonKIEventInfo
//    {

//        public NonKIEventInfo() 
//        {
            
//        }

//        #region ViewModel_
//        private NonKIEventViewModel viewModel_;
//        public NonKIEventViewModel ViewModel_
//        {
//            get
//            {
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

//        #region ReturnCalculation_
//        private ReturnCalculation returnCalculation_;
//        public ReturnCalculation ReturnCalculation_
//        {
//            get
//            {
//                return this.returnCalculation_;
//            }
//            set
//            {
//                if (this.returnCalculation_ != value)
//                {
//                    this.returnCalculation_ = value;
//                }
//            }
//        }
//        #endregion

//        public double ReturnValue_ { get; set; }

//        public void loadFromXml(XmlNode node)
//        {
//        }

//        private void setVM()
//        {
//            this.viewModel_ = new NonKIEventViewModel();
//            this.viewModel_.setNonKIEventVM(this);
//        }

//        public void buildProductXmlData(XmlWriter xmlWriter)
//        {

//        }
//    }
//}
