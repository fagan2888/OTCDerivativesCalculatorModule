using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Excel_Interface
{
    public class Excel_fxLoaderViewModel : Excel_loaderViewModel
    {
        public Excel_fxLoaderViewModel()
        {
            this.definedFxSymbolList_ = new ObservableCollection<Excel_fxSymbolViewModel>();
        }

        #region DefinedFxSymbolList_
        private ObservableCollection<Excel_fxSymbolViewModel> definedFxSymbolList_;
        public ObservableCollection<Excel_fxSymbolViewModel> DefinedFxSymbolList_
        {
            get { return this.definedFxSymbolList_; }
            set
            {
                if (this.definedFxSymbolList_ != value)
                {
                    this.definedFxSymbolList_ = value;
                    //this.NotifyPropertyChanged("DefinedFxSymbolList_");
                }
            }
        }
        #endregion

        public override void loadDefinedSymbolFromDB()
        {
            MARKETDATA_SYMBOL_INFO_Table_DAOManager daoM = new MARKETDATA_SYMBOL_INFO_Table_DAOManager();

            // equity 쪽을 죄다 로드함.

            daoM.KeyColumn_ = "fx".ToUpper();
            daoM.KeyColumn_SYMBOL_TYPE_ = "fx".ToUpper();

            try
            {
                daoM.select(DataBaseConnectManager.ConnectionFactory("myDB"));

                this.definedFxSymbolList_.Clear();

                foreach (var item in daoM.DAOList_)
                {
                    Excel_fxSymbolViewModel esvm = new Excel_fxSymbolViewModel();

                    esvm.setFromDAO(item);

                    this.definedFxSymbolList_.Add(esvm);

                }
            }
            catch (Exception)
            {
                //OutputLogViewModel.addResult("index data load error , code : " + code + " date : " + refDate.ToString(StringFormat.DbDateFormat_));
            }
        }

        public override Control view()
        {
            Control v = new Excel_fxLoaderView();

            v.DataContext = this;

            return v;
        }
    }
}
