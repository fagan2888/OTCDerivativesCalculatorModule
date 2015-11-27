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

namespace RiskMonitor
{
    /// <summary>
    /// StandardStreamView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class StandardStreamView : UserControl
    {

        #region ViewModel_
        private StandardStreamViewModel viewModel_;
        public StandardStreamViewModel ViewModel_
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

        public StandardStreamView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as StandardStreamViewModel;

            this.ScheduleGrid_.Children.Clear();

            this.ScheduleGrid_.Children.Add(this.viewModel_.ScheduleInfoViewModel_.View_);

            this.IRCalculationDataGrid_.ItemsSource = this.viewModel_.IRCalculationViewModel_;
        }
    }
}