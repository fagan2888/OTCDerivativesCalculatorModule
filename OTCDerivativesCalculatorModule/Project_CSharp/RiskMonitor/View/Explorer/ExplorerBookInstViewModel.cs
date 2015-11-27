using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Xml;
using System.Windows.Controls;
using System.IO;

namespace RiskMonitor
{
    public class ExplorerBookInstViewModel : IXmlData
    {

        #region View_
        protected Control view_;
        public Control View_
        {
            get { return this.view_; }
            set
            {
                if (this.view_ != value)
                {
                    this.view_ = value;
                    this.NotifyPropertyChanged("View_");
                }
            }
        }
        #endregion

        #region InstHierarchyList_
        private ObservableCollection<ExploreHirachyVMWrapper> instHierarchyList_;
        public ObservableCollection<ExploreHirachyVMWrapper> InstHierarchyList_
        {
            get { return this.instHierarchyList_; }
            set
            {
                if (this.instHierarchyList_ != value)
                {
                    this.instHierarchyList_ = value;
                    this.NotifyPropertyChanged("InstHierarchyList_");
                }
            }
        }
        #endregion

        private void sortinstList()
        { }

        public XmlDocument BookInfoXml_ { get; set; }

        private BookInfoViewModel bookInfoVM_ { get; set; }
        private MainWindow mainWindow_;

        public ExplorerBookInstViewModel(MainWindow mainWindow,BookInfoViewModel bookInfoVM)
        {
            this.mainWindow_ = mainWindow;
            this.bookInfoVM_ = bookInfoVM;
            this.loadBookInfo();
            this.view_ = new ExplorerBookInstView(mainWindow, bookInfoVM_);
            this.view_.DataContext = this;
        }

        public void loadBookInfo()
        {
            //FileInfo file = bookInfoVM_.BookFile_;

            //XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.Load(file.FullName);

            XmlNode node = this.bookInfoVM_.BookInfoXml_;

            XmlNode bookInfoNode = node.SelectSingleNode("/bookInformation");
            FpmlSerializedCSharp.BookInformation serial_bookInfo = new FpmlSerializedCSharp.BookInformation(bookInfoNode);

            this.instHierarchyList_ = new ObservableCollection<ExploreHirachyVMWrapper>();

            //this.PathURLInfo_ = this.bookInfoVM_.PathURLInfo_;

            //DirectoryInfo directoryInfo = new DirectoryInfo(this.PathURLInfo_);

            foreach (var item in serial_bookInfo.InstrumentList_.InstHirachyInfo_)
            {
                //FileInfo fileInfo = new FileInfo(directoryInfo.FullName + itemCode + "_" + itemType + ".xml");

                InstUriInfo instUri =  this.bookInfoVM_.InstUri(item);
                //ResultUriInfo resultUri = this.bookInfoVM_.resultUri(item);

                InstrumentBaseViewModel instBaseVM = InstrumentBaseViewModel.CreateInstBaseVM(instUri);

                //ExploreHirachyInstrumentVMWrapper hirachyInstVMWrapper
                //    = new ExploreHirachyInstrumentVMWrapper(itemCode, itemType, instBaseVM);

                //ExploreHirachyVMWrapper hirachyInstVMWrapper = ExploreHirachyVMWrapper.CreateExploreHirachyWrapper(instUri, resultUri, instBaseVM);
                ExploreHirachyVMWrapper hirachyInstVMWrapper = ExploreHirachyVMWrapper.CreateExploreHirachyWrapper(instBaseVM);

                hirachyInstVMWrapper.setFromSerial(item);

                this.hirachyLoop(item, hirachyInstVMWrapper);

                this.instHierarchyList_.Add(hirachyInstVMWrapper);
            }


        }

        public void saveBookInfo()
        {
            this.sortinstList();

            this.BookInfoXml_ = new XmlDocument();

            StringBuilder sb = new StringBuilder();
            XmlWriterSettings setting = new XmlWriterSettings();

            setting.Indent = true;
            //setting.Encoding = Encoding.UTF8;

            XmlWriter xmlWriter = XmlWriter.Create(sb, setting);

            xmlWriter.WriteProcessingInstruction("xml", "version='1.0' encoding='UTF-8'");

            xmlWriter.WriteStartElement("instrumentList");

            this.buildXml(xmlWriter);

            xmlWriter.WriteEndElement();

            xmlWriter.Close();

            this.BookInfoXml_.LoadXml(sb.ToString());
        }

        //public InstrumentDataLoader dataLoader_;

        public void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            foreach (var item in instHierarchyList_)
            {
                item.buildXml(xmlWriter);
            }
        }

        public void setFromXml(System.Xml.XmlNode InstNode)
        {
            //XmlNode bookInfoNode = InstNode.SelectSingleNode("/bookInformation");
            //FpmlSerializedCSharp.BookInformation serial_bookInfo = new FpmlSerializedCSharp.BookInformation(bookInfoNode);
            //this.setFromSerial(serial_bookInfo);
        }

        public void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {

        }

        private void hirachyLoop(FpmlSerializedCSharp.InstHirachyInfo serial_Hirachy,
                                 HirachyInstrumentVM roop_ExploreHirachyInstWrapper)
        {
            foreach (var item in serial_Hirachy.InstHirachyInfo_)
            {
                string itemCode = item.Code_.ValueStr;
                string itemType = item.Type_.ValueStr;

                InstUriInfo instUri = bookInfoVM_.InstUri(item);
                //ResultUriInfo resultUri = bookInfoVM_.resultUri(item);

                //FileInfo fileInfo = new FileInfo(itemCode + "_" + itemType + ".xml");

                InstrumentBaseViewModel instBaseVM = InstrumentBaseViewModel.CreateInstBaseVM(instUri);

                //ExploreHirachyInstrumentVMWrapper hirachyInstVMWrapper 
                //    = new ExploreHirachyInstrumentVMWrapper(itemCode, itemType, instBaseVM);

                //ExploreHirachyVMWrapper hirachyInstVMWrapper = ExploreHirachyVMWrapper.CreateExploreHirachyWrapper(instUri, resultUri, instBaseVM);
                ExploreHirachyVMWrapper hirachyInstVMWrapper = ExploreHirachyVMWrapper.CreateExploreHirachyWrapper(instBaseVM);

                this.hirachyLoop(item, hirachyInstVMWrapper);

                roop_ExploreHirachyInstWrapper.addHirachInstrumentVM(hirachyInstVMWrapper);

            }

        }

        //void load() 
        //{
        //    //string path = @"F:\Users\ahn\Desktop\OTCDerivativesCalculatorModule\Project_CSharp\RiskMonitor\XmlFile\";

        //    dataLoader_ = new InstrumentDataLoader(PortfolioPath_);
        //    //dataLoader_ = new InstrumentDataLoader(path);
        //    //상품 list 정보가 있는 xml을 받음
        //    this.instHierarchyList_ = dataLoader_.listLoad_test();

        //    // build hierarchy view model

        //}

        //public void Add(InstrumentBaseViewModel instBaseVM)
        //{
        //    this.instHierarchyList_.Add(new InstrumentHierarchyViewModel(instBaseVM));
        //}

        //public void calculate()
        //{
        //    foreach (var item in instHierarchyList_)
        //    {
        //        item.calculate();
        //    }
        //}

        #region Event

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

    }
}
