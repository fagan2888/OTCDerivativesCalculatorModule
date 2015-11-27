using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_irSymbolViewModel : Excel_marketDataSymbol
    {
        #region Excel_irDataViewModelList_
        private ObservableCollection<Excel_irDataViewModel> excel_irDataViewModelList_;
        public ObservableCollection<Excel_irDataViewModel> Excel_irDataViewModelList_
        {
            get { return this.excel_irDataViewModelList_; }
            set
            {
                if (this.excel_irDataViewModelList_ != value)
                {
                    this.excel_irDataViewModelList_ = value;
                    this.NotifyPropertyChanged("Excel_irDataViewModelList_");
                }
            }
        }
        #endregion

        public Excel_irSymbolViewModel()
        {
            this.excel_irDataViewModelList_ = new ObservableCollection<Excel_irDataViewModel>();
        }

        public override string dataLoad(DateTime refDate, string code)
        {
            MARKETDATA_SYMBOL_INFO_Table_DAO dao = new MARKETDATA_SYMBOL_INFO_Table_DAO();

            dao.SYMBOL_ = code;

            dao.select(DataBaseConnectManager.ConnectionFactory("myDB"));

            this.setFromDAO(dao);

            IRCurveMarketDataLoader irLoader = IRCurveMarketDataLoader.CreateMarketDataLoader(this.provider_);

            ObservableCollection<Excel_irCurveDataViewModel> e_ircdvmList = new ObservableCollection<Excel_irCurveDataViewModel>();

            irLoader.load(refDate, this.Linkedcurve_, e_ircdvmList);

            int tenorNum = e_ircdvmList[0].getTenorIndex(this.Tenor_);

            string value = e_ircdvmList[0].Excel_rateDataViewModelList_[tenorNum].Value_;

            return value;
        }

        public override Excel_underlyingInfoViewModel underlyingInfoVM()
        {
            Excel_interestRateViewModel e_irvm = new Excel_interestRateViewModel();

            e_irvm.KrCode_ = this.Symbol_;
            e_irvm.Tenor_ = this.Tenor_;
            e_irvm.NameTrans_ = new NameTrans(this.name_eng_);

            e_irvm.Currency_ = this.Currency_;
            e_irvm.LegTenor_ = this.Leg_tenor_;
            e_irvm.RateType_ = this.Rate_type_;

            e_irvm.LinkedCurveCode_ = this.Linkedcurve_;

            return e_irvm;
        }
    }
}
