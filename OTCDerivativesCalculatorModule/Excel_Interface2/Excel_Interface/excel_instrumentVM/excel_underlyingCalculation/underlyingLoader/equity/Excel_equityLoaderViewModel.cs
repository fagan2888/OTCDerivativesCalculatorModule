using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;


namespace Excel_Interface
{
    public class Excel_equityLoaderViewModel : Excel_loaderViewModel
    {

        public Excel_equityLoaderViewModel()
        {
            this.definedEquitySymbolList_ = new ObservableCollection<Excel_equitySymbolViewModel>();
        }

        #region DefinedEquitySymbolList_
        private ObservableCollection<Excel_equitySymbolViewModel> definedEquitySymbolList_;
        public ObservableCollection<Excel_equitySymbolViewModel> DefinedEquitySymbolList_
        {
            get { return this.definedEquitySymbolList_; }
            set
            {
                if (this.definedEquitySymbolList_ != value)
                {
                    this.definedEquitySymbolList_ = value;
                    //this.NotifyPropertyChanged("DefinedEquitySymbolList_");
                }
            }
        }
        #endregion

        public override void loadDefinedSymbolFromDB()
        {
            MARKETDATA_SYMBOL_INFO_Table_DAOManager daoM = new MARKETDATA_SYMBOL_INFO_Table_DAOManager();

            // equity 쪽을 죄다 로드함.

            daoM.KeyColumn_ = "equity".ToUpper();
            daoM.KeyColumn_SYMBOL_TYPE_ = "equity".ToUpper();

            try
            {
                daoM.select(DataBaseConnectManager.ConnectionFactory("myDB"));

                this.definedEquitySymbolList_.Clear();

                foreach (var item in daoM.DAOList_)
                {
                    Excel_equitySymbolViewModel esvm = new Excel_equitySymbolViewModel();

                    esvm.setFromDAO(item);

                    this.definedEquitySymbolList_.Add(esvm);
                    
                }
            }
            catch (Exception)
            {
                //OutputLogViewModel.addResult("index data load error , code : " + code + " date : " + refDate.ToString(StringFormat.DbDateFormat_));
            }

        }

        public override Control view()
        {
            Control v = new Excel_equityLoaderView();

            v.DataContext = this;

            return v;
        }

    }
}
