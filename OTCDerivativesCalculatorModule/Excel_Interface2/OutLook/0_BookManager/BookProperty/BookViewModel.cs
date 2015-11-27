using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

using System.Windows;

namespace Excel_Interface
{
    public class BookViewModel : IXmlData, IFolderAction
    {
        #region Event
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        #region Parent_
        private BookViewModel parent_;
        public BookViewModel Parent_
        {
            get { return this.parent_; }
            set
            {
                if (this.parent_ != value)
                {
                    this.parent_ = value;
                    this.NotifyPropertyChanged("Parent_");
                }
            }
        }
        #endregion

        public DateTime ReferenceDate_ { get; set; }
        private string bookPath_ = @"D:\Project File\OTCDerivativesCalculatorModule\testExcelAddinWPF\bin\Debug";

        public static BookViewModel CreateRootBookViewModel()
        {
            return new BookViewModel(null, "RootBook", "RootBookCode");
        }

        // empty book
        public BookViewModel()
        {
            this.bookCode_ = "nullCode";
            this.bookName_ = "nullBook";
        }

        public BookViewModel(BookViewModel parent) 
        {
            this.parent_ = parent;
            this.fontWeight_ = FontWeights.Normal;
            this.childBookList_ = new ObservableCollection<BookViewModel>();
            this.instrumentList_ = new ObservableCollection<Excel_instrumentViewModel>();

        }

        public BookViewModel(BookViewModel parent,
                             string bookName,
                             string bookCode) 
        {
            this.parent_ = parent;
            this.bookName_ = bookName;
            this.bookCode_ = bookCode;
            this.fontWeight_ = FontWeights.Normal;
            this.childBookList_ = new ObservableCollection<BookViewModel>();
            this.instrumentList_ = new ObservableCollection<Excel_instrumentViewModel>();

        }

        #region IsTreeExpand_
        private bool isTreeExpand_;
        public bool IsTreeExpand_
        {
            get { return this.isTreeExpand_; }
            set
            {
                if (this.isTreeExpand_ != value)
                {
                    this.isTreeExpand_ = value;
                    
                    this.updateBookInfo();

                    this.NotifyPropertyChanged("IsTreeExpand_");
                }
            }
        }

        private void isTreeExpandXmlSave()
        {
            System.Xml.XmlNode bookInfoNode = this.Node_["bookInfo"];


        }

        #endregion

        #region FontWeight_
        private FontWeight fontWeight_;
        public FontWeight FontWeight_
        {
            get { return this.fontWeight_; }
            set
            {
                if (this.fontWeight_ != value)
                {
                    this.fontWeight_ = value;
                    this.NotifyPropertyChanged("FontWeight_");
                }
            }
        }
        #endregion

        #region AbstractFlag_
        private string abstractFlag_;
        public string AbstractFlag_
        {
            get { return this.abstractFlag_; }
            set
            {
                if (this.abstractFlag_ != value)
                {
                    this.abstractFlag_ = value;
                    this.NotifyPropertyChanged("AbstractFlag_");
                }
            }
        }
        #endregion

        //#region BookPath_
        //private string bookPath_;
        //public string BookPath_
        //{
        //    get { return this.bookPath_; }
        //    set
        //    {
        //        if (this.bookPath_ != value)
        //        {
        //            this.bookPath_ = value;
        //            this.NotifyPropertyChanged("BookPath_");
        //        }
        //    }
        //}
        //#endregion

        #region BookName_
        private string bookName_;
        public string BookName_
        {
            get { return this.bookName_; }
            set
            {
                if (this.bookName_ != value)
                {
                    this.bookName_ = value;
                    this.NotifyPropertyChanged("BookName_");
                }
            }
        }
        #endregion

        #region BookCode_
        private string bookCode_;
        public string BookCode_
        {
            get { return this.bookCode_; }
            set
            {
                if (this.bookCode_ != value)
                {
                    this.bookCode_ = value;
                    this.NotifyPropertyChanged("BookCode_");
                }
            }
        }
        #endregion

        #region ChildBookList_
        private ObservableCollection<BookViewModel> childBookList_;
        public ObservableCollection<BookViewModel> ChildBookList_
        {
            get { return this.childBookList_; }
            set
            {
                if (this.childBookList_ != value)
                {
                    this.childBookList_ = value;
                    this.NotifyPropertyChanged("ChildBookList_");
                }
            }
        }
        #endregion

        #region InstrumentList_
        private ObservableCollection<Excel_instrumentViewModel> instrumentList_;
        public ObservableCollection<Excel_instrumentViewModel> InstrumentList_
        {
            get { return this.instrumentList_; }
            set
            {
                if (this.instrumentList_ != value)
                {
                    this.instrumentList_ = value;
                    this.NotifyPropertyChanged("InstrumentList_");
                }
            }
        }
        #endregion

        public System.Xml.XmlNode Node_;

        public void AddInstrument(Excel_instrumentViewModel e_instVM)
        {
            //e_ivm.ItemCode_ = "testInstrument";
            //foreach (var item in collection)
            //{
                
            //}
            this.instrumentList_.Add(e_instVM);

            System.Xml.XmlElement xmlEle
                = this.Node_.OwnerDocument.CreateElement("instrument");

            xmlEle.InnerText = e_instVM.Item_code_;

            this.Node_["instrumentList"].AppendChild(xmlEle);
        }

        //public void addTestInstrumentLoad()
        //{
        //    this.addInstrument();
        //}

        public void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("book");
                xmlWriter.WriteStartElement("bookInfo");
                    xmlWriter.WriteElementString("abstractFalg", this.abstractFlag_);
                    xmlWriter.WriteElementString("bookName", this.bookName_);
                    xmlWriter.WriteElementString("bookCode", this.bookCode_);
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("instrumentList");

                    foreach (var item in this.instrumentList_)
                    {
                        xmlWriter.WriteElementString("instrument", item.Item_code_);
                    }

                xmlWriter.WriteEndElement();

                foreach (var item in this.childBookList_)
                {
                    item.buildXml(xmlWriter);
                }

            xmlWriter.WriteEndElement();
        }

        //bookViewModel 및 childBook , instrument 를 초기화 하는 부분 from xmlfile
        public void setFromXml(System.Xml.XmlNode InstNode)
        {
            this.Node_ = InstNode;
            //InstNode["book"]["bookInfo"];

            System.Xml.XmlNode bookInfoNode
                = InstNode["bookInfo"];

            this.abstractFlag_ = bookInfoNode["abstract"].InnerText;

            string isExpandStr = bookInfoNode["isTreeExpand"].InnerText;

            if (isExpandStr.ToUpper() == "TRUE" || isExpandStr.ToUpper() == "T")
            {
                this.isTreeExpand_ = true;

            }
            else 
            {
                this.isTreeExpand_ = false;
            }
            

            this.bookName_ = bookInfoNode["bookName"].InnerText;
            this.bookCode_ = bookInfoNode["bookCode"].InnerText;

            if (this.abstractFlag_.ToUpper() != "TRUE" && this.abstractFlag_.ToUpper() != "T")
            {
                System.Xml.XmlNodeList instrumentListNodeList
                    = InstNode["instrumentList"].SelectNodes("instrument");

                foreach (System.Xml.XmlNode item in instrumentListNodeList)
                {
                    string instCode = item.InnerText;

                    //Excel_instrumentViewModel instrument = new Excel_instrumentViewModel();
                    
                    //instrument.Item_code_ = instCode;

                    //this.instrumentList_.Add(instrument);

                    if (MasterInformationViewModel.masterPositionMap_.ContainsKey(instCode))
                    {
                        this.instrumentList_.Add(MasterInformationViewModel.masterPositionMap_[instCode]);
                    }
                    else
                    {
                        this.instrumentList_.Add(new Excel_instrumentViewModel());
                    }
                    

                }
            }

            foreach (System.Xml.XmlNode item in InstNode.SelectNodes("book"))
            {
                BookViewModel childBook = new BookViewModel(this);

                childBook.setFromXml(item);

                this.childBookList_.Add(childBook);

            } 
            
        }

        public void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            throw new NotImplementedException();
        }

        public bool removeInstrument(Excel_instrumentViewModel e_ivm)
        {
            bool flag = false;

            foreach (var item in this.childBookList_)
            {
                flag = flag || item.removeInstrument(e_ivm);
            }

            System.Xml.XmlNodeList instrumentListNodeList
               = this.Node_["instrumentList"].SelectNodes("instrument");

            foreach (System.Xml.XmlNode item in instrumentListNodeList)
            {
                string code = item.InnerText;

                if (code == e_ivm.Item_code_ || e_ivm.Item_code_ == null )
                {
                    this.instrumentList_.Remove(e_ivm);
                    this.Node_["instrumentList"].RemoveChild(item);

                    flag = true;
                }
            }

            return flag;
        }

        public bool removeInstrument(string itemCode)
        {
            bool flag = false;

            System.Xml.XmlNodeList instrumentListNodeList
               = this.Node_["instrumentList"].SelectNodes("instrument");

            foreach (System.Xml.XmlNode item in instrumentListNodeList)
            {
                string code = item.InnerText;

                if (code == itemCode )
                {
                    this.Node_["instrumentList"].RemoveChild(item);

                    flag = true;
                }
            }

            return flag;
        }



        public void addBook(string bookName)
        {
            string bookCode = "testBookCode";

            BookViewModel bvm = new BookViewModel(this,bookName,bookCode);

            this.childBookList_.Add(bvm);

            System.Xml.XmlElement xmlEle = this.Node_.OwnerDocument.CreateElement("book");

            //bvm.Node_ = this.Node_;
            bvm.Node_ = xmlEle;

            xmlEle.InnerXml = this.emptyBookXmlStr(false, bookName, bookCode);

            this.Node_.AppendChild(xmlEle);

        }

        private string emptyBookXmlStr(bool abstractFlag,
                                       string bookName,
                                       string bookCode)
        {
            string str = "<bookInfo>" +
                            "<abstract>" + abstractFlag.ToString() + "</abstract>" +
                            "<isTreeExpand>True</isTreeExpand>" +
                            "<bookName>" + bookName + "</bookName>" +
                            "<bookCode>" + bookCode + "</bookCode>" +
                         "</bookInfo>" +
                         "<instrumentList />";

            return str;
        }


        public void removeThisBook()
        {
            this.Node_.ParentNode.RemoveChild(this.Node_);
            this.parent_.childBookList_.Remove(this);

        }

        public void loadMasterInformation()
        {
            foreach (var item in this.instrumentList_)
            {
                try
                {
                    item.MasterInformationViewModel_.loadMasterInfo(item.Item_code_);
                }
                catch (Exception)
                {
                    OutputLogViewModel.addResult("masterInfo load error - itemCode : " + item.Item_code_ + " bookName : " + this.bookName_);
                    //throw;
                }
                
            }

            foreach (var item in this.childBookList_)
            {
                item.loadMasterInformation();
            }
        }

        public void getEventList(ObservableCollection<EventViewModel> e_vmList,bool subBookInclude = false)
        {
            foreach (var item in this.instrumentList_)
            {
                ObservableCollection<EventViewModel> e_list = Excel_eventManagerViewModel.dbLoad(item.Item_code_);

                foreach (var e_vm in e_list)
                {
                    e_vmList.Add(e_vm);
                }
            }

            if (subBookInclude == true)
            {
                foreach (var item in this.childBookList_)
                {
                    item.getEventList(e_vmList);
                }
            }
        }

        public void getItemCode(List<string> itemCodeList)
        {
            foreach (var item in this.instrumentList_)
            {
                foreach (var e_vm in this.instrumentList_)
                {
                    itemCodeList.Add(e_vm.Item_code_);
                }
            }

            foreach (var item in this.childBookList_)
            {
                item.getItemCode(itemCodeList);
            }
        }

        public void getInstrument(List<Excel_instrumentViewModel> instList)
        {
            foreach (var item in this.instrumentList_)
            {
                instList.Add(item);
            }

            foreach (var item in this.childBookList_)
            {
                item.getInstrument(instList);
            }
        }


        public BookViewModel clone()
        {
            BookViewModel bvm = new BookViewModel(this.parent_);

            //이건 수정 가능 항목들
            bvm.bookCode_ = this.bookCode_;
            bvm.bookName_ = this.bookName_;

            //이건 수정 불가능 항목들
            bvm.Node_ = this.Node_;
            bvm.childBookList_ = this.childBookList_;
            bvm.instrumentList_ = this.instrumentList_;

            return bvm;
        }

        public void updateBookInfo()
        {
            System.Xml.XmlNode bookInfoNode = this.Node_["bookInfo"];

            bookInfoNode["isTreeExpand"].InnerText = this.isTreeExpand_.ToString();
            bookInfoNode["bookName"].InnerText = this.bookName_;
            bookInfoNode["bookCode"].InnerText = this.bookCode_;
        }

        public void bookInfoCopy(BookViewModel copyVM)
        {
            this.isTreeExpand_ = copyVM.IsTreeExpand_;
            this.bookCode_ = copyVM.BookCode_;
            this.bookName_ = copyVM.BookName_;

        }

        public bool hasTradeID(string tradeID)
        {
            bool tf = false;

            foreach (var inst in this.instrumentList_)
            {
                if (inst.Trade_id_ == tradeID)
                {
                    this.fontWeight_ = FontWeights.Bold;
                    tf = true;
                }
            }

            foreach (var cbook in this.childBookList_)
            {
                if (cbook.hasTradeID(tradeID))
                {
                    tf = true;
                }
                
            }

            return tf;
        }

        public void clearSelection()
        {
            this.fontWeight_ = FontWeights.Normal;
            
            foreach (var cbook in this.childBookList_)
            {
                cbook.clearSelection();
            }
            
        }

        public void refreshInstrument()
        {
            foreach (var item in this.instrumentList_)
            {
                item.loadDetailContext();
                item.dataContextRefesh();
            }
        }

        public void loadInstrument()
        {
            throw new NotImplementedException();
        }

        public void getBookList(List<BookViewModel> bookList)
        {
            foreach (var item in this.childBookList_)
            {
                item.getBookList(bookList);
            }

            bookList.Add(this);

        }

        public void booking(Excel_instrumentViewModel e_inst_sbvm)
        {
            
            e_inst_sbvm.bookingInstrument();
            MasterInformationViewModel.WholeMasterPosition_.Add(e_inst_sbvm);

            this.AddInstrument(e_inst_sbvm);

            XMLFileLoader.SaveInstrument(e_inst_sbvm);
        }


        public int removeBook(string bookCode)
        {
            int removedNum = 0;

            foreach (var item in this.childBookList_)
            {
                if (item.BookCode_ == bookCode || item.BookName_ == bookCode)
                {
                    item.removeThisBook();

                    removedNum += 1;
                }
            }

            foreach (var item in this.childBookList_)
            {
                removedNum += item.removeBook(bookCode);
            }

            return removedNum;
        }

        public void saveBookXml()
        {
            this.Node_.OwnerDocument.Save(bookPath_ + "\\" + "XMLFile1.xml");
        }
    }
}
