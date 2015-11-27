using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XmlBuilder.DataModel;
using XmlBuilder.DataLoader;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace XmlBuilder.Views.StructuredProduct.ViewModel
{
    public class UnderlyingEditViewModel
    {
        public UnderlyingEditViewModel() 
        {
            this.loadData();
        }

        public void loadData()
        {
            this.stockDataLoader_ = new StockDataLoader();
            this.indexDataLoader_ = new IndexDataLoader();
            this.interestRateDataLoader_ = new InterestRateDataLoader();
            this.commodityDataLoader_ = new CommodityDataLoader();

            StockDataList_ = stockDataLoader_.loadData();
            IndexDataList_ = indexDataLoader_.loadData();
            IRDataList_ = interestRateDataLoader_.loadData();
            //IRDataList_ = interestRateDataLoader_.loadData();

        }

        public void historyCalDataLoad() 
        {
            
        }



        public void addUnderlying(IData underlyingData) 
        {
            BaseIndexViewModel bivm 
                = new BaseIndexViewModel("",
                                        underlyingData.Code_,
                                        underlyingData.Name_,
                                        underlyingData.Type_,
                                        underlyingData.Description_);

            baseIndexList_.Add(bivm);

        }

        private void symbolMaker() 
        {
        
        }
        
        #region Data
        private StockDataLoader stockDataLoader_;

        #region StockDataList_
        private ObservableCollection<StockData> stockDataList_;
        public ObservableCollection<StockData> StockDataList_
        {
            get { return this.stockDataList_; }
            set
            {
                if (this.stockDataList_ != value)
                {
                    this.stockDataList_ = value;
                    this.NotifyPropertyChanged("StockDataList_");
                }
            }
        }
        #endregion

        private IndexDataLoader indexDataLoader_;
        public List<IndexData> IndexDataList_;

        private InterestRateDataLoader interestRateDataLoader_;
        public List<InterestRateData> IRDataList_;

        private CommodityDataLoader commodityDataLoader_;
        public List<CommodityData> CommDataList_;

        #endregion

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
