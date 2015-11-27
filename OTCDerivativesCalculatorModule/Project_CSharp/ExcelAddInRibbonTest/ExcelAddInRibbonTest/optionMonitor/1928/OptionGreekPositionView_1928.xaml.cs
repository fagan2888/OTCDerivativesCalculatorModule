using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Research.DynamicDataDisplay;
using Microsoft.Research.DynamicDataDisplay.DataSources;
using Microsoft.Research.DynamicDataDisplay.PointMarkers;
using System.Reflection;

namespace ExcelAddInRibbonTest
{
    /// <summary>
    /// OptionGreekView_1928.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class OptionGreekPositionView_1928 : UserControl
    {
        #region ViewModel_
        private OptionGreekPositionViewModel_1928 viewModel_;
        public OptionGreekPositionViewModel_1928 ViewModel_
        {
            get { return this.viewModel_; }
            set
            {
                if (this.viewModel_ != value)
                {
                    this.viewModel_ = value;
                    //this.NotifyPropertyChanged("ViewModel_");
                }
            }
        }
        #endregion

        public OptionGreekPositionView_1928()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);

            ChartPlotter cp = new ChartPlotter();

            this.drowChartPlotter(cp);

            this.chartGrid_.Children.Add(cp);
        }

        //private void DataGrid_LoadingRow_(object sender, DataGridRowEventArgs e)
        //{
        //    e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        //}

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as OptionGreekPositionViewModel_1928;

            this.bindingPanel_.DataContext = this.viewModel_.GBMParaViewModel_;
            this.OPTION_POSITIONDataGrid_.ItemsSource = this.viewModel_.OptionViewModelList_;



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double[] x = Enumerable.Range(2000, 1000).Select(i => i / 10.0).ToArray();

            this.viewModel_.xData_ = x;

            this.viewModel_.calculate();

            OptionViewModel_1928 sumOption = OptionViewModel_1928.Sum(this.viewModel_.OptionViewModelList_);

            sumOption.convertAbs();

            this.sumBindingPanel_.DataContext = sumOption;

            this.OPTION_POSITIONDataGrid_.Items.Refresh();
        }

        private void drowChartPlotter(ChartPlotter cp)
        {
            this.chartGrid_.Children.Clear();

            Header h = new Header();
            h.Content = "Payoff";
            cp.Children.Add(h);
            VerticalAxisTitle vat = new VerticalAxisTitle();
            vat.Content = "억원";
            HorizontalAxisTitle hat = new HorizontalAxisTitle();
            hat.Content = "P";
            cp.Children.Add(vat);
            cp.Children.Add(hat);

        }

        private void OPTION_POSITIONDataGrid__PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (this.viewModel_.Calculated_)
            {
                ChartPlotter cp = new ChartPlotter();

                this.drowChartPlotter(cp);

                List<OptionViewModel_1928> optionList
                    = this.OPTION_POSITIONDataGrid_.SelectedItems.OfType<OptionViewModel_1928>().ToList();

                //foreach (var item in optionList)
                //{
                //    var xData = item.xData_.AsXDataSource();
                //    var yData = item.yData_.AsYDataSource();

                //    CompositeDataSource compositeDataSource = xData.Join(yData);

                //    LineGraph lineG = new LineGraph(compositeDataSource);

                //    lineG.LinePen = new Pen(item.Brush_, 3);
                //    lineG.Description = new PenDescription(item.Name_);

                //    cp.Children.Add(lineG);


                //}

                int dataLength = this.viewModel_.xData_.Length;
                double[] sumY = Enumerable.Repeat<double>(0.0, dataLength).ToArray<double>();

                foreach (var item in optionList)
                {
                    for (int i = 0; i < dataLength; i++)
                    {
                        sumY[i] = sumY[i] + item.yData_[i] / 100000000.0;
                    }

                }

                var xData = this.viewModel_.xData_.AsXDataSource();
                var yData = sumY.AsYDataSource();

                CompositeDataSource compositeDataSource = xData.Join(yData);

                LineGraph lineG = new LineGraph(compositeDataSource);

                lineG.Description = new PenDescription("합계");

                cp.Children.Add(lineG);


                this.chartGrid_.Children.Add(cp);
            }

            else
            {
                MessageBox.Show("Excute Calculation First!");
            }

            
        }

    }
}
