using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using RiskMonitor;

namespace ExcelInterface
{
    public class CorrelationParaXL
    {

        #region ViewModel_
        private CorrelationInfo_paraViewModel viewModel_;
        public CorrelationInfo_paraViewModel ViewModel_
        {
            get { return this.viewModel_; }
            set
            {
                if (this.viewModel_ != value)
                {
                    this.viewModel_ = value;
                }
            }
        }
        #endregion

        public CorrelationParaXL(string[] codeList,
                                 string[,] matrix)
        {
            viewModel_ = new CorrelationInfo_paraViewModel();
            viewModel_.Correlation_paraViewModel_ = new System.Collections.ObjectModel.ObservableCollection<Correlation_paraViewModel>();

            int dimension = codeList.Length;

            viewModel_.Dimension_ = dimension.ToString();

            for (int r = 0; r < dimension; r++)
            {
                for (int c = 0; c < dimension; c++)
                {
                    Correlation_paraViewModel corrParaVM = new Correlation_paraViewModel();

                    corrParaVM.First_ = codeList[r];
                    corrParaVM.Second_ = codeList[c];
                    corrParaVM.Value_ = matrix[r,c];

                    viewModel_.Correlation_paraViewModel_.Add(corrParaVM);
                }
            }

        }

    }
}
