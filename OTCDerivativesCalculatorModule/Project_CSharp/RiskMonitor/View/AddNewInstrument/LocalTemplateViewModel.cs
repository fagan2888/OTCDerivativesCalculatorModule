using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class LocalTemplateViewModel
    {

        public LocalTemplateViewModel() 
        {

            this.templateHirachyList_ = new ObservableCollection<TemplateHirachyModel>();

            this.templateHirachyList_.Add(new GeneralTemplateModel());
            //this.templateContentsList_.Add(new ELSOptionTemplate());

        }

        #region TemplateHirachyList_
        private ObservableCollection<TemplateHirachyModel> templateHirachyList_;
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
