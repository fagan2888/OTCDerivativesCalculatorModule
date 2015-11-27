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
    /// RedemptionSelectorView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class RedemptionSelectorView : Window
    {
        #region SelectedRedemptionViewModel_
        private EventTriggerViewModel selectedRedemptionViewModel_;
        public EventTriggerViewModel SelectedRedemptionViewModel_
        {
            get { return this.selectedRedemptionViewModel_; }
            set
            {
                if (this.selectedRedemptionViewModel_ != value)
                {
                    this.selectedRedemptionViewModel_ = value;
                    //this.NotifyPropertyChanged("SelectedRedemptionViewModel_");
                }
            }
        }
        #endregion

        //logical tree error 로 인해 추가함 , InvalidOperationException 어쩌구.. 이런 쉬발
        private ContentControl contenControl_;

        public RedemptionSelectorView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void redemptionCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectionStr = sender as string;

            this.selectedRedemptionViewModel_ = new AutoCallConstReturnTriggerViewModel();
            this.DataContext = this.selectedRedemptionViewModel_;

        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.selectedRedemptionViewModel_ = this.DataContext as EventTriggerViewModel;

            contenControl_ = new ContentControl();
            contenControl_.Content = selectedRedemptionViewModel_.View_;

            this.detailGrid_.Children.Clear();

            this.detailGrid_.Children.Add(contenControl_);

        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            this.RemoveLogicalChild(contenControl_);    
        }

    }
}
