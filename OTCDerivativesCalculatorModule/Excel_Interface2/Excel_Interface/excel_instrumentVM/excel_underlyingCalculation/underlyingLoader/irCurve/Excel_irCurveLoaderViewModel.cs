using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Excel_Interface
{
    public class Excel_irCurveLoaderViewModel : Excel_loaderViewModel
    {
        public Excel_irCurveLoaderViewModel()
        {
            this.definedIRCurveSymbolList_ = new ObservableCollection<Excel_irCurveSymbolViewModel>();
        }

        #region DefinedIRCurveSymbolList_
        private ObservableCollection<Excel_irCurveSymbolViewModel> definedIRCurveSymbolList_;
        public ObservableCollection<Excel_irCurveSymbolViewModel> DefinedIRCurveSymbolList_
        {
            get { return this.definedIRCurveSymbolList_; }
            set
            {
                if (this.definedIRCurveSymbolList_ != value)
                {
                    this.definedIRCurveSymbolList_ = value;
                    //this.NotifyPropertyChanged("DefinedEquitySymbolList_");
                }
            }
        }
        #endregion

        public override void loadDefinedSymbolFromDB()
        {
            MARKETDATA_SYMBOL_INFO_Table_DAOManager daoM = new MARKETDATA_SYMBOL_INFO_Table_DAOManager();

            // ir 쪽을 죄다 로드함.

            daoM.KeyColumn_ = "ircurve".ToUpper();
            daoM.KeyColumn_SYMBOL_TYPE_ = "ircurve".ToUpper();

            try
            {
                daoM.select(DataBaseConnectManager.ConnectionFactory("myDB"));

                this.definedIRCurveSymbolList_.Clear();

                foreach (var item in daoM.DAOList_)
                {
                    Excel_irCurveSymbolViewModel eicvm = new Excel_irCurveSymbolViewModel();

                    eicvm.setFromDAO(item);

                    this.definedIRCurveSymbolList_.Add(eicvm);

                }
            }
            catch (Exception)
            {
                //OutputLogViewModel.addResult("index data load error , code : " + code + " date : " + refDate.ToString(StringFormat.DbDateFormat_));
            }
        }

        public override Control view()
        {
            Control v = new Excel_irCurveLoaderView();

            v.DataContext = this;

            return v;
        }
    }
}
