using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class HedgeInformationViewModel
    {
        public HedgeInformationViewModel(int fundCode)
        {
            FundCode_ = fundCode;
            //dataLoaderStr_ = "DynamicHedgePosition";
            
            // 알아서 로드함.

            this.dataLoad();
            this.build();
        }

        //public void setDataSeverInformation(ServerCondition condition) 
        //{
        //    //set 함.
        //}

        private void dataLoad()
        {
            //PositionDataLoader pdl = new PositionDataLoader("");

            //position_ = pdl.getPosition();

            //foreach (Instrument inst in position_)
            //{

            //    foreach (UnderlyingStock under in inst.Underlying_)
            //    {
                    
            //    }    
            //}
            


            //underlyingList_ = pdl.underlyingList();
        }

        // underlying 별로 분류함.
        private void build()
        {
            hedgeInformationModels_ = new ObservableCollection<GreekUnderlyingResultWrapperViewModel>();
            
            //bool flag;

            //foreach (string item in underlyingList_)
            //{
            //    hedgeInformationModels_.Add(item);
            //}
        }

        public int FundCode_ { get; set; }

        //private string dataLoaderStr_;

        //private List<ELSUnderlyingStock> underlyingList_;


        #region Position_ - portfolio position whole list
        private ObservableCollection<InstrumentViewModel> position_;
        public ObservableCollection<InstrumentViewModel> Position_
        {
            get { return this.position_; }
            set
            {
                if (this.position_ != value)
                {
                    this.position_ = value;
                    this.NotifyPropertyChanged("Position_");
                }
            }
        }
        #endregion

        #region HedgeInformationModels_
        private ObservableCollection<GreekUnderlyingResultWrapperViewModel> hedgeInformationModels_;
        public ObservableCollection<GreekUnderlyingResultWrapperViewModel> HedgeInformationModels_
        {
            get { return this.hedgeInformationModels_; }
            set
            {
                if (this.hedgeInformationModels_ != value)
                {
                    this.hedgeInformationModels_ = value;
                    this.NotifyPropertyChanged("HedgeInformationModels_");
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
