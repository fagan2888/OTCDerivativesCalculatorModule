using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;


namespace Excel_Interface
{
    public class Excel_irLoaderViewModel : Excel_loaderViewModel
    {
        public Excel_irLoaderViewModel()
        {
            this.definedIRSymbolList_ = new ObservableCollection<Excel_irSymbolViewModel>();

        }

        #region DefinedIRSymbolList_
        private ObservableCollection<Excel_irSymbolViewModel> definedIRSymbolList_;
        public ObservableCollection<Excel_irSymbolViewModel> DefinedIRSymbolList_
        {
            get { return this.definedIRSymbolList_; }
            set
            {
                if (this.definedIRSymbolList_ != value)
                {
                    this.definedIRSymbolList_ = value;
                    //this.NotifyPropertyChanged("DefinedIRSymbolList_");
                }
            }
        }
        #endregion

        public override void loadDefinedSymbolFromDB()
        {
            MARKETDATA_SYMBOL_INFO_Table_DAOManager daoM = new MARKETDATA_SYMBOL_INFO_Table_DAOManager();

            // equity 쪽을 죄다 로드함.

            daoM.KeyColumn_ = "ir".ToUpper();
            daoM.KeyColumn_SYMBOL_TYPE_ = "ir".ToUpper();

            try
            {
                daoM.select(DataBaseConnectManager.ConnectionFactory("myDB"));

                this.definedIRSymbolList_.Clear();

                foreach (var item in daoM.DAOList_)
                {
                    Excel_irSymbolViewModel esvm = new Excel_irSymbolViewModel();

                    esvm.setFromDAO(item);

                    this.definedIRSymbolList_.Add(esvm);

                }
            }
            catch (Exception)
            {
                //OutputLogViewModel.addResult("index data load error , code : " + code + " date : " + refDate.ToString(StringFormat.DbDateFormat_));
            }
        }

        public override Control view()
        {
            Control v = new Excel_irLoaderView();

            v.DataContext = this;

            return v;
        }
    }
}
