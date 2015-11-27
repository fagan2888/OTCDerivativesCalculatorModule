//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.IO;
//using System.Xml;
//using System.Windows.Controls;
//using System.ComponentModel;
//using System.Collections.ObjectModel;
//using QLNet;

//namespace RiskMonitor
//{
//    //Xml DataLoader

//    // View 따른 구분
//    public enum InstrumentType { StepDownKIType, StopLossType , StandardOptionType };

//    public class InstrumentDataLoader
//    {
//        public InstrumentDataLoader(string portfolioPath) 
//        {
//            this.portfolioPath_ = portfolioPath;
//        }

//        #region PortfolioPath_
//        private string portfolioPath_;
//        public string PortfolioPath_
//        {
//            get { return this.portfolioPath_; }
//            set
//            {
//                if (this.portfolioPath_ != value)
//                {
//                    this.portfolioPath_ = value;
//                    this.NotifyPropertyChanged("PortfolioPath_");
//                }
//            }
//        }
//        #endregion

//        #region EngineSetting_
//        private EngineSetting engineSetting_;
//        public EngineSetting EngineSetting_
//        {
//            get { return this.engineSetting_; }
//            set
//            {
//                if (this.engineSetting_ != value)
//                {
//                    this.engineSetting_ = value;
//                    this.NotifyPropertyChanged("EngineSetting_");
//                }
//            }
//        }
//        #endregion

//        public ObservableCollection<InstrumentHierarchyViewModel> listLoad()
//        {
//            ObservableCollection<InstrumentHierarchyViewModel> instList = new ObservableCollection<InstrumentHierarchyViewModel>();

//            //string[] filePaths = Directory.GetFiles(@"c:\MyDir\", "*.bmp",SearchOption.AllDirectories);
            
//            string[] filePaths = Directory.GetFiles(portfolioPath_, "*.xml", SearchOption.AllDirectories);


//            //foreach (string item in filePaths)
//            //{
//            //    InstrumentViewModel inst = this.instViewModel(item);
                
//            //    instList.Add(inst);
//            //}

//            XmlDocument portDoc = new XmlDocument();

//            foreach (string xmlFile in filePaths)
//            {
//                portDoc.Load(xmlFile);    
//            }

//            XmlNodeList list = portDoc.SelectNodes("ItemList");

//            foreach (XmlNode node in list)
//            {
//                string instType = node.Name;
//                string filePath = node.Attributes["file"].Name;

//                //instList.Add(this.instViewModel(filePath,instType));
//            }

//            return instList;

//        }

//        public ObservableCollection<InstrumentHierarchyViewModel> listLoad_test() 
//        {

//            ObservableCollection<InstrumentHierarchyViewModel> instList = new ObservableCollection<InstrumentHierarchyViewModel>();

//            //string[] filePaths = Directory.GetFiles(@"c:\MyDir\", "*.bmp",SearchOption.AllDirectories);

//            string[] filePaths = Directory.GetFiles(portfolioPath_, "*.xml", SearchOption.TopDirectoryOnly);

//            //foreach (string item in filePaths)
//            //{
//            //    InstrumentViewModel inst = this.instViewModel(item);

//            //    instList.Add(inst);
//            //}

//            //XmlDocument portDoc = new XmlDocument();
//            XmlDocument instXml = new XmlDocument();

//            foreach (string item in filePaths)
//            {
//                InstrumentBaseViewModel instBaseVM;
//                XmlNode InstNode;
//                string itemCode = "";
//                string instrumentTypeStr = "";

//                try
//                {
//                    instXml.Load(item);
//                    InstNode = instXml.SelectSingleNode("instrument");
//                }
//                catch (Exception)
//                {
//                    InstNode = null;
//                }

//                if (InstNode != null)
//                {
//                    XmlAttribute typeAtt = InstNode.Attributes["Type"];

//                    if (typeAtt != null)
//                    {
//                        instrumentTypeStr = InstNode.Attributes["Type"].Value;
//                        XmlNode headerNode = InstNode.SelectSingleNode("header/krCode");
//                        itemCode = headerNode.InnerText;
//                    }

//                    FileInfo fileInfo = new FileInfo(item);
//                    instBaseVM = instrumentVMHeader_loader_test(itemCode, fileInfo, instrumentTypeStr);

//                    if (instBaseVM != null)
//                    {
//                        InstrumentHierarchyViewModel instHierachyVM = new InstrumentHierarchyViewModel(instBaseVM);
//                        instHierachyVM.setBaseInfo(InstNode);

//                        instList.Add(instHierachyVM);
//                    }
//                    else
//                    {
//                        //error에 추가
//                    }
//                }
//                //}
                
                
//            }
//            return instList;
//        }

//        //type 별로 VM을 link 해주는 함수.( class로 빼야 하나? )
//        private InstrumentBaseViewModel instrumentVMHeader_loader_test(string itemCode,FileInfo fileInfo, string instrumentTypeStr) 
//        {
//            InstrumentBaseViewModel instBaseVM;

//            if (instrumentTypeStr.ToUpper() == "STEPDOWN")
//            {
//                instBaseVM = new StandardInstBaseViewModel(itemCode,fileInfo);
//            }
//            else 
//            {
//                instBaseVM = null;
//            }

//            return instBaseVM;
            

//            //if (InstNode != null)
//            //{
//            //    //instInfo.loadFromXml(InstNode);

                

//            //    if (instrumentTypeStr.ToUpper() == "STEPDOWN")
//            //    {
//            //        instBaseVM = new StepDownKIBaseViewModel(filePath);
//            //        //instBaseVM.InstInfoViewModel_ = new InstrumentInformationViewModel(instInfo);
//            //        return instBaseVM;
//            //    }
//            //    else if (instrumentTypeStr.ToUpper() == "CREDIT")
//            //    {
//            //        //instBaseVM = new NthDefaultCLNViewModel(filePath);
//            //        //instBaseVM.InstInfoViewModel_ = new InstrumentInformationViewModel(instInfo);
//            //        //return instBaseVM;
//            //    }
//            //    else
//            //    {
//            //        //return instBaseVM = new NullInstrumentViewModel();
//            //    }
//            //}
//            //else
//            //{
//            //    //return instBaseVM = new NullInstrumentViewModel();
//            //}

            
            
//        }


//        //private InstrumentHierarchyViewModel instViewModel(string fileName, string instType) 
//        //{
//        //    //XmlDocument xmlInst = new XmlDocument(fileName);
//        //    XmlDocument xmlInst = new XmlDocument();
            
//        //    InstrumentViewModel instVM = new InstrumentViewModel(fileName);

//        //    InstrumentHierarchyViewModel instHierarchyVM = new InstrumentHierarchyViewModel(instVM); 
            
//        //    InstrumentInformation instInfo = this.buildInstInfo(xmlInst);
//        //    UnderlyingInfo underInfo = this.buildUnderInfo(xmlInst);

//        //    MCEngine engine = new MCEngine(0.0265, 10000);

//        //    InstrumentViewBuilder instrumentViewBuilder;
            
//        //    MCInstrument inst;

//        //    string type = "StandardOption";

//        //    if (type == "StandardOption")
//        //    {
//        //        inst = this.standardOption(instInfo, underInfo, engine);

//        //        //instVM.Instrument_ = inst;

//        //        instrumentViewBuilder = new StandardOptionViewBuilder();
//        //        instrumentViewBuilder.setView(instVM);
                
//        //    }
//        //    else if (type == "StandardOption")
//        //    {
//        //        inst = this.standardOption(instInfo, underInfo, engine);

//        //        instrumentViewBuilder = new StandardOptionViewBuilder();
//        //        instrumentViewBuilder.setView(instVM);
//        //    }
//        //    else if (type == "StandardOption")
//        //    {
//        //        inst = this.standardOption(instInfo, underInfo, engine);
//        //        instrumentViewBuilder = new StandardOptionViewBuilder();
//        //        instrumentViewBuilder.setView(instVM);
//        //    }
//        //    else if (type == "StandardOption")
//        //    {
//        //    }
//        //    else if (type == "StandardOption")
//        //    {
//        //    }
//        //    else if (type == "StandardOption")
//        //    {
//        //    }
//        //    else if (type == "StandardOption")
//        //    {
//        //    }
//        //    else
//        //    {
//        //    }

//        //    return instHierarchyVM;

//        //}

//        //#region Common Information builder - UnderlyingInfo , InstInfo
//        //private UnderlyingInfo buildUnderInfo(XmlDocument xmlInst)
//        //{
//        //    UnderlyingInfo unders = new UnderlyingInfo();

//        //    unders.Underlyings_ = new List<Underlying>();

//        //    //unders.Underlyings_.Add(new Underlying("한국전력"));
//        //    //unders.Underlyings_.Add(new Underlying("SK이노베이션"));

//        //    return unders;
//        //}

//        //private InstrumentInformation buildInstInfo(XmlNode instNode) 
//        //{
//        //    //

//        //    // info Node를 발라냄
//        //    //XmlNode infoNode = new XmlNode();
//        //    XmlNode infoNode = instNode;

//        //    // node 에서 필요한 정보 발라냄

//        //    string productName = "";
//        //    string productType = "";
//        //    DateTime tradeDate = new DateTime();
//        //    DateTime effectiveDate = new DateTime();
//        //    DateTime maturityDate = new DateTime();

//        //    long notional = 10000;
//        //    string currency = "KRW";

//        //    long premium = 200;
//        //    string premiumCurrency = "KRW";

//        //    DateTime paymentDate = new DateTime();

//        //    //InstrumentInformation instInfo = new InstrumentInformation(productName,
//        //    InstrumentInformation instInfo = new InstrumentInformation();

//        //    return instInfo;
        
//        //}
//        //#endregion

//        // 각각 Type 별 생성함.
//        //private StandardOption standardOption(InstrumentInformation instInfo,UnderlyingInfo underInfo,MCEngine engine) 
//        //{

//        //    List<Date> cashFlowDates = new List<Date>();

//        //    Date date1 = new Date(25, 10, 2012);
//        //    Date date2 = new Date(25, 4, 2013);
//        //    Date date3 = new Date(25, 10, 2013);
//        //    Date date4 = new Date(25, 4, 2014);
//        //    Date date5 = new Date(25, 10, 2014);
//        //    Date date6 = new Date(25, 4, 2015);

//        //    cashFlowDates.Add(date1); cashFlowDates.Add(date2);
//        //    cashFlowDates.Add(date3); cashFlowDates.Add(date4);
//        //    cashFlowDates.Add(date5); cashFlowDates.Add(date6);

//        //    List<PathMultiPayoff> payoffs = new List<PathMultiPayoff>();

//        //    payoffs.Add(new ConstPayoff(0.01));
//        //    payoffs.Add(new ConstPayoff(0.01));
//        //    payoffs.Add(new ConstPayoff(0.01));
//        //    payoffs.Add(new ConstPayoff(0.01));
//        //    payoffs.Add(new ConstPayoff(0.01));
//        //    payoffs.Add(new ConstPayoff(0.01));

//        //    List<EventDomain> domain = new List<EventDomain>();

//        //    domain.Add(new EventDomain());
//        //    domain.Add(new EventDomain());
//        //    domain.Add(new EventDomain());
//        //    domain.Add(new EventDomain());
//        //    domain.Add(new EventDomain());
//        //    domain.Add(new EventDomain());

//        //    StandardOptionPricer pricer = new StandardOptionPricer(cashFlowDates, payoffs, domain);

//        //    StandardOption standardOption = new StandardOption(instInfo,underInfo,pricer,engine);

//        //    return standardOption;
//        //}

//        public event PropertyChangedEventHandler PropertyChanged;

//        private void NotifyPropertyChanged(string propertyName)
//        {
//            if (PropertyChanged != null)
//            {
//                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
//            }
//        }



//    }
//}
