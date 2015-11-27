using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Xml;

namespace XmlBuilder.Views.StructuredProduct.ViewModel
{
    public class EventIndexTransformationViewModel
    {
        public EventIndexTransformationViewModel(FpmlSerializedCSharp.EventIndexTransformation eventIndexTransformation)
        {
            // TODO: Complete member initialization
            this.eit_= eventIndexTransformation;
            this.buildFromSerialClass();

        }

        private void buildFromSerialClass()
        {
            indexTransVMList_ = new ObservableCollection<IndexTransViewModel>();

            foreach (FpmlSerializedCSharp.IndexCalculation item in eit_.IndexCalculation_)
	        {
                indexTransVMList_.Add(new IndexTransViewModel(item));
	        }
            
        }

        public void buildXml(XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("eventIndexTransformation");

            foreach (IndexTransViewModel item in indexTransVMList_)
            {
                item.buildXml(xmlWriter);
            }

            xmlWriter.WriteEndElement();

        }


        private FpmlSerializedCSharp.EventIndexTransformation eit_;

        #region IndexTransVMList_
        private ObservableCollection<IndexTransViewModel> indexTransVMList_;
        public ObservableCollection<IndexTransViewModel> IndexTransVMList_
        {
            get { return this.indexTransVMList_; }
            set
            {
                if (this.indexTransVMList_ != value)
                {
                    this.indexTransVMList_ = value;
                    this.NotifyPropertyChanged("IndexTransVMList_");
                }
            }
        }
        #endregion
        
        // ---------------------- Event ---------------------------
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }




    }
}
