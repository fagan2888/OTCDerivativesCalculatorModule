using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace RiskMonitor
{
    public class ContentsListViewModel
    {
        // Data 위치 및 어쩌구

        #region TemplateType_
        private string templateType_;
        public string TemplateType_
        {
            get { return this.templateType_; }
            set
            {
                if (this.templateType_ != value)
                {
                    this.templateType_ = value;
                    this.NotifyPropertyChanged("TemplateType_");
                }
            }
        }
        #endregion

        public ContentsListViewModel() 
        {
            this.instrumentTemplateList_ = new ObservableCollection<InstrumentTemplate>();
        }

        #region InstrumentTemplateList_
        private ObservableCollection<InstrumentTemplate> instrumentTemplateList_;
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
