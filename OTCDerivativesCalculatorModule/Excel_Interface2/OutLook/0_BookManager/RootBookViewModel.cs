using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Xml;


namespace Excel_Interface
{
    public class RootBookViewModel : IFileAction
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

        private static DateTime rootBookReferenceDate_;
        //private DateTime ReferenceDate_;

        public static void setRootBookReferenceDate(DateTime d)
        {
            rootBookReferenceDate_ = d;
        }

        public static DateTime rootBookReferenceDate()
        {
            return rootBookReferenceDate_;
        }

        private XmlDocument bookXml_;
        //private string bookPath_ = @"D:\Project File\OTCDerivativesCalculatorModule\Excel_Interface2\OutLook";
        //private string bookPath_ = System.IO.Directory.GetCurrentDirectory();
        private string bookPath_ = @"D:\Project File\OTCDerivativesCalculatorModule\testExcelAddinWPF\bin\Debug";

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

        #region AncestorBookViewModel_
        private BookViewModel ancestorBookViewModel_;
        public BookViewModel AncestorBookViewModel_
        {
            get { return this.ancestorBookViewModel_; }
            set
            {
                if (this.ancestorBookViewModel_ != value)
                {
                    this.ancestorBookViewModel_ = value;
                    this.NotifyPropertyChanged("AncestorBookViewModel_");
                }
            }
        }
        #endregion

        public RootBookViewModel()
        {
            MasterInformationViewModel.loadWholeMasterPosition();

            this.ancestorBookViewModel_ = BookViewModel.CreateRootBookViewModel();

            //this.ancestorBookViewModel_.IsTreeExpand_ = true;
            this.ancestorBookViewModel_.BookName_ = "RootBook";
            this.ancestorBookViewModel_.BookName_ = "RootBookCode";

            //this.childBookList_ = new ObservableCollection<BookViewModel>();

            //BookViewModel wholeBook = new BookViewModel();

            //wholeBook.BookName_ = "wholeBook";

            //wholeBook.addBook();
            //wholeBook.addBook();

            //this.childBookList_.Add(wholeBook);

            //BookViewModel wholeBook2 = new BookViewModel();

            //wholeBook2.BookName_ = "wholeBook2";

            //wholeBook2.addBook();
            //wholeBook2.addBook();
            //wholeBook2.addBook();

            //this.childBookList_.Add(wholeBook2);
            
        }

        // book 에 있는 position들을 load함.
        public void loadPosition()
        {
            this.bookXml_ = new XmlDocument();

            this.childBookList_ = new ObservableCollection<BookViewModel>();
            this.childBookList_.Add(this.ancestorBookViewModel_);

            //string bookPath = @"D:\Project File\OTCDerivativesCalculatorModule\Excel_Interface2\OutLook\";
            bookXml_.Load(bookPath_ + "\\" +"XMLFile1.xml");

            System.Xml.XmlNode positionFolderNode
                = bookXml_["positionFolder"];

            this.ancestorBookViewModel_.Node_ = positionFolderNode;
            
            System.Xml.XmlNode bookInfoNode
                = positionFolderNode["bookInfo"];

            this.ancestorBookViewModel_.IsTreeExpand_ = Convert.ToBoolean(bookInfoNode["isTreeExpand"].InnerText);
            this.ancestorBookViewModel_.BookName_ = bookInfoNode["bookName"].InnerText;
            this.ancestorBookViewModel_.BookCode_ = bookInfoNode["bookCode"].InnerText;

            foreach (System.Xml.XmlNode item in positionFolderNode.SelectNodes("book"))
            {
                BookViewModel childBook = new BookViewModel(this.ancestorBookViewModel_);

                childBook.setFromXml(item);

                this.ancestorBookViewModel_.ChildBookList_.Add(childBook);
            } 
        
        }

        //chile북의 master를 죄다 로드함. from db
        // 처음부터 한방에 되다 로드할지는 미정(효율성을 위해서)
        public void loadChildBookMasterInfo()
        {
            foreach (var item in this.childBookList_)
            {
                item.loadMasterInformation();
            }
        }

        public List<string> getWholeItemCode()
        {
            List<string> itemCodeList = new List<string>();

            foreach (var item in this.childBookList_)
            {
                item.getItemCode(itemCodeList);
            }

            return itemCodeList;
        }

        public List<Excel_instrumentViewModel> getWholeInstrument()
        {
            List<Excel_instrumentViewModel> instList = new List<Excel_instrumentViewModel>();

            foreach (var item in this.childBookList_)
            {
                item.getInstrument(instList);
            }

            return instList;
        }

        public void buildInstrument()
        {
            try
            {
                this.bookXml_ = new XmlDocument();

                StringBuilder sb = new StringBuilder();
                XmlWriterSettings setting = new XmlWriterSettings();

                setting.Indent = true;
                //setting.Encoding = Encoding.UTF8;

                XmlWriter xmlWriter = XmlWriter.Create(sb, setting);

                xmlWriter.WriteProcessingInstruction("xml", "version='1.0' encoding='UTF-8'");

                xmlWriter.WriteStartElement("bookInfo");
                    xmlWriter.WriteElementString("bookName", this.ancestorBookViewModel_.BookName_);
                    xmlWriter.WriteElementString("bookCode", this.ancestorBookViewModel_.BookName_);
                xmlWriter.WriteEndElement();

                foreach (var item in this.childBookList_)
                {
                    item.buildXml(xmlWriter);
                }

                //this. (xmlWriter);

                xmlWriter.Close();

                this.bookXml_.LoadXml(sb.ToString());

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void saveXml()
        {
            bookXml_.Save(bookPath_ + "\\" + "XMLFile1.xml");
        }

        public bool hasTradeInstrument(string tradeID)
        {
            bool tf = false;

            tf = tf || this.ancestorBookViewModel_.hasTradeID(tradeID);

            return tf;
        }

        public void clearSelection()
        {
            this.ancestorBookViewModel_.clearSelection();
        }

        //public void refreshInstrument()
        //{
        //    this.ancestorBookViewModel_.refreshInstrument();
        //}

        public bool removeInstrument(Excel_instrumentViewModel e_ivm)
        {
            bool flag = false;

            foreach (var item in this.childBookList_)
            {
                flag = flag || item.removeInstrument(e_ivm);
            }

            return flag;


        }

        public BookViewModel getBook(string bookCode)
        {
            List<BookViewModel> bookList = new List<BookViewModel>();

            foreach (var item in this.childBookList_)
	        {
                item.getBookList(bookList);
	        }

            BookViewModel bvm = new BookViewModel();

            foreach (var item in bookList)
            {
                if (item.BookCode_ == bookCode || item.BookName_ == bookCode)
                {
                    bvm = item;
                    break;
                }
            }

            return bvm;

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

        public void booking(string bookCode, Excel_instrument_structuredBondViewModel e_inst_sbvm)
        {
            //find book

            BookViewModel bvm = this.getBook(bookCode);

            bvm.booking(e_inst_sbvm);

        }
    }
}
