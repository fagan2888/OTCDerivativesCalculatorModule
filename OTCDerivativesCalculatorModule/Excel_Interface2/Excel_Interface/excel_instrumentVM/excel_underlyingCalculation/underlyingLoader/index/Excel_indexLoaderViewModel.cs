using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;


namespace Excel_Interface
{
    public class Excel_indexLoaderViewModel : Excel_loaderViewModel
    {
        public Excel_indexLoaderViewModel()
        {
            this.definedIndexSymbolList_ = new ObservableCollection<Excel_indexSymbolViewModel>();
        }

        #region DefinedIndexSymbolList_
        private ObservableCollection<Excel_indexSymbolViewModel> definedIndexSymbolList_;
        public ObservableCollection<Excel_indexSymbolViewModel> DefinedIndexSymbolList_
        {
            get { return this.definedIndexSymbolList_; }
            set
            {
                if (this.definedIndexSymbolList_ != value)
                {
                    this.definedIndexSymbolList_ = value;
                    //this.NotifyPropertyChanged("DefinedIndexSymbolList_");
                }
            }
        }
        #endregion

        public override void loadDefinedSymbolFromDB()
        {
            MARKETDATA_SYMBOL_INFO_Table_DAOManager daoM = new MARKETDATA_SYMBOL_INFO_Table_DAOManager();

            // equity 쪽을 죄다 로드함.

            daoM.KeyColumn_ = "index".ToUpper();
            daoM.KeyColumn_SYMBOL_TYPE_ = "index".ToUpper();

            try
            {
                daoM.select(DataBaseConnectManager.ConnectionFactory("myDB"));

                this.definedIndexSymbolList_.Clear();

                foreach (var item in daoM.DAOList_)
                {
                    Excel_indexSymbolViewModel esvm = new Excel_indexSymbolViewModel();

                    esvm.setFromDAO(item);

                    this.definedIndexSymbolList_.Add(esvm);

                }
            }
            catch (Exception)
            {
                //OutputLogViewModel.addResult("index data load error , code : " + code + " date : " + refDate.ToString(StringFormat.DbDateFormat_));
            }
        }

        public override System.Windows.Controls.Control view()
        {
            Control v = new Excel_indexLoaderView();

            v.DataContext = this;

            return v;
        }
    }
}
