using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class IndexUnderInfoViewModel : UnderlyingInfoViewModel
    {

        public IndexUnderInfoViewModel()
        {
            this.indexUnderList_ = new ObservableCollection<IndexUnderViewModel>();
        }

        #region IndexUnderList_
        private ObservableCollection<IndexUnderViewModel> indexUnderList_;
        public ObservableCollection<IndexUnderViewModel> IndexUnderList_
        {
            get { return this.indexUnderList_; }
            set
            {
                if (this.indexUnderList_ != value)
                {
                    this.indexUnderList_ = value;
                    this.NotifyPropertyChanged("IndexUnderList_");
                }
            }
        }
        #endregion

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("underlyingInformation");
                xmlWriter.WriteElementString("type" , "indexUnderInfo");
                xmlWriter.WriteStartElement("indexUnderInfo");

                    foreach (var item in indexUnderList_)
                    {
                        item.buildXml(xmlWriter);
                    }
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }

        public override void setFromXml(System.Xml.XmlNode InstNode)
        {
            throw new NotImplementedException();
        }

        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.UnderlyingInformation serial_underInfo = serial_Class as FpmlSerializedCSharp.UnderlyingInformation;
            FpmlSerializedCSharp.IndexUnderInfo serial_indexUnderInfo = serial_underInfo.IndexUnderInfo_;

            this.indexUnderList_ = new ObservableCollection<IndexUnderViewModel>();

            foreach (var item in serial_indexUnderInfo.Index_)
            {
                IndexUnderViewModel indexUnderVM = IndexUnderViewModel.CreateIndexUnder(item);
                indexUnderVM.setFromSerial(item);
                this.indexUnderList_.Add(indexUnderVM);
            }

            this.view_ = new IndexUnderInfoView();
            this.view_.DataContext = this;
        }


    }
}

