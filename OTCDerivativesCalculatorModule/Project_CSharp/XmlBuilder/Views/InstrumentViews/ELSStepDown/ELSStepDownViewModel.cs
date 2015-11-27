using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XmlBuilder.Views.StructuredProduct.ViewModel;
using System.Xml;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace XmlBuilder.Views.InstrumentViews.ELSStepDown
{
    public class ELSStepDownViewModel : IXmlBuild
    {
        public ELSStepDownViewModel() 
        {
            
        }

        public void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }


        #region ELSRedemInfoList_
        private ObservableCollection<ELSRedemInfoViewModel> elsRedemInfoList_;
        public ObservableCollection<ELSRedemInfoViewModel> ELSRedemInfoList_
        {
            get { return this.elsRedemInfoList_; }
            set
            {
                if (this.elsRedemInfoList_ != value)
                {
                    this.elsRedemInfoList_ = value;
                    this.NotifyPropertyChanged("ELSRedemInfoList_");
                }
            }
        }
        #endregion

        #region ELSMaturityInfo_
        private ELSMaturityInfoViewModel elsMaturityInfo_;
        public ELSMaturityInfoViewModel ELSMaturityInfo_
        {
            get { return this.elsMaturityInfo_; }
            set
            {
                if (this.elsMaturityInfo_ != value)
                {
                    this.elsMaturityInfo_ = value;
                    this.NotifyPropertyChanged("ELSMaturityInfo_");
                }
            }
        }
        #endregion

        #region ELSKICheckInfo_
        private ELSKICheckInfoViewModel elsKICheckInfo_;
        public ELSKICheckInfoViewModel ELSKICheckInfo_
        {
            get { return this.elsKICheckInfo_; }
            set
            {
                if (this.elsKICheckInfo_ != value)
                {
                    this.elsKICheckInfo_ = value;
                    this.NotifyPropertyChanged("ELSKICheckInfo_");
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
