using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.IO;

namespace RiskMonitor
{
    public class BookInfoViewModel
    {
        #region ReferenceDate_
        private DateTime referenceDate_;
        public DateTime ReferenceDate_
        {
            get { return this.referenceDate_; }
            set
            {
                if (this.referenceDate_ != value)
                {
                    this.referenceDate_ = value;
                    this.NotifyPropertyChanged("ReferenceDate_");
                }
            }
        }
        #endregion

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

        #region HostType_
        private string hostType_;
        public string HostType_
        {
            get { return this.hostType_; }
            set
            {
                if (this.hostType_ != value)
                {
                    this.hostType_ = value;
                    this.NotifyPropertyChanged("HostType_");
                }
            }
        }
        #endregion

        #region BookFile_
        private FileInfo bookFile_;
        public FileInfo BookFile_
        {
            get { return this.bookFile_; }
            set
            {
                if (this.bookFile_ != value)
                {
                    this.bookFile_ = value;
                    this.NotifyPropertyChanged("BookFile_");
                }
            }
        }
        #endregion

        #region PathURLInfo_
        private string pathURLInfo_;
        public string PathURLInfo_
        {
            get { return this.pathURLInfo_; }
            set
            {
                if (this.pathURLInfo_ != value)
                {
                    this.pathURLInfo_ = value;
                    this.NotifyPropertyChanged("PathURLInfo_");
                }
            }
        }
        #endregion

        //public ObservableCollection<InstrumentHierarchyViewModel> InstHierarchyList_ { get; set; }

        public XmlDocument BookInfoXml_ { get; set; }

        public BookInfoViewModel(FileInfo bookFile)
        {
            this.bookFile_ = bookFile;
            this.loadBook();
        }

        public void loadBook() 
        {
            this.BookName_ = this.bookFile_.Name;

            BookInfoXml_ = new XmlDocument();
            BookInfoXml_.Load(this.bookFile_.FullName);

            this.pathURLInfo_ = BookInfoXml_.SelectSingleNode("bookInformation/pathInfo/url").InnerText;


            //load book configuration File

            // list make up
        }

        public void saveBookInfo()
        {
            
        }

        public void buildXml()
        {
            throw new NotImplementedException();
        }

        public InstUriInfo InstUri(FpmlSerializedCSharp.InstHirachyInfo serial_Class)
        {
            string itemCode = serial_Class.Code_.ValueStr;
            string itemType = serial_Class.Type_.ValueStr;

            Uri uri = new Uri(pathURLInfo_ + itemCode + "_" + itemType + ".xml");

            InstUriInfo instUri = new InstUriInfo(itemCode, itemType, uri);

            return instUri;
        }

        public ResultUriInfo resultUri(FpmlSerializedCSharp.InstHirachyInfo serial_Class)
        {
            string itemCode = serial_Class.Code_.ValueStr;
            string itemType = serial_Class.Type_.ValueStr;

            Uri uri = new Uri(pathURLInfo_ + itemCode + "_" + itemType);

            ResultUriInfo resultUri = new ResultUriInfo(itemCode, itemType, uri);

            return resultUri;
        }

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
