//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.ComponentModel;
//using System.Collections.ObjectModel;
//using System.Xml;

//namespace RiskMonitor
//{
//    public class StepDownKIPayoff : PayoffInfo
//    {

//        #region RedemptionInfo_
//        private RedemptionInfo redemptionInfo_;
//        public RedemptionInfo RedemptionInfo_
//        {
//            get { return this.redemptionInfo_; }
//            set
//            {
//                if (this.redemptionInfo_ != value)
//                {
//                    this.redemptionInfo_ = value;
//                    this.NotifyPropertyChanged("RedemptionInfo_");
//                }
//            }
//        }
//        #endregion

//        #region KIEventInfo_
//        private KIEventInfo kiEventInfo_;
//        public KIEventInfo KIEventInfo_
//        {
//            get { return this.kiEventInfo_; }
//            set
//            {
//                if (this.kiEventInfo_ != value)
//                {
//                    this.kiEventInfo_ = value;
//                    this.NotifyPropertyChanged("KIEventInfo_");
//                }
//            }
//        }
//        #endregion

//        #region NonKIEventInfo_
//        private NonKIEventInfo nonKIEventInfo_;
//        public NonKIEventInfo NonKIEventInfo_
//        {
//            get { return this.nonKIEventInfo_; }
//            set
//            {
//                if (this.nonKIEventInfo_ != value)
//                {
//                    this.nonKIEventInfo_ = value;
//                    this.NotifyPropertyChanged("NonKIEventInfo_");
//                }
//            }
//        }
//        #endregion

//        public StepDownKIPayoff() 
//        {
        
//        }


//        public override void payoffInfoFromXml(XmlNode node)
//        {

           

//        }

//        public override void buildProductXmlData(XmlWriter xmlWriter)
//        {


//        }
        
//        //payoffInfo까지 올릴필요는 없고

       

//        #region Event

//        public event PropertyChangedEventHandler PropertyChanged;

//        private void NotifyPropertyChanged(string propertyName)
//        {
//            if (PropertyChanged != null)
//            {
//                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
//            }
//        }


//        #endregion



//    }
//}
