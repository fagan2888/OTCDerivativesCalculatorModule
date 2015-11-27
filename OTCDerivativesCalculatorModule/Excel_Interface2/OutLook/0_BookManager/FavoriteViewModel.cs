using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface 
{
    public class FavoriteViewModel : IXmlData, IFolderAction
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

        #region FavoriteName_
        protected string favoriteName_;
        public string FavoriteName_
        {
            get { return this.favoriteName_; }
            set
            {
                if (this.favoriteName_ != value)
                {
                    this.favoriteName_ = value;
                    this.NotifyPropertyChanged("FavoriteName_");
                }
            }
        }
        #endregion

        #region FavoriteCode_
        protected string favoriteCode_;
        public string FavoriteCode_
        {
            get { return this.favoriteCode_; }
            set
            {
                if (this.favoriteCode_ != value)
                {
                    this.favoriteCode_ = value;
                    this.NotifyPropertyChanged("FavoriteCode_");
                }
            }
        }
        #endregion

        #region InstrumentList_
        protected ObservableCollection<Excel_instrumentViewModel> instrumentList_;
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

        private System.Xml.XmlNode node_;

        public FavoriteViewModel()
        {
            this.instrumentList_ = new ObservableCollection<Excel_instrumentViewModel>();
        }

        public void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("favorite");
                xmlWriter.WriteStartElement("favoriteInfo");
                    xmlWriter.WriteElementString("favoriteName", this.favoriteName_);
                    xmlWriter.WriteElementString("favoriteCode", this.favoriteCode_);
                xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("instrumentList");

            foreach (var item in this.instrumentList_)
            {
                xmlWriter.WriteElementString("instrument", item.Item_code_);
            }

            xmlWriter.WriteEndElement();

            xmlWriter.WriteEndElement();
        }

        public void setFromXml(System.Xml.XmlNode InstNode)
        {
            this.node_ = InstNode;
            //InstNode["book"]["bookInfo"];

            System.Xml.XmlNode bookInfoNode
                = InstNode["favoriteInfo"];

            this.favoriteName_ = bookInfoNode["favoriteName"].InnerText;
            this.favoriteCode_ = bookInfoNode["favoriteCode"].InnerText;

                System.Xml.XmlNodeList instrumentListNodeList
                    = InstNode["instrumentList"].SelectNodes("instrument");

            foreach (System.Xml.XmlNode item in instrumentListNodeList)
            {
                string instCode = item.InnerText;

                Excel_instrumentViewModel instrument = new Excel_instrumentViewModel();
                instrument.Item_code_ = instCode;

                this.instrumentList_.Add(instrument);

            }
            
            
        }

        public void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            throw new NotImplementedException();
        }

        public virtual void AddInstrument(Excel_instrumentViewModel e_instVM)
        {
            this.instrumentList_.Add(e_instVM);

            System.Xml.XmlElement xmlEle
                = this.node_.OwnerDocument.CreateElement("instrument");
            
            xmlEle.InnerText = e_instVM.Item_code_;

            this.node_["instrumentList"].AppendChild(xmlEle);
        }

        public virtual bool removeInstrument(Excel_instrumentViewModel e_ivm)
        {
            System.Xml.XmlNodeList instrumentListNodeList
                = this.node_["instrumentList"].SelectNodes("instrument");

            foreach (System.Xml.XmlNode item in instrumentListNodeList)
            {
                string code = item.InnerText;

                if (code == e_ivm.Item_code_) 
                {
                    this.instrumentList_.Remove(e_ivm);
                    this.node_["instrumentList"].RemoveChild(item);

                    return true;
                }
            }

            return false;
        }

        public void loadMasterInformation()
        {
            foreach (var item in this.instrumentList_)
            {
                item.MasterInformationViewModel_.loadMasterInfo(item.Item_code_);
            }
        }
    }
}
