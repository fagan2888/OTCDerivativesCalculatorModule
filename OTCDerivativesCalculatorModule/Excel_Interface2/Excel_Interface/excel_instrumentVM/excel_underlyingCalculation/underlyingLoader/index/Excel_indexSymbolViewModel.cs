using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_indexSymbolViewModel : Excel_marketDataSymbol
    {
        #region Excel_indexDataViewModelList_
        private ObservableCollection<Excel_indexDataViewModel> excel_indexDataViewModelList_;
        public ObservableCollection<Excel_indexDataViewModel> Excel_indexDataViewModelList_
        {
            get { return this.excel_indexDataViewModelList_; }
            set
            {
                if (this.excel_indexDataViewModelList_ != value)
                {
                    this.excel_indexDataViewModelList_ = value;
                    this.NotifyPropertyChanged("Excel_indexDataViewModelList_");
                }
            }
        }
        #endregion

        public Excel_indexSymbolViewModel()
        {
            this.excel_indexDataViewModelList_ = new ObservableCollection<Excel_indexDataViewModel>();
        }

        public override string dataLoad(DateTime refDate, string code)
        {
            MARKETDATA_SYMBOL_INFO_Table_DAO dao = new MARKETDATA_SYMBOL_INFO_Table_DAO();

            dao.SYMBOL_ = code;

            dao.select(DataBaseConnectManager.ConnectionFactory("myDB"));

            this.setFromDAO(dao);

            IndexMarketDataLoader indexLoader = IndexMarketDataLoader.CreateMarketDataLoader(this.provider_);

            string value = indexLoader.load(refDate, code);

            return value;
        }

        public override Excel_underlyingInfoViewModel underlyingInfoVM()
        {
            Excel_indexTypeViewModel e_sivm = new Excel_indexTypeViewModel();

            e_sivm.KrCode_ = this.Symbol_;
            e_sivm.NameTrans_ = new NameTrans(this.name_eng_);
            e_sivm.Tenor_ = this.Tenor_;
            
            e_sivm.Sub_type_ = this.Sub_type_;

            e_sivm.LinkedCurveCode_ = this.Linkedcurve_;

            return e_sivm;
        }
    }
}
