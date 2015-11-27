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
    public class OptionGreekPositionViewModel_1928 : INotifyPropertyChanged
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

        public double[] xData_ { get; set; }

        public List<double> call_strikeData_ { get; set; }
        public List<double> put_strikeData_ { get; set; }

        public List<double> call_imvolData_ { get; set; }
        public List<double> put_imvolData_ { get; set; }

        #region OptionViewModelList_
        private ObservableCollection<OptionViewModel_1928> optionViewModelList_;
        public ObservableCollection<OptionViewModel_1928> OptionViewModelList_
        {
            get { return this.optionViewModelList_; }
            set
            {
                if (this.optionViewModelList_ != value)
                {
                    this.optionViewModelList_ = value;
                    this.NotifyPropertyChanged("OptionViewModelList_");
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

        public OptionGreekPositionViewModel_1928()
        {
            this.Calculated_ = false;

            this.optionViewModelList_ = new ObservableCollection<OptionViewModel_1928>();

            this.call_strikeData_ = new List<double>();
            this.put_strikeData_ = new List<double>();

            this.call_imvolData_ = new List<double>();
            this.put_imvolData_ = new List<double>();

            this.gbmParaViewModel_ = new GBMParaViewModel();

            this.gbmParaViewModel_.ReferenceDate_ = DateTime.Now.Date;
        }

        public void loadDataFromExcelSheet(Excel.Worksheet activeWorksheet)
        {
            
            this.optionViewModelList_.Clear();
            this.call_strikeData_.Clear();
            this.put_strikeData_.Clear();
            this.call_imvolData_.Clear();
            this.put_imvolData_.Clear();

            Excel.Range rngColumnA = activeWorksheet.get_Range("A1:A300");

            try
            {
                Excel.Range callNameRng = rngColumnA.Find("종목명");
                Excel.Range callDataRng = callNameRng.CurrentRegion;

                int callOptionCount = callDataRng.Rows.Count;

                for (int i = 1; i < callOptionCount; i++)
                {
                    OPTION_POSITION_1928_Table_DAO dao = new OPTION_POSITION_1928_Table_DAO();

                    dao.POSITIONNAME_ = (string)callNameRng.get_Offset(i, 0).Value;
                    dao.SELLBUY_ = (callNameRng.get_Offset(i, 1).Value2).ToString();
                    dao.UNIT_ = (callNameRng.get_Offset(i, 2).Value2).ToString();
                    dao.EVALAMT_ = (callNameRng.get_Offset(i, 3).Value2).ToString();
                    dao.DELTA_ = (callNameRng.get_Offset(i, 4).Value2).ToString();
                    dao.GAMMA_= (callNameRng.get_Offset(i, 5).Value2).ToString();
                    dao.VEGA_ = (callNameRng.get_Offset(i, 6).Value2).ToString();
                    dao.IMVOL_ = (callNameRng.get_Offset(i, 7).Value2).ToString();
                    dao.DELTAPOSITION_ = (callNameRng.get_Offset(i, 8).Value2).ToString();
                    dao.TOTALRISK_ = (callNameRng.get_Offset(i, 9).Value2).ToString();
                    dao.DELTARISK_ = (callNameRng.get_Offset(i, 10).Value2).ToString();
                    dao.GAMMARISK_ = (callNameRng.get_Offset(i, 11).Value2).ToString();
                    dao.VEGARISK_ = (callNameRng.get_Offset(i, 12).Value2).ToString();
                    dao.DEEPOTM_ = (callNameRng.get_Offset(i, 13).Value2).ToString();
                    dao.REMAINDAYS_ = (callNameRng.get_Offset(i, 14).Value2).ToString();

                    OptionViewModel_1928 ovm_1928 = new OptionViewModel_1928();
                    ovm_1928.Brush_ = BrushesViewModel.BrushList_[i - 1];
                    ovm_1928.build(dao);

                    if (ovm_1928.ImVol_ > 5 )
                    {
                        if (ovm_1928.CallPutEnum_ == Option.Type.Call)
                        {
                            if (!(this.call_strikeData_.Contains(ovm_1928.Strike_)))
                            {
                                this.call_strikeData_.Add(ovm_1928.Strike_);
                                this.call_imvolData_.Add(ovm_1928.ImVol_);
                            }
                        }
                        else if (ovm_1928.CallPutEnum_ == Option.Type.Put)
                        {
                            if (!(this.put_strikeData_.Contains(ovm_1928.Strike_)))
                            {
                                this.put_strikeData_.Add(ovm_1928.Strike_);
                                this.put_imvolData_.Add(ovm_1928.ImVol_);
                            }
                        }
                        else
                        { }
                        
                    }

                    this.optionViewModelList_.Add(ovm_1928);
                    
                }

                Excel.Range kospiNameRng = rngColumnA.Find("KOSPI200");
                this.gbmParaViewModel_.CurrentPrice_ = Convert.ToDouble((kospiNameRng.get_Offset(0, 1).Value2).ToString());

                this.put_strikeData_.Reverse();
                this.put_imvolData_.Reverse();

                this.gbmParaViewModel_.Call_Interpolation_ = this.call_imvolFitting();
                this.gbmParaViewModel_.Put_Interpolation_ = this.put_imvolFitting();

                
            }
            catch (Exception)
            {
                System.Windows.MessageBox.Show("Load PowerBase TR_1928 Data.");
                throw;
            }
        }

        public Control view()
        {
            OptionGreekPositionView_1928 v = new OptionGreekPositionView_1928();

            v.DataContext = this;

            return v;

        }

        public void calculate()
        {
            foreach (var item in this.optionViewModelList_)
            {
                item.calculate(this.xData_,this.gbmParaViewModel_);
            }

            this.Calculated_ = true;
        }

        private Interpolation call_imvolFitting()
        {
            List<double> xGrid = this.call_strikeData_;
            List<double> yGrid = this.call_imvolData_;

            //List<double> xGrid = Enumerable.Range(0, 100);
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

        public bool Calculated_ { get; set; }
    }
}
