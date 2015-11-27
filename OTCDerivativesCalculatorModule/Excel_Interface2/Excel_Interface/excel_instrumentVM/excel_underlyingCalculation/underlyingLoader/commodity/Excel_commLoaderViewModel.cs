using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Excel_Interface
{
    public class Excel_commLoaderViewModel : Excel_loaderViewModel
    {
        public Excel_commLoaderViewModel()
        {
            this.definedCommoditySymbolList_ = new ObservableCollection<Excel_commoditySymbolViewModel>();
        }

        #region DefinedCommoditySymbolList_
        private ObservableCollection<Excel_commoditySymbolViewModel> definedCommoditySymbolList_;
        public ObservableCollection<Excel_commoditySymbolViewModel> DefinedCommoditySymbolList_
        {
            get { return this.definedCommoditySymbolList_; }
            set
            {
                if (this.definedCommoditySymbolList_ != value)
                {
                    this.definedCommoditySymbolList_ = value;
                    //this.NotifyPropertyChanged("DefinedEquitySymbolList_");
                }
            }
        }
        #endregion

        public override void loadDefinedSymbolFromDB()
        {
            MARKETDATA_SYMBOL_INFO_Table_DAOManager daoM = new MARKETDATA_SYMBOL_INFO_Table_DAOManager();

            // equity 쪽을 죄다 로드함.

            daoM.KeyColumn_ = "comm".ToUpper();
            daoM.KeyColumn_SYMBOL_TYPE_ = "comm".ToUpper();

            try
            {
                daoM.select(DataBaseConnectManager.ConnectionFactory("myDB"));

                this.definedCommoditySymbolList_.Clear();

                foreach (var item in daoM.DAOList_)
                {
                    Excel_commoditySymbolViewModel esvm = new Excel_commoditySymbolViewModel();

                    esvm.setFromDAO(item);

                    this.definedCommoditySymbolList_.Add(esvm);

                }
            }
            catch (Exception)
            {
                //OutputLogViewModel.addResult("index data load error , code : " + code + " date : " + refDate.ToString(StringFormat.DbDateFormat_));
            }
        }

        public override System.Windows.Controls.Control view()
        {
            Control v = new Excel_commLoaderView();

            v.DataContext = this;

            return v;
        }
    }
}
