using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Xml;

namespace RiskMonitor
{
    // 여기선 기초자산 종목 못바꾸게함
    public class UnderlyingInfoParameterViewModel
    {
        public UnderlyingInfoParameterViewModel(UnderlyingInfo underInfo)
        {
            this.underlyingParaVMList_ = new ObservableCollection<UnderlyingParameterViewModel>();

            foreach (Underlying item in underInfo.Underlyings_)
	        {

                this.underlyingParaVMList_.Add(new UnderlyingParameterViewModel(item));
	        }
            
        }

        public void loadFromXml() 
        {
        
        }

        #region UnderlyingParaVMList_
        private ObservableCollection<UnderlyingParameterViewModel> underlyingParaVMList_;
        public ObservableCollection<UnderlyingParameterViewModel> UnderlyingParaVMList_
        {
            get { return this.underlyingParaVMList_; }
            set
            {
                if (this.underlyingParaVMList_ != value)
                {
                    this.underlyingParaVMList_ = value;
                    this.NotifyPropertyChanged("UnderlyingParaVMList_");
                }
            }
        }
        #endregion

        #region MatrixViewModel_
        private MatrixViewModel matrixViewModel_;
        public MatrixViewModel MatrixViewModel_
        {
            get { return this.matrixViewModel_; }
            set
            {
                if (this.matrixViewModel_ != value)
                {
                    this.matrixViewModel_ = value;
                    this.NotifyPropertyChanged("MatrixViewModel_");
                }
            }
        }
        #endregion

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
