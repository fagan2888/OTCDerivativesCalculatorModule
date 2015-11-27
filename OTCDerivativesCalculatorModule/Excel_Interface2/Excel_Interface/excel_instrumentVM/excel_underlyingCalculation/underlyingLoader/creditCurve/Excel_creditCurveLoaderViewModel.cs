using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Excel_Interface
{
    public class Excel_creditCurveLoaderViewModel : Excel_loaderViewModel
    {
        public Excel_creditCurveLoaderViewModel()
        {
            this.definedCreditCurveSymbolList_ = new ObservableCollection<Excel_creditCurveSymbolViewModel>();
        }

        #region DefinedCreditCurveSymbolList_
        private ObservableCollection<Excel_creditCurveSymbolViewModel> definedCreditCurveSymbolList_;
        public ObservableCollection<Excel_creditCurveSymbolViewModel> DefinedCreditCurveSymbolList_
        {
            get { return this.definedCreditCurveSymbolList_; }
            set
            {
                if (this.definedCreditCurveSymbolList_ != value)
                {
                    this.definedCreditCurveSymbolList_ = value;
                    //this.NotifyPropertyChanged("DefinedEquitySymbolList_");
                }
            }
        }
        #endregion

        public override void loadDefinedSymbolFromDB()
        {
            MARKETDATA_SYMBOL_INFO_Table_DAOManager daoM = new MARKETDATA_SYMBOL_INFO_Table_DAOManager();

            // equity 쪽을 죄다 로드함.

            daoM.KeyColumn_ = "creditcurve".ToUpper();
            daoM.KeyColumn_SYMBOL_TYPE_ = "creditcurve".ToUpper();

            try
            {
                daoM.select(DataBaseConnectManager.ConnectionFactory("myDB"));

                this.definedCreditCurveSymbolList_.Clear();

                foreach (var item in daoM.DAOList_)
                {
                    Excel_creditCurveSymbolViewModel esvm = new Excel_creditCurveSymbolViewModel();

                    esvm.setFromDAO(item);

                    this.definedCreditCurveSymbolList_.Add(esvm);

                }
            }
            catch (Exception)
            {
                //OutputLogViewModel.addResult("index data load error , code : " + code + " date : " + refDate.ToString(StringFormat.DbDateFormat_));
            }

        }

        public override Control view()
        {
            Control v = new Excel_creditCurveLoaderView();

            v.DataContext = this;

            return v;
        }
    }
}
