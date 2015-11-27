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

namespace RiskMonitor
{
    /// <summary>
    /// InstrumentSelectorView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class InstrumentSelectorView : Window
    {
        #region ViewModel_
        private InstrumentSelectorViewModel viewModel_;
        public InstrumentSelectorViewModel ViewModel_
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

        #region SelectedInstBaseVM_
        private InstrumentBaseViewModel selectedInstVaseVM_;
        public InstrumentBaseViewModel SelectedInstBaseVM_
        {
            get { return this.selectedInstVaseVM_; }
            set
            {
                if (this.selectedInstVaseVM_ != value)
                {
                    this.selectedInstVaseVM_ = value;
                }
            }
        }
        #endregion

        public InstrumentSelectorView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as InstrumentSelectorViewModel;

            Dictionary<string,InstrumentBaseViewModel>.ValueCollection valueList
                = new Dictionary<string, InstrumentBaseViewModel>.ValueCollection(this.viewModel_.PrototypeList_);

            this.prototypeDataGrid_.ItemsSource = valueList;
            
        }

        private void prototypeDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            RiskMonitor.InstrumentBaseViewModel selectedVM = this.prototypeDataGrid_.SelectedItem as RiskMonitor.InstrumentBaseViewModel;
            this.selectedInstVaseVM_ = selectedVM;

            selectedVM.loadSample();

            this.Close();
        }

    }
}
