using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{

    // dataGrid에 들어갈 하나하나
    public class HedgeUnderlyingGreekPositionViewModel
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

        #region DeltaPosition_
        private double deltaPosition_;
        public double DeltaPosition_
        {
            get { return this.deltaPosition_; }
            set
            {
                if (this.deltaPosition_ != value)
                {
                    this.deltaPosition_ = value;
                    this.NotifyPropertyChanged("DeltaPosition_");
                }
            }
        }
        #endregion

        #region GammaPosition_
        private double gammaPosition_;
        public double GammaPosition_
        {
            get { return this.gammaPosition_; }
            set
            {
                if (this.gammaPosition_ != value)
                {
                    this.gammaPosition_ = value;
                    this.NotifyPropertyChanged("GammaPosition_");
                }
            }
        }
        #endregion

        #region VegaPosition_
        private double vegaPosition_;
        public double VegaPosition_
        {
            get { return this.vegaPosition_; }
            set
            {
                if (this.vegaPosition_ != value)
                {
                    this.vegaPosition_ = value;
                    this.NotifyPropertyChanged("VegaPosition_");
                }
            }
        }
        #endregion

        #region GreekPositionList_
        private ObservableCollection<GreekPositionViewModel> greekPositionList_;
        public ObservableCollection<GreekPositionViewModel> GreekPositionList_
        {
            get { return this.greekPositionList_; }
            set
            {
                if (this.greekPositionList_ != value)
                {
                    this.greekPositionList_ = value;
                    this.NotifyPropertyChanged("GreekPositionList_");
                }
            }
        }
        #endregion

        #region UnderlyingName_ 
		private string underlyingName_;
		public string UnderlyingName_ 
		{ 
			get { return this.underlyingName_; }
			set
			{
			if (this.underlyingName_ != value)
			{
				this.underlyingName_ = value;
				this.NotifyPropertyChanged("UnderlyingName_");
			}
			}
		}
		#endregion

        #region UnderlyingKrCode_
        private string underlyingKrCode_;
        public string UnderlyingKrCode_
        {
            get { return this.underlyingKrCode_; }
            set
            {
                if (this.underlyingKrCode_ != value)
                {
                    this.underlyingKrCode_ = value;
                    this.NotifyPropertyChanged("UnderlyingKrCode_");
                }
            }
        }
        #endregion

        //  외부에서 골라서 옴
        public HedgeUnderlyingGreekPositionViewModel(string underlyingKrCode,
                                                     ObservableCollection<Excel_instrumentViewModel> instList)
        {

        }

        //  외부에서 골라서 옴
        public HedgeUnderlyingGreekPositionViewModel(string underlyingKrCode)
        {
            this.greekPositionList_ = new ObservableCollection<GreekPositionViewModel>();
        }

        private void positionUpdate()
        { 
            // underlying position 을 계산함
                // db에서 몇주인가와 현재가격을 가져옴
                // deltaposition을 계산함

            // 
        }

        public void addGreekPosition(GreekPositionViewModel greekP)
        {
            this.greekPositionList_.Add(greekP);
        }
    }
}
