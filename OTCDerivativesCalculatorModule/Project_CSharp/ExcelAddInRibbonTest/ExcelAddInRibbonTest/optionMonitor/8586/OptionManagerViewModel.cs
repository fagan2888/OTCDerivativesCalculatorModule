using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using QLNet;

namespace ExcelAddInRibbonTest
{
    public class OptionManagerViewModel : INotifyPropertyChanged
    {

        #region Event

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        public List<double> call_strikeData_ { get; set; }
        public List<double> put_strikeData_ { get; set; }

        public List<double> call_imvolData_ { get; set; }
        public List<double> put_imvolData_ { get; set; }

        #region CallOptionViewModelList_
        private ObservableCollection<OptionViewModel> callOptionViewModelList_;
        public ObservableCollection<OptionViewModel> CallOptionViewModelList_
        {
            get { return this.callOptionViewModelList_; }
            set
            {
                if (this.callOptionViewModelList_ != value)
                {
                    this.callOptionViewModelList_ = value;
                    this.NotifyPropertyChanged("OptionViewModelList_");
                }
            }
        }
        #endregion

        #region PutOptionViewModelList_
        private ObservableCollection<OptionViewModel> putOptionViewModelList_;
        public ObservableCollection<OptionViewModel> PutOptionViewModelList_
        {
            get { return this.putOptionViewModelList_; }
            set
            {
                if (this.putOptionViewModelList_ != value)
                {
                    this.putOptionViewModelList_ = value;
                    this.NotifyPropertyChanged("PutOptionViewModelList_");
                }
            }
        }
        #endregion

        #region GBMParaViewModel_
        private GBMParaViewModel gbmParaViewModel_;
        public GBMParaViewModel GBMParaViewModel_
        {
            get { return this.gbmParaViewModel_; }
            set
            {
                if (this.gbmParaViewModel_ != value)
                {
                    this.gbmParaViewModel_ = value;
                    this.NotifyPropertyChanged("GBMParaViewModel_");
                }
            }
        }
        #endregion

        public OptionManagerViewModel()
        {
            this.callOptionViewModelList_ = new ObservableCollection<OptionViewModel>();
            this.putOptionViewModelList_ = new ObservableCollection<OptionViewModel>();

            this.call_strikeData_ = new List<double>();
            this.put_strikeData_ = new List<double>();

            this.call_imvolData_ = new List<double>();
            this.put_imvolData_ = new List<double>();

            this.gbmParaViewModel_ = new GBMParaViewModel();

            this.gbmParaViewModel_.ReferenceDate_ = DateTime.Now;
        }

        public void loadDataFromExcelSheet(Excel.Worksheet activeWorksheet)
        {
            this.callOptionViewModelList_.Clear();
            this.putOptionViewModelList_.Clear();

            this.call_strikeData_.Clear();
            this.put_strikeData_.Clear();
            this.call_imvolData_.Clear();
            this.put_imvolData_.Clear();

            Excel.Range rngColumnA = activeWorksheet.get_Range("A1:A300");

            try
            {
                Excel.Range callNameRng = rngColumnA.Find("콜옵션 종목명");
                Excel.Range callDataRng = callNameRng.CurrentRegion;

                int callOptionCount = callDataRng.Rows.Count;

                OptionViewModel sumCallOVM = new OptionViewModel();

                for (int i = 1; i < callOptionCount; i++)
                {
                    OPTION_POSITION_Table_DAO dao = new OPTION_POSITION_Table_DAO();

                    dao.POSITIONNAME_ = (string)callNameRng.get_Offset(i, 0).Value;
                    dao.CURRPRICE_ = (callNameRng.get_Offset(i, 1).Value2).ToString();
                    dao.PREDIFF_ = (callNameRng.get_Offset(i, 2).Value2).ToString();
                    dao.PREDIFFRATE_ = (callNameRng.get_Offset(i, 3).Value2).ToString();
                    dao.CURRPRICE2_ = (callNameRng.get_Offset(i, 4).Value2).ToString();
                    dao.PREDIFF2_ = (callNameRng.get_Offset(i, 5).Value2).ToString();
                    dao.PREDIFFRATE2_ = (callNameRng.get_Offset(i, 6).Value2).ToString();
                    dao.TRADINGAMT_ = (callNameRng.get_Offset(i, 7).Value2).ToString();
                    dao.IMVOL_ = (callNameRng.get_Offset(i, 8).Value2).ToString();
                    dao.GREEK_DELTA_ = (callNameRng.get_Offset(i, 9).Value2).ToString();
                    dao.GREEK_GAMMA_ = (callNameRng.get_Offset(i, 10).Value2).ToString();
                    dao.GREEK_VEGA_ = (callNameRng.get_Offset(i, 11).Value2).ToString();
                    dao.GREEK_THETA_ = (callNameRng.get_Offset(i, 12).Value2).ToString();
                    dao.GREEK_RHO_ = (callNameRng.get_Offset(i, 13).Value2).ToString();
                    dao.TRADINGVALUE_ = (callNameRng.get_Offset(i, 14).Value2).ToString();
                    dao.REMAINAMT_ = (callNameRng.get_Offset(i, 15).Value2).ToString();
                    dao.REMAINAMTPREDIFF_ = (callNameRng.get_Offset(i, 16).Value2).ToString();

                    OptionViewModel ovm = new OptionViewModel();
                    ovm.build(dao);

                    if (ovm.ImVol_ > 5)
                    {
                        if (!(this.call_strikeData_.Contains(ovm.Strike_)))
                        {
                            this.call_strikeData_.Add(ovm.Strike_);
                            this.call_imvolData_.Add(ovm.ImVol_);
                        }
                    }

                    this.callOptionViewModelList_.Add(ovm);
                    
                }

                Excel.Range putNameRng = rngColumnA.Find("풋옵션 종목명");
                Excel.Range putDataRng = callNameRng.CurrentRegion;

                int putOptionCount = putDataRng.Rows.Count;

                for (int i = 1; i < putOptionCount; i++)
                {
                    OPTION_POSITION_Table_DAO dao = new OPTION_POSITION_Table_DAO();

                    dao.POSITIONNAME_ = (string)putNameRng.get_Offset(i, 0).Value;
                    dao.CURRPRICE_ = (putNameRng.get_Offset(i, 1).Value2).ToString();
                    dao.PREDIFF_ = (putNameRng.get_Offset(i, 2).Value2).ToString();
                    dao.PREDIFFRATE_ = (putNameRng.get_Offset(i, 3).Value2).ToString();
                    dao.CURRPRICE2_ = (putNameRng.get_Offset(i, 4).Value2).ToString();
                    dao.PREDIFF2_ = (putNameRng.get_Offset(i, 5).Value2).ToString();
                    dao.PREDIFFRATE2_ = (putNameRng.get_Offset(i, 6).Value2).ToString();
                    dao.TRADINGAMT_ = (putNameRng.get_Offset(i, 7).Value2).ToString();
                    dao.IMVOL_ = (putNameRng.get_Offset(i, 8).Value2).ToString();
                    dao.GREEK_DELTA_ = (putNameRng.get_Offset(i, 9).Value2).ToString();
                    dao.GREEK_GAMMA_ = (putNameRng.get_Offset(i, 10).Value2).ToString();
                    dao.GREEK_VEGA_ = (putNameRng.get_Offset(i, 11).Value2).ToString();
                    dao.GREEK_THETA_ = (putNameRng.get_Offset(i, 12).Value2).ToString();
                    dao.GREEK_RHO_ = (putNameRng.get_Offset(i, 13).Value2).ToString();
                    dao.TRADINGVALUE_ = (putNameRng.get_Offset(i, 14).Value2).ToString();
                    dao.REMAINAMT_ = (putNameRng.get_Offset(i, 15).Value2).ToString();
                    dao.REMAINAMTPREDIFF_ = (putNameRng.get_Offset(i, 16).Value2).ToString();

                    OptionViewModel ovm = new OptionViewModel();
                    ovm.build(dao);

                    if (ovm.ImVol_ > 5)
                    {
                        if (!(this.put_strikeData_.Contains(ovm.Strike_)))
                        {
                            this.put_strikeData_.Add(ovm.Strike_);
                            this.put_imvolData_.Add(ovm.ImVol_);
                        }
                    }

                    this.putOptionViewModelList_.Add(ovm);

                }

                this.gbmParaViewModel_.CurrentPrice_ = (this.call_strikeData_[0] + this.call_strikeData_[this.call_strikeData_.Count - 1]) / 2;

                this.call_strikeData_.Reverse();
                this.call_imvolData_.Reverse();

                this.put_strikeData_.Reverse();
                this.put_imvolData_.Reverse();

                this.gbmParaViewModel_.Call_Interpolation_ = this.call_imvolFitting();
                this.gbmParaViewModel_.Put_Interpolation_ = this.put_imvolFitting();

            }
            catch (Exception)
            {
                System.Windows.MessageBox.Show("Load PowerBase TR_8586 Data.");
                throw;
            }
        }

        public Control view()
        {

            OptionViewManager v = new OptionViewManager();

            v.DataContext = this;

            return v;

        }

        private Interpolation call_imvolFitting()
        {
            List<double> xGrid = this.call_strikeData_;
            List<double> yGrid = this.call_imvolData_;

            //List<double> xGrid = Enumerable.Range(0, 100);
            //LinearInterpolation cubic = new LinearInterpolation(xGrid, xGrid.Count, yGrid,
            //                                                    CubicInterpolation.DerivativeApprox.Kruger, true,
            //                                                    CubicInterpolation.BoundaryCondition.SecondDerivative, 0.0,
            //                                                    CubicInterpolation.BoundaryCondition.SecondDerivative, 0.0);

            LinearInterpolation cubic = new LinearInterpolation(xGrid, xGrid.Count, yGrid);

            return cubic;

        }

        private Interpolation put_imvolFitting()
        {
            List<double> xGrid = this.put_strikeData_;
            List<double> yGrid = this.put_imvolData_;

            //List<double> xGrid = Enumerable.Range(0, 100);
            LinearInterpolation cubic = new LinearInterpolation(xGrid, xGrid.Count, yGrid);
            return cubic;

        }

        public void calculate()
        {
            foreach (var item in this.callOptionViewModelList_)
            {
                item.calculate(this.gbmParaViewModel_);
            }

            foreach (var item in this.putOptionViewModelList_)
            {
                item.calculate(this.gbmParaViewModel_);
            }
        }
    }
}
