using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using XmlBuilder.Views.StructuredProduct.ViewModel;
using XmlBuilder.Ctrl;
using System.Xml;

namespace XmlBuilder.ViewModel
{
    public class BaseInformationViewModel : IXmlBuild
    {
        private FpmlSerializedCSharp.BaseInformation baseInformation_;

        public BaseInformationViewModel(FpmlSerializedCSharp.BaseInformation baseInformation)
        {
            // TODO: Complete member initialization
            this.baseInformation_ = baseInformation;
            this.buildFromSerialClass();
        }

        private void buildFromSerialClass() 
        {
            baseIndexList_ = new ObservableCollection<BaseIndexViewModel>();

            foreach (FpmlSerializedCSharp.UnderlyingIndex item in baseInformation_.BaseIndexes_.UnderlyingIndex_)
	        {
		         baseIndexList_.Add(new BaseIndexViewModel(item));
	        }

            initialFixedValueList_ = new ObservableCollection<VariableModel>();

            foreach (FpmlSerializedCSharp.VariableValue item in baseInformation_.InitialFixedValue_.Variable_)
            {
                initialFixedValueList_.Add(new VariableModel(item));
            }

        }

        public void buildXml(XmlWriter xmlWriter)
        {
            foreach (BaseIndexViewModel item in baseIndexList_)
            {
                item.buildXml(xmlWriter);
            }

        }

        #region BaseIndexList_
        private ObservableCollection<BaseIndexViewModel> baseIndexList_;
        public ObservableCollection<BaseIndexViewModel> BaseIndexList_
        {
            get { return this.baseIndexList_; }
            set
            {
                if (this.baseIndexList_ != value)
                {
                    this.baseIndexList_ = value;
                    this.NotifyPropertyChanged("BaseIndexList_");
                }
            }
        }
        #endregion

        #region InitialFixedValueList_
        private ObservableCollection<VariableModel> initialFixedValueList_;
        public ObservableCollection<VariableModel> InitialFixedValueList_
        {
            get { return this.initialFixedValueList_; }
            set
            {
                if (this.initialFixedValueList_ != value)
                {
                    this.initialFixedValueList_ = value;
                    this.NotifyPropertyChanged("InitialFixedValueList_");
                }
            }
        }
        #endregion


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
