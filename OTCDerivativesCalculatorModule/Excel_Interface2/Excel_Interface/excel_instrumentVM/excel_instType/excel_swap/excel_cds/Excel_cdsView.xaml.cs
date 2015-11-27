﻿using System;
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

namespace Excel_Interface
{
    /// <summary>
    /// Excel_cdsView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_cdsView : UserControl
    {
        #region ViewModel_
        private Excel_cdsViewModel viewModel_;
        public Excel_cdsViewModel ViewModel_
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

        public Excel_cdsView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_cdsViewModel;

            this.issueInfoGrid_.Children.Clear();
            this.issueInfoGrid_.Children.Add(this.viewModel_.Excel_issueInfoViewModel_.view());

            this.swapLegFirstGrid_.Children.Clear();
            this.swapLegFirstGrid_.Children.Add(this.viewModel_.Excel_swapLegViewModel_.view());

            this.swapLegSecondGrid_.Children.Clear();
            this.swapLegSecondGrid_.Children.Add(this.viewModel_.Excel_creditEventSwapLegViewModel_.view());
        }
    }
}