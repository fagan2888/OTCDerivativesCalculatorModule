using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace RiskMonitor
{
    public abstract class TemplateHirachyModel
    {
        //public abstract ObservableCollection<InstrumentTemplate> contentList();

        #region Name_
        private string name_;
        public string Name_
        {
            get { return this.name_; }
            set
            {
                if (this.name_ != value)
                {
                    this.name_ = value;
                    this.NotifyPropertyChanged("Name_");
                }
            }
        }
        #endregion

        #region TemplateHirachyList_
        protected ObservableCollection<TemplateHirachyModel> templateHirachyList_;
        public ObservableCollection<TemplateHirachyModel> TemplateHirachyList_
        {
            get { return this.templateHirachyList_; }
            set
            {
                if (this.templateHirachyList_ != value)
                {
                    this.templateHirachyList_ = value;
                    this.NotifyPropertyChanged("TemplateHirachyList_");
                }
            }
        }
        #endregion

        #region InstrumentTemplateList_
        protected ObservableCollection<InstrumentTemplate> instrumentTemplateList_;
        public ObservableCollection<InstrumentTemplate> InstrumentTemplateList_
        {
            get { return this.instrumentTemplateList_; }
            set
            {
                if (this.instrumentTemplateList_ != value)
                {
                    this.instrumentTemplateList_ = value;
                    this.NotifyPropertyChanged("InstrumentTemplateList_");
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
