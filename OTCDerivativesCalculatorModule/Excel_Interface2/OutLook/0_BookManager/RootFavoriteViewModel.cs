using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Xml;


namespace Excel_Interface
{
    public class RootFavoriteViewModel : IFileAction
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

        private XmlDocument favoriteXml_;
        //private string bookPath_ = @"D:\Project File\OTCDerivativesCalculatorModule\Excel_Interface2\OutLook\";
        private string bookPath_ = System.IO.Directory.GetCurrentDirectory();
        #region Default Favorite

        #region MasterFavoriteViewModel_
        private MasterFavoriteViewModel masterFavoriteViewModel_;
        public MasterFavoriteViewModel MasterFavoriteViewModel_
        {
            get { return this.masterFavoriteViewModel_; }
            set
            {
                if (this.masterFavoriteViewModel_ != value)
                {
                    this.masterFavoriteViewModel_ = value;
                    this.NotifyPropertyChanged("MasterFavoriteViewModel_");
                }
            }
        }
        #endregion

        #region UnClassifiedFavoriteViewModel_
        private FavoriteViewModel unClassifiedFavoriteViewModel_;
        public FavoriteViewModel UnClassifiedFavoriteViewModel_
        {
            get { return this.unClassifiedFavoriteViewModel_; }
            set
            {
                if (this.unClassifiedFavoriteViewModel_ != value)
                {
                    this.unClassifiedFavoriteViewModel_ = value;
                    this.NotifyPropertyChanged("UnClassifiedFavoriteViewModel_");
                }
            }
        }
        #endregion

        #endregion

        // custom Favorite

        #region FavoriteList_
        private ObservableCollection<FavoriteViewModel> favoriteList_;
        public ObservableCollection<FavoriteViewModel> FavoriteList_
        {
            get { return this.favoriteList_; }
            set
            {
                if (this.favoriteList_ != value)
                {
                    this.favoriteList_ = value;
                    this.NotifyPropertyChanged("FavoriteList_");
                }
            }
        }
        #endregion

        public RootFavoriteViewModel()
        { 
        
        }

        public void loadPosition()
        {
            this.favoriteXml_ = new XmlDocument();

            this.favoriteList_ = new ObservableCollection<FavoriteViewModel>();

            favoriteXml_.Load(bookPath_ +"\\"+ "favorite.xml");

            System.Xml.XmlNode favoritePositionNode
                = favoriteXml_["favoritePosition"];

            //this.positionFolderName_ = positionFolderNode["positionFolderName"].InnerText;
            //this.positionFolderCode_ = positionFolderNode["positionFolderCode"].InnerText;

            #region load WholePositionMaster

            this.masterFavoriteViewModel_ = new MasterFavoriteViewModel();

            this.favoriteList_.Add(this.masterFavoriteViewModel_);

            #endregion

            #region unclassifedFavorite Set

            System.Xml.XmlNode unclassifiedFavoriteNode
                    = favoritePositionNode["unclassifiedFavorite"];

                FavoriteViewModel unclassifiedFavoriteBook = new FavoriteViewModel();

                unclassifiedFavoriteBook.setFromXml(unclassifiedFavoriteNode);

                this.unClassifiedFavoriteViewModel_ = unclassifiedFavoriteBook;
                this.favoriteList_.Add(unclassifiedFavoriteBook);

            #endregion

            foreach (System.Xml.XmlNode item in favoritePositionNode.SelectNodes("favorite"))
            {
                FavoriteViewModel favoriteBook = new FavoriteViewModel();

                favoriteBook.setFromXml(item);

                this.favoriteList_.Add(favoriteBook);
            }

        }

        private void loadDBMasterInformation()
        {
            throw new NotImplementedException();
        }

        public void buildInstrument()
        {
        //    try
        //    {
        //        this.favoriteXml_ = new XmlDocument();

        //        StringBuilder sb = new StringBuilder();
        //        XmlWriterSettings setting = new XmlWriterSettings();

        //        setting.Indent = true;
        //        //setting.Encoding = Encoding.UTF8;

        //        XmlWriter xmlWriter = XmlWriter.Create(sb, setting);

        //        xmlWriter.WriteProcessingInstruction("xml", "version='1.0' encoding='UTF-8'");

        //        xmlWriter.WriteStartElement("positionFolder");
        //        xmlWriter.WriteElementString("positionFolderName", this.positionFolderName_);
        //        xmlWriter.WriteElementString("positionFolderCode", this.positionFolderCode_);
        //        xmlWriter.WriteEndElement();

        //        foreach (var item in this.childBookList_)
        //        {
        //            item.buildXml(xmlWriter);
        //        }

        //        //this. (xmlWriter);

        //        xmlWriter.Close();

        //        this.favoriteXml_.LoadXml(sb.ToString());

        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        }

        
        public void saveXml()
        {
            favoriteXml_.Save(bookPath_ + "favorite.xml");
        }

    }
}
