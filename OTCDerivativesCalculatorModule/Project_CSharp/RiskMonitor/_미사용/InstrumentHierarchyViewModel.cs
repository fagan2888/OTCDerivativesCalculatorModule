//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Windows.Controls;
//using System.ComponentModel;
//using System.Collections.ObjectModel;
//using System.IO;
//using System.Xml;

//namespace RiskMonitor
//{
//    //portpolio 처리를 위한 것
//    public class InstrumentHierarchyViewModel
//    {

//        public InstrumentHierarchyViewModel(InstrumentBaseViewModel instBaseViewModel)
//        {
//            this.instrumentBaseViewModel_ = instBaseViewModel;
//            this.fileInfo_ = instBaseViewModel.FileInfo_;
//            this.fileName_ = this.fileInfo_.Name;

//        }
//        //this.view

//        #region FileInfo_
//        private FileInfo fileInfo_;
//        public FileInfo FileInfo_
//        {
//            get { return this.fileInfo_; }
//            set
//            {
//                if (this.fileInfo_ != value)
//                {
//                    this.fileInfo_ = value;
//                    this.NotifyPropertyChanged("FileInfo_");
//                }
//            }
//        }
//        #endregion

//        #region FileName_
//        protected string fileName_;
//        public string FileName_
//        {
//            get { return this.fileName_; }
//            set
//            {
//                if (this.fileName_ != value)
//                {
//                    this.fileName_ = value;
//                    this.NotifyPropertyChanged("FileName_");
//                }
//            }
//        }
//        #endregion

//        #region InstName_
//        private string instName_;
//        public string InstName_
//        {
//            get { return this.instName_; }
//            set
//            {
//                if (this.instName_ != value)
//                {
//                    this.instName_ = value;
//                    this.NotifyPropertyChanged("InstName_");
//                }
//            }
//        }
//        #endregion

//        #region InstInformation

//        #region ProductName_
//        private string productName_;
//        public string ProductName_
//        {
//            get { return this.productName_; }
//            set
//            {
//                if (this.productName_ != value)
//                {
//                    this.productName_ = value;
//                    this.NotifyPropertyChanged("ProductName_");
//                }
//            }
//        }
//        #endregion

//        #region ProductType_
//        private string productType_;
//        public string ProductType_
//        {
//            get { return this.productType_; }
//            set
//            {
//                if (this.productType_ != value)
//                {
//                    this.productType_ = value;
//                    this.NotifyPropertyChanged("ProductType_");
//                }
//            }
//        }
//        #endregion

//        #region KRCode_
//        private string krCode_;
//        public string KRCode_
//        {
//            get { return this.krCode_; }
//            set
//            {
//                if (this.krCode_ != value)
//                {
//                    this.krCode_ = value;
//                    this.NotifyPropertyChanged("KRCode_");
//                }
//            }
//        }
//        #endregion

//        #endregion

//        #region InstrumentBaseViewModel_
//        private InstrumentBaseViewModel instrumentBaseViewModel_;
//        public InstrumentBaseViewModel InstrumentBaseViewModel_
//        {
//            get { return this.instrumentBaseViewModel_; }
//            set
//            {
//                if (this.instrumentBaseViewModel_ != value)
//                {
//                    this.instrumentBaseViewModel_ = value;
//                    this.NotifyPropertyChanged("InstrumentBaseViewModel_");
//                }
//            }
//        }
//        #endregion

//        public StackPanel view()
//        {
//            StackPanel panel = new StackPanel();
//            panel.Orientation = Orientation.Vertical;

//            //panel.Children.Add(instrumentViewModel_.InstInfomationView_);
//            //panel.Children.Add(instrumentViewModel_.UnderView_);
//            //panel.Children.Add(instrumentViewModel_.PayoffView_);

//            //instrumentViewModel_.loadProduct(); //? 뭘 로드함? 우선 그림 그리고 나중에 load해서 바인딩함. 초기화부터 함.
//            //panel.Children.Add(instrumentViewModel_.InstrumentView_);
//            InstrumentBaseView instBaseView = new InstrumentBaseView();
//            this.instrumentBaseViewModel_.loadAll();
//            //this.instrumentBaseViewModel_.loadParaResult();
//            instBaseView.ViewModel_ = this.instrumentBaseViewModel_;
//            //instBaseView.ViewModel_.loadProduct();
//            panel.Children.Add(instBaseView);

//            //stackPanel 패널을 하나 만들고 거기다가 add함
//            return panel;
//        }


//        //save 어떻게 할지 생각 2013-08-06


//        public void saveParaResult(DateTime referenceDate)
//        {
//            OutputLogViewModel.addResult(new ProcessOutput(this.instName_,
//                                                           this.krCode_,
//                                                           "Making Xml File..."));

//            this.instrumentBaseViewModel_.ReferenceDate_ = referenceDate;
//            this.instrumentBaseViewModel_.saveParaResult();

//            OutputLogViewModel.addResult(new ProcessOutput(this.instName_,
//                                                           this.krCode_,
//                                                           "Complete Making Xml File..."));
//        }

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
