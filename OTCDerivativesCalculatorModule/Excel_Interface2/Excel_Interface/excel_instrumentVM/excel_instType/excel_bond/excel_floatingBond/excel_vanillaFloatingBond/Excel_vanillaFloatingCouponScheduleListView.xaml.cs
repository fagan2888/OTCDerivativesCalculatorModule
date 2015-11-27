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
    /// Excel_vanillaFloatingCouponScheduleListView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_vanillaFloatingCouponScheduleListView : UserControl
    {
        #region ViewModel_
        private Excel_vanillaFloatingCouponScheduleListViewModel viewModel_;
        public Excel_vanillaFloatingCouponScheduleListViewModel ViewModel_
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

        public Excel_vanillaFloatingCouponScheduleListView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_vanillaFloatingCouponScheduleListViewModel;
            this.vanillaFloatingScheduleDataGrid_.ItemsSource = this.viewModel_.Excel_vanillaFloatingCouponScheduleViewModel_;
        }
    }
}
